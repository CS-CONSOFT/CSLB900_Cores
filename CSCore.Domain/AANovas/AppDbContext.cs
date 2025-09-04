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

    public virtual DbSet<OsusrE9aCsicpAa143> OsusrE9aCsicpAa143s { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa144> OsusrE9aCsicpAa144s { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa145Tpdebcre> OsusrE9aCsicpAa145Tpdebcres { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa146Tpgov> OsusrE9aCsicpAa146Tpgovs { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa147> OsusrE9aCsicpAa147s { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa148> OsusrE9aCsicpAa148s { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa149Tpopgov> OsusrE9aCsicpAa149Tpopgovs { get; set; }

    public virtual DbSet<OsusrE9aCsicpAa150Ccredpre> OsusrE9aCsicpAa150Ccredpres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dbdsv17.csicorpnet.com.br;Database=CSOS_DSV03_ERP17;User Id=CSSPRUN_DSV17;Password=CSSPRUN17;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<OsusrE9aCsicpAa143>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA143");

            entity.ToTable("OSUSR_E9A_CSICP_AA143");

            entity.HasIndex(e => e.Aa043Artigo, "OSIDX_OSUSR_E9A_CSICP_AA143_12AA043_ARTIGO");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Aa043Artigo)
                .HasMaxLength(50)
                .HasColumnName("AA043_ARTIGO");
            entity.Property(e => e.Aa043Ec)
                .HasMaxLength(150)
                .HasColumnName("AA043_EC");
            entity.Property(e => e.Aa043LcRedacao)
                .HasMaxLength(2000)
                .HasColumnName("AA043_LC_REDACAO");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa144>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA144");

            entity.ToTable("OSUSR_E9A_CSICP_AA144");

            entity.HasIndex(e => new { e.CstibsCbs, e.Cclasstrib }, "OSIDX_OSUSR_E9A_CSICP_AA144_10CSTIBS_CBS_10CCLASSTRIB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cclasstrib).HasColumnName("CCLASSTRIB");
            entity.Property(e => e.CstibsCbs).HasColumnName("CSTIBS_CBS");
            entity.Property(e => e.Descricaocclasstrib)
                .HasMaxLength(2000)
                .HasColumnName("DESCRICAOCCLASSTRIB");
            entity.Property(e => e.DescricaocstibsCbs)
                .HasMaxLength(100)
                .HasColumnName("DESCRICAOCSTIBS_CBS");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa145Tpdebcre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA145_TPDEBCRE");

            entity.ToTable("OSUSR_E9A_CSICP_AA145_TPDEBCRE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Debcre)
                .HasMaxLength(1)
                .HasColumnName("DEBCRE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("LABEL");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.Tiponotacredeb)
                .HasMaxLength(2)
                .HasColumnName("TIPONOTACREDEB");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa146Tpgov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA146_TPGOV");

            entity.ToTable("OSUSR_E9A_CSICP_AA146_TPGOV");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .HasColumnName("LABEL");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.Tpcompragov)
                .HasMaxLength(1)
                .HasColumnName("TPCOMPRAGOV");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa147>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA147");

            entity.ToTable("OSUSR_E9A_CSICP_AA147");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_AA147_9TENANT_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Aa047PrefcbsUniao)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("AA047_PREFCBS_UNIAO");
            entity.Property(e => e.Aa047PrefibsEstadual)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("AA047_PREFIBS_ESTADUAL");
            entity.Property(e => e.Aa047PrefibsMunicipal)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("AA047_PREFIBS_MUNICIPAL");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa148>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA148");

            entity.ToTable("OSUSR_E9A_CSICP_AA148");

            entity.HasIndex(e => new { e.Aa048UfId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_AA148_11AA048_UF_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Aa048MunicId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_AA148_14AA048_MUNIC_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_AA148_9TENANT_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Aa048MunicId)
                .HasMaxLength(36)
                .HasColumnName("AA048_MUNIC_ID");
            entity.Property(e => e.Aa048PrefibsEstadual)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("AA048_PREFIBS_ESTADUAL");
            entity.Property(e => e.Aa048PrefibsMunicipal)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("AA048_PREFIBS_MUNICIPAL");
            entity.Property(e => e.Aa048UfId)
                .HasMaxLength(36)
                .HasColumnName("AA048_UF_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa149Tpopgov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA149_TPOPGOV");

            entity.ToTable("OSUSR_E9A_CSICP_AA149_TPOPGOV");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("LABEL");
            entity.Property(e => e.Order).HasColumnName("ORDER");
        });

        modelBuilder.Entity<OsusrE9aCsicpAa150Ccredpre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA150_CCREDPRES");

            entity.ToTable("OSUSR_E9A_CSICP_AA150_CCREDPRES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("LABEL");
            entity.Property(e => e.Order).HasColumnName("ORDER");
        });
        modelBuilder.HasSequence("Seq_PK_ID");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
