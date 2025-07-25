

using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb005> OsusrE9aCsicpBb005s { get; set; }
        partial void OnModelCreating_CSICP_BB005(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb005>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB005");

                entity.ToTable("OSUSR_E9A_CSICP_BB005");

                entity.HasIndex(e => new { e.Bb005Nomeccusto, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB005_16BB005_NOMECCUSTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB005_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB005_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb005Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB005_CODIGO");
                entity.Property(e => e.Bb005Colunaimpressao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB005_COLUNAIMPRESSAO");
                entity.Property(e => e.Bb005Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB005_FILIAL");
                entity.Property(e => e.Bb005Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB005_ISACTIVE");
                entity.Property(e => e.Bb005Nomeccusto)
                    .HasMaxLength(90)
                    .HasDefaultValue("")
                    .HasColumnName("BB005_NOMECCUSTO");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
