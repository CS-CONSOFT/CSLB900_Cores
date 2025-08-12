
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {

        public DbSet<CSICP_AA001> OsusrE9aCsicpAa001s { get; set; }

        public DbSet<CSICP_AA006> OsusrE9aCsicpAa006s { get; set; }

        public DbSet<CSICP_Aa007> OsusrE9aCsicpAa007s { get; set; }

        public DbSet<CSICP_Aa012> OsusrE9aCsicpAa012s { get; set; }

        public DbSet<CSICP_Aa013> OsusrE9aCsicpAa013s { get; set; }

        public DbSet<CSICP_Aa014> OsusrE9aCsicpAa014s { get; set; }

        public DbSet<CSICP_Aa024> OsusrE9aCsicpAa024s { get; set; }

        public DbSet<CSICP_Aa025> OsusrE9aCsicpAa025s { get; set; }

        public DbSet<CSICP_Aa026> OsusrE9aCsicpAa026s { get; set; }

        public DbSet<CSICP_Aa027> OsusrE9aCsicpAa027s { get; set; }

        public DbSet<CSICP_Aa028> OsusrE9aCsicpAa028s { get; set; }

        public DbSet<CSICP_AA029> OsusrE9aCsicpAa029s { get; set; }
        public DbSet<CSICP_AA030> OsusrE9aCsicpAa030Tokens { get; set; }

        public DbSet<CSICP_Aa040> OsusrE9aCsicpAa040s { get; set; }

        public DbSet<CSICP_Aa041> OsusrE9aCsicpAa041s { get; set; }

        public DbSet<CSICP_Aa042> OsusrE9aCsicpAa042s { get; set; }
        public DbSet<CSICP_AA043> CSICP_AA043 { get; set; }

        partial void OnModelCreating_CSICP_AA(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_AA043>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Aa043Artigo)
                    .HasMaxLength(30)
                    .HasColumnName("AA043_ARTIGO");
                entity.Property(e => e.Aa043Ec)
                    .HasMaxLength(50)
                    .HasColumnName("AA043_EC");
                entity.Property(e => e.Aa043LcRedacao)
                    .HasMaxLength(1000)
                    .HasColumnName("AA043_LC_REDACAO");
                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
            modelBuilder.Entity<CSICP_AA001>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA001");

                entity.ToTable("OSUSR_E9A_CSICP_AA001");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa001Conteudo)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA001_CONTEUDO");
                entity.Property(e => e.Aa001Descricao)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA001_DESCRICAO");
                entity.Property(e => e.Aa001Filial)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("AA001_FILIAL");
                entity.Property(e => e.Aa001Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA001_FILIALID");
                entity.Property(e => e.Aa001Identificacao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA001_IDENTIFICACAO");
                entity.Property(e => e.Aa001Json)
                    .HasDefaultValue("")
                    .HasColumnName("AA001_JSON");
                entity.Property(e => e.Aa001Tipo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA001_TIPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.FilialBB001).WithOne()
                    .HasForeignKey<CSICP_AA001>(d => d.Aa001Filialid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA001_OSUSR_E9A_CSICP_BB001_AA001_FILIALID");
            });

            modelBuilder.Entity<CSICP_AA006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA006");

                entity.ToTable("OSUSR_E9A_CSICP_AA006");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa006Arquivo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("AA006_ARQUIVO");
                entity.Property(e => e.Aa006Ci)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("AA006_CI");
                entity.Property(e => e.Aa006Circular)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA006_CIRCULAR");
                entity.Property(e => e.Aa006Dataultcaptura)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("AA006_DATAULTCAPTURA");
                entity.Property(e => e.Aa006Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("AA006_FILIAL");
                entity.Property(e => e.Aa006Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA006_FILIALID");
                entity.Property(e => e.Aa006Maxcircular)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("AA006_MAXCIRCULAR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Aa006CircularNavigation).WithOne()
                    .HasForeignKey<CSICP_AA006>(d => d.Aa006Circular)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA006_OSUSR_E9A_CSICP_STATICA_AA006_CIRCULAR");

                entity.HasOne(d => d.FilialBB001).WithOne()
                    .HasForeignKey<CSICP_AA006>(d => d.Aa006Filialid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA006_OSUSR_E9A_CSICP_BB001_AA006_FILIALID");
            });

            modelBuilder.Entity<CSICP_Aa007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA007");

                entity.ToTable("OSUSR_E9A_CSICP_AA007");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Aa007Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA007_DESCRICAO");
                entity.Property(e => e.Aa007Modeloemail)
                    .HasDefaultValue("")
                    .HasColumnName("AA007_MODELOEMAIL");
                entity.Property(e => e.Aa007Tipo)
                    .HasDefaultValue(0)
                    .HasColumnName("AA007_TIPO");
                entity.Property(e => e.Aa007Uso)
                    .HasDefaultValue(0)
                    .HasColumnName("AA007_USO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Aa012>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA012");

                entity.ToTable("OSUSR_E9A_CSICP_AA012");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa012Codigo)
                    .HasMaxLength(6)
                    .HasDefaultValue("")
                    .HasColumnName("AA012_CODIGO");
                entity.Property(e => e.Aa012Descricao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("AA012_DESCRICAO");
                entity.Property(e => e.Aa012DescricaoGrande)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("AA012_DESCRICAO_GRANDE");
                entity.Property(e => e.Aa012Tabela)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("AA012_TABELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Aa013>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA013");

                entity.ToTable("OSUSR_E9A_CSICP_AA013");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa013DataValidade)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("AA013_DATA_VALIDADE");
                entity.Property(e => e.Aa013Filial)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("AA013_FILIAL");
                entity.Property(e => e.Aa013Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA013_FILIALID");
                entity.Property(e => e.Aa013Isusocontigencia)
                    .HasDefaultValue(false)
                    .HasColumnName("AA013_ISUSOCONTIGENCIA");
                entity.Property(e => e.Aa013ModId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA013_MOD_ID");
                entity.Property(e => e.Aa013Numero)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("AA013_NUMERO");
                entity.Property(e => e.Aa013Serie)
                    .HasMaxLength(9)
                    .HasDefaultValue("")
                    .HasColumnName("AA013_SERIE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Filial).WithOne()
                    .HasForeignKey<CSICP_Aa013>(d => d.Aa013Filialid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA013_OSUSR_E9A_CSICP_BB001_AA013_FILIALID");

                entity.HasOne(d => d.Aa013Mod).WithOne()
                    .HasForeignKey<CSICP_Aa013>(d => d.Aa013ModId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA013_OSUSR_NNX_SPED_IN_DOC_ICMS_AA013_MOD_ID");
            });

            modelBuilder.Entity<CSICP_Aa014>(entity =>
            {
                entity.HasKey(e => e.Aa014Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA014");

                entity.ToTable("OSUSR_E9A_CSICP_AA014");

                entity.Property(e => e.Aa014Id).HasColumnName("AA014_ID");
                entity.Property(e => e.Aa014Dregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("AA014_DREGISTRO");
                entity.Property(e => e.Aa014Serienfid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA014_SERIENFID");
                entity.Property(e => e.Aa014Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA014_USUARIOID");
                entity.Property(e => e.Aa014Usuariopropid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA014_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Aa014Serienf).WithMany(p => p.OsusrE9aCsicpAa014s)
                //    .HasForeignKey(d => d.Aa014Serienfid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA014_OSUSR_E9A_CSICP_AA013_AA014_SERIENFID");
            });

            modelBuilder.Entity<CSICP_Aa025>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA025");

                entity.ToTable("OSUSR_E9A_CSICP_AA025");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa025CodigoNacoesunidas)
                    .HasDefaultValue(0)
                    .HasColumnName("AA025_CODIGO_NACOESUNIDAS");
                entity.Property(e => e.Aa025Codigobacen)
                    .HasDefaultValue(0)
                    .HasColumnName("AA025_CODIGOBACEN");
                entity.Property(e => e.Aa025Codigopais)
                    .HasDefaultValue(0)
                    .HasColumnName("AA025_CODIGOPAIS");
                entity.Property(e => e.Aa025Codigosiscomex)
                    .HasDefaultValue(0)
                    .HasColumnName("AA025_CODIGOSISCOMEX");
                entity.Property(e => e.Aa025Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_DESCRICAO");
                entity.Property(e => e.Aa025ExportPaisid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_EXPORT_PAISID");
                entity.Property(e => e.Aa025Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("AA025_ISACTIVE");
                entity.Property(e => e.Aa025Iso3166A2)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_ISO_3166_A2");
                entity.Property(e => e.Aa025Iso3166A3)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_ISO_3166_A3");
                entity.Property(e => e.Aa025Iso3166N3)
                    .HasDefaultValue(0)
                    .HasColumnName("AA025_ISO_3166_N3");
                entity.Property(e => e.Aa025Nacionalidade)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_NACIONALIDADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Aa024>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA024");

                entity.ToTable("OSUSR_E9A_CSICP_AA024");

                entity.HasIndex(e => new { e.Aa024NomeUdh, e.Aa028Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_AA024_14AA024_NOME_UDH_8AA028_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Aa027Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_AA024_8AA027_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Aa028Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_AA024_8AA028_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_AA024_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Aa024Ano)
                    .HasMaxLength(4)
                    .HasDefaultValue("")
                    .HasColumnName("AA024_ANO");
                entity.Property(e => e.Aa024IdhmR)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(4, 3)")
                    .HasColumnName("AA024_IDHM_R");
                entity.Property(e => e.Aa024NomeUdh)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA024_NOME_UDH");
                entity.Property(e => e.Aa027Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA027_ID");
                entity.Property(e => e.Aa028Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA028_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavAA028).WithOne().HasForeignKey<CSICP_Aa024>(e => e.Aa028Id);

            });

            modelBuilder.Entity<CSICP_Aa026>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA026");

                entity.ToTable("OSUSR_E9A_CSICP_AA026");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa026Codigoibge)
                    .HasDefaultValue(0)
                    .HasColumnName("AA026_CODIGOIBGE");
                entity.Property(e => e.Aa026Codigoregiao)
                    .HasDefaultValue(0)
                    .HasColumnName("AA026_CODIGOREGIAO");
                entity.Property(e => e.Aa026Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("AA026_DESCRICAO");
                entity.Property(e => e.Aa026ExportRegiaoid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("AA026_EXPORT_REGIAOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Aa027>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA027");

                entity.ToTable("OSUSR_E9A_CSICP_AA027");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Aa025ExportPaisid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA025_EXPORT_PAISID");
                entity.Property(e => e.Aa026ExportRegiaoid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA026_EXPORT_REGIAOID");
                entity.Property(e => e.Aa027Codigoibge)
                    .HasDefaultValue(0)
                    .HasColumnName("AA027_CODIGOIBGE");
                entity.Property(e => e.Aa027ExportUfid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_EXPORT_UFID");
                entity.Property(e => e.Aa027Mascieimpressao)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_MASCIEIMPRESSAO");
                entity.Property(e => e.Aa027Mascinsestadual)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_MASCINSESTADUAL");
                entity.Property(e => e.Aa027Naturalidade)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_NATURALIDADE");
                entity.Property(e => e.Aa027Percicmscontrib)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA027_PERCICMSCONTRIB");
                entity.Property(e => e.Aa027Percicmsentrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA027_PERCICMSENTRADA");
                entity.Property(e => e.Aa027Percicmsncontrib)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA027_PERCICMSNCONTRIB");
                entity.Property(e => e.Aa027Percsubsttribut)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA027_PERCSUBSTTRIBUT");
                entity.Property(e => e.Aa027Sigla)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_SIGLA");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.Paisid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PAISID");
                entity.Property(e => e.Regiaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("REGIAOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Pais).WithOne()
                    .HasForeignKey<CSICP_Aa027>(d => d.Paisid);

                entity.HasOne(d => d.Regiao).WithOne()
                    .HasForeignKey<CSICP_Aa027>(d => d.Regiaoid);
            });

            modelBuilder.Entity<CSICP_Aa028>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA028");

                entity.ToTable("OSUSR_E9A_CSICP_AA028");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.A028Mascieimpressao)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("A028_MASCIEIMPRESSAO");
                entity.Property(e => e.A028Mascinsestadual)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("A028_MASCINSESTADUAL");
                entity.Property(e => e.A028Percicmsentrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("A028_PERCICMSENTRADA");
                entity.Property(e => e.A028Percicmsncontrib)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("A028_PERCICMSNCONTRIB");
                entity.Property(e => e.A028Percsubsttribut)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("A028_PERCSUBSTTRIBUT");
                entity.Property(e => e.Aa027ExportUfid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("AA027_EXPORT_UFID");
                entity.Property(e => e.Aa028Cidade)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("AA028_CIDADE");
                entity.Property(e => e.Aa028Codgibge)
                    .HasDefaultValue(0)
                    .HasColumnName("AA028_CODGIBGE");
                entity.Property(e => e.Aa028Estadobrasil)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA028_ESTADOBRASIL");
                entity.Property(e => e.Aa028ExportCidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("AA028_EXPORT_CIDADEID");
                entity.Property(e => e.Aa028Percicmscontrib)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA028_PERCICMSCONTRIB");
                entity.Property(e => e.Aa028Zonafranca)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA028_ZONAFRANCA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Ufid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("UFID");

                entity.HasOne(d => d.NavUFBrasil).WithOne()
                    .HasForeignKey<CSICP_Aa028>(d => d.Aa028Estadobrasil);

                entity.HasOne(d => d.NavZonaFranca).WithOne()
                    .HasForeignKey<CSICP_Aa028>(d => d.Aa028Zonafranca);

                entity.HasOne(d => d.NavUf).WithOne()
                    .HasForeignKey<CSICP_Aa028>(d => d.Ufid);
            });

            modelBuilder.Entity<CSICP_AA029>(entity =>
            {
                entity.HasKey(e => e.Aa029Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA029");

                entity.ToTable("OSUSR_E9A_CSICP_AA029");

                entity.Property(e => e.Aa029Id)
                    .HasMaxLength(36)
                    .HasColumnName("AA029_ID");
                entity.Property(e => e.Aa029Cnae)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("AA029_CNAE");
                entity.Property(e => e.Aa029Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("AA029_DESCRICAO");
                entity.Property(e => e.Aa029Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("AA029_ISACTIVE");
                entity.Property(e => e.Aa029Notaexplicativa)
                    .HasMaxLength(2000)
                    .HasDefaultValue("")
                    .HasColumnName("AA029_NOTAEXPLICATIVA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
            modelBuilder.Entity<CSICP_AA030>(entity =>
            {
                entity.HasKey(e => e.Aa030Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA030_TOKEN");

                entity.ToTable("OSUSR_E9A_CSICP_AA030_TOKEN");

                entity.Property(e => e.Aa030Id).HasColumnName("AA030_ID");
                entity.Property(e => e.Aa030AwsBucket)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_AWS_BUCKET");
                entity.Property(e => e.Aa030Awsaccesskeyid)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_AWSACCESSKEYID");
                entity.Property(e => e.Aa030Awsregion)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_AWSREGION");
                entity.Property(e => e.Aa030Awssecretaccesske)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_AWSSECRETACCESSKE");
                entity.Property(e => e.Aa030Descricao)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_DESCRICAO");
                entity.Property(e => e.Aa030Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA030_ESTABID");
                entity.Property(e => e.Aa030Ospushtoken)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_OSPUSHTOKEN");
                entity.Property(e => e.Aa030Senha)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_SENHA");
                entity.Property(e => e.Aa030Tptokenid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA030_TPTOKENID");
                entity.Property(e => e.Aa030User)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA030_USER");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Aa030Estab).WithMany(p => p.OsusrE9aCsicpAa030Tokens)
                //    .HasForeignKey(d => d.Aa030Estabid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA030_TOKEN_OSUSR_E9A_CSICP_BB001_AA030_ESTABID");

                entity.HasOne(d => d.Aa030Tptoken).WithOne()
                    .HasForeignKey<CSICP_AA030>(d => d.Aa030Tptokenid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA030_TOKEN_OSUSR_E9A_CSICP_AA030_TPTOKEN_AA030_TPTOKENID");
            });
            modelBuilder.Entity<CSICP_Aa040>(entity =>
            {
                entity.HasKey(e => e.Aa040Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA040");

                entity.ToTable("OSUSR_E9A_CSICP_AA040");

                entity.Property(e => e.Aa040Id)
                    .HasMaxLength(36)
                    .HasColumnName("AA040_ID");
                entity.Property(e => e.Aa040Paliquota)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("AA040_PALIQUOTA");
                entity.Property(e => e.Aa040UfdestinoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA040_UFDESTINO_ID");
                entity.Property(e => e.Aa040UforigemId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA040_UFORIGEM_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Aa040Ufdestino).WithMany(p => p.OsusrE9aCsicpAa040Aa040Ufdestinos)
                //    .HasForeignKey(d => d.Aa040UfdestinoId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA040_OSUSR_E9A_CSICP_AA027_AA040_UFDESTINO_ID");

                //entity.HasOne(d => d.Aa040Uforigem).WithMany(p => p.OsusrE9aCsicpAa040Aa040Uforigems)
                //    .HasForeignKey(d => d.Aa040UforigemId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA040_OSUSR_E9A_CSICP_AA027_AA040_UFORIGEM_ID");
            });

            modelBuilder.Entity<CSICP_Aa041>(entity =>
            {
                entity.HasKey(e => e.Aa041Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA041");

                entity.ToTable("OSUSR_E9A_CSICP_AA041");

                entity.Property(e => e.Aa041Id).HasColumnName("AA041_ID");
                entity.Property(e => e.Aa041Codigo)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("AA041_CODIGO");
                entity.Property(e => e.Aa041Descricao)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("AA041_DESCRICAO");
                entity.Property(e => e.Aa041Dfinal)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("AA041_DFINAL");
                entity.Property(e => e.Aa041Dinicio)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("AA041_DINICIO");
                entity.Property(e => e.Aa041TabspedId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA041_TABSPED_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Aa041Tabsped).WithOne()
                    .HasForeignKey<CSICP_Aa041>(d => d.Aa041TabspedId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA041_OSUSR_NNX_SPED_IN_TABELAS_AA041_TABSPED_ID");
            });

            modelBuilder.Entity<CSICP_Aa042>(entity =>
            {
                entity.HasKey(e => e.Aa042Id).HasName("OSPRK_OSUSR_E9A_CSICP_AA042");

                entity.ToTable("OSUSR_E9A_CSICP_AA042");

                entity.Property(e => e.Aa042Id).HasColumnName("AA042_ID");
                entity.Property(e => e.Aa042CfopId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA042_CFOP_ID");
                entity.Property(e => e.Aa042Coddeclaid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA042_CODDECLAID");
                entity.Property(e => e.Aa042CstId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA042_CST_ID");
                entity.Property(e => e.Aa042CstOrigemid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA042_CST_ORIGEMID");
                entity.Property(e => e.Aa042Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AA042_PRODUTOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Ufid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("UFID");

                //entity.HasOne(d => d.Aa042Cfop).WithMany(p => p.OsusrE9aCsicpAa042s)
                //    .HasForeignKey(d => d.Aa042CfopId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA042_OSUSR_66C_SPED_IN_CFOP_AA042_CFOP_ID");

                //entity.HasOne(d => d.Aa042Coddecla).WithMany(p => p.OsusrE9aCsicpAa042s)
                //    .HasForeignKey(d => d.Aa042Coddeclaid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA042_OSUSR_E9A_CSICP_AA041_AA042_CODDECLAID");

                //entity.HasOne(d => d.Aa042Cst).WithMany(p => p.OsusrE9aCsicpAa042s)
                //    .HasForeignKey(d => d.Aa042CstId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA042_OSUSR_E9A_CSICP_AA032_CSTICM_AA042_CST_ID");

                //entity.HasOne(d => d.Aa042CstOrigem).WithMany(p => p.OsusrE9aCsicpAa042s)
                //    .HasForeignKey(d => d.Aa042CstOrigemid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA042_OSUSR_E9A_CSICP_AA031_CSTORI_AA042_CST_ORIGEMID");

                //entity.HasOne(d => d.Uf).WithMany(p => p.OsusrE9aCsicpAa042s)
                //    .HasForeignKey(d => d.Ufid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_AA042_OSUSR_E9A_CSICP_AA027_UFID");
            });

        }
    }
}
