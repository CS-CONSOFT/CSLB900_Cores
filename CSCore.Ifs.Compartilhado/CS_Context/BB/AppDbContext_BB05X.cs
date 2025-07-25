
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb050> OsusrE9aCsicpBb050s { get; set; }

        public DbSet<CSICP_Bb051> OsusrE9aCsicpBb051s { get; set; }

        public DbSet<CSICP_Bb055> OsusrE9aCsicpBb055s { get; set; }

        public DbSet<CSICP_Bb056> OsusrE9aCsicpBb056s { get; set; }

        public DbSet<CSICP_Bb057> OsusrE9aCsicpBb057s { get; set; }
        partial void OnModelCreating_CSICP_BB05X(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Bb050>(entity =>
            {
                entity.HasKey(e => e.Bb050Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB050");

                entity.ToTable("OSUSR_E9A_CSICP_BB050");

                entity.HasIndex(e => new { e.Bb050Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB050_15BB050_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb050Grupoprodutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB050_20BB050_GRUPOPRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB050_9TENANT_ID");

                entity.Property(e => e.Bb050Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB050_ID");
                entity.Property(e => e.Bb050Datafinal)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB050_DATAFINAL");
                entity.Property(e => e.Bb050Datainicio)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB050_DATAINICIO");
                entity.Property(e => e.Bb050Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB050_EMPRESAID");
                entity.Property(e => e.Bb050Grupoprodutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB050_GRUPOPRODUTOID");
                entity.Property(e => e.Bb050Valorminimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB050_VALORMINIMO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb051>(entity =>
            {
                entity.HasKey(e => e.Bb051Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB051");

                entity.ToTable("OSUSR_E9A_CSICP_BB051");

                entity.HasIndex(e => new { e.Bb051Formapagtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB051_18BB051_FORMAPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb050Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB051_8BB050_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB051_9TENANT_ID");

                entity.Property(e => e.Bb051Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB051_ID");
                entity.Property(e => e.Bb050Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB050_ID");
                entity.Property(e => e.Bb051Formapagtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB051_FORMAPAGTOID");
                entity.Property(e => e.Bb051Maxparcela)
                    .HasDefaultValue(0)
                    .HasColumnName("BB051_MAXPARCELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb050).WithMany(p => p.OsusrE9aCsicpBb051s)
                //    .HasForeignKey(d => d.Bb050Id)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB051_OSUSR_E9A_CSICP_BB050_BB050_ID");

                //entity.HasOne(d => d.Bb051Formapagto).WithMany(p => p.OsusrE9aCsicpBb051s)
                //    .HasForeignKey(d => d.Bb051Formapagtoid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB051_OSUSR_E9A_CSICP_BB026_BB051_FORMAPAGTOID");
            });

            modelBuilder.Entity<CSICP_Bb055>(entity =>
            {
                entity.HasKey(e => e.Bb055Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB055");

                entity.ToTable("OSUSR_E9A_CSICP_BB055");

                entity.HasIndex(e => new { e.Bb055UfId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB055_11BB055_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb055Paisid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB055_12BB055_PAISID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb055Cidadeid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB055_14BB055_CIDADEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB055_9TENANT_ID");

                entity.Property(e => e.Bb055Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB055_ID");
                entity.Property(e => e.Bb055Bairro)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_BAIRRO");
                entity.Property(e => e.Bb055CelularContato)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_CELULAR_CONTATO");
                entity.Property(e => e.Bb055Cep)
                    .HasDefaultValue(0)
                    .HasColumnName("BB055_CEP");
                entity.Property(e => e.Bb055Cidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB055_CIDADEID");
                entity.Property(e => e.Bb055Complemento)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_COMPLEMENTO");
                entity.Property(e => e.Bb055Desespecialidade)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_DESESPECIALIDADE");
                entity.Property(e => e.Bb055Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_EMAIL");
                entity.Property(e => e.Bb055EmailContato)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_EMAIL_CONTATO");
                entity.Property(e => e.Bb055IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB055_IS_ACTIVE");
                entity.Property(e => e.Bb055Logradouro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_LOGRADOURO");
                entity.Property(e => e.Bb055Nome)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_NOME");
                entity.Property(e => e.Bb055Nomecontato)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_NOMECONTATO");
                entity.Property(e => e.Bb055Numero)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_NUMERO");
                entity.Property(e => e.Bb055Paisid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB055_PAISID");
                entity.Property(e => e.Bb055Perimetro)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_PERIMETRO");
                entity.Property(e => e.Bb055Ratemedia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB055_RATEMEDIA");
                entity.Property(e => e.Bb055Tags)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_TAGS");
                entity.Property(e => e.Bb055Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_TELEFONE");
                entity.Property(e => e.Bb055UfId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB055_UF_ID");
                entity.Property(e => e.Bb055UrlAvatar)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_URL_AVATAR");
                entity.Property(e => e.Bb055UrlLogo)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_URL_LOGO");
                entity.Property(e => e.Bb055UrlSeloqld)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB055_URL_SELOQLD");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nav_CSICP_AA028).WithOne().HasForeignKey<CSICP_Bb055>(d => d.Bb055Cidadeid);
                entity.HasOne(d => d.Nav_CSICP_AA027).WithOne().HasForeignKey<CSICP_Bb055>(d => d.Bb055UfId);
            });

            modelBuilder.Entity<CSICP_Bb056>(entity =>
            {
                entity.HasKey(e => e.Bb056Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB056");

                entity.ToTable("OSUSR_E9A_CSICP_BB056");

                entity.HasIndex(e => new { e.Bb056Profid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB056_12BB056_PROFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb056Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB056_13BB056_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb056Datahora, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB056_14BB056_DATAHORA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB056_9TENANT_ID");

                entity.Property(e => e.Bb056Id).HasColumnName("BB056_ID");
                entity.Property(e => e.Bb056Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB056_CONTAID");
                entity.Property(e => e.Bb056Datahora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB056_DATAHORA");
                entity.Property(e => e.Bb056Dtsmscliente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB056_DTSMSCLIENTE");
                entity.Property(e => e.Bb056Dtsmsprof)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB056_DTSMSPROF");
                entity.Property(e => e.Bb056Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB056_ISACTIVE");
                entity.Property(e => e.Bb056Issmsenviadocliente)
                    .HasDefaultValue(false)
                    .HasColumnName("BB056_ISSMSENVIADOCLIENTE");
                entity.Property(e => e.Bb056Issmsenviadoprof)
                    .HasDefaultValue(false)
                    .HasColumnName("BB056_ISSMSENVIADOPROF");
                entity.Property(e => e.Bb056Mensagem)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB056_MENSAGEM");
                entity.Property(e => e.Bb056Profid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB056_PROFID");
                entity.Property(e => e.Bb056Rate)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB056_RATE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB012).WithOne().HasForeignKey<CSICP_Bb056>(d => d.Bb056Contaid);
            });

            modelBuilder.Entity<CSICP_Bb057>(entity =>
            {
                entity.HasKey(e => e.Bb057Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB057");

                entity.ToTable("OSUSR_E9A_CSICP_BB057");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB057_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb055Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB057_8BB055_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB057_9TENANT_ID");

                entity.Property(e => e.Bb057Id).HasColumnName("BB057_ID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Bb055Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB055_ID");
                entity.Property(e => e.Bb057Datahora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB057_DATAHORA");
                entity.Property(e => e.Bb057Dtsmscliente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB057_DTSMSCLIENTE");
                entity.Property(e => e.Bb057Dtsmsprof)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB057_DTSMSPROF");
                entity.Property(e => e.Bb057Issmsenvcliente)
                    .HasDefaultValue(false)
                    .HasColumnName("BB057_ISSMSENVCLIENTE");
                entity.Property(e => e.Bb057Issmsenvprof)
                    .HasDefaultValue(false)
                    .HasColumnName("BB057_ISSMSENVPROF");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB012).WithOne().HasForeignKey<CSICP_Bb057>(d => d.Bb012Id);
            });

        }
    }
}
