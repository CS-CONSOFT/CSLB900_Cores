using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloEstornar
{
    public class MovtoTituloEstornar : IMovtoTituloEstornar
    {
        private const string PdvWebLabel = "PDV Web";
        private readonly AppDbContext _appDbContext;

        public MovtoTituloEstornar(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<bool> Executar(string InFF103ID, int InTenantID)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF103? WorkFF103 = await _appDbContext.OsusrE9aCsicpFf103s
               .Where(e => e.TenantId == InTenantID && e.Id == InFF103ID)
               .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Movimento não encontrado para Baixa!");

                ValidarEstornoMovimento(WorkFF103);

                WorkFF103.Ff103Estornado = true;
                WorkFF103.Ff103Flagregistro = 1; // Estornado

                await _appDbContext.SaveChangesAsync();

                //CS_TituloCalculoBaixa

                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is KeyNotFoundException) throw new KeyNotFoundException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                if (ex is InvalidOperationException) throw new InvalidOperationException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private static void ValidarEstornoMovimento(CSICP_FF103 WorkFF103)
        {
            if (WorkFF103.Ff103ObjBxId == PdvWebLabel || WorkFF103.Ff103ObjBxLabel == "BXPER")
                throw new InvalidOperationException(WorkFF103.Ff103ObjBxLabel == PdvWebLabel ? "O Estorno de baixas do PDV, somente poderá ser estornada pelo PDV!" : "O Estorno de baixas via Permuta, não poderá ser estornado!");

            if (WorkFF103.Ff103Baixado == false)
                throw new InvalidOperationException("O Estorno não pode ser efetuado, movimento não está Baixado!");

            if (WorkFF103.Ff103Estornado == true)
                throw new InvalidOperationException("Não é possivel o Estorno, movimento já foi estornado!");

            if (WorkFF103.Ff103Cancelado == true)
                throw new InvalidOperationException("Não é possivel o Estorno, movimento está cancelado!");
        }
    }
}
