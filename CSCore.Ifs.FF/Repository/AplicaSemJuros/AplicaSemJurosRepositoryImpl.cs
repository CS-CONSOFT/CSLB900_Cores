using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
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

        public AplicaSemJurosRepositoryImpl(
            AppDbContext appDbContext, 
            IGravaOcorrencia gravaOcorrenciaRepository)
        {
            _appDbContext = appDbContext;
            _gravaOcorrenciaRepository = gravaOcorrenciaRepository;
        }

        public async Task<bool> ExecutarAplicaSemJuros(PrmGravaOcorrencia parametros)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(parametros);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(parametros);

                // Valida regras de negócio
                ValidarSituacao(titulo, parametros);

                // Aplica não cobrança de juros
                AplicarNaoCobrancaJuros(titulo, parametros);

                // Define propriedades específicas para ocorrência
                parametros.DataVencimento = titulo.Ff102DataVencimento;
                parametros.NovaDataVencimento = titulo.Ff102DataVencimento;
                parametros.ValorAntigo = titulo.Ff102ValorTitulo;
                parametros.ValorNovo = titulo.Ff102ValorTitulo;
                parametros.TipoOperacao = TipoOperacaoOcorrencia.AplicaSemJuros;
                parametros.TipoMovimento = parametros.InStIDNCobraJuros;

                // Grava ocorrência
                _gravaOcorrenciaRepository.GravaOcorrenciaPrms(parametros);

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

        private static void ValidarParametros(PrmGravaOcorrencia parametros)
        {
            ArgumentNullException.ThrowIfNull(parametros);

            if (parametros.InTenantID <= 0)
                throw new ArgumentException("ID do tenant deve ser maior que zero", nameof(parametros.InTenantID));

            if (string.IsNullOrEmpty(parametros.InFF102ID))
                throw new ArgumentException("ID do título é obrigatório", nameof(parametros.InFF102ID));

            if (string.IsNullOrEmpty(parametros.InUsuarioID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(parametros.InUsuarioID));

            if (!parametros.InStIDNCobraJuros.HasValue)
                throw new ArgumentException("Status de não cobrança de juros é obrigatório", nameof(parametros.InStIDNCobraJuros));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmGravaOcorrencia parametros)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .FirstOrDefaultAsync(e => e.TenantId == parametros.InTenantID && e.Id == parametros.InFF102ID);

            return titulo ?? throw new KeyNotFoundException("Título não encontrado");
        }

        private static void ValidarSituacao(CSICP_FF102 titulo, PrmGravaOcorrencia parametros)
        {
            // Validação 1: Situação deve estar Aberto ou Baixa Parcial
            if (titulo.Ff102Situacaoid != parametros.InStIDFF102SitAberto &&
                titulo.Ff102Situacaoid != parametros.InStIDFF102SitBxParcial)
            {
                throw new InvalidOperationException("O Título precisa estar aberto ou em Baixa Parcial!");
            }

            // Validação 2: Não deve ter sido aplicado anteriormente
            if (titulo.Ff102SitespecialId != null)
            {
                throw new InvalidOperationException("Este Título já foi aplicado Juros/Multa não cobrado!");
            }
        }

        private static void AplicarNaoCobrancaJuros(CSICP_FF102 titulo, PrmGravaOcorrencia parametros)
        {
            titulo.Ff102SitespecialId = parametros.InStIDNCobraJuros;
            titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
        }
    }
}