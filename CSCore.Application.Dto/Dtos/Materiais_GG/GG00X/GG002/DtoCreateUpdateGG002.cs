using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG002
{
    public class DtoCreateUpdateGG002 : IConverteParaEntidade<CSICP_GG002>
    {
        public int? Gg002Filial { get; set; }

        public string? Gg002Filialid { get; set; }

        public string? Gg002Desctipoproduto { get; set; }

        public int? Gg002PermiteVendas { get; set; }

        public int? Gg002PermiteCompras { get; set; }

        public bool? Gg002Isactive { get; set; }

        public int? Gg002TipoprodId { get; set; }


        public CSICP_GG002 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG002
            {
                Id = id!,
                TenantId = tenant,
                Gg002Filial = Gg002Filial,
                Gg002Filialid = Gg002Filialid,
                Gg002Desctipoproduto = Gg002Desctipoproduto,
                Gg002PermiteVendas = Gg002PermiteVendas,
                Gg002PermiteCompras = Gg002PermiteCompras,
                Gg002Isactive = Gg002Isactive,
                Gg002TipoprodId = Gg002TipoprodId
            };
        }
    }
}
