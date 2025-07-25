using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.Staticas.GG;
using GG104Materiais.C82Application.Dto.GG00X.GG001;
using GG104Materiais.C82Application.Dto.GG00X.GG008;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG028
{
    public class DtoGetGG028
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg028Filialid { get; set; }

        public int? Gg028Filial { get; set; }

        public string? Gg028Protocolnumber { get; set; }

        public string? Gg028Origemprograma { get; set; }

        public string? Gg028OrigemPkid { get; set; }

        public DateTime? Gg028DataMovimento { get; set; }

        public DateTime? Gg028DataReferente { get; set; }

        public string? Gg028Almoxid { get; set; }

        public string? Gg028KardexId { get; set; }

        public string? Gg028Produtoid { get; set; }

        public int? CS_GG008_CodigoProduto { get; set; }
        public string? CS_GG008_DescricaoReduzida { get; set; }

        public string? Gg028Saldoid { get; set; }

        public string? Gg028Transacaoid { get; set; }

        public string? Gg028Contaid { get; set; }

        public string? Gg028Usuarioid { get; set; }

        public decimal? Gg028QtdMovimento { get; set; }

        public decimal? Gg028ValorUnitario { get; set; }

        public decimal? Gg028SaldoAnterior { get; set; }

        public string? Gg028DocProtocolnumber { get; set; }

        public string? Gg028DoctoId { get; set; }

        public int? Gg028NPdv { get; set; }

        public decimal? Gg028NfOuCupom { get; set; }

        public int? Gg028EntsaidaId { get; set; }

        public int? Gg028NaturezaId { get; set; }

        public string? Natureza { get; set; }
        public decimal? NF_Cupom { get; set; }
        public string? Nome_Usuario { get; set; }
        public string? Almoxarifado_NS { get; set; }
        public string? TipoMovimento { get; set; }
        public int? CodigoProduto { get; set; }

    }

    public partial class DtoGetGG028ComIncludes : DtoGetGG028
    {
        public DtoGetGG001Simples? NavGG001_Almox { get; set; }
        public Dto_GetBB012_Exibicao? NavBB012_Cliente { get; set; }
        public Dto_GetSY001Simples? NavSY001_Usuario { get; set; }
        public Dto_GetBB027Simples? NavBB027 { get; set; }
        public CSICP_GG028Entsai? Nav_GG028_EntSaida { get; set; }
        public OsusrE9aCsicpGg028Nat? Nav_GG028_Nat { get; set; }
        public DtoGetGG008Simples? Nav_GG008_Produto { get; set; }
        public DtoGetGG520Simples? Nav_GG520_Saldo { get; set; }
    }
}
