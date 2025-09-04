using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Domain.DELETAR;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OsusrE9aCsicpBb012> OsusrE9aCsicpBb012s { get; set; }

    public virtual DbSet<OsusrE9aCsicpBb027Imp> OsusrE9aCsicpBb027Imps { get; set; }

    public virtual DbSet<OsusrE9aCsicpGg008rftransacao> OsusrE9aCsicpGg008rftransacaos { get; set; }

    public virtual DbSet<OsusrTeiCsicpCc040> OsusrTeiCsicpCc040s { get; set; }

    public virtual DbSet<OsusrTeiCsicpCc061Cfgimp> OsusrTeiCsicpCc061Cfgimps { get; set; }

    public virtual DbSet<OsusrTeiCsicpDd040> OsusrTeiCsicpDd040s { get; set; }

    public virtual DbSet<OsusrTeiCsicpDd061Cfgimp> OsusrTeiCsicpDd061Cfgimps { get; set; }

    public virtual DbSet<OsusrTeiCsicpDd070> OsusrTeiCsicpDd070s { get; set; }

    public virtual DbSet<OsusrTeiCsicpDd081Cfgimp> OsusrTeiCsicpDd081Cfgimps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dbdsv17.csicorpnet.com.br;Database=CSOS_DSV03_ERP17;User Id=CSSPRUN_DSV17;Password=CSSPRUN17;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<OsusrE9aCsicpBb012>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012");

            entity.ToTable("OSUSR_E9A_CSICP_BB012");

            entity.HasIndex(e => new { e.Bb012Codigo, e.Bb012Keyacess, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_12BB012_CODIGO_14BB012_KEYACESS_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_12BB012_CODIGO_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Tpgovid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_13BB012_TPGOVID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Sequence, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_14BB012_SEQUENCE_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Estabcadid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_16BB012_ESTABCADID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012IdIndicador, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_ID_INDICADOR_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012NomeCliente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_NOME_CLIENTE_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012SitContaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_SIT_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012DataCadastro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_DATA_CADASTRO_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Dultalteracao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_DULTALTERACAO_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012GrupocontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_GRUPOCONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012ModrelacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_MODRELACAO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012Oricadastroid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_ORICADASTROID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012TipoContaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_TIPO_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012ClassecontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_20BB012_CLASSECONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012StatuscontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_20BB012_STATUSCONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012RflcespecialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_21BB012_RFLCESPECIAL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb012DataAniversario, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_22BB012_DATA_ANIVERSARIO_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012_9TENANT_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Bb012ClassecontaId).HasColumnName("BB012_CLASSECONTA_ID");
            entity.Property(e => e.Bb012Codigo).HasColumnName("BB012_CODIGO");
            entity.Property(e => e.Bb012Countappmcon).HasColumnName("BB012_COUNTAPPMCON");
            entity.Property(e => e.Bb012DataAniversario)
                .HasColumnType("datetime")
                .HasColumnName("BB012_DATA_ANIVERSARIO");
            entity.Property(e => e.Bb012DataCadastro)
                .HasColumnType("datetime")
                .HasColumnName("BB012_DATA_CADASTRO");
            entity.Property(e => e.Bb012DataEntradaSit)
                .HasColumnType("datetime")
                .HasColumnName("BB012_DATA_ENTRADA_SIT");
            entity.Property(e => e.Bb012DataSaidaSit)
                .HasColumnType("datetime")
                .HasColumnName("BB012_DATA_SAIDA_SIT");
            entity.Property(e => e.Bb012Descricao)
                .HasMaxLength(500)
                .HasColumnName("BB012_DESCRICAO");
            entity.Property(e => e.Bb012Dultalteracao)
                .HasColumnType("datetime")
                .HasColumnName("BB012_DULTALTERACAO");
            entity.Property(e => e.Bb012Email)
                .HasMaxLength(250)
                .HasColumnName("BB012_EMAIL");
            entity.Property(e => e.Bb012Estabcadid)
                .HasMaxLength(36)
                .HasColumnName("BB012_ESTABCADID");
            entity.Property(e => e.Bb012Faxcelular)
                .HasMaxLength(20)
                .HasColumnName("BB012_FAXCELULAR");
            entity.Property(e => e.Bb012GrupocontaId).HasColumnName("BB012_GRUPOCONTA_ID");
            entity.Property(e => e.Bb012HomePage)
                .HasMaxLength(150)
                .HasColumnName("BB012_HOME_PAGE");
            entity.Property(e => e.Bb012IdIndicador)
                .HasMaxLength(36)
                .HasColumnName("BB012_ID_INDICADOR");
            entity.Property(e => e.Bb012IsActive).HasColumnName("BB012_IS_ACTIVE");
            entity.Property(e => e.Bb012Keyacess)
                .HasMaxLength(10)
                .HasColumnName("BB012_KEYACESS");
            entity.Property(e => e.Bb012LcespecialId)
                .HasMaxLength(36)
                .HasColumnName("BB012_LCESPECIAL_ID");
            entity.Property(e => e.Bb012LcespecialIdExclui)
                .HasMaxLength(50)
                .HasColumnName("BB012_LCESPECIAL_ID_EXCLUI");
            entity.Property(e => e.Bb012ModrelacaoId).HasColumnName("BB012_MODRELACAO_ID");
            entity.Property(e => e.Bb012NomeCliente)
                .HasMaxLength(80)
                .HasColumnName("BB012_NOME_CLIENTE");
            entity.Property(e => e.Bb012NomeFantasia)
                .HasMaxLength(80)
                .HasColumnName("BB012_NOME_FANTASIA");
            entity.Property(e => e.Bb012Oricadastroid).HasColumnName("BB012_ORICADASTROID");
            entity.Property(e => e.Bb012RflcespecialId)
                .HasMaxLength(36)
                .HasColumnName("BB012_RFLCESPECIAL_ID");
            entity.Property(e => e.Bb012Sequence).HasColumnName("BB012_SEQUENCE");
            entity.Property(e => e.Bb012SitContaId).HasColumnName("BB012_SIT_CONTA_ID");
            entity.Property(e => e.Bb012StatuscontaId).HasColumnName("BB012_STATUSCONTA_ID");
            entity.Property(e => e.Bb012Telefone)
                .HasMaxLength(20)
                .HasColumnName("BB012_TELEFONE");
            entity.Property(e => e.Bb012TipoContaId).HasColumnName("BB012_TIPO_CONTA_ID");
            entity.Property(e => e.Bb012Tpgovid).HasColumnName("BB012_TPGOVID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            entity.HasOne(d => d.Bb012IdIndicadorNavigation).WithMany(p => p.InverseBb012IdIndicadorNavigation)
                .HasForeignKey(d => d.Bb012IdIndicador)
                .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012_OSUSR_E9A_CSICP_BB012_BB012_ID_INDICADOR");
        });

        modelBuilder.Entity<OsusrE9aCsicpBb027Imp>(entity =>
        {
            entity.HasKey(e => e.Bb027bId).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_IMP");

            entity.ToTable("OSUSR_E9A_CSICP_BB027_IMP");

            entity.HasIndex(e => new { e.Bb027bRflcId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_14BB027B_RFLC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027cIndpres, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_14BB027C_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bModbcId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_15BB027B_MODBC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bMp255Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_15BB027B_MP255_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bOrigemId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_16BB027B_ORIGEM_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bRegimeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_16BB027B_REGIME_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCcredpreid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_CCREDPREID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCstIpiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_CST_IPI_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCstPisId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_CST_PIS_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bTpdebcreid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_TPDEBCREID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bUfDestId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_UF_DEST_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCstIcmsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_18BB027B_CST_ICMS_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bImpostosId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_18BB027B_IMPOSTOS_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCstCofinsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_20BB027B_CST_COFINS_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_21BB027B_CENQUAD_IPI_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bClassecontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_21BB027B_CLASSECONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bRfclasstribId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_21BB027B_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bCfopStaticaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_CFOP_STATICA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bFcalcicmsdesId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_FCALCICMSDES_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bNatBcCredPis, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_NAT_BC_CRED_PIS_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bMotdesoneracaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_23BB027B_MOTDESONERACAOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bVicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_23BB027B_VICMSDESONSUB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bIsRfclasstribId2, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_25BB027B_IS_RFCLASSTRIB_ID2_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bModalbcIcmsStId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_25BB027B_MODALBC_ICMS_ST_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027bNatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_25BB027B_NAT_BC_CRED_COFINS_9TENANT_ID");

            entity.HasIndex(e => new { e.Bb027Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_8BB027_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_9TENANT_ID");

            entity.Property(e => e.Bb027bId)
                .HasMaxLength(36)
                .HasColumnName("BB027B_ID");
            entity.Property(e => e.Bb027Id)
                .HasMaxLength(36)
                .HasColumnName("BB027_ID");
            entity.Property(e => e.Bb027bAliqInternauf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_ALIQ_INTERNAUF");
            entity.Property(e => e.Bb027bAliquota)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("BB027B_ALIQUOTA");
            entity.Property(e => e.Bb027bCbenef)
                .HasMaxLength(20)
                .HasColumnName("BB027B_CBENEF");
            entity.Property(e => e.Bb027bCcredpreid).HasColumnName("BB027B_CCREDPREID");
            entity.Property(e => e.Bb027bCenquadIpiId).HasColumnName("BB027B_CENQUAD_IPI_ID");
            entity.Property(e => e.Bb027bCfopStaticaId).HasColumnName("BB027B_CFOP_STATICA_ID");
            entity.Property(e => e.Bb027bClassecontaId).HasColumnName("BB027B_CLASSECONTA_ID");
            entity.Property(e => e.Bb027bClasstribId).HasColumnName("BB027B_CLASSTRIB_ID");
            entity.Property(e => e.Bb027bClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("BB027B_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Bb027bCodgcst)
                .HasMaxLength(5)
                .HasColumnName("BB027B_CODGCST");
            entity.Property(e => e.Bb027bCodgfilial).HasColumnName("BB027B_CODGFILIAL");
            entity.Property(e => e.Bb027bCodgtransacao).HasColumnName("BB027B_CODGTRANSACAO");
            entity.Property(e => e.Bb027bCstCofinsId).HasColumnName("BB027B_CST_COFINS_ID");
            entity.Property(e => e.Bb027bCstIcmsId).HasColumnName("BB027B_CST_ICMS_ID");
            entity.Property(e => e.Bb027bCstIpiId).HasColumnName("BB027B_CST_IPI_ID");
            entity.Property(e => e.Bb027bCstPisId).HasColumnName("BB027B_CST_PIS_ID");
            entity.Property(e => e.Bb027bFcalcicmsdesId).HasColumnName("BB027B_FCALCICMSDES_ID");
            entity.Property(e => e.Bb027bHashid)
                .HasMaxLength(36)
                .HasColumnName("BB027B_HASHID");
            entity.Property(e => e.Bb027bImpostosId).HasColumnName("BB027B_IMPOSTOS_ID");
            entity.Property(e => e.Bb027bInformacoescofins)
                .HasMaxLength(200)
                .HasColumnName("BB027B_INFORMACOESCOFINS");
            entity.Property(e => e.Bb027bInformacoesipi)
                .HasMaxLength(200)
                .HasColumnName("BB027B_INFORMACOESIPI");
            entity.Property(e => e.Bb027bInformacoesnf)
                .HasMaxLength(200)
                .HasColumnName("BB027B_INFORMACOESNF");
            entity.Property(e => e.Bb027bInformacoespis)
                .HasMaxLength(200)
                .HasColumnName("BB027B_INFORMACOESPIS");
            entity.Property(e => e.Bb027bIsClasstribId).HasColumnName("BB027B_IS_CLASSTRIB_ID");
            entity.Property(e => e.Bb027bIsClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("BB027B_IS_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Bb027bIsRfclasstribId2).HasColumnName("BB027B_IS_RFCLASSTRIB_ID2");
            entity.Property(e => e.Bb027bIsvicmsdesSubtrai).HasColumnName("BB027B_ISVICMSDES_SUBTRAI");
            entity.Property(e => e.Bb027bLcId)
                .HasMaxLength(36)
                .HasColumnName("BB027B_LC_ID");
            entity.Property(e => e.Bb027bLcIdExclui)
                .HasMaxLength(50)
                .HasColumnName("BB027B_LC_ID_EXCLUI");
            entity.Property(e => e.Bb027bModalbcIcmsStId).HasColumnName("BB027B_MODALBC_ICMS_ST_ID");
            entity.Property(e => e.Bb027bModbcId).HasColumnName("BB027B_MODBC_ID");
            entity.Property(e => e.Bb027bMotdesoneracaoid).HasColumnName("BB027B_MOTDESONERACAOID");
            entity.Property(e => e.Bb027bMp255Id).HasColumnName("BB027B_MP255_ID");
            entity.Property(e => e.Bb027bNatBcCredCofins).HasColumnName("BB027B_NAT_BC_CRED_COFINS");
            entity.Property(e => e.Bb027bNatBcCredPis).HasColumnName("BB027B_NAT_BC_CRED_PIS");
            entity.Property(e => e.Bb027bOrigemId).HasColumnName("BB027B_ORIGEM_ID");
            entity.Property(e => e.Bb027bPaliqefetregCbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PALIQEFETREG_CBS");
            entity.Property(e => e.Bb027bPaliqefetregIbsMun)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PALIQEFETREG_IBS_MUN");
            entity.Property(e => e.Bb027bPaliqefetregIbsUf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PALIQEFETREG_IBS_UF");
            entity.Property(e => e.Bb027bPcbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PCBS");
            entity.Property(e => e.Bb027bPcredpresCbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PCREDPRES_CBS");
            entity.Property(e => e.Bb027bPcredpresIbsMun)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PCREDPRES_IBS_MUN");
            entity.Property(e => e.Bb027bPcredpresIbsUf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PCREDPRES_IBS_UF");
            entity.Property(e => e.Bb027bPdifCbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PDIF_CBS");
            entity.Property(e => e.Bb027bPdifIbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PDIF_IBS");
            entity.Property(e => e.Bb027bPdifIbsMun)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PDIF_IBS_MUN");
            entity.Property(e => e.Bb027bPdifIbsUf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PDIF_IBS_UF");
            entity.Property(e => e.Bb027bPibsMun)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PIBS_MUN");
            entity.Property(e => e.Bb027bPibsUf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PIBS_UF");
            entity.Property(e => e.Bb027bPicmsDiferido)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BB027B_PICMS_DIFERIDO");
            entity.Property(e => e.Bb027bPpropocaodestino)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("BB027B_PPROPOCAODESTINO");
            entity.Property(e => e.Bb027bPreducaocbs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PREDUCAOCBS");
            entity.Property(e => e.Bb027bPreducaoibs)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("BB027B_PREDUCAOIBS");
            entity.Property(e => e.Bb027bReducaobase)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BB027B_REDUCAOBASE");
            entity.Property(e => e.Bb027bReducaobcst)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BB027B_REDUCAOBCST");
            entity.Property(e => e.Bb027bRegimeId).HasColumnName("BB027B_REGIME_ID");
            entity.Property(e => e.Bb027bRfclasstribId).HasColumnName("BB027B_RFCLASSTRIB_ID");
            entity.Property(e => e.Bb027bRflcId)
                .HasMaxLength(36)
                .HasColumnName("BB027B_RFLC_ID");
            entity.Property(e => e.Bb027bTpdebcreid).HasColumnName("BB027B_TPDEBCREID");
            entity.Property(e => e.Bb027bUfDestId)
                .HasMaxLength(36)
                .HasColumnName("BB027B_UF_DEST_ID");
            entity.Property(e => e.Bb027bVicmsdesonsubId).HasColumnName("BB027B_VICMSDESONSUB_ID");
            entity.Property(e => e.Bb027cIndpres).HasColumnName("BB027C_INDPRES");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<OsusrE9aCsicpGg008rftransacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008RFTRANSACAO");

            entity.ToTable("OSUSR_E9A_CSICP_GG008RFTRANSACAO");

            entity.HasIndex(e => new { e.Gg008tNcmId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_13GG008T_NCM_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg008tFilialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_15GG008T_FILIALID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg008tKardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_16GG008T_KARDEX_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg008tTransacaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_18GG008T_TRANSACAOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg008tTiporegistro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_19GG008T_TIPOREGISTRO_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008RFTRANSACAO_9TENANT_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Gg008tFilialid)
                .HasMaxLength(36)
                .HasColumnName("GG008T_FILIALID");
            entity.Property(e => e.Gg008tKardexId)
                .HasMaxLength(36)
                .HasColumnName("GG008T_KARDEX_ID");
            entity.Property(e => e.Gg008tNcmId)
                .HasMaxLength(36)
                .HasColumnName("GG008T_NCM_ID");
            entity.Property(e => e.Gg008tTiporegistro).HasColumnName("GG008T_TIPOREGISTRO");
            entity.Property(e => e.Gg008tTransacaoid)
                .HasMaxLength(36)
                .HasColumnName("GG008T_TRANSACAOID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpCc040>(entity =>
        {
            entity.HasKey(e => e.Cc040Id).HasName("OSPRK_OSUSR_TEI_CSICP_CC040");

            entity.ToTable("OSUSR_TEI_CSICP_CC040", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_CC040"));

            entity.HasIndex(e => new { e.Cc040Serie, e.Cc040NoNf, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_11CC040_SERIE_11CC040_NO_NF_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040ModId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_12CC040_MOD_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Indpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_13CC040_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_14CC040_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.B34Tpopergovid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_15B34_TPOPERGOVID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_15CC040_CCUSTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_15CC040_EMPRESAID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040EspecieId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_16CC040_ESPECIE_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Tpdebcreid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_16DD040_TPDEBCREID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Dataentrada, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_17CC040_DATAENTRADA_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Statuswmsid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_17CC040_STATUSWMSID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040TiponotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_17CC040_TIPONOTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040CompradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_18CC040_COMPRADOR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040DataEmissao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_18CC040_DATA_EMISSAO_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_19CC040_AGCOBRADOR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040CondPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_19CC040_COND_PAGTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Chaveacessonfe, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_CHAVEACESSONFE_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040ClassecontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_CLASSECONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_NATOPERACAO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_PROTOCOLNUMBER_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_RESPONSAVEL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040StatusNotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_20CC040_STATUS_NOTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040StatusFinancId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_22CC040_STATUS_FINANC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040StatusPrecifId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_22CC040_STATUS_PRECIF_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040UsuarioProprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_22CC040_USUARIO_PROPR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_22CC040_VICMSDESONSUB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040CtbIsestornadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_23CC040_CTB_ISESTORNADOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040PrecifUsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_23CC040_PRECIF_USUARIO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040StatusEstoqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_23CC040_STATUS_ESTOQUE_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc040CtbIscontabilizadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC040_27CC040_CTB_ISCONTABILIZADOID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_CC040_9TENANT_ID");

            entity.Property(e => e.Cc040Id)
                .HasMaxLength(36)
                .HasColumnName("CC040_ID");
            entity.Property(e => e.B33Predutor)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("B33_PREDUTOR");
            entity.Property(e => e.B34Tpopergovid).HasColumnName("B34_TPOPERGOVID");
            entity.Property(e => e.Cc040Acrescimo)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_ACRESCIMO");
            entity.Property(e => e.Cc040AgcobradorId)
                .HasMaxLength(36)
                .HasColumnName("CC040_AGCOBRADOR_ID");
            entity.Property(e => e.Cc040CcustoId)
                .HasMaxLength(36)
                .HasColumnName("CC040_CCUSTO_ID");
            entity.Property(e => e.Cc040Chaveacessonfe)
                .HasMaxLength(50)
                .HasColumnName("CC040_CHAVEACESSONFE");
            entity.Property(e => e.Cc040ClassecontaId).HasColumnName("CC040_CLASSECONTA_ID");
            entity.Property(e => e.Cc040CodgAgcobrador).HasColumnName("CC040_CODG_AGCOBRADOR");
            entity.Property(e => e.Cc040CodgCcusto).HasColumnName("CC040_CODG_CCUSTO");
            entity.Property(e => e.Cc040CodgCondPagto).HasColumnName("CC040_CODG_COND_PAGTO");
            entity.Property(e => e.Cc040Codnatoperacao)
                .HasMaxLength(10)
                .HasColumnName("CC040_CODNATOPERACAO");
            entity.Property(e => e.Cc040CompradorId)
                .HasMaxLength(36)
                .HasColumnName("CC040_COMPRADOR_ID");
            entity.Property(e => e.Cc040CondPagtoId)
                .HasMaxLength(36)
                .HasColumnName("CC040_COND_PAGTO_ID");
            entity.Property(e => e.Cc040ContaId)
                .HasMaxLength(36)
                .HasColumnName("CC040_CONTA_ID");
            entity.Property(e => e.Cc040CtbDtregistro)
                .HasColumnType("datetime")
                .HasColumnName("CC040_CTB_DTREGISTRO");
            entity.Property(e => e.Cc040CtbEstdtreg)
                .HasColumnType("datetime")
                .HasColumnName("CC040_CTB_ESTDTREG");
            entity.Property(e => e.Cc040CtbEstusuarioid)
                .HasMaxLength(36)
                .HasColumnName("CC040_CTB_ESTUSUARIOID");
            entity.Property(e => e.Cc040CtbIdlancto).HasColumnName("CC040_CTB_IDLANCTO");
            entity.Property(e => e.Cc040CtbIscontabilizadoid).HasColumnName("CC040_CTB_ISCONTABILIZADOID");
            entity.Property(e => e.Cc040CtbIsestornadoid).HasColumnName("CC040_CTB_ISESTORNADOID");
            entity.Property(e => e.Cc040CtbMsg)
                .HasMaxLength(100)
                .HasColumnName("CC040_CTB_MSG");
            entity.Property(e => e.Cc040CtbUsuarioid)
                .HasMaxLength(36)
                .HasColumnName("CC040_CTB_USUARIOID");
            entity.Property(e => e.Cc040DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("CC040_DATA_EMISSAO");
            entity.Property(e => e.Cc040DataMovimento)
                .HasColumnType("datetime")
                .HasColumnName("CC040_DATA_MOVIMENTO");
            entity.Property(e => e.Cc040DataSaida)
                .HasColumnType("datetime")
                .HasColumnName("CC040_DATA_SAIDA");
            entity.Property(e => e.Cc040Dataentrada)
                .HasColumnType("datetime")
                .HasColumnName("CC040_DATAENTRADA");
            entity.Property(e => e.Cc040Desconto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_DESCONTO");
            entity.Property(e => e.Cc040Empresaid)
                .HasMaxLength(36)
                .HasColumnName("CC040_EMPRESAID");
            entity.Property(e => e.Cc040Especie)
                .HasMaxLength(60)
                .HasColumnName("CC040_ESPECIE");
            entity.Property(e => e.Cc040EspecieId)
                .HasMaxLength(36)
                .HasColumnName("CC040_ESPECIE_ID");
            entity.Property(e => e.Cc040Filial).HasColumnName("CC040_FILIAL");
            entity.Property(e => e.Cc040FreteCifFob).HasColumnName("CC040_FRETE_CIF_FOB");
            entity.Property(e => e.Cc040HoraSaida)
                .HasColumnType("datetime")
                .HasColumnName("CC040_HORA_SAIDA");
            entity.Property(e => e.Cc040Indpres).HasColumnName("CC040_INDPRES");
            entity.Property(e => e.Cc040Iscontaspagar).HasColumnName("CC040_ISCONTASPAGAR");
            entity.Property(e => e.Cc040Iscopiada).HasColumnName("CC040_ISCOPIADA");
            entity.Property(e => e.Cc040Isgradebx).HasColumnName("CC040_ISGRADEBX");
            entity.Property(e => e.Cc040IssubtraiIcmsDeson).HasColumnName("CC040_ISSUBTRAI_ICMS_DESON");
            entity.Property(e => e.Cc040Mod)
                .HasMaxLength(2)
                .HasColumnName("CC040_MOD");
            entity.Property(e => e.Cc040ModId).HasColumnName("CC040_MOD_ID");
            entity.Property(e => e.Cc040Motdesoneracaoid).HasColumnName("CC040_MOTDESONERACAOID");
            entity.Property(e => e.Cc040NatoperacaoId)
                .HasMaxLength(36)
                .HasColumnName("CC040_NATOPERACAO_ID");
            entity.Property(e => e.Cc040NoNf).HasColumnName("CC040_NO_NF");
            entity.Property(e => e.Cc040NoPedido)
                .HasMaxLength(50)
                .HasColumnName("CC040_NO_PEDIDO");
            entity.Property(e => e.Cc040NroTitulo)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("CC040_NRO_TITULO");
            entity.Property(e => e.Cc040Perc1Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERC1_DESCONTO");
            entity.Property(e => e.Cc040Perc2Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERC2_DESCONTO");
            entity.Property(e => e.Cc040Perc3Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERC3_DESCONTO");
            entity.Property(e => e.Cc040Perc4Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERC4_DESCONTO");
            entity.Property(e => e.Cc040Perc5Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERC5_DESCONTO");
            entity.Property(e => e.Cc040Percdescservico)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CC040_PERCDESCSERVICO");
            entity.Property(e => e.Cc040PesoBruto)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("CC040_PESO_BRUTO");
            entity.Property(e => e.Cc040PesoLiquido)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("CC040_PESO_LIQUIDO");
            entity.Property(e => e.Cc040Picmsdesonerado)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("CC040_PICMSDESONERADO");
            entity.Property(e => e.Cc040PrecifUsuarioId)
                .HasMaxLength(36)
                .HasColumnName("CC040_PRECIF_USUARIO_ID");
            entity.Property(e => e.Cc040Protocolnumber)
                .HasMaxLength(20)
                .HasColumnName("CC040_PROTOCOLNUMBER");
            entity.Property(e => e.Cc040Psimples)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("CC040_PSIMPLES");
            entity.Property(e => e.Cc040QtdVolumes).HasColumnName("CC040_QTD_VOLUMES");
            entity.Property(e => e.Cc040QtdeParcelas).HasColumnName("CC040_QTDE_PARCELAS");
            entity.Property(e => e.Cc040ResponsavelId)
                .HasMaxLength(36)
                .HasColumnName("CC040_RESPONSAVEL_ID");
            entity.Property(e => e.Cc040Serie)
                .HasMaxLength(5)
                .HasColumnName("CC040_SERIE");
            entity.Property(e => e.Cc040StatusEstoqueId).HasColumnName("CC040_STATUS_ESTOQUE_ID");
            entity.Property(e => e.Cc040StatusFinancId).HasColumnName("CC040_STATUS_FINANC_ID");
            entity.Property(e => e.Cc040StatusNotaId).HasColumnName("CC040_STATUS_NOTA_ID");
            entity.Property(e => e.Cc040StatusPrecifId).HasColumnName("CC040_STATUS_PRECIF_ID");
            entity.Property(e => e.Cc040Statuswmsid).HasColumnName("CC040_STATUSWMSID");
            entity.Property(e => e.Cc040Texto)
                .HasMaxLength(500)
                .HasColumnName("CC040_TEXTO");
            entity.Property(e => e.Cc040TipoMovimento).HasColumnName("CC040_TIPO_MOVIMENTO");
            entity.Property(e => e.Cc040TiponotaId).HasColumnName("CC040_TIPONOTA_ID");
            entity.Property(e => e.Cc040TotalBruto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_BRUTO");
            entity.Property(e => e.Cc040TotalDescsuframa)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_DESCSUFRAMA");
            entity.Property(e => e.Cc040TotalFrete)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_FRETE");
            entity.Property(e => e.Cc040TotalLiquido)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_LIQUIDO");
            entity.Property(e => e.Cc040TotalOutdespesas)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_OUTDESPESAS");
            entity.Property(e => e.Cc040TotalSeguro)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_SEGURO");
            entity.Property(e => e.Cc040TotalServico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTAL_SERVICO");
            entity.Property(e => e.Cc040TotalprodEServ)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTALPROD_E_SERV");
            entity.Property(e => e.Cc040Totliqservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TOTLIQSERVICO");
            entity.Property(e => e.Cc040Tretencaoimp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_TRETENCAOIMP");
            entity.Property(e => e.Cc040UsuarioProprId)
                .HasMaxLength(36)
                .HasColumnName("CC040_USUARIO_PROPR_ID");
            entity.Property(e => e.Cc040ValorEntrada)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VALOR_ENTRADA");
            entity.Property(e => e.Cc040Vbc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VBC");
            entity.Property(e => e.Cc040Vbcst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VBCST");
            entity.Property(e => e.Cc040Vcofins)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VCOFINS");
            entity.Property(e => e.Cc040Vfcp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VFCP");
            entity.Property(e => e.Cc040Vfcpst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VFCPST");
            entity.Property(e => e.Cc040Vfcpstret)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VFCPSTRET");
            entity.Property(e => e.Cc040Vfreteconhec)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VFRETECONHEC");
            entity.Property(e => e.Cc040Vicms)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VICMS");
            entity.Property(e => e.Cc040VicmsFrete)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VICMS_FRETE");
            entity.Property(e => e.Cc040Vicmsdeson)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VICMSDESON");
            entity.Property(e => e.Cc040VicmsdesonsubId).HasColumnName("CC040_VICMSDESONSUB_ID");
            entity.Property(e => e.Cc040Vii)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VII");
            entity.Property(e => e.Cc040Vipi)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VIPI");
            entity.Property(e => e.Cc040Vipidevol)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VIPIDEVOL");
            entity.Property(e => e.Cc040Vlrafinanciar)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VLRAFINANCIAR");
            entity.Property(e => e.Cc040Vlrdescservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VLRDESCSERVICO");
            entity.Property(e => e.Cc040Vpis)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VPIS");
            entity.Property(e => e.Cc040Vst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VST");
            entity.Property(e => e.Cc040Vsuframa)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VSUFRAMA");
            entity.Property(e => e.Cc040Vvpc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CC040_VVPC");
            entity.Property(e => e.Dd040Tpdebcreid).HasColumnName("DD040_TPDEBCREID");
            entity.Property(e => e.Processid).HasColumnName("PROCESSID");
            entity.Property(e => e.ProcessidFinanceiro).HasColumnName("PROCESSID_FINANCEIRO");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.W06b1Qbcmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06B_1_QBCMONO");
            entity.Property(e => e.W06c1Qbcmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_1_QBCMONORETEN");
            entity.Property(e => e.W06cVicmsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_VICMSMONO");
            entity.Property(e => e.W06d1Qbcmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_1_QBCMONORET");
            entity.Property(e => e.W06dVicmsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_VICMSMONORETEN");
            entity.Property(e => e.W06eVicmsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06E_VICMSMONORET");
            entity.Property(e => e.W33Vbcis)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("W33_VBCIS");
            entity.Property(e => e.W33Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W33_VIS");
            entity.Property(e => e.W34Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W34_VIS");
            entity.Property(e => e.W35Vbcibscbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W35_VBCIBSCBS");
            entity.Property(e => e.W38IbsufVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W38_IBSUF_VDIF");
            entity.Property(e => e.W39IbsufVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W39_IBSUF_VDEVTRIB");
            entity.Property(e => e.W41Vibsuf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W41_VIBSUF");
            entity.Property(e => e.W43IbsmunVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W43_IBSMUN_VDIF");
            entity.Property(e => e.W44IbsmunVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W44_IBSMUN__VDEVTRIB");
            entity.Property(e => e.W46Vibsmun)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W46_VIBSMUN");
            entity.Property(e => e.W47IbsmunVibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_IBSMUN_VIBSTOT");
            entity.Property(e => e.W47Vibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_VIBSTOT");
            entity.Property(e => e.W48IbsmunVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_IBSMUN_VCREDPRES");
            entity.Property(e => e.W48Vcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_VCREDPRES");
            entity.Property(e => e.W49IbsmunVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_IBSMUN_VCREDPRESCONDSUS");
            entity.Property(e => e.W49Vcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_VCREDPRESCONDSUS");
            entity.Property(e => e.W51CbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W51_CBS_VCREDPRES");
            entity.Property(e => e.W52CbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W52_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W53CbsVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W53_CBS_VDIF");
            entity.Property(e => e.W54CbsVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W54_CBS_VDEVTRIB");
            entity.Property(e => e.W56Vcbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56_VCBS");
            entity.Property(e => e.W56aCbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56A_CBS_VCREDPRES");
            entity.Property(e => e.W56bCbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56B_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W58Vtotibsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W58_VTOTIBSMONO");
            entity.Property(e => e.W59Vtotcbsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59_VTOTCBSMONO");
            entity.Property(e => e.W59bVcbsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59B_VCBSMONORETEN");
            entity.Property(e => e.W59cVibsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59C_VIBSMONORETEN");
            entity.Property(e => e.W59dVcbsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59D_VCBSMONORET");
            entity.Property(e => e.W60Vtotnf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W60_VTOTNF");

            entity.HasOne(d => d.Cc040Conta).WithMany(p => p.OsusrTeiCsicpCc040s)
                .HasForeignKey(d => d.Cc040ContaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_CC040_OSUSR_E9A_CSICP_BB012_CC040_CONTA_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpCc061Cfgimp>(entity =>
        {
            entity.HasKey(e => e.Cc060Id).HasName("OSPRK_OSUSR_TEI_CSICP_CC061_CFGIMP");

            entity.ToTable("OSUSR_TEI_CSICP_CC061_CFGIMP");

            entity.HasIndex(e => new { e.Dd061RflcId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_13DD061_RFLC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub7479Ccredpresid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_19UB74_79_CCREDPRESID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc061NatBcCredPis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_21CC061_NAT_BC_CRED_PIS_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc061Bb027bCfgimpId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_22CC061_BB027B_CFGIMP_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub03IsRfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_22UB03_IS_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub13ub14RfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_23UB13UB14_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc061NatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_24CC061_NAT_BC_CRED_COFINS_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub6970RfclasstribregId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_25UB69_70_RFCLASSTRIBREG_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc061Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_27CC061_BB027B_CENQUAD_IPI_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Cc060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_8CC060_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_CC061_CFGIMP_9TENANT_ID");

            entity.Property(e => e.Cc060Id)
                .HasMaxLength(36)
                .HasColumnName("CC060_ID");
            entity.Property(e => e.Cc061Bb027CfopId).HasColumnName("CC061_BB027_CFOP_ID");
            entity.Property(e => e.Cc061Bb027Id)
                .HasMaxLength(36)
                .HasColumnName("CC061_BB027_ID");
            entity.Property(e => e.Cc061Bb027bAliqInternauf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CC061_BB027B_ALIQ_INTERNAUF");
            entity.Property(e => e.Cc061Bb027bAliquota)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("CC061_BB027B_ALIQUOTA");
            entity.Property(e => e.Cc061Bb027bCenquadIpiId).HasColumnName("CC061_BB027B_CENQUAD_IPI_ID");
            entity.Property(e => e.Cc061Bb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("CC061_BB027B_CFGIMP_ID");
            entity.Property(e => e.Cc061Bb027bCfopEntradaId).HasColumnName("CC061_BB027B_CFOP_ENTRADA_ID");
            entity.Property(e => e.Cc061Bb027bCfopExcecaoId).HasColumnName("CC061_BB027B_CFOP_EXCECAO_ID");
            entity.Property(e => e.Cc061Bb027bClassecontaId).HasColumnName("CC061_BB027B_CLASSECONTA_ID");
            entity.Property(e => e.Cc061Bb027bCodgcst)
                .HasMaxLength(5)
                .HasColumnName("CC061_BB027B_CODGCST");
            entity.Property(e => e.Cc061Bb027bCstCofinsId).HasColumnName("CC061_BB027B_CST_COFINS_ID");
            entity.Property(e => e.Cc061Bb027bCstIcmsId).HasColumnName("CC061_BB027B_CST_ICMS_ID");
            entity.Property(e => e.Cc061Bb027bCstIpiId).HasColumnName("CC061_BB027B_CST_IPI_ID");
            entity.Property(e => e.Cc061Bb027bCstPisId).HasColumnName("CC061_BB027B_CST_PIS_ID");
            entity.Property(e => e.Cc061Bb027bInforcofins)
                .HasMaxLength(200)
                .HasColumnName("CC061_BB027B_INFORCOFINS");
            entity.Property(e => e.Cc061Bb027bInforipi)
                .HasMaxLength(200)
                .HasColumnName("CC061_BB027B_INFORIPI");
            entity.Property(e => e.Cc061Bb027bInfornf)
                .HasMaxLength(200)
                .HasColumnName("CC061_BB027B_INFORNF");
            entity.Property(e => e.Cc061Bb027bInforpis)
                .HasMaxLength(200)
                .HasColumnName("CC061_BB027B_INFORPIS");
            entity.Property(e => e.Cc061Bb027bModalbcIcmsSt).HasColumnName("CC061_BB027B_MODALBC_ICMS_ST");
            entity.Property(e => e.Cc061Bb027bModbcId).HasColumnName("CC061_BB027B_MODBC_ID");
            entity.Property(e => e.Cc061Bb027bMotdesoneracao).HasColumnName("CC061_BB027B_MOTDESONERACAO");
            entity.Property(e => e.Cc061Bb027bMp255Id).HasColumnName("CC061_BB027B_MP255_ID");
            entity.Property(e => e.Cc061Bb027bOrigemId).HasColumnName("CC061_BB027B_ORIGEM_ID");
            entity.Property(e => e.Cc061Bb027bReducaobase)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("CC061_BB027B_REDUCAOBASE");
            entity.Property(e => e.Cc061Bb027bReducaobcst)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("CC061_BB027B_REDUCAOBCST");
            entity.Property(e => e.Cc061Bb027bRegimeId).HasColumnName("CC061_BB027B_REGIME_ID");
            entity.Property(e => e.Cc061Bb027bUfDestId)
                .HasMaxLength(36)
                .HasColumnName("CC061_BB027B_UF_DEST_ID");
            entity.Property(e => e.Cc061NatBcCredCofins).HasColumnName("CC061_NAT_BC_CRED_COFINS");
            entity.Property(e => e.Cc061NatBcCredPis).HasColumnName("CC061_NAT_BC_CRED_PIS");
            entity.Property(e => e.Cc061RfBb027Id)
                .HasMaxLength(36)
                .HasColumnName("CC061_RF_BB027_ID");
            entity.Property(e => e.Cc061RfBb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("CC061_RF_BB027B_CFGIMP_ID");
          
            entity.Property(e => e.Dd061RflcId)
                .HasMaxLength(36)
                .HasColumnName("DD061_RFLC_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
          
            entity.Property(e => e.Ub03IsRfclasstribId).HasColumnName("UB03_IS_RFCLASSTRIB_ID");
         
            entity.Property(e => e.Ub13ub14RfclasstribId).HasColumnName("UB13UB14_RFCLASSTRIB_ID");
          
          
            entity.Property(e => e.Ub6970RfclasstribregId).HasColumnName("UB69_70_RFCLASSTRIBREG_ID");
            entity.Property(e => e.Ub7479Ccredpresid).HasColumnName("UB74_79_CCREDPRESID");
           

            entity.HasOne(d => d.Cc061Bb027bCfgimp).WithMany(p => p.OsusrTeiCsicpCc061Cfgimps)
                .HasForeignKey(d => d.Cc061Bb027bCfgimpId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_CC061_CFGIMP_OSUSR_E9A_CSICP_BB027_IMP_CC061_BB027B_CFGIMP_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpDd040>(entity =>
        {
            entity.HasKey(e => e.Dd040Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040");

            entity.ToTable("OSUSR_TEI_CSICP_DD040", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD040"));

            entity.HasIndex(e => new { e.Dd040Serie, e.Dd040NoNf, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_11DD040_SERIE_11DD040_NO_NF_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040ModId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_12DD040_MOD_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Tpemis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_12DD040_TPEMIS_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040DispId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_13DD040_DISP_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Indpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_13DD040_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_14DD040_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Situacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_14DD040_SITUACAO_9TENANT_ID");

            entity.HasIndex(e => new { e.B34Tpopergovid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15B34_TPOPERGOVID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_CCUSTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Empresaid, e.Dd040TiponotaId, e.Dd040NumImpressoes, e.Dd040SitNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_EMPRESAID_17DD040_TIPONOTA_ID_20DD040_NUM_IMPRESSOES_16DD040_SIT_NFE_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_EMPRESAID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040SitNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_16DD040_SIT_NFE_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Tpdebcreid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_16DD040_TPDEBCREID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Arquitetoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_ARQUITETOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040AvalistaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_AVALISTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Origemregpv, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_ORIGEMREGPV_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040TiponotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_TIPONOTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040ContarealId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_CONTAREAL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040DataEmissao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_DATA_EMISSAO_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Keyecommerce, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_KEYECOMMERCE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_MODENTREGAID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_AGCOBRADOR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Chavecashback, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_CHAVECASHBACK_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040CompContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_COMP_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040CondPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_COND_PAGTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040StEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_ST_ENTREGA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040ClassecontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_CLASSECONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_NATOPERACAO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_PROTOCOLNUMBER_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_RESPONSAVEL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd042Chaveacessonfe, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD042_CHAVEACESSONFE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040AlmoxdestinoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_21DD040_ALMOXDESTINO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_21DD040_MODALIDADEFRETE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040UsuarioProprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_22DD040_USUARIO_PROPR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_22DD040_VICMSDESONSUB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040CtbIsestornadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_23DD040_CTB_ISESTORNADOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040StatusEstoqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_23DD040_STATUS_ESTOQUE_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040Usuariofaturistaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_24DD040_USUARIOFATURISTAID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040UsuarioAtendenteid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_25DD040_USUARIO_ATENDENTEID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040CtbIscontabilizadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_27DD040_CTB_ISCONTABILIZADOID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD040_9TENANT_ID");

            entity.HasIndex(e => new { e.TenantId, e.Dd040Empresaid, e.Dd040Situacao, e.Dd040TiponotaId }, "cs_idxEx004_dd040_EmpSitTp");

            entity.HasIndex(e => new { e.Dd040Empresaid, e.Dd040TiponotaId, e.Dd040NumImpressoes, e.Dd040SitNfeId }, "cs_idxEx005_pdv_tmp");

            entity.Property(e => e.Dd040Id)
                .HasMaxLength(36)
                .HasColumnName("DD040_ID");
            entity.Property(e => e.B33Predutor)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("B33_PREDUTOR");
            entity.Property(e => e.B34Tpopergovid).HasColumnName("B34_TPOPERGOVID");
            entity.Property(e => e.Dd040Acrescimo)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_ACRESCIMO");
            entity.Property(e => e.Dd040AgcobradorId)
                .HasMaxLength(36)
                .HasColumnName("DD040_AGCOBRADOR_ID");
            entity.Property(e => e.Dd040Alfa50)
                .HasMaxLength(50)
                .HasColumnName("DD040_ALFA_50");
            entity.Property(e => e.Dd040AlmoxdestinoId)
                .HasMaxLength(36)
                .HasColumnName("DD040_ALMOXDESTINO_ID");
            entity.Property(e => e.Dd040Arquitetoid)
                .HasMaxLength(36)
                .HasColumnName("DD040_ARQUITETOID");
            entity.Property(e => e.Dd040AvalistaId)
                .HasMaxLength(36)
                .HasColumnName("DD040_AVALISTA_ID");
            entity.Property(e => e.Dd040CcustoId)
                .HasMaxLength(36)
                .HasColumnName("DD040_CCUSTO_ID");
            entity.Property(e => e.Dd040Chavecashback)
                .HasMaxLength(10)
                .HasColumnName("DD040_CHAVECASHBACK");
            entity.Property(e => e.Dd040CiOrcamento)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD040_CI_ORCAMENTO");
            entity.Property(e => e.Dd040ClassecontaId).HasColumnName("DD040_CLASSECONTA_ID");
            entity.Property(e => e.Dd040CnpjMarketplace)
                .HasMaxLength(14)
                .HasColumnName("DD040_CNPJ_MARKETPLACE");
            entity.Property(e => e.Dd040Codalmoxdestino).HasColumnName("DD040_CODALMOXDESTINO");
            entity.Property(e => e.Dd040CodgAgcobrador).HasColumnName("DD040_CODG_AGCOBRADOR");
            entity.Property(e => e.Dd040CodgAtendente).HasColumnName("DD040_CODG_ATENDENTE");
            entity.Property(e => e.Dd040CodgCcusto).HasColumnName("DD040_CODG_CCUSTO");
            entity.Property(e => e.Dd040CodgCondPagto).HasColumnName("DD040_CODG_COND_PAGTO");
            entity.Property(e => e.Dd040Codnatoperacao)
                .HasMaxLength(10)
                .HasColumnName("DD040_CODNATOPERACAO");
            entity.Property(e => e.Dd040Codrespcomprador).HasColumnName("DD040_CODRESPCOMPRADOR");
            entity.Property(e => e.Dd040Codrespvendedor).HasColumnName("DD040_CODRESPVENDEDOR");
            entity.Property(e => e.Dd040Codtabelapreco)
                .HasMaxLength(7)
                .HasColumnName("DD040_CODTABELAPRECO");
            entity.Property(e => e.Dd040Comissao).HasColumnName("DD040_COMISSAO");
            entity.Property(e => e.Dd040CompContaId)
                .HasMaxLength(36)
                .HasColumnName("DD040_COMP_CONTA_ID");
            entity.Property(e => e.Dd040CondPagtoId)
                .HasMaxLength(36)
                .HasColumnName("DD040_COND_PAGTO_ID");
            entity.Property(e => e.Dd040ContaId)
                .HasMaxLength(36)
                .HasColumnName("DD040_CONTA_ID");
            entity.Property(e => e.Dd040ContarealId)
                .HasMaxLength(36)
                .HasColumnName("DD040_CONTAREAL_ID");
            entity.Property(e => e.Dd040CorreiosCodRastreio)
                .HasMaxLength(20)
                .HasColumnName("DD040_CORREIOS_COD_RASTREIO");
            entity.Property(e => e.Dd040CorreiosDetalhe)
                .HasMaxLength(255)
                .HasColumnName("DD040_CORREIOS_DETALHE");
            entity.Property(e => e.Dd040CorreiosSiglaTriagem)
                .HasMaxLength(3)
                .HasColumnName("DD040_CORREIOS_SIGLA_TRIAGEM");
            entity.Property(e => e.Dd040CtbDtregistro)
                .HasColumnType("datetime")
                .HasColumnName("DD040_CTB_DTREGISTRO");
            entity.Property(e => e.Dd040CtbEstdtreg)
                .HasColumnType("datetime")
                .HasColumnName("DD040_CTB_ESTDTREG");
            entity.Property(e => e.Dd040CtbEstusuarioid)
                .HasMaxLength(36)
                .HasColumnName("DD040_CTB_ESTUSUARIOID");
            entity.Property(e => e.Dd040CtbIdlancto).HasColumnName("DD040_CTB_IDLANCTO");
            entity.Property(e => e.Dd040CtbIscontabilizadoid).HasColumnName("DD040_CTB_ISCONTABILIZADOID");
            entity.Property(e => e.Dd040CtbIsestornadoid).HasColumnName("DD040_CTB_ISESTORNADOID");
            entity.Property(e => e.Dd040CtbMsg)
                .HasMaxLength(100)
                .HasColumnName("DD040_CTB_MSG");
            entity.Property(e => e.Dd040CtbUsuarioid)
                .HasMaxLength(36)
                .HasColumnName("DD040_CTB_USUARIOID");
            entity.Property(e => e.Dd040CtrlSerieNfId)
                .HasMaxLength(36)
                .HasColumnName("DD040_CTRL_SERIE_NF_ID");
            entity.Property(e => e.Dd040DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DATA_EMISSAO");
            entity.Property(e => e.Dd040DataImpressao)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DATA_IMPRESSAO");
            entity.Property(e => e.Dd040DataMovimento)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DATA_MOVIMENTO");
            entity.Property(e => e.Dd040DataSaida)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DATA_SAIDA");
            entity.Property(e => e.Dd040Datahoraemissao)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DATAHORAEMISSAO");
            entity.Property(e => e.Dd040Desconto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_DESCONTO");
            entity.Property(e => e.Dd040DhCanc)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DH_CANC");
            entity.Property(e => e.Dd040Dhaut)
                .HasMaxLength(30)
                .HasColumnName("DD040_DHAUT");
            entity.Property(e => e.Dd040Dhcont)
                .HasMaxLength(30)
                .HasColumnName("DD040_DHCONT");
            entity.Property(e => e.Dd040Dhentrega)
                .HasColumnType("datetime")
                .HasColumnName("DD040_DHENTREGA");
            entity.Property(e => e.Dd040Digval)
                .HasMaxLength(28)
                .HasColumnName("DD040_DIGVAL");
            entity.Property(e => e.Dd040DispId).HasColumnName("DD040_DISP_ID");
            entity.Property(e => e.Dd040Empenho)
                .HasMaxLength(10)
                .HasColumnName("DD040_EMPENHO");
            entity.Property(e => e.Dd040Empresaid)
                .HasMaxLength(36)
                .HasColumnName("DD040_EMPRESAID");
            entity.Property(e => e.Dd040Especie)
                .HasMaxLength(60)
                .HasColumnName("DD040_ESPECIE");
            entity.Property(e => e.Dd040Filial).HasColumnName("DD040_FILIAL");
            entity.Property(e => e.Dd040Finnfe)
                .HasMaxLength(1)
                .HasColumnName("DD040_FINNFE");
            entity.Property(e => e.Dd040FreteCifFob).HasColumnName("DD040_FRETE_CIF_FOB");
            entity.Property(e => e.Dd040HoraImpressao)
                .HasColumnType("datetime")
                .HasColumnName("DD040_HORA_IMPRESSAO");
            entity.Property(e => e.Dd040HoraSaida)
                .HasColumnType("datetime")
                .HasColumnName("DD040_HORA_SAIDA");
            entity.Property(e => e.Dd040Indpres).HasColumnName("DD040_INDPRES");
            entity.Property(e => e.Dd040Isgrupada).HasColumnName("DD040_ISGRUPADA");
            entity.Property(e => e.Dd040Islibentregaliq).HasColumnName("DD040_ISLIBENTREGALIQ");
            entity.Property(e => e.Dd040Islocksat).HasColumnName("DD040_ISLOCKSAT");
            entity.Property(e => e.Dd040Isorigemdecupom).HasColumnName("DD040_ISORIGEMDECUPOM");
            entity.Property(e => e.Dd040IssubtraiIcmsDesone).HasColumnName("DD040_ISSUBTRAI_ICMS_DESONE");
            entity.Property(e => e.Dd040Isvendaonline).HasColumnName("DD040_ISVENDAONLINE");
            entity.Property(e => e.Dd040Keyecommerce)
                .HasMaxLength(36)
                .HasColumnName("DD040_KEYECOMMERCE");
            entity.Property(e => e.Dd040Marca)
                .HasMaxLength(60)
                .HasColumnName("DD040_MARCA");
            entity.Property(e => e.Dd040Marketplace)
                .HasMaxLength(60)
                .HasColumnName("DD040_MARKETPLACE");
            entity.Property(e => e.Dd040ModId).HasColumnName("DD040_MOD_ID");
            entity.Property(e => e.Dd040Modalidadefrete).HasColumnName("DD040_MODALIDADEFRETE");
            entity.Property(e => e.Dd040Modentregaid).HasColumnName("DD040_MODENTREGAID");
            entity.Property(e => e.Dd040Motdesoneracaoid).HasColumnName("DD040_MOTDESONERACAOID");
            entity.Property(e => e.Dd040Natop)
                .HasMaxLength(60)
                .HasColumnName("DD040_NATOP");
            entity.Property(e => e.Dd040NatoperacaoId)
                .HasMaxLength(36)
                .HasColumnName("DD040_NATOPERACAO_ID");
            entity.Property(e => e.Dd040NfEntregueSn)
                .HasMaxLength(1)
                .HasColumnName("DD040_NF_ENTREGUE_SN");
            entity.Property(e => e.Dd040NoCupom).HasColumnName("DD040_NO_CUPOM");
            entity.Property(e => e.Dd040NoEstacao).HasColumnName("DD040_NO_ESTACAO");
            entity.Property(e => e.Dd040NoNf).HasColumnName("DD040_NO_NF");
            entity.Property(e => e.Dd040NoPdv).HasColumnName("DD040_NO_PDV");
            entity.Property(e => e.Dd040NoPedido).HasColumnName("DD040_NO_PEDIDO");
            entity.Property(e => e.Dd040NoRequisicao)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD040_NO_REQUISICAO");
            entity.Property(e => e.Dd040NroContrato)
                .HasMaxLength(50)
                .HasColumnName("DD040_NRO_CONTRATO");
            entity.Property(e => e.Dd040NroRomaneio)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD040_NRO_ROMANEIO");
            entity.Property(e => e.Dd040NumImpressoes).HasColumnName("DD040_NUM_IMPRESSOES");
            entity.Property(e => e.Dd040NumeroPreco).HasColumnName("DD040_NUMERO_PRECO");
            entity.Property(e => e.Dd040Numeroautorizacao)
                .HasMaxLength(60)
                .HasColumnName("DD040_NUMEROAUTORIZACAO");
            entity.Property(e => e.Dd040Nvol)
                .HasMaxLength(60)
                .HasColumnName("DD040_NVOL");
            entity.Property(e => e.Dd040OrigemNota)
                .HasMaxLength(20)
                .HasColumnName("DD040_ORIGEM_NOTA");
            entity.Property(e => e.Dd040Origemregpv).HasColumnName("DD040_ORIGEMREGPV");
            entity.Property(e => e.Dd040Perc1Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERC1_DESCONTO");
            entity.Property(e => e.Dd040Perc2Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERC2_DESCONTO");
            entity.Property(e => e.Dd040Perc3Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERC3_DESCONTO");
            entity.Property(e => e.Dd040Perc4Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERC4_DESCONTO");
            entity.Property(e => e.Dd040Perc5Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERC5_DESCONTO");
            entity.Property(e => e.Dd040Percdescservico)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD040_PERCDESCSERVICO");
            entity.Property(e => e.Dd040PesoBruto)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("DD040_PESO_BRUTO");
            entity.Property(e => e.Dd040PesoLiquido)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("DD040_PESO_LIQUIDO");
            entity.Property(e => e.Dd040Picmsdesonerado)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("DD040_PICMSDESONERADO");
            entity.Property(e => e.Dd040PrazoEntrega)
                .HasMaxLength(50)
                .HasColumnName("DD040_PRAZO_ENTREGA");
            entity.Property(e => e.Dd040Processo)
                .HasMaxLength(15)
                .HasColumnName("DD040_PROCESSO");
            entity.Property(e => e.Dd040Protocolnumber)
                .HasMaxLength(20)
                .HasColumnName("DD040_PROTOCOLNUMBER");
            entity.Property(e => e.Dd040QtdVolumes).HasColumnName("DD040_QTD_VOLUMES");
            entity.Property(e => e.Dd040QtdeParcelas).HasColumnName("DD040_QTDE_PARCELAS");
            entity.Property(e => e.Dd040ResponsavelId)
                .HasMaxLength(36)
                .HasColumnName("DD040_RESPONSAVEL_ID");
            entity.Property(e => e.Dd040Romaneioid).HasColumnName("DD040_ROMANEIOID");
            entity.Property(e => e.Dd040SatChaveCanc)
                .HasMaxLength(50)
                .HasColumnName("DD040_SAT_CHAVE_CANC");
            entity.Property(e => e.Dd040SatNoCfeCanc).HasColumnName("DD040_SAT_NO_CFE_CANC");
            entity.Property(e => e.Dd040SatQrcodeCanc)
                .HasMaxLength(600)
                .HasColumnName("DD040_SAT_QRCODE_CANC");
            entity.Property(e => e.Dd040SatSerieCanc)
                .HasMaxLength(9)
                .HasColumnName("DD040_SAT_SERIE_CANC");
            entity.Property(e => e.Dd040Serie)
                .HasMaxLength(9)
                .HasColumnName("DD040_SERIE");
            entity.Property(e => e.Dd040SerieCupom)
                .HasMaxLength(5)
                .HasColumnName("DD040_SERIE_CUPOM");
            entity.Property(e => e.Dd040ServCregtrib).HasColumnName("DD040_SERV_CREGTRIB");
            entity.Property(e => e.Dd040ServDcompet).HasColumnName("DD040_SERV_DCOMPET");
            entity.Property(e => e.Dd040ServVbc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VBC");
            entity.Property(e => e.Dd040ServVcofins)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VCOFINS");
            entity.Property(e => e.Dd040ServVdesccond)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VDESCCOND");
            entity.Property(e => e.Dd040ServVdescincond)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VDESCINCOND");
            entity.Property(e => e.Dd040ServViss)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VISS");
            entity.Property(e => e.Dd040ServVissret)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VISSRET");
            entity.Property(e => e.Dd040ServVoutro)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VOUTRO");
            entity.Property(e => e.Dd040ServVpis)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_SERV_VPIS");
            entity.Property(e => e.Dd040SitNfeId).HasColumnName("DD040_SIT_NFE_ID");
            entity.Property(e => e.Dd040Situacao).HasColumnName("DD040_SITUACAO");
            entity.Property(e => e.Dd040StEntregaId).HasColumnName("DD040_ST_ENTREGA_ID");
            entity.Property(e => e.Dd040Status).HasColumnName("DD040_STATUS");
            entity.Property(e => e.Dd040StatusEstoqueId).HasColumnName("DD040_STATUS_ESTOQUE_ID");
            entity.Property(e => e.Dd040Texto)
                .HasMaxLength(500)
                .HasColumnName("DD040_TEXTO");
            entity.Property(e => e.Dd040TipoMovimento).HasColumnName("DD040_TIPO_MOVIMENTO");
            entity.Property(e => e.Dd040TiponotaId).HasColumnName("DD040_TIPONOTA_ID");
            entity.Property(e => e.Dd040TotValorAproxImp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOT_VALOR_APROX_IMP");
            entity.Property(e => e.Dd040TotalBruto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_BRUTO");
            entity.Property(e => e.Dd040TotalDescsuframa)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_DESCSUFRAMA");
            entity.Property(e => e.Dd040TotalFrete)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_FRETE");
            entity.Property(e => e.Dd040TotalLiquido)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_LIQUIDO");
            entity.Property(e => e.Dd040TotalOutdespesas)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_OUTDESPESAS");
            entity.Property(e => e.Dd040TotalSeguro)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_SEGURO");
            entity.Property(e => e.Dd040TotalServico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTAL_SERVICO");
            entity.Property(e => e.Dd040TotalprodEServ)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTALPROD_E_SERV");
            entity.Property(e => e.Dd040Totliqservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_TOTLIQSERVICO");
            entity.Property(e => e.Dd040Tpamb).HasColumnName("DD040_TPAMB");
            entity.Property(e => e.Dd040Tpdebcreid).HasColumnName("DD040_TPDEBCREID");
            entity.Property(e => e.Dd040Tpemis).HasColumnName("DD040_TPEMIS");
            entity.Property(e => e.Dd040Transcomtef).HasColumnName("DD040_TRANSCOMTEF");
            entity.Property(e => e.Dd040Tzd)
                .HasMaxLength(20)
                .HasColumnName("DD040_TZD");
            entity.Property(e => e.Dd040Urlqrcode)
                .HasMaxLength(600)
                .HasColumnName("DD040_URLQRCODE");
            entity.Property(e => e.Dd040UsuarioAtendenteid)
                .HasMaxLength(36)
                .HasColumnName("DD040_USUARIO_ATENDENTEID");
            entity.Property(e => e.Dd040UsuarioEntregaid)
                .HasMaxLength(36)
                .HasColumnName("DD040_USUARIO_ENTREGAID");
            entity.Property(e => e.Dd040UsuarioImp)
                .HasMaxLength(50)
                .HasColumnName("DD040_USUARIO_IMP");
            entity.Property(e => e.Dd040UsuarioProprId)
                .HasMaxLength(36)
                .HasColumnName("DD040_USUARIO_PROPR_ID");
            entity.Property(e => e.Dd040Usuariofaturistaid)
                .HasMaxLength(36)
                .HasColumnName("DD040_USUARIOFATURISTAID");
            entity.Property(e => e.Dd040Valor1)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_1");
            entity.Property(e => e.Dd040Valor2)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_2");
            entity.Property(e => e.Dd040Valor3)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_3");
            entity.Property(e => e.Dd040Valor4)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_4");
            entity.Property(e => e.Dd040Valor5)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_5");
            entity.Property(e => e.Dd040ValorEntrada)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VALOR_ENTRADA");
            entity.Property(e => e.Dd040Vbc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VBC");
            entity.Property(e => e.Dd040Vbcst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VBCST");
            entity.Property(e => e.Dd040Vcofins)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VCOFINS");
            entity.Property(e => e.Dd040Vfcp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VFCP");
            entity.Property(e => e.Dd040Vfcpst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VFCPST");
            entity.Property(e => e.Dd040Vfcpstret)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VFCPSTRET");
            entity.Property(e => e.Dd040Vfcpufdest)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VFCPUFDEST");
            entity.Property(e => e.Dd040Vicms)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VICMS");
            entity.Property(e => e.Dd040Vicmsdeson)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VICMSDESON");
            entity.Property(e => e.Dd040VicmsdesonsubId).HasColumnName("DD040_VICMSDESONSUB_ID");
            entity.Property(e => e.Dd040Vicmsufdest)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VICMSUFDEST");
            entity.Property(e => e.Dd040Vicmsufremet)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VICMSUFREMET");
            entity.Property(e => e.Dd040Vii)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VII");
            entity.Property(e => e.Dd040Vipi)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VIPI");
            entity.Property(e => e.Dd040Vipidevol)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VIPIDEVOL");
            entity.Property(e => e.Dd040Vlrafinanciar)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VLRAFINANCIAR");
            entity.Property(e => e.Dd040Vlrdescservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VLRDESCSERVICO");
            entity.Property(e => e.Dd040Vpis)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VPIS");
            entity.Property(e => e.Dd040Vst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD040_VST");
            entity.Property(e => e.Dd040Xjust)
                .HasMaxLength(256)
                .HasColumnName("DD040_XJUST");
            entity.Property(e => e.Dd042Chaveacessonfe)
                .HasMaxLength(50)
                .HasColumnName("DD042_CHAVEACESSONFE");
            entity.Property(e => e.NfeEpecNprot)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NFE_EPEC_NPROT");
            entity.Property(e => e.NfeNprot)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NFE_NPROT");
            entity.Property(e => e.NfeNrec)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NFE_NREC");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.W06b1Qbcmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06B_1_QBCMONO");
            entity.Property(e => e.W06c1Qbcmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_1_QBCMONORETEN");
            entity.Property(e => e.W06cVicmsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_VICMSMONO");
            entity.Property(e => e.W06d1Qbcmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_1_QBCMONORET");
            entity.Property(e => e.W06dVicmsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_VICMSMONORETEN");
            entity.Property(e => e.W06eVicmsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06E_VICMSMONORET");
            entity.Property(e => e.W33Vbcis)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("W33_VBCIS");
            entity.Property(e => e.W33Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W33_VIS");
            entity.Property(e => e.W34Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W34_VIS");
            entity.Property(e => e.W35Vbcibscbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W35_VBCIBSCBS");
            entity.Property(e => e.W38IbsufVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W38_IBSUF_VDIF");
            entity.Property(e => e.W39IbsufVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W39_IBSUF_VDEVTRIB");
            entity.Property(e => e.W41Vibsuf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W41_VIBSUF");
            entity.Property(e => e.W43IbsmunVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W43_IBSMUN_VDIF");
            entity.Property(e => e.W44IbsmunVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W44_IBSMUN__VDEVTRIB");
            entity.Property(e => e.W46Vibsmun)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W46_VIBSMUN");
            entity.Property(e => e.W47IbsmunVibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_IBSMUN_VIBSTOT");
            entity.Property(e => e.W47Vibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_VIBSTOT");
            entity.Property(e => e.W48IbsmunVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_IBSMUN_VCREDPRES");
            entity.Property(e => e.W48Vcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_VCREDPRES");
            entity.Property(e => e.W49IbsmunVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_IBSMUN_VCREDPRESCONDSUS");
            entity.Property(e => e.W49Vcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_VCREDPRESCONDSUS");
            entity.Property(e => e.W51CbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W51_CBS_VCREDPRES");
            entity.Property(e => e.W52CbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W52_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W53CbsVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W53_CBS_VDIF");
            entity.Property(e => e.W54CbsVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W54_CBS_VDEVTRIB");
            entity.Property(e => e.W56Vcbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56_VCBS");
            entity.Property(e => e.W56aCbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56A_CBS_VCREDPRES");
            entity.Property(e => e.W56bCbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56B_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W58Vtotibsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W58_VTOTIBSMONO");
            entity.Property(e => e.W59Vtotcbsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59_VTOTCBSMONO");
            entity.Property(e => e.W59bVcbsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59B_VCBSMONORETEN");
            entity.Property(e => e.W59cVibsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59C_VIBSMONORETEN");
            entity.Property(e => e.W59dVcbsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59D_VCBSMONORET");
            entity.Property(e => e.W60Vtotnf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W60_VTOTNF");

            entity.HasOne(d => d.Dd040Avalista).WithMany(p => p.OsusrTeiCsicpDd040Dd040Avalista)
                .HasForeignKey(d => d.Dd040AvalistaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD040_OSUSR_E9A_CSICP_BB012_DD040_AVALISTA_ID");

            entity.HasOne(d => d.Dd040CompConta).WithMany(p => p.OsusrTeiCsicpDd040Dd040CompConta)
                .HasForeignKey(d => d.Dd040CompContaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD040_OSUSR_E9A_CSICP_BB012_DD040_COMP_CONTA_ID");

            entity.HasOne(d => d.Dd040Conta).WithMany(p => p.OsusrTeiCsicpDd040Dd040Conta)
                .HasForeignKey(d => d.Dd040ContaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD040_OSUSR_E9A_CSICP_BB012_DD040_CONTA_ID");

            entity.HasOne(d => d.Dd040Contareal).WithMany(p => p.OsusrTeiCsicpDd040Dd040Contareals)
                .HasForeignKey(d => d.Dd040ContarealId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD040_OSUSR_E9A_CSICP_BB012_DD040_CONTAREAL_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpDd061Cfgimp>(entity =>
        {
            entity.HasKey(e => e.Dd060Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD061_CFGIMP");

            entity.ToTable("OSUSR_TEI_CSICP_DD061_CFGIMP");

            entity.HasIndex(e => new { e.Dd061RflcId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_13DD061_RFLC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub7479Ccredpresid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_19UB74_79_CCREDPRESID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd061Bb027bIndpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_20DD061_BB027B_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd061NatBcCredPis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_21DD061_NAT_BC_CRED_PIS_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd061Bb027bCfgimpId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_22DD061_BB027B_CFGIMP_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub03IsRfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_22UB03_IS_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub13ub14RfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_23UB13UB14_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd061NatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_24DD061_NAT_BC_CRED_COFINS_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub6970RfclasstribregId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_25UB69_70_RFCLASSTRIBREG_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd061Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_27DD061_BB027B_CENQUAD_IPI_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_8DD060_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_9TENANT_ID");

            entity.Property(e => e.Dd060Id)
                .HasMaxLength(36)
                .HasColumnName("DD060_ID");
            entity.Property(e => e.Dd061Bb027CfopId).HasColumnName("DD061_BB027_CFOP_ID");
            entity.Property(e => e.Dd061Bb027Id)
                .HasMaxLength(36)
                .HasColumnName("DD061_BB027_ID");
            entity.Property(e => e.Dd061Bb027bAliqInternauf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("DD061_BB027B_ALIQ_INTERNAUF");
            entity.Property(e => e.Dd061Bb027bAliquota)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("DD061_BB027B_ALIQUOTA");
            entity.Property(e => e.Dd061Bb027bCenquadIpiId).HasColumnName("DD061_BB027B_CENQUAD_IPI_ID");
            entity.Property(e => e.Dd061Bb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("DD061_BB027B_CFGIMP_ID");
            entity.Property(e => e.Dd061Bb027bCfopExcecaoId).HasColumnName("DD061_BB027B_CFOP_EXCECAO_ID");
            entity.Property(e => e.Dd061Bb027bCfopStaticaId).HasColumnName("DD061_BB027B_CFOP_STATICA_ID");
            entity.Property(e => e.Dd061Bb027bClassecontaId).HasColumnName("DD061_BB027B_CLASSECONTA_ID");
            entity.Property(e => e.Dd061Bb027bCodgcst)
                .HasMaxLength(5)
                .HasColumnName("DD061_BB027B_CODGCST");
            entity.Property(e => e.Dd061Bb027bCstCofinsId).HasColumnName("DD061_BB027B_CST_COFINS_ID");
            entity.Property(e => e.Dd061Bb027bCstIcmsId).HasColumnName("DD061_BB027B_CST_ICMS_ID");
            entity.Property(e => e.Dd061Bb027bCstIpiId).HasColumnName("DD061_BB027B_CST_IPI_ID");
            entity.Property(e => e.Dd061Bb027bCstPisId).HasColumnName("DD061_BB027B_CST_PIS_ID");
            entity.Property(e => e.Dd061Bb027bIndpres).HasColumnName("DD061_BB027B_INDPRES");
            entity.Property(e => e.Dd061Bb027bInforcofins)
                .HasMaxLength(200)
                .HasColumnName("DD061_BB027B_INFORCOFINS");
            entity.Property(e => e.Dd061Bb027bInforipi)
                .HasMaxLength(200)
                .HasColumnName("DD061_BB027B_INFORIPI");
            entity.Property(e => e.Dd061Bb027bInfornf)
                .HasMaxLength(200)
                .HasColumnName("DD061_BB027B_INFORNF");
            entity.Property(e => e.Dd061Bb027bInforpis)
                .HasMaxLength(200)
                .HasColumnName("DD061_BB027B_INFORPIS");
            entity.Property(e => e.Dd061Bb027bModalbcIcmsSt).HasColumnName("DD061_BB027B_MODALBC_ICMS_ST");
            entity.Property(e => e.Dd061Bb027bModbcId).HasColumnName("DD061_BB027B_MODBC_ID");
            entity.Property(e => e.Dd061Bb027bMotdesoneracao).HasColumnName("DD061_BB027B_MOTDESONERACAO");
            entity.Property(e => e.Dd061Bb027bMp255Id).HasColumnName("DD061_BB027B_MP255_ID");
            entity.Property(e => e.Dd061Bb027bOrigemId).HasColumnName("DD061_BB027B_ORIGEM_ID");
            entity.Property(e => e.Dd061Bb027bReducaobase)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("DD061_BB027B_REDUCAOBASE");
            entity.Property(e => e.Dd061Bb027bReducaobcst)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("DD061_BB027B_REDUCAOBCST");
            entity.Property(e => e.Dd061Bb027bRegimeId).HasColumnName("DD061_BB027B_REGIME_ID");
            entity.Property(e => e.Dd061Bb027bUfDestId)
                .HasMaxLength(36)
                .HasColumnName("DD061_BB027B_UF_DEST_ID");
            entity.Property(e => e.Dd061Cbenef)
                .HasMaxLength(20)
                .HasColumnName("DD061_CBENEF");
            entity.Property(e => e.Dd061LcId)
                .HasMaxLength(36)
                .HasColumnName("DD061_LC_ID");
            entity.Property(e => e.Dd061LcIdexclui)
                .HasMaxLength(50)
                .HasColumnName("DD061_LC_IDEXCLUI");
            entity.Property(e => e.Dd061NatBcCredCofins).HasColumnName("DD061_NAT_BC_CRED_COFINS");
            entity.Property(e => e.Dd061NatBcCredPis).HasColumnName("DD061_NAT_BC_CRED_PIS");
            entity.Property(e => e.Dd061RfBb027Id)
                .HasMaxLength(36)
                .HasColumnName("DD061_RF_BB027_ID");
            entity.Property(e => e.Dd061RfBb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("DD061_RF_BB027B_CFGIMP_ID");
            entity.Property(e => e.Dd061RflcId)
                .HasMaxLength(36)
                .HasColumnName("DD061_RFLC_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Ub03IsClasstribId).HasColumnName("UB03_IS_CLASSTRIB_ID");
            entity.Property(e => e.Ub03IsClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("UB03_IS_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Ub03IsRfclasstribId).HasColumnName("UB03_IS_RFCLASSTRIB_ID");
            entity.Property(e => e.Ub13ub14ClasstribId).HasColumnName("UB13UB14_CLASSTRIB_ID");
            entity.Property(e => e.Ub13ub14ClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("UB13UB14_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Ub13ub14RfclasstribId).HasColumnName("UB13UB14_RFCLASSTRIB_ID");
            entity.Property(e => e.Ub17Ufid)
                .HasMaxLength(36)
                .HasColumnName("UB17_UFID");
            entity.Property(e => e.Ub30ub31ClasstribIdReg).HasColumnName("UB30UB31_CLASSTRIB_ID_REG");
            entity.Property(e => e.Ub36Municipioid)
                .HasMaxLength(36)
                .HasColumnName("UB36_MUNICIPIOID");
            entity.Property(e => e.Ub5665Ccredpres)
                .HasMaxLength(2)
                .HasColumnName("UB56_65_CCREDPRES");
            entity.Property(e => e.Ub6970ClasstribId).HasColumnName("UB69_70_CLASSTRIB_ID");
            entity.Property(e => e.Ub6970ClasstribregId).HasColumnName("UB69_70_CLASSTRIBREG_ID");
            entity.Property(e => e.Ub6970ClasstribregIdexclu)
                .HasMaxLength(50)
                .HasColumnName("UB69_70_CLASSTRIBREG_IDEXCLU");
            entity.Property(e => e.Ub6970RfclasstribregId).HasColumnName("UB69_70_RFCLASSTRIBREG_ID");
            entity.Property(e => e.Ub7479Ccredpresid).HasColumnName("UB74_79_CCREDPRESID");
            entity.Property(e => e.Ub74Ccredpres)
                .HasMaxLength(2)
                .HasColumnName("UB74_CCREDPRES");

            entity.HasOne(d => d.Dd061Bb027bCfgimp).WithMany(p => p.OsusrTeiCsicpDd061Cfgimps)
                .HasForeignKey(d => d.Dd061Bb027bCfgimpId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD061_CFGIMP_OSUSR_E9A_CSICP_BB027_IMP_DD061_BB027B_CFGIMP_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpDd070>(entity =>
        {
            entity.HasKey(e => e.Dd070Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070");

            entity.ToTable("OSUSR_TEI_CSICP_DD070", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD070"));

            entity.HasIndex(e => new { e.Dd070CfnfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_13DD070_CFNF_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Indpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_13DD070_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_14DD070_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Situacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_14DD070_SITUACAO_9TENANT_ID");

            entity.HasIndex(e => new { e.B34Tpopergovid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15B34_TPOPERGOVID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd040TpnotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD040_TPNOTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_CCUSTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Empresaid, e.Dd070DataEmissao, e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_18DD070_DATA_EMISSAO_20DD070_PROTOCOLNUMBER_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Empresaid, e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_20DD070_PROTOCOLNUMBER_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Romaneioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_16DD070_ROMANEIOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Tpdebcreid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_16DD070_TPDEBCREID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Arquitetoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_17DD070_ARQUITETOID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070AvalistaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_17DD070_AVALISTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070ContarealId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_CONTAREAL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070DataEmissao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_DATA_EMISSAO_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Keyecommerce, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_KEYECOMMERCE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_AGCOBRADOR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Chavecashback, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_CHAVECASHBACK_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070CompContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_COMP_CONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070CondPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_COND_PAGTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Statusestoque, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_STATUSESTOQUE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070ClassecontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_CLASSECONTA_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_NATOPERACAO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_PROTOCOLNUMBER_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_RESPONSAVEL_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070AlmoxdestinoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_21DD070_ALMOXDESTINO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_21DD070_MODALIDADEFRETE_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070UsuarioProprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_22DD070_USUARIO_PROPR_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_22DD070_VICMSDESONSUB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070TipoatendimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_24DD070_TIPOATENDIMENTO_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd070UsuarioAtendenteid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_25DD070_USUARIO_ATENDENTEID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD070_9TENANT_ID");

            entity.Property(e => e.Dd070Id)
                .HasMaxLength(36)
                .HasColumnName("DD070_ID");
            entity.Property(e => e.B33Predutor)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("B33_PREDUTOR");
            entity.Property(e => e.B34Tpopergovid).HasColumnName("B34_TPOPERGOVID");
            entity.Property(e => e.Dd0070IsPvResultante).HasColumnName("DD0070_IS_PV_RESULTANTE");
            entity.Property(e => e.Dd040TpnotaId).HasColumnName("DD040_TPNOTA_ID");
            entity.Property(e => e.Dd070Acrescimo)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_ACRESCIMO");
            entity.Property(e => e.Dd070AgcobradorId)
                .HasMaxLength(36)
                .HasColumnName("DD070_AGCOBRADOR_ID");
            entity.Property(e => e.Dd070AlmoxdestinoId)
                .HasMaxLength(36)
                .HasColumnName("DD070_ALMOXDESTINO_ID");
            entity.Property(e => e.Dd070Arquitetoid)
                .HasMaxLength(36)
                .HasColumnName("DD070_ARQUITETOID");
            entity.Property(e => e.Dd070Arredondamento)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_ARREDONDAMENTO");
            entity.Property(e => e.Dd070AvalistaId)
                .HasMaxLength(36)
                .HasColumnName("DD070_AVALISTA_ID");
            entity.Property(e => e.Dd070CcustoId)
                .HasMaxLength(36)
                .HasColumnName("DD070_CCUSTO_ID");
            entity.Property(e => e.Dd070CfnfId).HasColumnName("DD070_CFNF_ID");
            entity.Property(e => e.Dd070Chavecashback)
                .HasMaxLength(10)
                .HasColumnName("DD070_CHAVECASHBACK");
            entity.Property(e => e.Dd070CiOrcamento)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD070_CI_ORCAMENTO");
            entity.Property(e => e.Dd070ClassecontaId).HasColumnName("DD070_CLASSECONTA_ID");
            entity.Property(e => e.Dd070CnpjMarketplace)
                .HasMaxLength(14)
                .HasColumnName("DD070_CNPJ_MARKETPLACE");
            entity.Property(e => e.Dd070Codalmoxdestino).HasColumnName("DD070_CODALMOXDESTINO");
            entity.Property(e => e.Dd070CodgAgcobrador).HasColumnName("DD070_CODG_AGCOBRADOR");
            entity.Property(e => e.Dd070CodgAtendente).HasColumnName("DD070_CODG_ATENDENTE");
            entity.Property(e => e.Dd070CodgCcusto).HasColumnName("DD070_CODG_CCUSTO");
            entity.Property(e => e.Dd070CodgCondPagto).HasColumnName("DD070_CODG_COND_PAGTO");
            entity.Property(e => e.Dd070Codnatoperacao)
                .HasMaxLength(10)
                .HasColumnName("DD070_CODNATOPERACAO");
            entity.Property(e => e.Dd070Codrespcomprador).HasColumnName("DD070_CODRESPCOMPRADOR");
            entity.Property(e => e.Dd070Codrespvendedor).HasColumnName("DD070_CODRESPVENDEDOR");
            entity.Property(e => e.Dd070Codtabelapreco)
                .HasMaxLength(7)
                .HasColumnName("DD070_CODTABELAPRECO");
            entity.Property(e => e.Dd070Comissao).HasColumnName("DD070_COMISSAO");
            entity.Property(e => e.Dd070CompContaId)
                .HasMaxLength(36)
                .HasColumnName("DD070_COMP_CONTA_ID");
            entity.Property(e => e.Dd070CondPagtoId)
                .HasMaxLength(36)
                .HasColumnName("DD070_COND_PAGTO_ID");
            entity.Property(e => e.Dd070ContaId)
                .HasMaxLength(36)
                .HasColumnName("DD070_CONTA_ID");
            entity.Property(e => e.Dd070ContarealId)
                .HasMaxLength(36)
                .HasColumnName("DD070_CONTAREAL_ID");
            entity.Property(e => e.Dd070CtrlSerieNfId)
                .HasMaxLength(36)
                .HasColumnName("DD070_CTRL_SERIE_NF_ID");
            entity.Property(e => e.Dd070DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATA_EMISSAO");
            entity.Property(e => e.Dd070DataImpressao)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATA_IMPRESSAO");
            entity.Property(e => e.Dd070DataMovimento)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATA_MOVIMENTO");
            entity.Property(e => e.Dd070DataSaida)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATA_SAIDA");
            entity.Property(e => e.Dd070Datahoraemissao)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATAHORAEMISSAO");
            entity.Property(e => e.Dd070Datavalidade)
                .HasColumnType("datetime")
                .HasColumnName("DD070_DATAVALIDADE");
            entity.Property(e => e.Dd070Desconto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_DESCONTO");
            entity.Property(e => e.Dd070Empenho)
                .HasMaxLength(10)
                .HasColumnName("DD070_EMPENHO");
            entity.Property(e => e.Dd070Empresaid)
                .HasMaxLength(36)
                .HasColumnName("DD070_EMPRESAID");
            entity.Property(e => e.Dd070Especie)
                .HasMaxLength(60)
                .HasColumnName("DD070_ESPECIE");
            entity.Property(e => e.Dd070Filial).HasColumnName("DD070_FILIAL");
            entity.Property(e => e.Dd070Finnfe)
                .HasMaxLength(1)
                .HasColumnName("DD070_FINNFE");
            entity.Property(e => e.Dd070FlagRegra).HasColumnName("DD070_FLAG_REGRA");
            entity.Property(e => e.Dd070FreteCifFob).HasColumnName("DD070_FRETE_CIF_FOB");
            entity.Property(e => e.Dd070HoraImpressao)
                .HasColumnType("datetime")
                .HasColumnName("DD070_HORA_IMPRESSAO");
            entity.Property(e => e.Dd070HoraSaida)
                .HasColumnType("datetime")
                .HasColumnName("DD070_HORA_SAIDA");
            entity.Property(e => e.Dd070Indpres).HasColumnName("DD070_INDPRES");
            entity.Property(e => e.Dd070Isaprovacao).HasColumnName("DD070_ISAPROVACAO");
            entity.Property(e => e.Dd070Isdiverg).HasColumnName("DD070_ISDIVERG");
            entity.Property(e => e.Dd070Ismarcado).HasColumnName("DD070_ISMARCADO");
            entity.Property(e => e.Dd070Isorigemcotacao).HasColumnName("DD070_ISORIGEMCOTACAO");
            entity.Property(e => e.Dd070Isromdiverg).HasColumnName("DD070_ISROMDIVERG");
            entity.Property(e => e.Dd070IssubtraiIcmsDesone).HasColumnName("DD070_ISSUBTRAI_ICMS_DESONE");
            entity.Property(e => e.Dd070Isvendacasada).HasColumnName("DD070_ISVENDACASADA");
            entity.Property(e => e.Dd070Keyecommerce)
                .HasMaxLength(36)
                .HasColumnName("DD070_KEYECOMMERCE");
            entity.Property(e => e.Dd070Marca)
                .HasMaxLength(60)
                .HasColumnName("DD070_MARCA");
            entity.Property(e => e.Dd070Marketplace)
                .HasMaxLength(60)
                .HasColumnName("DD070_MARKETPLACE");
            entity.Property(e => e.Dd070Modalidadefrete).HasColumnName("DD070_MODALIDADEFRETE");
            entity.Property(e => e.Dd070Motdesoneracaoid).HasColumnName("DD070_MOTDESONERACAOID");
            entity.Property(e => e.Dd070Natop)
                .HasMaxLength(60)
                .HasColumnName("DD070_NATOP");
            entity.Property(e => e.Dd070NatoperacaoId)
                .HasMaxLength(36)
                .HasColumnName("DD070_NATOPERACAO_ID");
            entity.Property(e => e.Dd070NoCupom).HasColumnName("DD070_NO_CUPOM");
            entity.Property(e => e.Dd070NoEstacao).HasColumnName("DD070_NO_ESTACAO");
            entity.Property(e => e.Dd070NoNf).HasColumnName("DD070_NO_NF");
            entity.Property(e => e.Dd070NoPdv).HasColumnName("DD070_NO_PDV");
            entity.Property(e => e.Dd070NoPedido).HasColumnName("DD070_NO_PEDIDO");
            entity.Property(e => e.Dd070NoRequisicao)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD070_NO_REQUISICAO");
            entity.Property(e => e.Dd070NroContrato)
                .HasMaxLength(50)
                .HasColumnName("DD070_NRO_CONTRATO");
            entity.Property(e => e.Dd070NroPvDav)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD070_NRO_PV_DAV");
            entity.Property(e => e.Dd070NroRomaneio)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("DD070_NRO_ROMANEIO");
            entity.Property(e => e.Dd070NumImpressoes).HasColumnName("DD070_NUM_IMPRESSOES");
            entity.Property(e => e.Dd070NumeroPreco).HasColumnName("DD070_NUMERO_PRECO");
            entity.Property(e => e.Dd070Nvol)
                .HasMaxLength(60)
                .HasColumnName("DD070_NVOL");
            entity.Property(e => e.Dd070Origemregpv).HasColumnName("DD070_ORIGEMREGPV");
            entity.Property(e => e.Dd070Perc1Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERC1_DESCONTO");
            entity.Property(e => e.Dd070Perc2Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERC2_DESCONTO");
            entity.Property(e => e.Dd070Perc3Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERC3_DESCONTO");
            entity.Property(e => e.Dd070Perc4Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERC4_DESCONTO");
            entity.Property(e => e.Dd070Perc5Desconto)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERC5_DESCONTO");
            entity.Property(e => e.Dd070Percdescservico)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("DD070_PERCDESCSERVICO");
            entity.Property(e => e.Dd070PesoBruto)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("DD070_PESO_BRUTO");
            entity.Property(e => e.Dd070PesoLiquido)
                .HasColumnType("decimal(15, 5)")
                .HasColumnName("DD070_PESO_LIQUIDO");
            entity.Property(e => e.Dd070Picmsdesonerado)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("DD070_PICMSDESONERADO");
            entity.Property(e => e.Dd070PrazoEntrega)
                .HasMaxLength(50)
                .HasColumnName("DD070_PRAZO_ENTREGA");
            entity.Property(e => e.Dd070Processo)
                .HasMaxLength(15)
                .HasColumnName("DD070_PROCESSO");
            entity.Property(e => e.Dd070Protocolnumber)
                .HasMaxLength(20)
                .HasColumnName("DD070_PROTOCOLNUMBER");
            entity.Property(e => e.Dd070PvGrupadaId)
                .HasMaxLength(36)
                .HasColumnName("DD070_PV_GRUPADA_ID");
            entity.Property(e => e.Dd070QtdVolumes).HasColumnName("DD070_QTD_VOLUMES");
            entity.Property(e => e.Dd070QtdeParcelas).HasColumnName("DD070_QTDE_PARCELAS");
            entity.Property(e => e.Dd070ResponsavelId)
                .HasMaxLength(36)
                .HasColumnName("DD070_RESPONSAVEL_ID");
            entity.Property(e => e.Dd070Romaneioid).HasColumnName("DD070_ROMANEIOID");
            entity.Property(e => e.Dd070Serie)
                .HasMaxLength(9)
                .HasColumnName("DD070_SERIE");
            entity.Property(e => e.Dd070SerieCupom)
                .HasMaxLength(5)
                .HasColumnName("DD070_SERIE_CUPOM");
            entity.Property(e => e.Dd070ServCregtrib).HasColumnName("DD070_SERV_CREGTRIB");
            entity.Property(e => e.Dd070ServDcompet).HasColumnName("DD070_SERV_DCOMPET");
            entity.Property(e => e.Dd070ServVbc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VBC");
            entity.Property(e => e.Dd070ServVcofins)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VCOFINS");
            entity.Property(e => e.Dd070ServVdesccond)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VDESCCOND");
            entity.Property(e => e.Dd070ServVdescincond)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VDESCINCOND");
            entity.Property(e => e.Dd070ServViss)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VISS");
            entity.Property(e => e.Dd070ServVissret)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VISSRET");
            entity.Property(e => e.Dd070ServVoutro)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VOUTRO");
            entity.Property(e => e.Dd070ServVpis)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_SERV_VPIS");
            entity.Property(e => e.Dd070Situacao).HasColumnName("DD070_SITUACAO");
            entity.Property(e => e.Dd070Statusestoque).HasColumnName("DD070_STATUSESTOQUE");
            entity.Property(e => e.Dd070Texto)
                .HasMaxLength(500)
                .HasColumnName("DD070_TEXTO");
            entity.Property(e => e.Dd070TipoMovimento).HasColumnName("DD070_TIPO_MOVIMENTO");
            entity.Property(e => e.Dd070TipoatendimentoId).HasColumnName("DD070_TIPOATENDIMENTO_ID");
            entity.Property(e => e.Dd070TotValorAproxImp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOT_VALOR_APROX_IMP");
            entity.Property(e => e.Dd070TotalBruto)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_BRUTO");
            entity.Property(e => e.Dd070TotalDescsuframa)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_DESCSUFRAMA");
            entity.Property(e => e.Dd070TotalFrete)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_FRETE");
            entity.Property(e => e.Dd070TotalLiquido)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_LIQUIDO");
            entity.Property(e => e.Dd070TotalOutdespesas)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_OUTDESPESAS");
            entity.Property(e => e.Dd070TotalSeguro)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_SEGURO");
            entity.Property(e => e.Dd070TotalServico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTAL_SERVICO");
            entity.Property(e => e.Dd070TotalprodEServ)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTALPROD_E_SERV");
            entity.Property(e => e.Dd070Totliqservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_TOTLIQSERVICO");
            entity.Property(e => e.Dd070Tpdebcreid).HasColumnName("DD070_TPDEBCREID");
            entity.Property(e => e.Dd070Transcomtef).HasColumnName("DD070_TRANSCOMTEF");
            entity.Property(e => e.Dd070UsuarioAtendenteid)
                .HasMaxLength(36)
                .HasColumnName("DD070_USUARIO_ATENDENTEID");
            entity.Property(e => e.Dd070UsuarioImp)
                .HasMaxLength(50)
                .HasColumnName("DD070_USUARIO_IMP");
            entity.Property(e => e.Dd070UsuarioProprId)
                .HasMaxLength(36)
                .HasColumnName("DD070_USUARIO_PROPR_ID");
            entity.Property(e => e.Dd070ValorEntrada)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VALOR_ENTRADA");
            entity.Property(e => e.Dd070Vbc)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VBC");
            entity.Property(e => e.Dd070Vbcst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VBCST");
            entity.Property(e => e.Dd070Vcofins)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VCOFINS");
            entity.Property(e => e.Dd070Vfcp)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VFCP");
            entity.Property(e => e.Dd070Vfcpst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VFCPST");
            entity.Property(e => e.Dd070Vfcpstret)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VFCPSTRET");
            entity.Property(e => e.Dd070Vfcpufdest)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VFCPUFDEST");
            entity.Property(e => e.Dd070Vicms)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VICMS");
            entity.Property(e => e.Dd070Vicmsdeson)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VICMSDESON");
            entity.Property(e => e.Dd070VicmsdesonsubId).HasColumnName("DD070_VICMSDESONSUB_ID");
            entity.Property(e => e.Dd070Vicmsufdest)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VICMSUFDEST");
            entity.Property(e => e.Dd070Vicmsufremet)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VICMSUFREMET");
            entity.Property(e => e.Dd070Vii)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VII");
            entity.Property(e => e.Dd070Vipi)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VIPI");
            entity.Property(e => e.Dd070Vipidevol)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VIPIDEVOL");
            entity.Property(e => e.Dd070Vlrafinanciar)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VLRAFINANCIAR");
            entity.Property(e => e.Dd070Vlrdescservico)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VLRDESCSERVICO");
            entity.Property(e => e.Dd070Vpis)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VPIS");
            entity.Property(e => e.Dd070Vst)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("DD070_VST");
            entity.Property(e => e.Processid).HasColumnName("PROCESSID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.W06b1Qbcmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06B_1_QBCMONO");
            entity.Property(e => e.W06c1Qbcmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_1_QBCMONORETEN");
            entity.Property(e => e.W06cVicmsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06C_VICMSMONO");
            entity.Property(e => e.W06d1Qbcmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_1_QBCMONORET");
            entity.Property(e => e.W06dVicmsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06D_VICMSMONORETEN");
            entity.Property(e => e.W06eVicmsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W06E_VICMSMONORET");
            entity.Property(e => e.W33Vbcis)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("W33_VBCIS");
            entity.Property(e => e.W33Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W33_VIS");
            entity.Property(e => e.W34Vis)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W34_VIS");
            entity.Property(e => e.W35Vbcibscbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W35_VBCIBSCBS");
            entity.Property(e => e.W38IbsufVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W38_IBSUF_VDIF");
            entity.Property(e => e.W39IbsufVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W39_IBSUF_VDEVTRIB");
            entity.Property(e => e.W41Vibsuf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W41_VIBSUF");
            entity.Property(e => e.W43IbsmunVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W43_IBSMUN_VDIF");
            entity.Property(e => e.W44IbsmunVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W44_IBSMUN__VDEVTRIB");
            entity.Property(e => e.W46Vibsmun)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W46_VIBSMUN");
            entity.Property(e => e.W47IbsmunVibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_IBSMUN_VIBSTOT");
            entity.Property(e => e.W47Vibstot)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W47_VIBSTOT");
            entity.Property(e => e.W48IbsmunVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_IBSMUN_VCREDPRES");
            entity.Property(e => e.W48Vcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W48_VCREDPRES");
            entity.Property(e => e.W49IbsmunVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_IBSMUN_VCREDPRESCONDSUS");
            entity.Property(e => e.W49Vcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W49_VCREDPRESCONDSUS");
            entity.Property(e => e.W51CbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W51_CBS_VCREDPRES");
            entity.Property(e => e.W52CbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W52_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W53CbsVdif)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W53_CBS_VDIF");
            entity.Property(e => e.W54CbsVdevtrib)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W54_CBS_VDEVTRIB");
            entity.Property(e => e.W56Vcbs)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56_VCBS");
            entity.Property(e => e.W56aCbsVcredpres)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56A_CBS_VCREDPRES");
            entity.Property(e => e.W56bCbsVcredprescondsus)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W56B_CBS_VCREDPRESCONDSUS");
            entity.Property(e => e.W58Vtotibsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W58_VTOTIBSMONO");
            entity.Property(e => e.W59Vtotcbsmono)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59_VTOTCBSMONO");
            entity.Property(e => e.W59bVcbsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59B_VCBSMONORETEN");
            entity.Property(e => e.W59cVibsmonoreten)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59C_VIBSMONORETEN");
            entity.Property(e => e.W59dVcbsmonoret)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W59D_VCBSMONORET");
            entity.Property(e => e.W60Vtotnf)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("W60_VTOTNF");

            entity.HasOne(d => d.Dd070Avalista).WithMany(p => p.OsusrTeiCsicpDd070Dd070Avalista)
                .HasForeignKey(d => d.Dd070AvalistaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD070_OSUSR_E9A_CSICP_BB012_DD070_AVALISTA_ID");

            entity.HasOne(d => d.Dd070CompConta).WithMany(p => p.OsusrTeiCsicpDd070Dd070CompConta)
                .HasForeignKey(d => d.Dd070CompContaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD070_OSUSR_E9A_CSICP_BB012_DD070_COMP_CONTA_ID");

            entity.HasOne(d => d.Dd070Conta).WithMany(p => p.OsusrTeiCsicpDd070Dd070Conta)
                .HasForeignKey(d => d.Dd070ContaId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD070_OSUSR_E9A_CSICP_BB012_DD070_CONTA_ID");

            entity.HasOne(d => d.Dd070Contareal).WithMany(p => p.OsusrTeiCsicpDd070Dd070Contareals)
                .HasForeignKey(d => d.Dd070ContarealId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD070_OSUSR_E9A_CSICP_BB012_DD070_CONTAREAL_ID");
        });

        modelBuilder.Entity<OsusrTeiCsicpDd081Cfgimp>(entity =>
        {
            entity.HasKey(e => e.Dd080Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD081_CFGIMP");

            entity.ToTable("OSUSR_TEI_CSICP_DD081_CFGIMP");

            entity.HasIndex(e => new { e.Dd081RflcId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_13DD081_RFLC_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub7479Ccredpresid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_19UB74_79_CCREDPRESID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd081Bb027bIndpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_20DD081_BB027B_INDPRES_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd081NatBcCredPis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_21DD081_NAT_BC_CRED_PIS_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd081Bb027bCfgimpId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_22DD081_BB027B_CFGIMP_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub03IsRfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_22UB03_IS_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub13ub14RfclasstribId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_23UB13UB14_RFCLASSTRIB_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd081NatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_24DD081_NAT_BC_CRED_COFINS_9TENANT_ID");

            entity.HasIndex(e => new { e.Ub6970RfclasstribregId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_25UB69_70_RFCLASSTRIBREG_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd081Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_27DD081_BB027B_CENQUAD_IPI_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_8DD080_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_9TENANT_ID");

            entity.Property(e => e.Dd080Id)
                .HasMaxLength(36)
                .HasColumnName("DD080_ID");
            entity.Property(e => e.Dd081Bb027CfopId).HasColumnName("DD081_BB027_CFOP_ID");
            entity.Property(e => e.Dd081Bb027Id)
                .HasMaxLength(36)
                .HasColumnName("DD081_BB027_ID");
            entity.Property(e => e.Dd081Bb027bAliqInternauf)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("DD081_BB027B_ALIQ_INTERNAUF");
            entity.Property(e => e.Dd081Bb027bAliquota)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("DD081_BB027B_ALIQUOTA");
            entity.Property(e => e.Dd081Bb027bCenquadIpiId).HasColumnName("DD081_BB027B_CENQUAD_IPI_ID");
            entity.Property(e => e.Dd081Bb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("DD081_BB027B_CFGIMP_ID");
            entity.Property(e => e.Dd081Bb027bCfopExcecaoId).HasColumnName("DD081_BB027B_CFOP_EXCECAO_ID");
            entity.Property(e => e.Dd081Bb027bCfopStaticaId).HasColumnName("DD081_BB027B_CFOP_STATICA_ID");
            entity.Property(e => e.Dd081Bb027bClassecontaId).HasColumnName("DD081_BB027B_CLASSECONTA_ID");
            entity.Property(e => e.Dd081Bb027bCodgcst)
                .HasMaxLength(5)
                .HasColumnName("DD081_BB027B_CODGCST");
            entity.Property(e => e.Dd081Bb027bCstCofinsId).HasColumnName("DD081_BB027B_CST_COFINS_ID");
            entity.Property(e => e.Dd081Bb027bCstIcmsId).HasColumnName("DD081_BB027B_CST_ICMS_ID");
            entity.Property(e => e.Dd081Bb027bCstIpiId).HasColumnName("DD081_BB027B_CST_IPI_ID");
            entity.Property(e => e.Dd081Bb027bCstPisId).HasColumnName("DD081_BB027B_CST_PIS_ID");
            entity.Property(e => e.Dd081Bb027bIndpres).HasColumnName("DD081_BB027B_INDPRES");
            entity.Property(e => e.Dd081Bb027bInforcofins)
                .HasMaxLength(200)
                .HasColumnName("DD081_BB027B_INFORCOFINS");
            entity.Property(e => e.Dd081Bb027bInforipi)
                .HasMaxLength(200)
                .HasColumnName("DD081_BB027B_INFORIPI");
            entity.Property(e => e.Dd081Bb027bInfornf)
                .HasMaxLength(200)
                .HasColumnName("DD081_BB027B_INFORNF");
            entity.Property(e => e.Dd081Bb027bInforpis)
                .HasMaxLength(200)
                .HasColumnName("DD081_BB027B_INFORPIS");
            entity.Property(e => e.Dd081Bb027bModalbcIcmsSt).HasColumnName("DD081_BB027B_MODALBC_ICMS_ST");
            entity.Property(e => e.Dd081Bb027bModbcId).HasColumnName("DD081_BB027B_MODBC_ID");
            entity.Property(e => e.Dd081Bb027bMotdesoneracao).HasColumnName("DD081_BB027B_MOTDESONERACAO");
            entity.Property(e => e.Dd081Bb027bMp255Id).HasColumnName("DD081_BB027B_MP255_ID");
            entity.Property(e => e.Dd081Bb027bOrigemId).HasColumnName("DD081_BB027B_ORIGEM_ID");
            entity.Property(e => e.Dd081Bb027bReducaobase)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("DD081_BB027B_REDUCAOBASE");
            entity.Property(e => e.Dd081Bb027bReducaobcst)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("DD081_BB027B_REDUCAOBCST");
            entity.Property(e => e.Dd081Bb027bRegimeId).HasColumnName("DD081_BB027B_REGIME_ID");
            entity.Property(e => e.Dd081Bb027bUfDestId)
                .HasMaxLength(36)
                .HasColumnName("DD081_BB027B_UF_DEST_ID");
            entity.Property(e => e.Dd081Cbenef)
                .HasMaxLength(20)
                .HasColumnName("DD081_CBENEF");
            entity.Property(e => e.Dd081LcId)
                .HasMaxLength(36)
                .HasColumnName("DD081_LC_ID");
            entity.Property(e => e.Dd081LcIdexclui)
                .HasMaxLength(50)
                .HasColumnName("DD081_LC_IDEXCLUI");
            entity.Property(e => e.Dd081NatBcCredCofins).HasColumnName("DD081_NAT_BC_CRED_COFINS");
            entity.Property(e => e.Dd081NatBcCredPis).HasColumnName("DD081_NAT_BC_CRED_PIS");
            entity.Property(e => e.Dd081RfBb027Id)
                .HasMaxLength(36)
                .HasColumnName("DD081_RF_BB027_ID");
            entity.Property(e => e.Dd081RfBb027bCfgimpId)
                .HasMaxLength(36)
                .HasColumnName("DD081_RF_BB027B_CFGIMP_ID");
            entity.Property(e => e.Dd081RflcId)
                .HasMaxLength(36)
                .HasColumnName("DD081_RFLC_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Ub03IsClasstribId).HasColumnName("UB03_IS_CLASSTRIB_ID");
            entity.Property(e => e.Ub03IsClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("UB03_IS_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Ub03IsRfclasstribId).HasColumnName("UB03_IS_RFCLASSTRIB_ID");
            entity.Property(e => e.Ub13ub14ClasstribId).HasColumnName("UB13UB14_CLASSTRIB_ID");
            entity.Property(e => e.Ub13ub14ClasstribIdexclui)
                .HasMaxLength(50)
                .HasColumnName("UB13UB14_CLASSTRIB_IDEXCLUI");
            entity.Property(e => e.Ub13ub14RfclasstribId).HasColumnName("UB13UB14_RFCLASSTRIB_ID");
            entity.Property(e => e.Ub17Ufid)
                .HasMaxLength(36)
                .HasColumnName("UB17_UFID");
            entity.Property(e => e.Ub30ub31ClasstribIdReg).HasColumnName("UB30UB31_CLASSTRIB_ID_REG");
            entity.Property(e => e.Ub36Municipioid)
                .HasMaxLength(36)
                .HasColumnName("UB36_MUNICIPIOID");
            entity.Property(e => e.Ub5665Ccredpres)
                .HasMaxLength(2)
                .HasColumnName("UB56_65_CCREDPRES");
            entity.Property(e => e.Ub6970ClasstribId).HasColumnName("UB69_70_CLASSTRIB_ID");
            entity.Property(e => e.Ub6970ClasstribregId).HasColumnName("UB69_70_CLASSTRIBREG_ID");
            entity.Property(e => e.Ub6970ClasstribregIdexclu)
                .HasMaxLength(50)
                .HasColumnName("UB69_70_CLASSTRIBREG_IDEXCLU");
            entity.Property(e => e.Ub6970RfclasstribregId).HasColumnName("UB69_70_RFCLASSTRIBREG_ID");
            entity.Property(e => e.Ub7479Ccredpresid).HasColumnName("UB74_79_CCREDPRESID");
            entity.Property(e => e.Ub74Ccredpres)
                .HasMaxLength(2)
                .HasColumnName("UB74_CCREDPRES");

            entity.HasOne(d => d.Dd081Bb027bCfgimp).WithMany(p => p.OsusrTeiCsicpDd081Cfgimps)
                .HasForeignKey(d => d.Dd081Bb027bCfgimpId)
                .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD081_CFGIMP_OSUSR_E9A_CSICP_BB027_IMP_DD081_BB027B_CFGIMP_ID");
        });
        modelBuilder.HasSequence("Seq_PK_ID");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
