using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_FF000Basecalc> OsusrE9aCsicpFf000Basecalcs { get; set; }

        public DbSet<OsusrE9aCsicpFf000Envapi> OsusrE9aCsicpFf000Envapis { get; set; }

        public DbSet<OsusrE9aCsicpFf000Fbx> OsusrE9aCsicpFf000Fbxes { get; set; }

        public DbSet<OsusrE9aCsicpFf003Tpesp> OsusrE9aCsicpFf003Tpesps { get; set; }

        public DbSet<OsusrE9aCsicpFf006Stum> OsusrE9aCsicpFf006Sta { get; set; }

        public DbSet<OsusrE9aCsicpFf016Email> OsusrE9aCsicpFf016Emails { get; set; }


        public DbSet<OsusrE9aCsicpFf020Emirec> OsusrE9aCsicpFf020Emirecs { get; set; }

        public DbSet<OsusrE9aCsicpFf021Sit> OsusrE9aCsicpFf021Sits { get; set; }

        public DbSet<OsusrE9aCsicpFf030Sit> OsusrE9aCsicpFf030Sits { get; set; }
        public DbSet<OsusrE9aCsicpFf002Mod> OsusrE9aCsicpF002Mod { get; set; }

        public DbSet<OsusrE9aCsicpFf032Stum> OsusrE9aCsicpFf032Sta { get; set; }

        public DbSet<OsusrE9aCsicpFf040Sit> OsusrE9aCsicpFf040Sits { get; set; }

        public DbSet<CSICP_FF102Adt> OsusrE9aCsicpFf102Adts { get; set; }

        public DbSet<CSICP_FF102ApiBanco> OsusrE9aCsicpFf102ApiBancos { get; set; }

        public DbSet<CSICP_FF102Aut> OsusrE9aCsicpFf102Auts { get; set; }

        public DbSet<CSICP_FF102_C018> OsusrE9aCsicpFf102C018s { get; set; }

        public DbSet<CSICP_FF102_C021> OsusrE9aCsicpFf102C021s { get; set; }

        public DbSet<CSICP_FF102Cob> OsusrE9aCsicpFf102Cobs { get; set; }

        public DbSet<CSICP_FF102Des> OsusrE9aCsicpFf102Des { get; set; }

        public DbSet<CSICP_FF102Ent> OsusrE9aCsicpFf102Ents { get; set; }

        public DbSet<CSICP_FF102_G073> OsusrE9aCsicpFf102G073s { get; set; }

        public DbSet<CSICP_FF102Sit> OsusrE9aCsicpFf102Sits { get; set; }

        public DbSet<OsusrE9aCsicpFf103Msg> OsusrE9aCsicpFf103Msgs { get; set; }

        public DbSet<OsusrE9aCsicpFf103Tpbai> OsusrE9aCsicpFf103Tpbais { get; set; }

        public DbSet<OsusrE9aCsicpFf105Status> OsusrE9aCsicpFf105Statuses { get; set; }

        public DbSet<OsusrE9aCsicpFf105Statusapi> OsusrE9aCsicpFf105Statusapis { get; set; }

        public DbSet<OsusrE9aCsicpFf107Acr> OsusrE9aCsicpFf107Acrs { get; set; }

        public DbSet<OsusrE9aCsicpFf107Vc> OsusrE9aCsicpFf107Vcs { get; set; }

        public DbSet<OsusrE9aCsicpFf110Sit> OsusrE9aCsicpFf110Sits { get; set; }

        public DbSet<OsusrE9aCsicpFf112C004> OsusrE9aCsicpFf112C004s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C006> OsusrE9aCsicpFf112C006s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C007> OsusrE9aCsicpFf112C007s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C008> OsusrE9aCsicpFf112C008s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C009> OsusrE9aCsicpFf112C009s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C010> OsusrE9aCsicpFf112C010s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C026> OsusrE9aCsicpFf112C026s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C028> OsusrE9aCsicpFf112C028s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C029> OsusrE9aCsicpFf112C029s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C044> OsusrE9aCsicpFf112C044s { get; set; }

        public DbSet<OsusrE9aCsicpFf112C047a> OsusrE9aCsicpFf112C047as { get; set; }

        public DbSet<OsusrE9aCsicpFf112C047b> OsusrE9aCsicpFf112C047bs { get; set; }

        public DbSet<OsusrE9aCsicpFf112C047c> OsusrE9aCsicpFf112C047cs { get; set; }

        public DbSet<OsusrE9aCsicpFf112Cnab> OsusrE9aCsicpFf112Cnabs { get; set; }

        public DbSet<OsusrE9aCsicpFf112G005> OsusrE9aCsicpFf112G005s { get; set; }

        public DbSet<OsusrE9aCsicpFf112G025> OsusrE9aCsicpFf112G025s { get; set; }

        public DbSet<OsusrE9aCsicpFf112G028> OsusrE9aCsicpFf112G028s { get; set; }

        public DbSet<OsusrE9aCsicpFf112OrgNeg> OsusrE9aCsicpFf112OrgNegs { get; set; }

        public DbSet<OsusrE9aCsicpFf112Reg> OsusrE9aCsicpFf112Regs { get; set; }

        public DbSet<CSICP_FF112ApiBaixa> OsusrE9aCsicpFf112apiBaixas { get; set; }

        public DbSet<CSICP_FF112ApiLiquidacao> OsusrE9aCsicpFf112apiLiquidacaos { get; set; }

        public DbSet<CSICP_FF112ApiOcorrencium> OsusrE9aCsicpFf112apiOcorrencia { get; set; }

        public DbSet<OsusrE9aCsicpFf113Tipo> OsusrE9aCsicpFf113Tipos { get; set; }

        public DbSet<OsusrE9aCsicpFf116Tmov> OsusrE9aCsicpFf116Tmovs { get; set; }

        public DbSet<OsusrE9aCsicpFf118Nivel> OsusrE9aCsicpFf118Nivels { get; set; }

        public DbSet<OsusrE9aCsicpFf118Stat> OsusrE9aCsicpFf118Stats { get; set; }

        public DbSet<CSICP_FF120TrackApi> OsusrE9aCsicpFf120Trackapis { get; set; }

        public DbSet<OsusrE9aCsicpFf125Stat> OsusrE9aCsicpFf125Stats { get; set; }

        public DbSet<OsusrE9aCsicpFf135Status> OsusrE9aCsicpFf135Statuses { get; set; }

        public DbSet<OsusrE9aCsicpFf136St> OsusrE9aCsicpFf136Sts { get; set; }

        public DbSet<OsusrE9aCsicpFf136Tmov> OsusrE9aCsicpFf136Tmovs { get; set; }

        public DbSet<OsusrE9aCsicpFf140Exe> OsusrE9aCsicpFf140Exes { get; set; }

        public DbSet<OsusrE9aCsicpFf140Stum> OsusrE9aCsicpFf140Sta { get; set; }

        public DbSet<OsusrE9aCsicpFf140Vin> OsusrE9aCsicpFf140Vins { get; set; }

        public DbSet<OsusrE9aCsicpFf16Tagcar> OsusrE9aCsicpFf16Tagcars { get; set; }

        public DbSet<OsusrE9aCsicpFf996Stum> OsusrE9aCsicpFf996Sta { get; set; }
        partial void OnModelCreatingStaticaFF(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_FF000Basecalc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF000_BASECALC");

                entity.ToTable("OSUSR_E9A_CSICP_FF000_BASECALC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf000Envapi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF000_ENVAPI");

                entity.ToTable("OSUSR_E9A_CSICP_FF000_ENVAPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf000Fbx>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF000_FBX");

                entity.ToTable("OSUSR_E9A_CSICP_FF000_FBX");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf002Mod>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF002_MOD");

                entity.ToTable("OSUSR_E9A_CSICP_FF002_MOD");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf003Tpesp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF003_TPESP");

                entity.ToTable("OSUSR_E9A_CSICP_FF003_TPESP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IdPdv).HasColumnName("ID_PDV");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf006Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF006_STA");

                entity.ToTable("OSUSR_E9A_CSICP_FF006_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasMaxLength(10)
                    .HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf016Email>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF016_EMAILS");

                entity.ToTable("OSUSR_E9A_CSICP_FF016_EMAILS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf020Emirec>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF020_EMIREC");

                entity.ToTable("OSUSR_E9A_CSICP_FF020_EMIREC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf021Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF021_SIT");

                entity.ToTable("OSUSR_E9A_CSICP_FF021_SIT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf030Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF030_SIT");

                entity.ToTable("OSUSR_E9A_CSICP_FF030_SIT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf032Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF032_STA");

                entity.ToTable("OSUSR_E9A_CSICP_FF032_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf040Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF040_SIT");

                entity.ToTable("OSUSR_E9A_CSICP_FF040_SIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Adt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_ADT");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_ADT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102ApiBanco>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_API_BANCO");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_API_BANCO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Aut>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_AUT");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_AUT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsLabelRpt)
                    .HasMaxLength(50)
                    .HasColumnName("CS_LABEL_RPT");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102_C018>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_C018");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_C018");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102_C021>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_C021");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_C021");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Cob>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_COB");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_COB");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Des>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_DES");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_DES");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Ent>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_ENT");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102_G073>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_G073");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_G073");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF102Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF102_SIT");

                entity.ToTable("OSUSR_E9A_CSICP_FF102_SIT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf103Msg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF103_MSG");

                entity.ToTable("OSUSR_E9A_CSICP_FF103_MSG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf103Tpbai>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF103_TPBAI");

                entity.ToTable("OSUSR_E9A_CSICP_FF103_TPBAI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf105Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF105_STATUS");

                entity.ToTable("OSUSR_E9A_CSICP_FF105_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf105Statusapi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF105_STATUSAPI");

                entity.ToTable("OSUSR_E9A_CSICP_FF105_STATUSAPI");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });


            modelBuilder.Entity<OsusrE9aCsicpFf107Acr>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF107_ACR");

                entity.ToTable("OSUSR_E9A_CSICP_FF107_ACR");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf107Vc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF107_VC");

                entity.ToTable("OSUSR_E9A_CSICP_FF107_VC");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf110Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF110_SIT");

                entity.ToTable("OSUSR_E9A_CSICP_FF110_SIT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C004>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C004");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C004");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcnab)
                    .HasMaxLength(50)
                    .HasColumnName("CODGCNAB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C006");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C006");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ContBb)
                    .HasMaxLength(50)
                    .HasColumnName("CONT_BB");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C007");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C007");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C008>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C008");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C008");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C009>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C009");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C009");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C010>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C010");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C010");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C026>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C026");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C026");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Santander)
                    .HasMaxLength(10)
                    .HasColumnName("SANTANDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C028>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C028");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C028");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C029>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C029");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C029");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(10)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C044>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C044");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C044");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcnab)
                    .HasMaxLength(50)
                    .HasColumnName("CODGCNAB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tabc047)
                    .HasMaxLength(10)
                    .HasColumnName("TABC047");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C047a>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C047A");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C047A");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcnab)
                    .HasMaxLength(2)
                    .HasColumnName("CODGCNAB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C047b>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C047B");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C047B");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcnab)
                    .HasMaxLength(2)
                    .HasColumnName("CODGCNAB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112C047c>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_C047C");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_C047C");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcnab)
                    .HasMaxLength(2)
                    .HasColumnName("CODGCNAB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(150)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112Cnab>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_CNAB");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_CNAB");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112G005>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_G005");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_G005");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112G025>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_G025");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_G025");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112G028>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_G028");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_G028");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Conteudo)
                    .HasMaxLength(50)
                    .HasColumnName("CONTEUDO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112OrgNeg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_ORG_NEG");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_ORG_NEG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgBb)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_BB");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf112Reg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112_REG");

                entity.ToTable("OSUSR_E9A_CSICP_FF112_REG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.TipoRegistro).HasColumnName("TIPO_REGISTRO");
            });

            modelBuilder.Entity<CSICP_FF112ApiBaixa>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112API_BAIXA");

                entity.ToTable("OSUSR_E9A_CSICP_FF112API_BAIXA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.BancoApi).HasColumnName("BANCO_API");
                entity.Property(e => e.CodgBaixa)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_BAIXA");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF112ApiLiquidacao>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112API_LIQUIDACAO");

                entity.ToTable("OSUSR_E9A_CSICP_FF112API_LIQUIDACAO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.BancoApi).HasColumnName("BANCO_API");
                entity.Property(e => e.CodgLiquidacao)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_LIQUIDACAO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF112ApiOcorrencium>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF112API_OCORRENCIA");

                entity.ToTable("OSUSR_E9A_CSICP_FF112API_OCORRENCIA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.BancoApi).HasColumnName("BANCO_API");
                entity.Property(e => e.CodgOcorrencia)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_OCORRENCIA");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf113Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF113_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_FF113_TIPO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf116Tmov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF116_TMOV");

                entity.ToTable("OSUSR_E9A_CSICP_FF116_TMOV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf118Nivel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF118_NIVEL");

                entity.ToTable("OSUSR_E9A_CSICP_FF118_NIVEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf118Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF118_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_FF118_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_FF120TrackApi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF120_TRACKAPI");

                entity.ToTable("OSUSR_E9A_CSICP_FF120_TRACKAPI");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf125Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF125_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_FF125_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf135Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF135_STATUS");

                entity.ToTable("OSUSR_E9A_CSICP_FF135_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf136St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF136_ST");

                entity.ToTable("OSUSR_E9A_CSICP_FF136_ST");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf136Tmov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF136_TMOV");

                entity.ToTable("OSUSR_E9A_CSICP_FF136_TMOV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf140Exe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF140_EXE");

                entity.ToTable("OSUSR_E9A_CSICP_FF140_EXE");

                entity.HasIndex(e => e.Codgcs, "OSIDX_OSUSR_E9A_CSICP_FF140_EXE_6CODGCS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf140Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF140_STA");

                entity.ToTable("OSUSR_E9A_CSICP_FF140_STA");

                entity.HasIndex(e => e.Codgcs, "OSIDX_OSUSR_E9A_CSICP_FF140_STA_6CODGCS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf140Vin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF140_VIN");

                entity.ToTable("OSUSR_E9A_CSICP_FF140_VIN");

                entity.HasIndex(e => e.Codgcs, "OSIDX_OSUSR_E9A_CSICP_FF140_VIN_6CODGCS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf16Tagcar>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF16_TAGCAR");

                entity.ToTable("OSUSR_E9A_CSICP_FF16_TAGCAR");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpFf996Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_FF996_STA");

                entity.ToTable("OSUSR_E9A_CSICP_FF996_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });
        }
    }
}
