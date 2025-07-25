using CSBS101._82Application.Dto.BB00X.BB001;

namespace GG104Materiais.C82Application.Dto.GG00X.GG001
{
    public class DtoGetGG001Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg001Filial { get; set; }

        public string? Gg001Filialid { get; set; }

        public int? Gg001Codigoalmox { get; set; }

        public string? Gg001Descalmox { get; set; }

        public bool? Gg001Isactive { get; set; }

        public int? Gg001Tipoalmoxarifado { get; set; }

        public bool? Gg001RiControlequalidade { get; set; }

        public decimal? Gg001Caparmaz { get; set; }

        public string? Gg001Descnspadrao { get; set; }
    }

    public class DtoGetGG001SimplesComFilial : DtoGetGG001Simples
    {
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
    }
}
