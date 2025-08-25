using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF014;
using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF012
{
    public class DtoGetFF012
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = "";
        public string? Ff012Filialid { get; set; }
        public int? Ff012CodigoGrupo { get; set; }
        public string? Ff012DescricaoGrupo { get; set; }
        public string? Ff012Usuariosuperid { get; set; }
        public string? Ff014Comissaosuperid { get; set; }
        public string? Ff014Comissaocobradorid { get; set; }
        public string? Ff012Grupopaiid { get; set; }

        // Navegações
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }
        public DtoGetFF014? NavFF014ComissaoSuper { get; set; }
        public DtoGetFF014? NavFF014ComissaoCobrador { get; set; }
        public DtoGetFF012Simples? NavFF012GrupoPai { get; set; }
    }
}