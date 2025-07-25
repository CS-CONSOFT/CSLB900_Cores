
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB007> OsusrE9aCsicpBb007s { get; set; }

        public DbSet<CSICP_BB007c> OsusrE9aCsicpBb007cs { get; set; }

        public DbSet<CSICP_BB007d> OsusrE9aCsicpBb007ds { get; set; }

        partial void OnModelCreating_CSICP_BB007(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_BB007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB007");

                entity.ToTable("OSUSR_E9A_CSICP_BB007");

                entity.HasIndex(e => new { e.Bb007Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_13BB007_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb032Cargoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_13BB032_CARGOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_14BB007_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb031Funcaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_14BB031_FUNCAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomipi, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_16BB007_BASECOMIPI_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Geracpagar, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_16BB007_GERACPAGAR_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_16BB007_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomicms, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_17BB007_BASECOMICMS_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Codggerente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_17BB007_CODGGERENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Contafornid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_17BB007_CONTAFORNID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomfrete, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_18BB007_BASECOMFRETE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomseguro, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_19BB007_BASECOMSEGURO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomicmsret, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_20BB007_BASECOMICMSRET_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Codgsupervisor, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_20BB007_CODGSUPERVISOR_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Vinculocliente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_20BB007_VINCULOCLIENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomacrfinan, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_21BB007_BASECOMACRFINAN_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Basecomdespesas, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_21BB007_BASECOMDESPESAS_9TENANT_ID");

                entity.HasIndex(e => new { e.Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007_9EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB007_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb007Agencia)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_AGENCIA");
                entity.Property(e => e.Bb007Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_ALMOXID");
                entity.Property(e => e.Bb007Basecomacrfinan)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMACRFINAN");
                entity.Property(e => e.Bb007Basecomdespesas)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMDESPESAS");
                entity.Property(e => e.Bb007Basecomfrete)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMFRETE");
                entity.Property(e => e.Bb007Basecomicms)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMICMS");
                entity.Property(e => e.Bb007Basecomicmsret)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMICMSRET");
                entity.Property(e => e.Bb007Basecomipi)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMIPI");
                entity.Property(e => e.Bb007Basecomseguro)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_BASECOMSEGURO");
                entity.Property(e => e.Bb007Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_CCUSTOID");
                entity.Property(e => e.Bb007Classificacao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_CLASSIFICACAO");
                entity.Property(e => e.Bb007Codgalmox)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_CODGALMOX");
                entity.Property(e => e.Bb007Codgatividade)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_CODGATIVIDADE");
                entity.Property(e => e.Bb007Codgccusto)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_CODGCCUSTO");
                entity.Property(e => e.Bb007Codggerente)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_CODGGERENTE");
                entity.Property(e => e.Bb007Codgregiao)
                    .HasMaxLength(5)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_CODGREGIAO");
                entity.Property(e => e.Bb007Codgsupervisor)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_CODGSUPERVISOR");
                entity.Property(e => e.Bb007Codigo)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_CODIGO");
                entity.Property(e => e.Bb007Coms1)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_COMS1");
                entity.Property(e => e.Bb007Coms2)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_COMS2");
                entity.Property(e => e.Bb007Coms3)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_COMS3");
                entity.Property(e => e.Bb007Coms4)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_COMS4");
                entity.Property(e => e.Bb007Coms5)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_COMS5");
                entity.Property(e => e.Bb007Conta)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_CONTA");
                entity.Property(e => e.Bb007Contafornid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_CONTAFORNID");
                entity.Property(e => e.Bb007Coreregistro)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_COREREGISTRO");
                entity.Property(e => e.Bb007Cpf)
                    .HasMaxLength(11)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_CPF");
                entity.Property(e => e.Bb007Dtadmissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB007_DTADMISSAO");
                entity.Property(e => e.Bb007Dtdemissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB007_DTDEMISSAO");
                entity.Property(e => e.Bb007Faixaautorizacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_FAIXAAUTORIZACAO");
                entity.Property(e => e.Bb007Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_FILIAL");
                entity.Property(e => e.Bb007Geracpagar)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_GERACPAGAR");
                entity.Property(e => e.Bb007Handheldsuperv)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_HANDHELDSUPERV");
                entity.Property(e => e.Bb007Imphandheld)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_IMPHANDHELD");
                entity.Property(e => e.Bb007Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB007_ISACTIVE");
                entity.Property(e => e.Bb007Maxdescvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("BB007_MAXDESCVENDA");
                entity.Property(e => e.Bb007Nomebanco)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_NOMEBANCO");
                entity.Property(e => e.Bb007Nomereduzido)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_NOMEREDUZIDO");
                entity.Property(e => e.Bb007Nomeusuario)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_NOMEUSUARIO");
                entity.Property(e => e.Bb007Nrohandheld)
                    .HasDefaultValue(0)
                    .HasColumnName("BB007_NROHANDHELD");
                entity.Property(e => e.Bb007Observacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_OBSERVACAO");
                entity.Property(e => e.Bb007Responsavel)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_RESPONSAVEL");
                entity.Property(e => e.Bb007Senha)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_SENHA");
                entity.Property(e => e.Bb007Senhahandheld)
                    .HasMaxLength(8)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_SENHAHANDHELD");
                entity.Property(e => e.Bb007Userhandheld)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB007_USERHANDHELD");
                entity.Property(e => e.Bb007UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_USUARIO_ID");
                entity.Property(e => e.Bb007Vinculocliente)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_VINCULOCLIENTE");
                entity.Property(e => e.Bb031Funcaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB031_FUNCAOID");
                entity.Property(e => e.Bb032Cargoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB032_CARGOID");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb007Ccusto).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb007Ccustoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB007_OSUSR_E9A_CSICP_BB005_BB007_CCUSTOID");

                entity.HasOne(d => d.Bb007CodggerenteNavigation).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb007Codggerente)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB007_OSUSR_E9A_CSICP_BB007_BB007_CODGGERENTE");

                entity.HasOne(d => d.Bb007CodgsupervisorNavigation).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb007Codgsupervisor)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB007_OSUSR_E9A_CSICP_BB007_BB007_CODGSUPERVISOR");

                entity.HasOne(d => d.Bb031Funcao).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb031Funcaoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB007_OSUSR_E9A_CSICP_BB031_BB031_FUNCAOID");

                entity.HasOne(d => d.Bb032Cargo).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb032Cargoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB007_OSUSR_E9A_CSICP_BB032_BB032_CARGOID");

                entity.HasOne(d => d.Bb001Empresa).WithOne()
                  .HasForeignKey<CSICP_BB007>(d => d.Empresaid);

                entity.HasOne(d => d.CSICP_GG001).WithOne()
                    .HasForeignKey<CSICP_BB007>(d => d.Bb007Almoxid);
            });

            modelBuilder.Entity<CSICP_BB007c>(entity =>
            {
                entity.HasKey(e => e.Bb007cId).HasName("OSPRK_OSUSR_E9A_CSICP_BB007C");

                entity.ToTable("OSUSR_E9A_CSICP_BB007C");

                entity.HasIndex(e => new { e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007C_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Responid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007C_14BB007_RESPONID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB007C_9TENANT_ID");

                entity.Property(e => e.Bb007cId).HasColumnName("BB007C_ID");
                entity.Property(e => e.Bb007Responid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_RESPONID");
                entity.Property(e => e.Bb007cPcomissao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB007C_PCOMISSAO");
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb012Conta).WithOne()
                    .HasForeignKey<CSICP_BB007c>(d => d.Bb012Contaid)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CSICP_BB007d>(entity =>
            {
                entity.HasKey(e => e.Bb007dId).HasName("OSPRK_OSUSR_E9A_CSICP_BB007D");

                entity.ToTable("OSUSR_E9A_CSICP_BB007D");

                entity.HasIndex(e => new { e.Gg001Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007D_13GG001_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb007Responid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB007D_14BB007_RESPONID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB007D_9TENANT_ID");

                entity.Property(e => e.Bb007dId).HasColumnName("BB007D_ID");
                entity.Property(e => e.Bb007Responid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB007_RESPONID");
                entity.Property(e => e.Gg001Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG001_ALMOXID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.CSICP_GG001).WithOne().HasForeignKey<CSICP_BB007d>(d => d.Gg001Almoxid);
            });
        }
    }
}
