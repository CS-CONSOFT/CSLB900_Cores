
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb003> OsusrE9aCsicpBb003s { get; set; }
        partial void OnModelCreating_CSICP_BB003(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb003>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB003");

                entity.ToTable("OSUSR_E9A_CSICP_BB003");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB003_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb003Moeda)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_MOEDA");
                entity.Property(e => e.Bb003Sigla)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB003_SIGLA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
