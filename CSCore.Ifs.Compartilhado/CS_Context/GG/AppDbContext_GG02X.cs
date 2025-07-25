using CSCore.Domain.CS_Models.CSICP_GG;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG021> OsusrE9aCsicpGg021s { get; set; }

        partial void OnModelCreating_CSICP_GG02X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_GG021>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG021");

                entity.ToTable("OSUSR_E9A_CSICP_GG021");

                entity.HasIndex(e => new { e.Gg021Unid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_10GG021_UNID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg021CestId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_13GG021_CEST_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg021CnaeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_13GG021_CNAE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg021Mp255Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_14GG021_MP255_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg021Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_15GG021_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg021GeneroId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG021_15GG021_GENERO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG021_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg021AliquotaIrpj)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG021_ALIQUOTA_IRPJ");
                entity.Property(e => e.Gg021CestId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_CEST_ID");
                entity.Property(e => e.Gg021CestN2)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_CEST_N2");
                entity.Property(e => e.Gg021CestN3)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_CEST_N3");
                entity.Property(e => e.Gg021CnaeId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_CNAE_ID");
                entity.Property(e => e.Gg021Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_DESCRICAO");
                entity.Property(e => e.Gg021Dtfimvigencia)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG021_DTFIMVIGENCIA");
                entity.Property(e => e.Gg021Dtiniciovigencia)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG021_DTINICIOVIGENCIA");
                entity.Property(e => e.Gg021ExNbm)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_EX_NBM");
                entity.Property(e => e.Gg021ExNcm)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_EX_NCM");
                entity.Property(e => e.Gg021GeneroId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_GENERO_ID");
                entity.Property(e => e.Gg021IcmsPauta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG021_ICMS_PAUTA");
                entity.Property(e => e.Gg021Ierelevanteid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_IERELEVANTEID");
                entity.Property(e => e.Gg021IpiPauta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG021_IPI_PAUTA");
                entity.Property(e => e.Gg021IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG021_IS_ACTIVE");
                entity.Property(e => e.Gg021IsinalanteId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_ISINALANTE_ID");
                entity.Property(e => e.Gg021Mp255Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_MP255_ID");
                entity.Property(e => e.Gg021Ncm)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("GG021_NCM");
                entity.Property(e => e.Gg021NcmGenero)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_NCM_GENERO");
                entity.Property(e => e.Gg021PercCofins)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG021_PERC_COFINS");
                entity.Property(e => e.Gg021PercCsll)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG021_PERC_CSLL");
                entity.Property(e => e.Gg021PercIcms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG021_PERC_ICMS");
                entity.Property(e => e.Gg021PercIpi)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG021_PERC_IPI");
                entity.Property(e => e.Gg021PercPis)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG021_PERC_PIS");
                entity.Property(e => e.Gg021Tipi)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_TIPI");
                entity.Property(e => e.Gg021Unid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG021_UNID");
                entity.Property(e => e.Gg021Unidade)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG021_UNIDADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.NavGg007Un).WithOne().HasForeignKey<CSICP_GG021>(d => d.Gg021Unid);
                entity.HasOne(d => d.NavGg021Cest).WithOne().HasForeignKey<CSICP_GG021>(d => d.Gg021CestId);
                entity.HasOne(d => d.NavSpedGenero).WithOne().HasForeignKey<CSICP_GG021>(d => d.Gg021GeneroId);

            });
        }
    }
}
