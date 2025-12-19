
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb020> OsusrE9aCsicpBb020s { get; set; }

        public DbSet<CSICP_Bb021> OsusrE9aCsicpBb021s { get; set; }

        public DbSet<CSICP_Bb021a> OsusrE9aCsicpBb021as { get; set; }

        public DbSet<CSICP_Bb024> OsusrE9aCsicpBb024s { get; set; }

        public DbSet<CSICP_Bb025> OsusrE9aCsicpBb025s { get; set; }

        public DbSet<CSICP_Bb026> OsusrE9aCsicpBb026s { get; set; }

        public DbSet<CSICP_Bb027> OsusrE9aCsicpBb027s { get; set; }

        public DbSet<CSICP_Bb028> OsusrE9aCsicpBb028s { get; set; }

        public DbSet<CSICP_Bb028b> OsusrE9aCsicpBb028bs { get; set; }

        public DbSet<CSICP_Bb029> OsusrE9aCsicpBb029s { get; set; }
        partial void OnModelCreating_CSICP_BB02X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb020>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB020");

                entity.ToTable("OSUSR_E9A_CSICP_BB020");

                entity.HasIndex(e => new { e.Bb020Fpagtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB020_14BB020_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb008Condicaodepagamentoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB020_27BB008_CONDICAODEPAGAMENTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb019Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB020_8BB019_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB020_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB020_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb008Condicaodepagamentoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB008_CONDICAODEPAGAMENTOID");
                entity.Property(e => e.Bb019Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB019_ID");
                entity.Property(e => e.Bb020Fpagtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB020_FPAGTOID");
                entity.Property(e => e.Bb020Tcobcartao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB020_TCOBCARTAO");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb008Condicaodepagamento).WithOne()
                    .HasForeignKey<CSICP_Bb020>(d => d.Bb008Condicaodepagamentoid);

                entity.HasOne(d => d.Bb019).WithOne()
                    .HasForeignKey<CSICP_Bb020>(d => d.Bb019Id);

                entity.HasOne(d => d.Bb020Fpagto).WithOne()
                    .HasForeignKey<CSICP_Bb020>(d => d.Bb020Fpagtoid);
            });

            modelBuilder.Entity<CSICP_Bb021>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB021");

                entity.ToTable("OSUSR_E9A_CSICP_BB021");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB021_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb021Autorizacao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB021_AUTORIZACAO");
                entity.Property(e => e.Bb021Codautorizado)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021_CODAUTORIZADO");
                entity.Property(e => e.Bb021Codautorizador)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021_CODAUTORIZADOR");
                entity.Property(e => e.Bb021CodigoProduto)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021_CODIGO_PRODUTO");
                entity.Property(e => e.Bb021DataEmissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB021_DATA_EMISSAO");
                entity.Property(e => e.Bb021Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021_FILIAL");
                entity.Property(e => e.Bb021Hora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB021_HORA");
                entity.Property(e => e.Bb021Modulo)
                    .HasMaxLength(11)
                    .HasDefaultValue("")
                    .HasColumnName("BB021_MODULO");
                entity.Property(e => e.Bb021NomeAutorizado)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB021_NOME_AUTORIZADO");
                entity.Property(e => e.Bb021NomeAutorizador)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB021_NOME_AUTORIZADOR");
                entity.Property(e => e.Bb021PercentualValor)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB021_PERCENTUAL_VALOR");
                entity.Property(e => e.Bb021Situacao)
                    .HasMaxLength(11)
                    .HasDefaultValue("")
                    .HasColumnName("BB021_SITUACAO");
                entity.Property(e => e.Bb021Tipo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021_TIPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb021a>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB021A");

                entity.ToTable("OSUSR_E9A_CSICP_BB021A");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB021A_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb021aCiOrigem)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB021A_CI_ORIGEM");
                entity.Property(e => e.Bb021aCiOrigemSeq)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021A_CI_ORIGEM_SEQ");
                entity.Property(e => e.Bb021aDataemissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB021A_DATAEMISSAO");
                entity.Property(e => e.Bb021aFilial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021A_FILIAL");
                entity.Property(e => e.Bb021aNoautorizacao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB021A_NOAUTORIZACAO");
                entity.Property(e => e.Bb021aNoestacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB021A_NOESTACAO");
                entity.Property(e => e.Bb021aTabela)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB021A_TABELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb024>(entity =>
            {
                entity.HasKey(e => e.Bb024Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB024");

                entity.ToTable("OSUSR_E9A_CSICP_BB024");

                entity.HasIndex(e => new { e.Bb024CfopId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB024_13BB024_CFOP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB024_20BB025_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB024_9TENANT_ID");

                entity.Property(e => e.Bb024Id).HasColumnName("BB024_ID");
                entity.Property(e => e.Bb024CfopId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB024_CFOP_ID");
                entity.Property(e => e.Bb025NatoperacaoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_NATOPERACAO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.osusr66CSpedInCfop).WithOne()
                    .HasForeignKey<CSICP_Bb024>(d => d.Bb024CfopId);
            });

            modelBuilder.Entity<CSICP_Bb025>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB025");

                entity.ToTable("OSUSR_E9A_CSICP_BB025");

                entity.HasIndex(e => new { e.Bb025Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_15BB025_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025Transacaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_17BB025_TRANSACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025Baixaestoque, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_18BB025_BAIXAESTOQUE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025GeraDuplicata, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_20BB025_GERA_DUPLICATA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025UsaTabelaPreco, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_22BB025_USA_TABELA_PRECO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025Valorizarprecoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_22BB025_VALORIZARPRECOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb025ModdoctofiscalId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_23BB025_MODDOCTOFISCAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB025_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB025_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb025Baixaestoque)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_BAIXAESTOQUE");
                entity.Property(e => e.Bb025Cfopdentroestado)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB025_CFOPDENTROESTADO");
                entity.Property(e => e.Bb025Cfopforaestado)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB025_CFOPFORAESTADO");
                entity.Property(e => e.Bb025Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB025_CODIGO");
                entity.Property(e => e.Bb025Codtptransacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB025_CODTPTRANSACAO");
                entity.Property(e => e.Bb025Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB025_DESCRICAO");
                entity.Property(e => e.Bb025Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB025_FILIAL");
                entity.Property(e => e.Bb025GeraDuplicata)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_GERA_DUPLICATA");
                entity.Property(e => e.Bb025GrupoContabil)
                    .HasDefaultValue(0)
                    .HasColumnName("BB025_GRUPO_CONTABIL");
                entity.Property(e => e.Bb025Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB025_ISACTIVE");
                entity.Property(e => e.Bb025Moddoctofiscal)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB025_MODDOCTOFISCAL");
                entity.Property(e => e.Bb025ModdoctofiscalId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_MODDOCTOFISCAL_ID");
                entity.Property(e => e.Bb025Transacaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_TRANSACAOID");
                entity.Property(e => e.Bb025UsaTabelaPreco)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_USA_TABELA_PRECO");
                entity.Property(e => e.Bb025Valorizarprecoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB025_VALORIZARPRECOID");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb025Transacao).WithOne().HasForeignKey<CSICP_Bb025>(d => d.Bb025Transacaoid);
                entity.HasOne(d => d.osusr66CSpedInAjIcm).WithOne().HasForeignKey<CSICP_Bb025>(d => d.Bb025ModdoctofiscalId);
            });

            modelBuilder.Entity<CSICP_Bb026>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB026");

                entity.ToTable("OSUSR_E9A_CSICP_BB026");

                entity.HasIndex(e => new { e.Bb026Tipo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_10BB026_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_12BB026_CODIGO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026ClasseId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_15BB026_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026EspecieId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_16BB026_ESPECIE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Tipoespecie, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_17BB026_TIPOESPECIE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Dadoscartaosn, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_19BB026_DADOSCARTAOSN_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Dadoschequesn, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_19BB026_DADOSCHEQUESN_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Formapagamento, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_20BB026_FORMAPAGAMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026TipovinculoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_20BB026_TIPOVINCULO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Condpagtofixoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_21BB026_CONDPAGTOFIXOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Vinccupomfiscal, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_21BB026_VINCCUPOMFISCAL_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb026Administradoraid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_22BB026_ADMINISTRADORAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB026_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB026_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb026Aceitapagto)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ACEITAPAGTO");
                entity.Property(e => e.Bb026Aceitarecebimento)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ACEITARECEBIMENTO");
                entity.Property(e => e.Bb026Aceitavpresente)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ACEITAVPRESENTE");
                entity.Property(e => e.Bb026Administradoraid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_ADMINISTRADORAID");
                entity.Property(e => e.Bb026Capturarecebpvpdv)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_CAPTURARECEBPVPDV");
                entity.Property(e => e.Bb026Chequebompara)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_CHEQUEBOMPARA");
                entity.Property(e => e.Bb026ClasseId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_CLASSE_ID");
                entity.Property(e => e.Bb026Classificacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB026_CLASSIFICACAO");
                entity.Property(e => e.Bb026Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB026_CODIGO");
                entity.Property(e => e.Bb026Condpagtofixoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_CONDPAGTOFIXOID");
                entity.Property(e => e.Bb026Consultacheque)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_CONSULTACHEQUE");
                entity.Property(e => e.Bb026Crplanocontaid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB026_CRPLANOCONTAID");
                entity.Property(e => e.Bb026Dadoscartaosn)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_DADOSCARTAOSN");
                entity.Property(e => e.Bb026Dadoschequesn)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_DADOSCHEQUESN");
                entity.Property(e => e.Bb026Dbplanocontaid2)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB026_DBPLANOCONTAID2");
                entity.Property(e => e.Bb026EspecieId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_ESPECIE_ID");
                entity.Property(e => e.Bb026Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB026_FILIAL");
                entity.Property(e => e.Bb026Formapagamento)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB026_FORMAPAGAMENTO");
                entity.Property(e => e.Bb026Impressaocheque)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_IMPRESSAOCHEQUE");
                entity.Property(e => e.Bb026Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ISACTIVE");
                entity.Property(e => e.Bb026Isagrupa)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ISAGRUPA");
                entity.Property(e => e.Bb026Isaplicaaprovcond)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ISAPLICAAPROVCOND");
                entity.Property(e => e.Bb026Islibentregaliq)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_ISLIBENTREGALIQ");
                entity.Property(e => e.Bb026Meiopagtoimpfiscal)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB026_MEIOPAGTOIMPFISCAL");
                entity.Property(e => e.Bb026Naoabregaveta)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_NAOABREGAVETA");
                entity.Property(e => e.Bb026NroAutenticacoes)
                    .HasDefaultValue(0)
                    .HasColumnName("BB026_NRO_AUTENTICACOES");
                entity.Property(e => e.Bb026Parcelapordepto)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_PARCELAPORDEPTO");
                entity.Property(e => e.Bb026Pcomissaovend)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB026_PCOMISSAOVEND");
                entity.Property(e => e.Bb026Permitetroco)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_PERMITETROCO");
                entity.Property(e => e.Bb026Pontosangria)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB026_PONTOSANGRIA");
                entity.Property(e => e.Bb026Sangriaautomatica)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_SANGRIAAUTOMATICA");
                entity.Property(e => e.Bb026Solicitacondpagto)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_SOLICITACONDPAGTO");
                entity.Property(e => e.Bb026Solicitaemitente)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_SOLICITAEMITENTE");
                entity.Property(e => e.Bb026Solicitaqtd)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_SOLICITAQTD");
                entity.Property(e => e.Bb026Tipo)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_TIPO");
                entity.Property(e => e.Bb026Tipoespecie)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_TIPOESPECIE");
                entity.Property(e => e.Bb026TipovinculoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_TIPOVINCULO_ID");
                entity.Property(e => e.Bb026TrocoMaximo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB026_TROCO_MAXIMO");
                entity.Property(e => e.Bb026UtilizaPinpad)
                    .HasDefaultValue(false)
                    .HasColumnName("BB026_UTILIZA_PINPAD");
                entity.Property(e => e.Bb026ValorMaximo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB026_VALOR_MAXIMO");
                entity.Property(e => e.Bb026ValorMinimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB026_VALOR_MINIMO");
                entity.Property(e => e.Bb026Vinccupomfiscal)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB026_VINCCUPOMFISCAL");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb026Administradora).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Administradoraid);

                entity.HasOne(d => d.Bb026Condpagtofixo).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Condpagtofixoid);

                entity.HasOne(d => d.NavBb026Classe).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026ClasseId);
                entity.HasOne(d => d.NavBb026Tipo).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Tipo);
                entity.HasOne(d => d.NavBb026Vin).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026TipovinculoId);
                entity.HasOne(d => d.NavBB026_DadosCartaoSN).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Dadoscartaosn);
                entity.HasOne(d => d.NavBB026_DadosChequeSN).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Dadoschequesn);
                entity.HasOne(d => d.NavBB026_VincCupomFiscal).WithOne().HasForeignKey<CSICP_Bb026>(d => d.Bb026Vinccupomfiscal);
            });

            modelBuilder.Entity<CSICP_Bb027>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB027");

                entity.ToTable("OSUSR_E9A_CSICP_BB027");

                entity.HasIndex(e => new { e.Bb027Difa, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_10BB027_DIFA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Icst, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_10BB027_ICST_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Irpj, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_10BB027_IRPJ_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Irrf, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_10BB027_IRRF_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Cofins, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_12BB027_COFINS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Hashid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_12BB027_HASHID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_15BB027_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027EntsaiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_15BB027_ENTSAI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027RegimeId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_15BB027_REGIME_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027CalcipiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_16BB027_CALCIPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Calculaiss, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_16BB027_CALCULAISS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027CalcicmsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_17BB027_CALCICMS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Baixaestoque, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_18BB027_BAIXAESTOQUE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Geracreceber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_18BB027_GERACRECEBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Icmsdiferido, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_18BB027_ICMSDIFERIDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027IpiBrutoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_18BB027_IPI_BRUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027PodertercId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_18BB027_PODERTERC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027TdevolucaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_19BB027_TDEVOLUCAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Agregasubstrib, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_20BB027_AGREGASUBSTRIB_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027CfopStaticaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_21BB027_CFOP_STATICA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Geraestatistica, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_21BB027_GERAESTATISTICA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Atualizaprcompra, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_22BB027_ATUALIZAPRCOMPRA_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Calcsubstituicao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_22BB027_CALCSUBSTITUICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027CalcajusteicmsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_23BB027_CALCAJUSTEICMS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027CfopForaestadoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_24BB027_CFOP_FORAESTADO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027BaseicmsbrutaliqId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_25BB027_BASEICMSBRUTALIQ_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027BasesubsbrutaliqId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_25BB027_BASESUBSBRUTALIQ_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027SomaipiBaseicmsId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_25BB027_SOMAIPI_BASEICMS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb027Pis, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_9BB027_PIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB027_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB027_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb027Agregasubstrib)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_AGREGASUBSTRIB");
                entity.Property(e => e.Bb027Atualizaprcompra)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ATUALIZAPRCOMPRA");
                entity.Property(e => e.Bb027Baixaestoque)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_BAIXAESTOQUE");
                entity.Property(e => e.Bb027BaseicmsbrutaliqId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_BASEICMSBRUTALIQ_ID");
                entity.Property(e => e.Bb027BasesubsbrutaliqId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_BASESUBSBRUTALIQ_ID");
                entity.Property(e => e.Bb027CalcajusteicmsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CALCAJUSTEICMS_ID");
                entity.Property(e => e.Bb027CalcicmsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CALCICMS_ID");
                entity.Property(e => e.Bb027CalcipiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CALCIPI_ID");
                entity.Property(e => e.Bb027Calcsubstituicao)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CALCSUBSTITUICAO");
                entity.Property(e => e.Bb027Calculaiss)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CALCULAISS");
                entity.Property(e => e.Bb027CfopForaestadoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CFOP_FORAESTADO_ID");
                entity.Property(e => e.Bb027CfopStaticaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CFOP_STATICA_ID");
                entity.Property(e => e.Bb027Cfopdentroestado)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_CFOPDENTROESTADO");
                entity.Property(e => e.Bb027Cfopforaestado)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_CFOPFORAESTADO");
                entity.Property(e => e.Bb027CodgajusteicmsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_CODGAJUSTEICMS_ID");
                entity.Property(e => e.Bb027Codgcst)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_CODGCST");
                entity.Property(e => e.Bb027Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB027_CODIGO");
                entity.Property(e => e.Bb027Cofins)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_COFINS");
                entity.Property(e => e.Bb027Descnatoper)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_DESCNATOPER");
                entity.Property(e => e.Bb027Descricao)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_DESCRICAO");
                entity.Property(e => e.Bb027Difa)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_DIFA");
                entity.Property(e => e.Bb027EntsaiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ENTSAI_ID");
                entity.Property(e => e.Bb027Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB027_FILIAL");
                entity.Property(e => e.Bb027Geracreceber)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_GERACRECEBER");
                entity.Property(e => e.Bb027Geraestatistica)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_GERAESTATISTICA");
                entity.Property(e => e.Bb027Hashid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB027_HASHID");
                entity.Property(e => e.Bb027Icmsdiferido)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ICMSDIFERIDO");
                entity.Property(e => e.Bb027Icmsdiferidoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ICMSDIFERIDOID");
                entity.Property(e => e.Bb027Icst)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_ICST");
                entity.Property(e => e.Bb027IpiBrutoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_IPI_BRUTO_ID");
                entity.Property(e => e.Bb027Irpj)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_IRPJ");
                entity.Property(e => e.Bb027Irrf)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_IRRF");
                entity.Property(e => e.Bb027PicmsDiferido)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027_PICMS_DIFERIDO");
                entity.Property(e => e.Bb027Pis)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_PIS");
                entity.Property(e => e.Bb027PodertercId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_PODERTERC_ID");
                entity.Property(e => e.Bb027Reducaoicms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027_REDUCAOICMS");
                entity.Property(e => e.Bb027Reducaoicmsst)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027_REDUCAOICMSST");
                entity.Property(e => e.Bb027Reducaoipi)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027_REDUCAOIPI");
                entity.Property(e => e.Bb027Reducaoiss)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("BB027_REDUCAOISS");
                entity.Property(e => e.Bb027RegimeId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_REGIME_ID");
                entity.Property(e => e.Bb027SomaipiBaseicmsId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_SOMAIPI_BASEICMS_ID");
                entity.Property(e => e.Bb027TdevolucaoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB027_TDEVOLUCAO_ID");
                entity.Property(e => e.Bb027Transdevolucao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB027_TRANSDEVOLUCAO");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb027Tdevolucao).WithMany(p => p.InverseBb027Tdevolucao)
                //    .HasForeignKey(d => d.Bb027TdevolucaoId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB027_OSUSR_E9A_CSICP_BB027_BB027_TDEVOLUCAO_ID");
            });

            modelBuilder.Entity<CSICP_Bb028>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB028");

                entity.ToTable("OSUSR_E9A_CSICP_BB028");

                entity.HasIndex(e => new { e.Bb028TipoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB028_13BB028_TIPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb028Contafornid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB028_17BB028_CONTAFORNID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB028_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb028Agencia)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_AGENCIA");
                entity.Property(e => e.Bb028Celular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_CELULAR");
                entity.Property(e => e.Bb028Cnpj)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_CNPJ");
                entity.Property(e => e.Bb028Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB028_CODIGO");
                entity.Property(e => e.Bb028Coms1)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_COMS1");
                entity.Property(e => e.Bb028Coms2)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_COMS2");
                entity.Property(e => e.Bb028Coms3)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_COMS3");
                entity.Property(e => e.Bb028Coms4)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_COMS4");
                entity.Property(e => e.Bb028Coms5)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_COMS5");
                entity.Property(e => e.Bb028Conta)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_CONTA");
                entity.Property(e => e.Bb028Contafornid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB028_CONTAFORNID");
                entity.Property(e => e.Bb028Datanasc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB028_DATANASC");
                entity.Property(e => e.Bb028Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_EMAIL");
                entity.Property(e => e.Bb028Fax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_FAX");
                entity.Property(e => e.Bb028Geracpagar)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_GERACPAGAR");
                entity.Property(e => e.Bb028Homepage)
                    .HasMaxLength(80)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_HOMEPAGE");
                entity.Property(e => e.Bb028Inscestadual)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_INSCESTADUAL");
                entity.Property(e => e.Bb028Inscmunicipal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028_INSCMUNICIPAL");
                entity.Property(e => e.Bb028Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB028_ISACTIVE");
                entity.Property(e => e.Bb028Nomebanco)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_NOMEBANCO");
                entity.Property(e => e.Bb028Nomereduzido)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_NOMEREDUZIDO");
                entity.Property(e => e.Bb028Nomeresponsavel)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_NOMERESPONSAVEL");
                entity.Property(e => e.Bb028Observacao)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_OBSERVACAO");
                entity.Property(e => e.Bb028Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB028_TELEFONE");
                entity.Property(e => e.Bb028TipoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB028_TIPO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBB028Tp).WithOne().HasForeignKey<CSICP_Bb028>(e => e.Bb028TipoId);
                entity.HasOne(e => e.NavBB012).WithOne().HasForeignKey<CSICP_Bb028>(e => e.Bb028Contafornid);
            });

            modelBuilder.Entity<CSICP_Bb028b>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB028B");

                entity.ToTable("OSUSR_E9A_CSICP_BB028B");

                entity.HasIndex(e => new { e.Bb028bContaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB028B_14BB028B_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb028bCompradorId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB028B_19BB028B_COMPRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB028B_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb028bCodigocliente)
                    .HasDefaultValue(0)
                    .HasColumnName("BB028B_CODIGOCLIENTE");
                entity.Property(e => e.Bb028bCodresponsavel)
                    .HasDefaultValue(0)
                    .HasColumnName("BB028B_CODRESPONSAVEL");
                entity.Property(e => e.Bb028bCompradorId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB028B_COMPRADOR_ID");
                entity.Property(e => e.Bb028bContaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB028B_CONTAID");
                entity.Property(e => e.Bb028bFilial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB028B_FILIAL");
                entity.Property(e => e.Bb028bPerccomissao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB028B_PERCCOMISSAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB012).WithOne().HasForeignKey<CSICP_Bb028b>(d => d.Bb028bContaid);
            });

            modelBuilder.Entity<CSICP_Bb029>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB029");

                entity.ToTable("OSUSR_E9A_CSICP_BB029");

                entity.HasIndex(e => new { e.Bb029Categoria, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB029_15BB029_CATEGORIA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB029_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb029Categoria)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB029_CATEGORIA");
                entity.Property(e => e.Bb029Codgcategoria)
                    .HasDefaultValue(0)
                    .HasColumnName("BB029_CODGCATEGORIA");
                entity.Property(e => e.Bb029IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB029_IS_ACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
