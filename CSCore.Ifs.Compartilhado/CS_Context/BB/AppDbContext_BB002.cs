

using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB002> OsusrE9aCsicpBb002s { get; set; }

        public DbSet<CSICP_BB002CSC> OsusrE9aCsicpBb002Cscs { get; set; }
        partial void OnModelCreating_CSICP_BB002(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_BB002>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB002");

                entity.ToTable("OSUSR_E9A_CSICP_BB002");

                entity.HasIndex(e => new { e.Bb002Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB002_12BB002_CODIGO_9TENANT_ID").IsUnique();

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB002_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb002Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB002_CODIGO");
                entity.Property(e => e.Bb002Grupoempresa)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB002_GRUPOEMPRESA");
                entity.Property(e => e.Bb003AwsBucket)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_AWS_BUCKET");
                entity.Property(e => e.Bb003Awsaccesskeyid)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_AWSACCESSKEYID");
                entity.Property(e => e.Bb003Awsregion)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_AWSREGION");
                entity.Property(e => e.Bb003Awssecretaccesskey)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_AWSSECRETACCESSKEY");
                entity.Property(e => e.CixNrodominio)
                    .HasDefaultValue(0)
                    .HasColumnName("CIX_NRODOMINIO");
                entity.Property(e => e.CixToken)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("CIX_TOKEN");
                entity.Property(e => e.CixUrlWebservicecix)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("CIX_URL_WEBSERVICECIX");
                entity.Property(e => e.CixUsacix)
                    .HasDefaultValue(false)
                    .HasColumnName("CIX_USACIX");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_BB002CSC>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB002_CSC");

                entity.ToTable("OSUSR_E9A_CSICP_BB002_CSC");

                entity.HasIndex(e => new { e.Bb001Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB002_CSC_13BB001_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb002Cidtoken, e.Bb002Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB002_CSC_14BB002_CIDTOKEN_8BB002_ID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Bb002Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB002_CSC_8BB002_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb002Csc, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB002_CSC_9BB002_CSC_9TENANT_ID").IsUnique();

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB002_CSC_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb001Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_ESTABID");
                entity.Property(e => e.Bb002Cidtoken)
                    .HasDefaultValue(0)
                    .HasColumnName("BB002_CIDTOKEN");
                entity.Property(e => e.Bb002Csc)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB002_CSC");
                entity.Property(e => e.Bb002Dataativacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB002_DATAATIVACAO");
                entity.Property(e => e.Bb002Datarevogacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB002_DATAREVOGACAO");
                entity.Property(e => e.Bb002Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB002_ID");
                entity.Property(e => e.Bb002Isrevogado)
                    .HasDefaultValue(false)
                    .HasColumnName("BB002_ISREVOGADO");
                entity.Property(e => e.Bb002Motivorevogacao)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("BB002_MOTIVOREVOGACAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb002).WithMany(p => p.OsusrE9aCsicpBb002Cscs)
                //    .HasForeignKey(d => d.Bb002Id)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB002_CSC_OSUSR_E9A_CSICP_BB002_BB002_ID");
            });
        }
    }
}
