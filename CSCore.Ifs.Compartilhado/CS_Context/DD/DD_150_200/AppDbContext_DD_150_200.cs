using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {


        public virtual DbSet<CSICP_DD150> OsusrDfwCsicpDd150s { get; set; }

        public virtual DbSet<CSICP_DD150Conf> OsusrDfwCsicpDd150Confs { get; set; }

        public virtual DbSet<CSICP_DD150St> OsusrDfwCsicpDd150Sts { get; set; }

        public virtual DbSet<CSICP_DD151> OsusrDfwCsicpDd151s { get; set; }

        public virtual DbSet<CSICP_DD152> OsusrDfwCsicpDd152s { get; set; }

        public virtual DbSet<CSICP_DD153> OsusrDfwCsicpDd153s { get; set; }

        public virtual DbSet<CSICP_DD154> OsusrDfwCsicpDd154s { get; set; }

        public virtual DbSet<CSICP_DD155> OsusrDfwCsicpDd155s { get; set; }

        public virtual DbSet<CSICP_DD156> OsusrDfwCsicpDd156s { get; set; }

        public virtual DbSet<CSICP_DD156Rg> OsusrDfwCsicpDd156Rgs { get; set; }

        public virtual DbSet<CSICP_DD157> OsusrDfwCsicpDd157s { get; set; }

        public virtual DbSet<CSICP_DD158> OsusrDfwCsicpDd158s { get; set; }

        public virtual DbSet<CSICP_DD158Tp> OsusrDfwCsicpDd158Tps { get; set; }

        public virtual DbSet<CSICP_DD159> OsusrDfwCsicpDd159s { get; set; }

        public virtual DbSet<CSICP_DD160> OsusrDfwCsicpDd160s { get; set; }

        public virtual DbSet<CSICP_DD161> OsusrDfwCsicpDd161s { get; set; }

        public virtual DbSet<CSICP_DD162> OsusrDfwCsicpDd162s { get; set; }

        public virtual DbSet<CSICP_DD163> OsusrDfwCsicpDd163s { get; set; }

        public virtual DbSet<CSICP_DD165> OsusrDfwCsicpDd165s { get; set; }

        public virtual DbSet<CSICP_DD165Tcp> OsusrDfwCsicpDd165Tcps { get; set; }

        public virtual DbSet<CSICP_DD166> OsusrDfwCsicpDd166s { get; set; }

        public virtual DbSet<CSICP_DD166Stat> OsusrDfwCsicpDd166Stats { get; set; }

        public virtual DbSet<CSICP_DD167> OsusrDfwCsicpDd167s { get; set; }

        public virtual DbSet<CSICP_DD168Tp> OsusrDfwCsicpDd168Tps { get; set; }

        public virtual DbSet<CSICP_DD190> OsusrDfwCsicpDd190s { get; set; }

        public virtual DbSet<CSICP_DD191> OsusrDfwCsicpDd191s { get; set; }

        public virtual DbSet<CSICP_DD191St> OsusrDfwCsicpDd191Sts { get; set; }

        public virtual DbSet<CSICP_DD192> OsusrDfwCsicpDd192s { get; set; }

        public virtual DbSet<CSICP_DD192Tp> OsusrDfwCsicpDd192Tps { get; set; }

        public virtual DbSet<CSICP_DD193> OsusrDfwCsicpDd193s { get; set; }

        public virtual DbSet<CSICP_DD194> OsusrDfwCsicpDd194s { get; set; }

        public virtual DbSet<CSICP_DD195> OsusrDfwCsicpDd195s { get; set; }

        public virtual DbSet<CSICP_DD196> OsusrDfwCsicpDd196s { get; set; }

        public virtual DbSet<CSICP_DD197> OsusrDfwCsicpDd197s { get; set; }

        public virtual DbSet<CSICP_DD198> OsusrDfwCsicpDd198s { get; set; }

        public virtual DbSet<CSICP_DD199> OsusrDfwCsicpDd199s { get; set; }

        public virtual DbSet<CSICP_DD199det> OsusrDfwCsicpDd199dets { get; set; }

        public virtual DbSet<CSICP_DD200> OsusrDfwCsicpDd200s { get; set; }

        public virtual DbSet<CSICP_DD201> OsusrDfwCsicpDd201s { get; set; }

        public virtual DbSet<CSICP_DD202> OsusrDfwCsicpDd202s { get; set; }

        public virtual DbSet<CSICP_DD203Tp> OsusrDfwCsicpDd203Tps { get; set; }

        public virtual DbSet<CSICP_DD204> OsusrDfwCsicpDd204s { get; set; }

        public virtual DbSet<CSICP_DD205> OsusrDfwCsicpDd205s { get; set; }

        public virtual DbSet<CSICP_DD205Stat> OsusrDfwCsicpDd205Stats { get; set; }

        public virtual DbSet<CSICP_DD210> OsusrDfwCsicpDd210s { get; set; }

        public virtual DbSet<CSICP_DD211> OsusrDfwCsicpDd211s { get; set; }

        public virtual DbSet<CSICP_DD270> OsusrDfwCsicpDd270s { get; set; }

        public virtual DbSet<CSICP_DD271Ide> OsusrDfwCsicpDd271Ides { get; set; }

        public virtual DbSet<CSICP_DD272Prod> OsusrDfwCsicpDd272Prods { get; set; }

        public virtual DbSet<CSICP_DD273Xml> OsusrDfwCsicpDd273Xmls { get; set; }

        public virtual DbSet<CSICP_DD274Uploadxml> OsusrDfwCsicpDd274Uploadxmls { get; set; }

        partial void OnModelCreating_CSICP_DD_150_200(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD150>(entity =>
            {
                entity.HasKey(e => e.Dd150Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD150");

                entity.ToTable("OSUSR_DFW_CSICP_DD150");

                entity.HasIndex(e => new { e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Dagenda, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_13DD150_DAGENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_13DD150_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Statusid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_14DD150_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Confirmaid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_16DD150_CONFIRMAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Dhprevisao, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_16DD150_DHPREVISAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Dhregistro, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_16DD150_DHREGISTRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_19DD150_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Montadorrespid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_20DD150_MONTADORRESPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD150_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD150_9TENANT_ID");

                entity.Property(e => e.Dd150Id).HasColumnName("DD150_ID");
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd150Confirmaid).HasColumnName("DD150_CONFIRMAID");
                entity.Property(e => e.Dd150Dagenda)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DAGENDA");
                entity.Property(e => e.Dd150Dconfirmacliente)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DCONFIRMACLIENTE");
                entity.Property(e => e.Dd150Dfinalmontagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DFINALMONTAGEM");
                entity.Property(e => e.Dd150Dhprevisao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DHPREVISAO");
                entity.Property(e => e.Dd150Dhregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DHREGISTRO");
                entity.Property(e => e.Dd150Diniciomontagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DINICIOMONTAGEM");
                entity.Property(e => e.Dd150Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_DREGISTRO");
                entity.Property(e => e.Dd150Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD150_EMAIL");
                entity.Property(e => e.Dd150Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD150_ESTABID");
                entity.Property(e => e.Dd150Hagenda)
                    .HasColumnType("datetime")
                    .HasColumnName("DD150_HAGENDA");
                entity.Property(e => e.Dd150Isactive).HasColumnName("DD150_ISACTIVE");
                entity.Property(e => e.Dd150Isentregue).HasColumnName("DD150_ISENTREGUE");
                entity.Property(e => e.Dd150Montadorrespid)
                    .HasMaxLength(36)
                    .HasColumnName("DD150_MONTADORRESPID");
                entity.Property(e => e.Dd150Msgcliente)
                    .HasMaxLength(500)
                    .HasColumnName("DD150_MSGCLIENTE");
                entity.Property(e => e.Dd150Observacao)
                    .HasMaxLength(250)
                    .HasColumnName("DD150_OBSERVACAO");
                entity.Property(e => e.Dd150Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD150_PROTOCOLNUMBER");
                entity.Property(e => e.Dd150Satisfacaocliente).HasColumnName("DD150_SATISFACAOCLIENTE");
                entity.Property(e => e.Dd150Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD150_SMS");
                entity.Property(e => e.Dd150Statusid).HasColumnName("DD150_STATUSID");
                entity.Property(e => e.Dd150Thorasmontg)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("DD150_THORASMONTG");
                entity.Property(e => e.Dd150Thoraspadrao)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("DD150_THORASPADRAO");
                entity.Property(e => e.Dd150Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD150_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");






            });

            modelBuilder.Entity<CSICP_DD150Conf>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD150_CONF");

                entity.ToTable("OSUSR_DFW_CSICP_DD150_CONF");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD150St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD150_ST");

                entity.ToTable("OSUSR_DFW_CSICP_DD150_ST");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsCodginterno).HasColumnName("CS_CODGINTERNO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD151>(entity =>
            {
                entity.HasKey(e => e.Dd151Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD151");

                entity.ToTable("OSUSR_DFW_CSICP_DD151");

                entity.HasIndex(e => new { e.Dd156Regramontgid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD151_18DD156_REGRAMONTGID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD151_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD151_8DD150_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD151_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD151_9TENANT_ID");

                entity.Property(e => e.Dd151Id).HasColumnName("DD151_ID");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd150Id).HasColumnName("DD150_ID");
                entity.Property(e => e.Dd151LogPmontador)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("DD151_LOG_PMONTADOR");
                entity.Property(e => e.Dd151LogPsobrefaturliq)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("DD151_LOG_PSOBREFATURLIQ");
                entity.Property(e => e.Dd151LogTfaturliq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD151_LOG_TFATURLIQ");
                entity.Property(e => e.Dd151Qmontagem)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD151_QMONTAGEM");
                entity.Property(e => e.Dd156Regramontgid).HasColumnName("DD156_REGRAMONTGID");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD152>(entity =>
            {
                entity.HasKey(e => e.Dd152Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD152");

                entity.ToTable("OSUSR_DFW_CSICP_DD152");

                entity.HasIndex(e => new { e.Dd150Statusid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD152_14DD150_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd152Montadorid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD152_16DD152_MONTADORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd151Detmontagemid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD152_19DD151_DETMONTAGEMID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD152_9TENANT_ID");

                entity.Property(e => e.Dd152Id).HasColumnName("DD152_ID");
                entity.Property(e => e.Dd150Statusid).HasColumnName("DD150_STATUSID");
                entity.Property(e => e.Dd151Detmontagemid).HasColumnName("DD151_DETMONTAGEMID");
                entity.Property(e => e.Dd152Dfinalmontagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD152_DFINALMONTAGEM");
                entity.Property(e => e.Dd152Diniciomontagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD152_DINICIOMONTAGEM");
                entity.Property(e => e.Dd152Montadorid)
                    .HasMaxLength(36)
                    .HasColumnName("DD152_MONTADORID");
                entity.Property(e => e.Dd152Pincentivo)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD152_PINCENTIVO");
                entity.Property(e => e.Dd152Vbasevenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD152_VBASEVENDA");
                entity.Property(e => e.Dd152Vcomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD152_VCOMISSAO");
                entity.Property(e => e.Dd152Vunitmontagem)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD152_VUNITMONTAGEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD153>(entity =>
            {
                entity.HasKey(e => e.Dd153Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD153");

                entity.ToTable("OSUSR_DFW_CSICP_DD153");

                entity.HasIndex(e => new { e.Dd153Dagenda, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD153_13DD153_DAGENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd153Montadorid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD153_16DD153_MONTADORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD153_8DD150_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD153_9TENANT_ID");

                entity.Property(e => e.Dd153Id).HasColumnName("DD153_ID");
                entity.Property(e => e.Dd150Id).HasColumnName("DD150_ID");
                entity.Property(e => e.Dd153Dagenda)
                    .HasColumnType("datetime")
                    .HasColumnName("DD153_DAGENDA");
                entity.Property(e => e.Dd153Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD153_DREGISTRO");
                entity.Property(e => e.Dd153Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD153_HORA");
                entity.Property(e => e.Dd153Isactive).HasColumnName("DD153_ISACTIVE");
                entity.Property(e => e.Dd153Montadorid)
                    .HasMaxLength(36)
                    .HasColumnName("DD153_MONTADORID");
                entity.Property(e => e.Dd153Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD153_USUARIOPROPID");
                entity.Property(e => e.Dd160Perfilid).HasColumnName("DD160_PERFILID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD154>(entity =>
            {
                entity.HasKey(e => e.Dd154Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD154");

                entity.ToTable("OSUSR_DFW_CSICP_DD154");

                entity.HasIndex(e => new { e.Dd154Montadorid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD154_16DD154_MONTADORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd151Detmontagemid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD154_19DD151_DETMONTAGEMID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD154_9TENANT_ID");

                entity.Property(e => e.Dd154Id).HasColumnName("DD154_ID");
                entity.Property(e => e.Dd151Detmontagemid).HasColumnName("DD151_DETMONTAGEMID");
                entity.Property(e => e.Dd154Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD154_DREGISTRO");
                entity.Property(e => e.Dd154Ispendente).HasColumnName("DD154_ISPENDENTE");
                entity.Property(e => e.Dd154Mensagem)
                    .HasMaxLength(256)
                    .HasColumnName("DD154_MENSAGEM");
                entity.Property(e => e.Dd154Montadorid)
                    .HasMaxLength(36)
                    .HasColumnName("DD154_MONTADORID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD155>(entity =>
            {
                entity.HasKey(e => e.Dd155Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD155");

                entity.ToTable("OSUSR_DFW_CSICP_DD155");

                entity.HasIndex(e => new { e.Dd155Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD155_13DD155_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd155Perfilprincid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD155_19DD155_PERFILPRINCID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD155_9TENANT_ID");

                entity.Property(e => e.Dd155Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD155_ID");
                entity.Property(e => e.Dd155Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD155_ESTABID");
                entity.Property(e => e.Dd155Peficiencia)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD155_PEFICIENCIA");
                entity.Property(e => e.Dd155Perfilprincid).HasColumnName("DD155_PERFILPRINCID");
                entity.Property(e => e.Dd155Qhorasmax).HasColumnName("DD155_QHORASMAX");
                entity.Property(e => e.Dd155Qhoraspadrao).HasColumnName("DD155_QHORASPADRAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD156>(entity =>
            {
                entity.HasKey(e => e.Dd156Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD156");

                entity.ToTable("OSUSR_DFW_CSICP_DD156");

                entity.HasIndex(e => new { e.Gg008Produtoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD156_15GG008_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd156Regramontgid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD156_18DD156_REGRAMONTGID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD156_9TENANT_ID");

                entity.Property(e => e.Dd156Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD156_ID");
                entity.Property(e => e.Dd156Isautomatico).HasColumnName("DD156_ISAUTOMATICO");
                entity.Property(e => e.Dd156Psobrefaturliq)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("DD156_PSOBREFATURLIQ");
                entity.Property(e => e.Dd156Qmontador).HasColumnName("DD156_QMONTADOR");
                entity.Property(e => e.Dd156Regramontgid).HasColumnName("DD156_REGRAMONTGID");
                entity.Property(e => e.Dd156Tempoestimado).HasColumnName("DD156_TEMPOESTIMADO");
                entity.Property(e => e.Dd156Vunitmontagem)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD156_VUNITMONTAGEM");
                entity.Property(e => e.Gg008Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_PRODUTOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD156Rg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD156_RG");

                entity.ToTable("OSUSR_DFW_CSICP_DD156_RG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD157>(entity =>
            {
                entity.HasKey(e => e.Dd157Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD157");

                entity.ToTable("OSUSR_DFW_CSICP_DD157");

                entity.HasIndex(e => new { e.Gg008Produtoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD157_15GG008_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD157_9TENANT_ID");

                entity.Property(e => e.Dd157Id).HasColumnName("DD157_ID");
                entity.Property(e => e.Dd157Descricao)
                    .HasMaxLength(120)
                    .HasColumnName("DD157_DESCRICAO");
                entity.Property(e => e.Dd157Qtd)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("DD157_QTD");
                entity.Property(e => e.Gg008Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_PRODUTOID");
                entity.Property(e => e.Gg008Produtosecid)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_PRODUTOSECID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD158>(entity =>
            {
                entity.HasKey(e => e.Dd158Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD158");

                entity.ToTable("OSUSR_DFW_CSICP_DD158");

                entity.HasIndex(e => new { e.Dd158Intextid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_14DD158_INTEXTID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd160Perfilid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_14DD160_PERFILID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy001Usuarioid, e.Dd158Contafornid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_15SY001_USUARIOID_17DD158_CONTAFORNID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Sy001Usuarioid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_15SY001_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd158Contafornid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_17DD158_CONTAFORNID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd158Nomemontador, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD158_18DD158_NOMEMONTADOR_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD158_9TENANT_ID");

                entity.Property(e => e.Dd158Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD158_ID");
                entity.Property(e => e.Dd158Contafornid)
                    .HasMaxLength(36)
                    .HasColumnName("DD158_CONTAFORNID");
                entity.Property(e => e.Dd158Intextid).HasColumnName("DD158_INTEXTID");
                entity.Property(e => e.Dd158Isactive).HasColumnName("DD158_ISACTIVE");
                entity.Property(e => e.Dd158Nomemontador)
                    .HasMaxLength(60)
                    .HasColumnName("DD158_NOMEMONTADOR");
                entity.Property(e => e.Dd158Pcomissao)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("DD158_PCOMISSAO");
                entity.Property(e => e.Dd158Pcomissao2)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("DD158_PCOMISSAO2");
                entity.Property(e => e.Dd160Perfilid).HasColumnName("DD160_PERFILID");
                entity.Property(e => e.Sy001Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("SY001_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD158Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD158_TP");

                entity.ToTable("OSUSR_DFW_CSICP_DD158_TP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD159>(entity =>
            {
                entity.HasKey(e => e.Dd159Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD159");

                entity.ToTable("OSUSR_DFW_CSICP_DD159");

                entity.HasIndex(e => new { e.Dd159UfId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD159_11DD159_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd159PaisId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD159_13DD159_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd159CidadeId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD159_15DD159_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD159_8DD150_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD159_9TENANT_ID");

                entity.Property(e => e.Dd159Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD159_ID");
                entity.Property(e => e.Dd150Id).HasColumnName("DD150_ID");
                entity.Property(e => e.Dd159Cep).HasColumnName("DD159_CEP");
                entity.Property(e => e.Dd159CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD159_CIDADE_ID");
                entity.Property(e => e.Dd159Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD159_COMPLEMENTO");
                entity.Property(e => e.Dd159Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD159_LOGRADOURO");
                entity.Property(e => e.Dd159Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD159_NOMEBAIRRO");
                entity.Property(e => e.Dd159Numero)
                    .HasMaxLength(15)
                    .HasColumnName("DD159_NUMERO");
                entity.Property(e => e.Dd159PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD159_PAIS_ID");
                entity.Property(e => e.Dd159Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD159_PERIMETRO");
                entity.Property(e => e.Dd159Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD159_SMS");
                entity.Property(e => e.Dd159Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD159_TELEFONE");
                entity.Property(e => e.Dd159UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD159_UF_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD160>(entity =>
            {
                entity.HasKey(e => e.Dd160Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD160");

                entity.ToTable("OSUSR_DFW_CSICP_DD160");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD160_9TENANT_ID");

                entity.Property(e => e.Dd160Id).HasColumnName("DD160_ID");
                entity.Property(e => e.Dd160Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD160_DESCRICAO");
                entity.Property(e => e.Dd160Pinccompartilhado)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD160_PINCCOMPARTILHADO");
                entity.Property(e => e.Dd160Pincentivo)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD160_PINCENTIVO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD161>(entity =>
            {
                entity.HasKey(e => e.Dd161Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD161");

                entity.ToTable("OSUSR_DFW_CSICP_DD161");

                entity.HasIndex(e => new { e.Dd161EstabId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD161_14DD161_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd161Descambiente, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD161_18DD161_DESCAMBIENTE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD161_9TENANT_ID");

                entity.Property(e => e.Dd161Id).HasColumnName("DD161_ID");
                entity.Property(e => e.Dd161Dcriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD161_DCRIACAO");
                entity.Property(e => e.Dd161Descambiente)
                    .HasMaxLength(50)
                    .HasColumnName("DD161_DESCAMBIENTE");
                entity.Property(e => e.Dd161Descdetalhada)
                    .HasMaxLength(250)
                    .HasColumnName("DD161_DESCDETALHADA");
                entity.Property(e => e.Dd161EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD161_ESTAB_ID");
                entity.Property(e => e.Dd161Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD161_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD162>(entity =>
            {
                entity.HasKey(e => e.Dd162Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD162");

                entity.ToTable("OSUSR_DFW_CSICP_DD162");

                entity.HasIndex(e => new { e.Dd162EstabId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD162_14DD162_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD162_9TENANT_ID");

                entity.Property(e => e.Dd162Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD162_ID");
                entity.Property(e => e.Dd162Ambienteid).HasColumnName("DD162_AMBIENTEID");
                entity.Property(e => e.Dd162Descdetalhada)
                    .HasMaxLength(250)
                    .HasColumnName("DD162_DESCDETALHADA");
                entity.Property(e => e.Dd162Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD162_DESCRICAO");
                entity.Property(e => e.Dd162EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD162_ESTAB_ID");
                entity.Property(e => e.Dd162Isactive).HasColumnName("DD162_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD163>(entity =>
            {
                entity.HasKey(e => e.Dd163Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD163");

                entity.ToTable("OSUSR_DFW_CSICP_DD163");

                entity.HasIndex(e => new { e.Dd163Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD163_19DD163_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd162Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD163_8DD162_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD163_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD163_9TENANT_ID");

                entity.Property(e => e.Dd163Id).HasColumnName("DD163_ID");
                entity.Property(e => e.Dd162Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD162_ID");
                entity.Property(e => e.Dd162Qtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD162_QTD");
                entity.Property(e => e.Dd163Anotacao)
                    .HasMaxLength(100)
                    .HasColumnName("DD163_ANOTACAO");
                entity.Property(e => e.Dd163Dcriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD163_DCRIACAO");
                entity.Property(e => e.Dd163Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD163_USUARIOPROPID");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD165>(entity =>
            {
                entity.HasKey(e => e.Dd165Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD165");

                entity.ToTable("OSUSR_DFW_CSICP_DD165");

                entity.HasIndex(e => new { e.Dd165Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD165_13DD165_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd165Tcupomid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD165_14DD165_TCUPOMID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD165_9TENANT_ID");

                entity.Property(e => e.Dd165Id).HasColumnName("DD165_ID");
                entity.Property(e => e.Dd165Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD165_ESTABID");
                entity.Property(e => e.Dd165Isperiodocontrolado).HasColumnName("DD165_ISPERIODOCONTROLADO");
                entity.Property(e => e.Dd165Isperiodomensal).HasColumnName("DD165_ISPERIODOMENSAL");
                entity.Property(e => e.Dd165Isperiodoquinz).HasColumnName("DD165_ISPERIODOQUINZ");
                entity.Property(e => e.Dd165Pcupomdesc)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD165_PCUPOMDESC");
                entity.Property(e => e.Dd165Qdiasmais).HasColumnName("DD165_QDIASMAIS");
                entity.Property(e => e.Dd165Qdiasmenos).HasColumnName("DD165_QDIASMENOS");
                entity.Property(e => e.Dd165Tcupomid).HasColumnName("DD165_TCUPOMID");
                entity.Property(e => e.Dd165Vcupomdesc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD165_VCUPOMDESC");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD165Tcp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD165_TCP");

                entity.ToTable("OSUSR_DFW_CSICP_DD165_TCP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD166>(entity =>
            {
                entity.HasKey(e => e.Dd166Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD166");

                entity.ToTable("OSUSR_DFW_CSICP_DD166");

                entity.HasIndex(e => new { e.Dd166Contaid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_13DD166_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_13DD166_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Statusid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_14DD166_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Tcupomid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_14DD166_TCUPOMID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_19DD166_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Ncupomdesconto, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD166_20DD166_NCUPOMDESCONTO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD166_9TENANT_ID");

                entity.Property(e => e.Dd166Id).HasColumnName("DD166_ID");
                entity.Property(e => e.Dd166Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD166_CONTAID");
                entity.Property(e => e.Dd166Dfinaluso)
                    .HasColumnType("datetime")
                    .HasColumnName("DD166_DFINALUSO");
                entity.Property(e => e.Dd166Diniciouso)
                    .HasColumnType("datetime")
                    .HasColumnName("DD166_DINICIOUSO");
                entity.Property(e => e.Dd166Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD166_DREGISTRO");
                entity.Property(e => e.Dd166Dresgate)
                    .HasColumnType("datetime")
                    .HasColumnName("DD166_DRESGATE");
                entity.Property(e => e.Dd166Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD166_EMAIL");
                entity.Property(e => e.Dd166Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD166_ESTABID");
                entity.Property(e => e.Dd166Ncupomdesconto)
                    .HasMaxLength(20)
                    .HasColumnName("DD166_NCUPOMDESCONTO");
                entity.Property(e => e.Dd166Pdesconto)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD166_PDESCONTO");
                entity.Property(e => e.Dd166Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD166_SMS");
                entity.Property(e => e.Dd166Statusid).HasColumnName("DD166_STATUSID");
                entity.Property(e => e.Dd166Tcupomid).HasColumnName("DD166_TCUPOMID");
                entity.Property(e => e.Dd166Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD166_USUARIOPROPID");
                entity.Property(e => e.Dd166Vdesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD166_VDESCONTO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD166Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD166_STAT");

                entity.ToTable("OSUSR_DFW_CSICP_DD166_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD167>(entity =>
            {
                entity.HasKey(e => e.Dd167Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD167");

                entity.ToTable("OSUSR_DFW_CSICP_DD167");

                entity.HasIndex(e => new { e.Dd167PvId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_11DD167_PV_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd167PdvId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_12DD167_PDV_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd167Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_13DD167_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd167NotaId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_13DD167_NOTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd167Tpeventoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_16DD167_TPEVENTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd167Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_19DD167_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd166Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD167_8DD166_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD167_9TENANT_ID");

                entity.Property(e => e.Dd167Id).HasColumnName("DD167_ID");
                entity.Property(e => e.Dd166Id).HasColumnName("DD166_ID");
                entity.Property(e => e.Dd167Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD167_DREGISTRO");
                entity.Property(e => e.Dd167Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD167_EMAIL");
                entity.Property(e => e.Dd167Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD167_ESTABID");
                entity.Property(e => e.Dd167Msg)
                    .HasMaxLength(250)
                    .HasColumnName("DD167_MSG");
                entity.Property(e => e.Dd167NotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD167_NOTA_ID");
                entity.Property(e => e.Dd167PdvId)
                    .HasMaxLength(36)
                    .HasColumnName("DD167_PDV_ID");
                entity.Property(e => e.Dd167PvId)
                    .HasMaxLength(36)
                    .HasColumnName("DD167_PV_ID");
                entity.Property(e => e.Dd167Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD167_SMS");
                entity.Property(e => e.Dd167Tpeventoid).HasColumnName("DD167_TPEVENTOID");
                entity.Property(e => e.Dd167Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD167_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD168Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD168_TP");

                entity.ToTable("OSUSR_DFW_CSICP_DD168_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs)
                    .HasMaxLength(10)
                    .HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD190>(entity =>
            {
                entity.HasKey(e => e.Dd190Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD190");

                entity.ToTable("OSUSR_DFW_CSICP_DD190");

                entity.HasIndex(e => new { e.Dd190Skid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_10DD190_SKID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Tagid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_11DD190_TAGID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190UfId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_11DD190_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Dmovto, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_12DD190_DMOVTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Colorid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_13DD190_COLORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Estabid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_13DD190_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190PaisId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_13DD190_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd196Grupoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_13DD196_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Statusid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_14DD190_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190CcustoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_15DD190_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190CidadeId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_15DD190_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190IdObrapai, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_16DD190_ID_OBRAPAI_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Usuarioalt, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_16DD190_USUARIOALT_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190AgcobradorId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_19DD190_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190CondPagtoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_19DD190_COND_PAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190FormapagtoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_19DD190_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Resptecnicoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_19DD190_RESPTECNICOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_19DD190_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Contaclienteid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_20DD190_CONTACLIENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190Protocolnumber, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_20DD190_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd190ResponsavelId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD190_20DD190_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD190_9TENANT_ID");

                entity.Property(e => e.Dd190Id).HasColumnName("DD190_ID");
                entity.Property(e => e.Dd190AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_AGCOBRADOR_ID");
                entity.Property(e => e.Dd190Bairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD190_BAIRRO");
                entity.Property(e => e.Dd190CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_CCUSTO_ID");
                entity.Property(e => e.Dd190Cep).HasColumnName("DD190_CEP");
                entity.Property(e => e.Dd190CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_CIDADE_ID");
                entity.Property(e => e.Dd190Colorid)
                    .HasMaxLength(50)
                    .HasColumnName("DD190_COLORID");
                entity.Property(e => e.Dd190Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD190_COMPLEMENTO");
                entity.Property(e => e.Dd190CondPagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_COND_PAGTO_ID");
                entity.Property(e => e.Dd190Contaclienteid)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_CONTACLIENTEID");
                entity.Property(e => e.Dd190Dalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD190_DALTERACAO");
                entity.Property(e => e.Dd190Descricao)
                    .HasMaxLength(250)
                    .HasColumnName("DD190_DESCRICAO");
                entity.Property(e => e.Dd190Dfinalexec)
                    .HasColumnType("datetime")
                    .HasColumnName("DD190_DFINALEXEC");
                entity.Property(e => e.Dd190Dinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD190_DINCLUSAO");
                entity.Property(e => e.Dd190Dinicioexec)
                    .HasColumnType("datetime")
                    .HasColumnName("DD190_DINICIOEXEC");
                entity.Property(e => e.Dd190Dmovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD190_DMOVTO");
                entity.Property(e => e.Dd190Estabid)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_ESTABID");
                entity.Property(e => e.Dd190FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_FORMAPAGTO_ID");
                entity.Property(e => e.Dd190IdObrapai).HasColumnName("DD190_ID_OBRAPAI");
                entity.Property(e => e.Dd190Isgeradofinanc).HasColumnName("DD190_ISGERADOFINANC");
                entity.Property(e => e.Dd190Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD190_LOGRADOURO");
                entity.Property(e => e.Dd190Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD190_NUMERO");
                entity.Property(e => e.Dd190PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_PAIS_ID");
                entity.Property(e => e.Dd190Pandamento)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD190_PANDAMENTO");
                entity.Property(e => e.Dd190Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD190_PERIMETRO");
                entity.Property(e => e.Dd190Pexecucao)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD190_PEXECUCAO");
                entity.Property(e => e.Dd190Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD190_PROTOCOLNUMBER");
                entity.Property(e => e.Dd190ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_RESPONSAVEL_ID");
                entity.Property(e => e.Dd190Resptecnicoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_RESPTECNICOID");
                entity.Property(e => e.Dd190Skid)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_SKID");
                entity.Property(e => e.Dd190Statusid).HasColumnName("DD190_STATUSID");
                entity.Property(e => e.Dd190Tag)
                    .HasMaxLength(15)
                    .HasColumnName("DD190_TAG");
                entity.Property(e => e.Dd190Tagid).HasColumnName("DD190_TAGID");
                entity.Property(e => e.Dd190Threxec)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD190_THREXEC");
                entity.Property(e => e.Dd190Thrtarefa)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD190_THRTAREFA");
                entity.Property(e => e.Dd190UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_UF_ID");
                entity.Property(e => e.Dd190Usuarioalt)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_USUARIOALT");
                entity.Property(e => e.Dd190Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD190_USUARIOPROPID");
                entity.Property(e => e.Dd190Valorobra)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD190_VALOROBRA");
                entity.Property(e => e.Dd196Grupoid).HasColumnName("DD196_GRUPOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD191>(entity =>
            {
                entity.HasKey(e => e.Dd191Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD191");

                entity.ToTable("OSUSR_DFW_CSICP_DD191");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD191_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd191Produtoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD191_15DD191_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd191Tipoprodutoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD191_19DD191_TIPOPRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD191_9TENANT_ID");

                entity.Property(e => e.Dd191Id).HasColumnName("DD191_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd191Nroserie)
                    .HasMaxLength(1000)
                    .HasColumnName("DD191_NROSERIE");
                entity.Property(e => e.Dd191Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD191_PRODUTOID");
                entity.Property(e => e.Dd191Qtdcontratada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD191_QTDCONTRATADA");
                entity.Property(e => e.Dd191Qtdentregue)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD191_QTDENTREGUE");
                entity.Property(e => e.Dd191Qtdsolicitada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD191_QTDSOLICITADA");
                entity.Property(e => e.Dd191Saldoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD191_SALDOID");
                entity.Property(e => e.Dd191Tipoprodutoid).HasColumnName("DD191_TIPOPRODUTOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });

            modelBuilder.Entity<CSICP_DD191St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD191_ST");

                entity.ToTable("OSUSR_DFW_CSICP_DD191_ST");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD192>(entity =>
            {
                entity.HasKey(e => e.Dd192Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD192");

                entity.ToTable("OSUSR_DFW_CSICP_DD192");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD192_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd192Fpagtoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD192_14DD192_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd192Condicaoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD192_16DD192_CONDICAOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD192_9TENANT_ID");

                entity.Property(e => e.Dd192Id).HasColumnName("DD192_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd192ChaveVincId)
                    .HasMaxLength(36)
                    .HasColumnName("DD192_CHAVE_VINC_ID");
                entity.Property(e => e.Dd192Condicaoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD192_CONDICAOID");
                entity.Property(e => e.Dd192DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD192_DATA_MOVIMENTO");
                entity.Property(e => e.Dd192Fpagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD192_FPAGTOID");
                entity.Property(e => e.Dd192Nroparcelas).HasColumnName("DD192_NROPARCELAS");
                entity.Property(e => e.Dd192Qtd).HasColumnName("DD192_QTD");
                entity.Property(e => e.Dd192Valor1aparcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD192_VALOR_1APARCELA");
                entity.Property(e => e.Dd192ValorPago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD192_VALOR_PAGO");
                entity.Property(e => e.Dd192ValorTotalpago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD192_VALOR_TOTALPAGO");
                entity.Property(e => e.Dd192ValorTroco)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD192_VALOR_TROCO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD192Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD192_TP");

                entity.ToTable("OSUSR_DFW_CSICP_DD192_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD193>(entity =>
            {
                entity.HasKey(e => e.Dd193Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD193");

                entity.ToTable("OSUSR_DFW_CSICP_DD193");

                entity.HasIndex(e => new { e.Dd192Memcalculoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD193_18DD192_MEMCALCULOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd193TituloCrId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD193_18DD193_TITULO_CR_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD193_9TENANT_ID");

                entity.Property(e => e.Dd193Id).HasColumnName("DD193_ID");
                entity.Property(e => e.Dd192Memcalculoid).HasColumnName("DD192_MEMCALCULOID");
                entity.Property(e => e.Dd193DataVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD193_DATA_VENCTO");
                entity.Property(e => e.Dd193DataVenctoOri)
                    .HasColumnType("datetime")
                    .HasColumnName("DD193_DATA_VENCTO_ORI");
                entity.Property(e => e.Dd193Parcela).HasColumnName("DD193_PARCELA");
                entity.Property(e => e.Dd193Pfxtitulo)
                    .HasMaxLength(3)
                    .HasColumnName("DD193_PFXTITULO");
                entity.Property(e => e.Dd193Sfxtitulo)
                    .HasMaxLength(2)
                    .HasColumnName("DD193_SFXTITULO");
                entity.Property(e => e.Dd193Titulo)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD193_TITULO");
                entity.Property(e => e.Dd193TituloCrId)
                    .HasMaxLength(36)
                    .HasColumnName("DD193_TITULO_CR_ID");
                entity.Property(e => e.Dd193ValorParcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD193_VALOR_PARCELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD194>(entity =>
            {
                entity.HasKey(e => e.Dd194Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD194");

                entity.ToTable("OSUSR_DFW_CSICP_DD194");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD194_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD194_9TENANT_ID");

                entity.Property(e => e.Dd194Id).HasColumnName("DD194_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd194Descricao)
                    .HasMaxLength(150)
                    .HasColumnName("DD194_DESCRICAO");
                entity.Property(e => e.Dd194Filetype)
                    .HasMaxLength(500)
                    .HasColumnName("DD194_FILETYPE");
                entity.Property(e => e.Dd194Objeto).HasColumnName("DD194_OBJETO");
                entity.Property(e => e.Dd194Ordem).HasColumnName("DD194_ORDEM");
                entity.Property(e => e.Dd194Path)
                    .HasMaxLength(250)
                    .HasColumnName("DD194_PATH");
                entity.Property(e => e.Filename)
                    .HasMaxLength(250)
                    .HasColumnName("FILENAME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD195>(entity =>
            {
                entity.HasKey(e => e.Dd195Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD195");

                entity.ToTable("OSUSR_DFW_CSICP_DD195");

                entity.HasIndex(e => new { e.Dd195Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD195_19DD195_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd191Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD195_8DD191_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD195_9TENANT_ID");

                entity.Property(e => e.Dd195Id).HasColumnName("DD195_ID");
                entity.Property(e => e.Dd191Id).HasColumnName("DD191_ID");
                entity.Property(e => e.Dd195Dinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD195_DINCLUSAO");
                entity.Property(e => e.Dd195Motivo)
                    .HasMaxLength(50)
                    .HasColumnName("DD195_MOTIVO");
                entity.Property(e => e.Dd195Qtdanterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD195_QTDANTERIOR");
                entity.Property(e => e.Dd195Qtdnova)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD195_QTDNOVA");
                entity.Property(e => e.Dd195Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD195_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD196>(entity =>
            {
                entity.HasKey(e => e.Dd196Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD196");

                entity.ToTable("OSUSR_DFW_CSICP_DD196");

                entity.HasIndex(e => new { e.Dd196SkId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD196_11DD196_SK_ID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Dd196Descricao, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD196_15DD196_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd196Identificador, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD196_19DD196_IDENTIFICADOR_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD196_9TENANT_ID");

                entity.Property(e => e.Dd196Id).HasColumnName("DD196_ID");
                entity.Property(e => e.Dd196Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD196_DESCRICAO");
                entity.Property(e => e.Dd196Identificador)
                    .HasMaxLength(30)
                    .HasColumnName("DD196_IDENTIFICADOR");
                entity.Property(e => e.Dd196SkId)
                    .HasMaxLength(36)
                    .HasColumnName("DD196_SK_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD197>(entity =>
            {
                entity.HasKey(e => e.Dd197Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD197");

                entity.ToTable("OSUSR_DFW_CSICP_DD197");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD197_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd197Usuario, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD197_13DD197_USUARIO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD197_9TENANT_ID");

                entity.Property(e => e.Dd197Id).HasColumnName("DD197_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd197Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DD197_DATA");
                entity.Property(e => e.Dd197Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD197_HORA");
                entity.Property(e => e.Dd197Mensagem)
                    .HasMaxLength(250)
                    .HasColumnName("DD197_MENSAGEM");
                entity.Property(e => e.Dd197Usuario)
                    .HasMaxLength(36)
                    .HasColumnName("DD197_USUARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD198>(entity =>
            {
                entity.HasKey(e => e.Dd198Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD198");

                entity.ToTable("OSUSR_DFW_CSICP_DD198");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD198_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD198_9TENANT_ID");

                entity.Property(e => e.Dd198Id).HasColumnName("DD198_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd198Cargo)
                    .HasMaxLength(50)
                    .HasColumnName("DD198_CARGO");
                entity.Property(e => e.Dd198Celular)
                    .HasMaxLength(20)
                    .HasColumnName("DD198_CELULAR");
                entity.Property(e => e.Dd198Celular2)
                    .HasMaxLength(20)
                    .HasColumnName("DD198_CELULAR2");
                entity.Property(e => e.Dd198Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD198_EMAIL");
                entity.Property(e => e.Dd198Nomecontato)
                    .HasMaxLength(50)
                    .HasColumnName("DD198_NOMECONTATO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD199>(entity =>
            {
                entity.HasKey(e => e.Dd199Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD199");

                entity.ToTable("OSUSR_DFW_CSICP_DD199");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD199_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD199_8GG073_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD199_9TENANT_ID");

                entity.Property(e => e.Dd199Id).HasColumnName("DD199_ID");
                entity.Property(e => e.Bb007Respid)
                    .HasMaxLength(36)
                    .HasColumnName("BB007_RESPID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd199Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD199_DATAHORA");
                entity.Property(e => e.Dd199Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD199_USUARIOID");
                entity.Property(e => e.Gg073Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG073_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD199det>(entity =>
            {
                entity.HasKey(e => e.Dd199dId).HasName("OSPRK_OSUSR_DFW_CSICP_DD199DET");

                entity.ToTable("OSUSR_DFW_CSICP_DD199DET");

                entity.HasIndex(e => new { e.Dd199dMotivoid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD199DET_15DD199D_MOTIVOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd199Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD199DET_8DD199_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg074Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD199DET_8GG074_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD199DET_9TENANT_ID");

                entity.Property(e => e.Dd199dId).HasColumnName("DD199D_ID");
                entity.Property(e => e.Dd199Id).HasColumnName("DD199_ID");
                entity.Property(e => e.Dd199Qtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD199_QTD");
                entity.Property(e => e.Dd199dMotivoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD199D_MOTIVOID");
                entity.Property(e => e.Gg074Id).HasColumnName("GG074_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD200>(entity =>
            {
                entity.HasKey(e => e.Dd200Checklistid).HasName("OSPRK_OSUSR_DFW_CSICP_DD200");

                entity.ToTable("OSUSR_DFW_CSICP_DD200");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD200_9TENANT_ID");

                entity.Property(e => e.Dd200Checklistid).HasColumnName("DD200_CHECKLISTID");
                entity.Property(e => e.Dd200Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD200_DESCRICAO");
                entity.Property(e => e.Dd200Isactive).HasColumnName("DD200_ISACTIVE");
                entity.Property(e => e.Dd200Qtdestimada)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD200_QTDESTIMADA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD201>(entity =>
            {
                entity.HasKey(e => e.Dd201Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD201");

                entity.ToTable("OSUSR_DFW_CSICP_DD201");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD201_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd200Checklistid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD201_17DD200_CHECKLISTID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD201_9TENANT_ID");

                entity.Property(e => e.Dd201Id).HasColumnName("DD201_ID");
                entity.Property(e => e.Dd190Obraid).HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Dd200Checklistid).HasColumnName("DD200_CHECKLISTID");
                entity.Property(e => e.Dd201Qtdhrexec)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD201_QTDHREXEC");
                entity.Property(e => e.Dd201Qtdhrtarefa)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD201_QTDHRTAREFA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD202>(entity =>
            {
                entity.HasKey(e => e.Dd202Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD202");

                entity.ToTable("OSUSR_DFW_CSICP_DD202");

                entity.HasIndex(e => new { e.Dd202Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD202_12DD202_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd202Tpprofisionalid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD202_21DD202_TPPROFISIONALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD202_9TENANT_ID");

                entity.Property(e => e.Dd202Id).HasColumnName("DD202_ID");
                entity.Property(e => e.Dd202Datahorainc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD202_DATAHORAINC");
                entity.Property(e => e.Dd202Dthrinativado)
                    .HasColumnType("datetime")
                    .HasColumnName("DD202_DTHRINATIVADO");
                entity.Property(e => e.Dd202Isactive).HasColumnName("DD202_ISACTIVE");
                entity.Property(e => e.Dd202Obraid).HasColumnName("DD202_OBRAID");
                entity.Property(e => e.Dd202Tpprofisionalid).HasColumnName("DD202_TPPROFISIONALID");
                entity.Property(e => e.Dd202Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD202_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD203Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD203_TP");

                entity.ToTable("OSUSR_DFW_CSICP_DD203_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD204>(entity =>
            {
                entity.HasKey(e => e.Dd204Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD204");

                entity.ToTable("OSUSR_DFW_CSICP_DD204");

                entity.HasIndex(e => new { e.Dd204Descricaotag, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD204_18DD204_DESCRICAOTAG_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD204_9TENANT_ID");

                entity.Property(e => e.Dd204Id).HasColumnName("DD204_ID");
                entity.Property(e => e.Dd204Descricaotag)
                    .HasMaxLength(50)
                    .HasColumnName("DD204_DESCRICAOTAG");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD205>(entity =>
            {
                entity.HasKey(e => e.Dd205Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD205");

                entity.ToTable("OSUSR_DFW_CSICP_DD205");

                entity.HasIndex(e => new { e.Dd205Obraid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD205_12DD205_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd205Statid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD205_12DD205_STATID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd205Usuariopropid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD205_19DD205_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD205_9TENANT_ID");

                entity.Property(e => e.Dd205Id).HasColumnName("DD205_ID");
                entity.Property(e => e.Dd205Datahorainc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD205_DATAHORAINC");
                entity.Property(e => e.Dd205Obraid).HasColumnName("DD205_OBRAID");
                entity.Property(e => e.Dd205Ocorrencia)
                    .HasMaxLength(250)
                    .HasColumnName("DD205_OCORRENCIA");
                entity.Property(e => e.Dd205Responsavel)
                    .HasMaxLength(50)
                    .HasColumnName("DD205_RESPONSAVEL");
                entity.Property(e => e.Dd205Statid).HasColumnName("DD205_STATID");
                entity.Property(e => e.Dd205Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD205_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD205Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD205_STAT");

                entity.ToTable("OSUSR_DFW_CSICP_DD205_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD210>(entity =>
            {
                entity.HasKey(e => e.Dd210Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD210");

                entity.ToTable("OSUSR_DFW_CSICP_DD210");

                entity.HasIndex(e => new { e.Dd210Seguroid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD210_14DD210_SEGUROID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD210_9TENANT_ID");

                entity.Property(e => e.Dd210Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD210_ID");
                entity.Property(e => e.Dd210Contratoseguradora)
                    .HasMaxLength(50)
                    .HasColumnName("DD210_CONTRATOSEGURADORA");
                entity.Property(e => e.Dd210Pcomrep)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD210_PCOMREP");
                entity.Property(e => e.Dd210Piof)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD210_PIOF");
                entity.Property(e => e.Dd210Seguroid).HasColumnName("DD210_SEGUROID");
                entity.Property(e => e.GazinCdPlano)
                    .HasMaxLength(4)
                    .HasColumnName("GAZIN_CD_PLANO");
                entity.Property(e => e.GazinNrolote).HasColumnName("GAZIN_NROLOTE");
                entity.Property(e => e.GazinRangeNrosorte)
                    .HasMaxLength(50)
                    .HasColumnName("GAZIN_RANGE_NROSORTE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD211>(entity =>
            {
                entity.HasKey(e => e.Dd211Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD211");

                entity.ToTable("OSUSR_DFW_CSICP_DD211");

                entity.HasIndex(e => new { e.Dd210Seguroid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD211_14DD210_SEGUROID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD211_9TENANT_ID");

                entity.Property(e => e.Dd211Id).HasColumnName("DD211_ID");
                entity.Property(e => e.Dd210Seguroid).HasColumnName("DD210_SEGUROID");
                entity.Property(e => e.Dd211CodgProduto)
                    .HasMaxLength(20)
                    .HasColumnName("DD211_CODG_PRODUTO");
                entity.Property(e => e.Dd211Descproduto)
                    .HasMaxLength(150)
                    .HasColumnName("DD211_DESCPRODUTO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD270>(entity =>
            {
                entity.HasKey(e => e.Dd270Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD270");

                entity.ToTable("OSUSR_DFW_CSICP_DD270");

                entity.HasIndex(e => new { e.Dd270Chavenfe, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_14DD270_CHAVENFE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270EmpresaId, e.Dd270Ultnrocsdfeid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_16DD270_EMPRESA_ID_19DD270_ULTNROCSDFEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270EmpresaId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_16DD270_EMPRESA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270CondpagtoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_18DD270_CONDPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270FormapgtoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_18DD270_FORMAPGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270Usuariopropr, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_18DD270_USUARIOPROPR_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270Ultnrocsdfeid, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_19DD270_ULTNROCSDFEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD270_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD270_9TENANT_ID");

                entity.Property(e => e.Dd270Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd270Anotacao)
                    .HasMaxLength(200)
                    .HasColumnName("DD270_ANOTACAO");
                entity.Property(e => e.Dd270Chavenfe)
                    .HasMaxLength(50)
                    .HasColumnName("DD270_CHAVENFE");
                entity.Property(e => e.Dd270CondpagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_CONDPAGTO_ID");
                entity.Property(e => e.Dd270Datarecebimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD270_DATARECEBIMENTO");
                entity.Property(e => e.Dd270EmpresaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_EMPRESA_ID");
                entity.Property(e => e.Dd270FormapgtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_FORMAPGTO_ID");
                entity.Property(e => e.Dd270Iscontaspagar).HasColumnName("DD270_ISCONTASPAGAR");
                entity.Property(e => e.Dd270Nomefabricante)
                    .HasMaxLength(150)
                    .HasColumnName("DD270_NOMEFABRICANTE");
                entity.Property(e => e.Dd270Prtnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD270_PRTNUMBER");
                entity.Property(e => e.Dd270Ultnrocsdfeid).HasColumnName("DD270_ULTNROCSDFEID");
                entity.Property(e => e.Dd270Usuariopropr)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_USUARIOPROPR");
                entity.Property(e => e.Dd270Versaoxml)
                    .HasMaxLength(10)
                    .HasColumnName("DD270_VERSAOXML");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD271Ide>(entity =>
            {
                entity.HasKey(e => e.Dd271IdDd270).HasName("OSPRK_OSUSR_DFW_CSICP_DD271_IDE");

                entity.ToTable("OSUSR_DFW_CSICP_DD271_IDE");

                entity.HasIndex(e => new { e.Dd271ContaId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD271_IDE_14DD271_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd271IdDd270, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD271_IDE_14DD271_ID_DD270_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD271_IDE_9TENANT_ID");

                entity.Property(e => e.Dd271IdDd270)
                    .HasMaxLength(36)
                    .HasColumnName("DD271_ID_DD270");
                entity.Property(e => e.Dd271Cnf)
                    .HasMaxLength(50)
                    .HasColumnName("DD271_CNF");
                entity.Property(e => e.Dd271Cnumfg)
                    .HasMaxLength(7)
                    .HasColumnName("DD271_CNUMFG");
                entity.Property(e => e.Dd271ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD271_CONTA_ID");
                entity.Property(e => e.Dd271Cuf)
                    .HasMaxLength(50)
                    .HasColumnName("DD271_CUF");
                entity.Property(e => e.Dd271Demi)
                    .HasMaxLength(30)
                    .HasColumnName("DD271_DEMI");
                entity.Property(e => e.Dd271Dsaient)
                    .HasMaxLength(30)
                    .HasColumnName("DD271_DSAIENT");
                entity.Property(e => e.Dd271Hsaient)
                    .HasMaxLength(30)
                    .HasColumnName("DD271_HSAIENT");
                entity.Property(e => e.Dd271Indpag)
                    .HasMaxLength(1)
                    .HasColumnName("DD271_INDPAG");
                entity.Property(e => e.Dd271Mod)
                    .HasMaxLength(2)
                    .HasColumnName("DD271_MOD");
                entity.Property(e => e.Dd271Natop)
                    .HasMaxLength(250)
                    .HasColumnName("DD271_NATOP");
                entity.Property(e => e.Dd271Nnf)
                    .HasMaxLength(9)
                    .HasColumnName("DD271_NNF");
                entity.Property(e => e.Dd271Serie)
                    .HasMaxLength(3)
                    .HasColumnName("DD271_SERIE");
                entity.Property(e => e.Dd271Tpamb)
                    .HasMaxLength(1)
                    .HasColumnName("DD271_TPAMB");
                entity.Property(e => e.Dd271Tpemis)
                    .HasMaxLength(1)
                    .HasColumnName("DD271_TPEMIS");
                entity.Property(e => e.Dd271Tpnf)
                    .HasMaxLength(1)
                    .HasColumnName("DD271_TPNF");
                entity.Property(e => e.Dd271Xped)
                    .HasMaxLength(60)
                    .HasColumnName("DD271_XPED");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Dd271IdDd270Navigation).WithOne(p => p.OsusrDfwCsicpDd271Ide)
                    .HasForeignKey<CSICP_DD271Ide>(d => d.Dd271IdDd270)
                    .HasConstraintName("OSFRK_OSUSR_DFW_CSICP_DD271_IDE_OSUSR_DFW_CSICP_DD270_DD271_ID_DD270");
            });

            modelBuilder.Entity<CSICP_DD272Prod>(entity =>
            {
                entity.HasKey(e => e.Dd272Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD272_PROD");

                entity.ToTable("OSUSR_DFW_CSICP_DD272_PROD");

                entity.HasIndex(e => new { e.Dd272SaldoId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD272_PROD_14DD272_SALDO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd272KardexId, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD272_PROD_15DD272_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD272_PROD_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd270Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD272_PROD_8DD270_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD272_PROD_9TENANT_ID");

                entity.Property(e => e.Dd272Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD272_ID");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd270Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_ID");
                entity.Property(e => e.Dd272AtrNitemnum).HasColumnName("DD272_ATR_NITEMNUM");
                entity.Property(e => e.Dd272AttrNitem)
                    .HasMaxLength(3)
                    .HasColumnName("DD272_ATTR_NITEM");
                entity.Property(e => e.Dd272Bb027Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD272_BB027_ID");
                entity.Property(e => e.Dd272Cean)
                    .HasMaxLength(14)
                    .HasColumnName("DD272_CEAN");
                entity.Property(e => e.Dd272Ceantrib)
                    .HasMaxLength(50)
                    .HasColumnName("DD272_CEANTRIB");
                entity.Property(e => e.Dd272Cfop)
                    .HasMaxLength(4)
                    .HasColumnName("DD272_CFOP");
                entity.Property(e => e.Dd272Cnpjfabricante)
                    .HasMaxLength(14)
                    .HasColumnName("DD272_CNPJFABRICANTE");
                entity.Property(e => e.Dd272Cprod)
                    .HasMaxLength(60)
                    .HasColumnName("DD272_CPROD");
                entity.Property(e => e.Dd272Extipi)
                    .HasMaxLength(5)
                    .HasColumnName("DD272_EXTIPI");
                entity.Property(e => e.Dd272Ierelevanteid).HasColumnName("DD272_IERELEVANTEID");
                entity.Property(e => e.Dd272Indescala)
                    .HasMaxLength(1)
                    .HasColumnName("DD272_INDESCALA");
                entity.Property(e => e.Dd272Indtot)
                    .HasMaxLength(50)
                    .HasColumnName("DD272_INDTOT");
                entity.Property(e => e.Dd272Infadprod)
                    .HasMaxLength(500)
                    .HasColumnName("DD272_INFADPROD");
                entity.Property(e => e.Dd272KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD272_KARDEX_ID");
                entity.Property(e => e.Dd272Ncm)
                    .HasMaxLength(8)
                    .HasColumnName("DD272_NCM");
                entity.Property(e => e.Dd272Nomefabricante)
                    .HasMaxLength(150)
                    .HasColumnName("DD272_NOMEFABRICANTE");
                entity.Property(e => e.Dd272Qcom)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_QCOM");
                entity.Property(e => e.Dd272Qtrib)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_QTRIB");
                entity.Property(e => e.Dd272SaldoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD272_SALDO_ID");
                entity.Property(e => e.Dd272Ucom)
                    .HasMaxLength(6)
                    .HasColumnName("DD272_UCOM");
                entity.Property(e => e.Dd272Utrib)
                    .HasMaxLength(6)
                    .HasColumnName("DD272_UTRIB");
                entity.Property(e => e.Dd272Vdesc)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_VDESC");
                entity.Property(e => e.Dd272Vfrete)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_VFRETE");
                entity.Property(e => e.Dd272Voutro)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_VOUTRO");
                entity.Property(e => e.Dd272Vprod)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_VPROD");
                entity.Property(e => e.Dd272Vseg)
                    .HasMaxLength(15)
                    .HasColumnName("DD272_VSEG");
                entity.Property(e => e.Dd272Vuncom)
                    .HasMaxLength(21)
                    .HasColumnName("DD272_VUNCOM");
                entity.Property(e => e.Dd272Vuntrib)
                    .HasMaxLength(21)
                    .HasColumnName("DD272_VUNTRIB");
                entity.Property(e => e.Dd272Xped)
                    .HasMaxLength(60)
                    .HasColumnName("DD272_XPED");
                entity.Property(e => e.Dd272Xprod)
                    .HasMaxLength(120)
                    .HasColumnName("DD272_XPROD");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD273Xml>(entity =>
            {
                entity.HasKey(e => e.Dd270Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD273_XML");

                entity.ToTable("OSUSR_DFW_CSICP_DD273_XML");

                entity.HasIndex(e => new { e.Dd270Id, e.TenantId }, "OSIDX_OSUSR_DFW_CSICP_DD273_XML_8DD270_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD273_XML_9TENANT_ID");

                entity.Property(e => e.Dd270Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD270_ID");
                entity.Property(e => e.Dd273Tipo)
                    .HasMaxLength(30)
                    .HasColumnName("DD273_TIPO");
                entity.Property(e => e.Dd273Xml).HasColumnName("DD273_XML");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Dd270).WithOne(p => p.OsusrDfwCsicpDd273Xml)
                    .HasForeignKey<CSICP_DD273Xml>(d => d.Dd270Id)
                    .HasConstraintName("OSFRK_OSUSR_DFW_CSICP_DD273_XML_OSUSR_DFW_CSICP_DD270_DD270_ID");
            });

            modelBuilder.Entity<CSICP_DD274Uploadxml>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_DFW_CSICP_DD274_UPLOADXMLS");

                entity.ToTable("OSUSR_DFW_CSICP_DD274_UPLOADXMLS");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_DFW_CSICP_DD274_UPLOADXMLS_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Chave)
                    .HasMaxLength(44)
                    .HasColumnName("CHAVE");
                entity.Property(e => e.Content).HasColumnName("CONTENT");
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED");
                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .HasColumnName("FILENAME");
                entity.Property(e => e.Filesize)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("FILESIZE");
                entity.Property(e => e.Filetype)
                    .HasMaxLength(100)
                    .HasColumnName("FILETYPE");
                entity.Property(e => e.Isdanfe).HasColumnName("ISDANFE");
                entity.Property(e => e.Isimportada).HasColumnName("ISIMPORTADA");
                entity.Property(e => e.Numnfe).HasColumnName("NUMNFE");
                entity.Property(e => e.Sessionid)
                    .HasMaxLength(100)
                    .HasColumnName("SESSIONID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Xml).HasColumnName("XML");
            });
        }
    }
}
