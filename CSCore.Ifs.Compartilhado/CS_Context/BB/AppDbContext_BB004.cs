using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB004> OsusrE9aCsicpBb004s { get; set; }
        partial void OnModelCreating_CSICP_BB004(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_BB004>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB004");

                entity.ToTable("OSUSR_E9A_CSICP_BB004");

                entity.HasIndex(e => new { e.Moedaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB004_7MOEDAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB004_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb004Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB004_CODIGO");
                entity.Property(e => e.Bb004Datacambio)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB004_DATACAMBIO");
                entity.Property(e => e.Bb004Valorcambio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB004_VALORCAMBIO");
                entity.Property(e => e.Moedaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("MOEDAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Moeda).WithMany(p => p.BB004List)
                //    .HasForeignKey(d => d.Moedaid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB004_OSUSR_E9A_CSICP_BB003_MOEDAID");
            });
        }
    }
}
