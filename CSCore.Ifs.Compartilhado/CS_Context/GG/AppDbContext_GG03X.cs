using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG036> OsusrE9aCsicpGg036s { get; set; }

        public DbSet<CSICP_GG037> OsusrE9aCsicpGg037s { get; set; }
        partial void OnModelCreating_CSICP_GG03X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_GG036>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG036");

                entity.ToTable("OSUSR_E9A_CSICP_GG036");

                entity.HasIndex(e => new { e.Gg036Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG036_14GG036_FILIALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG036_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg036Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG036_CODBARRASALFA");
                entity.Property(e => e.Gg036Codigobarras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG036_CODIGOBARRAS");
                entity.Property(e => e.Gg036Dataregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG036_DATAREGISTRO");
                entity.Property(e => e.Gg036Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG036_FILIALID");
                entity.Property(e => e.Gg036Inventariado)
                    .HasDefaultValue(false)
                    .HasColumnName("GG036_INVENTARIADO");
                entity.Property(e => e.Gg036KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG036_KARDEX_ID");
                entity.Property(e => e.Gg036Mensagem)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("GG036_MENSAGEM");
                entity.Property(e => e.Gg036Naoinventariar)
                    .HasDefaultValue(false)
                    .HasColumnName("GG036_NAOINVENTARIAR");
                entity.Property(e => e.Gg036Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("GG036_ORDEM");
                entity.Property(e => e.Gg036Precocusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_PRECOCUSTO");
                entity.Property(e => e.Gg036Precocustomedio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_PRECOCUSTOMEDIO");
                entity.Property(e => e.Gg036Precocustoreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_PRECOCUSTOREAL");
                entity.Property(e => e.Gg036Precovenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_PRECOVENDA");
                entity.Property(e => e.Gg036QtdEstoque)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_QTD_ESTOQUE");
                entity.Property(e => e.Gg036Saldoestoque)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG036_SALDOESTOQUE");
                entity.Property(e => e.Gg036Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG036_SALDOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

               

                
            });

            modelBuilder.Entity<CSICP_GG037>(entity =>
            {
                entity.HasKey(e => e.Gg037Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG037");

                entity.ToTable("OSUSR_E9A_CSICP_GG037");

                entity.HasIndex(e => new { e.Gg037FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG037_15GG037_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg037InventarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG037_19GG037_INVENTARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG037_9TENANT_ID");

                entity.Property(e => e.Gg037Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG037_ID");
                entity.Property(e => e.Gg037FilialId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG037_FILIAL_ID");
                entity.Property(e => e.Gg037GeradoListaInv)
                    .HasDefaultValue(false)
                    .HasColumnName("GG037_GERADO_LISTA_INV");
                entity.Property(e => e.Gg037InventarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG037_INVENTARIO_ID");
                entity.Property(e => e.Gg037QtdNconfirmidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG037_QTD_NCONFIRMIDADE");
                entity.Property(e => e.Gg037SaldoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG037_SALDO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
