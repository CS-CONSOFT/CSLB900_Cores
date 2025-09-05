using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.GravaOcorrencia;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public class AplicaSemJurosRepositoryImpl : IAplicaSemJurosRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IGravaOcorrencia _gravaOcorrenciaRepository;
        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;


        public AplicaSemJurosRepositoryImpl(
            AppDbContext appDbContext, 
            IGravaOcorrencia gravaOcorrenciaRepository,
            ICS_GenerateId generateId,
            IGenerateProtocolo generateProtocolo)
        {
            _appDbContext = appDbContext;
            _gravaOcorrenciaRepository = gravaOcorrenciaRepository;
            _generateId = generateId;
            _generateProtocolo = generateProtocolo;
        }

        public async Task<bool> ExecutarAplicaSemJuros(PrmsAnaliseSemJurosRepository prmsAnaliseSJuros)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(prmsAnaliseSJuros);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(prmsAnaliseSJuros);

                // Valida regras de negócio
                ValidarSituacao(titulo, prmsAnaliseSJuros);

                var protocolNumber = await _generateProtocolo.Fcn_Protocolo10(
                    prmsAnaliseSJuros.InFilialID ?? string.Empty,
                    "O_CR");

                var ocorrencia = new CSICP_FF116
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = prmsAnaliseSJuros.InTenantID, 
                    Ff116Tipomovto = prmsAnaliseSJuros.InStIDNCobraJuros,
                    Ff116Filialid = titulo.Ff102Filialid,
                    Ff116Usuariopropid = prmsAnaliseSJuros.InUsuarioPropID,
                    Ff102Tituloid = prmsAnaliseSJuros.InFF102TituloID, 
                    Ff116Datavencto = null,
                    Ff116Protocolnumber = protocolNumber.ToString(),
                    Ff116Msg = $"Aplica não cobrança de juros - Motivo: {prmsAnaliseSJuros.InMsgMotivo}".Substring(0, 100)
                };

                // Grava ocorrência
                await _gravaOcorrenciaRepository.GravaOcorrenciaPrms(ocorrencia);

                // Aplica não cobrança de juros
                AplicarNaoCobrancaJuros(titulo, prmsAnaliseSJuros);

                // Salva alterações
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private static void ValidarParametros(PrmsAnaliseSemJurosRepository prmsAnalise)
        {
            ArgumentNullException.ThrowIfNull(prmsAnalise);

            if (prmsAnalise.InTenantID <= 0)
                throw new ArgumentException("ID do tenant deve ser maior que zero", nameof(prmsAnalise.InTenantID));

            if (string.IsNullOrEmpty(prmsAnalise.InFF102TituloID))
                throw new ArgumentException("ID do título é obrigatório", nameof(prmsAnalise.InFF102TituloID));

            if (string.IsNullOrEmpty(prmsAnalise.InUsuarioPropID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(prmsAnalise.InUsuarioPropID));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmsAnaliseSemJurosRepository prmsAnalise)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .FirstOrDefaultAsync(e => e.TenantId == prmsAnalise.InTenantID && e.Id == prmsAnalise.InFF102TituloID);

            return titulo ?? throw new KeyNotFoundException("Título não encontrado");
        }

        private static void ValidarSituacao(CSICP_FF102 titulo, PrmsAnaliseSemJurosRepository prmsAnalise)
        {
            // Validação 1: Situação deve estar Aberto ou Baixa Parcial
            if (titulo.Ff102Situacaoid != prmsAnalise.InStIDFF102SitAberto &&
                titulo.Ff102Situacaoid != prmsAnalise.InStIDFF102SitBxParcial)
            {
                throw new InvalidOperationException("O Título precisa estar aberto ou em Baixa Parcial!");
            }

            // Validação 2: Não deve ter sido aplicado anteriormente
            if (titulo.Ff102SitespecialId != null)
            {
                throw new InvalidOperationException("Este Título já foi aplicado Juros/Multa não cobrado!");
            }
        }

        private static void AplicarNaoCobrancaJuros(CSICP_FF102 titulo, PrmsAnaliseSemJurosRepository prmsAnalise)
        {
            titulo.Ff102SitespecialId = prmsAnalise.InStIDNCobraJuros;
            titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
        }
    }
}