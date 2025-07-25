using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace GG104Materiais.C82Application.Dto.GG00X.GG036
{
    public class DtoCreateUpdateGG036 : IConverteParaEntidade<CSICP_GG036>
    {
        public string? Gg036Filialid { get; set; }

        public int? Gg036Ordem { get; set; }

        public string? Gg036KardexId { get; set; }

        public decimal? Gg036Codigobarras { get; set; }

        public DateTime? Gg036Dataregistro { get; set; }

        public string? Gg036Saldoid { get; set; }

        public decimal? Gg036QtdEstoque { get; set; }

        public decimal? Gg036Saldoestoque { get; set; }

        public decimal? Gg036Precocusto { get; set; }

        public decimal? Gg036Precocustoreal { get; set; }

        public decimal? Gg036Precocustomedio { get; set; }

        public decimal? Gg036Precovenda { get; set; }

        public bool? Gg036Naoinventariar { get; set; }

        public bool? Gg036Inventariado { get; set; }

        public string? Gg036Mensagem { get; set; }

        public string? Gg036Codbarrasalfa { get; set; }

        public CSICP_GG036 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG036
            {
                Id = id!,
                TenantId = tenant,
                Gg036Filialid = this.Gg036Filialid,
                Gg036Ordem = this.Gg036Ordem,
                Gg036KardexId = this.Gg036KardexId,
                Gg036Codigobarras = this.Gg036Codigobarras,
                Gg036Dataregistro = this.Gg036Dataregistro,
                Gg036Saldoid = this.Gg036Saldoid,
                Gg036QtdEstoque = this.Gg036QtdEstoque,
                Gg036Saldoestoque = this.Gg036Saldoestoque,
                Gg036Precocusto = this.Gg036Precocusto,
                Gg036Precocustoreal = this.Gg036Precocustoreal,
                Gg036Precocustomedio = this.Gg036Precocustomedio,
                Gg036Precovenda = this.Gg036Precovenda,
                Gg036Naoinventariar = this.Gg036Naoinventariar,
                Gg036Inventariado = this.Gg036Inventariado,
                Gg036Mensagem = this.Gg036Mensagem,
                Gg036Codbarrasalfa = this.Gg036Codbarrasalfa,
            };
        }
    }
}

