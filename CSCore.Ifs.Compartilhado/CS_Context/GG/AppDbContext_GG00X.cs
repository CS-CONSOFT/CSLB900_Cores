using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG001> CSICP_GG001s { get; set; }
        public DbSet<CSICP_GG000> OsusrE9aCsicpGg000s { get; set; }
        public DbSet<CSICP_GG002> OsusrE9aCsicpGg002s { get; set; }

        public DbSet<CSICP_GG003> OsusrE9aCsicpGg003s { get; set; }

        public DbSet<CSICP_GG004> OsusrE9aCsicpGg004s { get; set; }

        public DbSet<CSICP_GG005> OsusrE9aCsicpGg005s { get; set; }

        public DbSet<CSICP_GG006> OsusrE9aCsicpGg006s { get; set; }

        public DbSet<CSICP_GG007> OsusrE9aCsicpGg007s { get; set; }
        public DbSet<CSICP_GG008> OsusrE9aCsicpGg008s { get; set; }

        public DbSet<CSICP_GG008Kdx> OsusrE9aCsicpGg008Kdxes { get; set; }

        public DbSet<CSICP_GG008a> OsusrE9aCsicpGg008as { get; set; }

        public DbSet<CSICP_GG008b> OsusrE9aCsicpGg008bs { get; set; }

        public DbSet<CSICP_GG008c> OsusrE9aCsicpGg008cs { get; set; }



        public DbSet<CSICP_GG008e> OsusrE9aCsicpGg008es { get; set; }

        public DbSet<CSICP_GG008i> OsusrE9aCsicpGg008is { get; set; }

        public DbSet<CSICP_GG008p> OsusrE9aCsicpGg008ps { get; set; }

        public DbSet<CSICP_GG009> OsusrE9aCsicpGg009s { get; set; }
        partial void OnModelCreating_CSICP_GG001(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_GG001>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG001");

                entity.ToTable("OSUSR_E9A_CSICP_GG001");

                entity.HasIndex(e => new { e.Gg001Filialid, e.Gg001Codigoalmox, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG001_14GG001_FILIALID_17GG001_CODIGOALMOX_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg001Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG001_14GG001_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg001Descalmox, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG001_15GG001_DESCALMOX_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg001Tipoalmoxarifado, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG001_22GG001_TIPOALMOXARIFADO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG001_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg001Caparmaz)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG001_CAPARMAZ");
                entity.Property(e => e.Gg001Codigoalmox)
                    .HasDefaultValue(0)
                    .HasColumnName("GG001_CODIGOALMOX");
                entity.Property(e => e.Gg001Descalmox)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG001_DESCALMOX");
                entity.Property(e => e.Gg001Descnspadrao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG001_DESCNSPADRAO");
                entity.Property(e => e.Gg001Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG001_FILIAL");
                entity.Property(e => e.Gg001Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG001_FILIALID");
                entity.Property(e => e.Gg001Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG001_ISACTIVE");
                entity.Property(e => e.Gg001RiControlequalidade)
                    .HasDefaultValue(false)
                    .HasColumnName("GG001_RI_CONTROLEQUALIDADE");
                entity.Property(e => e.Gg001Tipoalmoxarifado)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG001_TIPOALMOXARIFADO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Gg001TipoalmoxarifadoNavigation).WithOne()
                    .HasForeignKey<CSICP_GG001>(d => d.Gg001Tipoalmoxarifado);

                entity.HasOne(d => d.BB001FilialNav).WithOne()
                   .HasForeignKey<CSICP_GG001>(d => d.Gg001Filialid);
            });

            modelBuilder.Entity<CSICP_GG000>(entity =>
            {
                entity.HasKey(e => e.Gg000Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG000");

                entity.ToTable("OSUSR_E9A_CSICP_GG000");

                entity.HasIndex(e => new { e.Gg000AltUsuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG000_19GG000_ALT_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG000_9TENANT_ID");

                entity.Property(e => e.Gg000Id).HasColumnName("GG000_ID");
                entity.Property(e => e.Gg000AltData)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG000_ALT_DATA");
                entity.Property(e => e.Gg000AltUsuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG000_ALT_USUARIOID");
                entity.Property(e => e.Gg000AwsBucket)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG000_AWS_BUCKET");
                entity.Property(e => e.Gg000Awsaccesskeyid)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG000_AWSACCESSKEYID");
                entity.Property(e => e.Gg000Awsregion)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG000_AWSREGION");
                entity.Property(e => e.Gg000Awssecretaccesskey)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG000_AWSSECRETACCESSKEY");
                entity.Property(e => e.Gg000Diltregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG000_DILTREGISTRO");
                entity.Property(e => e.Gg000Ultcodigo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG000_ULTCODIGO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });



            modelBuilder.Entity<CSICP_GG002>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG002");

                entity.ToTable("OSUSR_E9A_CSICP_GG002");

                entity.HasIndex(e => new { e.Gg002Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG002_14GG002_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg002TipoprodId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG002_17GG002_TIPOPROD_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg002PermiteVendas, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG002_20GG002_PERMITE_VENDAS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg002Desctipoproduto, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG002_21GG002_DESCTIPOPRODUTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg002PermiteCompras, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG002_21GG002_PERMITE_COMPRAS_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG002_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg002Desctipoproduto)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG002_DESCTIPOPRODUTO");
                entity.Property(e => e.Gg002Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG002_FILIAL");
                entity.Property(e => e.Gg002Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG002_FILIALID");
                entity.Property(e => e.Gg002Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG002_ISACTIVE");
                entity.Property(e => e.Gg002PermiteCompras)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG002_PERMITE_COMPRAS");
                entity.Property(e => e.Gg002PermiteVendas)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG002_PERMITE_VENDAS");
                entity.Property(e => e.Gg002TipoprodId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG002_TIPOPROD_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavSpedTipoItem).WithOne().HasForeignKey<CSICP_GG002>(e => e.Gg002TipoprodId);
            });

            modelBuilder.Entity<CSICP_GG003>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG003");

                entity.ToTable("OSUSR_E9A_CSICP_GG003");

                entity.HasIndex(e => new { e.Gg003Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG003_14GG003_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg003Descgrupo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG003_15GG003_DESCGRUPO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG003_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg003Codigogrupo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG003_CODIGOGRUPO");
                entity.Property(e => e.Gg003Descgrupo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG003_DESCGRUPO");
                entity.Property(e => e.Gg003Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG003_FILIAL");
                entity.Property(e => e.Gg003Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG003_FILIALID");
                entity.Property(e => e.Gg003Iconegrupoproduto)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG003_ICONEGRUPOPRODUTO");
                entity.Property(e => e.Gg003Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG003_ISACTIVE");
                entity.Property(e => e.Gg003Isexibepdv)
                    .HasDefaultValue(false)
                    .HasColumnName("GG003_ISEXIBEPDV");
                entity.Property(e => e.Gg003Isvisivelcompra)
                    .HasDefaultValue(false)
                    .HasColumnName("GG003_ISVISIVELCOMPRA");
                entity.Property(e => e.Gg003Isvisivelvenda)
                    .HasDefaultValue(false)
                    .HasColumnName("GG003_ISVISIVELVENDA");
                entity.Property(e => e.Gg003Ordemconsulta)
                    .HasDefaultValue(0)
                    .HasColumnName("GG003_ORDEMCONSULTA");
                entity.Property(e => e.Gg003Plucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG003_PLUCRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_GG004>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG004");

                entity.ToTable("OSUSR_E9A_CSICP_GG004");

                entity.HasIndex(e => new { e.Gg004Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG004_14GG004_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg004Descclasse, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG004_16GG004_DESCCLASSE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG004_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg004Codigoclasse)
                    .HasDefaultValue(0)
                    .HasColumnName("GG004_CODIGOCLASSE");
                entity.Property(e => e.Gg004Descclasse)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG004_DESCCLASSE");
                entity.Property(e => e.Gg004Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG004_FILIAL");
                entity.Property(e => e.Gg004Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG004_FILIALID");
                entity.Property(e => e.Gg004Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG004_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBB001Filial).WithOne().HasForeignKey<CSICP_GG004>(e => e.Gg004Filialid);
            });

            modelBuilder.Entity<CSICP_GG005>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG005");

                entity.ToTable("OSUSR_E9A_CSICP_GG005");

                entity.HasIndex(e => new { e.Gg005Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG005_14GG005_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg005Descartigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG005_16GG005_DESCARTIGO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG005_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg005Codigoartigo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG005_CODIGOARTIGO");
                entity.Property(e => e.Gg005Descartigo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG005_DESCARTIGO");
                entity.Property(e => e.Gg005Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG005_FILIAL");
                entity.Property(e => e.Gg005Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG005_FILIALID");
                entity.Property(e => e.Gg005Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG005_ISACTIVE");
                entity.Property(e => e.Gg005PesoLe)
                    .HasMaxLength(12)
                    .HasDefaultValue("")
                    .HasColumnName("GG005_PESO_LE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBB001Estabelecimento).WithOne().HasForeignKey<CSICP_GG005>(e => e.Gg005Filialid);
            });

            modelBuilder.Entity<CSICP_GG006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG006");

                entity.ToTable("OSUSR_E9A_CSICP_GG006");

                entity.HasIndex(e => new { e.Gg006Filial, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG006_12GG006_FILIAL_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg006Descmarca, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG006_15GG006_DESCMARCA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG006_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg006Codgfilial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG006_CODGFILIAL");
                entity.Property(e => e.Gg006Codigomarca)
                    .HasDefaultValue(0)
                    .HasColumnName("GG006_CODIGOMARCA");
                entity.Property(e => e.Gg006Descmarca)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG006_DESCMARCA");
                entity.Property(e => e.Gg006Filial)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG006_FILIAL");
                entity.Property(e => e.Gg006IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG006_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_GG007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG007");

                entity.ToTable("OSUSR_E9A_CSICP_GG007");

                entity.HasIndex(e => new { e.Gg007Filialid, e.Gg007Unidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG007_14GG007_FILIALID_13GG007_UNIDADE_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg007Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG007_14GG007_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg007Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG007_15GG007_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg007FormavendaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG007_19GG007_FORMAVENDA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG007_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg007Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG007_DESCRICAO");
                entity.Property(e => e.Gg007Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG007_FILIAL");
                entity.Property(e => e.Gg007Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG007_FILIALID");
                entity.Property(e => e.Gg007FormavendaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG007_FORMAVENDA_ID");
                entity.Property(e => e.Gg007IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG007_IS_ACTIVE");
                entity.Property(e => e.Gg007Qdecimais)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("GG007_QDECIMAIS");
                entity.Property(e => e.Gg007Unidade)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG007_UNIDADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavGg007Filial).WithOne().HasForeignKey<CSICP_GG007>(e => e.Gg007Filialid);
                entity.HasOne(e => e.NavGG007FraFormaVenda).WithOne().HasForeignKey<CSICP_GG007>(e => e.Gg007FormavendaId);
            });

            modelBuilder.Entity<CSICP_GG008>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008");

                entity.ToTable("OSUSR_E9A_CSICP_GG008");

                entity.HasIndex(e => new { e.Gg008Ncmid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_11GG008_NCMID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008AnpId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_12GG008_ANP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Tipoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_12GG008_TIPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_13GG008_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Linhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_13GG008_LINHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Marcaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_13GG008_MARCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Servico, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_13GG008_SERVICO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Artigoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_ARTIGOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Classeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_CLASSEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Entregar, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_ENTREGAR_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Etiqueta, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_ETIQUETA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Filialid, e.Gg008Codgproduto, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_FILIALID_17GG008_CODGPRODUTO_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg008Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Montavel, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_MONTAVEL_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Padraoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_PADRAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Sequence, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_14GG008_SEQUENCE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Dregistro, e.Gg008Usuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_15GG008_DREGISTRO_19GG008_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008PesavelId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_16GG008_PESAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Subgrupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_16GG008_SUBGRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TipokitId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_16GG008_TIPOKIT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Qualidadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_17GG008_QUALIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Descreduzida, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_18GG008_DESCREDUZIDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Dultalteracao, e.Gg008Usuarioaltid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_19GG008_DULTALTERACAO_18GG008_USUARIOALTID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Grpsubgrupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_19GG008_GRPSUBGRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Tipoprodutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_19GG008_TIPOPRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008UsaNroSerie, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_19GG008_USA_NRO_SERIE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008ListservicoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_20GG008_LISTSERVICO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008EstadofisicoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_21GG008_ESTADOFISICO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TpgarantiavendaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_24GG008_TPGARANTIAVENDA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TpgarantiacompraId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_25GG008_TPGARANTIACOMPRA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg008AlturaArmaz)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_ALTURA_ARMAZ");
                entity.Property(e => e.Gg008AnpId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ANP_ID");
                entity.Property(e => e.Gg008Artigoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ARTIGOID");
                entity.Property(e => e.Gg008Classeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CLASSEID");
                entity.Property(e => e.Gg008Classifvegetal)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CLASSIFVEGETAL");
                entity.Property(e => e.Gg008Cnpjfabricante)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CNPJFABRICANTE");
                entity.Property(e => e.Gg008Codgproduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODGPRODUTO");
                entity.Property(e => e.Gg008CodigoArtigo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODIGO_ARTIGO");
                entity.Property(e => e.Gg008CodigoClasse)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODIGO_CLASSE");
                entity.Property(e => e.Gg008CodigoGrupo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODIGO_GRUPO");
                entity.Property(e => e.Gg008CodigoMarca)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODIGO_MARCA");
                entity.Property(e => e.Gg008CodigoPadrao)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CODIGO_PADRAO");
                entity.Property(e => e.Gg008CodigoQualidade)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CODIGO_QUALIDADE");
                entity.Property(e => e.Gg008CodigoTipo)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CODIGO_TIPO");
                entity.Property(e => e.Gg008Codindustrial)
                    .HasMaxLength(15)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CODINDUSTRIAL");
                entity.Property(e => e.Gg008Complemento)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_COMPLEMENTO");
                entity.Property(e => e.Gg008Comprimentoarmaz)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_COMPRIMENTOARMAZ");
                entity.Property(e => e.Gg008Dataforalinha)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DATAFORALINHA");
                entity.Property(e => e.Gg008Descespecial1)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_DESCESPECIAL1");
                entity.Property(e => e.Gg008Descespecial2)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_DESCESPECIAL2");
                //entity.Property(e => e.Gg008Descpeqwms1)
                //    .HasMaxLength(20)
                //    .HasDefaultValue("")
                //    .HasColumnName("GG008_DESCPEQWMS1");
                //entity.Property(e => e.Gg008Descpeqwms2)
                //    .HasMaxLength(20)
                //    .HasDefaultValue("")
                //    .HasColumnName("GG008_DESCPEQWMS2");
                entity.Property(e => e.Gg008Descreduzida)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_DESCREDUZIDA");
                entity.Property(e => e.Gg008Dregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DREGISTRO");
                entity.Property(e => e.Gg008Dultalteracao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DULTALTERACAO");
                entity.Property(e => e.Gg008Embalagem1)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_EMBALAGEM_1");
                entity.Property(e => e.Gg008Embalagem2)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_EMBALAGEM_2");
                entity.Property(e => e.Gg008Empilhagem)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_EMPILHAGEM");
                entity.Property(e => e.Gg008Entregar)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ENTREGAR");
                entity.Property(e => e.Gg008Espessura)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_ESPESSURA");
                entity.Property(e => e.Gg008EstadofisicoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ESTADOFISICO_ID");
                entity.Property(e => e.Gg008Etiqueta)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ETIQUETA");
                entity.Property(e => e.Gg008ExNcm)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_EX_NCM");
                entity.Property(e => e.Gg008FatorArmaz)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(13, 8)")
                    .HasColumnName("GG008_FATOR_ARMAZ");
                entity.Property(e => e.Gg008Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_FILIAL");
                entity.Property(e => e.Gg008Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_FILIALID");
                entity.Property(e => e.Gg008Grpsubgrupoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_GRPSUBGRUPOID");
                entity.Property(e => e.Gg008Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_GRUPOID");
                entity.Property(e => e.Gg008Ierelevanteid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_IERELEVANTEID");
                entity.Property(e => e.Gg008IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_IS_ACTIVE");
                entity.Property(e => e.Gg008Isecommerce)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_ISECOMMERCE");
                entity.Property(e => e.Gg008Isforalinha)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_ISFORALINHA");
                entity.Property(e => e.Gg008Largura)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_LARGURA");
                entity.Property(e => e.Gg008LarguraArmaz)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_LARGURA_ARMAZ");
                entity.Property(e => e.Gg008Linhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_LINHAID");
                entity.Property(e => e.Gg008ListservicoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_LISTSERVICO_ID");
                entity.Property(e => e.Gg008Marcaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_MARCAID");
                entity.Property(e => e.Gg008Montavel)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_MONTAVEL");
                entity.Property(e => e.Gg008Ncm)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_NCM");
                entity.Property(e => e.Gg008Ncmid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_NCMID");
                entity.Property(e => e.Gg008Nomefabricante)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_NOMEFABRICANTE");
                entity.Property(e => e.Gg008Padraoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_PADRAOID");
                entity.Property(e => e.Gg008PesavelId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_PESAVEL_ID");
                entity.Property(e => e.Gg008PesoBruto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PESO_BRUTO");
                entity.Property(e => e.Gg008PesoLiquido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PESO_LIQUIDO");
                entity.Property(e => e.Gg008Przgarancompra)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_PRZGARANCOMPRA");
                entity.Property(e => e.Gg008Przgaranvenda)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_PRZGARANVENDA");
                entity.Property(e => e.Gg008QtdEmbalagem1)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTD_EMBALAGEM_1");
                entity.Property(e => e.Gg008QtdEmbalagem2)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTD_EMBALAGEM_2");
                entity.Property(e => e.Gg008Qualidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_QUALIDADEID");
                entity.Property(e => e.Gg008Referencia)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_REFERENCIA");
                entity.Property(e => e.Gg008Refersimilar)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_REFERSIMILAR");
                entity.Property(e => e.Gg008SafraDiamesfim)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_SAFRA_DIAMESFIM");
                entity.Property(e => e.Gg008Safradiamesinicio)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_SAFRADIAMESINICIO");
                entity.Property(e => e.Gg008Sequence)
                    .HasDefaultValue(0L)
                    .HasColumnName("GG008_SEQUENCE");
                entity.Property(e => e.Gg008Servico)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_SERVICO");
                entity.Property(e => e.Gg008Subgrupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_SUBGRUPOID");
                entity.Property(e => e.Gg008Tamanho)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_TAMANHO");
                entity.Property(e => e.Gg008TipoProduto)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_TIPO_PRODUTO");
                entity.Property(e => e.Gg008Tipoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPOID");
                entity.Property(e => e.Gg008TipokitId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPOKIT_ID");
                entity.Property(e => e.Gg008Tipoprodutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPOPRODUTOID");
                entity.Property(e => e.Gg008TpgarantiacompraId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TPGARANTIACOMPRA_ID");
                entity.Property(e => e.Gg008TpgarantiavendaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TPGARANTIAVENDA_ID");
                entity.Property(e => e.Gg008UsaNroSerie)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_USA_NRO_SERIE");
                entity.Property(e => e.Gg008Usuarioaltid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_USUARIOALTID");
                entity.Property(e => e.Gg008Usuariopropid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_USUARIOPROPID");
                entity.Property(e => e.Gg008Vicmsproprio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VICMSPROPRIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavArtigoProdutoGG005).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Artigoid);
                entity.HasOne(e => e.NavMarcaProdutoGG006).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Marcaid);
                entity.HasOne(e => e.NavFilialBB001).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Filialid);
                entity.HasOne(e => e.NavTipodeProdutosGG002).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Tipoprodutoid);
                entity.HasOne(e => e.NavGrupoProdutoGG003).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Grupoid);
                entity.HasOne(e => e.NavSubGrupoProdutoGG015).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Subgrupoid);
                entity.HasOne(e => e.NavClasseProdutoGG004).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Classeid);
                entity.HasOne(e => e.NavLinhaProdutoGG014).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Linhaid);
                entity.HasOne(e => e.NavPadraoProdutoGG009).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Padraoid);
                entity.HasOne(e => e.NavTipoPadraoProdutoGG010).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Tipoid);
                entity.HasOne(e => e.NavQualidadeProdutoGG011).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Qualidadeid);
                entity.HasOne(e => e.NavNCMProdutoGG021).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Ncmid);

                entity.HasOne(e => e.NavGG060_GrpSubGrupo).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Grpsubgrupoid);
                entity.HasOne(e => e.NavGG029_ANP).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008AnpId);
                entity.HasOne(e => e.NavSY001_UsuarioProp).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Usuariopropid);
                entity.HasOne(e => e.NavSY001_UsuarioAlt).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Usuarioaltid);

                entity.HasOne(e => e.NavGG008_EstadoFisico).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008EstadofisicoId);
                entity.HasOne(e => e.NavGG008_TpGarantiaCompra).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008TpgarantiacompraId);
                entity.HasOne(e => e.NavGG008_TpGarantiaVenda).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008TpgarantiavendaId);
                entity.HasOne(e => e.NavGG008_TipoKit).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008TipokitId);
                entity.HasOne(e => e.NavGG008_ListServico).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008ListservicoId);
                entity.HasOne(e => e.NavGG008_Etiqueta).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Etiqueta);
                entity.HasOne(e => e.NavGG008_Usa_Nro_Serie).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008UsaNroSerie);
                entity.HasOne(e => e.NavGG008_Servico).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Servico);
                entity.HasOne(e => e.NavGG008_Montavel).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Montavel);
                entity.HasOne(e => e.NavGG008_Pesavel).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008PesavelId);
                entity.HasOne(e => e.NavGG008_Entregar).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Entregar);
                entity.HasOne(e => e.Navgg008_IERelevante).WithOne().HasForeignKey<CSICP_GG008>(e => e.Gg008Ierelevanteid);
                //entity.HasOne(e => e.NavGG008_Kardex).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Produtoid);
                //entity.HasMany(e => e.CS_NavListaKardex).WithOne().HasForeignKey(e => e.Gg008Produtoid);

            });

            modelBuilder.Entity<CSICP_GG008a>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008A");

                entity.ToTable("OSUSR_E9A_CSICP_GG008A");

                entity.HasIndex(e => new { e.Gg008aFilialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008A_15GG008A_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008aProdutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008A_16GG008A_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008A_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg008aFilialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008A_FILIALID");
                entity.Property(e => e.Gg008aProdutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008A_PRODUTOID");
                entity.Property(e => e.Gg008aValor)
                    .HasMaxLength(400)
                    .HasDefaultValue("")
                    .HasColumnName("GG008A_VALOR");
                entity.Property(e => e.Gg08aCaracteristica)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("GG08A_CARACTERISTICA");
                entity.Property(e => e.Gg08aCodgProduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG08A_CODG_PRODUTO");
                entity.Property(e => e.Gg08aFilial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG08A_FILIAL");
                entity.Property(e => e.Gg08aLinha)
                    .HasDefaultValue(0)
                    .HasColumnName("GG08A_LINHA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_GG008b>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008B");

                entity.ToTable("OSUSR_E9A_CSICP_GG008B");

                entity.HasIndex(e => new { e.Gg008bMarcaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008B_14GG008B_MARCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008bFilialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008B_15GG008B_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008bProdutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008B_16GG008B_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008bRefsimilar, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008B_17GG008B_REFSIMILAR_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008B_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg008bCodgmarca)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008B_CODGMARCA");
                entity.Property(e => e.Gg008bCodgproduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008B_CODGPRODUTO");
                entity.Property(e => e.Gg008bDatavigor)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008B_DATAVIGOR");
                entity.Property(e => e.Gg008bFilial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008B_FILIAL");
                entity.Property(e => e.Gg008bFilialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008B_FILIALID");
                entity.Property(e => e.Gg008bMarcaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008B_MARCAID");
                entity.Property(e => e.Gg008bProdutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008B_PRODUTOID");
                entity.Property(e => e.Gg008bRefsimilar)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG008B_REFSIMILAR");
                entity.Property(e => e.Gg008bSeq)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008B_SEQ");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_GG008c>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008C");

                entity.ToTable("OSUSR_E9A_CSICP_GG008C");

                entity.HasIndex(e => new { e.Gg008cCdnid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008C_12GG008C_CDNID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008cFilialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008C_15GG008C_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008cProdutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008C_16GG008C_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008C_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Filename)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("FILENAME");
                entity.Property(e => e.Gg008cCdnid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008C_CDNID");
                entity.Property(e => e.Gg008cCodgproduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008C_CODGPRODUTO");
                entity.Property(e => e.Gg008cDescricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG008C_DESCRICAO");
                entity.Property(e => e.Gg008cFiletype)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("GG008C_FILETYPE");
                entity.Property(e => e.Gg008cFilial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008C_FILIAL");
                entity.Property(e => e.Gg008cFilialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008C_FILIALID");
                entity.Property(e => e.Gg008cIspadrao)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008C_ISPADRAO");
                entity.Property(e => e.Gg008cObjeto)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008C_OBJETO");
                entity.Property(e => e.Gg008cOrdem)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008C_ORDEM");
                entity.Property(e => e.Gg008cPath)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("GG008C_PATH");
                entity.Property(e => e.Gg008cProdutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008C_PRODUTOID");
                entity.Property(e => e.Gg008cSize)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008C_SIZE");
                entity.Property(e => e.Gg008cTexto)
                    .HasDefaultValue("")
                    .HasColumnName("GG008C_TEXTO");
                entity.Property(e => e.Gg008cTiporegistro)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("GG008C_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Gg008cCdn).WithMany(p => p.OsusrE9aCsicpGg008cs)
                //    .HasForeignKey(d => d.Gg008cCdnid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG008C_OSUSR_E9A_CSICP_GG008_CDN_GG008C_CDNID");


            });



            modelBuilder.Entity<CSICP_GG008e>(entity =>
            {
                entity.HasKey(e => e.Gg008eId).HasName("OSPRK_OSUSR_E9A_CSICP_GG008E");

                entity.ToTable("OSUSR_E9A_CSICP_GG008E");

                entity.HasIndex(e => new { e.Gg008eProdutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008E_16GG008E_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008E_9TENANT_ID");

                entity.Property(e => e.Gg008eId).HasColumnName("GG008E_ID");
                entity.Property(e => e.Gg008eCodigo)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("GG008E_CODIGO");
                entity.Property(e => e.Gg008eDescricao)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("GG008E_DESCRICAO");
                entity.Property(e => e.Gg008eProdutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008E_PRODUTOID");
                entity.Property(e => e.Gg008eSeq)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG008E_SEQ");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_GG008i>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008I");

                entity.ToTable("OSUSR_E9A_CSICP_GG008I");

                entity.HasIndex(e => new { e.Gg008iNcmId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008I_13GG008I_NCM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008iFilialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008I_15GG008I_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008iKardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008I_16GG008I_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008iTransacaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008I_18GG008I_TRANSACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008iTiporegistro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008I_19GG008I_TIPOREGISTRO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008I_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg008iFilialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_FILIALID");
                entity.Property(e => e.Gg008iKardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_KARDEX_ID");
                entity.Property(e => e.Gg008iNcmId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_NCM_ID");
                entity.Property(e => e.Gg008iProdutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_PRODUTOID");
                entity.Property(e => e.Gg008iTiporegistro)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_TIPOREGISTRO");
                entity.Property(e => e.Gg008iTransacaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008I_TRANSACAOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavGG008Trans).WithOne().HasForeignKey<CSICP_GG008i>(e => e.Gg008iTiporegistro);
                entity.HasOne(e => e.NavBB027Transacao).WithOne().HasForeignKey<CSICP_GG008i>(e => e.Gg008iTransacaoid);
            });

            modelBuilder.Entity<CSICP_GG008p>(entity =>
            {
                entity.HasKey(e => e.Gg008Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008P");

                entity.ToTable("OSUSR_E9A_CSICP_GG008P");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008P_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008P_9TENANT_ID");

                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.Gg008pPercVenda1)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_1");
                entity.Property(e => e.Gg008pPercVenda2)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_2");
                entity.Property(e => e.Gg008pPercVenda3)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_3");
                entity.Property(e => e.Gg008pPercVenda4)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_4");
                entity.Property(e => e.Gg008pPercVenda5)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_5");
                entity.Property(e => e.Gg008pPercVenda6)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_6");
                entity.Property(e => e.Gg008pPercVenda7)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_7");
                entity.Property(e => e.Gg008pPercVenda8)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_8");
                entity.Property(e => e.Gg008pPercVenda9)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG008P_PERC_VENDA_9");
                entity.Property(e => e.Gg008pPrecoBase)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_BASE");
                entity.Property(e => e.Gg008pPrecoVenda1)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_1");
                entity.Property(e => e.Gg008pPrecoVenda2)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_2");
                entity.Property(e => e.Gg008pPrecoVenda3)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_3");
                entity.Property(e => e.Gg008pPrecoVenda4)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_4");
                entity.Property(e => e.Gg008pPrecoVenda5)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_5");
                entity.Property(e => e.Gg008pPrecoVenda6)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_6");
                entity.Property(e => e.Gg008pPrecoVenda7)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_7");
                entity.Property(e => e.Gg008pPrecoVenda8)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_8");
                entity.Property(e => e.Gg008pPrecoVenda9)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008P_PRECO_VENDA_9");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Gg008).WithOne(p => p.OsusrE9aCsicpGg008p)
                //    .HasForeignKey<OsusrE9aCsicpGg008p>(d => d.Gg008Id)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG008P_OSUSR_E9A_CSICP_GG008_KDX_GG008_ID");
            });
            modelBuilder.Entity<CSICP_GG008Kdx>(entity =>
            {
                entity.HasKey(e => e.Gg008Kardexid)
                    .HasName("OSPRK_OSUSR_E9A_CSICP_GG008_KDX")
                    .HasFillFactor(70);

                entity.ToTable("OSUSR_E9A_CSICP_GG008_KDX");

                entity.HasIndex(e => new { e.Gg008Anuente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_13GG008_ANUENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_13GG008_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Moedaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_13GG008_MOEDAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Auditasn, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_14GG008_AUDITASN_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_14GG008_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Filialid, e.Gg008Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_14GG008_FILIALID_15GG008_PRODUTOID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg008Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_14GG008_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_15GG008_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Restricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_15GG008_RESTRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Possuisaldo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_17GG008_POSSUISALDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008CalculaInss, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_18GG008_CALCULA_INSS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008CalculaIrrf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_18GG008_CALCULA_IRRF_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TipoprazoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_18GG008_TIPOPRAZO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Almoxpadraoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_19GG008_ALMOXPADRAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Almoxtransfid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_19GG008_ALMOXTRANSFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008ControleLote, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_19GG008_CONTROLE_LOTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Alteraprcvenda, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_20GG008_ALTERAPRCVENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008ControlaSaldo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_20GG008_CONTROLA_SALDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008ControleGrade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_20GG008_CONTROLE_GRADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Untributavelid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_20GG008_UNTRIBUTAVELID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Permsldnegativo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_21GG008_PERMSLDNEGATIVO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TpcbarratribId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_21GG008_TPCBARRATRIB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Unvendavarejoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_21GG008_UNVENDAVAREJOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008FornecedorCanal, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_22GG008_FORNECEDOR_CANAL_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Minutaautomatica, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_22GG008_MINUTAAUTOMATICA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Requisautomatica, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_22GG008_REQUISAUTOMATICA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Uncompravarejoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_22GG008_UNCOMPRAVAREJOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Unvendaatacadoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_22GG008_UNVENDAATACADOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TipoConversaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_23GG008_TIPO_CONVERSAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008TpContribuicaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_24GG008_TP_CONTRIBUICAO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG008_KDX_9TENANT_ID");

                entity.Property(e => e.Gg008Kardexid)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_KARDEXID");
                entity.Property(e => e.Gg008Abc)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_ABC");
                entity.Property(e => e.Gg008AliqDifCofins)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQ_DIF_COFINS");
                entity.Property(e => e.Gg008AliqDifPis)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQ_DIF_PIS");
                entity.Property(e => e.Gg008AliqIcmsReduzidaPdv)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQ_ICMS_REDUZIDA_PDV");
                entity.Property(e => e.Gg008AliquotaIcms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQUOTA_ICMS");
                entity.Property(e => e.Gg008AliquotaIpi)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQUOTA_IPI");
                entity.Property(e => e.Gg008AliquotaIrpj)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQUOTA_IRPJ");
                entity.Property(e => e.Gg008AliquotaIss)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_ALIQUOTA_ISS");
                entity.Property(e => e.Gg008Almoxpadraoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ALMOXPADRAOID");
                entity.Property(e => e.Gg008Almoxtransfid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ALMOXTRANSFID");
                entity.Property(e => e.Gg008Alteraprcvenda)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ALTERAPRCVENDA");
                entity.Property(e => e.Gg008Anuente)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ANUENTE");
                entity.Property(e => e.Gg008Auditasn)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_AUDITASN");
                entity.Property(e => e.Gg008CalculaInss)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CALCULA_INSS");
                entity.Property(e => e.Gg008CalculaIrrf)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CALCULA_IRRF");
                entity.Property(e => e.Gg008Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CCUSTOID");
                entity.Property(e => e.Gg008CentroCusto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CENTRO_CUSTO");
                entity.Property(e => e.Gg008ClasseContabil)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CLASSE_CONTABIL");
                entity.Property(e => e.Gg008Codalmoxpadrao)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODALMOXPADRAO");
                entity.Property(e => e.Gg008Codalmtransf)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_CODALMTRANSF");
                entity.Property(e => e.Gg008ContaContabil)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CONTA_CONTABIL");
                entity.Property(e => e.Gg008Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CONTAID");
                entity.Property(e => e.Gg008ControlaSaldo)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CONTROLA_SALDO");
                entity.Property(e => e.Gg008ControleGrade)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CONTROLE_GRADE");
                entity.Property(e => e.Gg008ControleLote)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CONTROLE_LOTE");
                entity.Property(e => e.Gg008CustoMedio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_CUSTO_MEDIO");
                entity.Property(e => e.Gg008DataDesativacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DATA_DESATIVACAO");
                entity.Property(e => e.Gg008DataFabricacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DATA_FABRICACAO");
                entity.Property(e => e.Gg008DataValidade)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DATA_VALIDADE");
                entity.Property(e => e.Gg008DescontoSuframa)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_DESCONTO_SUFRAMA");
                entity.Property(e => e.Gg008DiasValidade)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_DIAS_VALIDADE");
                entity.Property(e => e.Gg008Diversos)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_DIVERSOS");
                entity.Property(e => e.Gg008Dtultprocle)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_DTULTPROCLE");
                entity.Property(e => e.Gg008EanTributavel)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG008_EAN_TRIBUTAVEL");
                entity.Property(e => e.Gg008EstoqueMaximo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_ESTOQUE_MAXIMO");
                entity.Property(e => e.Gg008EstoqueMinimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_ESTOQUE_MINIMO");
                entity.Property(e => e.Gg008FatorConversao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(13, 8)")
                    .HasColumnName("GG008_FATOR_CONVERSAO");
                entity.Property(e => e.Gg008FatorLucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(13, 8)")
                    .HasColumnName("GG008_FATOR_LUCRO");
                entity.Property(e => e.Gg008FatorUnidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(11, 5)")
                    .HasColumnName("GG008_FATOR_UNIDADE");
                entity.Property(e => e.Gg008Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_FILIALID");
                entity.Property(e => e.Gg008FornecedorCanal)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_FORNECEDOR_CANAL");
                entity.Property(e => e.Gg008Fornecedorpadrao)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_FORNECEDORPADRAO");
                entity.Property(e => e.Gg008GrauAtendimento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_GRAU_ATENDIMENTO");
                entity.Property(e => e.Gg008Grupocomprasid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_GRUPOCOMPRASID");
                entity.Property(e => e.Gg008IcmsPauta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_ICMS_PAUTA");
                entity.Property(e => e.Gg008IpiPauta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_IPI_PAUTA");
                entity.Property(e => e.Gg008IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_IS_ACTIVE");
                entity.Property(e => e.Gg008IsctrlGondola)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_ISCTRL_GONDOLA");
                entity.Property(e => e.Gg008Localizfixa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_LOCALIZFIXA");
                entity.Property(e => e.Gg008LoteEconomico)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_LOTE_ECONOMICO");
                entity.Property(e => e.Gg008Margemlucroent)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_MARGEMLUCROENT");
                entity.Property(e => e.Gg008Margemlucrosai)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_MARGEMLUCROSAI");
                entity.Property(e => e.Gg008Minutaautomatica)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_MINUTAAUTOMATICA");
                entity.Property(e => e.Gg008Moedaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_MOEDAID");
                entity.Property(e => e.Gg008PercCofins)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_COFINS");
                entity.Property(e => e.Gg008PercComissao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_COMISSAO");
                entity.Property(e => e.Gg008PercCsll)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_CSLL");
                entity.Property(e => e.Gg008PercDescItem)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_DESC_ITEM");
                entity.Property(e => e.Gg008PercPis)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_PIS");
                entity.Property(e => e.Gg008PercTolerancia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PERC_TOLERANCIA");
                entity.Property(e => e.Gg008Periodicidadeinv)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_PERIODICIDADEINV");
                entity.Property(e => e.Gg008Permsldnegativo)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_PERMSLDNEGATIVO");
                entity.Property(e => e.Gg008Plucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_PLUCRO");
                entity.Property(e => e.Gg008PontoPedido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PONTO_PEDIDO");
                entity.Property(e => e.Gg008Possuisaldo)
                    .HasDefaultValue(0)
                    .HasColumnName("GG008_POSSUISALDO");
                entity.Property(e => e.Gg008PrcVendavarejo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRC_VENDAVAREJO");
                entity.Property(e => e.Gg008PrcVndMercado)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRC_VND_MERCADO");
                entity.Property(e => e.Gg008Prcecommerce)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRCECOMMERCE");
                entity.Property(e => e.Gg008Prcpromocional)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRCPROMOCIONAL");
                entity.Property(e => e.Gg008PrecoCusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRECO_CUSTO");
                entity.Property(e => e.Gg008PrecoCustoReal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRECO_CUSTO_REAL");
                entity.Property(e => e.Gg008PrecoReposicao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRECO_REPOSICAO");
                entity.Property(e => e.Gg008PrecoVendaLiq)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_PRECO_VENDA_LIQ");
                entity.Property(e => e.Gg008Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_PRODUTOID");
                entity.Property(e => e.Gg008Qmediaconsumo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QMEDIACONSUMO");
                entity.Property(e => e.Gg008QtdPromocional)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTD_PROMOCIONAL");
                entity.Property(e => e.Gg008QtdeUltVenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTDE_ULT_VENDA");
                entity.Property(e => e.Gg008Qtdpedidocompra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTDPEDIDOCOMPRA");
                entity.Property(e => e.Gg008Qtdultrecebto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_QTDULTRECEBTO");
                entity.Property(e => e.Gg008Requisautomatica)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_REQUISAUTOMATICA");
                entity.Property(e => e.Gg008Restricao)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_RESTRICAO");
                entity.Property(e => e.Gg008RetencaoAliqInss)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_RETENCAO_ALIQ_INSS");
                entity.Property(e => e.Gg008RetencaoAliqIrrf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG008_RETENCAO_ALIQ_IRRF");
                entity.Property(e => e.Gg008RiControlequalidade)
                    .HasDefaultValue(false)
                    .HasColumnName("GG008_RI_CONTROLEQUALIDADE");
                entity.Property(e => e.Gg008TempoReposicao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("GG008_TEMPO_REPOSICAO");
                entity.Property(e => e.Gg008Timestamp)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_TIMESTAMP");
                entity.Property(e => e.Gg008TipoConversaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPO_CONVERSAO_ID");
                entity.Property(e => e.Gg008TipoprazoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPOPRAZO_ID");
                entity.Property(e => e.Gg008TpContribuicaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TP_CONTRIBUICAO_ID");
                entity.Property(e => e.Gg008TpcbarratribId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TPCBARRATRIB_ID");
                entity.Property(e => e.Gg008UltimaVenda)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_ULTIMA_VENDA");
                entity.Property(e => e.Gg008Ultreajprccusto)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_ULTREAJPRCCUSTO");
                entity.Property(e => e.Gg008Ultreajprcvenda)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_ULTREAJPRCVENDA");
                entity.Property(e => e.Gg008Ultrecebimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG008_ULTRECEBIMENTO");
                entity.Property(e => e.Gg008Uncompravarejoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_UNCOMPRAVAREJOID");
                entity.Property(e => e.Gg008Unidade)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_UNIDADE");
                entity.Property(e => e.Gg008Unidsecundaria)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_UNIDSECUNDARIA");
                entity.Property(e => e.Gg008Untributavelid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_UNTRIBUTAVELID");
                entity.Property(e => e.Gg008Unvendaatacadoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_UNVENDAATACADOID");
                entity.Property(e => e.Gg008Unvendavarejoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_UNVENDAVAREJOID");
                entity.Property(e => e.Gg008ValorCofins)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VALOR_COFINS");
                entity.Property(e => e.Gg008ValorPis)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VALOR_PIS");
                entity.Property(e => e.Gg008Vlrmargemlucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VLRMARGEMLUCRO");
                entity.Property(e => e.Gg008Vmediaconsumo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VMEDIACONSUMO");
                entity.Property(e => e.Gg008Vmoeda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VMOEDA");
                entity.Property(e => e.Gg008VuncompraCmedio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_CMEDIO");
                entity.Property(e => e.Gg008VuncompraCustoreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_CUSTOREAL");
                entity.Property(e => e.Gg008VuncompraPrccusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_PRCCUSTO");
                entity.Property(e => e.Gg008VuncompraPrcmercado)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_PRCMERCADO");
                entity.Property(e => e.Gg008VuncompraPrcvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_PRCVENDA");
                entity.Property(e => e.Gg008VuncompraReposicao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_REPOSICAO");
                entity.Property(e => e.Gg008VuncompraVlrmarglucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG008_VUNCOMPRA_VLRMARGLUCRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavGG008pOutrosPrecos).WithOne().HasForeignKey<CSICP_GG008p>(e => e.Gg008Id);

                entity.HasOne(e => e.NavBB001Filial).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Filialid);
                entity.HasOne(e => e.NavGG008Produto).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Produtoid);
                entity.HasOne(e => e.NavGG001AlmoxarifadoPadrao).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Almoxpadraoid);
                entity.HasOne(e => e.NavGG001AlmoxarifadoTransferencia).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Almoxtransfid);

                entity.HasOne(e => e.NavGG007UNVendaVarejo).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Unvendavarejoid);
                entity.HasOne(e => e.NavGG007UNCompraVarejo).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Uncompravarejoid);
                entity.HasOne(e => e.NavGG007UNVendaAtacado).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Unvendaatacadoid);
                entity.HasOne(e => e.NavGG007UNTributavel).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Untributavelid);
                entity.HasOne(e => e.NavBB005_CCusto).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Ccustoid);
                entity.HasOne(e => e.NavBB003_Moeda).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Moedaid);
                entity.HasOne(e => e.NavBB012_Conta).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Contaid);
                entity.HasOne(e => e.NavGG008_Tipo_Conversao).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008TipoConversaoId);
                entity.HasOne(e => e.NavGG008_TipoPrazo).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008TipoprazoId);
                entity.HasOne(e => e.NavGG019_tpCBarraTrib).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008TpcbarratribId);
                entity.HasOne(e => e.NavGG008_Tp_Contribuicao).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008TpContribuicaoId);
                entity.HasOne(e => e.NavGG008_AuditaSN).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Auditasn);
                entity.HasOne(e => e.NavGG008_Desconto_SUFRAMA).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008DescontoSuframa);
                entity.HasOne(e => e.NavGG008_Calcula_IRRF).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008CalculaIrrf);
                entity.HasOne(e => e.NavGG008_Calcula_INSS).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008CalculaInss);
                entity.HasOne(e => e.NavGG008_AlteraPrcVenda).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Alteraprcvenda);
                entity.HasOne(e => e.NavGG008_Fornecedor_Canal).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008FornecedorCanal);
                entity.HasOne(e => e.NavGG008_Controla_Saldo).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008ControlaSaldo);
                entity.HasOne(e => e.NavGG008_Controle_Lote).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008ControleLote);
                entity.HasOne(e => e.NavGG008_Controle_Grade).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008ControleGrade);
                entity.HasOne(e => e.NavGG008_Anuente).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Anuente);
                entity.HasOne(e => e.NavGG008_Restricao).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Restricao);
                entity.HasOne(e => e.NavGG008_PermSldNegativo).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Permsldnegativo);
                entity.HasOne(e => e.NavGG008_RequisAutomatica).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Requisautomatica);
                entity.HasOne(e => e.NavGG008_MinutaAutomatica).WithOne().HasForeignKey<CSICP_GG008Kdx>(e => e.Gg008Minutaautomatica);
                entity.HasMany(e => e.CS_NavListaSaldos).WithOne(e => e.Nav_GG008Kardex).HasForeignKey(e => e.Gg520KardexId);
            });
            modelBuilder.Entity<CSICP_GG009>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG009");

                entity.ToTable("OSUSR_E9A_CSICP_GG009");

                entity.HasIndex(e => new { e.Gg009Filiald, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG009_13GG009_FILIALD_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg009Descpadrao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG009_16GG009_DESCPADRAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG009_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg009Codigopadrao)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG009_CODIGOPADRAO");
                entity.Property(e => e.Gg009Descpadrao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG009_DESCPADRAO");
                entity.Property(e => e.Gg009Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG009_FILIAL");
                entity.Property(e => e.Gg009Filiald)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG009_FILIALD");
                entity.Property(e => e.Gg009IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG009_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(d => d.NavFilialBB001).WithOne().HasForeignKey<CSICP_GG009>(d => d.Gg009Filiald);
            });
        }
    }
}
