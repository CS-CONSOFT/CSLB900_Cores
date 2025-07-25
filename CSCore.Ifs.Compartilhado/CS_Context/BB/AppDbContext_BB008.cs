
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb008> OsusrE9aCsicpBb008s { get; set; }
        partial void OnModelCreating_CSICP_BB008(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb008>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB008");

                entity.ToTable("OSUSR_E9A_CSICP_BB008");

                entity.HasIndex(e => new { e.Bb008Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_12BB008_CODIGO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008Tipoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_12BB008_TIPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008AprovaVenda, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_18BB008_APROVA_VENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008Entliquidada, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_18BB008_ENTLIQUIDADA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008CondicaoPagto, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_20BB008_CONDICAO_PAGTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008Parcliquidadas, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_20BB008_PARCLIQUIDADAS_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB008_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB008_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb008AprovaVenda)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB008_APROVA_VENDA");
                entity.Property(e => e.Bb008Codformapagto)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_CODFORMAPAGTO");
                entity.Property(e => e.Bb008Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_CODIGO");
                entity.Property(e => e.Bb008Condicao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB008_CONDICAO");
                entity.Property(e => e.Bb008CondicaoPagto)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB008_CONDICAO_PAGTO");
                entity.Property(e => e.Bb008Entliquidada)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB008_ENTLIQUIDADA");
                entity.Property(e => e.Bb008Fatorjuros)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("BB008_FATORJUROS");
                entity.Property(e => e.Bb008Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_FILIAL");
                entity.Property(e => e.Bb008Indprecovenda)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_INDPRECOVENDA");
                entity.Property(e => e.Bb008Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB008_ISACTIVE");
                entity.Property(e => e.Bb008Parcliquidadas)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB008_PARCLIQUIDADAS");
                entity.Property(e => e.Bb008PercAcrescimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB008_PERC_ACRESCIMO");
                entity.Property(e => e.Bb008PercDesconto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB008_PERC_DESCONTO");
                entity.Property(e => e.Bb008Percentrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("BB008_PERCENTRADA");
                entity.Property(e => e.Bb008Qtdparcela)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_QTDPARCELA");
                entity.Property(e => e.Bb008Tipo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB008_TIPO");
                entity.Property(e => e.Bb008Tipoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB008_TIPOID");
                entity.Property(e => e.Bb008Valoracrescimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB008_VALORACRESCIMO");
                entity.Property(e => e.Bb008Vlrmaxformapagto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB008_VLRMAXFORMAPAGTO");
                entity.Property(e => e.Bb008Vlrminformapagto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB008_VLRMINFORMAPAGTO");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBB008_EntLiquidada).WithOne().HasForeignKey<CSICP_Bb008>(e => e.Bb008Entliquidada);
                entity.HasOne(e => e.NavBB008_ParcLiquidadas).WithOne().HasForeignKey<CSICP_Bb008>(e => e.Bb008Parcliquidadas);
                entity.HasOne(e => e.NavBB008_Aprova_Venda).WithOne().HasForeignKey<CSICP_Bb008>(e => e.Bb008AprovaVenda);
                entity.HasOne(e => e.CSICP_Bb008Tipo).WithOne().HasForeignKey<CSICP_Bb008>(e => e.Bb008Tipoid);
                entity.HasOne(e => e.CSICP_BB001).WithOne().HasForeignKey<CSICP_Bb008>(e => e.Empresaid);
            });
        }
    }
}
