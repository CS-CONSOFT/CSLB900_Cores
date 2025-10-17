using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG013
{
    public class DtoCreateUpdateGG013 : IConverteParaEntidade<CSICP_GG013>
    {
        public string GG008_ProdutoId { get; set; } = null!;
        public int? Gg013Filial { get; set; }

        public string? Gg013Filialid { get; set; }

        public string? Gg013Aplicacao { get; set; }

        public CSICP_GG013 ToEntity(int tenant, string? _)
        {
            if (this.GG008_ProdutoId == null) throw new Exception("O campo GG008_ProdutoId não pode ser nulo ou vazio.");
            return new CSICP_GG013
            {
                TenantId = tenant,
                Id = this.GG008_ProdutoId,
                Gg013Filial = this.Gg013Filial,
                Gg013Filialid = this.Gg013Filialid,
                Gg013Aplicacao = this.Gg013Aplicacao,
            };
        }
    }
}
