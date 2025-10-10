using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem.PR21_Strategy;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy
{
    public class PR21_GetQueryImplHandler
    {
        public static PR21_IQueryImpl GetQueryImpl(
            PR21_EnumTipoOrigem enumtp,
            AppDbContext appDbContext,
            string IdControle
            )
        {
            return enumtp switch
            {
                PR21_EnumTipoOrigem.csicp_dd040 => new PR21_DD040QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_cc030 => new PR21_CC030QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_cc040 => new PR21_CC040QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_bf010 => new PR21_BF010QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_ff040 => new PR21_FF040QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_ff017 => new PR21_FF017QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_dd190 => new PR21_DD190QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_ge010 => new PR21_GE010QueryImpl(appDbContext, IdControle),
                PR21_EnumTipoOrigem.csicp_ff140 => new PR21_FF140QueryImpl(appDbContext, IdControle),
                _ => throw new NotImplementedException()
            };
        }
    }
}
