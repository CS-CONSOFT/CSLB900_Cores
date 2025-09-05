using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.AA;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Aa030Tptoken> E9ACSICP_AA030TPToken { get; set; }
        public DbSet<CSICP_AA031Cstori> E9ACSICP_AA031Cstoris { get; set; }

        public DbSet<CSICP_AA032Csticm> E9ACSICP_AA032Csticms { get; set; }

        public DbSet<CSICP_AA033Cstipi> E9ACSICP_AA033Cstipis { get; set; }

        public DbSet<CSICP_AA034Cstpi> E9ACSICP_AA034Cstpis { get; set; }

        public DbSet<CSICP_AA035Cstcof> E9ACSICP_AA035Cstcofs { get; set; }

        public DbSet<CSICP_AA036Ipiaju> E9ACSICP_AA036Ipiajus { get; set; }

        public DbSet<CSICP_AA037Imp> E9ACSICP_AA037Imps { get; set; }

        public DbSet<CSICP_AA038Modst> E9ACSICP_AA038Modsts { get; set; }

        public DbSet<CSICP_AA39Mp255> E9ACSICP_AA039Mp255s { get; set; }

        public DbSet<CSICP_AA030Regime> E9ACSICP_AA030Regimes { get; set; }
        public DbSet<CSICP_AA146_TP_GOV> CSICP_AA146_TP_GOV { get; set; }

        partial void OnModelCreatingStaticaAA(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OsusrE9aCsicpAa145Tpdebcre>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA145_TPDEBCRE");

                entity.ToTable("OSUSR_E9A_CSICP_AA145_TPDEBCRE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Debcre)
                    .HasMaxLength(1)
                    .HasColumnName("DEBCRE");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tiponotacredeb)
                    .HasMaxLength(2)
                    .HasColumnName("TIPONOTACREDEB");
            });

            modelBuilder.Entity<OsusrE9aCsicpAa146Tpgov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA146_TPGOV");

                entity.ToTable("OSUSR_E9A_CSICP_AA146_TPGOV");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tpcompragov)
                    .HasMaxLength(1)
                    .HasColumnName("TPCOMPRAGOV");
            });

            modelBuilder.Entity<OsusrE9aCsicpAa149Tpopgov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA149_TPOPGOV");

                entity.ToTable("OSUSR_E9A_CSICP_AA149_TPOPGOV");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpAa150Ccredpre>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA150_CCREDPRES");

                entity.ToTable("OSUSR_E9A_CSICP_AA150_CCREDPRES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });
            modelBuilder.Entity<CSICP_AA146_TP_GOV>(entity =>
            {
                entity
                    .HasKey(e => e.Id);

                entity.ToTable("OSUSR_E9A_CSICP_AA046_TPGOV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tpcompragov)
                    .HasMaxLength(1)
                    .HasColumnName("TPCOMPRAGOV");
            });
            modelBuilder.Entity<CSICP_AA030Regime>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA030_REGIME");

                entity.ToTable("OSUSR_E9A_CSICP_AA030_REGIME");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CrtDigito)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("CRT_DIGITO");
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

            modelBuilder.Entity<CSICP_Aa030Tptoken>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA030_TPTOKEN");

                entity.ToTable("OSUSR_E9A_CSICP_AA030_TPTOKEN");

                entity.Property(e => e.Id).HasColumnName("ID");
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

            modelBuilder.Entity<CSICP_AA031Cstori>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA031_CSTORI");

                entity.ToTable("OSUSR_E9A_CSICP_AA031_CSTORI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CstDigito)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("CST_DIGITO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_AA032Csticm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA032_CSTICM");

                entity.ToTable("OSUSR_E9A_CSICP_AA032_CSTICM");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CstDigito)
                    .HasMaxLength(4)
                    .HasDefaultValue("")
                    .HasColumnName("CST_DIGITO");
                entity.Property(e => e.Informativo)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("INFORMATIVO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
                entity.Property(e => e.Regime)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("REGIME");
                entity.Property(e => e.RegimeId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("REGIME_ID");
            });

            modelBuilder.Entity<CSICP_AA033Cstipi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA033_CSTIPI");

                entity.ToTable("OSUSR_E9A_CSICP_AA033_CSTIPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CstDigito)
                    .HasMaxLength(4)
                    .HasDefaultValue("")
                    .HasColumnName("CST_DIGITO");
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

            modelBuilder.Entity<CSICP_AA034Cstpi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA034_CSTPIS");

                entity.ToTable("OSUSR_E9A_CSICP_AA034_CSTPIS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CstDigito)
                    .HasMaxLength(4)
                    .HasDefaultValue("")
                    .HasColumnName("CST_DIGITO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_AA035Cstcof>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA035_CSTCOF");

                entity.ToTable("OSUSR_E9A_CSICP_AA035_CSTCOF");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CstDigito)
                    .HasMaxLength(4)
                    .HasDefaultValue("")
                    .HasColumnName("CST_DIGITO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_AA036Ipiaju>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA036_IPIAJU");

                entity.ToTable("OSUSR_E9A_CSICP_AA036_IPIAJU");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Debcre)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("DEBCRE");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_AA037Imp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA037_IMP");

                entity.ToTable("OSUSR_E9A_CSICP_AA037_IMP");

                entity.Property(e => e.Id).HasColumnName("ID");
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

            modelBuilder.Entity<CSICP_AA038Modst>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA038_MODST");

                entity.ToTable("OSUSR_E9A_CSICP_AA038_MODST");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Digito)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("DIGITO");
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

            modelBuilder.Entity<CSICP_AA39Mp255>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA039_MP255");

                entity.ToTable("OSUSR_E9A_CSICP_AA039_MP255");

                entity.Property(e => e.Id).HasColumnName("ID");
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
