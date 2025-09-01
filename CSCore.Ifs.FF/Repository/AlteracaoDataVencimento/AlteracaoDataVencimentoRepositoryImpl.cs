using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public class AlteracaoDataVencimentoRepositoryImpl : IAlteracaoDataVencimentoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IStaticaLabelRepository _staticaLabelRepository;

        public AlteracaoDataVencimentoRepositoryImpl(
            AppDbContext appDbContext, 
            ICS_GenerateId generateId, 
            IStaticaLabelRepository staticaLabelRepository)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _staticaLabelRepository = staticaLabelRepository;
        }

        public async Task<bool> ExecutarAlteracaoDataVencimento(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(InPrmAlteracaoDataVencimento);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(InPrmAlteracaoDataVencimento);

                // Valida regras de negócio
                await ValidaRegras(titulo, InPrmAlteracaoDataVencimento);

                // Grava ocorrência
                GravaOcorrencia(titulo, InPrmAlteracaoDataVencimento);

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

        private static void ValidarParametros(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            if (InPrmAlteracaoDataVencimento == null)
                throw new ArgumentNullException(nameof(InPrmAlteracaoDataVencimento), "Parâmetro de entrada não pode ser nulo");

            if (string.IsNullOrEmpty(InPrmAlteracaoDataVencimento.InFF102ID))
                throw new ArgumentException("ID do título é obrigatório", nameof(InPrmAlteracaoDataVencimento.InFF102ID));

            if (string.IsNullOrEmpty(InPrmAlteracaoDataVencimento.InUsuarioID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(InPrmAlteracaoDataVencimento.InUsuarioID));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == InPrmAlteracaoDataVencimento.InTenantID
                       && e.Id == InPrmAlteracaoDataVencimento.InFF102ID)
                .FirstOrDefaultAsync();

            if (titulo == null)
                throw new KeyNotFoundException("Título não encontrado");

            return titulo;
        }

        private async Task ValidaRegras(CSICP_FF102 titulo, PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            // Validação 1: Situação deve estar Aberto
            if (titulo.Ff102Situacaoid != InPrmAlteracaoDataVencimento.InStIDFF102SitAberto)
            {
                throw new InvalidOperationException("O título precisa estar 'Aberto' para continuar a operação!");
            }

            // Validação 2: Nova data de vencimento não pode ser menor que data de emissão nem data atual
            if (InPrmAlteracaoDataVencimento.InNovaDataVencimento < titulo.Ff102DataEmissao ||
                InPrmAlteracaoDataVencimento.InNovaDataVencimento < DateTime.Now.Date)
            {
                throw new InvalidOperationException("A nova data de vencimento não pode ser menor que a data de emissão, nem menor que a data atual.");
            }

            await ValidaRegras(titulo, InPrmAlteracaoDataVencimento);
        }

        private void GravaOcorrencia(CSICP_FF102 titulo, PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            var ocorrencia = new CSICP_FF116
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InPrmAlteracaoDataVencimento.InTenantID,
                Ff116Novovencto = InPrmAlteracaoDataVencimento.InNovaDataVencimento,
                Ff116Datamovto = DateTime.UtcNow.ToLocalTime(),
                Ff116Usuariopropid = InPrmAlteracaoDataVencimento.InUsuarioID,
            };

            _appDbContext.Add(ocorrencia);
        }
    }
}