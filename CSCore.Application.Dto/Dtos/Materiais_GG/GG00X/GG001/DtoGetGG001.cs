using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG001
{
    public class DtoGetGG001
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

        public CSICP_GG001Talmox? Gg001TipoalmoxarifadoNavigation { get; set; }
        //public Dto_GetBB001Simples? BB001FilialNav { get; set; }
    }
}
