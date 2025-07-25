using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG072
{
    public class DtoCreateUpdateGG072 : IConverteParaEntidade<CSICP_GG072>
    {
    

        public long? Gg071Id { get; set; }

        public string? Gg072Codbarrasalfa { get; set; }

        public string? Gg072KardexId { get; set; }

        public string? Gg072Saidasaldoid { get; set; }

        public string? Gg072UnId { get; set; }

        public decimal? Gg072Quantidade { get; set; }

        public decimal? Gg072ValorUnitario { get; set; }

        public string? Gg072QtdAnterior { get; set; }

        public string? Gg072Entradasaldoid { get; set; }

        public string? Gg072UnSecId { get; set; }

        public int? Gg072UnSecTipoconvId { get; set; }

        public decimal? Gg072UnSecFatorconv { get; set; }

        public decimal? Gg072UnSecQtde { get; set; }

        public int? Gg072Statusestqid { get; set; }

        public string? Dd080Id { get; set; }

        public decimal? Gg072Qtdsolicitada { get; set; }
        public CSICP_GG072 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG072
            {
                TenantId = tenant,
                Gg071Id = this.Gg071Id,
                Gg072Codbarrasalfa = this.Gg072Codbarrasalfa,
                Gg072KardexId = this.Gg072KardexId,
                Gg072Saidasaldoid = this.Gg072Saidasaldoid,
                Gg072UnId = this.Gg072UnId,
                Gg072Quantidade = this.Gg072Quantidade,
                Gg072ValorUnitario = this.Gg072ValorUnitario,
                Gg072QtdAnterior = this.Gg072QtdAnterior,
                Gg072Entradasaldoid = this.Gg072Entradasaldoid,
                Gg072UnSecId = this.Gg072UnSecId,
                Gg072UnSecTipoconvId = this.Gg072UnSecTipoconvId,
                Gg072UnSecFatorconv = this.Gg072UnSecFatorconv,
                Gg072UnSecQtde = this.Gg072UnSecQtde,
                Gg072Statusestqid = this.Gg072Statusestqid,
                Dd080Id = this.Dd080Id,
                Gg072Qtdsolicitada = this.Gg072Qtdsolicitada,
            };
        }
    }
}
