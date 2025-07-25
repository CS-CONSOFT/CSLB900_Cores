
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb031> OsusrE9aCsicpBb031s { get; set; }

        public DbSet<CSICP_Bb032> OsusrE9aCsicpBb032s { get; set; }

        public DbSet<CSICP_Bb035> OsusrE9aCsicpBb035s { get; set; }

        public DbSet<CSICP_Bb036> OsusrE9aCsicpBb036s { get; set; }



        public DbSet<CSICP_Bb037> OsusrE9aCsicpBb037s { get; set; }

        partial void OnModelCreating_CSICP_BB03X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb031>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB031");

                entity.ToTable("OSUSR_E9A_CSICP_BB031");

                entity.HasIndex(e => new { e.Bb031Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB031_15BB031_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB031_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb031Cbo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB031_CBO");
                entity.Property(e => e.Bb031Codgfuncaoid)
                    .HasDefaultValue(0)
                    .HasColumnName("BB031_CODGFUNCAOID");
                entity.Property(e => e.Bb031Descricao)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB031_DESCRICAO");
                entity.Property(e => e.Bb031Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB031_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb032>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB032");

                entity.ToTable("OSUSR_E9A_CSICP_BB032");

                entity.HasIndex(e => new { e.Bb032Cargo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB032_11BB032_CARGO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB032_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb032Cargo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB032_CARGO");
                entity.Property(e => e.Bb032Codgcargoid)
                    .HasDefaultValue(0)
                    .HasColumnName("BB032_CODGCARGOID");
                entity.Property(e => e.Bb032Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB032_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb035>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB035");

                entity.ToTable("OSUSR_E9A_CSICP_BB035");

                entity.HasIndex(e => new { e.Bb035Primeironome, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_18BB035_PRIMEIRONOME_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb035TratamentoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_19BB035_TRATAMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb035OrigemcontatoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB035_22BB035_ORIGEMCONTATO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB035_9TENANT_ID");

                //entity.HasIndex(e => new { e.Bb035CodgCliente7x, e.Bb035SeqCliente7x }, "idx_Contato_7x");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb035Assistente)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_ASSISTENTE");
                entity.Property(e => e.Bb035Celular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_CELULAR");
                //entity.Property(e => e.Bb035CodgCliente7x).HasColumnName("BB035_CODG_CLIENTE_7X");
                entity.Property(e => e.Bb035Cpf)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_CPF");
                entity.Property(e => e.Bb035DataAniversario)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB035_DATA_ANIVERSARIO");
                entity.Property(e => e.Bb035DataEmissaoRg)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB035_DATA_EMISSAO_RG");
                entity.Property(e => e.Bb035Departamento)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_DEPARTAMENTO");
                entity.Property(e => e.Bb035Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_DESCRICAO");
                entity.Property(e => e.Bb035Email)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_EMAIL");
                entity.Property(e => e.Bb035Emailsecundario)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_EMAILSECUNDARIO");
                entity.Property(e => e.Bb035Fax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_FAX");
                entity.Property(e => e.Bb035IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB035_IS_ACTIVE");
                entity.Property(e => e.Bb035OrgaoExpedRg)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_ORGAO_EXPED_RG");
                entity.Property(e => e.Bb035OrigemcontatoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_ORIGEMCONTATO_ID");
                entity.Property(e => e.Bb035Outrotelefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_OUTROTELEFONE");
                entity.Property(e => e.Bb035Primeironome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_PRIMEIRONOME");
                entity.Property(e => e.Bb035Rg)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("BB035_RG");
                //entity.Property(e => e.Bb035SeqCliente7x).HasColumnName("BB035_SEQ_CLIENTE_7X");
                entity.Property(e => e.Bb035Sobrenome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_SOBRENOME");
                entity.Property(e => e.Bb035Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_TELEFONE");
                entity.Property(e => e.Bb035Telefoneassist)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_TELEFONEASSIST");
                entity.Property(e => e.Bb035Telefoneresidencia)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_TELEFONERESIDENCIA");
                entity.Property(e => e.Bb035Titulo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB035_TITULO");
                entity.Property(e => e.Bb035TratamentoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB035_TRATAMENTO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavCSICP_BB035End).WithOne().HasForeignKey<CSICP_Bb035End>(e => e.Bb035Contatoid);
                entity.HasOne(e => e.NavCSICP_BB035Origem).WithOne().HasForeignKey<CSICP_Bb035>(e => e.Bb035OrigemcontatoId);
                entity.HasOne(e => e.NavCSICP_BB035Trat).WithOne().HasForeignKey<CSICP_Bb035>(e => e.Bb035TratamentoId);
            });

            modelBuilder.Entity<CSICP_Bb036>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB036");

                entity.ToTable("OSUSR_E9A_CSICP_BB036");

                entity.HasIndex(e => new { e.Bb036Atividadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_17BB036_ATIVIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036SituacaoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_17BB036_SITUACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036Primeironome, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_18BB036_PRIMEIRONOME_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb036TratamentoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB036_19BB036_TRATAMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB036_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb036Atividadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_ATIVIDADEID");
                entity.Property(e => e.Bb036Celular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_CELULAR");
                entity.Property(e => e.Bb036Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_DESCRICAO");
                entity.Property(e => e.Bb036Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_EMAIL");
                entity.Property(e => e.Bb036Emailsecundario)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_EMAILSECUNDARIO");
                entity.Property(e => e.Bb036Empresa)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_EMPRESA");
                entity.Property(e => e.Bb036Fax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_FAX");
                entity.Property(e => e.Bb036IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB036_IS_ACTIVE");
                entity.Property(e => e.Bb036Primeironome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_PRIMEIRONOME");
                entity.Property(e => e.Bb036Site)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_SITE");
                entity.Property(e => e.Bb036SituacaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_SITUACAO_ID");
                entity.Property(e => e.Bb036Sobrenome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_SOBRENOME");
                entity.Property(e => e.Bb036Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_TELEFONE");
                entity.Property(e => e.Bb036Titulo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB036_TITULO");
                entity.Property(e => e.Bb036TratamentoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB036_TRATAMENTO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb036Atividade).WithMany(p => p.OsusrE9aCsicpBb036s)
                //    .HasForeignKey(d => d.Bb036Atividadeid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB036_OSUSR_E9A_CSICP_BB011_BB036_ATIVIDADEID");
            });

            modelBuilder.Entity<CSICP_Bb037>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB037");

                entity.ToTable("OSUSR_E9A_CSICP_BB037");

                entity.HasIndex(e => new { e.Bb037Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB037_12BB037_CODIGO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb037Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB037_15BB037_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB037_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb037Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB037_CODIGO");
                entity.Property(e => e.Bb037Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB037_DESCRICAO");
                entity.Property(e => e.Bb037Dia)
                    .HasDefaultValue(0)
                    .HasColumnName("BB037_DIA");
                entity.Property(e => e.Bb037Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB037_ISACTIVE");
                entity.Property(e => e.Bb037Qtddiasmcompra)
                    .HasDefaultValue(0)
                    .HasColumnName("BB037_QTDDIASMCOMPRA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
