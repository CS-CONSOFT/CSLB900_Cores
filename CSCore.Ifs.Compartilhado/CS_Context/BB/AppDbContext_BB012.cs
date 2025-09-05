
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB012> OsusrE9aCsicpBb012s { get; set; }

        public DbSet<CSICP_BB01201> OsusrE9aCsicpBb01201s { get; set; }

        public DbSet<CSICP_BB01202> OsusrE9aCsicpBb01202s { get; set; }

        public DbSet<CSICP_BB01203> OsusrE9aCsicpBb01203s { get; set; }

        public DbSet<CSICP_BB01205> OsusrE9aCsicpBb01205s { get; set; }

        public DbSet<CSICP_BB01206> OsusrE9aCsicpBb01206s { get; set; }

        public DbSet<CSICP_BB01207> OsusrE9aCsicpBb01207s { get; set; }

        public DbSet<CSICP_BB01208> OsusrE9aCsicpBb01208s { get; set; }

        public DbSet<CSICP_BB01209> OsusrE9aCsicpBb01209s { get; set; }

        public DbSet<CSICP_BB01210> OsusrE9aCsicpBb01210s { get; set; }

        public DbSet<CSICP_BB012c> OsusrE9aCsicpBb012cs { get; set; }

        public DbSet<CSICP_BB012j> OsusrE9aCsicpBb012js { get; set; }

        public DbSet<CSICP_BB012m> OsusrE9aCsicpBb012ms { get; set; }

        public DbSet<CSICP_BB012o> OsusrE9aCsicpBb012os { get; set; }

        public DbSet<CSICP_BB012q> OsusrE9aCsicpBb012qs { get; set; }
        partial void OnModelCreating_CSICP_BB012(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_BB012>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012");

                entity.ToTable("OSUSR_E9A_CSICP_BB012");

                entity.HasIndex(e => new { e.Bb012Codigo, e.Bb012Keyacess, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_12BB012_CODIGO_14BB012_KEYACESS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_12BB012_CODIGO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Sequence, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_14BB012_SEQUENCE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Estabcadid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_16BB012_ESTABCADID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012IdIndicador, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_ID_INDICADOR_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012NomeCliente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_NOME_CLIENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012SitContaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_18BB012_SIT_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012DataCadastro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_DATA_CADASTRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Dultalteracao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_DULTALTERACAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012GrupocontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_GRUPOCONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012ModrelacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_MODRELACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Oricadastroid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_ORICADASTROID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012TipoContaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_19BB012_TIPO_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012ClassecontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_20BB012_CLASSECONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012StatuscontaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_20BB012_STATUSCONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012DataAniversario, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012_22BB012_DATA_ANIVERSARIO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012ClassecontaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CLASSECONTA_ID");
                entity.Property(e => e.Bb012Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012_CODIGO");
                entity.Property(e => e.Bb012Countappmcon)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012_COUNTAPPMCON");

                entity.Property(e => e.bb012_RFEspecial_ID)
                   .HasColumnName("BB012_RFLCESPECIAL_ID");

                entity.Property(e => e.bb012_TpGovId)
                 .HasColumnName("BB012_TPGOVID");

                entity.Property(e => e.Bb012Countappmcon)
                   .HasDefaultValue(0)
                   .HasColumnName("BB012_COUNTAPPMCON");
                entity.Property(e => e.Bb012DataAniversario)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATA_ANIVERSARIO");
                entity.Property(e => e.Bb012DataCadastro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATA_CADASTRO");
                entity.Property(e => e.Bb012DataEntradaSit)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATA_ENTRADA_SIT");
                entity.Property(e => e.Bb012DataSaidaSit)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATA_SAIDA_SIT");
                entity.Property(e => e.Bb012Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_DESCRICAO");
                entity.Property(e => e.Bb012Dultalteracao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DULTALTERACAO");
                entity.Property(e => e.Bb012Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMAIL");
                entity.Property(e => e.Bb012Estabcadid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ESTABCADID");
                entity.Property(e => e.Bb012Faxcelular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_FAXCELULAR");
                entity.Property(e => e.Bb012GrupocontaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_GRUPOCONTA_ID");
                entity.Property(e => e.Bb012HomePage)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_HOME_PAGE");
                entity.Property(e => e.Bb012IdIndicador)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID_INDICADOR");
                entity.Property(e => e.Bb012IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB012_IS_ACTIVE");
                entity.Property(e => e.Bb012Keyacess)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_KEYACESS");
                entity.Property(e => e.Bb012ModrelacaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_MODRELACAO_ID");
                entity.Property(e => e.Bb012NomeCliente)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_NOME_CLIENTE");
                entity.Property(e => e.Bb012NomeFantasia)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_NOME_FANTASIA");
                entity.Property(e => e.Bb012Oricadastroid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ORICADASTROID");
                entity.Property(e => e.Bb012Sequence)
                    .HasDefaultValue(0L)
                    .HasColumnName("BB012_SEQUENCE");
                entity.Property(e => e.Bb012SitContaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_SIT_CONTA_ID");
                entity.Property(e => e.Bb012StatuscontaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_STATUSCONTA_ID");
                entity.Property(e => e.Bb012Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_TELEFONE");
                entity.Property(e => e.Bb012TipoContaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_TIPO_CONTA_ID");

                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB01206).WithOne()
                    .HasForeignKey<CSICP_BB01206>(d => d.Bb012Id);

                entity.HasOne(d => d.OsusrE9aCsicpBb01201).WithOne()
                    .HasForeignKey<CSICP_BB01201>(d => d.Id);


                entity.HasOne(d => d.Nav_BB01202).WithOne()
                    .HasForeignKey<CSICP_BB01202>(d => d.Id);



                entity.HasOne(d => d.BB012_ModeloRelacao).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012ModrelacaoId)
                   .HasConstraintName("OSPRK_OSUSR_E9A_CSICP_BB012_MREL");

                entity.HasOne(d => d.BB012_StatusConta).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012StatuscontaId);

                entity.HasOne(d => d.BB012_TipoConta).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012TipoContaId);

                entity.HasOne(d => d.BB012_GrupoConta).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012GrupocontaId);

                entity.HasOne(d => d.BB012_ClasseConta).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012ClassecontaId);

                entity.HasOne(d => d.BB012_SitConta).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012SitContaId);

                entity.HasOne(d => d.BB012_MCred).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012Oricadastroid);

                entity.HasOne(d => d.BB012_EstabelecimentoCadastro).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012Estabcadid);


                entity.HasOne(d => d.Bb012IdIndicadorNavigation).WithOne()
                   .HasForeignKey<CSICP_BB012>(d => d.Bb012IdIndicador);

                entity.HasOne(d => d.Nav_AA143).WithOne()
                 .HasForeignKey<CSICP_BB012>(d => d.bb012_RFEspecial_ID);

                entity.HasOne(d => d.Nav_AA146_TP_GOV).WithOne()
                .HasForeignKey<CSICP_BB012>(d => d.bb012_TpGovId);

            });

            modelBuilder.Entity<CSICP_BB01201>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01201");

                entity.ToTable("OSUSR_E9A_CSICP_BB01201");

                entity.HasIndex(e => new { e.Bb012Zonaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_12BB012_ZONAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Revenda, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_13BB012_REVENDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Requisicao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_16BB012_REQUISICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Atividadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_ATIVIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Categoriaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_CATEGORIAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Condpagtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_CONDPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012ConvenioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_CONVENIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Diavenctoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_DIAVENCTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Vendarotaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_17BB012_VENDAROTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Entmtgrotaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_18BB012_ENTMTGROTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Natoperacaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_19BB012_NATOPERACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Padraobancoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_19BB012_PADRAOBANCOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012SitespecialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_20BB012_SITESPECIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012TipogeracaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_20BB012_TIPOGERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01201_2ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01201_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Atividadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ATIVIDADEID");
                entity.Property(e => e.Bb012Bcoagenciaconta)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_BCOAGENCIACONTA");
                entity.Property(e => e.Bb012Categoriaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CATEGORIAID");
                entity.Property(e => e.Bb012ClasseCredito)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CLASSE_CREDITO");
                entity.Property(e => e.Bb012Codgbcodebconta)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CODGBCODEBCONTA");
                entity.Property(e => e.Bb012Codgcategoria)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CODGCATEGORIA");
                entity.Property(e => e.Bb012Condpagtofornec)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CONDPAGTOFORNEC");
                entity.Property(e => e.Bb012Condpagtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONDPAGTOID");
                entity.Property(e => e.Bb012Contacontabil)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CONTACONTABIL");
                entity.Property(e => e.Bb012Contaconvenio)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CONTACONVENIO");
                entity.Property(e => e.Bb012Contratocartao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB012_CONTRATOCARTAO");
                entity.Property(e => e.Bb012ConvenioId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONVENIO_ID");
                entity.Property(e => e.Bb012Datacontratocartao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATACONTRATOCARTAO");
                entity.Property(e => e.Bb012Diaspagtoconv)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_DIASPAGTOCONV");
                entity.Property(e => e.Bb012Diavenctocartao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("BB012_DIAVENCTOCARTAO");
                entity.Property(e => e.Bb012Diavenctoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_DIAVENCTOID");
                entity.Property(e => e.Bb012Dtprimcompra)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DTPRIMCOMPRA");
                entity.Property(e => e.Bb012Dtultcompra)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DTULTCOMPRA");
                entity.Property(e => e.Bb012Dtvalidadecartao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DTVALIDADECARTAO");
                entity.Property(e => e.Bb012Dtvalidcadastro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DTVALIDCADASTRO");
                entity.Property(e => e.Bb012Entmtgrotaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ENTMTGROTAID");
                entity.Property(e => e.Bb012GrauRisco)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_GRAU_RISCO");
                entity.Property(e => e.Bb012Historicocontabilid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_HISTORICOCONTABILID");
                entity.Property(e => e.Bb012Limcreditosecun)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_LIMCREDITOSECUN");
                entity.Property(e => e.Bb012Limiteccredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_LIMITECCREDITO");
                entity.Property(e => e.Bb012Limitecredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_LIMITECREDITO");
                entity.Property(e => e.Bb012Limitecredparcela)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_LIMITECREDPARCELA");
                entity.Property(e => e.Bb012MaiorAtraso)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_MAIOR_ATRASO");
                entity.Property(e => e.Bb012MaiorCompra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_MAIOR_COMPRA");
                entity.Property(e => e.Bb012Maiorsaldo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_MAIORSALDO");
                entity.Property(e => e.Bb012Mediadeatraso)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_MEDIADEATRASO");
                entity.Property(e => e.Bb012MenorAtraso)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_MENOR_ATRASO");
                entity.Property(e => e.Bb012MenorCompra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_MENOR_COMPRA");
                entity.Property(e => e.Bb012Modalidadecredcartao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_MODALIDADECREDCARTAO");
                entity.Property(e => e.Bb012Natoperacaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_NATOPERACAOID");
                entity.Property(e => e.Bb012NumUltFatura)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("BB012_NUM_ULT_FATURA");
                entity.Property(e => e.Bb012Numcompras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_NUMCOMPRAS");
                entity.Property(e => e.Bb012Numpagtoatraso)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_NUMPAGTOATRASO");
                entity.Property(e => e.Bb012Numpagtodia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_NUMPAGTODIA");
                entity.Property(e => e.Bb012Padraobancoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_PADRAOBANCOID");
                entity.Property(e => e.Bb012PercIcms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB012_PERC_ICMS");
                entity.Property(e => e.Bb012Perclimcredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB012_PERCLIMCREDITO");
                entity.Property(e => e.Bb012Prazoentregafornec)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_PRAZOENTREGAFORNEC");
                entity.Property(e => e.Bb012Qtdchqdevolvido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_QTDCHQDEVOLVIDO");
                entity.Property(e => e.Bb012Qtdtitprotestado)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_QTDTITPROTESTADO");
                entity.Property(e => e.Bb012Requisicao)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_REQUISICAO");
                entity.Property(e => e.Bb012Revenda)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_REVENDA");
                entity.Property(e => e.Bb012Saldodevedor)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_SALDODEVEDOR");
                entity.Property(e => e.Bb012Saldopedido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_SALDOPEDIDO");
                entity.Property(e => e.Bb012SitespecialId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_SITESPECIAL_ID");
                entity.Property(e => e.Bb012TaxaAdministracaoCon)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB012_TAXA_ADMINISTRACAO_CON");
                entity.Property(e => e.Bb012Textonotaid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_TEXTONOTAID");
                entity.Property(e => e.Bb012TipogeracaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_TIPOGERACAO_ID");
                entity.Property(e => e.Bb012Totcompracarnet)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_TOTCOMPRACARNET");
                entity.Property(e => e.Bb012Totdiasatraso)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("BB012_TOTDIASATRASO");
                entity.Property(e => e.Bb012Ultchqdevolvido)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_ULTCHQDEVOLVIDO");
                entity.Property(e => e.Bb012Ultprotesto)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_ULTPROTESTO");
                entity.Property(e => e.Bb012ValorEntrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_VALOR_ENTRADA");
                entity.Property(e => e.Bb012Vendarotaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_VENDAROTAID");
                entity.Property(e => e.Bb012Vlrmaiorpagto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_VLRMAIORPAGTO");
                entity.Property(e => e.Bb012Zonaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ZONAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.BB010_Zona)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Zonaid);

                entity.HasOne(e => e.BB011_Atividade)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Atividadeid);

                entity.HasOne(e => e.BB006_BancoPadrao)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Padraobancoid);

                entity.HasOne(e => e.Revenda)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Revenda);

                entity.HasOne(e => e.Requisicao)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Requisicao);

                entity.HasOne(e => e.BB025_NatOperacao)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Natoperacaoid);

                entity.HasOne(e => e.BB008_CondPagamento)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Condpagtoid);

                entity.HasOne(e => e.BB029_Categoria)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Categoriaid);

                entity.HasOne(e => e.BB01201_Convenio)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012ConvenioId);

                entity.HasOne(e => e.BB01201_TpGeracao)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012TipogeracaoId);

                entity.HasOne(e => e.BB01201_SitEspecial)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012SitespecialId);

                entity.HasOne(e => e.BB010_EntregaMontagem)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Entmtgrotaid);

                entity.HasOne(e => e.BB010_VendaRota)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Vendarotaid);

                entity.HasOne(e => e.BB037_DiaVencimento)
                    .WithOne()
                    .HasForeignKey<CSICP_BB01201>(e => e.Bb012Diavenctoid);



                //entity.HasOne(d => d.IdNavigation).WithOne(p => p.OsusrE9aCsicpBb01201)
                //    .HasForeignKey<CSICP_BB01201>(d => d.Id)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01201_OSUSR_E9A_CSICP_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB01202>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01202");

                entity.ToTable("OSUSR_E9A_CSICP_BB01202");

                entity.HasIndex(e => new { e.Bb012Cnpj, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_10BB012_CNPJ_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012SexoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_13BB012_SEXO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012OcupacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_17BB012_OCUPACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EmpGrupoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_18BB012_EMP_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012NaturaldeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_18BB012_NATURALDE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Compresid01Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_20BB012_COMPRESID01_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Compresid02Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_20BB012_COMPRESID02_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EstadocivilId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_20BB012_ESTADOCIVIL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012InscEstSniId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_21BB012_INSC_EST_SNI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012TptributacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_21BB012_TPTRIBUTACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012GescolaridadeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_22BB012_GESCOLARIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Motdesoneracaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_22BB012_MOTDESONERACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Regsuframavalido, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_22BB012_REGSUFRAMAVALIDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012TipodomicilioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_22BB012_TIPODOMICILIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_2ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Cpf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01202_9BB012_CPF_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01202_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012CapitalSocial)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_CAPITAL_SOCIAL");
                entity.Property(e => e.Bb012Cnpj)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CNPJ");
                entity.Property(e => e.Bb012Complementorg)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_COMPLEMENTORG");
                entity.Property(e => e.Bb012Compresid01Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_COMPRESID01_ID");
                entity.Property(e => e.Bb012Compresid02Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_COMPRESID02_ID");
                entity.Property(e => e.Bb012Cpf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("BB012_CPF");
                entity.Property(e => e.Bb012Dataregjunta)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_DATAREGJUNTA");
                entity.Property(e => e.Bb012Emissaorg)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_EMISSAORG");
                entity.Property(e => e.Bb012EmpEndereco)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMP_ENDERECO");
                entity.Property(e => e.Bb012EmpGrupoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_EMP_GRUPO_ID");
                entity.Property(e => e.Bb012EmpProfissao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMP_PROFISSAO");
                entity.Property(e => e.Bb012Empadmissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_EMPADMISSAO");
                entity.Property(e => e.Bb012Empresa)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMPRESA");
                entity.Property(e => e.Bb012EstadocivilId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ESTADOCIVIL_ID");
                entity.Property(e => e.Bb012GescolaridadeId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_GESCOLARIDADE_ID");
                entity.Property(e => e.Bb012IdentEstrangeiro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_IDENT_ESTRANGEIRO");
                entity.Property(e => e.Bb012InscEstSniId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_INSC_EST_SNI_ID");
                entity.Property(e => e.Bb012Inscestadual)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB012_INSCESTADUAL");
                entity.Property(e => e.Bb012Motdesoneracaoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_MOTDESONERACAOID");
                entity.Property(e => e.Bb012NaturaldeId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_NATURALDE_ID");
                entity.Property(e => e.Bb012Nrodependentes)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("BB012_NRODEPENDENTES");
                entity.Property(e => e.Bb012OcupacaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_OCUPACAO_ID");
                entity.Property(e => e.Bb012Origemoutrosrend)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ORIGEMOUTROSREND");
                entity.Property(e => e.Bb012Outrosrendimentos)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_OUTROSRENDIMENTOS");
                entity.Property(e => e.Bb012Patrimonio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_PATRIMONIO");
                entity.Property(e => e.Bb012Pis)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB012_PIS");
                entity.Property(e => e.Bb012Regjuntacomercial)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_REGJUNTACOMERCIAL");
                entity.Property(e => e.Bb012Regsuframavalido)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_REGSUFRAMAVALIDO");
                entity.Property(e => e.Bb012Residedesde)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012_RESIDEDESDE");
                entity.Property(e => e.Bb012Rg)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB012_RG");
                entity.Property(e => e.Bb012SexoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_SEXO_ID");
                entity.Property(e => e.Bb012Suframa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_SUFRAMA");
                entity.Property(e => e.Bb012TipodomicilioId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_TIPODOMICILIO_ID");
                entity.Property(e => e.Bb012TptributacaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_TPTRIBUTACAO_ID");
                entity.Property(e => e.Bb012Valorremuneracao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_VALORREMUNERACAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.BB012_RegSUFRAMAValido)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012Regsuframavalido);

                entity.HasOne(e => e.BB012_Insc_Est_SNI)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012InscEstSniId);

                entity.HasOne(e => e.BB012_Sexo)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012SexoId);

                entity.HasOne(e => e.BB012_EstadoCivil)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012EstadocivilId);

                entity.HasOne(e => e.BB012_Domicilio)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012TipodomicilioId);

                entity.HasOne(e => e.BB012_ComprovanteResidencia1)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012Compresid01Id);

                entity.HasOne(e => e.BB012_ComprovanteResidencia2)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012Compresid02Id);

                entity.HasOne(e => e.BB012_Escolaridade)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012GescolaridadeId);

                entity.HasOne(e => e.BB012_Ocupacao)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012OcupacaoId);

                entity.HasOne(e => e.AA028_NatualDe)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012NaturaldeId);

                entity.HasOne(e => e.BB001_Tributacao)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012TptributacaoId);

                entity.HasOne(e => e.BB012_TipoDaEmpresaTrabalho)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012EmpGrupoId);

                entity.HasOne(e => e.BB027_MotivoDesoneracao)
                .WithOne()
                .HasForeignKey<CSICP_BB01202>(e => e.Bb012Motdesoneracaoid);

            });

            modelBuilder.Entity<CSICP_BB01203>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01203");

                entity.ToTable("OSUSR_E9A_CSICP_BB01203");

                entity.HasIndex(e => new { e.Bb041Casoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_12BB041_CASOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_15BB012_CONTATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb043Campanhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_16BB043_CAMPANHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Candidatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_17BB012_CANDIDATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb040Atividadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_17BB040_ATIVIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb042Potencialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_17BB042_POTENCIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb046Concorrenteid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_19BB046_CONCORRENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01203_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01203_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb01203IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB01203_IS_ACTIVE");
                entity.Property(e => e.Bb012Candidatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CANDIDATOID");
                entity.Property(e => e.Bb012Contatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTATOID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012Nota)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_NOTA");
                entity.Property(e => e.Bb040Atividadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB040_ATIVIDADEID");
                entity.Property(e => e.Bb041Casoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB041_CASOID");
                entity.Property(e => e.Bb042Potencialid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB042_POTENCIALID");
                entity.Property(e => e.Bb043Campanhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB043_CAMPANHAID");
                entity.Property(e => e.Bb046Concorrenteid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB046_CONCORRENTEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb01203s)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01203_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB01205>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01205");

                entity.ToTable("OSUSR_E9A_CSICP_BB01205");

                entity.HasIndex(e => new { e.Bb012Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01205_15BB012_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01205_2ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01205_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Categoriaatendimento)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CATEGORIAATENDIMENTO");
                entity.Property(e => e.Bb012Diapagamento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("BB012_DIAPAGAMENTO");
                entity.Property(e => e.Bb012Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_EMPRESAID");
                entity.Property(e => e.Bb012Filial)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_FILIAL");
                entity.Property(e => e.Bb012Login)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_LOGIN");
                entity.Property(e => e.Bb012Qtdeusuario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_QTDEUSUARIO");
                entity.Property(e => e.Bb012Qtdhrscontrato)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_QTDHRSCONTRATO");
                entity.Property(e => e.Bb012Qtdhrsexcedente)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_QTDHRSEXCEDENTE");
                entity.Property(e => e.Bb012Qtdusuariopdvf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_QTDUSUARIOPDVF");
                entity.Property(e => e.Bb012Qtdusuariopdvn)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB012_QTDUSUARIOPDVN");
                entity.Property(e => e.Bb012Valorhrexcedente)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_VALORHREXCEDENTE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.OsusrE9aCsicpBb01205)
                    .HasForeignKey<CSICP_BB01205>(d => d.Id)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01205_OSUSR_E9A_CSICP_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB01206>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01206");

                entity.ToTable("OSUSR_E9A_CSICP_BB01206");

                entity.HasIndex(e => new { e.Bb012Codgbairro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_16BB012_CODGBAIRRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EntregaUf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_16BB012_ENTREGA_UF_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012CodigoPais, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_17BB012_CODIGO_PAIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EntregaPais, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_18BB012_ENTREGA_PAIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012CodigoCidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_19BB012_CODIGO_CIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EntregaCodgbairro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_24BB012_ENTREGA_CODGBAIRRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012EntregaCodCidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_24BB012_ENTREGA_COD_CIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Uf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01206_8BB012_UF_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01206_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Bairro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_BAIRRO");
                entity.Property(e => e.Bb012Celular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CELULAR");
                entity.Property(e => e.Bb012Cep)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012_CEP");
                entity.Property(e => e.Bb012Codgbairro)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CODGBAIRRO");
                entity.Property(e => e.Bb012CodigoCidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CODIGO_CIDADE");
                entity.Property(e => e.Bb012CodigoPais)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CODIGO_PAIS");
                entity.Property(e => e.Bb012Complemento)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_COMPLEMENTO");
                entity.Property(e => e.Bb012Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMAIL");
                entity.Property(e => e.Bb012EntregaBairro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ENTREGA_BAIRRO");
                entity.Property(e => e.Bb012EntregaCep)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012_ENTREGA_CEP");
                entity.Property(e => e.Bb012EntregaCodCidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ENTREGA_COD_CIDADE");
                entity.Property(e => e.Bb012EntregaCodgbairro)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ENTREGA_CODGBAIRRO");
                entity.Property(e => e.Bb012EntregaComplement)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ENTREGA_COMPLEMENT");
                entity.Property(e => e.Bb012EntregaLogradouro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ENTREGA_LOGRADOURO");
                entity.Property(e => e.Bb012EntregaNumero)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ENTREGA_NUMERO");
                entity.Property(e => e.Bb012EntregaPais)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ENTREGA_PAIS");
                entity.Property(e => e.Bb012EntregaPerimetro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_ENTREGA_PERIMETRO");
                entity.Property(e => e.Bb012EntregaUf)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ENTREGA_UF");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012Logradouro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_LOGRADOURO");
                entity.Property(e => e.Bb012Numero)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_NUMERO");
                entity.Property(e => e.Bb012Perimetro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_PERIMETRO");
                entity.Property(e => e.Bb012Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_TELEFONE");
                entity.Property(e => e.Bb012Uf)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_UF");
                entity.Property(e => e.Bb012jEnderecoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012J_ENDERECOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.AA028_Cidade)
                .WithOne()
                .HasForeignKey<CSICP_BB01206>(e => e.Bb012CodigoCidade);

                entity.HasOne(e => e.AA027_UF)
                .WithOne()
                .HasForeignKey<CSICP_BB01206>(e => e.Bb012Uf);

                entity.HasOne(e => e.AA025_Pais)
                .WithOne()
                .HasForeignKey<CSICP_BB01206>(e => e.Bb012CodigoPais);


                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb01206s)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01206_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB01207>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01207");

                entity.ToTable("OSUSR_E9A_CSICP_BB01207");

                entity.HasIndex(e => new { e.Bb012Membroid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01207_14BB012_MEMBROID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01207_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01207_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb01207IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB01207_IS_ACTIVE");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012Membroid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_MEMBROID");
                entity.Property(e => e.Bb012TipoRegMembroconveni)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012_TIPO_REG_MEMBROCONVENI");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBb012Membro)
                .WithOne()
                .HasForeignKey<CSICP_BB01207>(e => e.Bb012Membroid);
            });

            modelBuilder.Entity<CSICP_BB01208>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01208");

                entity.ToTable("OSUSR_E9A_CSICP_BB01208");

                entity.HasIndex(e => new { e.Bb041Casoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_12BB041_CASOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Concorrenteid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_13CONCORRENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_15BB012_CONTATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb043Campanhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_16BB043_CAMPANHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036Candidatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_17BB036_CANDIDATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb040Atividadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_17BB040_ATIVIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb042Potencialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_17BB042_POTENCIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb01208GrauparentId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_21BB01208_GRAUPARENT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01208_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01208_9TENANT_ID");

                //entity.HasIndex(e => new { e.Bb01208CodgCliente7x, e.Bb01208SeqCliente7x, e.Bb01208OrigemcontatoId }, "idx_Link_Contato_7x");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                //entity.Property(e => e.Bb01208CodgCliente7x).HasColumnName("BB01208_CODG_CLIENTE_7X");
                entity.Property(e => e.Bb01208GrauparentId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB01208_GRAUPARENT_ID");
                entity.Property(e => e.Bb01208IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB01208_IS_ACTIVE");
                //entity.Property(e => e.Bb01208OrigemcontatoId).HasColumnName("BB01208_ORIGEMCONTATO_ID");
                //entity.Property(e => e.Bb01208SeqCliente7x).HasColumnName("BB01208_SEQ_CLIENTE_7X");
                entity.Property(e => e.Bb012Contatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTATOID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb036Candidatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_CANDIDATOID");
                entity.Property(e => e.Bb040Atividadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB040_ATIVIDADEID");
                entity.Property(e => e.Bb041Casoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB041_CASOID");
                entity.Property(e => e.Bb042Potencialid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB042_POTENCIALID");
                entity.Property(e => e.Bb043Campanhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB043_CAMPANHAID");
                entity.Property(e => e.Concorrenteid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CONCORRENTEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavCSICP_BB035)
                  .WithOne()
                  .HasForeignKey<CSICP_BB01208>(e => e.Bb012Contatoid);

                entity.HasOne(e => e.NavCSICP_BB035Gpa)
                  .WithOne()
                  .HasForeignKey<CSICP_BB01208>(e => e.Bb01208GrauparentId);

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb01208s)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01208_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB01209>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01209");

                entity.ToTable("OSUSR_E9A_CSICP_BB01209");

                entity.HasIndex(e => new { e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01209_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb01209Datareg, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01209_15BB01209_DATAREG_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01209_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Bb01209Datareg)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB01209_DATAREG");
                entity.Property(e => e.Bb01209Json)
                    .HasDefaultValue("")
                    .HasColumnName("BB01209_JSON");
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb012Conta).WithMany(p => p.OsusrE9aCsicpBb01209s)
                //    .HasForeignKey(d => d.Bb012Contaid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01209_OSUSR_E9A_CSICP_BB012_BB012_CONTAID");
            });

            modelBuilder.Entity<CSICP_BB01210>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB01210");

                entity.ToTable("OSUSR_E9A_CSICP_BB01210");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB01210_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB01210_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Bb01210Ano)
                    .HasDefaultValue(0)
                    .HasColumnName("BB01210_ANO");
                entity.Property(e => e.Bb01210Dtregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB01210_DTREGISTRO");
                entity.Property(e => e.Bb01210Mes)
                    .HasDefaultValue(0)
                    .HasColumnName("BB01210_MES");
                entity.Property(e => e.Bb01210Tipo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB01210_TIPO");
                entity.Property(e => e.Bb01210Vcredcomscore)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB01210_VCREDCOMSCORE");
                entity.Property(e => e.Bb01210Vcredmedia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB01210_VCREDMEDIA");
                entity.Property(e => e.Bb01210Vcredsemscore)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB01210_VCREDSEMSCORE");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.CteAgradDPercVlrsdivida)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_AGRAD_D_PERC_VLRSDIVIDA");
                entity.Property(e => e.CteAgradDPesoVlrsdivida)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_AGRAD_D_PESO_VLRSDIVIDA");
                entity.Property(e => e.CteCgradCreditoEmaberto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_CGRAD_CREDITO_EMABERTO");
                entity.Property(e => e.CteCgradCreditoPago)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_CGRAD_CREDITO_PAGO");
                entity.Property(e => e.CteCgradCreditoUsado)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_CGRAD_CREDITO_USADO");
                entity.Property(e => e.CteCgradFatorGradualidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_CGRAD_FATOR_GRADUALIDADE");
                entity.Property(e => e.CteCgradMaxDiasPagtoatra)
                    .HasDefaultValue(0)
                    .HasColumnName("CTE_CGRAD_MAX_DIAS_PAGTOATRA");
                entity.Property(e => e.CteCgradMaxDiasTitatraso)
                    .HasDefaultValue(0)
                    .HasColumnName("CTE_CGRAD_MAX_DIAS_TITATRASO");
                entity.Property(e => e.CteCgradQtdTituloaberto)
                    .HasDefaultValue(0)
                    .HasColumnName("CTE_CGRAD_QTD_TITULOABERTO");
                entity.Property(e => e.CteCgradValorcredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_CGRAD_VALORCREDITO");
                entity.Property(e => e.CteCrednaopagoPercNaopago)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_CREDNAOPAGO_PERC_NAOPAGO");
                entity.Property(e => e.CteGradualF)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_GRADUAL_F");
                entity.Property(e => e.CteGradualP)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_GRADUAL_P");
                entity.Property(e => e.CteGradualU)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_GRADUAL_U");
                entity.Property(e => e.CteGradualUWu)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CTE_GRADUAL_U_WU");
                entity.Property(e => e.CteObtemPesoC)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_OBTEM_PESO_C");
                entity.Property(e => e.CteObtemPesoP)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("CTE_OBTEM_PESO_P");
                entity.Property(e => e.FFatorajuste)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("F_FATORAJUSTE");
                entity.Property(e => e.FWf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("F_WF");
                entity.Property(e => e.JsonCreditpro)
                    .HasDefaultValue("")
                    .HasColumnName("JSON_CREDITPRO");
                entity.Property(e => e.Mediasalarialbairro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("MEDIASALARIALBAIRRO");
                entity.Property(e => e.PWpa)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("P_WPA");
                entity.Property(e => e.QtdAtrasosfreq)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_ATRASOSFREQ");
                entity.Property(e => e.QtdAtrasosmoderados)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_ATRASOSMODERADOS");
                entity.Property(e => e.QtdComportamentoCompras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_COMPORTAMENTO_COMPRAS");
                entity.Property(e => e.QtdPagtospontuais)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_PAGTOSPONTUAIS");
                entity.Property(e => e.QtdSemprepagaprazo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_SEMPREPAGAPRAZO");
                entity.Property(e => e.QtdTitulos)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("QTD_TITULOS");
                entity.Property(e => e.Renda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("RENDA");
                entity.Property(e => e.Scoreclearsale)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("SCORECLEARSALE");
                entity.Property(e => e.Taxascore)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("TAXASCORE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.VlrNovocredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("VLR_NOVOCREDITO");
                entity.Property(e => e.Wc)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("WC");
                entity.Property(e => e.We)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("WE");
                entity.Property(e => e.Wp)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("WP");
                entity.Property(e => e.Wr)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("WR");

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb01210s)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB01210_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB012c>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012C");

                entity.ToTable("OSUSR_E9A_CSICP_BB012C");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012C_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012C_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012cDescempresa)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB012C_DESCEMPRESA");
                entity.Property(e => e.Bb012cFone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012C_FONE");
                entity.Property(e => e.Bb012cIsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB012C_IS_ACTIVE");
                entity.Property(e => e.Bb012cProprietramo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB012C_PROPRIETRAMO");
                entity.Property(e => e.Bb012cValorMedia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012C_VALOR_MEDIA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb012cs)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012C_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB012j>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012J");

                entity.ToTable("OSUSR_E9A_CSICP_BB012J");

                entity.HasIndex(e => new { e.Bb012jTipoendereco, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012J_19BB012J_TIPOENDERECO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012J_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012J_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012jEmail)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB012J_EMAIL");
                entity.Property(e => e.Bb012jFax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012J_FAX");
                entity.Property(e => e.Bb012jTelefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012J_TELEFONE");
                entity.Property(e => e.Bb012jTipoendereco)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012J_TIPOENDERECO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavTipoEndereco).WithOne().HasForeignKey<CSICP_BB012j>(d => d.Bb012jTipoendereco);

                entity.HasOne(d => d.NavBB1206_Endereco).WithOne().HasForeignKey<CSICP_BB01206>(d => d.Bb012jEnderecoid);

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb012js)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012J_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB012m>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012M");

                entity.ToTable("OSUSR_E9A_CSICP_BB012M");

                entity.HasIndex(e => new { e.Bb041Casoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_12BB041_CASOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012mDoctoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_14BB012M_DOCTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_15BB012_CONTATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb043Campanhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_16BB043_CAMPANHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Candidatoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_17BB012_CANDIDATOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb040Atividadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_17BB040_ATIVIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb042Potencialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_17BB042_POTENCIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012mTipodoctoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_18BB012M_TIPODOCTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012M_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012M_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Candidatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CANDIDATOID");
                entity.Property(e => e.Bb012Contatoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTATOID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012mCodigoCliente)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012M_CODIGO_CLIENTE");
                entity.Property(e => e.Bb012mContent)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012M_CONTENT");
                entity.Property(e => e.Bb012mDatadocto)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB012M_DATADOCTO");
                entity.Property(e => e.Bb012mDescricao)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("BB012M_DESCRICAO");
                entity.Property(e => e.Bb012mDoctoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012M_DOCTOID");
                entity.Property(e => e.Bb012mFilename)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB012M_FILENAME");
                entity.Property(e => e.Bb012mFiletype)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB012M_FILETYPE");
                entity.Property(e => e.Bb012mIsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB012M_IS_ACTIVE");
                entity.Property(e => e.Bb012mPath)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB012M_PATH");
                entity.Property(e => e.Bb012mTipodoctoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012M_TIPODOCTOID");
                entity.Property(e => e.Bb040Atividadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB040_ATIVIDADEID");
                entity.Property(e => e.Bb041Casoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB041_CASOID");
                entity.Property(e => e.Bb042Potencialid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB042_POTENCIALID");
                entity.Property(e => e.Bb043Campanhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB043_CAMPANHAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB012MTD)
                  .WithOne()
                  .HasForeignKey<CSICP_BB012m>(d => d.Bb012mTipodoctoid);


                entity.HasOne(d => d.NavBB012MDC)
                  .WithOne()
                  .HasForeignKey<CSICP_BB012m>(d => d.Bb012mDoctoid);
                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb012ms)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012M_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB012o>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012O");

                entity.ToTable("OSUSR_E9A_CSICP_BB012O");

                entity.HasIndex(e => new { e.Bb012oRetem, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012O_12BB012O_RETEM_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012oImpostoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012O_17BB012O_IMPOSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012O_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012O_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012oCodigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB012O_CODIGO");
                entity.Property(e => e.Bb012oImpostoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012O_IMPOSTO_ID");
                entity.Property(e => e.Bb012oPercentual)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB012O_PERCENTUAL");
                entity.Property(e => e.Bb012oRetem)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012O_RETEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBb012oImposto).WithOne().HasForeignKey<CSICP_BB012o>(e => e.Bb012oImpostoId);
                entity.HasOne(e => e.NavStatica_Retem).WithOne().HasForeignKey<CSICP_BB012o>(e => e.Bb012oRetem);

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb012os)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012O_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });

            modelBuilder.Entity<CSICP_BB012q>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB012Q");

                entity.ToTable("OSUSR_E9A_CSICP_BB012Q");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB012Q_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB012Q_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb012Agencia)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_AGENCIA");
                entity.Property(e => e.Bb012Conta)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_CONTA");
                entity.Property(e => e.Bb012Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_EMAIL");
                entity.Property(e => e.Bb012Faxcelular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_FAXCELULAR");
                entity.Property(e => e.Bb012Homepage)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_HOMEPAGE");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb012Nomegerente)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_NOMEGERENTE");
                entity.Property(e => e.Bb012Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB012_TELEFONE");
                entity.Property(e => e.Bb012Valorfinanciamento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB012_VALORFINANCIAMENTO");
                entity.Property(e => e.Bb012qIsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB012Q_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb012).WithMany(p => p.OsusrE9aCsicpBb012qs)
                //    .HasForeignKey(d => d.Bb012Id)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB012Q_OSUSR_E9A_CSICP_BB012_BB012_ID");
            });
        }
    }
}
