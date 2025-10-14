using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG001
{
    public class DtoCreateUpdateGG001 : IConverteParaEntidade<CSICP_GG001>
    {
        public int? Gg001Filial { get; set; } = 123;

        public string? Gg001Filialid { get; set; } = "FILIAL01";

        public int? Gg001Codigoalmox { get; set; } = 456;

        public string? Gg001Descalmox { get; set; } = "Almoxarifado Central";

        public int? Gg001Tipoalmoxarifado { get; set; } = 1; // conforme solicitado

        public bool? Gg001RiControlequalidade { get; set; } = true;

        public decimal? Gg001Caparmaz { get; set; } = 1000.50m;

        public string? Gg001Descnspadrao { get; set; } = "Padrão de armazenamento";

        public bool? Gg001Isactive { get; set; } = true;

        public CSICP_GG001 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG001
            {
                Id = id!,
                TenantId = tenant,
                Gg001Filial = Gg001Filial,
                Gg001Filialid = Gg001Filialid,
                Gg001Codigoalmox = Gg001Codigoalmox,
                Gg001Descalmox = Gg001Descalmox,
                Gg001Isactive = Gg001Isactive,
                Gg001Tipoalmoxarifado = Gg001Tipoalmoxarifado,
                Gg001RiControlequalidade = Gg001RiControlequalidade,
                Gg001Caparmaz = Gg001Caparmaz,
                Gg001Descnspadrao = Gg001Descnspadrao
            };
        }
    }
}
