using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF040
{
    public class DtoCreateUpdateFF040 : IConverteParaEntidade<CSICP_FF040>
    {
        public string? Ff040Empresaid { get; set; }

        public int? Ff040Tiporegistro { get; set; }

        public DateTime? Ff040DataMovimento { get; set; }

        public string? Ff040ContaId { get; set; }

        public string? Ff040CcustoId { get; set; }

        public string? Ff040EspecieId { get; set; }

        public string? Ff040AgcobradorId { get; set; }

        public string? Ff040ResponsavelId { get; set; }

        public string? Ff040Tipocobrancaid { get; set; }

        public decimal? Ff040Vtransacao { get; set; }

        public string? Ff040Texto { get; set; }

        public string? Ff040UsuarioProprId { get; set; }

        public int? Ff040Situacaoid { get; set; }

        public string? Ff040Protocolnumber { get; set; }

        public DateTime? Ff040Dbasevencto { get; set; }

        public bool? Ff040Isprovisao { get; set; }

        public int? Ff040CtbIscontabilizadoid { get; set; }

        public string? Ff040CtbUsuarioid { get; set; }

        public DateTime? Ff040CtbDtregistro { get; set; }

        public int? Ff040CtbIsestornadoid { get; set; }

        public string? Ff040CtbEstusuarioid { get; set; }

        public DateTime? Ff040CtbEstdtreg { get; set; }

        public long? Ff040CtbIdlancto { get; set; }

        public string? Ff040CtbMsg { get; set; }

        public bool? Ff040CtlIscontabilizadoid { get; set; }

        public string? Ff040CtlUsuarioid { get; set; }

        public DateTime? Ff040CtlDtregistro { get; set; }

        public bool? Ff040CtlIsestornadoid { get; set; }

        public string? Ff040CtlEstusuarioid { get; set; }

        public DateTime? Ff040CtlEstdtreg { get; set; }

        public long? Ff040CtlIdlancto { get; set; }

        public string? Ff040CtlMsg { get; set; }

        public CSICP_FF040 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF040
            {
                TenantId = tenant,
                Ff040Empresaid = Ff040Empresaid,
                Ff040Tiporegistro = Ff040Tiporegistro,
                Ff040DataMovimento = Ff040DataMovimento,
                Ff040ContaId = Ff040ContaId,
                Ff040CcustoId = Ff040CcustoId,
                Ff040EspecieId = Ff040EspecieId,
                Ff040AgcobradorId = Ff040AgcobradorId,
                Ff040ResponsavelId = Ff040ResponsavelId,
                Ff040Tipocobrancaid = Ff040Tipocobrancaid,
                Ff040Vtransacao = Ff040Vtransacao,
                Ff040Texto = Ff040Texto,
                Ff040UsuarioProprId = Ff040UsuarioProprId,
                Ff040Situacaoid = Ff040Situacaoid,
                Ff040Protocolnumber = Ff040Protocolnumber,
                Ff040Dbasevencto = Ff040Dbasevencto,
                Ff040Isprovisao = Ff040Isprovisao,
                Ff040CtbIscontabilizadoid = Ff040CtbIscontabilizadoid,
                Ff040CtbUsuarioid = Ff040CtbUsuarioid,
                Ff040CtbDtregistro = Ff040CtbDtregistro,
                Ff040CtbIsestornadoid = Ff040CtbIsestornadoid,
                Ff040CtbEstusuarioid = Ff040CtbEstusuarioid,
                Ff040CtbEstdtreg = Ff040CtbEstdtreg,
                Ff040CtbIdlancto = Ff040CtbIdlancto,
                Ff040CtbMsg = Ff040CtbMsg,
                Ff040CtlIscontabilizadoid = Ff040CtlIscontabilizadoid,
                Ff040CtlUsuarioid = Ff040CtlUsuarioid,
                Ff040CtlDtregistro = Ff040CtlDtregistro,
                Ff040CtlIsestornadoid = Ff040CtlIsestornadoid,
                Ff040CtlEstusuarioid = Ff040CtlEstusuarioid,
                Ff040CtlEstdtreg = Ff040CtlEstdtreg,
                Ff040CtlIdlancto = Ff040CtlIdlancto,
                Ff040CtlMsg = Ff040CtlMsg,
            };
        }
    }
}
