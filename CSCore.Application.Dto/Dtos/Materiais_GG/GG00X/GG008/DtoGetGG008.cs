using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.Dto.GG00X.GG060;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG015;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_Models.Staticas.NFS;
using FF105Financeiro.C82Application.Dto.GG00X.GG002;
using FF105Financeiro.C82Application.Dto.GG00X.GG003;
using FF105Financeiro.C82Application.Dto.GG00X.GG004;
using FF105Financeiro.C82Application.Dto.GG00X.GG005;
using FF105Financeiro.C82Application.Dto.GG00X.GG006;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008c;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008Kdx;
using FF105Financeiro.C82Application.Dto.GG00X.GG009;
using FF105Financeiro.C82Application.Dto.GG00X.GG010;
using FF105Financeiro.C82Application.Dto.GG00X.GG011;
using FF105Financeiro.C82Application.Dto.GG00X.GG014;
using FF105Financeiro.C82Application.Dto.GG00X.GG021;
using FF105Financeiro.C82Application.Dto.GG00X.GG029;
using System.Text.Json.Serialization;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG008
{
    public class DtoGetGG008
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

        public int? Gg008TipokitId { get; set; }

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

        public Dto_GetBB001Simples? NavFilialBB001 { get; set; }
        public DtoGetGG002? NavTipodeProdutosGG002 { get; set; }
        public DtoGetGG003_Exibicao_2? NavGrupoProdutoGG003 { get; set; }
        public DtoGetGG004Simples? NavClasseProdutoGG004 { get; set; }
        public DtoGetGG005Simples? NavArtigoProdutoGG005 { get; set; }
        public DtoGetGG006? NavMarcaProdutoGG006 { get; set; }
        public DtoGetGG009Simples? NavPadraoProdutoGG009 { get; set; }
        public DtoGetGG010Simples? NavTipoPadraoProdutoGG010 { get; set; }
        public DtoGetGG011Simples? NavQualidadeProdutoGG011 { get; set; }
        public DtoGetGG014Simples? NavLinhaProdutoGG014 { get; set; }
        public DtoGetGG015? NavSubGrupoProdutoGG015 { get; set; }
        public DtoGetGG021Simples_ComGG021Cest? NavNCMProdutoGG021 { get; set; }
        public DtoGetGG008c? NavGG008cCaracteristica { get; set; }
        public DtoGetGG008c? NavGG008cFichaTecnica { get; set; }


        public DtoGetGG060Simples? NavGG060_GrpSubGrupo { get; set; }
        public DtoGetGG029? NavGG029_ANP { get; set; }
        public Dto_GetSY001Simples? NavSY001_UsuarioProp { get; set; }
        public Dto_GetSY001Simples? NavSY001_UsuarioAlt { get; set; }
        public CSICP_GG008Kit? NavGG008_TipoKit { get; set; }


        public CSICP_GG008Efi? NavGG008_EstadoFisico { get; set; }
        public CSICP_GG008Gar? NavGG008_TpGarantiaCompra { get; set; }
        public CSICP_GG008Gar? NavGG008_TpGarantiaVenda { get; set; }
        public Osusr66cCsicpNfsLstserv? NavGG008_ListServico { get; set; }
        public CSICP_Statica? NavGG008_Etiqueta { get; set; }
        public CSICP_Statica? NavGG008_Usa_Nro_Serie { get; set; }
        public CSICP_Statica? NavGG008_Servico { get; set; }
        public CSICP_Statica? NavGG008_Montavel { get; set; }
        public CSICP_Statica? NavGG008_Pesavel { get; set; }
        public CSICP_Statica? NavGG008_Entregar { get; set; }
        public SpedCsicpStrelevancium? Navgg008_IERelevante { get; set; }
    }

    
}
