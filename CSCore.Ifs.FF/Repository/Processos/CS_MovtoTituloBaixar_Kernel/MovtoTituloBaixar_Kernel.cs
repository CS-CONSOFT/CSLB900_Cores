using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloBaixar_Kernel
{
    public class MovtoTituloBaixar_Kernel : IMovtoTituloBaixar_Kernel
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITituloCalculoBaixa _tituloCalculoBaixa;

        public MovtoTituloBaixar_Kernel(AppDbContext appDbContext, ITituloCalculoBaixa tituloCalculoBaixa)
        {
            _tituloCalculoBaixa = tituloCalculoBaixa;
            _appDbContext = appDbContext;
        }


        public async Task<bool> Executar(PrmMovtoTituloBaixarKernel InPrmMovtoTituloBaixarKernel)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF103 WorkBaixa 
                    = await BuscarMovimentoParaBaixaComTracking(
                        InPrmMovtoTituloBaixarKernel.InFF103ID,
                        InPrmMovtoTituloBaixarKernel.InTenantID);

                VerificarRestricoesBaixa(WorkBaixa, InPrmMovtoTituloBaixarKernel);

                WorkBaixa.Ff103Baixado = true;
                WorkBaixa.Ff103Flagregistro = 1;
                WorkBaixa.NavFF102 = null;

                _appDbContext.Update(WorkBaixa);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                transaction.Dispose();

                PrmEntradaCalculoBaixa prmEntradaCalculoBaixa = new PrmEntradaCalculoBaixa
                {
                    InTenantID = InPrmMovtoTituloBaixarKernel.InTenantID,
                    InFF102Id = WorkBaixa.Ff102Id ?? "",
                    InBB001Id = InPrmMovtoTituloBaixarKernel.InEstabID_tituloCalcBaixa,

                    //id de tabela estatica
                    InSTIDFF102Liquidado = InPrmMovtoTituloBaixarKernel.InSTIDff102SitLiquidado,
                    InSTIDFF102BxParcial = InPrmMovtoTituloBaixarKernel.InSTIDFF102BxParcial_tituloCalcBaixa,
                    InSTIDFF102Aberto = InPrmMovtoTituloBaixarKernel.InSTIDFF102Aberto_tituloCalcBaixa,
                    InSTIDFF103TpBaiCancelamento = InPrmMovtoTituloBaixarKernel.InSTIDFF103TpBaiCancelamento_tituloCalcBaixa,
                    InSTIDFF103TpBaiDevolucao = InPrmMovtoTituloBaixarKernel.InSTIDFF103TpBaiDevolucao_tituloCalcBaixa,
                    InSTIDFF103TpBaiDoacao = InPrmMovtoTituloBaixarKernel.InSTIDFF103TpBaiDoacao_tituloCalcBaixa,
                };
                await _tituloCalculoBaixa.Executar(prmEntradaCalculoBaixa);
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is InvalidOperationException) throw new InvalidOperationException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                if (ex is KeyNotFoundException) throw new KeyNotFoundException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }

        }
        
        private void VerificarRestricoesBaixa(CSICP_FF103 WorkBaixa, PrmMovtoTituloBaixarKernel InPrmMovtoTituloBaixarKernel)
        {
            var validations = new List<(bool Condition, string Message)>
            {
                //i1
                (WorkBaixa.Ff103Baixado == true, "Movimento já baixado."),
                //i2
                (WorkBaixa.Ff103Estornado == true, "Não é possivel a baixa. Movimento já estornado!"),
                //i3
                (WorkBaixa.Ff103Cancelado == true, "Não é possivel a baixa. Movimento já cancelado!"),
                //i4
                (
                    //caso a situacao id nao seja nula, verifica se é uma das situações que não permitem baixa
                    //criando uma lista auxiliar de situações que não permitem baixa e chegando se a situação do título está nessa lista
                    WorkBaixa.NavFF102?.Ff102Situacaoid is not null &&
                    new[]
                    {
                        InPrmMovtoTituloBaixarKernel.InSTIDff102SitLiquidado,
                        InPrmMovtoTituloBaixarKernel.InSTIDff102SitCancelado,
                        InPrmMovtoTituloBaixarKernel.InSTIDff102SitRenegociado,
                        InPrmMovtoTituloBaixarKernel.InSTIDff102SitProvisao
                    }.Contains(WorkBaixa.NavFF102.Ff102Situacaoid),
                    "Não é possivel a baixa. Título já liquidado, cancelado, renegociado ou em provisão!"
                ),

                //i5
                (
                    WorkBaixa.Ff103ValorPago >
                    ((WorkBaixa.Ff103ValorMulta ?? 0) +
                     (WorkBaixa.Ff103ValorTarifas ?? 0) +
                     (WorkBaixa.Ff103ValorJuros ?? 0) -
                     (WorkBaixa.Ff103ValorDesconto ?? 0) +
                     (WorkBaixa.NavFF102?.Ff102VlLiqTitulo ?? 0)) +
                     (WorkBaixa.Ff103VlHonorarios ?? 0) +
                     (WorkBaixa.Ff103VlCorrmonetaria ?? 0),
                    "Valor pago é superior ao valor calculado do título."
                ),

                //caso precise de mais validações, adicione aqui
            };

            // Executa as validações
            foreach (var (condition, message) in validations)
            {
                if (condition)
                    throw new InvalidOperationException(message);
            }
        }



        private async Task<CSICP_FF103> BuscarMovimentoParaBaixaComTracking(string InFF103ID, int InTenantID)
        {
            var WorkResultado = await (from ff103 in _appDbContext.OsusrE9aCsicpFf103s
                                       where ff103.Id == InFF103ID && ff103.TenantId == InTenantID

                                       join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                                       on ff103.Ff102Id equals ff102.Id into leftJoin
                                       from ff102 in leftJoin.DefaultIfEmpty()

                                       select new CSICP_FF103
                                       {
                                           TenantId = ff103.TenantId,
                                           Id = ff103.Id,
                                           Ff102Id = ff103.Ff102Id,
                                           Ff103Filialid = ff103.Ff103Filialid,
                                           Ff103Filial = ff103.Ff103Filial,
                                           Ff103Pfx = ff103.Ff103Pfx,
                                           Ff103NoTitulo = ff103.Ff103NoTitulo,
                                           Ff103Sfx = ff103.Ff103Sfx,
                                           Ff103SeqBaixa = ff103.Ff103SeqBaixa,
                                           Ff103DataBaixa = ff103.Ff103DataBaixa,
                                           Ff103DtaBaixaAnt = ff103.Ff103DtaBaixaAnt,
                                           Ff103DataCredito = ff103.Ff103DataCredito,
                                           Ff103Agcobradorid = ff103.Ff103Agcobradorid,
                                           Ff103Banco = ff103.Ff103Banco,
                                           Ff103ValorJuros = ff103.Ff103ValorJuros,
                                           Ff103ValorDesconto = ff103.Ff103ValorDesconto,
                                           Ff103ValorPago = ff103.Ff103ValorPago,
                                           Ff103ValorMulta = ff103.Ff103ValorMulta,
                                           Ff103ValorTarifas = ff103.Ff103ValorTarifas,
                                           Ff103Atraso = ff103.Ff103Atraso,
                                           Ff103Historico = ff103.Ff103Historico,
                                           Ff103BaixadoAuto = ff103.Ff103BaixadoAuto,
                                           Ff103Usuarioproprid = ff103.Ff103Usuarioproprid,
                                           Ff103Cobradorid = ff103.Ff103Cobradorid,
                                           Ff103ResponsavelCob = ff103.Ff103ResponsavelCob,
                                           Ff103NoPdv = ff103.Ff103NoPdv,
                                           Ff103CiPdv = ff103.Ff103CiPdv,
                                           Ff103DespesaCartorio = ff103.Ff103DespesaCartorio,
                                           Ff103BaixaTesouraria = ff103.Ff103BaixaTesouraria,
                                           Ff103Lctoctbbxid = ff103.Ff103Lctoctbbxid,
                                           Ff103ObjBxLabel = ff103.Ff103ObjBxLabel,
                                           Ff103ObjBxId = ff103.Ff103ObjBxId,
                                           Ff103Baixado = ff103.Ff103Baixado,
                                           Ff103Estornado = ff103.Ff103Estornado,
                                           Ff103Cancelado = ff103.Ff103Cancelado,
                                           Ff103Dataregistro = ff103.Ff103Dataregistro,
                                           Ff103Tpbaixaid = ff103.Ff103Tpbaixaid,
                                           Ff103Flagregistro = ff103.Ff103Flagregistro,
                                           Ff103MsgId = ff103.Ff103MsgId,
                                           Ff103CtbIscontabilizadoid = ff103.Ff103CtbIscontabilizadoid,
                                           Ff103CtbUsuarioid = ff103.Ff103CtbUsuarioid,
                                           Ff103CtbDtregistro = ff103.Ff103CtbDtregistro,
                                           Ff103CtbIsestornadoid = ff103.Ff103CtbIsestornadoid,
                                           Ff103CtbEstusuarioid = ff103.Ff103CtbEstusuarioid,
                                           Ff103CtbEstdtreg = ff103.Ff103CtbEstdtreg,
                                           Ff103CtbIdlancto = ff103.Ff103CtbIdlancto,
                                           Ff103CtbMsg = ff103.Ff103CtbMsg,
                                           Ff103FpagtoId = ff103.Ff103FpagtoId,
                                           Ff103VlCorrmonetaria = ff103.Ff103VlCorrmonetaria,
                                           Ff103VlHonorarios = ff103.Ff103VlHonorarios,
                                           Ff103CtlIscontabilizadoid = ff103.Ff103CtlIscontabilizadoid,
                                           Ff103CtlUsuarioid = ff103.Ff103CtlUsuarioid,
                                           Ff103CtlDtregistro = ff103.Ff103CtlDtregistro,
                                           Ff103CtlIsestornadoid = ff103.Ff103CtlIsestornadoid,
                                           Ff103CtlEstusuarioid = ff103.Ff103CtlEstusuarioid,
                                           Ff103CtlEstdtreg = ff103.Ff103CtlEstdtreg,
                                           Ff103CtlIdlancto = ff103.Ff103CtlIdlancto,
                                           Ff103CtlMsg = ff103.Ff103CtlMsg,
                                           NavFF102 = ff102 != null ? new CSICP_FF102
                                           {
                                               Ff102Situacaoid = ff102.Ff102Situacaoid,
                                               Ff102VlLiqTitulo = ff102.Ff102VlLiqTitulo,
                                           } : null,


                                       }).AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Movimento não encontrado para Baixa");

            return WorkResultado; 
        }
    }
}
