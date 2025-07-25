
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_BB.BB01X;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb010> OsusrE9aCsicpBb010s { get; set; }

        public DbSet<CSICP_Bb011> OsusrE9aCsicpBb011s { get; set; }

        public DbSet<CSICP_Bb013> OsusrE9aCsicpBb013s { get; set; }

        public DbSet<CSICP_BB015> OsusrE9aCsicoBb015s { get; set; }

        public DbSet<CSICP_Bb017> OsusrE9aCsicpBb017s { get; set; }

        public DbSet<CSICP_Bb019> OsusrE9aCsicpBb019s { get; set; }

        partial void OnModelCreating_CSICP_BB01X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb010>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB010");

                entity.ToTable("OSUSR_E9A_CSICP_BB010");

                entity.HasIndex(e => new { e.Bb010Zona, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_10BB010_ZONA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Cidadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_14BB010_CIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010CcustoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_15BB010_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Banco01Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_16BB010_BANCO01_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Banco02Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_16BB010_BANCO02_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Banco03Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_16BB010_BANCO03_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Tiporotaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_16BB010_TIPOROTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb010Vendedorid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB010_16BB010_VENDEDORID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB010_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb010Banco01Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_BANCO01_ID");
                entity.Property(e => e.Bb010Banco02Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_BANCO02_ID");
                entity.Property(e => e.Bb010Banco03Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_BANCO03_ID");
                entity.Property(e => e.Bb010CcustoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_CCUSTO_ID");
                entity.Property(e => e.Bb010Cidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_CIDADEID");
                entity.Property(e => e.Bb010CodVendedor)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_COD_VENDEDOR");
                entity.Property(e => e.Bb010Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_CODIGO");
                entity.Property(e => e.Bb010ColPrecoTabela)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_COL_PRECO_TABELA");
                entity.Property(e => e.Bb010FoneContato)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB010_FONE_CONTATO");
                entity.Property(e => e.Bb010Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB010_ISACTIVE");
                entity.Property(e => e.Bb010Km)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_KM");
                entity.Property(e => e.Bb010Observacao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB010_OBSERVACAO");
                entity.Property(e => e.Bb010PeriodoRota)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_PERIODO_ROTA");
                entity.Property(e => e.Bb010PeriodoVisita)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_PERIODO_VISITA");
                entity.Property(e => e.Bb010Promotor)
                    .HasDefaultValue(0)
                    .HasColumnName("BB010_PROMOTOR");
                entity.Property(e => e.Bb010TabelaPreco)
                    .HasMaxLength(7)
                    .HasDefaultValue("")
                    .HasColumnName("BB010_TABELA_PRECO");
                entity.Property(e => e.Bb010Tiporotaid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_TIPOROTAID");
                entity.Property(e => e.Bb010Vendedorid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB010_VENDEDORID");
                entity.Property(e => e.Bb010Zona)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB010_ZONA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb011>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB011");

                entity.ToTable("OSUSR_E9A_CSICP_BB011");

                entity.HasIndex(e => new { e.Bb011Atividade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB011_15BB011_ATIVIDADE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB011_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb011Atividade)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB011_ATIVIDADE");
                entity.Property(e => e.Bb011Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB011_CODIGO");
                entity.Property(e => e.Bb011IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB011_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb013>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB013");

                entity.ToTable("OSUSR_E9A_CSICP_BB013");

                entity.HasIndex(e => new { e.Bb013Bairro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB013_12BB013_BAIRRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb013Codgcidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB013_16BB013_CODGCIDADE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB013_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb013Bairro)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB013_BAIRRO");
                entity.Property(e => e.Bb013Codgcidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB013_CODGCIDADE");
                entity.Property(e => e.Bb013Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB013_CODIGO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_BB015>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB015");

                entity.ToTable("OSUSR_E9A_CSICP_BB015");

                entity.HasIndex(e => new { e.Bb015Skid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB015_10BB015_SKID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb015Marketplace, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB015_17BB015_MARKETPLACE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb015Acessomarketplace, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB015_23BB015_ACESSOMARKETPLACE_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB015_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Bb015Acessomarketplace)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB015_ACESSOMARKETPLACE");
                entity.Property(e => e.Bb015Cnpj)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB015_CNPJ");
                entity.Property(e => e.Bb015Marketplace)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB015_MARKETPLACE");
                entity.Property(e => e.Bb015Skid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB015_SKID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb017>(entity =>
            {
                entity.HasKey(e => e.Bb017Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB017");

                entity.ToTable("OSUSR_E9A_CSICP_BB017");

                entity.HasIndex(e => new { e.Bb017Fpagtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_14BB017_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_15BB017_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017Condicaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_16BB017_CONDICAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017Entliquidada, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_18BB017_ENTLIQUIDADA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017CmdTefVdId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_19BB017_CMD_TEF_VD_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017Parcliquidadas, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_20BB017_PARCLIQUIDADAS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb017CmdTefCancId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB017_21BB017_CMD_TEF_CANC_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB017_9TENANT_ID");

                entity.Property(e => e.Bb017Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB017_ID");
                entity.Property(e => e.Bb017CmdTefCancId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_CMD_TEF_CANC_ID");
                entity.Property(e => e.Bb017CmdTefVdId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_CMD_TEF_VD_ID");
                entity.Property(e => e.Bb017Condicaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_CONDICAOID");
                entity.Property(e => e.Bb017Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_EMPRESAID");
                entity.Property(e => e.Bb017Entliquidada)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_ENTLIQUIDADA");
                entity.Property(e => e.Bb017Fatoracrescimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("BB017_FATORACRESCIMO");
                entity.Property(e => e.Bb017Fatorsementrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("BB017_FATORSEMENTRADA");
                entity.Property(e => e.Bb017Fpagtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_FPAGTOID");
                entity.Property(e => e.Bb017Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("BB017_ORDEM");
                entity.Property(e => e.Bb017Parcliquidadas)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB017_PARCLIQUIDADAS");
                entity.Property(e => e.Bb017Vacimade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB017_VACIMADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.NavBb008Condicao).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017Condicaoid);
                entity.HasOne(e => e.NavCSICP_PD001Ctef_Cmd_Tef_Canc).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017CmdTefCancId);
                entity.HasOne(e => e.NavCSICP_PD001Ctef_Cmd_Tef_VD).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017CmdTefVdId);
                entity.HasOne(e => e.NavStatica_BB017_EntLiquidada).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017Entliquidada);
                entity.HasOne(e => e.NavStatica_BB017_ParcLiquidadas).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017Parcliquidadas);
                entity.HasOne(e => e.NavBB026Forma).WithOne().HasForeignKey<CSICP_Bb017>(e => e.Bb017Fpagtoid);

            });

            modelBuilder.Entity<CSICP_Bb019>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB019");

                entity.ToTable("OSUSR_E9A_CSICP_BB019");

                entity.HasIndex(e => new { e.Bb019Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_13BB019_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb019Finanproprio, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_18BB019_FINANPROPRIO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb019TipofinancId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_19BB019_TIPOFINANC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb019Administradora, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_20BB019_ADMINISTRADORA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb019Usafatoracresc, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_20BB019_USAFATORACRESC_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB019_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB019_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb019Administradora)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_ADMINISTRADORA");
                entity.Property(e => e.Bb019Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB019_CODIGO");
                entity.Property(e => e.Bb019Codigocredenciadora)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_CODIGOCREDENCIADORA");
                entity.Property(e => e.Bb019Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_CONTAID");
                entity.Property(e => e.Bb019Dialimitevenctopadrao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB019_DIALIMITEVENCTOPADRAO");
                entity.Property(e => e.Bb019Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_EMAIL");
                entity.Property(e => e.Bb019Filename)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_FILENAME");
                entity.Property(e => e.Bb019Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB019_FILIAL");
                entity.Property(e => e.Bb019Finanproprio)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_FINANPROPRIO");
                entity.Property(e => e.Bb019Homepage)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_HOMEPAGE");
                entity.Property(e => e.Bb019Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB019_ISACTIVE");
                entity.Property(e => e.Bb019LogoAdm)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_LOGO_ADM");
                entity.Property(e => e.Bb019Path)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB019_PATH");
                entity.Property(e => e.Bb019Tac)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 5)")
                    .HasColumnName("BB019_TAC");
                entity.Property(e => e.Bb019TaxaDeCobranca)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB019_TAXA_DE_COBRANCA");
                entity.Property(e => e.Bb019TipofinancId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_TIPOFINANC_ID");
                entity.Property(e => e.Bb019Usafatoracresc)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_USAFATORACRESC");
                entity.Property(e => e.Bb019Venctopadrao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("BB019_VENCTOPADRAO");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavCSICP_Bb019Tipo).WithOne().HasForeignKey<CSICP_Bb019>(e => e.Bb019TipofinancId);
            });
        }
    }
}
