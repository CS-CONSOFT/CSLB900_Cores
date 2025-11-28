using CSBS101._82Application.Dto.AA00X;
using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Xml;
using CSBS101.C82Application.Dto.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA028;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get.BB012MDFe;
using CSCore.Application.Dto.Dtos.DD;
using CSCore.Application.Dto.Dtos.DD.DD041;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.AA;
using EnviaNFeHercules.C82Application.Dto.DD.DD042;
using EnviaNFeHercules.C82Application.Dto.DD.DD043;
using EnviaNFeHercules.C82Application.Dto.DD.DD044;
using EnviaNFeHercules.C82Application.Dto.DD.DD045;
using EnviaNFeHercules.C82Application.Dto.DD.DD048;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD040
{
    public class DtoGetDD040
    {
        public int TenantId { get; set; }

        public string Dd040Id { get; set; } = null!;

        public string? Dd040Empresaid { get; set; }

        public string? Dd042Chaveacessonfe { get; set; }

        public int? Dd040Filial { get; set; }

        public int? Dd040TipoMovimento { get; set; }

        public string? Dd040Serie { get; set; }

        public int? Dd040NoNf { get; set; }

        public int? Dd040NoPedido { get; set; }

        public int? Dd040NoEstacao { get; set; }

        public int? Dd040NoPdv { get; set; }

        public string? Dd040SerieCupom { get; set; }

        public int? Dd040NoCupom { get; set; }

        public DateTime? Dd040DataEmissao { get; set; }

        public DateTime? Dd040Datahoraemissao { get; set; }

        public string? Dd040ContaId { get; set; }

        public string? Dd040ContarealId { get; set; }

        public string? Dd040AvalistaId { get; set; }

        public string? Dd040CcustoId { get; set; }

        public string? Dd040AgcobradorId { get; set; }

        public string? Dd040CondPagtoId { get; set; }

        public string? Dd040ResponsavelId { get; set; }

        public string? Dd040NatoperacaoId { get; set; }

        public string? Dd040AlmoxdestinoId { get; set; }

        public int? Dd040CodgCcusto { get; set; }

        public int? Dd040CodgAgcobrador { get; set; }

        public int? Dd040CodgCondPagto { get; set; }

        public int? Dd040Codrespvendedor { get; set; }

        public int? Dd040Codrespcomprador { get; set; }

        public string? Dd040Codnatoperacao { get; set; }

        public int? Dd040Codalmoxdestino { get; set; }

        public decimal? Dd040Perc1Desconto { get; set; }

        public decimal? Dd040Perc2Desconto { get; set; }

        public decimal? Dd040Perc3Desconto { get; set; }

        public decimal? Dd040Perc4Desconto { get; set; }

        public decimal? Dd040Perc5Desconto { get; set; }

        public decimal? Dd040TotalDescsuframa { get; set; }

        public decimal? Dd040TotalBruto { get; set; }

        public decimal? Dd040TotalFrete { get; set; }

        public int? Dd040FreteCifFob { get; set; }

        public decimal? Dd040TotalSeguro { get; set; }

        public decimal? Dd040TotalOutdespesas { get; set; }

        public decimal? Dd040Desconto { get; set; }

        public decimal? Dd040Acrescimo { get; set; }

        public decimal? Dd040TotalLiquido { get; set; }

        public decimal? Dd040TotalServico { get; set; }

        public decimal? Dd040Percdescservico { get; set; }

        public decimal? Dd040Vlrdescservico { get; set; }

        public decimal? Dd040Totliqservico { get; set; }

        public decimal? Dd040TotalprodEServ { get; set; }

        public decimal? Dd040ValorEntrada { get; set; }

        public int? Dd040QtdeParcelas { get; set; }

        public decimal? Dd040Vlrafinanciar { get; set; }

        public string? Dd040Texto { get; set; }

        public int? Dd040QtdVolumes { get; set; }

        public string? Dd040Especie { get; set; }

        public string? Dd040Marca { get; set; }

        public string? Dd040Nvol { get; set; }

        public decimal? Dd040PesoLiquido { get; set; }

        public decimal? Dd040PesoBruto { get; set; }

        public DateTime? Dd040DataSaida { get; set; }

        public DateTime? Dd040HoraSaida { get; set; }

        public string? Dd040Codtabelapreco { get; set; }

        public int? Dd040NumeroPreco { get; set; }

        public string? Dd040UsuarioImp { get; set; }

        public DateTime? Dd040DataImpressao { get; set; }

        public DateTime? Dd040HoraImpressao { get; set; }

        public int? Dd040NumImpressoes { get; set; }

        public string? Dd040NroContrato { get; set; }

        public decimal? Dd040NroRomaneio { get; set; }

        public string? Dd040Empenho { get; set; }

        public string? Dd040Processo { get; set; }

        public decimal? Dd040NoRequisicao { get; set; }

        public int? Dd040Comissao { get; set; }

        public DateTime? Dd040DataMovimento { get; set; }

        public int? Dd040Situacao { get; set; }

        public string? Dd040PrazoEntrega { get; set; }

        public decimal? Dd040CiOrcamento { get; set; }

        public int? Dd040CodgAtendente { get; set; }

        public string? Dd040UsuarioAtendenteid { get; set; }

        public string? Dd040UsuarioProprId { get; set; }

        public int? Dd040ClassecontaId { get; set; }

        public int? Dd040StatusEstoqueId { get; set; }

        public decimal? Dd040Vbc { get; set; }

        public decimal? Dd040Vicms { get; set; }

        public decimal? Dd040Vicmsdeson { get; set; }

        public decimal? Dd040Vicmsufdest { get; set; }

        public decimal? Dd040Vicmsufremet { get; set; }

        public decimal? Dd040Vfcpufdest { get; set; }

        public decimal? Dd040Vbcst { get; set; }

        public decimal? Dd040Vst { get; set; }

        public decimal? Dd040Vii { get; set; }

        public decimal? Dd040Vipi { get; set; }

        public decimal? Dd040Vpis { get; set; }

        public decimal? Dd040Vcofins { get; set; }

        public decimal? Dd040Vfcp { get; set; }

        public decimal? Dd040Vfcpst { get; set; }

        public decimal? Dd040Vfcpstret { get; set; }

        public decimal? Dd040Vipidevol { get; set; }

        public decimal? Dd040TotValorAproxImp { get; set; }

        public decimal? Dd040ServVcofins { get; set; }

        public decimal? Dd040ServVbc { get; set; }

        public decimal? Dd040ServViss { get; set; }

        public decimal? Dd040ServVpis { get; set; }

        public int? Dd040ServDcompet { get; set; }

        public decimal? Dd040ServVissret { get; set; }

        public decimal? Dd040ServVoutro { get; set; }

        public decimal? Dd040ServVdescincond { get; set; }

        public decimal? Dd040ServVdesccond { get; set; }

        public int? Dd040ServCregtrib { get; set; }

        public string? Dd040OrigemNota { get; set; }

        public int? Dd040Status { get; set; }

        public string? Dd040NfEntregueSn { get; set; }

        public string? Dd040Alfa50 { get; set; }

        public bool? Dd040Isorigemdecupom { get; set; }

        public bool? Dd040Isgrupada { get; set; }

        public decimal? Dd040Valor1 { get; set; }

        public decimal? Dd040Valor2 { get; set; }

        public decimal? Dd040Valor3 { get; set; }

        public decimal? Dd040Valor4 { get; set; }

        public decimal? Dd040Valor5 { get; set; }

        public int? Dd040SitNfeId { get; set; }

        public int? Dd040TiponotaId { get; set; }

        public int? Dd040ModId { get; set; }

        public string? Dd040CtrlSerieNfId { get; set; }

        public decimal? NfeNprot { get; set; }

        public decimal? NfeNrec { get; set; }

        public decimal? NfeEpecNprot { get; set; }

        public int? Dd040DispId { get; set; }

        public string? Dd040Numeroautorizacao { get; set; }

        public string? Dd040CompContaId { get; set; }

        public string? Dd040Protocolnumber { get; set; }

        public int? Dd040Indpres { get; set; }

        public int? Dd040Tpemis { get; set; }

        public string? Dd040Finnfe { get; set; }

        public string? Dd040Dhcont { get; set; }

        public string? Dd040Xjust { get; set; }

        public int? Dd040Tpamb { get; set; }

        public string? Dd040Tzd { get; set; }

        public string? Dd040Dhaut { get; set; }

        public string? Dd040Digval { get; set; }

        public string? Dd040Urlqrcode { get; set; }

        public string? Dd040Arquitetoid { get; set; }

        public string? Dd040Natop { get; set; }

        public int? Dd040Transcomtef { get; set; }

        public int? Dd040Modalidadefrete { get; set; }

        public bool? Dd040Islibentregaliq { get; set; }

        public int? Dd040CtbIscontabilizadoid { get; set; }

        public string? Dd040CtbUsuarioid { get; set; }

        public DateTime? Dd040CtbDtregistro { get; set; }

        public int? Dd040CtbIsestornadoid { get; set; }

        public string? Dd040CtbEstusuarioid { get; set; }

        public DateTime? Dd040CtbEstdtreg { get; set; }

        public long? Dd040CtbIdlancto { get; set; }

        public string? Dd040CtbMsg { get; set; }

        public string? Dd040UsuarioEntregaid { get; set; }

        public DateTime? Dd040Dhentrega { get; set; }

        public string? Dd040SatChaveCanc { get; set; }

        public string? Dd040SatSerieCanc { get; set; }

        public int? Dd040SatNoCfeCanc { get; set; }

        public string? Dd040SatQrcodeCanc { get; set; }

        public DateTime? Dd040DhCanc { get; set; }

        public bool? Dd040Islocksat { get; set; }

        public long? Dd040Romaneioid { get; set; }

        public int? Dd040Motdesoneracaoid { get; set; }

        public decimal? Dd040Picmsdesonerado { get; set; }

        public int? Dd040VicmsdesonsubId { get; set; }

        public string? Dd040Usuariofaturistaid { get; set; }

        public string? Dd040CorreiosCodRastreio { get; set; }

        public string? Dd040CorreiosSiglaTriagem { get; set; }

        public string? Dd040CorreiosDetalhe { get; set; }

        public bool? Dd040Isvendaonline { get; set; }

        public int? Dd040Modentregaid { get; set; }

        public int? Dd040StEntregaId { get; set; }

        public string? Dd040CnpjMarketplace { get; set; }

        public string? Dd040Marketplace { get; set; }

        public string? Dd040Chavecashback { get; set; }

        public decimal? W06b1Qbcmono { get; set; }

        public decimal? W06cVicmsmono { get; set; }

        public decimal? W06c1Qbcmonoreten { get; set; }

        public decimal? W06dVicmsmonoreten { get; set; }

        public decimal? W06d1Qbcmonoret { get; set; }

        public decimal? W06eVicmsmonoret { get; set; }

        public int? Dd040Origemregpv { get; set; }

        public string? Dd040Keyecommerce { get; set; }

        //---------------------Reforma Tributária---------------------//

        public decimal? W33_VIS { get; set; }
        public decimal? W35_VBCIBSCBS { get; set; }
        public decimal? W38_IBSUF_VDIF { get; set; }
        public decimal? W39_IBSUF_VDEVTRIB { get; set; }
        public decimal? W41_VIBSUF { get; set; }
        public decimal? W43_IBSMUN_VDIF { get; set; }
        public decimal? W44_IBSMUN__VDEVTRIB { get; set; }
        public decimal? W46_VIBSMUN { get; set; }
        public decimal? W47_VIBSTOT { get; set; }
        public decimal? W48_VCREDPRES { get; set; }
        public decimal? W49_VCREDPRESCONDSUS { get; set; }
        public decimal? W53_CBS_VDIF { get; set; }
        public decimal? W54_CBS_VDEVTRIB { get; set; }
        public decimal? W56A_CBS_VCREDPRES { get; set; }
        public decimal? W56B_CBS_VCREDPRESCONDSUS { get; set; }
        public decimal? W58_VTOTIBSMONO { get; set; }
        public decimal? W59_VTOTCBSMONO { get; set; }
        public int? DD040_TPDEBCREID { get; set; }
        public decimal? W59B_VCBSMONORETEN { get; set; }
        public decimal? W59C_VIBSMONORETEN { get; set; }
        public decimal? W59D_VCBSMONORET { get; set; }
        public decimal? W60_VTOTNF { get; set; }
        public decimal? B33_PREDUTOR { get; set; }
        public int? B34_TPOPERGOVID { get; set; }

        //---Navs Reforma Tributária---//
        public OsusrE9aCsicpAa145Tpdebcre? NavAa145Tpdebcre { get; set; }
        public OsusrE9aCsicpAa149Tpopgov? NavAa149Tpopgov { get; set; }


        //------------------------------------------------------------//
        public DtoGet_BB012MDFe? NavBB012Conta { get; set; }
        public DtoGet_BB001paraMDFe? NavBB001 { get; set; }
        public OsusrNnxSpedInDocIcm? NavSpedIcm { get; set; }
        public CSICP_DD909? NavDD909 { get; set; }
        public CSICP_DD040Tnt? NavDD040Tnt { get; set; }
        public CSICP_DD040Ipre? NavDD040Ipre { get; set; }
        public CSICP_DD041Frete? NavDD041Frete { get; set; }
        public List<DtoGetDD041> NavListDD041 { get; set; } = new List<DtoGetDD041>();
        public List<DtoGetDD042> NavListDD042 { get; set; } = new List<DtoGetDD042>();
        public List<DtoGetDD044> NavListDD044 { get; set; } = new List<DtoGetDD044>();
        public List<DtoGetDD045> NavListDD045 { get; set; } = new List<DtoGetDD045>();
        public List<DtoGetDD048> NavListDD048 { get; set; } = new List<DtoGetDD048>();
        public List<Dto_GetXmlFromBB001> NavListBB001AXML { get; set; } = new List<Dto_GetXmlFromBB001>();
        public DD000BinarioDtoGet? NavDD000Config { get; set; }
    }
}

