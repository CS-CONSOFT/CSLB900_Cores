using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG070
{
    public class DtoCreateUpdateGG070 : IConverteParaEntidade<CSICP_GG070>
    {
        public string? Gg070EstabId { get; set; }

        public string? Gg070Produtoid { get; set; }

        public string? Gg070Motivoid { get; set; }

        public string? Gg070Grupoid { get; set; }

        public string? Gg070Subgrupoid { get; set; }

        public string? Gg070Classeid { get; set; }

        public string? Gg070Marcaid { get; set; }

        public string? Gg070Artigoid { get; set; }

        public int? Gg070Peso { get; set; }

        public string? Gg070Usuariopropid { get; set; }

        public string? Gg070Nomecliente { get; set; }

        public decimal? Gg070Qtdregistrada { get; set; }

        public string? Gg070Unvendavarejoid { get; set; }

        public decimal? Gg070Pvenda { get; set; }

        public decimal? Gg070Pcusto { get; set; }

        public decimal? Gg070Pcreal { get; set; }

        public DateTime? Gg070Dregistro { get; set; }

        public decimal? Gg070Saldoprod { get; set; }

        public string? Gg070Descproduto { get; set; }
        public CSICP_GG070 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG070
            {
                TenantId = tenant,
                Gg070EstabId = this.Gg070EstabId,
                Gg070Produtoid = this.Gg070Produtoid,
                Gg070Motivoid = this.Gg070Motivoid,
                Gg070Grupoid = this.Gg070Grupoid,
                Gg070Subgrupoid = this.Gg070Subgrupoid,
                Gg070Classeid = this.Gg070Classeid,
                Gg070Marcaid = this.Gg070Marcaid,
                Gg070Artigoid = this.Gg070Artigoid,
                Gg070Peso = this.Gg070Peso,
                Gg070Usuariopropid = this.Gg070Usuariopropid,
                Gg070Nomecliente = this.Gg070Nomecliente,
                Gg070Qtdregistrada = this.Gg070Qtdregistrada,
                Gg070Unvendavarejoid = this.Gg070Unvendavarejoid,
                Gg070Pvenda = this.Gg070Pvenda,
                Gg070Pcusto = this.Gg070Pcusto,
                Gg070Pcreal = this.Gg070Pcreal,
                Gg070Dregistro = this.Gg070Dregistro,
                Gg070Saldoprod = this.Gg070Saldoprod,
                Gg070Descproduto = this.Gg070Descproduto,
            };
        }
    }
}
