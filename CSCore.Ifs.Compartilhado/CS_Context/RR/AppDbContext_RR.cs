using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<OsusrTo3CsicpRr001> OsusrTo3CsicpRr001s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr001Ativo> OsusrTo3CsicpRr001Ativos { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr001Cat> OsusrTo3CsicpRr001Cats { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr001Sexo> OsusrTo3CsicpRr001Sexos { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr002> OsusrTo3CsicpRr002s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr003> OsusrTo3CsicpRr003s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr004> OsusrTo3CsicpRr004s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr005> OsusrTo3CsicpRr005s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr006> OsusrTo3CsicpRr006s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr007> OsusrTo3CsicpRr007s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr008> OsusrTo3CsicpRr008s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr009> OsusrTo3CsicpRr009s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr010> OsusrTo3CsicpRr010s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr011> OsusrTo3CsicpRr011s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr020> OsusrTo3CsicpRr020s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr021> OsusrTo3CsicpRr021s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr022> OsusrTo3CsicpRr022s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr030> OsusrTo3CsicpRr030s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr031> OsusrTo3CsicpRr031s { get; set; }

        public virtual DbSet<OsusrTo3CsicpRr035> OsusrTo3CsicpRr035s { get; set; }
        partial void OnModelCreatingRR(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<OsusrTo3CsicpRr001>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR001");

                entity.ToTable("OSUSR_TO3_CSICP_RR001");

                entity.HasIndex(e => new { e.Rr001Catid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_11RR001_CATID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001MaeId, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_12RR001_MAE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001PaiId, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_12RR001_PAI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Racaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_12RR001_RACAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Sexoid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_12RR001_SEXOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Ativoid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_13RR001_ATIVOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Fazendaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_15RR001_FAZENDAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Situacaoid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_16RR001_SITUACAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Categoriaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_17RR001_CATEGORIAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Ocorrenciaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_18RR001_OCORRENCIAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Usuariopropid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_19RR001_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Proprietarioid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_20RR001_PROPRIETARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR001_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Proprietario2id, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_21RR001_PROPRIETARIO2ID_9TENANT_ID");
                
                entity.HasIndex(e => new { e.Rr001Criadorid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR001_15RR001_CRIADORID_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr001Apelido)
                    .HasMaxLength(100)
                    .HasColumnName("RR001_APELIDO");
                entity.Property(e => e.Rr001Ativoid).HasColumnName("RR001_ATIVOID");
                entity.Property(e => e.Rr001Categoriaid).HasColumnName("RR001_CATEGORIAID");
                entity.Property(e => e.Rr001Catid).HasColumnName("RR001_CATID");
                entity.Property(e => e.Rr001Dtcategoria)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTCATEGORIA");
                entity.Property(e => e.Rr001Dtnascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTNASCIMENTO");
                entity.Property(e => e.Rr001Dtocorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTOCORRENCIA");
                entity.Property(e => e.Rr001Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTREGISTRO");
                entity.Property(e => e.Rr001Dtultpeso)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTULTPESO");
                entity.Property(e => e.Rr001Fazendaid)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_FAZENDAID");
                entity.Property(e => e.Rr001MaeId)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_MAE_ID");
                entity.Property(e => e.Rr001Nomeanimal)
                    .HasMaxLength(100)
                    .HasColumnName("RR001_NOMEANIMAL");
                entity.Property(e => e.Rr001Nrorgn).HasColumnName("RR001_NRORGN");
                entity.Property(e => e.Rr001Observacao)
                    .HasMaxLength(500)
                    .HasColumnName("RR001_OBSERVACAO");
                entity.Property(e => e.Rr001Ocorrenciaid).HasColumnName("RR001_OCORRENCIAID");
                entity.Property(e => e.Rr001PaiId)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_PAI_ID");
                entity.Property(e => e.Rr001Pesonasc)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR001_PESONASC");
                entity.Property(e => e.Rr001Proprietarioid).HasColumnName("RR001_PROPRIETARIOID");
                entity.Property(e => e.Rr001Racaid).HasColumnName("RR001_RACAID");
                entity.Property(e => e.Rr001Serie)
                    .HasMaxLength(10)
                    .HasColumnName("RR001_SERIE");
                entity.Property(e => e.Rr001Sexoid).HasColumnName("RR001_SEXOID");
                entity.Property(e => e.Rr001Situacaoid).HasColumnName("RR001_SITUACAOID");
                entity.Property(e => e.Rr001Ultidadediaspeso).HasColumnName("RR001_ULTIDADEDIASPESO");
                entity.Property(e => e.Rr001Ultpeso)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR001_ULTPESO");
                entity.Property(e => e.Rr001Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.Property(e => e.Rr001Proprietario2id).HasColumnName("RR001_PROPRIETARIO2ID");
                entity.Property(e => e.Rr001Criadorid).HasColumnName("RR001_CRIADORID");

            });

            modelBuilder.Entity<OsusrTo3CsicpRr001Ativo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR001_ATIVO");

                entity.ToTable("OSUSR_TO3_CSICP_RR001_ATIVO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr001Cat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR001_CAT");

                entity.ToTable("OSUSR_TO3_CSICP_RR001_CAT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr001Sexo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR001_SEXO");

                entity.ToTable("OSUSR_TO3_CSICP_RR001_SEXO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr002>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR002");

                entity.ToTable("OSUSR_TO3_CSICP_RR002");

                entity.HasIndex(e => new { e.Rr002Ufid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR002_10RR002_UFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr002Paisid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR002_12RR002_PAISID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr002Cidadeid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR002_14RR002_CIDADEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR002_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr002Bairro)
                    .HasMaxLength(30)
                    .HasColumnName("RR002_BAIRRO");
                entity.Property(e => e.Rr002Cep).HasColumnName("RR002_CEP");
                entity.Property(e => e.Rr002Cidadeid)
                    .HasMaxLength(36)
                    .HasColumnName("RR002_CIDADEID");
                entity.Property(e => e.Rr002Cnpj)
                    .HasMaxLength(14)
                    .HasColumnName("RR002_CNPJ");
                entity.Property(e => e.Rr002Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("RR002_COMPLEMENTO");
                entity.Property(e => e.Rr002Endereco)
                    .HasMaxLength(60)
                    .HasColumnName("RR002_ENDERECO");
                entity.Property(e => e.Rr002Nomefazenda)
                    .HasMaxLength(100)
                    .HasColumnName("RR002_NOMEFAZENDA");
                entity.Property(e => e.Rr002Nroender)
                    .HasMaxLength(10)
                    .HasColumnName("RR002_NROENDER");
                entity.Property(e => e.Rr002Paisid)
                    .HasMaxLength(36)
                    .HasColumnName("RR002_PAISID");
                entity.Property(e => e.Rr002Ufid)
                    .HasMaxLength(36)
                    .HasColumnName("RR002_UFID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr003>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR003");

                entity.ToTable("OSUSR_TO3_CSICP_RR003");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR003_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr003Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("RR003_DESCRICAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr004>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR004");

                entity.ToTable("OSUSR_TO3_CSICP_RR004");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR004_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr004Raca)
                    .HasMaxLength(50)
                    .HasColumnName("RR004_RACA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr005>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR005");

                entity.ToTable("OSUSR_TO3_CSICP_RR005");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR005_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr005Situacao)
                    .HasMaxLength(50)
                    .HasColumnName("RR005_SITUACAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR006");

                entity.ToTable("OSUSR_TO3_CSICP_RR006");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR006_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr006Ocorrencia)
                    .HasMaxLength(50)
                    .HasColumnName("RR006_OCORRENCIA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR007");

                entity.ToTable("OSUSR_TO3_CSICP_RR007");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR007_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr007Proprietario)
                    .HasMaxLength(50)
                    .HasColumnName("RR007_PROPRIETARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr008>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR008");

                entity.ToTable("OSUSR_TO3_CSICP_RR008");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR008_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr008Descritivo)
                    .HasMaxLength(500)
                    .HasColumnName("RR008_DESCRITIVO");
                entity.Property(e => e.Rr008Regalimentar)
                    .HasMaxLength(50)
                    .HasColumnName("RR008_REGALIMENTAR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr009>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR009");

                entity.ToTable("OSUSR_TO3_CSICP_RR009");

                entity.HasIndex(e => new { e.Rr001Virtualid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR009_15RR001_VIRTUALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr001Id, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR009_8RR001_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR009_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr001Id)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_ID");
                entity.Property(e => e.Rr001Virtualid)
                    .HasMaxLength(36)
                    .HasColumnName("RR001_VIRTUALID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavRR001AnimalVirtual_RR009)
                .WithMany()
                .HasForeignKey(e => e.Rr001Virtualid)
                .HasPrincipalKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OsusrTo3CsicpRr010>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR010");

                entity.ToTable("OSUSR_TO3_CSICP_RR010");

                entity.HasIndex(e => new { e.Rr010Condcriacao, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR010_17RR010_CONDCRIACAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR010_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr010Condcriacao)
                    .HasMaxLength(50)
                    .HasColumnName("RR010_CONDCRIACAO");
                entity.Property(e => e.Rr010Descritivo)
                    .HasMaxLength(500)
                    .HasColumnName("RR010_DESCRITIVO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr011>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR011");

                entity.ToTable("OSUSR_TO3_CSICP_RR011");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR011_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Rr011Serie)
                    .HasMaxLength(10)
                    .HasColumnName("RR011_SERIE");
                entity.Property(e => e.Rr011Ultrgn).HasColumnName("RR011_ULTRGN");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr020>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR020");

                entity.ToTable("OSUSR_TO3_CSICP_RR020");

                entity.HasIndex(e => new { e.Rr020Regalimentarid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR020_20RR020_REGALIMENTARID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR020_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr020Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("RR020_DESCRICAO");
                entity.Property(e => e.Rr020Dtfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("RR020_DTFINAL");
                entity.Property(e => e.Rr020Dtinicio)
                    .HasColumnType("datetime")
                    .HasColumnName("RR020_DTINICIO");
                entity.Property(e => e.Rr020Identificador)
                    .HasMaxLength(20)
                    .HasColumnName("RR020_IDENTIFICADOR");
                entity.Property(e => e.Rr020Regalimentarid).HasColumnName("RR020_REGALIMENTARID");
                entity.Property(e => e.Rr020IsActive).HasColumnName("rr020_IsActive");

                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<OsusrTo3CsicpRr021>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR021");

                entity.ToTable("OSUSR_TO3_CSICP_RR021");

                entity.HasIndex(e => new { e.Rr021Loteid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR021_12RR021_LOTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr021Animalid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR021_14RR021_ANIMALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR021_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr021Animalid)
                    .HasMaxLength(36)
                    .HasColumnName("RR021_ANIMALID");
                entity.Property(e => e.Rr021Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("RR021_DTREGISTRO");
                entity.Property(e => e.Rr021Loteid)
                    .HasMaxLength(36)
                    .HasColumnName("RR021_LOTEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<OsusrTo3CsicpRr022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR022");

                entity.ToTable("OSUSR_TO3_CSICP_RR022");

                entity.HasIndex(e => new { e.Rr022Loteid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR022_12RR022_LOTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr022Animalid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR022_14RR022_ANIMALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr022Usuarioid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR022_15RR022_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR022_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr022Condcriacaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR022_18RR022_CONDCRIACAID_9TENANT_ID");


                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr001Dtultpeso)
                    .HasColumnType("datetime")
                    .HasColumnName("RR001_DTULTPESO");
                entity.Property(e => e.Rr001Ultpeso)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR001_ULTPESO");
                entity.Property(e => e.Rr022Animalid)
                    .HasMaxLength(36)
                    .HasColumnName("RR022_ANIMALID");
                entity.Property(e => e.Rr022Dthrregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("RR022_DTHRREGISTRO");
                entity.Property(e => e.Rr022Dtpeso)
                    .HasColumnType("datetime")
                    .HasColumnName("RR022_DTPESO");
                entity.Property(e => e.Rr022Gmd)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR022_GMD");
                entity.Property(e => e.Rr022Gpd)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR022_GPD");
                entity.Property(e => e.Rr022Idadediasatual).HasColumnName("RR022_IDADEDIASATUAL");
                entity.Property(e => e.Rr022Idadediasult).HasColumnName("RR022_IDADEDIASULT");

                entity.Property(e => e.Rr022Loteid)
                    .HasMaxLength(36)
                    .HasColumnName("RR022_LOTEID");

                entity.Property(e => e.Rr022Peso)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RR022_PESO");
                entity.Property(e => e.Rr022Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("RR022_USUARIOID");
                entity.Property(e => e.Rr022IsProcessado).HasColumnName("rr022_IsProcessado");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.Property(e => e.Rr022Observacao)
                    .HasMaxLength(150)
                    .HasColumnName("RR022_OBSERVACAO");

                entity.Property(e => e.Rr022Circexcrotal)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("RR022_CIRCEXCROTAL");


            });

            modelBuilder.Entity<OsusrTo3CsicpRr030>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR030");

                entity.ToTable("OSUSR_TO3_CSICP_RR030");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR030_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr030Datamontafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_DATAMONTAFINAL");
                entity.Property(e => e.Rr030Datamontainicial)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_DATAMONTAINICIAL");
                entity.Property(e => e.Rr030Dataprovontafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_DATAPROVONTAFINAL");
                entity.Property(e => e.Rr030Dataprovontainicial)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_DATAPROVONTAINICIAL");
                entity.Property(e => e.Rr030Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("RR030_DESCRICAO");
                entity.Property(e => e.Rr030IaData)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_IA_DATA");
                entity.Property(e => e.Rr030IaDatadg)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_IA_DATADG");
                entity.Property(e => e.Rr030IaNrodias).HasColumnName("RR030_IA_NRODIAS");
                entity.Property(e => e.Rr030Montafinaldias).HasColumnName("RR030_MONTAFINALDIAS");
                entity.Property(e => e.Rr030Montainicialdias).HasColumnName("RR030_MONTAINICIALDIAS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.Property(e => e.Rr030Iadatafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_IA_DATAFINAL");

                entity.Property(e => e.Rr030IaNrodiasfinal).HasColumnName("RR030_IA_NRODIASFINAL");

                entity.Property(e => e.RR030Iadatadgfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("RR030_IA_DATADGFINAL");
            });

            modelBuilder.Entity<OsusrTo3CsicpRr031>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR031");

                entity.ToTable("OSUSR_TO3_CSICP_RR031");

                entity.HasIndex(e => new { e.Rr031IatfId, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR031_13RR031_IATF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr031Semenid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR031_13RR031_SEMENID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr031Animalid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR031_14RR031_ANIMALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Rr031Montaanimalid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR031_19RR031_MONTAANIMALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR031_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr031Animalid)
                    .HasMaxLength(36)
                    .HasColumnName("RR031_ANIMALID");
                entity.Property(e => e.Rr031Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("RR031_DTREGISTRO");
                entity.Property(e => e.Rr031IatfId)
                    .HasMaxLength(36)
                    .HasColumnName("RR031_IATF_ID");
                entity.Property(e => e.Rr031Ispositivo).HasColumnName("RR031_ISPOSITIVO");
                entity.Property(e => e.Rr031Montaanimalid)
                    .HasMaxLength(36)
                    .HasColumnName("RR031_MONTAANIMALID");
                entity.Property(e => e.Rr031Semenid)
                    .HasMaxLength(36)
                    .HasColumnName("RR031_SEMENID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.Property(e => e.Rr031Tiporeg).HasColumnName("RR031_TIPOREG");
                entity.Property(e => e.Rr031Isabsorveu).HasColumnName("RR031_ISABSORVEU");

                // Configuração de chave para buscar em RR021 (TenantId + Rr021Animalid)
                entity.HasOne(d => d.NavRR021Lote_RR031)
                    .WithMany()
                    .HasPrincipalKey(p => new { p.TenantId, p.Rr021Animalid })
                    .HasForeignKey(d => new { d.TenantId, d.Rr031Animalid })
                    .HasConstraintName("FK_RR031_RR021_Animal")
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<OsusrTo3CsicpRr035>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TO3_CSICP_RR035");

                entity.ToTable("OSUSR_TO3_CSICP_RR035");

                entity.HasIndex(e => new { e.Rr035Racaid, e.TenantId }, "OSIDX_OSUSR_TO3_CSICP_RR035_12RR035_RACAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TO3_CSICP_RR035_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Rr035Concespermatica)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_CONCESPERMATICA");
                entity.Property(e => e.Rr035Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("RR035_DESCRICAO");
                entity.Property(e => e.Rr035Dtcongelamento)
                    .HasColumnType("datetime")
                    .HasColumnName("RR035_DTCONGELAMENTO");
                entity.Property(e => e.Rr035Identtouro)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_IDENTTOURO");
                entity.Property(e => e.Rr035Lote)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_LOTE");
                entity.Property(e => e.Rr035Nomefornecedor)
                    .HasMaxLength(100)
                    .HasColumnName("RR035_NOMEFORNECEDOR");
                entity.Property(e => e.Rr035Nroregtouro)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_NROREGTOURO");
                entity.Property(e => e.Rr035Nrosemem)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_NROSEMEM");
                entity.Property(e => e.Rr035Observacao)
                    .HasMaxLength(100)
                    .HasColumnName("RR035_OBSERVACAO");
                entity.Property(e => e.Rr035Racaid).HasColumnName("RR035_RACAID");
                entity.Property(e => e.Rr035Volume)
                    .HasMaxLength(30)
                    .HasColumnName("RR035_VOLUME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });
            modelBuilder.HasSequence("Seq_PK_ID");

        }
    }
}
