using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB007;
using CSBS101._82Application.Dto.BB00X.BB009;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101._82Application.Dto.BB00X.BB06X.BB067;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;


namespace CSBS101._82Application.Dto.BB00X.BB06X.BB060
{
    public class Dto_GetBB060
    {
        public int TenantId { get; set; }

        public long Bb060Convenioid { get; set; }

        public string? Bb060Codigo { get; set; }

        public string? Bb060Descricao { get; set; }

        public decimal? Bb060Vbase { get; set; }

        public string? Bb060Ccustoid { get; set; }

        public string? Bb060Usuarioproprieid { get; set; }

        public string? Bb060Agcobradorid { get; set; }

        public string? Bb060Responsavelid { get; set; }

        public string? Bb060Condicaoid { get; set; }

        public string? Bb060Tipocobrancaid { get; set; }

        public string? Bb060Usuarioinc { get; set; }

        public string? Bb060Usuarioalt { get; set; }

        public DateTime? Bb060Dthrinc { get; set; }

        public DateTime? Bb060Dthralt { get; set; }

        public string? Bb060Especieid { get; set; }

        public string? Bb060FpagtoId { get; set; }

        public bool? Bb060Isactive { get; set; }

        public long? Bb060Convmasterid { get; set; }

        public Dto_GetBB006? NavBb060Agcobrador { get; set; }

        public Dto_GetBB005? NavBb060Ccusto { get; set; }

        public Dto_GetBB008? NavBb060Condicao { get; set; }

        public Dto_GetBB067? NavBb060Convmaster { get; set; }

        public Dto_GetBB007? NavBb060Responsavel { get; set; }

        public Dto_GetBB009? NavBb060Tipocobranca { get; set; }

        public Dto_GetBB026SemList? NavFormaPagamento { get; set; }

        public Csicp_Sy001? NavUsuarioProprietario { get; set; }

    }

    public class Dto_GetBB060_Exibicao
    {
        public int TenantId { get; set; }

        public long Bb060Convenioid { get; set; }

        public string? Bb060Codigo { get; set; }

        public string? Bb060Descricao { get; set; }

        public decimal? Bb060Vbase { get; set; }

    }
}
