using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB001_Aliqs> E9ACSICP_BB001Aliqs { get; set; }

        public DbSet<CSICP_BB001_ATPJS> E9ACSICP_BB001Atpjs { get; set; }

        public DbSet<CSICP_BB001Capmun> E9ACSICP_BB001Capmuns { get; set; }


        public DbSet<CSICP_BB001Natpj> E9ACSICP_BB001Natpjs { get; set; }

        public DbSet<CSICP_BB001Staimg> E9ACSICP_BB001Staimgs { get; set; }

        public DbSet<CSICP_BB001TpTri> E9ACSICP_BB001Tptris { get; set; }

        //XX-BB12

        public DbSet<CSICP_Bb01201Con> OsusrE9aCsicpBb01201Cons { get; set; }

        public DbSet<CSICP_Bb01201Jur> OsusrE9aCsicpBb01201Jurs { get; set; }

        public DbSet<CSICP_Bb01201Tger> OsusrE9aCsicpBb01201Tgers { get; set; }

        public DbSet<CSICP_Bb01202Dom> OsusrE9aCsicpBb01202Doms { get; set; }

        public DbSet<CSICP_Bb01202Eciv> OsusrE9aCsicpBb01202Ecivs { get; set; }

        public DbSet<CSICP_Bb01202Esc> OsusrE9aCsicpBb01202Escs { get; set; }

        public DbSet<CSICP_Bb01202Ins> OsusrE9aCsicpBb01202Ins { get; set; }

        public DbSet<CSICP_Bb01202Ocu> OsusrE9aCsicpBb01202Ocus { get; set; }

        public DbSet<CSICP_Bb01202Res> OsusrE9aCsicpBb01202Res { get; set; }

        public DbSet<CSICP_Bb01202Sex> OsusrE9aCsicpBb01202Sexes { get; set; }

        public DbSet<CSICP_Bb012Clacta> OsusrE9aCsicpBb012Clacta { get; set; }

        public DbSet<CSICP_Bb012Gructa> OsusrE9aCsicpBb012Gructa { get; set; }

        public DbSet<CSICP_Bb012Mcred> OsusrE9aCsicpBb012Mcreds { get; set; }

        public DbSet<CSICP_Bb012Mrel> OsusrE9aCsicpBb012Mrels { get; set; }

        public DbSet<CSICP_Bb012Sitcta> OsusrE9aCsicpBb012Sitcta { get; set; }

        public DbSet<CSICP_Bb012Stacta> OsusrE9aCsicpBb012Stacta { get; set; }

        public DbSet<CSICP_Bb012Tpcta> OsusrE9aCsicpBb012Tpcta { get; set; }

        public DbSet<CSICP_Bb012jTpend> OsusrE9aCsicpBb012jTpends { get; set; }

        public DbSet<Csicp_Bb012mdc> OsusrE9aCsicpBb012mdcs { get; set; }

        public DbSet<Csicp_Bb012mtd> OsusrE9aCsicpBb012mtds { get; set; }

        public DbSet<CSICP_Bb006Banco> OsusrE9aCsicpBb006Bancos { get; set; }

        public DbSet<CSICP_Bb008Tipo> OsusrE9aCsicpBb008Tipos { get; set; }

        public DbSet<CSICP_Bb010Tp> OsusrE9aCsicpBb010Tps { get; set; }

        public DbSet<CSICP_Bb019Tipo> OsusrE9aCsicpBb019Tipos { get; set; }

        public DbSet<CSICP_Bb026Classe> OsusrE9aCsicpBb026Classes { get; set; }

        public DbSet<CSICP_Bb026Tipo> OsusrE9aCsicpBb026Tipos { get; set; }

        public DbSet<CSICP_Bb026Vin> OsusrE9aCsicpBb026Vins { get; set; }

        public DbSet<CSICP_Bb027Bcalc> OsusrE9aCsicpBb027Bcalcs { get; set; }

        public DbSet<CSICP_Bb027Cicm> OsusrE9aCsicpBb027Cicms { get; set; }

        public DbSet<CSICP_Bb027Difer> OsusrE9aCsicpBb027Difers { get; set; }

        public DbSet<CSICP_Bb027Entsai> OsusrE9aCsicpBb027Entsais { get; set; }

        public DbSet<CSICP_Bb027Fdesen> OsusrE9aCsicpBb027Fdesens { get; set; }

        public DbSet<CSICP_Bb027Imp> OsusrE9aCsicpBb027Imps { get; set; }

        public DbSet<CSICP_Bb027Modal> OsusrE9aCsicpBb027Modals { get; set; }

        public DbSet<CSICP_Bb027Motivo> OsusrE9aCsicpBb027Motivos { get; set; }

        public DbSet<CSICP_Bb027Pterc> OsusrE9aCsicpBb027Ptercs { get; set; }

        public DbSet<CSICP_Bb027Sipi> OsusrE9aCsicpBb027Sipis { get; set; }

        public DbSet<CSICP_Bb027aTpcalc> OsusrE9aCsicpBb027aTpcalcs { get; set; }

        public DbSet<CSICP_Bb028Tp> OsusrE9aCsicpBb028Tps { get; set; }

        public DbSet<CSICP_Bb035End> OsusrE9aCsicpBb035Ends { get; set; }

        public DbSet<CSICP_Bb035Gpa> OsusrE9aCsicpBb035Gpas { get; set; }

        public DbSet<CSICP_Bb035Origem> OsusrE9aCsicpBb035Origems { get; set; }

        public DbSet<CSICP_Bb035Trat> OsusrE9aCsicpBb035Trats { get; set; }

        public DbSet<CSICP_Bb036Ender> OsusrE9aCsicpBb036Enders { get; set; }
        partial void OnModelCreatingStaticaBB(ModelBuilder modelBuilder)
        {
            //XX-BB01

            modelBuilder.Entity<CSICP_BB001_Aliqs>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_ALIQ");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_ALIQ");

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

            modelBuilder.Entity<CSICP_BB001_ATPJS>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_ATPJ");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_ATPJ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigofiscal)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGOFISCAL");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Labelgrande)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABELGRANDE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_BB001Capmun>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_CAPMUN");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_CAPMUN");

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

            modelBuilder.Entity<CSICP_BB001Natpj>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_NATPJ");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_NATPJ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigofiscal)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGOFISCAL");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Labelgrande)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABELGRANDE");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_BB001TpTri>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_TPTRI");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_TPTRI");

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

            modelBuilder.Entity<CSICP_BB001Staimg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_STAIMG");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_STAIMG");

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

            //XX-BB12

            modelBuilder.Entity<CSICP_Bb01201Con>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01201_CON");

                entity.ToTable("OSUSR_E9A_CSICP_BB01201_CON");

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

            modelBuilder.Entity<CSICP_Bb01201Jur>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01201_JUR");

                entity.ToTable("OSUSR_E9A_CSICP_BB01201_JUR");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
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

            modelBuilder.Entity<CSICP_Bb01201Tger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01201_TGER");

                entity.ToTable("OSUSR_E9A_CSICP_BB01201_TGER");

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

            modelBuilder.Entity<CSICP_Bb01202Dom>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_DOM");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_DOM");

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

            modelBuilder.Entity<CSICP_Bb01202Eciv>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_ECIV");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_ECIV");

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

            modelBuilder.Entity<CSICP_Bb01202Esc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_ESC");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_ESC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Labelmeucrediario)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABELMEUCREDIARIO");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_Bb01202Ins>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_INS");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_INS");

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

            modelBuilder.Entity<CSICP_Bb01202Ocu>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_OCU");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_OCU");

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

            modelBuilder.Entity<CSICP_Bb01202Res>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_RES");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_RES");

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

            modelBuilder.Entity<CSICP_Bb01202Sex>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202_SEX");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202_SEX");

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

            modelBuilder.Entity<CSICP_Bb012Clacta>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_CLACTA");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_CLACTA");

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

            modelBuilder.Entity<CSICP_Bb012Gructa>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_GRUCTA");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_GRUCTA");

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
                entity.Property(e => e.Usocs)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("USOCS");
            });

            modelBuilder.Entity<CSICP_Bb012Mcred>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_MCRED");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_MCRED");

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

            modelBuilder.Entity<CSICP_Bb012Mrel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_MREL");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_MREL");

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

            modelBuilder.Entity<CSICP_Bb012Sitcta>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_SITCTA");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_SITCTA");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_E9A_CSICP_BB012_SITCTA_5LABEL");

                entity.HasIndex(e => e.Codgcs, "OSIDX_OSUSR_E9A_CSICP_BB012_SITCTA_6CODGCS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
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

            modelBuilder.Entity<CSICP_Bb012Stacta>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_STACTA");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_STACTA");

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

            modelBuilder.Entity<CSICP_Bb012Tpcta>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012_TPCTA");

                entity.ToTable("OSUSR_E9A_CSICP_BB012_TPCTA");

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

            modelBuilder.Entity<CSICP_Bb012jTpend>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012J_TPEND");

                entity.ToTable("OSUSR_E9A_CSICP_BB012J_TPEND");

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

            modelBuilder.Entity<Csicp_Bb012mdc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012MDC");

                entity.ToTable("OSUSR_E9A_CSICP_BB012MDC");

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

            modelBuilder.Entity<Csicp_Bb012mtd>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012MTD");

                entity.ToTable("OSUSR_E9A_CSICP_BB012MTD");

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

            //XX-BB.X
            modelBuilder.Entity<CSICP_Bb006Banco>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB006_BANCO");

                entity.ToTable("OSUSR_E9A_CSICP_BB006_BANCO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Dvbanco)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("DVBANCO");
                entity.Property(e => e.Nomedobanco)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("NOMEDOBANCO");
                entity.Property(e => e.Nrobanco)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("NROBANCO");
                entity.Property(e => e.Paginanainternet)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("PAGINANAINTERNET");
            });

            modelBuilder.Entity<CSICP_Bb008Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB008_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_BB008_TIPO");

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

            modelBuilder.Entity<CSICP_Bb010Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB010_TP");

                entity.ToTable("OSUSR_E9A_CSICP_BB010_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsCodg)
                    .HasDefaultValue(0)
                    .HasColumnName("CS_CODG");
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

            modelBuilder.Entity<CSICP_Bb019Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB019_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_BB019_TIPO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgautorizadora)
                    .HasDefaultValue(0)
                    .HasColumnName("CODGAUTORIZADORA");
                entity.Property(e => e.CodgbandeiraSitef)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("CODGBANDEIRA_SITEF");
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
                entity.Property(e => e.Tband)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("TBAND");
            });

            modelBuilder.Entity<CSICP_Bb026Classe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB026_CLASSE");

                entity.ToTable("OSUSR_E9A_CSICP_BB026_CLASSE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Imagem)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("IMAGEM");
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
                entity.Property(e => e.Tpag)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("TPAG");
                entity.Property(e => e.UrlFormapagto)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("URL_FORMAPAGTO");
                entity.Property(e => e.Usocs)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("USOCS");
            });

            modelBuilder.Entity<CSICP_Bb026Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB026_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_BB026_TIPO");

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

            modelBuilder.Entity<CSICP_Bb026Vin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB026_VIN");

                entity.ToTable("OSUSR_E9A_CSICP_BB026_VIN");

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

            modelBuilder.Entity<CSICP_Bb027Bcalc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_BCALC");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_BCALC");

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

            modelBuilder.Entity<CSICP_Bb027Cicm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_CICMS");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_CICMS");

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

            modelBuilder.Entity<CSICP_Bb027Difer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_DIFER");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_DIFER");

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

            modelBuilder.Entity<CSICP_Bb027Entsai>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_ENTSAI");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_ENTSAI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IdPdv)
                    .HasDefaultValue(0)
                    .HasColumnName("ID_PDV");
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

            modelBuilder.Entity<CSICP_Bb027Fdesen>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_FDESEN");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_FDESEN");

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

            modelBuilder.Entity<CSICP_Bb027Imp>(entity =>
            {
                entity.HasKey(e => e.Bb027bId).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_IMP");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_IMP");

                entity.HasIndex(e => new { e.Bb027cIndpres, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_14BB027C_INDPRES_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bModbcId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_15BB027B_MODBC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bMp255Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_15BB027B_MP255_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bOrigemId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_16BB027B_ORIGEM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bRegimeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_16BB027B_REGIME_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCstIpiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_CST_IPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCstPisId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_CST_PIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bUfDestId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_17BB027B_UF_DEST_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCstIcmsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_18BB027B_CST_ICMS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bImpostosId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_18BB027B_IMPOSTOS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCstCofinsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_20BB027B_CST_COFINS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_21BB027B_CENQUAD_IPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bClassecontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_21BB027B_CLASSECONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bCfopStaticaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_CFOP_STATICA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bFcalcicmsdesId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_FCALCICMSDES_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bNatBcCredPis, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_22BB027B_NAT_BC_CRED_PIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bMotdesoneracaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_23BB027B_MOTDESONERACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bVicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_23BB027B_VICMSDESONSUB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bModalbcIcmsStId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_25BB027B_MODALBC_ICMS_ST_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027bNatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_25BB027B_NAT_BC_CRED_COFINS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_8BB027_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB027_IMP_9TENANT_ID");

                entity.Property(e => e.Bb027bId)
                    .HasMaxLength(36)
                    .HasColumnName("BB027B_ID");
                entity.Property(e => e.Bb027Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ID");
                entity.Property(e => e.Bb027bAliqInternauf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_ALIQ_INTERNAUF");
                entity.Property(e => e.Bb027bAliquota)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("BB027B_ALIQUOTA");
                entity.Property(e => e.Bb027bCbenef)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_CBENEF");
                entity.Property(e => e.Bb027bCenquadIpiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CENQUAD_IPI_ID");
                entity.Property(e => e.Bb027bCfopStaticaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CFOP_STATICA_ID");
                entity.Property(e => e.Bb027bClassecontaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CLASSECONTA_ID");
                entity.Property(e => e.Bb027bCodgcst)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_CODGCST");
                entity.Property(e => e.Bb027bCodgfilial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB027B_CODGFILIAL");
                entity.Property(e => e.Bb027bCodgtransacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB027B_CODGTRANSACAO");
                entity.Property(e => e.Bb027bCstCofinsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CST_COFINS_ID");
                entity.Property(e => e.Bb027bCstIcmsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CST_ICMS_ID");
                entity.Property(e => e.Bb027bCstIpiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CST_IPI_ID");
                entity.Property(e => e.Bb027bCstPisId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_CST_PIS_ID");
                entity.Property(e => e.Bb027bFcalcicmsdesId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_FCALCICMSDES_ID");
                entity.Property(e => e.Bb027bHashid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_HASHID");
                entity.Property(e => e.Bb027bImpostosId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_IMPOSTOS_ID");
                entity.Property(e => e.Bb027bInformacoescofins)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_INFORMACOESCOFINS");
                entity.Property(e => e.Bb027bInformacoesipi)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_INFORMACOESIPI");
                entity.Property(e => e.Bb027bInformacoesnf)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_INFORMACOESNF");
                entity.Property(e => e.Bb027bInformacoespis)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB027B_INFORMACOESPIS");
                entity.Property(e => e.Bb027bIsvicmsdesSubtrai)
                    .HasDefaultValue(false)
                    .HasColumnName("BB027B_ISVICMSDES_SUBTRAI");
                entity.Property(e => e.Bb027bModalbcIcmsStId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_MODALBC_ICMS_ST_ID");
                entity.Property(e => e.Bb027bModbcId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_MODBC_ID");
                entity.Property(e => e.Bb027bMotdesoneracaoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_MOTDESONERACAOID");
                entity.Property(e => e.Bb027bMp255Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_MP255_ID");
                entity.Property(e => e.Bb027bNatBcCredCofins)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_NAT_BC_CRED_COFINS");
                entity.Property(e => e.Bb027bNatBcCredPis)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_NAT_BC_CRED_PIS");
                entity.Property(e => e.Bb027bOrigemId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_ORIGEM_ID");
                entity.Property(e => e.Bb027bPicmsDiferido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027B_PICMS_DIFERIDO");
                entity.Property(e => e.Bb027bPpropocaodestino)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB027B_PPROPOCAODESTINO");
                entity.Property(e => e.Bb027bReducaobase)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027B_REDUCAOBASE");
                entity.Property(e => e.Bb027bReducaobcst)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027B_REDUCAOBCST");
                entity.Property(e => e.Bb027bRegimeId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_REGIME_ID");
                entity.Property(e => e.Bb027bUfDestId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_UF_DEST_ID");
                entity.Property(e => e.Bb027bVicmsdesonsubId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027B_VICMSDESONSUB_ID");
                entity.Property(e => e.Bb027cIndpres)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027C_INDPRES");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.Property(e => e.Bb027bRfclasstribId).HasColumnName("BB027B_RFCLASSTRIB_ID");
                entity.Property(e => e.Bb027bRflcId)
                    .HasMaxLength(36)
                    .HasColumnName("BB027B_RFLC_ID");
                entity.Property(e => e.Bb027bTpdebcreid).HasColumnName("BB027B_TPDEBCREID");
                entity.Property(e => e.Bb027bPaliqefetregIbsUf)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PALIQEFETREG_IBS_UF");
                entity.Property(e => e.Bb027bPaliqefetregIbsMun)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PALIQEFETREG_IBS_MUN");
                entity.Property(e => e.Bb027bPcredpresIbsUf)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PCREDPRES_IBS_UF");
                entity.Property(e => e.Bb027bPcredpresIbsMun)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PCREDPRES_IBS_MUN");
                entity.Property(e => e.Bb027bPcredpresCbs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PCREDPRES_CBS");
                entity.Property(e => e.Bb027bPdifCbs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PDIF_CBS");
                entity.Property(e => e.Bb027bPaliqefetregCbs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PALIQEFETREG_CBS");
                entity.Property(e => e.Bb027bPdifIbs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PDIF_IBS");
                entity.Property(e => e.Bb027bIsRfclasstribId2).HasColumnName("BB027B_IS_RFCLASSTRIB_ID2");
                entity.Property(e => e.Bb027bPreducaoibs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PREDUCAOIBS");
                entity.Property(e => e.Bb027bPreducaocbs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB027B_PREDUCAOCBS");
                entity.Property(e => e.Bb027bCcredpreid).HasColumnName("BB027B_CCREDPREID");

                entity.HasOne(d => d.NavBB027bFcalcicmsdes).WithMany(p => p.OsusrE9aCsicpBb027Imps)
                    .HasForeignKey(d => d.Bb027bFcalcicmsdesId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB027_IMP_OSUSR_E9A_CSICP_BB027_FDESEN_BB027B_FCALCICMSDES_ID");

                //entity.HasOne(d => d.Bb027bModbc).WithMany(p => p.OsusrE9aCsicpBb027Imps)
                  //  .HasForeignKey(d => d.Bb027bModbcId)
                   // .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB027_IMP_OSUSR_E9A_CSICP_BB027_MODAL_BB027B_MODBC_ID");

                //entity.HasOne(d => d.Bb027bMotdesoneracao).WithMany(p => p.OsusrE9aCsicpBb027Imps)
                    //.HasForeignKey(d => d.Bb027bMotdesoneracaoid)
                    //.HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB027_IMP_OSUSR_E9A_CSICP_BB027_MOTIVO_BB027B_MOTDESONERACAOID");
            });

            modelBuilder.Entity<CSICP_Bb027Modal>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_MODAL");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_MODAL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Digito)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("DIGITO");
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

            modelBuilder.Entity<CSICP_Bb027Motivo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_MOTIVO");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_MOTIVO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("CONTEUDO");
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

            modelBuilder.Entity<CSICP_Bb027Pterc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_PTERC");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_PTERC");

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

            modelBuilder.Entity<CSICP_Bb027Sipi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027_SIPI");

                entity.ToTable("OSUSR_E9A_CSICP_BB027_SIPI");

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

            modelBuilder.Entity<CSICP_Bb027aTpcalc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027A_TPCALC");

                entity.ToTable("OSUSR_E9A_CSICP_BB027A_TPCALC");

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

            modelBuilder.Entity<CSICP_Bb028Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB028_TP");

                entity.ToTable("OSUSR_E9A_CSICP_BB028_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("CODG_CS");
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

            modelBuilder.Entity<CSICP_Bb035End>(entity =>
            {
                entity.HasKey(e => e.Bb035Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB035_END");

                entity.ToTable("OSUSR_E9A_CSICP_BB035_END");

                entity.HasIndex(e => new { e.Bb035Contatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_END_15BB035_CONTATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb035CodigoPais, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_END_17BB035_CODIGO_PAIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb035CodigoCidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_END_19BB035_CODIGO_CIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb035Uf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_END_8BB035_UF_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB035_END_9TENANT_ID");

                entity.Property(e => e.Bb035Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB035_ID");
                entity.Property(e => e.Bb035Bairro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_BAIRRO");
                entity.Property(e => e.Bb035Cep)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_CEP");
                entity.Property(e => e.Bb035CodigoCidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_CODIGO_CIDADE");
                entity.Property(e => e.Bb035CodigoPais)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_CODIGO_PAIS");
                entity.Property(e => e.Bb035Complemento)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_COMPLEMENTO");
                entity.Property(e => e.Bb035Contatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_CONTATOID");
                entity.Property(e => e.Bb035Logradouro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_LOGRADOURO");
                entity.Property(e => e.Bb035Numero)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_NUMERO");
                entity.Property(e => e.Bb035Uf)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_UF");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb035Gpa>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB035_GPA");

                entity.ToTable("OSUSR_E9A_CSICP_BB035_GPA");

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

            modelBuilder.Entity<CSICP_Bb035Origem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB035_ORIGEM");

                entity.ToTable("OSUSR_E9A_CSICP_BB035_ORIGEM");

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

            modelBuilder.Entity<CSICP_Bb035Trat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB035_TRAT");

                entity.ToTable("OSUSR_E9A_CSICP_BB035_TRAT");

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

            modelBuilder.Entity<CSICP_Bb036Ender>(entity =>
            {
                entity.HasKey(e => e.Bb036Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB036_ENDER");

                entity.ToTable("OSUSR_E9A_CSICP_BB036_ENDER");

                entity.HasIndex(e => new { e.Bb036Candidatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_ENDER_17BB036_CANDIDATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036CodigoPais, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_ENDER_17BB036_CODIGO_PAIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036CodigoCidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_ENDER_19BB036_CODIGO_CIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036Uf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_ENDER_8BB036_UF_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB036_ENDER_9TENANT_ID");

                entity.Property(e => e.Bb036Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB036_ID");
                entity.Property(e => e.Bb036Bairro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_BAIRRO");
                entity.Property(e => e.Bb036Candidatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_CANDIDATOID");
                entity.Property(e => e.Bb036Cep)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_CEP");
                entity.Property(e => e.Bb036CodigoCidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_CODIGO_CIDADE");
                entity.Property(e => e.Bb036CodigoPais)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_CODIGO_PAIS");
                entity.Property(e => e.Bb036Complemento)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_COMPLEMENTO");
                entity.Property(e => e.Bb036Logradouro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_LOGRADOURO");
                entity.Property(e => e.Bb036Numero)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_NUMERO");
                entity.Property(e => e.Bb036Uf)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_UF");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

        }
    }
}
