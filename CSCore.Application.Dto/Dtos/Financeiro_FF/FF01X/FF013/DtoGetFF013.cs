using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB01X.BB010;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF012;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF013
{
    public class DtoGetFF013
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff013Filialid { get; set; }
        public string? Ff013Grupocobrancaid { get; set; }
        public string? Ff013Cobradorid { get; set; }
        public string? Ff013Zonaid { get; set; }
        public string? Ff013Contaid { get; set; }
        public int? Ff013Tpregistro { get; set; }

        // Navegações
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public DtoGetFF012Simples? NavFF012 { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }
        public Dto_GetBB010_Zona_Exibicao? NavBB010 { get; set; }
        public Dto_GetBB012_Exibicao? NavBB012 { get; set; }
    }
}