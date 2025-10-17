using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG011
{
    public class DtoCreateUpdateGG011 : IConverteParaEntidade<CSICP_GG011>
    {
        public int? Gg011Filial { get; set; }

        public string? Gg011Filialid { get; set; }

        public string? Gg011CodigoQualidade { get; set; }

        public string? Gg011Descricaoqualidade { get; set; }
        public bool? Gg011IsActive { get; set; }
        public CSICP_GG011 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG011
            {
                TenantId = tenant,
                Id = id!,
                Gg011Filial = this.Gg011Filial,
                Gg011Filialid = this.Gg011Filialid,
                Gg011CodigoQualidade = this.Gg011CodigoQualidade,
                Gg011Descricaoqualidade = this.Gg011Descricaoqualidade,
                Gg011IsActive = Gg011IsActive,
            };
        }
    }
}
