using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem
{
    public class PR21_FF102ListaTitulosGeradosQualquerOrigem : IPR21_FF102ListaTitulosGeradosQualquerOrigem
    {
        private AppDbContext appDbContext;

        public PR21_FF102ListaTitulosGeradosQualquerOrigem(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<CSICP_FF102>> Execute(PR21_EnumTipoOrigem pR21_EnumTipo, string IdControle, int in_tenant)
        {
            PR21_IQueryImpl WorkQueryHandler = PR21_GetQueryImplHandler.GetQueryImpl(
                pR21_EnumTipo,
                appDbContext,
                IdControle

                );

            List<CSICP_FF102> csicpFf102List = await WorkQueryHandler.Execute(in_tenant);
            return csicpFf102List;
        }

    }
}
