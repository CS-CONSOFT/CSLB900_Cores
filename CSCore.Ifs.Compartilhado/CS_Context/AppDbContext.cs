using CSCore.Domain.CS_Models;
using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Ifs.Compartilhado.CS_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace CSCore.Ifs.CS_Context;

public partial class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> optionsConfiguration) : base(optionsConfiguration)
    {
        if (this != null)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddConsole()
                .AddDebug()
                .AddEventSourceLogger()
                .SetMinimumLevel(LogLevel.Information)
                .AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Information);
        });

        optionsBuilder
        .UseLoggerFactory(loggerFactory)
        .EnableSensitiveDataLogging()
        .AddInterceptors(new SerilogDbCommandInterceptor());
    }


    public DbSet<OssysTenant> OssysTenants { get; set; }

    public DbSet<CSICP_TT030> OsusrE9aCsicpTt030s { get; set; }

    public DbSet<CSICP_TT031> OsusrE9aCsicpTt031s { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<CSICP_TT030>(entity =>
        {
            entity.HasKey(e => e.Tt030Id).HasName("OSPRK_OSUSR_E9A_CSICP_TT030");

            entity.ToTable("OSUSR_E9A_CSICP_TT030");

            entity.HasIndex(e => new { e.Tt030Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT030_13TT030_ESTABID_9TENANT_ID");

            entity.HasIndex(e => new { e.Tt030Usuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT030_19TT030_USUARIOPROPID_9TENANT_ID");

            entity.HasIndex(e => new { e.Tt030Usuariovendedorid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT030_23TT030_USUARIOVENDEDORID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_TT030_9TENANT_ID");

            entity.Property(e => e.Tt030Id).HasColumnName("TT030_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Tt030Datahora)
                .HasColumnType("datetime")
                .HasColumnName("TT030_DATAHORA");
            entity.Property(e => e.Tt030Estabid)
                .HasMaxLength(36)
                .HasColumnName("TT030_ESTABID");
            entity.Property(e => e.Tt030Observacao)
                .HasMaxLength(250)
                .HasColumnName("TT030_OBSERVACAO");
            entity.Property(e => e.Tt030Protocolnumber)
                .HasMaxLength(20)
                .HasColumnName("TT030_PROTOCOLNUMBER");
            entity.Property(e => e.Tt030Protocolonumber).HasColumnName("TT030_PROTOCOLONUMBER");
            entity.Property(e => e.Tt030Usuariopropid)
                .HasMaxLength(36)
                .HasColumnName("TT030_USUARIOPROPID");
            entity.Property(e => e.Tt030Usuariovendedorid)
                .HasMaxLength(36)
                .HasColumnName("TT030_USUARIOVENDEDORID");

            entity.HasOne(e => e.CSICP_BB001).WithOne().HasForeignKey<CSICP_TT030>(e => e.Tt030Estabid);
            entity.HasOne(e => e.Csicp_Sy001).WithOne().HasForeignKey<CSICP_TT030>(e => e.Tt030Usuariopropid);
        });
        modelBuilder.Entity<CSICP_TT031>(entity =>
        {
            entity.HasKey(e => e.Tt031Id).HasName("OSPRK_OSUSR_E9A_CSICP_TT031");

            entity.ToTable("OSUSR_E9A_CSICP_TT031");

            entity.HasIndex(e => new { e.Gg008kdxId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT031_11GG008KDX_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT031_8GG008_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Gg520Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT031_8GG520_ID_9TENANT_ID");

            entity.HasIndex(e => new { e.Tt030Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_TT031_8TT030_ID_9TENANT_ID");

            entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_TT031_9TENANT_ID");

            entity.Property(e => e.Tt031Id).HasColumnName("TT031_ID");
            entity.Property(e => e.Campoespecial1)
                .HasMaxLength(50)
                .HasColumnName("CAMPOESPECIAL1");
            entity.Property(e => e.Campoespecial2)
                .HasMaxLength(50)
                .HasColumnName("CAMPOESPECIAL2");
            entity.Property(e => e.CsCodgproduto)
                .HasMaxLength(50)
                .HasColumnName("CS_CODGPRODUTO");
            entity.Property(e => e.CsDesc)
                .HasColumnType("decimal(9, 5)")
                .HasColumnName("CS_DESC");
            entity.Property(e => e.CsQtd)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CS_QTD");
            entity.Property(e => e.CsValor)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("CS_VALOR");
            entity.Property(e => e.Gg008Id)
                .HasMaxLength(36)
                .HasColumnName("GG008_ID");
            entity.Property(e => e.Gg008kdxId)
                .HasMaxLength(36)
                .HasColumnName("GG008KDX_ID");
            entity.Property(e => e.Gg520Id)
                .HasMaxLength(36)
                .HasColumnName("GG520_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Tt030Id).HasColumnName("TT030_ID");


        });
        modelBuilder.Entity<OssysTenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ossys_tenant");

            entity.ToTable("ossys_Tenant");

            entity.HasIndex(e => new { e.Name, e.EspaceId }, "OSIDX_OSSYS_TENANT_4NAME_9ESPACE_ID").IsUnique();

            entity.HasIndex(e => e.EspaceId, "OSIDX_OSSYS_TENANT_9ESPACE_ID");

            entity.HasIndex(e => new { e.EspaceId, e.IsActive }, "OSIDX_OSSYS_TENANT_9ESPACE_ID_9IS_ACTIVE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EspaceId).HasColumnName("ESPACE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .HasColumnName("NAME");
        });

        OnModelCreatingStaticaFF(modelBuilder);
        OnModelCreatingStaticaGG(modelBuilder);
        OnModelCreatingStatica(modelBuilder);
        OnModelCreatingStaticaSped(modelBuilder);
        OnModelCreatingStaticaNFS(modelBuilder);
        OnModelCreatingStaticaAA(modelBuilder);
        OnModelCreatingStaticaBB(modelBuilder);
        OnModelCreating_CSICP_AA(modelBuilder);
        OnModelCreating_CSICP_BB001(modelBuilder);
        OnModelCreating_CSICP_BB002(modelBuilder);
        OnModelCreating_CSICP_BB003(modelBuilder);
        OnModelCreating_CSICP_BB004(modelBuilder);
        OnModelCreating_CSICP_BB005(modelBuilder);
        OnModelCreating_CSICP_BB006(modelBuilder);
        OnModelCreating_CSICP_BB007(modelBuilder);
        OnModelCreating_CSICP_BB008(modelBuilder);
        OnModelCreating_CSICP_BB009(modelBuilder);
        OnModelCreating_CSICP_BB01X(modelBuilder);
        OnModelCreating_CSICP_BB012(modelBuilder);
        OnModelCreating_CSICP_BB02X(modelBuilder);
        OnModelCreating_CSICP_BB03X(modelBuilder);
        OnModelCreating_CSICP_BB05X(modelBuilder);
        OnModelCreating_CSICP_BB06X(modelBuilder);
        OnModelCreating_CSICP_DD_0_20(modelBuilder);
        OnModelCreating_CSICP_DD_70_90(modelBuilder);
        OnModelCreating_CSICP_DD_180(modelBuilder);
        OnModelCreating_CSICP_DD_130_140(modelBuilder);
        OnModelCreating_CSICP_DD_100_120(modelBuilder);
        OnModelCreating_CSICP_DD_150_200(modelBuilder);
        OnModelCreating_CSICP_DD_40_60(modelBuilder);
        OnModelCreating_CSICP_DD_800_900(modelBuilder);
        OnModelCreating_CSICP_GG(modelBuilder);
        OnModelCreating_CSICP_GG001(modelBuilder);
        OnModelCreating_CSICP_GG01X(modelBuilder);
        OnModelCreating_CSICP_GG02X(modelBuilder);
        OnModelCreating_CSICP_GG03X(modelBuilder);
        OnModelCreating_CSICP_FF003(modelBuilder);
        OnModelCreating_CSICP_Systems(modelBuilder);
        OnModelCreatingRR(modelBuilder); // Adicionando a chamada para as configurações RR
        OnModelCreating_CSICP_CG(modelBuilder);
        OnModelCreating_CSICP_NN(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    partial void OnModelCreatingStaticaSped(ModelBuilder modelBuilder);
    partial void OnModelCreatingStatica(ModelBuilder modelBuilder);
    partial void OnModelCreatingStaticaFF(ModelBuilder modelBuilder);
    partial void OnModelCreatingStaticaGG(ModelBuilder modelBuilder);
    partial void OnModelCreatingStaticaNFS(ModelBuilder modelBuilder);
    partial void OnModelCreatingStaticaBB(ModelBuilder modelBuilder);
    partial void OnModelCreatingStaticaAA(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_NN(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_CG(ModelBuilder modelBuilder);

    partial void OnModelCreating_CSICP_AA(ModelBuilder modelBuilder);
    partial void OnModelCreatingRR(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB001(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB002(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB003(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB004(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB005(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB006(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB007(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB008(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB009(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB01X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB012(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB02X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB03X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB05X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_BB06X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_0_20(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_70_90(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_180(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_130_140(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_100_120(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_150_200(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_40_60(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_DD_800_900(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_GG(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_GG001(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_GG01X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_GG02X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_GG03X(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_FF003(ModelBuilder modelBuilder);
    partial void OnModelCreating_CSICP_Systems(ModelBuilder modelBuilder);

}

