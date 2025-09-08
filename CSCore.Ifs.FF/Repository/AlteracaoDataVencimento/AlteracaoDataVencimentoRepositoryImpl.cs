using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.GravaOcorrencia;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public class AlteracaoDataVencimentoRepositoryImpl : IAlteracaoDataVencimentoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IGravaOcorrencia _gravaOcorrenciaRepository;
        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;

        public AlteracaoDataVencimentoRepositoryImpl(
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

        public async Task<bool> ExecutarAlteracaoDataVencimento(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(InprmsAltDataVenc);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(InprmsAltDataVenc);

                // Valida regras de negócio
                ValidaSituacao(titulo, InprmsAltDataVenc);

                // Gera protocolo
                /*var protocolNumber = await _generateProtocolo.Fcn_Protocolo10(
                    InprmsAltDataVenc.InFilialID ?? string.Empty,
                    "O_CR");*/

                var protocolNumber = await _generateProtocolo
                    .Fcn_ProtocoloGeral(InprmsAltDataVenc.InFilialID ?? string.Empty, InprmsAltDataVenc.InTenantID);

                var ocorrencia = new CSICP_FF116
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = InprmsAltDataVenc.InTenantID,
                    Ff116Filialid = titulo.Ff102Filialid,
                    Ff116Usuariopropid = InprmsAltDataVenc.InUsuarioPropID,
                    Ff102Tituloid = InprmsAltDataVenc.InFF102TituloID,
                    Ff116Tipomovto = InprmsAltDataVenc.InStIDProrrogar,
                    Ff116Datavencto = titulo.Ff102DataVencimento,
                    Ff116Novovencto = InprmsAltDataVenc.InNovaDataVencimento,
                    Ff116Protocolnumber = protocolNumber.ToString(),
                };

                // Grava ocorrência
                await _gravaOcorrenciaRepository.GravaOcorrenciaPrms(ocorrencia);

                // Atualiza data de vencimento do título
                titulo.Ff102DataVencimento = InprmsAltDataVenc.InNovaDataVencimento;
                titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();

                titulo.Ff102CodigoBarras = "";
                titulo.Ff102Linhadigital = "";

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

        private static void ValidarParametros(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc)
        {
            ArgumentNullException.ThrowIfNull(InprmsAltDataVenc);

            if (InprmsAltDataVenc.InTenantID <= 0)
                throw new ArgumentException("ID do tenant deve ser maior que zero", nameof(InprmsAltDataVenc.InTenantID));

            if (string.IsNullOrEmpty(InprmsAltDataVenc.InFF102TituloID))
                throw new ArgumentException("ID do título é obrigatório", nameof(InprmsAltDataVenc.InFF102TituloID));

            if (string.IsNullOrEmpty(InprmsAltDataVenc.InUsuarioPropID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(InprmsAltDataVenc.InUsuarioPropID));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .FirstOrDefaultAsync(e => e.TenantId == InprmsAltDataVenc.InTenantID 
                                        && e.Id == InprmsAltDataVenc.InFF102TituloID);

            return titulo ?? throw new KeyNotFoundException("Título não encontrado");
        }

        private static void ValidaSituacao(CSICP_FF102 titulo, PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc)
        {
            // Validação 1: Situação deve estar Aberto
            if (titulo.Ff102Situacaoid != InprmsAltDataVenc.InStIDFF102SitAberto)
            {
                throw new InvalidOperationException("O título precisa estar 'Aberto' para continuar a operação!");
            }

            // Validação 2: Nova data de vencimento não pode ser menor que data de emissão nem data atual
            if (InprmsAltDataVenc.InNovaDataVencimento < titulo.Ff102DataEmissao ||
                InprmsAltDataVenc.InNovaDataVencimento < DateTime.Now.Date)
            {
                throw new InvalidOperationException("A nova data de vencimento não pode ser menor que a data de emissão, nem menor que a data atual.");
            }
        }
    }
}