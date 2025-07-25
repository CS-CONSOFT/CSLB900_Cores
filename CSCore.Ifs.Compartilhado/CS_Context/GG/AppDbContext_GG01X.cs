using CSCore.Domain.CS_Models.CSICP_GG;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG010> OsusrE9aCsicpGg010s { get; set; }

        public DbSet<CSICP_GG011> OsusrE9aCsicpGg011s { get; set; }

        public DbSet<CSICP_GG013> OsusrE9aCsicpGg013s { get; set; }

        public DbSet<CSICP_GG014> OsusrE9aCsicpGg014s { get; set; }

        public DbSet<CSICP_GG015> OsusrE9aCsicpGg015s { get; set; }

        public DbSet<CSICP_GG016> OsusrE9aCsicpGg016s { get; set; }

        public DbSet<CSICP_GG016b> OsusrE9aCsicpGg016bs { get; set; }

        public DbSet<CSICP_GG016e> OsusrE9aCsicpGg016es { get; set; }

        public DbSet<CSICP_GG016f> OsusrE9aCsicpGg016fs { get; set; }

        public DbSet<CSICP_GG017> OsusrE9aCsicpGg017s { get; set; }

        public DbSet<OsusrE9aCsicpGg018> OsusrE9aCsicpGg018s { get; set; }

        public DbSet<CSICP_GG019> OsusrE9aCsicpGg019s { get; set; }

        partial void OnModelCreating_CSICP_GG01X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_GG010>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG010");

                entity.ToTable("OSUSR_E9A_CSICP_GG010");

                entity.HasIndex(e => new { e.Gg010Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG010_14GG010_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg010Descricaotipopadrao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG010_25GG010_DESCRICAOTIPOPADRAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG010_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg010CodigoTipopadrao)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG010_CODIGO_TIPOPADRAO");
                entity.Property(e => e.Gg010Descricaotipopadrao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG010_DESCRICAOTIPOPADRAO");
                entity.Property(e => e.Gg010Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG010_FILIAL");
                entity.Property(e => e.Gg010Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG010_FILIALID");
                entity.Property(e => e.Gg010IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG010_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavFilial).WithOne().HasForeignKey<CSICP_GG010>(e => e.Gg010Filialid);
            });

            modelBuilder.Entity<CSICP_GG011>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG011");

                entity.ToTable("OSUSR_E9A_CSICP_GG011");

                entity.HasIndex(e => new { e.Gg011Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG011_14GG011_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg011Descricaoqualidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG011_24GG011_DESCRICAOQUALIDADE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG011_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg011CodigoQualidade)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG011_CODIGO_QUALIDADE");
                entity.Property(e => e.Gg011Descricaoqualidade)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG011_DESCRICAOQUALIDADE");
                entity.Property(e => e.Gg011Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG011_FILIAL");
                entity.Property(e => e.Gg011Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG011_FILIALID");
                entity.Property(e => e.Gg011IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG011_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavFilial).WithOne().HasForeignKey<CSICP_GG011>(e => e.Gg011Filialid);
            });

            modelBuilder.Entity<CSICP_GG013>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG013");

                entity.ToTable("OSUSR_E9A_CSICP_GG013");

                entity.HasIndex(e => new { e.Gg013Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG013_14GG013_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG013_2ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG013_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg013Aplicacao)
                    .HasDefaultValue("")
                    .HasColumnName("GG013_APLICACAO");
                entity.Property(e => e.Gg013Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG013_FILIAL");
                entity.Property(e => e.Gg013Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG013_FILIALID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.Nav_GG008).WithOne().HasForeignKey<CSICP_GG013>(e => e.Id);

            });

            modelBuilder.Entity<CSICP_GG014>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG014");

                entity.ToTable("OSUSR_E9A_CSICP_GG014");

                entity.HasIndex(e => new { e.Gg014Linha, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG014_11GG014_LINHA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg014Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG014_14GG014_FILIALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG014_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg014Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG014_FILIALID");
                entity.Property(e => e.Gg014IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG014_IS_ACTIVE");
                entity.Property(e => e.Gg014Linha)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG014_LINHA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(d => d.NavFilialBB001).WithOne().HasForeignKey<CSICP_GG014>(d => d.Gg014Filialid);
            });

            modelBuilder.Entity<CSICP_GG015>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG015");

                entity.ToTable("OSUSR_E9A_CSICP_GG015");

                entity.HasIndex(e => new { e.Gg015Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG015_14GG015_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg015Subgrupo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG015_14GG015_SUBGRUPO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG015_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg015Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG015_FILIALID");
                entity.Property(e => e.Gg015IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG015_IS_ACTIVE");
                entity.Property(e => e.Gg015Subgrupo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG015_SUBGRUPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_GG016>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG016");

                entity.ToTable("OSUSR_E9A_CSICP_GG016");

                entity.HasIndex(e => new { e.Gg016Filial, e.Gg016Grade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016_12GG016_FILIAL_11GG016_GRADE_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg016Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016_14GG016_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg016Lincolid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016_14GG016_LINCOLID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG016_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg016Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG016_DESCRICAO");
                entity.Property(e => e.Gg016Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG016_FILIAL");
                entity.Property(e => e.Gg016Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016_FILIALID");
                entity.Property(e => e.Gg016Grade)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG016_GRADE");
                entity.Property(e => e.Gg016Ismarcado)
                    .HasDefaultValue(false)
                    .HasColumnName("GG016_ISMARCADO");
                entity.Property(e => e.Gg016Lincolid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016_LINCOLID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavFilialBB001).WithOne().HasForeignKey<CSICP_GG016>(e => e.Gg016Filialid);
                entity.HasOne(e => e.NavCSICP_GG016b).WithOne().HasForeignKey<CSICP_GG016>(e => e.Gg016Lincolid);
            });

            modelBuilder.Entity<CSICP_GG016b>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG016B");

                entity.ToTable("OSUSR_E9A_CSICP_GG016B");

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

            modelBuilder.Entity<CSICP_GG016e>(entity =>
            {
                entity.HasKey(e => e.Gg016eId).HasName("OSPRK_OSUSR_E9A_CSICP_GG016E");

                entity.ToTable("OSUSR_E9A_CSICP_GG016E");

                entity.HasIndex(e => new { e.Gg016eUsuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016E_20GG016E_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG016E_9TENANT_ID");

                entity.Property(e => e.Gg016eId).HasColumnName("GG016E_ID");
                entity.Property(e => e.Gg016eDescricao)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG016E_DESCRICAO");
                entity.Property(e => e.Gg016eDregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG016E_DREGISTRO");
                entity.Property(e => e.Gg016eUsuariopropid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016E_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(d => d.NavProprietarioSY001).WithOne().HasForeignKey<CSICP_GG016e>(d => d.Gg016eUsuariopropid);
            });

            modelBuilder.Entity<CSICP_GG016f>(entity =>
            {
                entity.HasKey(e => e.Gg016fId).HasName("OSPRK_OSUSR_E9A_CSICP_GG016F");

                entity.ToTable("OSUSR_E9A_CSICP_GG016F");

                entity.HasIndex(e => new { e.Gg016fGradelinhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016F_19GG016F_GRADELINHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg016fGradecolunaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016F_20GG016F_GRADECOLUNAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg016eId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG016F_9GG016E_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG016F_9TENANT_ID");

                entity.Property(e => e.Gg016fId).HasColumnName("GG016F_ID");
                entity.Property(e => e.Gg016eId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016E_ID");
                entity.Property(e => e.Gg016fGradecolunaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016F_GRADECOLUNAID");
                entity.Property(e => e.Gg016fGradelinhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG016F_GRADELINHAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavGg016fGradecoluna).WithOne().HasForeignKey<CSICP_GG016f>(d => d.Gg016fGradecolunaid).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(d => d.NavGg016fGradelinha).WithOne().HasForeignKey<CSICP_GG016f>(d => d.Gg016fGradelinhaid).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CSICP_GG017>(entity =>
            {
                entity.HasKey(e => e.Gg017Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG017");

                entity.ToTable("OSUSR_E9A_CSICP_GG017");

                entity.HasIndex(e => new { e.Gg017CategoriapaiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG017_21GG017_CATEGORIAPAI_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG017_9TENANT_ID");

                entity.Property(e => e.Gg017Id).HasColumnName("GG017_ID");
                entity.Property(e => e.Gg017CategoriapaiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG017_CATEGORIAPAI_ID");
                entity.Property(e => e.Gg017Desccategoria)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG017_DESCCATEGORIA");
                entity.Property(e => e.Gg017Nivel)
                    .HasDefaultValue(0)
                    .HasColumnName("GG017_NIVEL");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavGg017Categoriapai).WithOne().HasForeignKey<CSICP_GG017>(d => d.Gg017CategoriapaiId);
            });

            modelBuilder.Entity<OsusrE9aCsicpGg018>(entity =>
            {
                entity.HasKey(e => e.Gg018Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG018");

                entity.ToTable("OSUSR_E9A_CSICP_GG018");

                entity.HasIndex(e => new { e.Gg017Categoriaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG018_17GG017_CATEGORIAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG018_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG018_9TENANT_ID");

                entity.Property(e => e.Gg018Id).HasColumnName("GG018_ID");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.Gg017Categoriaid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG017_CATEGORIAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                //entity.HasOne(d => d.Gg017Categoria).WithMany(p => p.OsusrE9aCsicpGg018s)
                //    .HasForeignKey(d => d.Gg017Categoriaid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG018_OSUSR_E9A_CSICP_GG017_GG017_CATEGORIAID");
            });

            modelBuilder.Entity<CSICP_GG019>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG019");

                entity.ToTable("OSUSR_E9A_CSICP_GG019");

                entity.HasIndex(e => new { e.Gg019Unid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_10GG019_UNID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_14GG019_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_15GG019_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019ConversaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_18GG019_CONVERSAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019Codbarrasalfa, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_19GG019_CODBARRASALFA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019CodigoBarras, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_19GG019_CODIGO_BARRAS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg019TipocbarraId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG019_19GG019_TIPOCBARRA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG019_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg019Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_CODBARRASALFA");
                entity.Property(e => e.Gg019CodigoBarras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG019_CODIGO_BARRAS");
                entity.Property(e => e.Gg019CodigoColuna)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_CODIGO_COLUNA");
                entity.Property(e => e.Gg019CodigoLinha)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_CODIGO_LINHA");
                entity.Property(e => e.Gg019ConversaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_CONVERSAO_ID");
                entity.Property(e => e.Gg019FatorConversao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(13, 8)")
                    .HasColumnName("GG019_FATOR_CONVERSAO");
                entity.Property(e => e.Gg019Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG019_FILIAL");
                entity.Property(e => e.Gg019Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_FILIALID");
                entity.Property(e => e.Gg019Isimpetq)
                    .HasDefaultValue(false)
                    .HasColumnName("GG019_ISIMPETQ");
                entity.Property(e => e.Gg019Item)
                    .HasDefaultValue(0)
                    .HasColumnName("GG019_ITEM");
                entity.Property(e => e.Gg019KeysldId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_KEYSLD_ID");
                entity.Property(e => e.Gg019Lote)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_LOTE");
                entity.Property(e => e.Gg019Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_PRODUTOID");
                entity.Property(e => e.Gg019SubLote)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_SUB_LOTE");
                entity.Property(e => e.Gg019TipocbarraId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_TIPOCBARRA_ID");
                entity.Property(e => e.Gg019Unid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG019_UNID");
                entity.Property(e => e.Gg019Unidade)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG019_UNIDADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavGG08Conversao).WithOne().HasForeignKey<CSICP_GG019>(d => d.Gg019ConversaoId);
                entity.HasOne(d => d.NavGg007Un).WithOne().HasForeignKey<CSICP_GG019>(d => d.Gg019Unid);

                entity.HasOne(d => d.NavGg019Tipocbarra).WithOne().HasForeignKey<CSICP_GG019>(d => d.Gg019TipocbarraId);

            });

        }
    }

}
