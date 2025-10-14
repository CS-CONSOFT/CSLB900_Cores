using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG007
{
    public class DtoCreateUpdateGG007 : IConverteParaEntidade<CSICP_GG007>
    {
        public int? Gg007Filial { get; set; }

        public string? Gg007Filialid { get; set; }

        public string? Gg007Unidade { get; set; }

        public string? Gg007Descricao { get; set; }

        public int? Gg007FormavendaId { get; set; }

        public string? Gg007Qdecimais { get; set; }
        public bool? Gg007IsActive { get; set; }


        public CSICP_GG007 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG007
            {
                TenantId = tenant,
                Id = id!,
                Gg007Filial = this.Gg007Filial,
                Gg007Filialid = this.Gg007Filialid,
                Gg007Unidade = this.Gg007Unidade,
                Gg007Descricao = this.Gg007Descricao,
                Gg007IsActive = Gg007IsActive,
                Gg007FormavendaId = this.Gg007FormavendaId,
                Gg007Qdecimais = this.Gg007Qdecimais,
            };

        }
    }
}
