
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb006> OsusrE9aCsicpBb006s { get; set; }

        partial void OnModelCreating_CSICP_BB006(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB006");

                entity.ToTable("OSUSR_E9A_CSICP_BB006");

                entity.HasIndex(e => new { e.Bb006Banco, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_11BB006_BANCO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb006BancoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_14BB006_BANCO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb006CodcobradorId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_20BB006_CODCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb006Tipocobrancaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_20BB006_TIPOCOBRANCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb006Movtatesouraria, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_21BB006_MOVTATESOURARIA_9TENANT_ID");

                entity.HasIndex(e => new { e.Ufid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_4UFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bairroid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_8BAIRROID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cidadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_8CIDADEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB006_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB006_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bairroid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BAIRROID");
                entity.Property(e => e.Bb006Agencia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("BB006_AGENCIA");
                entity.Property(e => e.Bb006AgenciaDv)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_AGENCIA_DV");
                entity.Property(e => e.Bb006ApiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB006_API_ID");
                entity.Property(e => e.Bb006Banco)
                    .HasMaxLength(40)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_BANCO");
                entity.Property(e => e.Bb006BancoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB006_BANCO_ID");
                entity.Property(e => e.Bb006Classificacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_CLASSIFICACAO");
                entity.Property(e => e.Bb006CodcobradorId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB006_CODCOBRADOR_ID");
                entity.Property(e => e.Bb006Codempresabanco)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_CODEMPRESABANCO");
                entity.Property(e => e.Bb006Codgbanco)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_CODGBANCO");
                entity.Property(e => e.Bb006Codgeracaocrec)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_CODGERACAOCREC");
                entity.Property(e => e.Bb006Codghistorico)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_CODGHISTORICO");
                entity.Property(e => e.Bb006Contacontabil)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_CONTACONTABIL");
                entity.Property(e => e.Bb006Contadv)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_CONTADV");
                entity.Property(e => e.Bb006Contato)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_CONTATO");
                entity.Property(e => e.Bb006Diasretencao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB006_DIASRETENCAO");
                entity.Property(e => e.Bb006Diasretencaodesc)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("BB006_DIASRETENCAODESC");
                entity.Property(e => e.Bb006Dvagenciacc)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_DVAGENCIACC");
                entity.Property(e => e.Bb006Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_EMAIL");
                entity.Property(e => e.Bb006Endereco)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_ENDERECO");
                entity.Property(e => e.Bb006Fax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_FAX");
                entity.Property(e => e.Bb006Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_FILIAL");
                entity.Property(e => e.Bb006Homepage)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_HOMEPAGE");
                entity.Property(e => e.Bb006Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB006_ISACTIVE");
                entity.Property(e => e.Bb006Limitecredito)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB006_LIMITECREDITO");
                entity.Property(e => e.Bb006Movtatesouraria)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB006_MOVTATESOURARIA");
                entity.Property(e => e.Bb006Msgboleto)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_MSGBOLETO");
                entity.Property(e => e.Bb006Nobanco)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("BB006_NOBANCO");
                entity.Property(e => e.Bb006Noconta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("BB006_NOCONTA");
                entity.Property(e => e.Bb006Nomeagencia)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_NOMEAGENCIA");
                entity.Property(e => e.Bb006Nomereduzido)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_NOMEREDUZIDO");
                entity.Property(e => e.Bb006Nroseqremessa)
                    .HasDefaultValue(0)
                    .HasColumnName("BB006_NROSEQREMESSA");
                entity.Property(e => e.Bb006Perccomissao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB006_PERCCOMISSAO");
                entity.Property(e => e.Bb006Saldoatual)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB006_SALDOATUAL");
                entity.Property(e => e.Bb006Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB006_TELEFONE");
                entity.Property(e => e.Bb006Tipocobrancaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB006_TIPOCOBRANCAID");
                entity.Property(e => e.Bb006Txcobsimples)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB006_TXCOBSIMPLES");
                entity.Property(e => e.Bb006Txdesconto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB006_TXDESCONTO");
                entity.Property(e => e.Cidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CIDADEID");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Ufid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("UFID");

                //entity.HasOne(d => d.Bairro).WithMany(p => p.OsusrE9aCsicpBb006s)
                //    .HasForeignKey(d => d.Bairroid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB006_OSUSR_E9A_CSICP_BB013_BAIRROID");

                //entity.HasOne(d => d.Bb006Tipocobranca).WithMany(p => p.OsusrE9aCsicpBb006s)
                //    .HasForeignKey(d => d.Bb006Tipocobrancaid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB006_OSUSR_E9A_CSICP_BB009_BB006_TIPOCOBRANCAID");
            });
        }
    }
}
