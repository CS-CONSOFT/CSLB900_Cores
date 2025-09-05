using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTeiCsicpCc040
{
    public int TenantId { get; set; }

    public string Cc040Id { get; set; } = null!;

    public string? Cc040Empresaid { get; set; }

    public int? Cc040Filial { get; set; }

    public int? Cc040TipoMovimento { get; set; }

    public string? Cc040Serie { get; set; }

    public int? Cc040NoNf { get; set; }

    public string? Cc040NoPedido { get; set; }

    public DateTime? Cc040DataEmissao { get; set; }

    public DateTime? Cc040Dataentrada { get; set; }

    public DateTime? Cc040DataMovimento { get; set; }

    public string? Cc040ContaId { get; set; }

    public string? Cc040CcustoId { get; set; }

    public string? Cc040AgcobradorId { get; set; }

    public string? Cc040CondPagtoId { get; set; }

    public string? Cc040ResponsavelId { get; set; }

    public string? Cc040CompradorId { get; set; }

    public string? Cc040NatoperacaoId { get; set; }

    public int? Cc040CodgCcusto { get; set; }

    public int? Cc040CodgAgcobrador { get; set; }

    public int? Cc040CodgCondPagto { get; set; }

    public string? Cc040Codnatoperacao { get; set; }

    public decimal? Cc040Perc1Desconto { get; set; }

    public decimal? Cc040Perc2Desconto { get; set; }

    public decimal? Cc040Perc3Desconto { get; set; }

    public decimal? Cc040Perc4Desconto { get; set; }

    public decimal? Cc040Perc5Desconto { get; set; }

    public decimal? Cc040TotalDescsuframa { get; set; }

    public decimal? Cc040TotalBruto { get; set; }

    public decimal? Cc040TotalFrete { get; set; }

    public int? Cc040FreteCifFob { get; set; }

    public decimal? Cc040TotalSeguro { get; set; }

    public decimal? Cc040TotalOutdespesas { get; set; }

    public decimal? Cc040Desconto { get; set; }

    public decimal? Cc040Acrescimo { get; set; }

    public decimal? Cc040TotalLiquido { get; set; }

    public decimal? Cc040TotalServico { get; set; }

    public decimal? Cc040Percdescservico { get; set; }

    public decimal? Cc040Vlrdescservico { get; set; }

    public decimal? Cc040Totliqservico { get; set; }

    public decimal? Cc040TotalprodEServ { get; set; }

    public decimal? Cc040ValorEntrada { get; set; }

    public int? Cc040QtdeParcelas { get; set; }

    public decimal? Cc040Vlrafinanciar { get; set; }

    public string? Cc040Texto { get; set; }

    public int? Cc040QtdVolumes { get; set; }

    public string? Cc040Especie { get; set; }

    public decimal? Cc040PesoLiquido { get; set; }

    public decimal? Cc040PesoBruto { get; set; }

    public DateTime? Cc040DataSaida { get; set; }

    public DateTime? Cc040HoraSaida { get; set; }

    public string? Cc040UsuarioProprId { get; set; }

    public int? Cc040ClassecontaId { get; set; }

    public decimal? Cc040Vbc { get; set; }

    public decimal? Cc040Vicms { get; set; }

    public decimal? Cc040Vbcst { get; set; }

    public decimal? Cc040Vst { get; set; }

    public decimal? Cc040Vii { get; set; }

    public decimal? Cc040Vipi { get; set; }

    public decimal? Cc040Vpis { get; set; }

    public decimal? Cc040Vcofins { get; set; }

    public int? Cc040TiponotaId { get; set; }

    public int? Cc040ModId { get; set; }

    public string? Cc040Mod { get; set; }

    public int? Cc040StatusEstoqueId { get; set; }

    public decimal? Cc040Vsuframa { get; set; }

    public decimal? Cc040Vfreteconhec { get; set; }

    public decimal? Cc040VicmsFrete { get; set; }

    public decimal? Cc040Psimples { get; set; }

    public int? Cc040StatusNotaId { get; set; }

    public int? Cc040StatusFinancId { get; set; }

    public int? Cc040StatusPrecifId { get; set; }

    public string? Cc040EspecieId { get; set; }

    public decimal? Cc040NroTitulo { get; set; }

    public string? Cc040Chaveacessonfe { get; set; }

    public int? Processid { get; set; }

    public bool? Cc040Iscopiada { get; set; }

    public string? Cc040PrecifUsuarioId { get; set; }

    public string? Cc040Protocolnumber { get; set; }

    public decimal? Cc040Vicmsdeson { get; set; }

    public bool? Cc040Iscontaspagar { get; set; }

    public decimal? Cc040Vvpc { get; set; }

    public int? Cc040CtbIscontabilizadoid { get; set; }

    public string? Cc040CtbUsuarioid { get; set; }

    public DateTime? Cc040CtbDtregistro { get; set; }

    public int? Cc040CtbIsestornadoid { get; set; }

    public string? Cc040CtbEstusuarioid { get; set; }

    public DateTime? Cc040CtbEstdtreg { get; set; }

    public long? Cc040CtbIdlancto { get; set; }

    public decimal? Cc040Vfcp { get; set; }

    public decimal? Cc040Vfcpst { get; set; }

    public decimal? Cc040Vfcpstret { get; set; }

    public decimal? Cc040Vipidevol { get; set; }

    public bool? Cc040Isgradebx { get; set; }

    public string? Cc040CtbMsg { get; set; }

    public int? Cc040Motdesoneracaoid { get; set; }

    public decimal? Cc040Picmsdesonerado { get; set; }

    public bool? Cc040IssubtraiIcmsDeson { get; set; }

    public int? Cc040VicmsdesonsubId { get; set; }

    public int? Cc040Statuswmsid { get; set; }

    public decimal? Cc040Tretencaoimp { get; set; }

    public int? Cc040Indpres { get; set; }

    public int? ProcessidFinanceiro { get; set; }

    public decimal? W06b1Qbcmono { get; set; }

    public decimal? W06cVicmsmono { get; set; }

    public decimal? W06c1Qbcmonoreten { get; set; }

    public decimal? W06dVicmsmonoreten { get; set; }

    public decimal? W06d1Qbcmonoret { get; set; }

    public decimal? W06eVicmsmonoret { get; set; }
    // Removidos: W33Vbcis, W34Vis, W47IbsmunVibstot, W48IbsmunVcredpres, W49IbsmunVcredprescondsus, W51CbsVcredpres, W52CbsVcredprescondsus

    public decimal? W35Vbcibscbs { get; set; }

    public decimal? W38IbsufVdif { get; set; }

    public decimal? W39IbsufVdevtrib { get; set; }

    public decimal? W41Vibsuf { get; set; }

    public decimal? W43IbsmunVdif { get; set; }

    public decimal? W44IbsmunVdevtrib { get; set; }

    public decimal? W46Vibsmun { get; set; }

    public decimal? W53CbsVdif { get; set; }

    public decimal? W54CbsVdevtrib { get; set; }

    public decimal? W56Vcbs { get; set; }

    public decimal? W58Vtotibsmono { get; set; }

    public decimal? W59Vtotcbsmono { get; set; }

    public decimal? W60Vtotnf { get; set; }

    public int? Dd040Tpdebcreid { get; set; }

    public decimal? W47Vibstot { get; set; }

    public decimal? W48Vcredpres { get; set; }

    public decimal? W49Vcredprescondsus { get; set; }

    public decimal? W33Vis { get; set; }

    public decimal? W56aCbsVcredpres { get; set; }

    public decimal? W56bCbsVcredprescondsus { get; set; }

    public decimal? W59bVcbsmonoreten { get; set; }

    public decimal? W59cVibsmonoreten { get; set; }

    public decimal? W59dVcbsmonoret { get; set; }

    public decimal? B33Predutor { get; set; }

    public int? B34Tpopergovid { get; set; }
    public virtual OsusrE9aCsicpBb012? Cc040Conta { get; set; }
}
