using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008a
{
    public class DtoCreateUpdateGG008a : IConverteParaEntidade<CSICP_GG008a>
    {
        public string? Gg008aFilialid { get; set; }

        public string? Gg008aProdutoid { get; set; }

        public int? Gg08aFilial { get; set; }

        public int? Gg08aCodgProduto { get; set; }

        public int? Gg08aLinha { get; set; }

        public string? Gg08aCaracteristica { get; set; }

        public string? Gg008aValor { get; set; }

        public CSICP_GG008a ToEntity(int tenant, string? id)
        {
            return new CSICP_GG008a
            {
                TenantId = tenant,
                Id = id!,
                Gg008aFilialid = this.Gg008aFilialid,
                Gg008aProdutoid = this.Gg008aProdutoid,
                Gg08aFilial = this.Gg08aFilial,
                Gg08aCodgProduto = this.Gg08aCodgProduto,
                Gg08aLinha = this.Gg08aLinha,
                Gg08aCaracteristica = this.Gg08aCaracteristica,
                Gg008aValor = this.Gg008aValor,
            };
        }
    }
}
