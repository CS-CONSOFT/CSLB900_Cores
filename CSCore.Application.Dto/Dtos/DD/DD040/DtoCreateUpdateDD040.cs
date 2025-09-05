using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD040
{
    public class DtoCreateUpdateDD040 : IConverteParaEntidade<CSICP_DD040>
    {
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
        public int? DD070_TPDEBCREID { get; set; }
        public decimal? W59B_VCBSMONORETEN { get; set; }
        public decimal? W59C_VIBSMONORETEN { get; set; }
        public decimal? W59D_VCBSMONORET { get; set; }
        public decimal? W60_VTOTNF { get; set; }
        public decimal? B33_PREDUTOR { get; set; }
        public int? B34_TPOPERGOVID { get; set; }

        //--------------------------------------------------//

        public CSICP_DD040 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD040
            {
                TenantId = tenant,
                Dd040Id = id!,
                Dd040Empresaid = this.Dd040Empresaid,
                Dd042Chaveacessonfe = this.Dd042Chaveacessonfe,
                Dd040Filial = this.Dd040Filial,
                Dd040TipoMovimento = this.Dd040TipoMovimento,
                Dd040Serie = this.Dd040Serie,
                Dd040NoNf = this.Dd040NoNf,
                Dd040NoPedido = this.Dd040NoPedido,
                Dd040NoEstacao = this.Dd040NoEstacao,
                Dd040NoPdv = this.Dd040NoPdv,
                Dd040SerieCupom = this.Dd040SerieCupom,
                Dd040NoCupom = this.Dd040NoCupom,
                Dd040DataEmissao = this.Dd040DataEmissao,
                Dd040Datahoraemissao = this.Dd040Datahoraemissao,
                Dd040ContaId = this.Dd040ContaId,
                Dd040ContarealId = this.Dd040ContarealId,
                Dd040AvalistaId = this.Dd040AvalistaId,
                Dd040CcustoId = this.Dd040CcustoId,
                Dd040AgcobradorId = this.Dd040AgcobradorId,
                Dd040CondPagtoId = this.Dd040CondPagtoId,
                Dd040ResponsavelId = this.Dd040ResponsavelId,
                Dd040NatoperacaoId = this.Dd040NatoperacaoId,
                Dd040AlmoxdestinoId = this.Dd040AlmoxdestinoId,
                Dd040CodgCcusto = this.Dd040CodgCcusto,
                Dd040CodgAgcobrador = this.Dd040CodgAgcobrador,
                Dd040CodgCondPagto = this.Dd040CodgCondPagto,
                Dd040Codrespvendedor = this.Dd040Codrespvendedor,
                Dd040Codrespcomprador = this.Dd040Codrespcomprador,
                Dd040Codnatoperacao = this.Dd040Codnatoperacao,
                Dd040Codalmoxdestino = this.Dd040Codalmoxdestino,
                Dd040Perc1Desconto = this.Dd040Perc1Desconto,
                Dd040Perc2Desconto = this.Dd040Perc2Desconto,
                Dd040Perc3Desconto = this.Dd040Perc3Desconto,
                Dd040Perc4Desconto = this.Dd040Perc4Desconto,
                Dd040Perc5Desconto = this.Dd040Perc5Desconto,
                Dd040TotalDescsuframa = this.Dd040TotalDescsuframa,
                Dd040TotalBruto = this.Dd040TotalBruto,
                Dd040TotalFrete = this.Dd040TotalFrete,
                Dd040FreteCifFob = this.Dd040FreteCifFob,
                Dd040TotalSeguro = this.Dd040TotalSeguro,
                Dd040TotalOutdespesas = this.Dd040TotalOutdespesas,
                Dd040Desconto = this.Dd040Desconto,
                Dd040Acrescimo = this.Dd040Acrescimo,
                Dd040TotalLiquido = this.Dd040TotalLiquido,
                Dd040TotalServico = this.Dd040TotalServico,
                Dd040Percdescservico = this.Dd040Percdescservico,
                Dd040Vlrdescservico = this.Dd040Vlrdescservico,
                Dd040Totliqservico = this.Dd040Totliqservico,
                Dd040TotalprodEServ = this.Dd040TotalprodEServ,
                Dd040ValorEntrada = this.Dd040ValorEntrada,
                Dd040QtdeParcelas = this.Dd040QtdeParcelas,
                Dd040Vlrafinanciar = this.Dd040Vlrafinanciar,
                Dd040Texto = this.Dd040Texto,
                Dd040QtdVolumes = this.Dd040QtdVolumes,
                Dd040Especie = this.Dd040Especie,
                Dd040Marca = this.Dd040Marca,
                Dd040Nvol = this.Dd040Nvol,
                Dd040PesoLiquido = this.Dd040PesoLiquido,
                Dd040PesoBruto = this.Dd040PesoBruto,
                Dd040DataSaida = this.Dd040DataSaida,
                Dd040HoraSaida = this.Dd040HoraSaida,
                Dd040Codtabelapreco = this.Dd040Codtabelapreco,
                Dd040NumeroPreco = this.Dd040NumeroPreco,
                Dd040UsuarioImp = this.Dd040UsuarioImp,
                Dd040DataImpressao = this.Dd040DataImpressao,
                Dd040HoraImpressao = this.Dd040HoraImpressao,
                Dd040NumImpressoes = this.Dd040NumImpressoes,
                Dd040NroContrato = this.Dd040NroContrato,
                Dd040NroRomaneio = this.Dd040NroRomaneio,
                Dd040Empenho = this.Dd040Empenho,
                Dd040Processo = this.Dd040Processo,
                Dd040NoRequisicao = this.Dd040NoRequisicao,
                Dd040Comissao = this.Dd040Comissao,
                Dd040DataMovimento = this.Dd040DataMovimento,
                Dd040Situacao = this.Dd040Situacao,
                Dd040PrazoEntrega = this.Dd040PrazoEntrega,
                Dd040CiOrcamento = this.Dd040CiOrcamento,
                Dd040CodgAtendente = this.Dd040CodgAtendente,
                Dd040UsuarioAtendenteid = this.Dd040UsuarioAtendenteid,
                Dd040UsuarioProprId = this.Dd040UsuarioProprId,
                Dd040ClassecontaId = this.Dd040ClassecontaId,
                Dd040StatusEstoqueId = this.Dd040StatusEstoqueId,
                Dd040Vbc = this.Dd040Vbc,
                Dd040Vicms = this.Dd040Vicms,
                Dd040Vicmsdeson = this.Dd040Vicmsdeson,
                Dd040Vicmsufdest = this.Dd040Vicmsufdest,
                Dd040Vicmsufremet = this.Dd040Vicmsufremet,
                Dd040Vfcpufdest = this.Dd040Vfcpufdest,
                Dd040Vbcst = this.Dd040Vbcst,
                Dd040Vst = this.Dd040Vst,
                Dd040Vii = this.Dd040Vii,
                Dd040Vipi = this.Dd040Vipi,
                Dd040Vpis = this.Dd040Vpis,
                Dd040Vcofins = this.Dd040Vcofins,
                Dd040Vfcp = this.Dd040Vfcp,
                Dd040Vfcpst = this.Dd040Vfcpst,
                Dd040Vfcpstret = this.Dd040Vfcpstret,
                Dd040Vipidevol = this.Dd040Vipidevol,
                Dd040TotValorAproxImp = this.Dd040TotValorAproxImp,
                Dd040ServVcofins = this.Dd040ServVcofins,
                Dd040ServVbc = this.Dd040ServVbc,
                Dd040ServViss = this.Dd040ServViss,
                Dd040ServVpis = this.Dd040ServVpis,
                Dd040ServDcompet = this.Dd040ServDcompet,
                Dd040ServVissret = this.Dd040ServVissret,
                Dd040ServVoutro = this.Dd040ServVoutro,
                Dd040ServVdescincond = this.Dd040ServVdescincond,
                Dd040ServVdesccond = this.Dd040ServVdesccond,
                Dd040ServCregtrib = this.Dd040ServCregtrib,
                Dd040OrigemNota = this.Dd040OrigemNota,
                Dd040Status = this.Dd040Status,
                Dd040NfEntregueSn = this.Dd040NfEntregueSn,
                Dd040Alfa50 = this.Dd040Alfa50,
                Dd040Isorigemdecupom = this.Dd040Isorigemdecupom,
                Dd040Isgrupada = this.Dd040Isgrupada,
                Dd040Valor1 = this.Dd040Valor1,
                Dd040Valor2 = this.Dd040Valor2,
                Dd040Valor3 = this.Dd040Valor3,
                Dd040Valor4 = this.Dd040Valor4,
                Dd040Valor5 = this.Dd040Valor5,
                Dd040SitNfeId = this.Dd040SitNfeId,
                Dd040TiponotaId = this.Dd040TiponotaId,
                Dd040ModId = this.Dd040ModId,
                Dd040CtrlSerieNfId = this.Dd040CtrlSerieNfId,
                NfeNprot = this.NfeNprot,
                NfeNrec = this.NfeNrec,
                NfeEpecNprot = this.NfeEpecNprot,
                Dd040DispId = this.Dd040DispId,
                Dd040Numeroautorizacao = this.Dd040Numeroautorizacao,
                Dd040CompContaId = this.Dd040CompContaId,
                Dd040Protocolnumber = this.Dd040Protocolnumber,
                Dd040Indpres = this.Dd040Indpres,
                Dd040Tpemis = this.Dd040Tpemis,
                Dd040Finnfe = this.Dd040Finnfe,
                Dd040Dhcont = this.Dd040Dhcont,
                Dd040Xjust = this.Dd040Xjust,
                Dd040Tpamb = this.Dd040Tpamb,
                Dd040Tzd = this.Dd040Tzd,
                Dd040Dhaut = this.Dd040Dhaut,
                Dd040Digval = this.Dd040Digval,
                Dd040Urlqrcode = this.Dd040Urlqrcode,
                Dd040Arquitetoid = this.Dd040Arquitetoid,
                Dd040Natop = this.Dd040Natop,
                Dd040Transcomtef = this.Dd040Transcomtef,
                Dd040Modalidadefrete = this.Dd040Modalidadefrete,
                Dd040Islibentregaliq = this.Dd040Islibentregaliq,
                Dd040CtbIscontabilizadoid = this.Dd040CtbIscontabilizadoid,
                Dd040CtbUsuarioid = this.Dd040CtbUsuarioid,
                Dd040CtbDtregistro = this.Dd040CtbDtregistro,
                Dd040CtbIsestornadoid = this.Dd040CtbIsestornadoid,
                Dd040CtbEstusuarioid = this.Dd040CtbEstusuarioid,
                Dd040CtbEstdtreg = this.Dd040CtbEstdtreg,
                Dd040CtbIdlancto = this.Dd040CtbIdlancto,
                Dd040CtbMsg = this.Dd040CtbMsg,
                Dd040UsuarioEntregaid = this.Dd040UsuarioEntregaid,
                Dd040Dhentrega = this.Dd040Dhentrega,
                Dd040SatChaveCanc = this.Dd040SatChaveCanc,
                Dd040SatSerieCanc = this.Dd040SatSerieCanc,
                Dd040SatNoCfeCanc = this.Dd040SatNoCfeCanc,
                Dd040SatQrcodeCanc = this.Dd040SatQrcodeCanc,
                Dd040DhCanc = this.Dd040DhCanc,
                Dd040Islocksat = this.Dd040Islocksat,
                Dd040Romaneioid = this.Dd040Romaneioid,
                Dd040Motdesoneracaoid = this.Dd040Motdesoneracaoid,
                Dd040Picmsdesonerado = this.Dd040Picmsdesonerado,
                Dd040VicmsdesonsubId = this.Dd040VicmsdesonsubId,
                Dd040Usuariofaturistaid = this.Dd040Usuariofaturistaid,
                Dd040CorreiosCodRastreio = this.Dd040CorreiosCodRastreio,
                Dd040CorreiosSiglaTriagem = this.Dd040CorreiosSiglaTriagem,
                Dd040CorreiosDetalhe = this.Dd040CorreiosDetalhe,
                Dd040Isvendaonline = this.Dd040Isvendaonline,
                Dd040Modentregaid = this.Dd040Modentregaid,
                Dd040StEntregaId = this.Dd040StEntregaId,
                Dd040CnpjMarketplace = this.Dd040CnpjMarketplace,
                Dd040Marketplace = this.Dd040Marketplace,
                Dd040Chavecashback = this.Dd040Chavecashback,
                W06b1Qbcmono = this.W06b1Qbcmono,
                W06cVicmsmono = this.W06cVicmsmono,
                W06c1Qbcmonoreten = this.W06c1Qbcmonoreten,
                W06dVicmsmonoreten = this.W06dVicmsmonoreten,
                W06d1Qbcmonoret = this.W06d1Qbcmonoret,
                W06eVicmsmonoret = this.W06eVicmsmonoret,
                Dd040Origemregpv = this.Dd040Origemregpv,
                Dd040Keyecommerce = this.Dd040Keyecommerce,
                //W33_VIS = this.W33_VIS,
                W35_VBCIBSCBS = this.W35_VBCIBSCBS,
                W38_IBSUF_VDIF = this.W38_IBSUF_VDIF,
                W39_IBSUF_VDEVTRIB = this.W39_IBSUF_VDEVTRIB,
                W41_VIBSUF = this.W41_VIBSUF,
                W43_IBSMUN_VDIF = this.W43_IBSMUN_VDIF,
                W44_IBSMUN__VDEVTRIB = this.W44_IBSMUN__VDEVTRIB,
                W46_VIBSMUN = this.W46_VIBSMUN,
                //W47_VIBSTOT = this.W47_VIBSTOT,
                //W48_VCREDPRES = this.W48_VCREDPRES,
                //W49_VCREDPRESCONDSUS = this.W49_VCREDPRESCONDSUS,
                W53_CBS_VDIF = this.W53_CBS_VDIF,
                W54_CBS_VDEVTRIB = this.W54_CBS_VDEVTRIB,
                W56A_CBS_VCREDPRES = this.W56A_CBS_VCREDPRES,
                W56B_CBS_VCREDPRESCONDSUS = this.W56B_CBS_VCREDPRESCONDSUS,
                W58_VTOTIBSMONO = this.W58_VTOTIBSMONO,
                W59_VTOTCBSMONO = this.W59_VTOTCBSMONO,
                DD070_TPDEBCREID = this.DD070_TPDEBCREID,
                W59B_VCBSMONORETEN = this.W59B_VCBSMONORETEN,
                W59C_VIBSMONORETEN = this.W59C_VIBSMONORETEN,
                W59D_VCBSMONORET = this.W59D_VCBSMONORET,
                W60_VTOTNF = this.W60_VTOTNF,
                B33_PREDUTOR = this.B33_PREDUTOR,
                B34_TPOPERGOVID = this.B34_TPOPERGOVID
            };
        }
    }
}
