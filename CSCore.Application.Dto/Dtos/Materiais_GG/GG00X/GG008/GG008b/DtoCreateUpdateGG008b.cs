using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.Extensao;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008b
{
    public class DtoCreateUpdateGG008b : IConverteParaEntidade<CSICP_GG008b>
    {
        public string? Gg008bFilialid { get; set; }

        public string? Gg008bProdutoid { get; set; }

        public int? Gg008bCodgproduto { get; set; }

        public int? Gg008bSeq { get; set; }

        public string? Gg008bRefsimilar { get; set; }

        public string? Gg008bDatavigor { get; set; }

        public string? Gg008bMarcaid { get; set; }

        public CSICP_GG008b ToEntity(int tenant, string? id)
        {
            return new CSICP_GG008b
            {
                TenantId = tenant,
                Id = id!,
                Gg008bFilialid = this.Gg008bFilialid,
                Gg008bProdutoid = this.Gg008bProdutoid,
                Gg008bFilial = 0,
                Gg008bCodgproduto = this.Gg008bCodgproduto,
                Gg008bSeq = this.Gg008bSeq,
                Gg008bRefsimilar = this.Gg008bRefsimilar,
                Gg008bDatavigor = this.Gg008bDatavigor.ConverteStringVaziaParaDataNula(),
                Gg008bCodgmarca = 0,
                Gg008bMarcaid = this.Gg008bMarcaid,
            };
        }
    }
}
