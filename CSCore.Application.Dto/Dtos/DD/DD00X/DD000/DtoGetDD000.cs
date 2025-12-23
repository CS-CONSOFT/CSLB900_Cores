using CSBS101._82Application.Dto.AA00X.AA013;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB025;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.NFS;
using FF105Financeiro.C82Application.Dto.GG00X.GG001;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD00X.DD000
{
    public class DtoGetDD000
    {
        public int TenantId { get; set; }

        [MaxLength(36)]
        public string Dd000ConfigId { get; set; } = null!;

        [ForeignKey("NavDD000Filial")]
        [MaxLength(36)]
        public string? Dd000FilialId { get; set; }

        [ForeignKey("NavDD000PvCcusto")]
        [MaxLength(36)]
        public string? Dd000PvCcustoId { get; set; }

        [ForeignKey("NavDD000PvAgcobrador")]
        [MaxLength(36)]
        public string? Dd000PvAgcobradorId { get; set; }

        [ForeignKey("NavDD000PvNatoperacao")]
        [MaxLength(36)]
        public string? Dd000PvNatoperacaoId { get; set; }

        [ForeignKey("NavDD000PvConta")]
        [MaxLength(36)]
        public string? Dd000PvContaId { get; set; }

        [ForeignKey("NavDD000CtrlSerieNf")]
        [MaxLength(36)]
        public string? Dd000CtrlSerieNfId { get; set; }

        [ForeignKey("NavDD000CtrlSerieCf")]
        [MaxLength(36)]
        public string? Dd000CtrlSerieCfId { get; set; }

        [ForeignKey("NavDD000CtrlSerieNfce")]
        [MaxLength(36)]
        public string? Dd000CtrlSerieNfceId { get; set; }

        [ForeignKey("NavDD000PdCcusto")]
        [MaxLength(36)]
        public string? Dd000PdCcustoId { get; set; }

        [ForeignKey("NavDD000PdAgcobrador")]
        [MaxLength(36)]
        public string? Dd000PdAgcobradorId { get; set; }

        [ForeignKey("NavDD000PdNatoperacao")]
        [MaxLength(36)]
        public string? Dd000PdNatoperacaoId { get; set; }

        [ForeignKey("NavDD000PdvCcusto")]
        [MaxLength(36)]
        public string? Dd000PdvCcustoId { get; set; }

        [ForeignKey("NavDD000PdvAgcobrador")]
        [MaxLength(36)]
        public string? Dd000PdvAgcobradorId { get; set; }

        [ForeignKey("NavDD000PdvNatoperacao")]
        [MaxLength(36)]
        public string? Dd000PdvNatoperacaoId { get; set; }

        [ForeignKey("NavDD000CtCcusto")]
        [MaxLength(36)]
        public string? Dd000CtCcustoId { get; set; }

        [ForeignKey("NavDD000CtAgcobrador")]
        [MaxLength(36)]
        public string? Dd000CtAgcobradorId { get; set; }

        [ForeignKey("NavDD000CtNatoperacao")]
        [MaxLength(36)]
        public string? Dd000CtNatoperacaoId { get; set; }

        public int? Dd000Qtddiasvalcotacao { get; set; }

        public int? Dd000Qtddiasvalprevenda { get; set; }

        [ForeignKey("NavDD000QualRegraAplicar")]
        public int? Dd000Qualregraaplicar { get; set; }

        [ForeignKey("NavDD000AmbNfe")]
        public int? Dd000AmbNfeId { get; set; }

        [ForeignKey("NavDD000VersaoNfe")]
        public int? Dd000VersaoNfeId { get; set; }

        [ForeignKey("NavDD000LcertDigital")]
        public int? Dd000LcertdigitalId { get; set; }

        //[Column(TypeName = "VARBINARY(MAX)")]
        //public byte[]? Dd000Arqcertdigitalbinario { get; set; }

        [MaxLength(500)]
        public string? Dd000Arqcertdigital { get; set; }

        [MaxLength(200)]
        public string? Dd000Senhacertdigital { get; set; }

        [ForeignKey("NavDD000NdCcusto")]
        [MaxLength(36)]
        public string? Dd000NdCcustoId { get; set; }

        [ForeignKey("NavDD000NdAgcobrador")]
        [MaxLength(36)]
        public string? Dd000NdAgcobradorId { get; set; }

        [ForeignKey("NavDD000NdNatoperacao")]
        [MaxLength(36)]
        public string? Dd000NdNatoperacaoId { get; set; }

        [ForeignKey("NavDD000DcCcusto")]
        [MaxLength(36)]
        public string? Dd000DcCcustoId { get; set; }

        [ForeignKey("NavDD000DcAgcobrador")]
        [MaxLength(36)]
        public string? Dd000DcAgcobradorId { get; set; }

        [ForeignKey("NavDD000DcNatoperacao")]
        [MaxLength(36)]
        public string? Dd000DcNatoperacaoId { get; set; }

        [ForeignKey("NavDD000DisCcusto")]
        [MaxLength(36)]
        public string? Dd000DisCcustoId { get; set; }

        [ForeignKey("NavDD000DisAgcobrador")]
        [MaxLength(36)]
        public string? Dd000DisAgcobradorId { get; set; }

        [ForeignKey("NavDD000DisNatoperacao")]
        [MaxLength(36)]
        public string? Dd000DisNatoperacaoId { get; set; }

        [ForeignKey("NavDD000ZoneTime")]
        public int? Dd000ZonetimeId { get; set; }

        [ForeignKey("NavDD000CpCcusto")]
        [MaxLength(36)]
        public string? Dd000CpCcustoId { get; set; }

        [ForeignKey("NavDD000CpAgcobrador")]
        [MaxLength(36)]
        public string? Dd000CpAgcobradorId { get; set; }

        [ForeignKey("NavDD000CpCondpagto")]
        [MaxLength(36)]
        public string? Dd000CpCondpagtoId { get; set; }

        [ForeignKey("NavDD000CpFormapagto")]
        [MaxLength(36)]
        public string? Dd000CpFormapagtoId { get; set; }

        public int? Dd000CpDiaVencto { get; set; }

        [ForeignKey("NavDD000UfOrgao")]
        [MaxLength(2)]
        public string? Dd000UfOrgaoId { get; set; }

        public int? Dd000Qtddiasvaletiq { get; set; }

        public bool? Dd000NfeConjugada { get; set; }

        [ForeignKey("NavDD000OrigPcomissao")]
        public int? Dd000OrigPcomissaoId { get; set; }

        [ForeignKey("NavDD000FormaPcom")]
        public int? Dd000FormaPcomId { get; set; }

        [ForeignKey("NavDD000ComEspecie")]
        [MaxLength(36)]
        public string? Dd000Comespecieid { get; set; }

        public bool? Dd000NfsIsmultiplo { get; set; }

        [ForeignKey("NavDD000NfsPadrao")]
        public int? Dd000NfsPadraoId { get; set; }

        [ForeignKey("NavDD000NfsRegEspTrib")]
        public int? Dd000NfsRegesptribId { get; set; }

        [ForeignKey("NavDD000NfsOtpSN")]
        public int? Dd000NfsOtpsnId { get; set; }

        [ForeignKey("NavDD000NfsIncCult")]
        public int? Dd000NfsInccultId { get; set; }

        [MaxLength(50)]
        public string? Dd000NfsCodintegrcliente { get; set; }

        [MaxLength(500)]
        public string? Dd000NfsUrlWsInvoicy { get; set; }

        [MaxLength(50)]
        public string? Dd000NfsAlvaraempresa { get; set; }

        [ForeignKey("NavDD000NfsNatOp")]
        public int? Dd000NfsNatop { get; set; }

        [MaxLength(36)]
        public string? Dd000PdvWebRptNfceId { get; set; }

        [MaxLength(36)]
        public string? Dd000PdvWebRptNfeId { get; set; }

        [MaxLength(36)]
        public string? Dd000PdvWebRptNfId { get; set; }

        [MaxLength(500)]
        public string? Dd000Tokenacessows { get; set; }

        public bool? Dd000Isenviows { get; set; }

        public bool? Dd000Isusaambiente { get; set; }

        public bool? Dd000Isusaprojeto { get; set; }

        public decimal? Dd000Vmetadiamonitor { get; set; }

        public decimal? Dd000Qmetadiamonitor { get; set; }

        public bool? Dd000Iscomissaogerente { get; set; }

        public decimal? Dd000Valormincomissao { get; set; }

        public bool? Dd000Exibepvfaturada { get; set; }

        public bool? Dd000Isdataemissaooriginal { get; set; }

        [ForeignKey("NavDD000RegraLimiteDesconto")]
        public int? Dd000RegralimitedescontoId { get; set; }

        public decimal? Dd000Vlrmaxarredondvenda { get; set; }

        public bool? Dd000Isusacomanda { get; set; }

        public bool? Dd000Ishabilitapvexpress { get; set; }

        [ForeignKey("NavDD000Formapgt")]
        [MaxLength(36)]
        public string? Dd000FormapgtId { get; set; }

        public bool? Dd000Isusavendareprimida { get; set; }

        public bool? Dd000Ishabilitaperfalmox { get; set; }

        public bool? Dd000Isvendadeposito { get; set; }

        public bool? Dd000Ispermitesaldonegativo { get; set; }

        public bool? Dd000Iscontigencianfce { get; set; }

        [MaxLength(100)]
        public string? Dd000SatAssinaturaac { get; set; }

        [MaxLength(100)]
        public string? Dd000SatCodigoativacao { get; set; }

        [ForeignKey("NavDD000AlmoxPadraoTroca")]
        [MaxLength(36)]
        public string? Dd000Almoxpadraotrocaid { get; set; }

        [ForeignKey("NavDD000CtrlContigenciaNfce")]
        [MaxLength(36)]
        public string? Dd000CtrlContigenciaNfcei { get; set; }

        public bool? Dd000Isusavaloresretido { get; set; }

        public bool? Dd000Iscalculavolume { get; set; }

        public int? Dd000Tipoimportbibliotec { get; set; }

        public int? Dd000Tipoinsercaoprod { get; set; }

        [MaxLength(100)]
        public string? Dd000CorreiosUsuario { get; set; }

        [MaxLength(100)]
        public string? Dd000CorreiosSenha { get; set; }

        [MaxLength(500)]
        public string? Dd000Urlcorreios { get; set; }

        public bool? Dd000Iscanccomentrega { get; set; }

        // ========== NAVIGATION PROPERTIES ==========

        // Forma de Pagamento Comissão
        public CSICP_DD000Fcom? NavDD000FormaPcom { get; set; }

        // Estabelecimento/Filial
        public Dto_GetBB001ListSimples? NavDD000Filial { get; set; }

        // Centros de Custo
        public Dto_GetBB005? NavDD000PvCcusto { get; set; }
        public Dto_GetBB005? NavDD000PdCcusto { get; set; }
        public Dto_GetBB005? NavDD000PdvCcusto { get; set; }
        public Dto_GetBB005? NavDD000CtCcusto { get; set; }
        public Dto_GetBB005? NavDD000NdCcusto { get; set; }
        public Dto_GetBB005? NavDD000DcCcusto { get; set; }
        public Dto_GetBB005? NavDD000DisCcusto { get; set; }
        public Dto_GetBB005? NavDD000CpCcusto { get; set; }

        // Agentes Cobradores
        public Dto_GetBB006_Exibicao? NavDD000PvAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000PdAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000PdvAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000CtAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000NdAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000DcAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000DisAgcobrador { get; set; }
        public Dto_GetBB006_Exibicao? NavDD000CpAgcobrador { get; set; }

        // Naturezas de Operação
        public Dto_GetBB025_Exibicao? NavDD000PvNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000PdNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000PdvNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000CtNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000NdNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000DcNatoperacao { get; set; }
        public Dto_GetBB025_Exibicao? NavDD000DisNatoperacao { get; set; }

        // Conta
        public Dto_GetBB012_ExibSimples? NavDD000PvConta { get; set; }

        // Séries de Notas
        public Dto_GetAA013_Simples? NavDD000CtrlSerieNf { get; set; }
        public Dto_GetAA013_Simples? NavDD000CtrlSerieCf { get; set; }
        public Dto_GetAA013_Simples? NavDD000CtrlSerieNfce { get; set; }
        public Dto_GetAA013_Simples? NavDD000CtrlContigenciaNfce { get; set; }

        // Condição de Pagamento
        public Dto_GetBB008_Exibicao? NavDD000CpCondpagto { get; set; }

        // Formas de Pagamento
        public Dto_GetBB026_Exibicao? NavDD000CpFormapagto { get; set; }
        public Dto_GetBB026_Exibicao? NavDD000Formapgt { get; set; }

        // UF
        public DtoGetAA027_Simples? NavDD000UfOrgao { get; set; }

        // Espécie de Título
        public Dto_GetFF003_Exibicao? NavDD000ComEspecie { get; set; }

        // Almoxarifado
        public DtoGetGG001Simples? NavDD000AlmoxPadraoTroca { get; set; }

        // Estáticas (para os IDs que são int e representam valores estáticos)
        public CSICP_DD000Rneg? NavDD000QualRegraAplicar { get; set; }
        public CSICP_DD903Anfe? NavDD000AmbNfe { get; set; }
        public CSICP_DD905Vnfe? NavDD000VersaoNfe { get; set; }
        public CSICP_DD907? NavDD000LcertDigital { get; set; }
        public CSICP_DD000Tdz? NavDD000ZoneTime { get; set; }
        public CSICP_DD000Ocom? NavDD000OrigPcomissao { get; set; }
        public Osusr66cCsicpNfsPadrao? NavDD000NfsPadrao { get; set; } 
        public Osusr66cCsicpNfsRegtrib? NavDD000NfsRegEspTrib { get; set; }
        public Osusr66cCsicpNfsOptsn? NavDD000NfsOtpSN { get; set; }
        public Osusr66cCsicpNfsInccult? NavDD000NfsIncCult { get; set; }
        public Osusr66cCsicpNfsNatoper? NavDD000NfsNatOp { get; set; }
        public CSICP_DD000Rdesc? NavDD000RegraLimiteDesconto { get; set; }
    }
}
