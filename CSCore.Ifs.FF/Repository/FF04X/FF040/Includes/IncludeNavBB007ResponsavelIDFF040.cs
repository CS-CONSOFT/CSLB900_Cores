using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Includes
{
    internal class IncludeNavBB007ResponsavelIDFF040 : ICSInclude<CSICP_FF040>
    {
        public IQueryable<CSICP_FF040> ApplyIncludes(IQueryable<CSICP_FF040> query)
        {
            return query
                .Where(e => e.Ff040ResponsavelId != null)
                .Select(e => new CSICP_FF040
                {
                    TenantId = e.TenantId,
                    Ff040Id = e.Ff040Id,
                    Ff040Empresaid = e.Ff040Empresaid,
                    Ff040Tiporegistro = e.Ff040Tiporegistro,
                    Ff040DataMovimento = e.Ff040DataMovimento,
                    Ff040ContaId = e.Ff040ContaId,
                    Ff040CcustoId = e.Ff040CcustoId,
                    Ff040EspecieId = e.Ff040EspecieId,
                    Ff040AgcobradorId = e.Ff040AgcobradorId,
                    Ff040ResponsavelId = e.Ff040ResponsavelId,
                    Ff040Tipocobrancaid = e.Ff040Tipocobrancaid,
                    Ff040Vtransacao = e.Ff040Vtransacao,
                    Ff040Texto = e.Ff040Texto,
                    Ff040UsuarioProprId = e.Ff040UsuarioProprId,
                    Ff040Situacaoid = e.Ff040Situacaoid,
                    Ff040Protocolnumber = e.Ff040Protocolnumber,
                    Ff040Dbasevencto = e.Ff040Dbasevencto,
                    Ff040Isprovisao = e.Ff040Isprovisao,
                    Ff040CtbIscontabilizadoid = e.Ff040CtbIscontabilizadoid,
                    Ff040CtbUsuarioid = e.Ff040CtbUsuarioid,
                    Ff040CtbDtregistro = e.Ff040CtbDtregistro,
                    Ff040CtbIsestornadoid = e.Ff040CtbIsestornadoid,
                    Ff040CtbEstusuarioid = e.Ff040CtbEstusuarioid,
                    Ff040CtbEstdtreg = e.Ff040CtbEstdtreg,
                    Ff040CtbIdlancto = e.Ff040CtbIdlancto
                });
        }
    }
}
