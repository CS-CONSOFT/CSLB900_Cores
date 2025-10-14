using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.Extensao;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG008
{
    public class DtoCreateUpdateGG008 : IConverteParaEntidade<CSICP_GG008>
    {
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

        public string? Gg008Dataforalinha { get; set; }

        public int? Gg008ListservicoId { get; set; }

        public int? Gg008Grpsubgrupoid { get; set; }

        public long? Gg008Sequence { get; set; }

        public string? Gg008Dultalteracao { get; set; }

        public int? Gg008Entregar { get; set; }

        public bool? Gg008Isecommerce { get; set; }

        public string? Gg008AnpId { get; set; }

        public string? Gg008Dregistro { get; set; }

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

        public CSICP_GG008 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG008
            {
                Id = id!,
                TenantId = tenant,
                Gg008Filialid = this.Gg008Filialid,
                Gg008Filial = this.Gg008Filial,
                Gg008Codgproduto = this.Gg008Codgproduto,
                //Gg008TipoProduto = this.Gg008TipoProduto,
                Gg008CodigoGrupo = this.Gg008CodigoGrupo,
                Gg008CodigoClasse = this.Gg008CodigoClasse,
                Gg008CodigoArtigo = this.Gg008CodigoArtigo,
                Gg008CodigoMarca = this.Gg008CodigoMarca,
                Gg008CodigoPadrao = this.Gg008CodigoPadrao,
                Gg008CodigoTipo = this.Gg008CodigoTipo,
                Gg008CodigoQualidade = this.Gg008CodigoQualidade,
                Gg008Tipoprodutoid = this.Gg008Tipoprodutoid,
                Gg008Grupoid = this.Gg008Grupoid,
                Gg008Subgrupoid = this.Gg008Subgrupoid,
                Gg008Classeid = this.Gg008Classeid,
                Gg008Artigoid = this.Gg008Artigoid,
                Gg008Marcaid = this.Gg008Marcaid,
                Gg008Linhaid = this.Gg008Linhaid,
                Gg008Padraoid = this.Gg008Padraoid,
                Gg008Tipoid = this.Gg008Tipoid,
                Gg008Qualidadeid = this.Gg008Qualidadeid,
                Gg008Referencia = this.Gg008Referencia,
                Gg008Complemento = this.Gg008Complemento,
                Gg008Codindustrial = this.Gg008Codindustrial,
                Gg008Safradiamesinicio = this.Gg008Safradiamesinicio,
                Gg008SafraDiamesfim = this.Gg008SafraDiamesfim,
                Gg008Etiqueta = this.Gg008Etiqueta,
                Gg008Ncm = this.Gg008Ncm,
                Gg008ExNcm = this.Gg008ExNcm,
                Gg008Ncmid = this.Gg008Ncmid,
                Gg008PesoBruto = this.Gg008PesoBruto,
                Gg008PesoLiquido = this.Gg008PesoLiquido,
                Gg008Tamanho = this.Gg008Tamanho,
                Gg008Largura = this.Gg008Largura,
                Gg008Espessura = this.Gg008Espessura,
                Gg008Embalagem1 = this.Gg008Embalagem1,
                Gg008Embalagem2 = this.Gg008Embalagem2,
                Gg008QtdEmbalagem1 = this.Gg008QtdEmbalagem1,
                Gg008QtdEmbalagem2 = this.Gg008QtdEmbalagem2,
                Gg008Comprimentoarmaz = this.Gg008Comprimentoarmaz,
                Gg008LarguraArmaz = this.Gg008LarguraArmaz,
                Gg008AlturaArmaz = this.Gg008AlturaArmaz,
                Gg008FatorArmaz = this.Gg008FatorArmaz,
                Gg008Empilhagem = this.Gg008Empilhagem,
                Gg008Descreduzida = this.Gg008Descreduzida,
                Gg008UsaNroSerie = this.Gg008UsaNroSerie,
                Gg008Refersimilar = this.Gg008Refersimilar,
                Gg008Przgarancompra = this.Gg008Przgarancompra,
                Gg008Przgaranvenda = this.Gg008Przgaranvenda,
                Gg008Servico = this.Gg008Servico,
                Gg008Montavel = this.Gg008Montavel,
                Gg008Classifvegetal = this.Gg008Classifvegetal,
                Gg008IsActive = this.Gg008IsActive,
                Gg008EstadofisicoId = this.Gg008EstadofisicoId,
                Gg008TpgarantiacompraId = this.Gg008TpgarantiacompraId,
                Gg008TpgarantiavendaId = this.Gg008TpgarantiavendaId,
                //Gg008TipokitId = this.Gg008TipokitId,
                Gg008PesavelId = this.Gg008PesavelId,
                Gg008Isforalinha = this.Gg008Isforalinha,
                Gg008Dataforalinha = this.Gg008Dataforalinha.ConverteStringVaziaParaDataNula(),
                Gg008ListservicoId = this.Gg008ListservicoId,
                Gg008Grpsubgrupoid = this.Gg008Grpsubgrupoid,
                Gg008Sequence = this.Gg008Sequence,
                Gg008Dultalteracao = this.Gg008Dultalteracao.ConverteStringVaziaParaDataNula(),
                Gg008Entregar = this.Gg008Entregar,
                Gg008Isecommerce = this.Gg008Isecommerce,
                Gg008AnpId = this.Gg008AnpId,
                Gg008Dregistro = this.Gg008Dregistro.ConverteStringVaziaParaDataNula(),
                Gg008Usuariopropid = this.Gg008Usuariopropid,
                Gg008Usuarioaltid = this.Gg008Usuarioaltid,
                Gg008Ierelevanteid = this.Gg008Ierelevanteid,
                Gg008Cnpjfabricante = this.Gg008Cnpjfabricante,
                Gg008Nomefabricante = this.Gg008Nomefabricante,
                Gg008Vicmsproprio = this.Gg008Vicmsproprio,
                //Gg008Descpeqwms1 = this.Gg008Descpeqwms1,
                //Gg008Descpeqwms2 = this.Gg008Descpeqwms2,
                Gg008Descespecial1 = this.Gg008Descespecial1,
                Gg008Descespecial2 = this.Gg008Descespecial2,

            };
        }
    }
}
