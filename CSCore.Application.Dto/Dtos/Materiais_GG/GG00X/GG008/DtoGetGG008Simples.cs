using GG104Materiais.C82Application.Dto.GG00X.GG003;
using GG104Materiais.C82Application.Dto.GG00X.GG004;
using GG104Materiais.C82Application.Dto.GG00X.GG005;
using GG104Materiais.C82Application.Dto.GG00X.GG006;

namespace GG104Materiais.C82Application.Dto.GG00X.GG008
{
    public class DtoGetGG008Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg008Filialid { get; set; }

        public int? Gg008Filial { get; set; }

        public int? Gg008Codgproduto { get; set; }

        public string? Gg008TipoProduto { get; set; }

        public int? Gg008CodigoGrupo { get; set; }

        public int? Gg008CodigoClasse { get; set; }

        public int? Gg008CodigoArtigo { get; set; }

        public int? Gg008CodigoMarca { get; set; }

        public string? Gg008CodigoPadrao { get; set; }

        public string? Gg008CodigoTipo { get; set; }

        public string? Gg008CodigoQualidade { get; set; }

        public string? Gg008Tipoprodutoid { get; set; }

        public string? Gg008Grupoid { get; set; }

        public string? Gg008Subgrupoid { get; set; }

        public string? Gg008Classeid { get; set; }

        public string? Gg008Artigoid { get; set; }

        public string? Gg008Marcaid { get; set; }

        public string? Gg008Linhaid { get; set; }

        public string? Gg008Padraoid { get; set; }

        public string? Gg008Tipoid { get; set; }

        public string? Gg008Qualidadeid { get; set; }

        public string? Gg008Referencia { get; set; }

        public string? Gg008Complemento { get; set; }

        public string? Gg008Codindustrial { get; set; }

        public int? Gg008Safradiamesinicio { get; set; }

        public int? Gg008SafraDiamesfim { get; set; }

        public int? Gg008Etiqueta { get; set; }

        public int? Gg008Ncm { get; set; }

        public string? Gg008ExNcm { get; set; }

        public string? Gg008Ncmid { get; set; }

        public decimal? Gg008PesoBruto { get; set; }

        public decimal? Gg008PesoLiquido { get; set; }

        public decimal? Gg008Tamanho { get; set; }

        public decimal? Gg008Largura { get; set; }

        public decimal? Gg008Espessura { get; set; }

        public string? Gg008Embalagem1 { get; set; }

        public string? Gg008Embalagem2 { get; set; }

        public decimal? Gg008QtdEmbalagem1 { get; set; }

        public decimal? Gg008QtdEmbalagem2 { get; set; }

        public decimal? Gg008Comprimentoarmaz { get; set; }

        public decimal? Gg008LarguraArmaz { get; set; }

        public decimal? Gg008AlturaArmaz { get; set; }

        public decimal? Gg008FatorArmaz { get; set; }

        public decimal? Gg008Empilhagem { get; set; }

        public string? Gg008Descreduzida { get; set; }

        public int? Gg008UsaNroSerie { get; set; }

        public string? Gg008Refersimilar { get; set; }

        public int? Gg008Przgarancompra { get; set; }

        public int? Gg008Przgaranvenda { get; set; }

        public int? Gg008Servico { get; set; }

        public int? Gg008Montavel { get; set; }

        public string? Gg008Classifvegetal { get; set; }

        public bool? Gg008IsActive { get; set; }

        public int? Gg008EstadofisicoId { get; set; }

        public int? Gg008TpgarantiacompraId { get; set; }

        public int? Gg008TpgarantiavendaId { get; set; }

        //public int? Gg008TipokitId { get; set; }

        public int? Gg008PesavelId { get; set; }

        public bool? Gg008Isforalinha { get; set; }

        public DateTime? Gg008Dataforalinha { get; set; }

        public int? Gg008ListservicoId { get; set; }

        public int? Gg008Grpsubgrupoid { get; set; }

        public long? Gg008Sequence { get; set; }

        public DateTime? Gg008Dultalteracao { get; set; }

        public int? Gg008Entregar { get; set; }

        public bool? Gg008Isecommerce { get; set; }

        public string? Gg008AnpId { get; set; }

        public DateTime? Gg008Dregistro { get; set; }

        public string? Gg008Usuariopropid { get; set; }

        public string? Gg008Usuarioaltid { get; set; }

        public int? Gg008Ierelevanteid { get; set; }

        public string? Gg008Cnpjfabricante { get; set; }

        public string? Gg008Nomefabricante { get; set; }

        public decimal? Gg008Vicmsproprio { get; set; }

        public string? Gg008Descpeqwms1 { get; set; }

        public string? Gg008Descpeqwms2 { get; set; }

        public string? Gg008Descespecial1 { get; set; }

        public string? Gg008Descespecial2 { get; set; }

        public decimal? CS_GG008Kdx_PrcEcommerce { get; set; }
        public string? CS_GG015SubGrupo_Label { get; set; }
    }



    public class DtoGetGG008_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg008Codgproduto { get; set; }

        public string? Gg008Descreduzida { get; set; }

        public DtoGetGG003_Exibicao? NavGrupoProdutoGG003 { get; set; }
        public DtoGG004_Exibicao? NavClasseProdutoGG004 { get; set; }
        public DtoGetGG005_Exibicao? NavArtigoProdutoGG005 { get; set; }
        public DtoGetGG006_Exibicao? NavMarcaProdutoGG006 { get; set; }
    }

    public class DtoGetGG008_Exibicao_Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg008Codgproduto { get; set; }

        public string? Gg008Descreduzida { get; set; }
    }
}
