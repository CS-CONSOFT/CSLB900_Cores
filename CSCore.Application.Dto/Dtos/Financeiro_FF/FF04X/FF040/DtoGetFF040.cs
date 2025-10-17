using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB009;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF040
{
    public class DtoGetFF040
    {
        public int TenantId { get; set; }

        public long Ff040Id { get; set; }

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

        public Dto_GetBB001_Exibicao? NavBB001Estabelecimento { get; set; }
        public Dto_GetBB005_Exibicao? NavBB005CCustoID { get; set; }
        public Dto_GetBB012_ExibSimples? NavBB012ContaID { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006AgCobradorID { get; set; }
        public Dto_GetBB007SemListSimples? NavBB007ResponsavelID { get; set; }
        public Dto_GetFF003_Exibicao? NavFF003EspecieID { get; set; }
        public Dto_GetBB009_Exibicao? NavBB009TipoCobrancaID { get; set; }
        public Dto_GetSY001Simples? NavSY001UsuarioPropID { get; set; }
        public OsusrE9aCsicpFf040Sit? NavFF040SituacaoID { get; set; }

    }
}
