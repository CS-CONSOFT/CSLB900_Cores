using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloBaixar_Kernel;
using CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloEstornar;
using CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.CS_MovtoTituloEstornar
{
    public class MovtoTituloEstornar : IMovtoTituloEstornar
    {
        private const string PdvWebLabel = "PDV Web";
        private readonly AppDbContext _appDbContext;
        private readonly ITituloCalculoBaixa _tituloCalculoBaixa;
        public MovtoTituloEstornar(AppDbContext appDbContext, ITituloCalculoBaixa tituloCalculoBaixa)
        {
            _appDbContext = appDbContext;
            _tituloCalculoBaixa = tituloCalculoBaixa;
        }

        public async Task<bool> Executar(PrmTituloEstornar InPrmTituloEstornar)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF103? WorkFF103 = await _appDbContext.OsusrE9aCsicpFf103s
               .Where(e => e.TenantId == InPrmTituloEstornar.InTenantID && e.Id == InPrmTituloEstornar.InFF103ID)
               .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Movimento não encontrado para Baixa!");

                ValidarEstornoMovimento(WorkFF103);

                WorkFF103.Ff103Estornado = true;
                WorkFF103.Ff103Flagregistro = 1; // Estornado

                await _appDbContext.SaveChangesAsync();

                PrmEntradaCalculoBaixa prmEntradaCalculoBaixa = new PrmEntradaCalculoBaixa
                {
                    InTenantID = InPrmTituloEstornar.InTenantID,
                    InSTIDFF102Liquidado = InPrmTituloEstornar.InSTIDFF102Liquidado_tituloCalcBaixa,
                    InSTIDFF102BxParcial = InPrmTituloEstornar.InSTIDFF102BxParcial_tituloCalcBaixa,
                    InSTIDFF102Aberto = InPrmTituloEstornar.InSTIDFF102Aberto_tituloCalcBaixa,
                    InSTIDFF103TpBaiCancelamento = InPrmTituloEstornar.InSTIDFF103TpBaiCancelamento_tituloCalcBaixa,
                    InSTIDFF103TpBaiDevolucao = InPrmTituloEstornar.InSTIDFF103TpBaiDevolucao_tituloCalcBaixa,
                    InSTIDFF103TpBaiDoacao = InPrmTituloEstornar.InSTIDFF103TpBaiDoacao_tituloCalcBaixa,
                    InFF102Id = InPrmTituloEstornar.InFF102Id_tituloCalcBaixa,
                    //InEstabID = InPrmTituloEstornar.InEstabID_tituloCalcBaixa,
                };
                await _tituloCalculoBaixa.Executar(prmEntradaCalculoBaixa);

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
            var validacoes = new List<(bool, string)>
            {
                (WorkFF103.Ff103ObjBxId == PdvWebLabel || WorkFF103.Ff103ObjBxLabel == "BXPER", WorkFF103.Ff103ObjBxLabel == PdvWebLabel ? "O Estorno de baixas do PDV, somente poderá ser estornada pelo PDV!" : "O Estorno de baixas via Permuta, não poderá ser estornado!"),
                (WorkFF103.Ff103Baixado == false,  "O Estorno não pode ser efetuado, movimento não está Baixado!"),
                (WorkFF103.Ff103Estornado == true,  "Não é possivel o Estorno, movimento já foi estornado!"),
                (WorkFF103.Ff103Cancelado == true,  "Não é possivel o Estorno, movimento está cancelado!")
            };

            foreach (var (condition, message) in validacoes)
            {
                if (condition)
                    throw new InvalidOperationException(message);
            }
        }
    }
}
