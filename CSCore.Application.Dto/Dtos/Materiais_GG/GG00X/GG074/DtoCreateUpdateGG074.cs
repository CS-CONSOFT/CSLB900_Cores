using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG074
{
    public class DtoCreateUpdateGG074 : IConverteParaEntidade<CSICP_GG074>
    {

        public string? Gg073Id { get; set; }

        public string? Gg074Codbarrasalfa { get; set; }

        public string? Gg074KardexId { get; set; }

        public string Gg074Saldoid { get; set; }

        public string? Gg074UnId { get; set; }

        public decimal Gg074Qtd { get; set; }

        public decimal? Gg074Vunitario { get; set; }

        public int Gg074Statusestqid { get; set; }

        public int? Gg074Tmovid { get; set; }

        public decimal? Gg074Tproduto { get; set; }
        public CSICP_GG074 ToEntity(int tenant, string? _)
        {
            var entity = new CSICP_GG074
            {
                TenantId = tenant,
                Gg073Id = this.Gg073Id,
                Gg074Codbarrasalfa = this.Gg074Codbarrasalfa,
                Gg074KardexId = this.Gg074KardexId,
                Gg074Saldoid = this.Gg074Saldoid,
                Gg074UnId = this.Gg074UnId,
                Gg074Qtd = this.Gg074Qtd,
                Gg074Vunitario = this.Gg074Vunitario,
                Gg074Statusestqid = this.Gg074Statusestqid,
                Gg074Tmovid = this.Gg074Tmovid,
                Gg074Tproduto = this.Gg074Tproduto,
            };
            return entity;
        }
    }
}








