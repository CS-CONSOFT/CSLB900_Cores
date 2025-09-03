using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
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

        public AlteracaoDataVencimentoRepositoryImpl(
            AppDbContext appDbContext,
            IGravaOcorrencia gravaOcorrenciaRepository)
        {
            _appDbContext = appDbContext;
            _gravaOcorrenciaRepository = gravaOcorrenciaRepository;
        }

        public async Task<bool> ExecutarAlteracaoDataVencimento(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(parametros);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(parametros);

                // Valida regras de negócio
                ValidaSituacao(titulo, parametros);

                // Atualiza data de vencimento do título
                titulo.Ff102DataVencimento = parametros.InNovaDataVencimento!.Value;
                titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
                titulo.Ff102CodigoBarras = "";
                titulo.Ff102Linhadigital = "";

                // Grava ocorrência
                await _gravaOcorrenciaRepository.GravaOcorrenciaPrms(parametros);

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

            if (string.IsNullOrEmpty(parametros.InFF102TituloID))
                throw new ArgumentException("ID do título é obrigatório", nameof(parametros.InFF102TituloID));

            if (string.IsNullOrEmpty(parametros.InUsuarioPropID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(parametros.InUsuarioPropID));

        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmGravaOcorrencia parametros, int in_tenantID)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .FirstOrDefaultAsync(e => e.TenantId == in_tenantID && e.Id == parametros.InFF102TituloID);

            return titulo ?? throw new KeyNotFoundException("Título não encontrado");
        }

        private static void ValidaSituacao(CSICP_FF102 titulo, PrmGravaOcorrencia parametros)
        {
            // Validação 1: Situação deve estar Aberto
            if (titulo.Ff102Situacaoid != parametros.InStIDFF102SitAberto)
            {
                throw new InvalidOperationException("O título precisa estar 'Aberto' para continuar a operação!");
            }

            // Validação 2: Nova data de vencimento não pode ser menor que data de emissão nem data atual
            if (parametros.InNovaDataVencimento < titulo.Ff102DataEmissao ||
                parametros.InNovaDataVencimento < DateTime.Now.Date)
            {
                throw new InvalidOperationException("A nova data de vencimento não pode ser menor que a data de emissão, nem menor que a data atual.");
            }
        }
    }
}