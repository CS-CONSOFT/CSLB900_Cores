
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb009> OsusrE9aCsicpBb009s { get; set; }
        partial void OnModelCreating_CSICP_BB009(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb009>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB009");

                entity.ToTable("OSUSR_E9A_CSICP_BB009");

                entity.HasIndex(e => new { e.Bb009Tipocobranca, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB009_18BB009_TIPOCOBRANCA_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB009_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB009_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb009Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB009_CODIGO");
                entity.Property(e => e.Bb009Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB009_FILIAL");
                entity.Property(e => e.Bb009Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB009_ISACTIVE");
                entity.Property(e => e.Bb009Tipocobranca)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB009_TIPOCOBRANCA");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
