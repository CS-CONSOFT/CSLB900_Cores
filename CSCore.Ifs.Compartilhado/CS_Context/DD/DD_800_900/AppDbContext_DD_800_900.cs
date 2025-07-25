using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD800> OsusrTeiCsicpDd800s { get; set; }

        public virtual DbSet<CSICP_DD800Tipo> OsusrTeiCsicpDd800Tipos { get; set; }

        public virtual DbSet<CSICP_DD801> OsusrTeiCsicpDd801s { get; set; }

        public virtual DbSet<CSICP_DD801Base> OsusrTeiCsicpDd801Bases { get; set; }

        public virtual DbSet<CSICP_DD801Otq> OsusrTeiCsicpDd801Otqs { get; set; }

        public virtual DbSet<CSICP_DD802> OsusrTeiCsicpDd802s { get; set; }

        public virtual DbSet<CSICP_DD803> OsusrTeiCsicpDd803s { get; set; }

        public virtual DbSet<CSICP_DD805> OsusrTeiCsicpDd805s { get; set; }

        public virtual DbSet<CSICP_DD806> OsusrTeiCsicpDd806s { get; set; }

        public virtual DbSet<CSICP_DD807> OsusrTeiCsicpDd807s { get; set; }

        public virtual DbSet<CSICP_DD807Lg> OsusrTeiCsicpDd807Lgs { get; set; }

        public virtual DbSet<CSICP_DD807Mod> OsusrTeiCsicpDd807Mods { get; set; }

        public virtual DbSet<CSICP_DD808> OsusrTeiCsicpDd808s { get; set; }

        public virtual DbSet<CSICP_DD810> OsusrTeiCsicpDd810s { get; set; }

        public virtual DbSet<CSICP_DD811> OsusrTeiCsicpDd811s { get; set; }

        public virtual DbSet<CSICP_DD812> OsusrTeiCsicpDd812s { get; set; }

        public virtual DbSet<CSICP_DD813> OsusrTeiCsicpDd813s { get; set; }

        public virtual DbSet<CSICP_DD820> OsusrTeiCsicpDd820s { get; set; }

        public virtual DbSet<CSICP_DD821> OsusrTeiCsicpDd821s { get; set; }

        public virtual DbSet<CSICP_DD822> OsusrTeiCsicpDd822s { get; set; }

        public virtual DbSet<CSICP_DD830> OsusrTeiCsicpDd830s { get; set; }

        public virtual DbSet<CSICP_DD840> OsusrTeiCsicpDd840s { get; set; }

        public virtual DbSet<CSICP_DD841> OsusrTeiCsicpDd841s { get; set; }

        public virtual DbSet<CSICP_DD842> OsusrTeiCsicpDd842s { get; set; }

        public virtual DbSet<CSICP_DD890> OsusrTeiCsicpDd890s { get; set; }

        public virtual DbSet<CSICP_DD891> OsusrTeiCsicpDd891s { get; set; }

        public virtual DbSet<CSICP_DD891Stat> OsusrTeiCsicpDd891Stats { get; set; }

        public virtual DbSet<CSICP_DD892> OsusrTeiCsicpDd892s { get; set; }

        public virtual DbSet<CSICP_DD892Tbl> OsusrTeiCsicpDd892Tbls { get; set; }

        public virtual DbSet<CSICP_DD893> OsusrTeiCsicpDd893s { get; set; }

        public virtual DbSet<CSICP_DD894> OsusrTeiCsicpDd894s { get; set; }

        public virtual DbSet<CSICP_DD894Nat> OsusrTeiCsicpDd894Nats { get; set; }

        public virtual DbSet<CSICP_DD895> OsusrTeiCsicpDd895s { get; set; }

        public virtual DbSet<CSICP_DD895Exec> OsusrTeiCsicpDd895Execs { get; set; }

        public virtual DbSet<CSICP_DD895Stat> OsusrTeiCsicpDd895Stats { get; set; }

        public virtual DbSet<CSICP_DD896> OsusrTeiCsicpDd896s { get; set; }

        public virtual DbSet<CSICP_DD901Freq> OsusrTeiCsicpDd901Freqs { get; set; }

        public virtual DbSet<CSICP_DD902Forma> OsusrTeiCsicpDd902Formas { get; set; }

        public virtual DbSet<CSICP_DD903Anfe> OsusrTeiCsicpDd903Anves { get; set; }

        public virtual DbSet<CSICP_DD904Snfe> OsusrTeiCsicpDd904Snves { get; set; }

        public virtual DbSet<CSICP_DD905Vnfe> OsusrTeiCsicpDd905Vnves { get; set; }

        public virtual DbSet<CSICP_DD906> OsusrTeiCsicpDd906s { get; set; }

        public virtual DbSet<CSICP_DD907> OsusrTeiCsicpDd907s { get; set; }

        public virtual DbSet<CSICP_DD908> OsusrTeiCsicpDd908s { get; set; }

        public virtual DbSet<CSICP_DD909> OsusrTeiCsicpDd909s { get; set; }

        public virtual DbSet<CSICP_DD910> OsusrTeiCsicpDd910s { get; set; }

        public virtual DbSet<CSICP_DD910St> OsusrTeiCsicpDd910Sts { get; set; }

        public virtual DbSet<CSICP_DD911> OsusrTeiCsicpDd911s { get; set; }

        public virtual DbSet<CSICP_DD998Valid> OsusrTeiCsicpDd998Valids { get; set; }

        public virtual DbSet<CSICP_DD999Nfcf> OsusrTeiCsicpDd999Nfcfs { get; set; }

        partial void OnModelCreating_CSICP_DD_800_900(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD800>(entity =>
            {
                entity.HasKey(e => e.Dd800Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD800");

                entity.ToTable("OSUSR_TEI_CSICP_DD800");

                entity.HasIndex(e => new { e.Dd800Datamov, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_13DD800_DATAMOV_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_15DD800_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800KardexId, e.Dd800Datamov, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_15DD800_KARDEX_ID_13DD800_DATAMOV_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800KardexId, e.Dd800Ano, e.Dd800Mes, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_15DD800_KARDEX_ID_9DD800_ANO_9DD800_MES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800KardexId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_15DD800_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800ProdutoId, e.Dd800Datamov, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_16DD800_PRODUTO_ID_13DD800_DATAMOV_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800ProdutoId, e.Dd800Ano, e.Dd800Mes, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_16DD800_PRODUTO_ID_9DD800_ANO_9DD800_MES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_16DD800_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd800Ano, e.Dd800Mes, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD800_9DD800_ANO_9DD800_MES_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD800_9TENANT_ID");

                entity.Property(e => e.Dd800Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD800_ID");
                entity.Property(e => e.Dd800Ano).HasColumnName("DD800_ANO");
                entity.Property(e => e.Dd800CancelTfatur)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_CANCEL_TFATUR");
                entity.Property(e => e.Dd800CancelTqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_CANCEL_TQTD");
                entity.Property(e => e.Dd800CompraTcompra)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_COMPRA_TCOMPRA");
                entity.Property(e => e.Dd800CompraTqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_COMPRA_TQTD");
                entity.Property(e => e.Dd800Datamov)
                    .HasColumnType("datetime")
                    .HasColumnName("DD800_DATAMOV");
                entity.Property(e => e.Dd800FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD800_FILIAL_ID");
                entity.Property(e => e.Dd800KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD800_KARDEX_ID");
                entity.Property(e => e.Dd800Mes).HasColumnName("DD800_MES");
                entity.Property(e => e.Dd800ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD800_PRODUTO_ID");
                entity.Property(e => e.Dd800TrocaTqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_TROCA_TQTD");
                entity.Property(e => e.Dd800TrocaTtroca)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_TROCA_TTROCA");
                entity.Property(e => e.Dd800VendaTfatur)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_VENDA_TFATUR");
                entity.Property(e => e.Dd800VendaTqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_VENDA_TQTD");
                entity.Property(e => e.Dd800VendaempromoTfatur)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_VENDAEMPROMO_TFATUR");
                entity.Property(e => e.Dd800VendaempromoTqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD800_VENDAEMPROMO_TQTD");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD800Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD800_TIPO");

                entity.ToTable("OSUSR_TEI_CSICP_DD800_TIPO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD801>(entity =>
            {
                entity.HasKey(e => e.Dd801Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD801");

                entity.ToTable("OSUSR_TEI_CSICP_DD801");

                entity.HasIndex(e => new { e.Dd801IdModulo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_15DD801_ID_MODULO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801KardexId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_15DD801_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto1Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO1_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto2Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO2_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto3Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO3_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto4Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO4_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto5Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO5_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto6Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO6_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto7Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO7_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto8Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO8_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto9Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_CPAGTO9_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801EmpresaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_16DD801_EMPRESA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto10Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_17DD801_CPAGTO10_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto11Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_17DD801_CPAGTO11_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto12Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_17DD801_CPAGTO12_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801NfentradaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_18DD801_NFENTRADA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Quemimprimiu, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_18DD801_QUEMIMPRIMIU_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801OrigemetiqId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_19DD801_ORIGEMETIQ_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Quematualizou, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_19DD801_QUEMATUALIZOU_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Usuariopropid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_19DD801_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801StatusPrecifId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_22DD801_STATUS_PRECIF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd803Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_8DD803_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD801_9TENANT_ID");

                entity.Property(e => e.Dd801Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_ID");
                entity.Property(e => e.Dd801Codbarras)
                    .HasMaxLength(20)
                    .HasColumnName("DD801_CODBARRAS");
                entity.Property(e => e.Dd801Cpagto10Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO10_ID");
                entity.Property(e => e.Dd801Cpagto11Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO11_ID");
                entity.Property(e => e.Dd801Cpagto12Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO12_ID");
                entity.Property(e => e.Dd801Cpagto1Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO1_ID");
                entity.Property(e => e.Dd801Cpagto2Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO2_ID");
                entity.Property(e => e.Dd801Cpagto3Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO3_ID");
                entity.Property(e => e.Dd801Cpagto4Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO4_ID");
                entity.Property(e => e.Dd801Cpagto5Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO5_ID");
                entity.Property(e => e.Dd801Cpagto6Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO6_ID");
                entity.Property(e => e.Dd801Cpagto7Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO7_ID");
                entity.Property(e => e.Dd801Cpagto8Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO8_ID");
                entity.Property(e => e.Dd801Cpagto9Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO9_ID");
                entity.Property(e => e.Dd801Datageracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD801_DATAGERACAO");
                entity.Property(e => e.Dd801Dataimpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD801_DATAIMPRESSAO");
                entity.Property(e => e.Dd801Dcriadoem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD801_DCRIADOEM");
                entity.Property(e => e.Dd801Dvalidadeprom)
                    .HasColumnType("datetime")
                    .HasColumnName("DD801_DVALIDADEPROM");
                entity.Property(e => e.Dd801EmpresaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_EMPRESA_ID");
                entity.Property(e => e.Dd801Formapagtoid1)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID1");
                entity.Property(e => e.Dd801Formapagtoid10)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID10");
                entity.Property(e => e.Dd801Formapagtoid11)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID11");
                entity.Property(e => e.Dd801Formapagtoid12)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID12");
                entity.Property(e => e.Dd801Formapagtoid2)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID2");
                entity.Property(e => e.Dd801Formapagtoid3)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID3");
                entity.Property(e => e.Dd801Formapagtoid4)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID4");
                entity.Property(e => e.Dd801Formapagtoid5)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID5");
                entity.Property(e => e.Dd801Formapagtoid6)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID6");
                entity.Property(e => e.Dd801Formapagtoid7)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID7");
                entity.Property(e => e.Dd801Formapagtoid8)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID8");
                entity.Property(e => e.Dd801Formapagtoid9)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID9");
                entity.Property(e => e.Dd801IdModulo)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_ID_MODULO");
                entity.Property(e => e.Dd801Imprimiu).HasColumnName("DD801_IMPRIMIU");
                entity.Property(e => e.Dd801Ismarcado).HasColumnName("DD801_ISMARCADO");
                entity.Property(e => e.Dd801KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_KARDEX_ID");
                entity.Property(e => e.Dd801NfentradaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_NFENTRADA_ID");
                entity.Property(e => e.Dd801OrigemetiqId).HasColumnName("DD801_ORIGEMETIQ_ID");
                entity.Property(e => e.Dd801Pjuros1)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS1");
                entity.Property(e => e.Dd801Pjuros10)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS10");
                entity.Property(e => e.Dd801Pjuros11)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS11");
                entity.Property(e => e.Dd801Pjuros12)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS12");
                entity.Property(e => e.Dd801Pjuros2)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS2");
                entity.Property(e => e.Dd801Pjuros3)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS3");
                entity.Property(e => e.Dd801Pjuros4)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS4");
                entity.Property(e => e.Dd801Pjuros5)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS5");
                entity.Property(e => e.Dd801Pjuros6)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS6");
                entity.Property(e => e.Dd801Pjuros7)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS7");
                entity.Property(e => e.Dd801Pjuros8)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS8");
                entity.Property(e => e.Dd801Pjuros9)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD801_PJUROS9");
                entity.Property(e => e.Dd801Prcparcela1)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA1");
                entity.Property(e => e.Dd801Prcparcela10)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA10");
                entity.Property(e => e.Dd801Prcparcela11)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA11");
                entity.Property(e => e.Dd801Prcparcela12)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA12");
                entity.Property(e => e.Dd801Prcparcela2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA2");
                entity.Property(e => e.Dd801Prcparcela3)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA3");
                entity.Property(e => e.Dd801Prcparcela4)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA4");
                entity.Property(e => e.Dd801Prcparcela5)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA5");
                entity.Property(e => e.Dd801Prcparcela6)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA6");
                entity.Property(e => e.Dd801Prcparcela7)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA7");
                entity.Property(e => e.Dd801Prcparcela8)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA8");
                entity.Property(e => e.Dd801Prcparcela9)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCPARCELA9");
                entity.Property(e => e.Dd801Prcvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA");
                entity.Property(e => e.Dd801Prcvenda1)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA1");
                entity.Property(e => e.Dd801Prcvenda10)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA10");
                entity.Property(e => e.Dd801Prcvenda11)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA11");
                entity.Property(e => e.Dd801Prcvenda12)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA12");
                entity.Property(e => e.Dd801Prcvenda2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA2");
                entity.Property(e => e.Dd801Prcvenda3)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA3");
                entity.Property(e => e.Dd801Prcvenda4)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA4");
                entity.Property(e => e.Dd801Prcvenda5)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA5");
                entity.Property(e => e.Dd801Prcvenda6)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA6");
                entity.Property(e => e.Dd801Prcvenda7)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA7");
                entity.Property(e => e.Dd801Prcvenda8)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA8");
                entity.Property(e => e.Dd801Prcvenda9)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA9");
                entity.Property(e => e.Dd801PrcvendaKdx)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD801_PRCVENDA_KDX");
                entity.Property(e => e.Dd801QtdEtiquetas).HasColumnName("DD801_QTD_ETIQUETAS");
                entity.Property(e => e.Dd801Quematualizou)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_QUEMATUALIZOU");
                entity.Property(e => e.Dd801Quemimprimiu)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_QUEMIMPRIMIU");
                entity.Property(e => e.Dd801StatusPrecifId).HasColumnName("DD801_STATUS_PRECIF_ID");
                entity.Property(e => e.Dd801Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_USUARIOPROPID");
                entity.Property(e => e.Dd803Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD803_ID");
                entity.Property(e => e.Gg019Codgbarraid)
                    .HasMaxLength(50)
                    .HasColumnName("GG019_CODGBARRAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD801Base>(entity =>
            {
                entity.HasKey(e => e.Dd801Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD801_BASE");

                entity.ToTable("OSUSR_TEI_CSICP_DD801_BASE");

                entity.HasIndex(e => new { e.Dd801Cpagto1Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO1_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto2Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO2_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto3Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO3_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto4Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO4_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto5Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO5_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto6Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO6_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto7Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO7_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto8Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO8_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto9Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_CPAGTO9_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801EmpresaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_16DD801_EMPRESA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto10Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_17DD801_CPAGTO10_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto11Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_17DD801_CPAGTO11_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Cpagto12Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_17DD801_CPAGTO12_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Usuariopropid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_19DD801_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD801_BASE_9TENANT_ID");

                entity.Property(e => e.Dd801Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_ID");
                entity.Property(e => e.Dd801Cpagto10Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO10_ID");
                entity.Property(e => e.Dd801Cpagto11Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO11_ID");
                entity.Property(e => e.Dd801Cpagto12Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO12_ID");
                entity.Property(e => e.Dd801Cpagto1Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO1_ID");
                entity.Property(e => e.Dd801Cpagto2Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO2_ID");
                entity.Property(e => e.Dd801Cpagto3Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO3_ID");
                entity.Property(e => e.Dd801Cpagto4Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO4_ID");
                entity.Property(e => e.Dd801Cpagto5Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO5_ID");
                entity.Property(e => e.Dd801Cpagto6Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO6_ID");
                entity.Property(e => e.Dd801Cpagto7Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO7_ID");
                entity.Property(e => e.Dd801Cpagto8Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO8_ID");
                entity.Property(e => e.Dd801Cpagto9Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_CPAGTO9_ID");
                entity.Property(e => e.Dd801Dcriadoem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD801_DCRIADOEM");
                entity.Property(e => e.Dd801EmpresaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_EMPRESA_ID");
                entity.Property(e => e.Dd801Formapagtoid1)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID1");
                entity.Property(e => e.Dd801Formapagtoid10)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID10");
                entity.Property(e => e.Dd801Formapagtoid11)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID11");
                entity.Property(e => e.Dd801Formapagtoid12)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID12");
                entity.Property(e => e.Dd801Formapagtoid2)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID2");
                entity.Property(e => e.Dd801Formapagtoid3)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID3");
                entity.Property(e => e.Dd801Formapagtoid4)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID4");
                entity.Property(e => e.Dd801Formapagtoid5)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID5");
                entity.Property(e => e.Dd801Formapagtoid6)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID6");
                entity.Property(e => e.Dd801Formapagtoid7)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID7");
                entity.Property(e => e.Dd801Formapagtoid8)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID8");
                entity.Property(e => e.Dd801Formapagtoid9)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_FORMAPAGTOID9");
                entity.Property(e => e.Dd801Identificacao)
                    .HasMaxLength(50)
                    .HasColumnName("DD801_IDENTIFICACAO");
                entity.Property(e => e.Dd801Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD801Otq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD801_OTQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD801_OTQ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD802>(entity =>
            {
                entity.HasKey(e => e.Dd802Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD802");

                entity.ToTable("OSUSR_TEI_CSICP_DD802");

                entity.HasIndex(e => new { e.Dd802KardexId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD802_15DD802_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd801Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD802_8DD801_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD802_9TENANT_ID");

                entity.Property(e => e.Dd802Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD802_ID");
                entity.Property(e => e.Dd801Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD801_ID");
                entity.Property(e => e.Dd802Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DD802_CREATEDATE");
                entity.Property(e => e.Dd802IdControle)
                    .HasMaxLength(36)
                    .HasColumnName("DD802_ID_CONTROLE");
                entity.Property(e => e.Dd802KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD802_KARDEX_ID");
                entity.Property(e => e.Dd802Precovenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD802_PRECOVENDA");
                entity.Property(e => e.Dd802Seqimpressao).HasColumnName("DD802_SEQIMPRESSAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD803>(entity =>
            {
                entity.HasKey(e => e.Dd803Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD803");

                entity.ToTable("OSUSR_TEI_CSICP_DD803");

                entity.HasIndex(e => new { e.Dd803Estabid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD803_13DD803_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd803Usuariopropid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD803_19DD803_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD803_9TENANT_ID");

                entity.Property(e => e.Dd803Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD803_ID");
                entity.Property(e => e.Dd803Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD803_DATAHORA");
                entity.Property(e => e.Dd803Dlimiteimp)
                    .HasColumnType("datetime")
                    .HasColumnName("DD803_DLIMITEIMP");
                entity.Property(e => e.Dd803Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD803_ESTABID");
                entity.Property(e => e.Dd803Protolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD803_PROTOLNUMBER");
                entity.Property(e => e.Dd803Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD803_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD805>(entity =>
            {
                entity.HasKey(e => e.Dd805Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD805");

                entity.ToTable("OSUSR_TEI_CSICP_DD805");

                entity.HasIndex(e => new { e.Dd805Tqtd, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD805_10DD805_TQTD_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd805Tvenda, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD805_12DD805_TVENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd805ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD805_16DD805_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd805Anomesmovimento, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD805_21DD805_ANOMESMOVIMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd805EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD805_24DD805_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD805_9TENANT_ID");

                entity.Property(e => e.Dd805Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD805_ID");
                entity.Property(e => e.Dd805Anomesmovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD805_ANOMESMOVIMENTO");
                entity.Property(e => e.Dd805CountLinha).HasColumnName("DD805_COUNT_LINHA");
                entity.Property(e => e.Dd805EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD805_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd805Pqtdabc)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PQTDABC");
                entity.Property(e => e.Dd805Pqtdacm)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PQTDACM");
                entity.Property(e => e.Dd805Pqtdpartic)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PQTDPARTIC");
                entity.Property(e => e.Dd805ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD805_PRODUTO_ID");
                entity.Property(e => e.Dd805Pvendaabc)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PVENDAABC");
                entity.Property(e => e.Dd805Pvendaacm)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PVENDAACM");
                entity.Property(e => e.Dd805Pvendapartic)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD805_PVENDAPARTIC");
                entity.Property(e => e.Dd805Qdiasuteis).HasColumnName("DD805_QDIASUTEIS");
                entity.Property(e => e.Dd805Qsaldoestq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_QSALDOESTQ");
                entity.Property(e => e.Dd805Qtdabc)
                    .HasMaxLength(1)
                    .HasColumnName("DD805_QTDABC");
                entity.Property(e => e.Dd805Qtdmax)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_QTDMAX");
                entity.Property(e => e.Dd805Qtdmedia)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_QTDMEDIA");
                entity.Property(e => e.Dd805Qtdmin)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_QTDMIN");
                entity.Property(e => e.Dd805Tempomedioestq).HasColumnName("DD805_TEMPOMEDIOESTQ");
                entity.Property(e => e.Dd805Tqtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_TQTD");
                entity.Property(e => e.Dd805Tvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_TVENDA");
                entity.Property(e => e.Dd805Vendaabc)
                    .HasMaxLength(1)
                    .HasColumnName("DD805_VENDAABC");
                entity.Property(e => e.Dd805Vvendamax)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_VVENDAMAX");
                entity.Property(e => e.Dd805Vvendamedia)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_VVENDAMEDIA");
                entity.Property(e => e.Dd805Vvendamin)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD805_VVENDAMIN");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD806>(entity =>
            {
                entity.HasKey(e => e.Dd806Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD806");

                entity.ToTable("OSUSR_TEI_CSICP_DD806");

                entity.HasIndex(e => new { e.Dd806ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD806_16DD806_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd806Anomesmovimento, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD806_21DD806_ANOMESMOVIMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd806EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD806_24DD806_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD806_9TENANT_ID");

                entity.Property(e => e.Dd806Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD806_ID");
                entity.Property(e => e.Dd806Anomesmovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD806_ANOMESMOVIMENTO");
                entity.Property(e => e.Dd806EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD806_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd806KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD806_KARDEX_ID");
                entity.Property(e => e.Dd806ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD806_PRODUTO_ID");
                entity.Property(e => e.Dd806Qconsumomedio)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD806_QCONSUMOMEDIO");
                entity.Property(e => e.Dd806Qestqmax)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD806_QESTQMAX");
                entity.Property(e => e.Dd806Qestqmin)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD806_QESTQMIN");
                entity.Property(e => e.Dd806Qle)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD806_QLE");
                entity.Property(e => e.Dd806Qpontopedido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD806_QPONTOPEDIDO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD807>(entity =>
            {
                entity.HasKey(e => e.Dd807Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD807");

                entity.ToTable("OSUSR_TEI_CSICP_DD807");

                entity.HasIndex(e => new { e.Dd807Linguagemid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD807_17DD807_LINGUAGEMID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd807Modimpresid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD807_17DD807_MODIMPRESID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD807_9TENANT_ID");

                entity.Property(e => e.Dd807Id).HasColumnName("DD807_ID");
                entity.Property(e => e.Dd807Aplicacao)
                    .HasMaxLength(200)
                    .HasColumnName("DD807_APLICACAO");
                entity.Property(e => e.Dd807Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD807_DESCRICAO");
                entity.Property(e => e.Dd807Linguagemid).HasColumnName("DD807_LINGUAGEMID");
                entity.Property(e => e.Dd807Modimpresid).HasColumnName("DD807_MODIMPRESID");
                entity.Property(e => e.Dd80Isactive).HasColumnName("DD80_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD807Lg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD807_LG");

                entity.ToTable("OSUSR_TEI_CSICP_DD807_LG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs).HasColumnName("CODGCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD807Mod>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD807_MOD");

                entity.ToTable("OSUSR_TEI_CSICP_DD807_MOD");

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

            modelBuilder.Entity<CSICP_DD808>(entity =>
            {
                entity.HasKey(e => e.Dd808Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD808");

                entity.ToTable("OSUSR_TEI_CSICP_DD808");

                entity.HasIndex(e => new { e.Dd807Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD808_8DD807_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD808_9TENANT_ID");

                entity.Property(e => e.Dd808Id).HasColumnName("DD808_ID");
                entity.Property(e => e.Dd807Id).HasColumnName("DD807_ID");
                entity.Property(e => e.Dd808Corpo).HasColumnName("DD808_CORPO");
                entity.Property(e => e.Dd808Numcolunas).HasColumnName("DD808_NUMCOLUNAS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD810>(entity =>
            {
                entity.HasKey(e => e.Dd810Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD810");

                entity.ToTable("OSUSR_TEI_CSICP_DD810");

                entity.HasIndex(e => new { e.Dd810Hashid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD810_12DD810_HASHID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd810CfopSaida, e.Dd810CfopEntrada, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD810_16DD810_CFOP_SAIDA_18DD810_CFOP_ENTRADA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd810CfopSaida, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD810_16DD810_CFOP_SAIDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd810CfopEntrada, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD810_18DD810_CFOP_ENTRADA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD810_9TENANT_ID");

                entity.Property(e => e.Dd810Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD810_ID");
                entity.Property(e => e.Dd810Anotacao)
                    .HasMaxLength(150)
                    .HasColumnName("DD810_ANOTACAO");
                entity.Property(e => e.Dd810CfopEntrada).HasColumnName("DD810_CFOP_ENTRADA");
                entity.Property(e => e.Dd810CfopSaida).HasColumnName("DD810_CFOP_SAIDA");
                entity.Property(e => e.Dd810Hashid)
                    .HasMaxLength(36)
                    .HasColumnName("DD810_HASHID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD811>(entity =>
            {
                entity.HasKey(e => e.Dd811Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD811");

                entity.ToTable("OSUSR_TEI_CSICP_DD811");

                entity.HasIndex(e => new { e.Dd811Hashid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_12DD811_HASHID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd811CfopId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_13DD811_CFOP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd811CstIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_16DD811_CST_IPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd811CstPisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_16DD811_CST_PIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd811CstIcmsId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_17DD811_CST_ICMS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd811CstCofinsId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD811_19DD811_CST_COFINS_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD811_9TENANT_ID");

                entity.Property(e => e.Dd811Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD811_ID");
                entity.Property(e => e.Dd811Anotacao)
                    .HasMaxLength(150)
                    .HasColumnName("DD811_ANOTACAO");
                entity.Property(e => e.Dd811CfopId).HasColumnName("DD811_CFOP_ID");
                entity.Property(e => e.Dd811CstCofinsId).HasColumnName("DD811_CST_COFINS_ID");
                entity.Property(e => e.Dd811CstIcmsId).HasColumnName("DD811_CST_ICMS_ID");
                entity.Property(e => e.Dd811CstIpiId).HasColumnName("DD811_CST_IPI_ID");
                entity.Property(e => e.Dd811CstPisId).HasColumnName("DD811_CST_PIS_ID");
                entity.Property(e => e.Dd811Hashid)
                    .HasMaxLength(36)
                    .HasColumnName("DD811_HASHID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD812>(entity =>
            {
                entity.HasKey(e => e.Dd812Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD812");

                entity.ToTable("OSUSR_TEI_CSICP_DD812");

                entity.HasIndex(e => new { e.Dd812EstabId, e.Dd812Dataregistro, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD812_14DD812_ESTAB_ID_18DD812_DATAREGISTRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd812EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD812_14DD812_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD812_9TENANT_ID");

                entity.Property(e => e.Dd812Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD812_ID");
                entity.Property(e => e.Bb012ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("BB012_CONTA_ID");
                entity.Property(e => e.Cc060ItemId)
                    .HasMaxLength(36)
                    .HasColumnName("CC060_ITEM_ID");
                entity.Property(e => e.Dd060ItemId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ITEM_ID");
                entity.Property(e => e.Dd812Datamovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD812_DATAMOVTO");
                entity.Property(e => e.Dd812Dataregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD812_DATAREGISTRO");
                entity.Property(e => e.Dd812Entsaida)
                    .HasMaxLength(10)
                    .HasColumnName("DD812_ENTSAIDA");
                entity.Property(e => e.Dd812EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD812_ESTAB_ID");
                entity.Property(e => e.Dd812NatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD812_NATOPERACAO_ID");
                entity.Property(e => e.Dd812NroNfCf).HasColumnName("DD812_NRO_NF_CF");
                entity.Property(e => e.Dd812Quantidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD812_QUANTIDADE");
                entity.Property(e => e.Dd812SaldoAnterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD812_SALDO_ANTERIOR");
                entity.Property(e => e.Dd812Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD812_SERIE");
                entity.Property(e => e.Gg008ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_PRODUTO_ID");
                entity.Property(e => e.Gg520SaldoId)
                    .HasMaxLength(36)
                    .HasColumnName("GG520_SALDO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD813>(entity =>
            {
                entity.HasKey(e => e.Dd813Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD813");

                entity.ToTable("OSUSR_TEI_CSICP_DD813");

                entity.HasIndex(e => new { e.Dd813CfopId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD813_13DD813_CFOP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd813FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD813_19DD813_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd813UsuarioaltId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD813_19DD813_USUARIOALT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd813UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD813_20DD813_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD813_9TENANT_ID");

                entity.Property(e => e.Dd813Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD813_ID");
                entity.Property(e => e.Dd813Anotacao)
                    .HasMaxLength(250)
                    .HasColumnName("DD813_ANOTACAO");
                entity.Property(e => e.Dd813CfopId).HasColumnName("DD813_CFOP_ID");
                entity.Property(e => e.Dd813Dalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD813_DALTERACAO");
                entity.Property(e => e.Dd813Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD813_DREGISTRO");
                entity.Property(e => e.Dd813FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD813_FORMAPAGTO_ID");
                entity.Property(e => e.Dd813UsuarioaltId)
                    .HasMaxLength(36)
                    .HasColumnName("DD813_USUARIOALT_ID");
                entity.Property(e => e.Dd813UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD813_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD820>(entity =>
            {
                entity.HasKey(e => e.Dd820Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD820");

                entity.ToTable("OSUSR_TEI_CSICP_DD820");

                entity.HasIndex(e => new { e.Dd820AProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD820_18DD820_A_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd820BProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD820_18DD820_B_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD820_9TENANT_ID");

                entity.Property(e => e.Dd820Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD820_ID");
                entity.Property(e => e.Dd820AProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD820_A_PRODUTO_ID");
                entity.Property(e => e.Dd820BProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD820_B_PRODUTO_ID");
                entity.Property(e => e.Dd820Dtultvenda)
                    .HasColumnType("datetime")
                    .HasColumnName("DD820_DTULTVENDA");
                entity.Property(e => e.Dd820QvendaA)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD820_QVENDA_A");
                entity.Property(e => e.Dd820QvendaB)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD820_QVENDA_B");
                entity.Property(e => e.Dd820Qvezes).HasColumnName("DD820_QVEZES");
                entity.Property(e => e.Dd820VvendaA)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD820_VVENDA_A");
                entity.Property(e => e.Dd820VvendaB)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD820_VVENDA_B");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD821>(entity =>
            {
                entity.HasKey(e => e.Dd821Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD821");

                entity.ToTable("OSUSR_TEI_CSICP_DD821");

                entity.HasIndex(e => new { e.Dd821FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD821_15DD821_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd821ProdutoaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD821_17DD821_PRODUTOA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd821ProdutobId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD821_17DD821_PRODUTOB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD821_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD821_9TENANT_ID");

                entity.Property(e => e.Dd821Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD821_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd821FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD821_FILIAL_ID");
                entity.Property(e => e.Dd821ProdutoaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD821_PRODUTOA_ID");
                entity.Property(e => e.Dd821ProdutobId)
                    .HasMaxLength(36)
                    .HasColumnName("DD821_PRODUTOB_ID");
                entity.Property(e => e.Dd821QtdProdutoa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD821_QTD_PRODUTOA");
                entity.Property(e => e.Dd821QtdProdutob)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD821_QTD_PRODUTOB");
                entity.Property(e => e.Dd821Vprodutoa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD821_VPRODUTOA");
                entity.Property(e => e.Dd821Vprodutob)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD821_VPRODUTOB");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD822>(entity =>
            {
                entity.HasKey(e => e.Dd822Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD822");

                entity.ToTable("OSUSR_TEI_CSICP_DD822");

                entity.HasIndex(e => new { e.Dd822FreqCtambemId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD822_21DD822_FREQ_CTAMBEM_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD822_9TENANT_ID");

                entity.Property(e => e.Dd822Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD822_ID");
                entity.Property(e => e.Dd822Dprxprocctambem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD822_DPRXPROCCTAMBEM");
                entity.Property(e => e.Dd822Dultprocctambem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD822_DULTPROCCTAMBEM");
                entity.Property(e => e.Dd822FreqCtambemId).HasColumnName("DD822_FREQ_CTAMBEM_ID");
                entity.Property(e => e.Dd822FrequenciaCtambem).HasColumnName("DD822_FREQUENCIA_CTAMBEM");
                entity.Property(e => e.Dd822Qtdminencontros).HasColumnName("DD822_QTDMINENCONTROS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD830>(entity =>
            {
                entity.HasKey(e => e.Dd830Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD830");

                entity.ToTable("OSUSR_TEI_CSICP_DD830");

                entity.HasIndex(e => new { e.Dd830Hashid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_12DD830_HASHID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd830IdEsitef, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_15DD830_ID_ESITEF_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd830Tpregistro, e.Dd830IdEsitef, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_16DD830_TPREGISTRO_15DD830_ID_ESITEF_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb001Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_8BB001_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd042Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_8DD042_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd072Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_8DD072_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Pd014Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD830_8PD014_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD830_9TENANT_ID");

                entity.Property(e => e.Dd830Id).HasColumnName("DD830_ID");
                entity.Property(e => e.Bb001Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB001_ID");
                entity.Property(e => e.Dd042Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ID");
                entity.Property(e => e.Dd072Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_ID");
                entity.Property(e => e.Dd830Codgbandsitef)
                    .HasMaxLength(5)
                    .HasColumnName("DD830_CODGBANDSITEF");
                entity.Property(e => e.Dd830Comando)
                    .HasMaxLength(3)
                    .HasColumnName("DD830_COMANDO");
                entity.Property(e => e.Dd830Dcreate)
                    .HasColumnType("datetime")
                    .HasColumnName("DD830_DCREATE");
                entity.Property(e => e.Dd830Dprimparcela)
                    .HasColumnType("datetime")
                    .HasColumnName("DD830_DPRIMPARCELA");
                entity.Property(e => e.Dd830Formapagto)
                    .HasMaxLength(1)
                    .HasColumnName("DD830_FORMAPAGTO");
                entity.Property(e => e.Dd830Hashid)
                    .HasMaxLength(36)
                    .HasColumnName("DD830_HASHID");
                entity.Property(e => e.Dd830IdEsitef).HasColumnName("DD830_ID_ESITEF");
                entity.Property(e => e.Dd830Inferp)
                    .HasMaxLength(100)
                    .HasColumnName("DD830_INFERP");
                entity.Property(e => e.Dd830Intervalopar)
                    .HasMaxLength(2)
                    .HasColumnName("DD830_INTERVALOPAR");
                entity.Property(e => e.Dd830Isautoconfirma).HasColumnName("DD830_ISAUTOCONFIRMA");
                entity.Property(e => e.Dd830Ispinpad).HasColumnName("DD830_ISPINPAD");
                entity.Property(e => e.Dd830Isprimparcavista).HasColumnName("DD830_ISPRIMPARCAVISTA");
                entity.Property(e => e.Dd830Ntransacao)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_NTRANSACAO");
                entity.Property(e => e.Dd830Operador)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_OPERADOR");
                entity.Property(e => e.Dd830Progresso)
                    .HasMaxLength(1)
                    .HasColumnName("DD830_PROGRESSO");
                entity.Property(e => e.Dd830Qparcela)
                    .HasMaxLength(3)
                    .HasColumnName("DD830_QPARCELA");
                entity.Property(e => e.Dd830Restricoes)
                    .HasMaxLength(50)
                    .HasColumnName("DD830_RESTRICOES");
                entity.Property(e => e.Dd830RetCompcanc).HasColumnName("DD830_RET_COMPCANC");
                entity.Property(e => e.Dd830RetCompcancestab).HasColumnName("DD830_RET_COMPCANCESTAB");
                entity.Property(e => e.Dd830RetCompcliente).HasColumnName("DD830_RET_COMPCLIENTE");
                entity.Property(e => e.Dd830RetCompestab).HasColumnName("DD830_RET_COMPESTAB");
                entity.Property(e => e.Dd830RetDautorizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD830_RET_DAUTORIZACAO");
                entity.Property(e => e.Dd830RetDcanc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD830_RET_DCANC");
                entity.Property(e => e.Dd830RetDoc)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_RET_DOC");
                entity.Property(e => e.Dd830RetHautorizacao)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_RET_HAUTORIZACAO");
                entity.Property(e => e.Dd830RetHcanc)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_RET_HCANC");
                entity.Property(e => e.Dd830RetIsautorizado)
                    .HasMaxLength(1)
                    .HasColumnName("DD830_RET_ISAUTORIZADO");
                entity.Property(e => e.Dd830RetMsg)
                    .HasMaxLength(250)
                    .HasColumnName("DD830_RET_MSG");
                entity.Property(e => e.Dd830RetNsu)
                    .HasMaxLength(40)
                    .HasColumnName("DD830_RET_NSU");
                entity.Property(e => e.Dd830RetProtocoltran)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_RET_PROTOCOLTRAN");
                entity.Property(e => e.Dd830SidLoja)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_SID_LOJA");
                entity.Property(e => e.Dd830SidTerminal)
                    .HasMaxLength(20)
                    .HasColumnName("DD830_SID_TERMINAL");
                entity.Property(e => e.Dd830Siptef)
                    .HasMaxLength(30)
                    .HasColumnName("DD830_SIPTEF");
                entity.Property(e => e.Dd830Status).HasColumnName("DD830_STATUS");
                entity.Property(e => e.Dd830Tipo).HasColumnName("DD830_TIPO");
                entity.Property(e => e.Dd830Tpparcela)
                    .HasMaxLength(1)
                    .HasColumnName("DD830_TPPARCELA");
                entity.Property(e => e.Dd830Tpregistro).HasColumnName("DD830_TPREGISTRO");
                entity.Property(e => e.Dd830Tptransacao)
                    .HasMaxLength(1)
                    .HasColumnName("DD830_TPTRANSACAO");
                entity.Property(e => e.Dd830VendaId).HasColumnName("DD830_VENDA_ID");
                entity.Property(e => e.Dd830Vtransacao)
                    .HasMaxLength(50)
                    .HasColumnName("DD830_VTRANSACAO");
                entity.Property(e => e.Pd014Id)
                    .HasMaxLength(36)
                    .HasColumnName("PD014_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });

            modelBuilder.Entity<CSICP_DD840>(entity =>
            {
                entity.HasKey(e => e.Dd840Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD840");

                entity.ToTable("OSUSR_TEI_CSICP_DD840");

                entity.HasIndex(e => new { e.Dd840AtId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_11DD840_AT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840Contaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_13DD840_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840NotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_13DD840_NOTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840EmpresaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_16DD840_EMPRESA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840UsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_16DD840_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840Formapagamentoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_22DD840_FORMAPAGAMENTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840LinkorigemNotaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD840_23DD840_LINKORIGEM_NOTAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD840_9TENANT_ID");

                entity.Property(e => e.Dd840Id).HasColumnName("DD840_ID");
                entity.Property(e => e.Dd840AtId)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_AT_ID");
                entity.Property(e => e.Dd840Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_CONTAID");
                entity.Property(e => e.Dd840Datarascunho)
                    .HasColumnType("datetime")
                    .HasColumnName("DD840_DATARASCUNHO");
                entity.Property(e => e.Dd840EmpresaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_EMPRESA_ID");
                entity.Property(e => e.Dd840Formapagamentoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_FORMAPAGAMENTOID");
                entity.Property(e => e.Dd840LinkorigemNotaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_LINKORIGEM_NOTAID");
                entity.Property(e => e.Dd840NotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_NOTA_ID");
                entity.Property(e => e.Dd840UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD840_USUARIO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD841>(entity =>
            {
                entity.HasKey(e => e.Dd841Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD841");

                entity.ToTable("OSUSR_TEI_CSICP_DD841");

                entity.HasIndex(e => new { e.Dd841SaldoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD841_14DD841_SALDO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd841Unidadeid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD841_15DD841_UNIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd841Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD841_18DD841_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd841RascunhovfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD841_20DD841_RASCUNHOVFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd841ProdutoVendaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD841_22DD841_PRODUTO_VENDA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD841_9TENANT_ID");

                entity.Property(e => e.Dd841Id).HasColumnName("DD841_ID");
                entity.Property(e => e.Dd841Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD841_CODBARRASALFA");
                entity.Property(e => e.Dd841Descricao)
                    .HasMaxLength(120)
                    .HasColumnName("DD841_DESCRICAO");
                entity.Property(e => e.Dd841Modentregaid).HasColumnName("DD841_MODENTREGAID");
                entity.Property(e => e.Dd841ProdutoVendaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD841_PRODUTO_VENDA_ID");
                entity.Property(e => e.Dd841Qtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD841_QTD");
                entity.Property(e => e.Dd841RascunhovfeId).HasColumnName("DD841_RASCUNHOVFE_ID");
                entity.Property(e => e.Dd841SaldoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD841_SALDO_ID");
                entity.Property(e => e.Dd841Unidadeid)
                    .HasMaxLength(36)
                    .HasColumnName("DD841_UNIDADEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD842>(entity =>
            {
                entity.HasKey(e => e.Dd842Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD842");

                entity.ToTable("OSUSR_TEI_CSICP_DD842");

                entity.HasIndex(e => new { e.Dd842UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_11DD842_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842PaisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_13DD842_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_14DD842_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842CidadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_15DD842_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842Tipodocto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_15DD842_TIPODOCTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842Ufveiculo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_15DD842_UFVEICULO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842UfreboqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_18DD842_UFREBOQUE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842UserOperadorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_22DD842_USER_OPERADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd842TransportadoraId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_23DD842_TRANSPORTADORA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd840Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD842_8DD840_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD842_9TENANT_ID");

                entity.Property(e => e.Dd842Id).HasColumnName("DD842_ID");
                entity.Property(e => e.Dd840Id).HasColumnName("DD840_ID");
                entity.Property(e => e.Dd842Balsa)
                    .HasMaxLength(20)
                    .HasColumnName("DD842_BALSA");
                entity.Property(e => e.Dd842Cep).HasColumnName("DD842_CEP");
                entity.Property(e => e.Dd842CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_CIDADE_ID");
                entity.Property(e => e.Dd842CnpjCpf)
                    .HasMaxLength(15)
                    .HasColumnName("DD842_CNPJ_CPF");
                entity.Property(e => e.Dd842Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD842_COMPLEMENTO");
                entity.Property(e => e.Dd842ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_CONTA_ID");
                entity.Property(e => e.Dd842DataCaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("DD842_DATA_CAIXA");
                entity.Property(e => e.Dd842Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD842_EMAIL");
                entity.Property(e => e.Dd842EnderecoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_ENDERECO_ID");
                entity.Property(e => e.Dd842IdentEstrangeiro)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_IDENT_ESTRANGEIRO");
                entity.Property(e => e.Dd842IeRg)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD842_IE_RG");
                entity.Property(e => e.Dd842Indfinal)
                    .HasMaxLength(1)
                    .HasColumnName("DD842_INDFINAL");
                entity.Property(e => e.Dd842Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD842_LOGRADOURO");
                entity.Property(e => e.Dd842Marcaveiculo)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_MARCAVEICULO");
                entity.Property(e => e.Dd842Nome)
                    .HasMaxLength(100)
                    .HasColumnName("DD842_NOME");
                entity.Property(e => e.Dd842Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_NOMEBAIRRO");
                entity.Property(e => e.Dd842Nometransp)
                    .HasMaxLength(100)
                    .HasColumnName("DD842_NOMETRANSP");
                entity.Property(e => e.Dd842Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD842_NUMERO");
                entity.Property(e => e.Dd842Numtransp)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_NUMTRANSP");
                entity.Property(e => e.Dd842Numtranspreboq)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_NUMTRANSPREBOQ");
                entity.Property(e => e.Dd842PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_PAIS_ID");
                entity.Property(e => e.Dd842Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD842_PERIMETRO");
                entity.Property(e => e.Dd842Placareboque)
                    .HasMaxLength(1050)
                    .HasColumnName("DD842_PLACAREBOQUE");
                entity.Property(e => e.Dd842Placaveiculo)
                    .HasMaxLength(10)
                    .HasColumnName("DD842_PLACAVEICULO");
                entity.Property(e => e.Dd842SendEmail).HasColumnName("DD842_SEND_EMAIL");
                entity.Property(e => e.Dd842SendSms).HasColumnName("DD842_SEND_SMS");
                entity.Property(e => e.Dd842Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD842_SMS");
                entity.Property(e => e.Dd842Suframa)
                    .HasMaxLength(20)
                    .HasColumnName("DD842_SUFRAMA");
                entity.Property(e => e.Dd842Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD842_TELEFONE");
                entity.Property(e => e.Dd842Tipo).HasColumnName("DD842_TIPO");
                entity.Property(e => e.Dd842Tipodocto).HasColumnName("DD842_TIPODOCTO");
                entity.Property(e => e.Dd842TransportadoraId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_TRANSPORTADORA_ID");
                entity.Property(e => e.Dd842UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_UF_ID");
                entity.Property(e => e.Dd842UfreboqueId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_UFREBOQUE_ID");
                entity.Property(e => e.Dd842Ufveiculo)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_UFVEICULO");
                entity.Property(e => e.Dd842UserOperadorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD842_USER_OPERADOR_ID");
                entity.Property(e => e.Dd842Vagao)
                    .HasMaxLength(50)
                    .HasColumnName("DD842_VAGAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD890>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD890");

                entity.ToTable("OSUSR_TEI_CSICP_DD890");

                entity.HasIndex(e => new { e.Tipoestatiscaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD890_15TIPOESTATISCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.DocId, e.Tipoestatiscaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD890_6DOC_ID_15TIPOESTATISCAID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD890_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.DocId)
                    .HasMaxLength(36)
                    .HasColumnName("DOC_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipoestatiscaid).HasColumnName("TIPOESTATISCAID");


            });

            modelBuilder.Entity<CSICP_DD891>(entity =>
            {
                entity.HasKey(e => e.Dd891Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD891");

                entity.ToTable("OSUSR_TEI_CSICP_DD891");

                entity.HasIndex(e => new { e.Dd891Statid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD891_12DD891_STATID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd891EstabelecimentoId, e.Dd891Tiporeg, e.Dd891Data, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD891_24DD891_ESTABELECIMENTO_ID_13DD891_TIPOREG_10DD891_DATA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd891EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD891_24DD891_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD891_8CC040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.Cc040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD891_8DD040_ID_8CC040_ID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD891_9TENANT_ID");

                entity.Property(e => e.Dd891Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD891_ID");
                entity.Property(e => e.Cc040Id)
                    .HasMaxLength(36)
                    .HasColumnName("CC040_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd891Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DD891_DATA");
                entity.Property(e => e.Dd891EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD891_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd891Msgerro)
                    .HasMaxLength(512)
                    .HasColumnName("DD891_MSGERRO");
                entity.Property(e => e.Dd891Statid).HasColumnName("DD891_STATID");
                entity.Property(e => e.Dd891Tiporeg).HasColumnName("DD891_TIPOREG");
                entity.Property(e => e.Dd891Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD891_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD891Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD891_STAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD891_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD892>(entity =>
            {
                entity.HasKey(e => e.Dd892Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD892");

                entity.ToTable("OSUSR_TEI_CSICP_DD892");

                entity.HasIndex(e => new { e.Dd882Tabelaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD892_14DD882_TABELAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd882Errsucessid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD892_17DD882_ERRSUCESSID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD892_9TENANT_ID");

                entity.Property(e => e.Dd892Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD892_ID");
                entity.Property(e => e.Dd882Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD882_DATAHORA");
                entity.Property(e => e.Dd882Errsucessid).HasColumnName("DD882_ERRSUCESSID");
                entity.Property(e => e.Dd882Msg)
                    .HasMaxLength(512)
                    .HasColumnName("DD882_MSG");
                entity.Property(e => e.Dd882Tabelaid).HasColumnName("DD882_TABELAID");
                entity.Property(e => e.Dd882TblId)
                    .HasMaxLength(36)
                    .HasColumnName("DD882_TBL_ID");
                entity.Property(e => e.Dd882Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD882_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD892Tbl>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD892_TBL");

                entity.ToTable("OSUSR_TEI_CSICP_DD892_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsCodginterno)
                    .HasMaxLength(10)
                    .HasColumnName("CS_CODGINTERNO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD893>(entity =>
            {
                entity.HasKey(e => e.Dd893Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD893");

                entity.ToTable("OSUSR_TEI_CSICP_DD893");

                entity.HasIndex(e => new { e.Dd883Estabid, e.Dd883TblId, e.Dd883Tabelaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD893_13DD883_ESTABID_12DD883_TBL_ID_14DD883_TABELAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd883Estabid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD893_13DD883_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd883Tabelaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD893_14DD883_TABELAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD893_9TENANT_ID");

                entity.Property(e => e.Dd893Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD893_ID");
                entity.Property(e => e.Dd883Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD883_DATAHORA");
                entity.Property(e => e.Dd883Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD883_ESTABID");
                entity.Property(e => e.Dd883Hash)
                    .HasMaxLength(50)
                    .HasColumnName("DD883_HASH");
                entity.Property(e => e.Dd883Istransf).HasColumnName("DD883_ISTRANSF");
                entity.Property(e => e.Dd883Tabelaid).HasColumnName("DD883_TABELAID");
                entity.Property(e => e.Dd883TblId)
                    .HasMaxLength(36)
                    .HasColumnName("DD883_TBL_ID");
                entity.Property(e => e.Dd883Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD883_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD894>(entity =>
            {
                entity.HasKey(e => e.Dd894Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD894");

                entity.ToTable("OSUSR_TEI_CSICP_DD894");

                entity.HasIndex(e => new { e.Dd894DoctoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD894_14DD894_DOCTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd894DoctoTipo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD894_16DD894_DOCTO_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd894DoctoParentId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD894_21DD894_DOCTO_PARENT_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD894_9TENANT_ID");

                entity.Property(e => e.Dd894Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD894_ID");
                entity.Property(e => e.Dd894Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD894_DATAHORA");
                entity.Property(e => e.Dd894DoctoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD894_DOCTO_ID");
                entity.Property(e => e.Dd894DoctoParentId)
                    .HasMaxLength(36)
                    .HasColumnName("DD894_DOCTO_PARENT_ID");
                entity.Property(e => e.Dd894DoctoTipo).HasColumnName("DD894_DOCTO_TIPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD894Nat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD894_NAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD894_NAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD895>(entity =>
            {
                entity.HasKey(e => e.Dd895Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD895");

                entity.ToTable("OSUSR_TEI_CSICP_DD895", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD895"));

                entity.HasIndex(e => new { e.Dd895Stat, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_10DD895_STAT_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd895Execid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_12DD895_EXECID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc030PedidoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_15CC030_PEDIDO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc020Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_8CC020_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_8CC040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Processid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD895_9PROCESSID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD895_9TENANT_ID");

                entity.Property(e => e.Dd895Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD895_ID");
                entity.Property(e => e.Cc020Id)
                    .HasMaxLength(36)
                    .HasColumnName("CC020_ID");
                entity.Property(e => e.Cc030PedidoId)
                    .HasMaxLength(36)
                    .HasColumnName("CC030_PEDIDO_ID");
                entity.Property(e => e.Cc040Id)
                    .HasMaxLength(36)
                    .HasColumnName("CC040_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd895Execid).HasColumnName("DD895_EXECID");
                entity.Property(e => e.Dd895Stat).HasColumnName("DD895_STAT");
                entity.Property(e => e.Processid).HasColumnName("PROCESSID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD895Exec>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD895_EXEC");

                entity.ToTable("OSUSR_TEI_CSICP_DD895_EXEC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD895Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD895_STAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD895_STAT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD896>(entity =>
            {
                entity.HasKey(e => e.Dd896Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD896");

                entity.ToTable("OSUSR_TEI_CSICP_DD896");

                entity.HasIndex(e => new { e.Dd896Hash, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_10DD896_HASH_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd886Qimpressoes, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_17DD886_QIMPRESSOES_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb001Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_8BB001_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Pd010Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD896_8PD010_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD896_9TENANT_ID");

                entity.Property(e => e.Dd896Id).HasColumnName("DD896_ID");
                entity.Property(e => e.Bb001Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB001_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd886Dimpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD886_DIMPRESSAO");
                entity.Property(e => e.Dd886Dmovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD886_DMOVTO");
                entity.Property(e => e.Dd886Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD886_DREGISTRO");
                entity.Property(e => e.Dd886Qimpressoes).HasColumnName("DD886_QIMPRESSOES");
                entity.Property(e => e.Dd886Ultimpusuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD886_ULTIMPUSUARIOID");
                entity.Property(e => e.Dd886Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD886_USUARIOPROPID");
                entity.Property(e => e.Dd896Hash)
                    .HasMaxLength(50)
                    .HasColumnName("DD896_HASH");
                entity.Property(e => e.Dd896Tipo).HasColumnName("DD896_TIPO");
                entity.Property(e => e.Dd896Url)
                    .HasMaxLength(500)
                    .HasColumnName("DD896_URL");
                entity.Property(e => e.Pd010Id)
                    .HasMaxLength(36)
                    .HasColumnName("PD010_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD901Freq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD901_FREQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD901_FREQ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD902Forma>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD902_FORMA");

                entity.ToTable("OSUSR_TEI_CSICP_DD902_FORMA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD903Anfe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD903_ANFE");

                entity.ToTable("OSUSR_TEI_CSICP_DD903_ANFE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Parametro)
                    .HasMaxLength(1)
                    .HasColumnName("PARAMETRO");
            });

            modelBuilder.Entity<CSICP_DD904Snfe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD904_SNFE");

                entity.ToTable("OSUSR_TEI_CSICP_DD904_SNFE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD905Vnfe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD905_VNFE");

                entity.ToTable("OSUSR_TEI_CSICP_DD905_VNFE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD906>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD906");

                entity.ToTable("OSUSR_TEI_CSICP_DD906");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD907>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD907");

                entity.ToTable("OSUSR_TEI_CSICP_DD907");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD908>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD908");

                entity.ToTable("OSUSR_TEI_CSICP_DD908");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD909>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD909");

                entity.ToTable("OSUSR_TEI_CSICP_DD909");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgFiscal)
                    .HasMaxLength(2)
                    .HasColumnName("CODG_FISCAL");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD910>(entity =>
            {
                entity.HasKey(e => e.Dd910Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD910");

                entity.ToTable("OSUSR_TEI_CSICP_DD910", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD910"));

                entity.HasIndex(e => new { e.Dd910Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD910_14DD910_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD910_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD910_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD910_9TENANT_ID");

                entity.Property(e => e.Dd910Id).HasColumnName("DD910_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd910Datahorainc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD910_DATAHORAINC");
                entity.Property(e => e.Dd910Iserro).HasColumnName("DD910_ISERRO");
                entity.Property(e => e.Dd910Json).HasColumnName("DD910_JSON");
                entity.Property(e => e.Dd910Mensagem)
                    .HasMaxLength(500)
                    .HasColumnName("DD910_MENSAGEM");
                entity.Property(e => e.Dd910Statusid).HasColumnName("DD910_STATUSID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD910St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD910_ST");

                entity.ToTable("OSUSR_TEI_CSICP_DD910_ST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD911>(entity =>
            {
                entity.HasKey(e => e.Dd911Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD911");

                entity.ToTable("OSUSR_TEI_CSICP_DD911", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD911"));

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD911_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD911_9TENANT_ID");

                entity.Property(e => e.Dd911Id).HasColumnName("DD911_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd911Datahorainc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD911_DATAHORAINC");
                entity.Property(e => e.Dd911Iserro).HasColumnName("DD911_ISERRO");
                entity.Property(e => e.Dd911Mensagem)
                    .HasMaxLength(500)
                    .HasColumnName("DD911_MENSAGEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD998Valid>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD998_VALID");

                entity.ToTable("OSUSR_TEI_CSICP_DD998_VALID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD999Nfcf>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD999_NFCF");

                entity.ToTable("OSUSR_TEI_CSICP_DD999_NFCF");

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
