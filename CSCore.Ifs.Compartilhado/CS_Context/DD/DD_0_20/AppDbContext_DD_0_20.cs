
using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD000> OsusrTeiCsicpDd000s { get; set; }

        public virtual DbSet<CSICP_DD000Fcom> OsusrTeiCsicpDd000Fcoms { get; set; }

        public virtual DbSet<CSICP_DD000Ocom> OsusrTeiCsicpDd000Ocoms { get; set; }

        public virtual DbSet<CSICP_DD000Rdesc> OsusrTeiCsicpDd000Rdescs { get; set; }

        public virtual DbSet<CSICP_DD000Rneg> OsusrTeiCsicpDd000Rnegs { get; set; }

        public virtual DbSet<CSICP_DD000Tdz> OsusrTeiCsicpDd000Tdzs { get; set; }

        public virtual DbSet<CSICP_DD000W> OsusrTeiCsicpDd000Ws { get; set; }

        public virtual DbSet<CSICP_DD001> OsusrTeiCsicpDd001s { get; set; }

        public virtual DbSet<CSICP_DD002> OsusrTeiCsicpDd002s { get; set; }

        public virtual DbSet<CSICP_DD003> OsusrTeiCsicpDd003s { get; set; }

        public virtual DbSet<CSICP_DD004> OsusrTeiCsicpDd004s { get; set; }

        public virtual DbSet<CSICP_DD005> OsusrTeiCsicpDd005s { get; set; }

        public virtual DbSet<CSICP_DD006> OsusrTeiCsicpDd006s { get; set; }

        public virtual DbSet<CSICP_DD007> OsusrTeiCsicpDd007s { get; set; }

        public virtual DbSet<CSICP_DD008> OsusrTeiCsicpDd008s { get; set; }

        public virtual DbSet<CSICP_DD009> OsusrTeiCsicpDd009s { get; set; }

        public virtual DbSet<CSICP_DD010> OsusrTeiCsicpDd010s { get; set; }

        public virtual DbSet<CSICP_DD011> OsusrTeiCsicpDd011s { get; set; }

        public virtual DbSet<CSICP_DD012> OsusrTeiCsicpDd012s { get; set; }

        public virtual DbSet<CSICP_DD012Tp> OsusrTeiCsicpDd012Tps { get; set; }

        public virtual DbSet<CSICP_DD013> OsusrTeiCsicpDd013s { get; set; }

        public virtual DbSet<CSICP_DD014> OsusrTeiCsicpDd014s { get; set; }

        public virtual DbSet<CSICP_DD015> OsusrTeiCsicpDd015s { get; set; }

        public virtual DbSet<CSICP_DD016> OsusrTeiCsicpDd016s { get; set; }

        public virtual DbSet<CSICP_DD016Apl> OsusrTeiCsicpDd016Apls { get; set; }

        public virtual DbSet<CSICP_DD017> OsusrTeiCsicpDd017s { get; set; }

        public virtual DbSet<CSICP_DD018> OsusrTeiCsicpDd018s { get; set; }

        public virtual DbSet<CSICP_DD019> OsusrTeiCsicpDd019s { get; set; }

        public virtual DbSet<CSICP_DD019Status> OsusrTeiCsicpDd019Statuses { get; set; }

        public virtual DbSet<CSICP_DD019Tipo> OsusrTeiCsicpDd019Tipos { get; set; }

        public virtual DbSet<CSICP_DD020> OsusrTeiCsicpDd020s { get; set; }

        public virtual DbSet<CSICP_DD020Metum> OsusrTeiCsicpDd020Meta { get; set; }

        public virtual DbSet<CSICP_DD021> OsusrTeiCsicpDd021s { get; set; }

        public virtual DbSet<CSICP_DD025> OsusrTeiCsicpDd025s { get; set; }

        public virtual DbSet<CSICP_DD025Stat> OsusrTeiCsicpDd025Stats { get; set; }

        public virtual DbSet<CSICP_DD026> OsusrTeiCsicpDd026s { get; set; }

        public virtual DbSet<CSICP_DD026Tpm> OsusrTeiCsicpDd026Tpms { get; set; }

        public virtual DbSet<CSICP_DD027> OsusrTeiCsicpDd027s { get; set; }

        partial void OnModelCreating_CSICP_DD_0_20(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD000>(entity =>
            {
                entity.HasKey(e => e.Dd000ConfigId).HasName("OSPRK_OSUSR_TEI_CSICP_DD000");

                entity.ToTable("OSUSR_TEI_CSICP_DD000");

                entity.HasIndex(e => new { e.Dd000FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_15DD000_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NfsNatop, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_15DD000_NFS_NATOP_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000AmbNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_16DD000_AMB_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000FormapgtId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_17DD000_FORMAPGT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PvContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_17DD000_PV_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000UfOrgaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_17DD000_UF_ORGAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000ZonetimeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_17DD000_ZONETIME_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000Comespecieid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_COMESPECIEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CpCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_CP_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_CT_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DcCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_DC_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NdCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_ND_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NfsOtpsnId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_NFS_OTPSN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_PD_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PvCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_18DD000_PV_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DisCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_19DD000_DIS_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000FormaPcomId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_19DD000_FORMA_PCOM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NfsPadraoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_19DD000_NFS_PADRAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvCcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_19DD000_PDV_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000VersaoNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_19DD000_VERSAO_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NfsInccultId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_20DD000_NFS_INCCULT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CpCondpagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_21DD000_CP_CONDPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000LcertdigitalId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_21DD000_LCERTDIGITAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CpAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_CP_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CpFormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_CP_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtrlSerieCfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_CTRL_SERIE_CF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtrlSerieNfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_CTRL_SERIE_NF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_CT_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DcAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_DC_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NdAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_ND_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_PD_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PvAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_PV_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000Qualregraaplicar, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_22DD000_QUALREGRAAPLICAR_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_CT_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DcNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_DC_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DisAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_DIS_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NdNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_ND_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000NfsRegesptribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_NFS_REGESPTRIB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000OrigPcomissaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_ORIG_PCOMISSAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvAgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_PDV_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvWebRptNfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_PDV_WEB_RPT_NF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_PD_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PvNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_23DD000_PV_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000Almoxpadraotrocaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_24DD000_ALMOXPADRAOTROCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtrlSerieNfceId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_24DD000_CTRL_SERIE_NFCE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000DisNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_24DD000_DIS_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvNatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_24DD000_PDV_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvWebRptNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_24DD000_PDV_WEB_RPT_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000PdvWebRptNfceId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_25DD000_PDV_WEB_RPT_NFCE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000CtrlContigenciaNfcei, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_28DD000_CTRL_CONTIGENCIA_NFCEI_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000RegralimitedescontoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_28DD000_REGRALIMITEDESCONTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD000_9TENANT_ID");

                entity.Property(e => e.Dd000ConfigId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CONFIG_ID");
                entity.Property(e => e.Dd000Almoxpadraotrocaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_ALMOXPADRAOTROCAID");
                entity.Property(e => e.Dd000AmbNfeId).HasColumnName("DD000_AMB_NFE_ID");
                entity.Property(e => e.Dd000Arqcertdigital)
                    .HasMaxLength(255)
                    .HasColumnName("DD000_ARQCERTDIGITAL");

                //entity.Property(e => e.Dd000Arqcertdigitalbinario)
                entity.Ignore(e => e.Dd000Arqcertdigitalbinario);
                //.HasColumnName("DD000_ARQCERTDIGITALBINARIO");

                entity.Property(e => e.Dd000Comespecieid)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_COMESPECIEID");
                entity.Property(e => e.Dd000CorreiosSenha)
                    .HasMaxLength(100)
                    .HasColumnName("DD000_CORREIOS_SENHA");
                entity.Property(e => e.Dd000CorreiosUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("DD000_CORREIOS_USUARIO");
                entity.Property(e => e.Dd000CpAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CP_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000CpCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CP_CCUSTO_ID");
                entity.Property(e => e.Dd000CpCondpagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CP_CONDPAGTO_ID");
                entity.Property(e => e.Dd000CpDiaVencto).HasColumnName("DD000_CP_DIA_VENCTO");
                entity.Property(e => e.Dd000CpFormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CP_FORMAPAGTO_ID");
                entity.Property(e => e.Dd000CtAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CT_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000CtCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CT_CCUSTO_ID");
                entity.Property(e => e.Dd000CtNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CT_NATOPERACAO_ID");
                entity.Property(e => e.Dd000CtrlContigenciaNfcei)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CTRL_CONTIGENCIA_NFCEI");
                entity.Property(e => e.Dd000CtrlSerieCfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CTRL_SERIE_CF_ID");
                entity.Property(e => e.Dd000CtrlSerieNfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CTRL_SERIE_NF_ID");
                entity.Property(e => e.Dd000CtrlSerieNfceId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CTRL_SERIE_NFCE_ID");
                entity.Property(e => e.Dd000DcAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DC_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000DcCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DC_CCUSTO_ID");
                entity.Property(e => e.Dd000DcNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DC_NATOPERACAO_ID");
                entity.Property(e => e.Dd000DisAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DIS_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000DisCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DIS_CCUSTO_ID");
                entity.Property(e => e.Dd000DisNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_DIS_NATOPERACAO_ID");
                entity.Property(e => e.Dd000Exibepvfaturada).HasColumnName("DD000_EXIBEPVFATURADA");
                entity.Property(e => e.Dd000FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_FILIAL_ID");
                entity.Property(e => e.Dd000FormaPcomId).HasColumnName("DD000_FORMA_PCOM_ID");
                entity.Property(e => e.Dd000FormapgtId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_FORMAPGT_ID");
                entity.Property(e => e.Dd000Iscalculavolume).HasColumnName("DD000_ISCALCULAVOLUME");
                entity.Property(e => e.Dd000Iscanccomentrega).HasColumnName("DD000_ISCANCCOMENTREGA");
                entity.Property(e => e.Dd000Iscomissaogerente).HasColumnName("DD000_ISCOMISSAOGERENTE");
                entity.Property(e => e.Dd000Iscontigencianfce).HasColumnName("DD000_ISCONTIGENCIANFCE");
                entity.Property(e => e.Dd000Isdataemissaooriginal).HasColumnName("DD000_ISDATAEMISSAOORIGINAL");
                entity.Property(e => e.Dd000Isenviows).HasColumnName("DD000_ISENVIOWS");
                entity.Property(e => e.Dd000Ishabilitaperfalmox).HasColumnName("DD000_ISHABILITAPERFALMOX");
                entity.Property(e => e.Dd000Ishabilitapvexpress).HasColumnName("DD000_ISHABILITAPVEXPRESS");
                entity.Property(e => e.Dd000Ispermitesaldonegativo).HasColumnName("DD000_ISPERMITESALDONEGATIVO");
                entity.Property(e => e.Dd000Isusaambiente).HasColumnName("DD000_ISUSAAMBIENTE");
                entity.Property(e => e.Dd000Isusacomanda).HasColumnName("DD000_ISUSACOMANDA");
                entity.Property(e => e.Dd000Isusaprojeto).HasColumnName("DD000_ISUSAPROJETO");
                entity.Property(e => e.Dd000Isusavaloresretido).HasColumnName("DD000_ISUSAVALORESRETIDO");
                entity.Property(e => e.Dd000Isusavendareprimida).HasColumnName("DD000_ISUSAVENDAREPRIMIDA");
                entity.Property(e => e.Dd000Isvendadeposito).HasColumnName("DD000_ISVENDADEPOSITO");
                entity.Property(e => e.Dd000LcertdigitalId).HasColumnName("DD000_LCERTDIGITAL_ID");
                entity.Property(e => e.Dd000NdAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_ND_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000NdCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_ND_CCUSTO_ID");
                entity.Property(e => e.Dd000NdNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_ND_NATOPERACAO_ID");
                entity.Property(e => e.Dd000NfeConjugada).HasColumnName("DD000_NFE_CONJUGADA");
                entity.Property(e => e.Dd000NfsAlvaraempresa)
                    .HasMaxLength(15)
                    .HasColumnName("DD000_NFS_ALVARAEMPRESA");
                entity.Property(e => e.Dd000NfsCodintegrcliente)
                    .HasMaxLength(40)
                    .HasColumnName("DD000_NFS_CODINTEGRCLIENTE");
                entity.Property(e => e.Dd000NfsInccultId).HasColumnName("DD000_NFS_INCCULT_ID");
                entity.Property(e => e.Dd000NfsIsmultiplo).HasColumnName("DD000_NFS_ISMULTIPLO");
                entity.Property(e => e.Dd000NfsNatop).HasColumnName("DD000_NFS_NATOP");
                entity.Property(e => e.Dd000NfsOtpsnId).HasColumnName("DD000_NFS_OTPSN_ID");
                entity.Property(e => e.Dd000NfsPadraoId).HasColumnName("DD000_NFS_PADRAO_ID");
                entity.Property(e => e.Dd000NfsRegesptribId).HasColumnName("DD000_NFS_REGESPTRIB_ID");
                entity.Property(e => e.Dd000NfsUrlWsInvoicy)
                    .HasMaxLength(300)
                    .HasColumnName("DD000_NFS_URL_WS_INVOICY");
                entity.Property(e => e.Dd000OrigPcomissaoId).HasColumnName("DD000_ORIG_PCOMISSAO_ID");
                entity.Property(e => e.Dd000PdAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PD_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000PdCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PD_CCUSTO_ID");
                entity.Property(e => e.Dd000PdNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PD_NATOPERACAO_ID");
                entity.Property(e => e.Dd000PdvAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000PdvCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_CCUSTO_ID");
                entity.Property(e => e.Dd000PdvNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_NATOPERACAO_ID");
                entity.Property(e => e.Dd000PdvWebRptNfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_WEB_RPT_NF_ID");
                entity.Property(e => e.Dd000PdvWebRptNfceId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_WEB_RPT_NFCE_ID");
                entity.Property(e => e.Dd000PdvWebRptNfeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PDV_WEB_RPT_NFE_ID");
                entity.Property(e => e.Dd000PvAgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PV_AGCOBRADOR_ID");
                entity.Property(e => e.Dd000PvCcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PV_CCUSTO_ID");
                entity.Property(e => e.Dd000PvContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PV_CONTA_ID");
                entity.Property(e => e.Dd000PvNatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_PV_NATOPERACAO_ID");
                entity.Property(e => e.Dd000Qmetadiamonitor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD000_QMETADIAMONITOR");
                entity.Property(e => e.Dd000Qtddiasvalcotacao).HasColumnName("DD000_QTDDIASVALCOTACAO");
                entity.Property(e => e.Dd000Qtddiasvaletiq).HasColumnName("DD000_QTDDIASVALETIQ");
                entity.Property(e => e.Dd000Qtddiasvalprevenda).HasColumnName("DD000_QTDDIASVALPREVENDA");
                entity.Property(e => e.Dd000Qualregraaplicar).HasColumnName("DD000_QUALREGRAAPLICAR");
                entity.Property(e => e.Dd000RegralimitedescontoId).HasColumnName("DD000_REGRALIMITEDESCONTO_ID");
                entity.Property(e => e.Dd000SatAssinaturaac)
                    .HasMaxLength(344)
                    .HasColumnName("DD000_SAT_ASSINATURAAC");
                entity.Property(e => e.Dd000SatCodigoativacao)
                    .HasMaxLength(32)
                    .HasColumnName("DD000_SAT_CODIGOATIVACAO");
                entity.Property(e => e.Dd000Senhacertdigital)
                    .HasMaxLength(50)
                    .HasColumnName("DD000_SENHACERTDIGITAL");
                entity.Property(e => e.Dd000Tipoimportbibliotec).HasColumnName("DD000_TIPOIMPORTBIBLIOTEC");
                entity.Property(e => e.Dd000Tipoinsercaoprod).HasColumnName("DD000_TIPOINSERCAOPROD");
                entity.Property(e => e.Dd000Tokenacessows)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_TOKENACESSOWS");
                entity.Property(e => e.Dd000UfOrgaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_UF_ORGAO_ID");
                entity.Property(e => e.Dd000Urlcorreios)
                    .HasMaxLength(255)
                    .HasColumnName("DD000_URLCORREIOS");
                entity.Property(e => e.Dd000Valormincomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD000_VALORMINCOMISSAO");
                entity.Property(e => e.Dd000VersaoNfeId).HasColumnName("DD000_VERSAO_NFE_ID");
                entity.Property(e => e.Dd000Vlrmaxarredondvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD000_VLRMAXARREDONDVENDA");
                entity.Property(e => e.Dd000Vmetadiamonitor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD000_VMETADIAMONITOR");
                entity.Property(e => e.Dd000ZonetimeId).HasColumnName("DD000_ZONETIME_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");




            });

            modelBuilder.Entity<CSICP_DD000Fcom>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_FCOM");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_FCOM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD000Ocom>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_OCOM");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_OCOM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD000Rdesc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_RDESC");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_RDESC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD000Rneg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_RNEG");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_RNEG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD000Tdz>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_TDZ");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_TDZ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tzd)
                    .HasMaxLength(20)
                    .HasColumnName("TZD");
                entity.Property(e => e.TzdHorarioverao)
                    .HasMaxLength(20)
                    .HasColumnName("TZD_HORARIOVERAO");
            });

            modelBuilder.Entity<CSICP_DD000W>(entity =>
            {
                entity.HasKey(e => e.Dd000Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD000_WS");

                entity.ToTable("OSUSR_TEI_CSICP_DD000_WS");

                entity.HasIndex(e => new { e.Dd000NfcfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_13DD000_NFCF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000ConfigId, e.Dd000ServnfeId, e.Dd000NfcfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_15DD000_CONFIG_ID_16DD000_SERVNFE_ID_13DD000_NFCF_ID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Dd000ConfigId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_15DD000_CONFIG_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000ServnfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_16DD000_SERVNFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd000UfOrgaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_17DD000_UF_ORGAO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD000_WS_9TENANT_ID");

                entity.Property(e => e.Dd000Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_ID");
                entity.Property(e => e.Dd000ConfigId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_CONFIG_ID");
                entity.Property(e => e.Dd000Isactive).HasColumnName("DD000_ISACTIVE");
                entity.Property(e => e.Dd000NfcfId).HasColumnName("DD000_NFCF_ID");
                entity.Property(e => e.Dd000ServnfeId).HasColumnName("DD000_SERVNFE_ID");
                entity.Property(e => e.Dd000UfOrgaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD000_UF_ORGAO_ID");
                entity.Property(e => e.Dd000Url)
                    .HasMaxLength(100)
                    .HasColumnName("DD000_URL");
                entity.Property(e => e.Dd000UrlHomologacao)
                    .HasMaxLength(100)
                    .HasColumnName("DD000_URL_HOMOLOGACAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD001>(entity =>
            {
                entity.HasKey(e => e.Dd001Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD001");

                entity.ToTable("OSUSR_TEI_CSICP_DD001");

                entity.HasIndex(e => new { e.Dd001Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD001_15DD001_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD001_9TENANT_ID");

                entity.Property(e => e.Dd001Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_ID");
                entity.Property(e => e.Dd001Datafim)
                    .HasColumnType("datetime")
                    .HasColumnName("DD001_DATAFIM");
                entity.Property(e => e.Dd001Datainicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DD001_DATAINICIO");
                entity.Property(e => e.Dd001Descricao)
                    .HasMaxLength(60)
                    .HasColumnName("DD001_DESCRICAO");
                entity.Property(e => e.Dd001Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_EMPRESAID");
                entity.Property(e => e.Dd001Filial).HasColumnName("DD001_FILIAL");
                entity.Property(e => e.Dd001Isactive).HasColumnName("DD001_ISACTIVE");
                entity.Property(e => e.Dd001Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD001_PROTOCOLNUMBER");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD002>(entity =>
            {
                entity.HasKey(e => e.Dd002Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD002");

                entity.ToTable("OSUSR_TEI_CSICP_DD002");

                entity.HasIndex(e => new { e.Dd002RotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_13DD002_ROTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd002ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_14DD002_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd002Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_15DD002_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd002CategoriaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_18DD002_CATEGORIA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd002FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_19DD002_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd001Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD002_8DD001_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD002_9TENANT_ID");

                entity.Property(e => e.Dd002Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_ID");
                entity.Property(e => e.Dd001Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_ID");
                entity.Property(e => e.Dd002CategoriaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_CATEGORIA_ID");
                entity.Property(e => e.Dd002ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_CONTA_ID");
                entity.Property(e => e.Dd002DataValidade)
                    .HasColumnType("datetime")
                    .HasColumnName("DD002_DATA_VALIDADE");
                entity.Property(e => e.Dd002DescontoFlexivel).HasColumnName("DD002_DESCONTO_FLEXIVEL");
                entity.Property(e => e.Dd002Descricao)
                    .HasMaxLength(60)
                    .HasColumnName("DD002_DESCRICAO");
                entity.Property(e => e.Dd002Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_EMPRESAID");
                entity.Property(e => e.Dd002FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_FORMAPAGTO_ID");
                entity.Property(e => e.Dd002Percentual)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD002_PERCENTUAL");
                entity.Property(e => e.Dd002Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD002_PROTOCOLNUMBER");
                entity.Property(e => e.Dd002RotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_ROTA_ID");
                entity.Property(e => e.Dd002ValorDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD002_VALOR_DESCONTO");
                entity.Property(e => e.Dd002Valoracimade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD002_VALORACIMADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD003>(entity =>
            {
                entity.HasKey(e => e.Dd003Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD003");

                entity.ToTable("OSUSR_TEI_CSICP_DD003");

                entity.HasIndex(e => new { e.Dd003ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD003_16DD003_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd003GrupoprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD003_21DD003_GRUPOPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd003MarcaprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD003_21DD003_MARCAPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd003ClasseprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD003_22DD003_CLASSEPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd002Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD003_8DD002_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD003_9TENANT_ID");

                entity.Property(e => e.Dd003Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD003_ID");
                entity.Property(e => e.Dd002Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD002_ID");
                entity.Property(e => e.Dd003ClasseprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD003_CLASSEPRODUTO_ID");
                entity.Property(e => e.Dd003GrupoprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD003_GRUPOPRODUTO_ID");
                entity.Property(e => e.Dd003MarcaprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD003_MARCAPRODUTO_ID");
                entity.Property(e => e.Dd003Percentual)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD003_PERCENTUAL");
                entity.Property(e => e.Dd003ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD003_PRODUTO_ID");
                entity.Property(e => e.Dd003ValorFaixaAte)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD003_VALOR_FAIXA_ATE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD004>(entity =>
            {
                entity.HasKey(e => e.Dd004Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD004");

                entity.ToTable("OSUSR_TEI_CSICP_DD004");

                entity.HasIndex(e => new { e.Dd004RotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_13DD004_ROTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd004ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_14DD004_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd004Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_15DD004_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd004CategoriaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_18DD004_CATEGORIA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd004FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_19DD004_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd001Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD004_8DD001_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD004_9TENANT_ID");

                entity.Property(e => e.Dd004Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_ID");
                entity.Property(e => e.Dd001Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_ID");
                entity.Property(e => e.Dd004CategoriaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_CATEGORIA_ID");
                entity.Property(e => e.Dd004ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_CONTA_ID");
                entity.Property(e => e.Dd004DataValidade)
                    .HasColumnType("datetime")
                    .HasColumnName("DD004_DATA_VALIDADE");
                entity.Property(e => e.Dd004DescontoFlexivel).HasColumnName("DD004_DESCONTO_FLEXIVEL");
                entity.Property(e => e.Dd004Descricao)
                    .HasMaxLength(60)
                    .HasColumnName("DD004_DESCRICAO");
                entity.Property(e => e.Dd004Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_EMPRESAID");
                entity.Property(e => e.Dd004FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_FORMAPAGTO_ID");
                entity.Property(e => e.Dd004Percentual)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD004_PERCENTUAL");
                entity.Property(e => e.Dd004Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD004_PROTOCOLNUMBER");
                entity.Property(e => e.Dd004RotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_ROTA_ID");
                entity.Property(e => e.Dd004ValorAcrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD004_VALOR_ACRESCIMO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD005>(entity =>
            {
                entity.HasKey(e => e.Dd005Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD005");

                entity.ToTable("OSUSR_TEI_CSICP_DD005");

                entity.HasIndex(e => new { e.Dd005ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD005_16DD005_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd005GrupoprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD005_21DD005_GRUPOPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd005MarcaprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD005_21DD005_MARCAPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd005ClasseprodutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD005_22DD005_CLASSEPRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd004Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD005_8DD004_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD005_9TENANT_ID");

                entity.Property(e => e.Dd005Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD005_ID");
                entity.Property(e => e.Dd004Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD004_ID");
                entity.Property(e => e.Dd005ClasseprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD005_CLASSEPRODUTO_ID");
                entity.Property(e => e.Dd005GrupoprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD005_GRUPOPRODUTO_ID");
                entity.Property(e => e.Dd005MarcaprodutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD005_MARCAPRODUTO_ID");
                entity.Property(e => e.Dd005Percentual)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD005_PERCENTUAL");
                entity.Property(e => e.Dd005ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD005_PRODUTO_ID");
                entity.Property(e => e.Dd005ValorFaixaAte)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD005_VALOR_FAIXA_ATE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD006>(entity =>
            {
                entity.HasKey(e => e.Dd006Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD006");

                entity.ToTable("OSUSR_TEI_CSICP_DD006");

                entity.HasIndex(e => new { e.Dd006AlmoxId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD006_14DD006_ALMOX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd006Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD006_15DD006_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd006ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD006_16DD006_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd001Rcomercializid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD006_20DD001_RCOMERCIALIZID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD006_9TENANT_ID");

                entity.Property(e => e.Dd006Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD006_ID");
                entity.Property(e => e.Dd001Rcomercializid)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_RCOMERCIALIZID");
                entity.Property(e => e.Dd006AlmoxId)
                    .HasMaxLength(36)
                    .HasColumnName("DD006_ALMOX_ID");
                entity.Property(e => e.Dd006Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD006_EMPRESAID");
                entity.Property(e => e.Dd006Isactive).HasColumnName("DD006_ISACTIVE");
                entity.Property(e => e.Dd006Percdesconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD006_PERCDESCONTO");
                entity.Property(e => e.Dd006Precopromocao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD006_PRECOPROMOCAO");
                entity.Property(e => e.Dd006Precovenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD006_PRECOVENDA");
                entity.Property(e => e.Dd006ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD006_PRODUTO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD007>(entity =>
            {
                entity.HasKey(e => e.Dd007Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD007");

                entity.ToTable("OSUSR_TEI_CSICP_DD007");

                entity.HasIndex(e => new { e.Dd007CondicaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD007_17DD007_CONDICAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd007FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD007_19DD007_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd006Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD007_8DD006_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD007_9TENANT_ID");

                entity.Property(e => e.Dd007Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD007_ID");
                entity.Property(e => e.Dd006Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD006_ID");
                entity.Property(e => e.Dd007Acimadeqtde)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD007_ACIMADEQTDE");
                entity.Property(e => e.Dd007CondicaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD007_CONDICAO_ID");
                entity.Property(e => e.Dd007FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD007_FORMAPAGTO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD008>(entity =>
            {
                entity.HasKey(e => e.Dd008Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD008");

                entity.ToTable("OSUSR_TEI_CSICP_DD008");

                entity.HasIndex(e => new { e.Dd008Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD008_15DD008_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd008CondpagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD008_18DD008_CONDPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd008FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD008_19DD008_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd008ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD008_20DD008_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD008_9TENANT_ID");

                entity.Property(e => e.Dd008Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_ID");
                entity.Property(e => e.Dd008CargoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_CARGO_ID");
                entity.Property(e => e.Dd008CondpagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_CONDPAGTO_ID");
                entity.Property(e => e.Dd008Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_EMPRESAID");
                entity.Property(e => e.Dd008FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_FORMAPAGTO_ID");
                entity.Property(e => e.Dd008Isactive).HasColumnName("DD008_ISACTIVE");
                entity.Property(e => e.Dd008Percdesconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD008_PERCDESCONTO");
                entity.Property(e => e.Dd008ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD008_RESPONSAVEL_ID");
                entity.Property(e => e.Dd008Valorate)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD008_VALORATE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD009>(entity =>
            {
                entity.HasKey(e => e.Dd009Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD009");

                entity.ToTable("OSUSR_TEI_CSICP_DD009");

                entity.HasIndex(e => new { e.Dd009Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD009_15DD009_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd009CategoriaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD009_18DD009_CATEGORIA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd009FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD009_19DD009_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD009_9TENANT_ID");

                entity.Property(e => e.Dd009Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD009_ID");
                entity.Property(e => e.Dd009CategoriaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD009_CATEGORIA_ID");
                entity.Property(e => e.Dd009Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD009_EMPRESAID");
                entity.Property(e => e.Dd009FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD009_FORMAPAGTO_ID");
                entity.Property(e => e.Dd009Isactive).HasColumnName("DD009_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD010>(entity =>
            {
                entity.HasKey(e => e.Dd010Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD010");

                entity.ToTable("OSUSR_TEI_CSICP_DD010");

                entity.HasIndex(e => new { e.Dd010Contaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD010_13DD010_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd010RotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD010_13DD010_ROTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd010Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD010_15DD010_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD010_9TENANT_ID");

                entity.Property(e => e.Dd010Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD010_ID");
                entity.Property(e => e.Dd010Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD010_CONTAID");
                entity.Property(e => e.Dd010DataValidade)
                    .HasColumnType("datetime")
                    .HasColumnName("DD010_DATA_VALIDADE");
                entity.Property(e => e.Dd010Descricao)
                    .HasMaxLength(60)
                    .HasColumnName("DD010_DESCRICAO");
                entity.Property(e => e.Dd010Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD010_EMPRESAID");
                entity.Property(e => e.Dd010Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD010_PROTOCOLNUMBER");
                entity.Property(e => e.Dd010RotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD010_ROTA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD011>(entity =>
            {
                entity.HasKey(e => e.Dd011Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD011");

                entity.ToTable("OSUSR_TEI_CSICP_DD011");

                entity.HasIndex(e => new { e.Dd011FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD011_19DD011_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd011Tabelaprecoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD011_19DD011_TABELAPRECOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd010Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD011_8DD010_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD011_9TENANT_ID");

                entity.Property(e => e.Dd011Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD011_ID");
                entity.Property(e => e.Dd010Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD010_ID");
                entity.Property(e => e.Dd011ColunaPreco).HasColumnName("DD011_COLUNA_PRECO");
                entity.Property(e => e.Dd011FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD011_FORMAPAGTO_ID");
                entity.Property(e => e.Dd011TabelaPreco)
                    .HasMaxLength(50)
                    .HasColumnName("DD011_TABELA_PRECO");
                entity.Property(e => e.Dd011Tabelaprecoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD011_TABELAPRECOID");
                entity.Property(e => e.Dd011ValorFaixaAte)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD011_VALOR_FAIXA_ATE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD012>(entity =>
            {
                entity.HasKey(e => e.Dd012Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD012");

                entity.ToTable("OSUSR_TEI_CSICP_DD012");

                entity.HasIndex(e => new { e.Dd012EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD012_14DD012_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd012Tpmodeloid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD012_16DD012_TPMODELOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD012_9TENANT_ID");

                entity.Property(e => e.Dd012Id).HasColumnName("DD012_ID");
                entity.Property(e => e.Dd012Descricao)
                    .HasMaxLength(150)
                    .HasColumnName("DD012_DESCRICAO");
                entity.Property(e => e.Dd012EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD012_ESTAB_ID");
                entity.Property(e => e.Dd012Footer).HasColumnName("DD012_FOOTER");
                entity.Property(e => e.Dd012Header).HasColumnName("DD012_HEADER");
                entity.Property(e => e.Dd012Isactive).HasColumnName("DD012_ISACTIVE");
                entity.Property(e => e.Dd012Main).HasColumnName("DD012_MAIN");
                entity.Property(e => e.Dd012Tpmodeloid).HasColumnName("DD012_TPMODELOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD012Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD012_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD012_TP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD013>(entity =>
            {
                entity.HasKey(e => e.Dd013Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD013");

                entity.ToTable("OSUSR_TEI_CSICP_DD013");

                entity.HasIndex(e => new { e.Dd013Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD013_15DD013_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD013_9TENANT_ID");

                entity.Property(e => e.Dd013Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD013_ID");
                entity.Property(e => e.Dd013Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD013_EMPRESAID");
                entity.Property(e => e.Dd013Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD013_PROTOCOLNUMBER");
                entity.Property(e => e.Dd013Texto)
                    .HasMaxLength(2000)
                    .HasColumnName("DD013_TEXTO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD014>(entity =>
            {
                entity.HasKey(e => e.Dd014Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD014");

                entity.ToTable("OSUSR_TEI_CSICP_DD014");

                entity.HasIndex(e => new { e.Dd014Contaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD014_13DD014_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd014Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD014_15DD014_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd014TipovigenciaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD014_21DD014_TIPOVIGENCIA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD014_9TENANT_ID");

                entity.Property(e => e.Dd014Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD014_ID");
                entity.Property(e => e.Dd014Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD014_CONTAID");
                entity.Property(e => e.Dd014Dataemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD014_DATAEMISSAO");
                entity.Property(e => e.Dd014Descricao)
                    .HasMaxLength(60)
                    .HasColumnName("DD014_DESCRICAO");
                entity.Property(e => e.Dd014Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD014_EMPRESAID");
                entity.Property(e => e.Dd014Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD014_PROTOCOLNUMBER");
                entity.Property(e => e.Dd014TipovigenciaId).HasColumnName("DD014_TIPOVIGENCIA_ID");
                entity.Property(e => e.Dd014Vigencia).HasColumnName("DD014_VIGENCIA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD015>(entity =>
            {
                entity.HasKey(e => e.Dd015Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD015");

                entity.ToTable("OSUSR_TEI_CSICP_DD015");

                entity.HasIndex(e => new { e.Dd015Forma, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD015_11DD015_FORMA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd015Frequencia, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD015_16DD015_FREQUENCIA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd014Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD015_8DD014_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD015_9TENANT_ID");

                entity.Property(e => e.Dd015Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD015_ID");
                entity.Property(e => e.Dd014Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD014_ID");
                entity.Property(e => e.Dd015CodgverbaId)
                    .HasMaxLength(50)
                    .HasColumnName("DD015_CODGVERBA_ID");
                entity.Property(e => e.Dd015Descverba)
                    .HasMaxLength(100)
                    .HasColumnName("DD015_DESCVERBA");
                entity.Property(e => e.Dd015Forma).HasColumnName("DD015_FORMA");
                entity.Property(e => e.Dd015Frequencia).HasColumnName("DD015_FREQUENCIA");
                entity.Property(e => e.Dd015Percentual)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD015_PERCENTUAL");
                entity.Property(e => e.Dd015Valorverba)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD015_VALORVERBA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");







            });

            modelBuilder.Entity<CSICP_DD016>(entity =>
            {
                entity.HasKey(e => e.Dd016Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD016");

                entity.ToTable("OSUSR_TEI_CSICP_DD016");

                entity.HasIndex(e => new { e.Dd016GrupoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_14DD016_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016MarcaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_14DD016_MARCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016Aplicacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_15DD016_APLICACAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016ArtigoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_15DD016_ARTIGO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016ClasseId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_15DD016_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_15DD016_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016CondicaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_17DD016_CONDICAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd016FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_19DD016_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd001Rcomercializid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD016_20DD001_RCOMERCIALIZID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD016_9TENANT_ID");

                entity.Property(e => e.Dd016Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_ID");
                entity.Property(e => e.Dd001Rcomercializid)
                    .HasMaxLength(36)
                    .HasColumnName("DD001_RCOMERCIALIZID");
                entity.Property(e => e.Dd016Aplicacao).HasColumnName("DD016_APLICACAO");
                entity.Property(e => e.Dd016ArtigoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_ARTIGO_ID");
                entity.Property(e => e.Dd016ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_CLASSE_ID");
                entity.Property(e => e.Dd016CondicaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_CONDICAO_ID");
                entity.Property(e => e.Dd016FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_FILIAL_ID");
                entity.Property(e => e.Dd016FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_FORMAPAGTO_ID");
                entity.Property(e => e.Dd016GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_GRUPO_ID");
                entity.Property(e => e.Dd016Isactive).HasColumnName("DD016_ISACTIVE");
                entity.Property(e => e.Dd016MarcaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD016_MARCA_ID");
                entity.Property(e => e.Dd016PercentPedido)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD016_PERCENT_PEDIDO");
                entity.Property(e => e.Dd016PercentPvenda)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD016_PERCENT_PVENDA");
                entity.Property(e => e.Dd016Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD016_PROTOCOLNUMBER");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD016Apl>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD016_APL");

                entity.ToTable("OSUSR_TEI_CSICP_DD016_APL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD017>(entity =>
            {
                entity.HasKey(e => e.Dd017Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD017");

                entity.ToTable("OSUSR_TEI_CSICP_DD017");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD017_9TENANT_ID");

                entity.Property(e => e.Dd017Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD017_ID");
                entity.Property(e => e.Dd017Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("DD017_CODIGO");
                entity.Property(e => e.Dd017Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("DD017_DESCRICAO");
                entity.Property(e => e.Dd017Isactive).HasColumnName("DD017_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD018>(entity =>
            {
                entity.HasKey(e => e.Dd018Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD018");

                entity.ToTable("OSUSR_TEI_CSICP_DD018");

                entity.HasIndex(e => new { e.Dd018GrupoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_14DD018_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018MarcaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_14DD018_MARCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018Aplicacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_15DD018_APLICACAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018ArtigoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_15DD018_ARTIGO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018ClasseId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_15DD018_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018CondicaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_17DD018_CONDICAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_19DD018_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd018Grupoformacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD018_19DD018_GRUPOFORMACAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD018_9TENANT_ID");

                entity.Property(e => e.Dd018Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_ID");
                entity.Property(e => e.Dd018Aplicacao).HasColumnName("DD018_APLICACAO");
                entity.Property(e => e.Dd018ArtigoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_ARTIGO_ID");
                entity.Property(e => e.Dd018ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_CLASSE_ID");
                entity.Property(e => e.Dd018CondicaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_CONDICAO_ID");
                entity.Property(e => e.Dd018FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_FORMAPAGTO_ID");
                entity.Property(e => e.Dd018GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_GRUPO_ID");
                entity.Property(e => e.Dd018Grupoformacao)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_GRUPOFORMACAO");
                entity.Property(e => e.Dd018Isactive).HasColumnName("DD018_ISACTIVE");
                entity.Property(e => e.Dd018MarcaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD018_MARCA_ID");
                entity.Property(e => e.Dd018PercentPedido)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD018_PERCENT_PEDIDO");
                entity.Property(e => e.Dd018PercentPvenda)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD018_PERCENT_PVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD019>(entity =>
            {
                entity.HasKey(e => e.Dd019Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD019");

                entity.ToTable("OSUSR_TEI_CSICP_DD019", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD019"));

                entity.HasIndex(e => new { e.Dd019TipoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD019_13DD019_TIPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd019Motivoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD019_14DD019_MOTIVOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd019FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD019_15DD019_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd019StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD019_15DD019_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd019Prococolnumber, e.Dd019Dataregistro, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD019_20DD019_PROCOCOLNUMBER_18DD019_DATAREGISTRO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD019_9TENANT_ID");

                entity.Property(e => e.Dd019Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_ID");
                entity.Property(e => e.Dd019AtendimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_ATENDIMENTO_ID");
                entity.Property(e => e.Dd019Dataautorizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD019_DATAAUTORIZACAO");
                entity.Property(e => e.Dd019Dataregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD019_DATAREGISTRO");
                entity.Property(e => e.Dd019FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_FILIAL_ID");
                entity.Property(e => e.Dd019ItematendimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_ITEMATENDIMENTO_ID");
                entity.Property(e => e.Dd019Motivoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_MOTIVOID");
                entity.Property(e => e.Dd019Pdescsolicitado)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD019_PDESCSOLICITADO");
                entity.Property(e => e.Dd019PercDesconto)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD019_PERC_DESCONTO");
                entity.Property(e => e.Dd019Precotabela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD019_PRECOTABELA");
                entity.Property(e => e.Dd019Prococolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD019_PROCOCOLNUMBER");
                entity.Property(e => e.Dd019Pvendafinal)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD019_PVENDAFINAL");
                entity.Property(e => e.Dd019StatusId).HasColumnName("DD019_STATUS_ID");
                entity.Property(e => e.Dd019TipoId).HasColumnName("DD019_TIPO_ID");
                entity.Property(e => e.Dd019UsuarioGerenteId)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_USUARIO_GERENTE_ID");
                entity.Property(e => e.Dd019UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD019_USUARIOPROP_ID");
                entity.Property(e => e.Dd019Valordescont)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD019_VALORDESCONT");
                entity.Property(e => e.Dd019Vdescsolicitado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD019_VDESCSOLICITADO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");




            });

            modelBuilder.Entity<CSICP_DD019Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD019_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD019_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD019Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD019_TIPO");

                entity.ToTable("OSUSR_TEI_CSICP_DD019_TIPO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD020>(entity =>
            {
                entity.HasKey(e => e.Dd020Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD020");

                entity.ToTable("OSUSR_TEI_CSICP_DD020");

                entity.HasIndex(e => new { e.Dd020StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD020_15DD020_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd020Usuarioprop, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD020_17DD020_USUARIOPROP_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd020Estabelecimentoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD020_23DD020_ESTABELECIMENTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD020_9TENANT_ID");

                entity.Property(e => e.Dd020Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD020_ID");
                entity.Property(e => e.Dd020Ano)
                    .HasMaxLength(4)
                    .HasColumnName("DD020_ANO");
                entity.Property(e => e.Dd020Dataregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD020_DATAREGISTRO");
                entity.Property(e => e.Dd020Descricao)
                    .HasMaxLength(250)
                    .HasColumnName("DD020_DESCRICAO");
                entity.Property(e => e.Dd020Estabelecimentoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD020_ESTABELECIMENTOID");
                entity.Property(e => e.Dd020Mes)
                    .HasMaxLength(2)
                    .HasColumnName("DD020_MES");
                entity.Property(e => e.Dd020Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD020_PROTOCOLNUMBER");
                entity.Property(e => e.Dd020StatusId).HasColumnName("DD020_STATUS_ID");
                entity.Property(e => e.Dd020Usuarioprop)
                    .HasMaxLength(36)
                    .HasColumnName("DD020_USUARIOPROP");
                entity.Property(e => e.Dd020Vdevolucoes)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD020_VDEVOLUCOES");
                entity.Property(e => e.Dd020Vtotalvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD020_VTOTALVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD020Metum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD020_META");

                entity.ToTable("OSUSR_TEI_CSICP_DD020_META");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD021>(entity =>
            {
                entity.HasKey(e => e.Dd021Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD021");

                entity.ToTable("OSUSR_TEI_CSICP_DD021");

                entity.HasIndex(e => new { e.Dd021Usuarioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD021_15DD021_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd021ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD021_20DD021_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd020Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD021_8DD020_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD021_9TENANT_ID");

                entity.Property(e => e.Dd021Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD021_ID");
                entity.Property(e => e.Dd020Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD020_ID");
                entity.Property(e => e.Dd021ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD021_RESPONSAVEL_ID");
                entity.Property(e => e.Dd021Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD021_USUARIOID");
                entity.Property(e => e.Dd021Vdevolucoes)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD021_VDEVOLUCOES");
                entity.Property(e => e.Dd021Vmetavenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD021_VMETAVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD025>(entity =>
            {
                entity.HasKey(e => e.Dd025Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD025");

                entity.ToTable("OSUSR_TEI_CSICP_DD025");

                entity.HasIndex(e => new { e.Dd025Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD025_14DD025_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd025Usuarioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD025_15DD025_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD025_9TENANT_ID");

                entity.Property(e => e.Dd025Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD025_ID");
                entity.Property(e => e.Dd025Ano)
                    .HasMaxLength(4)
                    .HasColumnName("DD025_ANO");
                entity.Property(e => e.Dd025Diasuteis).HasColumnName("DD025_DIASUTEIS");
                entity.Property(e => e.Dd025Mes)
                    .HasMaxLength(2)
                    .HasColumnName("DD025_MES");
                entity.Property(e => e.Dd025Qvendedor).HasColumnName("DD025_QVENDEDOR");
                entity.Property(e => e.Dd025Statusid).HasColumnName("DD025_STATUSID");
                entity.Property(e => e.Dd025Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD025_USUARIOID");
                entity.Property(e => e.Dd025Vdevolucoes)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD025_VDEVOLUCOES");
                entity.Property(e => e.Dd025Vmetavenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD025_VMETAVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD025Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD025_STAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD025_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD026>(entity =>
            {
                entity.HasKey(e => e.Dd026Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD026");

                entity.ToTable("OSUSR_TEI_CSICP_DD026");

                entity.HasIndex(e => new { e.Dd026Estabid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD026_13DD026_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd026Tpmetaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD026_14DD026_TPMETAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd026Vendedorid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD026_16DD026_VENDEDORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd026Grupoprodid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD026_17DD026_GRUPOPRODID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd025Planejmetaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD026_18DD025_PLANEJMETAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD026_9TENANT_ID");

                entity.Property(e => e.Dd026Id).HasColumnName("DD026_ID");
                entity.Property(e => e.Dd025Planejmetaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD025_PLANEJMETAID");
                entity.Property(e => e.Dd026Ano)
                    .HasMaxLength(4)
                    .HasColumnName("DD026_ANO");
                entity.Property(e => e.Dd026Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD026_ESTABID");
                entity.Property(e => e.Dd026Grupoprodid)
                    .HasMaxLength(36)
                    .HasColumnName("DD026_GRUPOPRODID");
                entity.Property(e => e.Dd026Mes)
                    .HasMaxLength(2)
                    .HasColumnName("DD026_MES");
                entity.Property(e => e.Dd026Pcomissao)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD026_PCOMISSAO");
                entity.Property(e => e.Dd026Qcobclientes).HasColumnName("DD026_QCOBCLIENTES");
                entity.Property(e => e.Dd026Tpmetaid).HasColumnName("DD026_TPMETAID");
                entity.Property(e => e.Dd026Vendedorid)
                    .HasMaxLength(36)
                    .HasColumnName("DD026_VENDEDORID");
                entity.Property(e => e.Dd026Vmeta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD026_VMETA");
                entity.Property(e => e.Dd026Vmetaindividual)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD026_VMETAINDIVIDUAL");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });

            modelBuilder.Entity<CSICP_DD026Tpm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD026_TPM");

                entity.ToTable("OSUSR_TEI_CSICP_DD026_TPM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD027>(entity =>
            {
                entity.HasKey(e => e.Dd027Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD027");

                entity.ToTable("OSUSR_TEI_CSICP_DD027");

                entity.HasIndex(e => new { e.Dd026Metaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD027_12DD026_METAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd027Estabid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD027_13DD027_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd027Vendedorid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD027_16DD027_VENDEDORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd027Grupoprodid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD027_17DD027_GRUPOPRODID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd025Planejmetaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD027_18DD025_PLANEJMETAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD027_9TENANT_ID");

                entity.Property(e => e.Dd027Id).HasColumnName("DD027_ID");
                entity.Property(e => e.Dd025Planejmetaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD025_PLANEJMETAID");
                entity.Property(e => e.Dd026Metaid).HasColumnName("DD026_METAID");
                entity.Property(e => e.Dd027Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD027_ESTABID");
                entity.Property(e => e.Dd027Grupoprodid)
                    .HasMaxLength(36)
                    .HasColumnName("DD027_GRUPOPRODID");
                entity.Property(e => e.Dd027Qcobclientes).HasColumnName("DD027_QCOBCLIENTES");
                entity.Property(e => e.Dd027Vdevolucao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD027_VDEVOLUCAO");
                entity.Property(e => e.Dd027Vendedorid)
                    .HasMaxLength(36)
                    .HasColumnName("DD027_VENDEDORID");
                entity.Property(e => e.Dd027Vvendabruta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD027_VVENDABRUTA");
                entity.Property(e => e.Dd027Vvendaliq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD027_VVENDALIQ");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });
        }

    }
}
