
using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.StaticaSped;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<SpedCsicpServcorreio> OsusrSpedNnxCsicpServcorreios { get; set; }

        public DbSet<SpedCsicpStrelevancium> OsusrSpedNnxCsicpStrelevancia { get; set; }

        public DbSet<SpedCsicpUnperiodo> OsusrSpedNnxCsicpUnperiodos { get; set; }
        public DbSet<OsusrNnxSpedInDocIcm> OsusrNnxSpedInDocIcms { get; set; }

        public DbSet<OsusrNnxSpedInEmitente> OsusrNnxSpedInEmitentes { get; set; }

        public DbSet<OsusrNnxSpedInGenItem> OsusrNnxSpedInGenItems { get; set; }

        public DbSet<OsusrNnxSpedInSitDocC> OsusrNnxSpedInSitDocCs { get; set; }

        public DbSet<OsusrNnxSpedInTabela> OsusrNnxSpedInTabelas { get; set; }

        public DbSet<SpedInTipoItem> OsusrNnxSpedInTipoItems { get; set; }

        public DbSet<Osusr66cSpedInAjIcm> Osusr66cSpedInAjIcms { get; set; }

        public DbSet<Osusr66cSpedInAjusteIpi> Osusr66cSpedInAjusteIpis { get; set; }

        public DbSet<Osusr66cSpedInCenqIpi> Osusr66cSpedInCenqIpis { get; set; }

        public DbSet<Osusr66cSpedInCfop> Osusr66cSpedInCfops { get; set; }

        public DbSet<Osusr66cSpedInCodAjuste> Osusr66cSpedInCodAjustes { get; set; }

        public DbSet<Osusr66cSpedInDispAutor> Osusr66cSpedInDispAutors { get; set; }

        public DbSet<Osusr66cSpedInEnquadIpi> Osusr66cSpedInEnquadIpis { get; set; }

        public DbSet<Osusr66cSpedInMotInv> Osusr66cSpedInMotInvs { get; set; }

        public DbSet<Osusr66cSpedInNatBc> Osusr66cSpedInNatBcs { get; set; }

        public DbSet<Osusr66cSpedInNatExp> Osusr66cSpedInNatExps { get; set; }

        public DbSet<Osusr66cSpedInSeloIpi> Osusr66cSpedInSeloIpis { get; set; }

        public DbSet<Osusr66cSpedInTotRedZ> Osusr66cSpedInTotRedZs { get; set; }

        public DbSet<Osusr66cSpedInTpAjuste> Osusr66cSpedInTpAjustes { get; set; }

        partial void OnModelCreatingStaticaSped(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osusr66cSpedInAjIcm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_AJ_ICMS");

                entity.ToTable("OSUSR_66C_SPED_IN_AJ_ICMS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.DataFin)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_FIN");
                entity.Property(e => e.DataIni)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_INI");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
                entity.Property(e => e.Uf)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<Osusr66cSpedInAjusteIpi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_AJUSTE_IPI");

                entity.ToTable("OSUSR_66C_SPED_IN_AJUSTE_IPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(390)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInCenqIpi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_CENQ_IPI");

                entity.ToTable("OSUSR_66C_SPED_IN_CENQ_IPI");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("COD");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(600)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.Grupocst)
                    .HasMaxLength(15)
                    .HasDefaultValue("")
                    .HasColumnName("GRUPOCST");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
            });

            modelBuilder.Entity<Osusr66cSpedInCfop>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_CFOP");

                entity.ToTable("OSUSR_66C_SPED_IN_CFOP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInCodAjuste>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_COD_AJUSTE");

                entity.ToTable("OSUSR_66C_SPED_IN_COD_AJUSTE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInDispAutor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_DISP_AUTOR");

                entity.ToTable("OSUSR_66C_SPED_IN_DISP_AUTOR");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInEnquadIpi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_ENQUAD_IPI");

                entity.ToTable("OSUSR_66C_SPED_IN_ENQUAD_IPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInMotInv>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_MOT_INV");

                entity.ToTable("OSUSR_66C_SPED_IN_MOT_INV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(90)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInNatBc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_NAT_BC");

                entity.ToTable("OSUSR_66C_SPED_IN_NAT_BC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInNatExp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_NAT_EXP");

                entity.ToTable("OSUSR_66C_SPED_IN_NAT_EXP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInSeloIpi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_SELO_IPI");

                entity.ToTable("OSUSR_66C_SPED_IN_SELO_IPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInTotRedZ>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_TOT_RED_Z");

                entity.ToTable("OSUSR_66C_SPED_IN_TOT_RED_Z");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Label)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<Osusr66cSpedInTpAjuste>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_SPED_IN_TP_AJUSTE");

                entity.ToTable("OSUSR_66C_SPED_IN_TP_AJUSTE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxSpedInDocIcm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_DOC_ICMS");

                entity.ToTable("OSUSR_NNX_SPED_IN_DOC_ICMS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Cupom)
                    .HasDefaultValue(false)
                    .HasColumnName("CUPOM");
                entity.Property(e => e.Docfiscal)
                    .HasDefaultValue(false)
                    .HasColumnName("DOCFISCAL");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxSpedInEmitente>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_EMITENTE");

                entity.ToTable("OSUSR_NNX_SPED_IN_EMITENTE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxSpedInGenItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_GEN_ITEM");

                entity.ToTable("OSUSR_NNX_SPED_IN_GEN_ITEM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(300)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxSpedInSitDocC>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_SIT_DOC_C");

                entity.ToTable("OSUSR_NNX_SPED_IN_SIT_DOC_C");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.Cupom)
                    .HasDefaultValue(false)
                    .HasColumnName("CUPOM");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxSpedInTabela>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_TABELAS");

                entity.ToTable("OSUSR_NNX_SPED_IN_TABELAS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("CODGCS");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<SpedInTipoItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_SPED_IN_TIPO_ITEM");

                entity.ToTable("OSUSR_NNX_SPED_IN_TIPO_ITEM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<SpedCsicpServcorreio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_CSICP_SERVCORREIOS");

                entity.ToTable("OSUSR_NNX_CSICP_SERVCORREIOS");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_NNX_CSICP_SERVCORREIOS_5LABEL");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<SpedCsicpStrelevancium>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_CSICP_STRELEVANCIA");

                entity.ToTable("OSUSR_NNX_CSICP_STRELEVANCIA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("CODGCS");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<SpedCsicpUnperiodo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_CSICP_UNPERIODO");

                entity.ToTable("OSUSR_NNX_CSICP_UNPERIODO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

        }
    }
}
