using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem
{
    public interface IPR21_FF102ListaTitulosGeradosQualquerOrigem
    {
        Task<(List<CSICP_FF102>, int)> Execute(
             PR21_EnumTipoOrigem pR21_EnumTipo,
             string IdControle,
             int in_tenant,
             int InPageNumer,
             int InPageSize);
    }
}
