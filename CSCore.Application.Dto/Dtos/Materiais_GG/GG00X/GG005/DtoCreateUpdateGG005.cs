using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG005
{
    public class DtoCreateUpdateGG005 : IConverteParaEntidade<CSICP_GG005>
    {
        public int? Gg005Filial { get; set; }

        public string? Gg005Filialid { get; set; }

        public int? Gg005Codigoartigo { get; set; }

        public string? Gg005Descartigo { get; set; }

        public string? Gg005PesoLe { get; set; }
        public bool? Gg005Isactive { get; set; }
        public CSICP_GG005 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG005
            {
                Id = id!,
                TenantId = tenant,
                Gg005Filial = Gg005Filial,
                Gg005Filialid = Gg005Filialid,
                Gg005Codigoartigo = Gg005Codigoartigo,
                Gg005Descartigo = Gg005Descartigo,
                Gg005Isactive = Gg005Isactive,
                Gg005PesoLe = Gg005PesoLe,
            };
        }
    }
}

