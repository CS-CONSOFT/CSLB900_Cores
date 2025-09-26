using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.FF.Repository.FF1XX.FF128;
using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF128
{
    public record PrmGetHistoricoRegistroCobradorPorTitulo(string InFF102TituloId, int InTenant) :ParametrosBaseFiltroRecord;
    public interface IFF128Repository
    {
        void CriaHistoricoRegistroCobrador(PrmCriaHistoricoRegistroCobrador prm, int InTenant);

        Task<(IEnumerable<CSICP_FF128>, int)> ObterHistoricoRegistroCobradorPorTituloId(PrmGetHistoricoRegistroCobradorPorTitulo prm);
    }
}
