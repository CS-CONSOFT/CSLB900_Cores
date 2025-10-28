using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.CS_Models.Staticas.NN;
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
        public virtual DbSet<OsusrE9aCsicpNn001> OsusrE9aCsicpNn001s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn001Tp> OsusrE9aCsicpNn001Tps { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn002> OsusrE9aCsicpNn002s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn002Tpgru> OsusrE9aCsicpNn002Tpgrus { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn003> OsusrE9aCsicpNn003s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn004> OsusrE9aCsicpNn004s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn005> OsusrE9aCsicpNn005s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn010> OsusrE9aCsicpNn010s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn010Est> OsusrE9aCsicpNn010Ests { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn010Tmov> OsusrE9aCsicpNn010Tmovs { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn010Tplan> OsusrE9aCsicpNn010Tplans { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn010o> OsusrE9aCsicpNn010os { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn011> OsusrE9aCsicpNn011s { get; set; }

        public virtual DbSet<CSICP_NN015> OsusrE9aCsicpNn015s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn015Rp> OsusrE9aCsicpNn015Rps { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn015Stum> OsusrE9aCsicpNn015Sta { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn016> OsusrE9aCsicpNn016s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn017> OsusrE9aCsicpNn017s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn018> OsusrE9aCsicpNn018s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn019> OsusrE9aCsicpNn019s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn020> OsusrE9aCsicpNn020s { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn020Stat> OsusrE9aCsicpNn020Stats { get; set; }

        public virtual DbSet<OsusrE9aCsicpNn021> OsusrE9aCsicpNn021s { get; set; }

        partial void OnModelCreating_CSICP_NN(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OsusrE9aCsicpNn001>(entity =>
            {
                entity.HasKey(e => e.Nn001CtacorrenteId).HasName("OSPRK_OSUSR_E9A_CSICP_NN001");

                entity.ToTable("OSUSR_E9A_CSICP_NN001");

                entity.HasIndex(e => new { e.Nn001Banco, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN001_11NN001_BANCO_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001Usacix, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN001_12NN001_USACIX_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN001_15NN001_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001Tpcontaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN001_15NN001_TPCONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001Agcobradorid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN001_18NN001_AGCOBRADORID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN001_9TENANT_ID");

                entity.Property(e => e.Nn001CtacorrenteId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CTACORRENTE_ID");
                entity.Property(e => e.Nn001Agcobradorid)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_AGCOBRADORID");
                entity.Property(e => e.Nn001Agencia).HasColumnName("NN001_AGENCIA");
                entity.Property(e => e.Nn001Banco).HasColumnName("NN001_BANCO");
                entity.Property(e => e.Nn001Chequepredatados)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_CHEQUEPREDATADOS");
                entity.Property(e => e.Nn001ChequesEmitidos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_CHEQUES_EMITIDOS");
                entity.Property(e => e.Nn001Cix)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CIX");
                entity.Property(e => e.Nn001CodCcorrente).HasColumnName("NN001_COD_CCORRENTE");
                entity.Property(e => e.Nn001ContaCorrente).HasColumnName("NN001_CONTA_CORRENTE");
                entity.Property(e => e.Nn001Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("NN001_DESCRICAO");
                entity.Property(e => e.Nn001Dtaberturaconta)
                    .HasColumnType("datetime")
                    .HasColumnName("NN001_DTABERTURACONTA");
                entity.Property(e => e.Nn001Dv)
                    .HasMaxLength(2)
                    .HasColumnName("NN001_DV");
                entity.Property(e => e.Nn001Filial).HasColumnName("NN001_FILIAL");
                entity.Property(e => e.Nn001FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_FILIAL_ID");
                entity.Property(e => e.Nn001IsActive).HasColumnName("NN001_IS_ACTIVE");
                entity.Property(e => e.Nn001Ishabilitarpermis).HasColumnName("NN001_ISHABILITARPERMIS");
                entity.Property(e => e.Nn001LimiteCredito)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_LIMITE_CREDITO");
                entity.Property(e => e.Nn001NroBanco).HasColumnName("NN001_NRO_BANCO");
                entity.Property(e => e.Nn001Predatadoscred)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_PREDATADOSCRED");
                entity.Property(e => e.Nn001Predatadosdeb)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_PREDATADOSDEB");
                entity.Property(e => e.Nn001Predatadosdep)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_PREDATADOSDEP");
                entity.Property(e => e.Nn001SaldoAtual)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_SALDO_ATUAL");
                entity.Property(e => e.Nn001SaldoCompensado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN001_SALDO_COMPENSADO");
                entity.Property(e => e.Nn001Tpcontaid).HasColumnName("NN001_TPCONTAID");
                entity.Property(e => e.Nn001Usacix).HasColumnName("NN001_USACIX");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn001Tpconta).WithMany(p => p.OsusrE9aCsicpNn001s)
                    .HasForeignKey(d => d.Nn001Tpcontaid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN001_OSUSR_E9A_CSICP_NN001_TP_NN001_TPCONTAID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn001Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN001_TP");

                entity.ToTable("OSUSR_E9A_CSICP_NN001_TP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn002>(entity =>
            {
                entity.HasKey(e => e.Nn002GrupoId).HasName("OSPRK_OSUSR_E9A_CSICP_NN002");

                entity.ToTable("OSUSR_E9A_CSICP_NN002");

                entity.HasIndex(e => new { e.Nn002FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN002_15NN002_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn002TipogrupoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN002_18NN002_TIPOGRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN002_9TENANT_ID");

                entity.Property(e => e.Nn002GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN002_GRUPO_ID");
                entity.Property(e => e.Nn002CodGrupo).HasColumnName("NN002_COD_GRUPO");
                entity.Property(e => e.Nn002Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("NN002_DESCRICAO");
                entity.Property(e => e.Nn002FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN002_FILIAL_ID");
                entity.Property(e => e.Nn002Isactive).HasColumnName("NN002_ISACTIVE");
                entity.Property(e => e.Nn002TipogrupoId).HasColumnName("NN002_TIPOGRUPO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn002Tipogrupo).WithMany(p => p.OsusrE9aCsicpNn002s)
                    .HasForeignKey(d => d.Nn002TipogrupoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN002_OSUSR_E9A_CSICP_NN002_TPGRU_NN002_TIPOGRUPO_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn002Tpgru>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN002_TPGRU");

                entity.ToTable("OSUSR_E9A_CSICP_NN002_TPGRU");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn003>(entity =>
            {
                entity.HasKey(e => e.Nn003Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN003");

                entity.ToTable("OSUSR_E9A_CSICP_NN003");

                entity.HasIndex(e => new { e.Nn003GrupoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN003_14NN003_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn003FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN003_15NN003_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN003_9TENANT_ID");

                entity.Property(e => e.Nn003Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN003_ID");
                entity.Property(e => e.Nn003Ano).HasColumnName("NN003_ANO");
                entity.Property(e => e.Nn003Codggrupo).HasColumnName("NN003_CODGGRUPO");
                entity.Property(e => e.Nn003Filial).HasColumnName("NN003_FILIAL");
                entity.Property(e => e.Nn003FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN003_FILIAL_ID");
                entity.Property(e => e.Nn003GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN003_GRUPO_ID");
                entity.Property(e => e.Nn003Mes).HasColumnName("NN003_MES");
                entity.Property(e => e.Nn003VlrProvisaoRec)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN003_VLR_PROVISAO_REC");
                entity.Property(e => e.Nn003Vlrprovisaodesp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN003_VLRPROVISAODESP");
                entity.Property(e => e.Nn003Vlrrealizadodesp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN003_VLRREALIZADODESP");
                entity.Property(e => e.Nn003Vlrrealizadorec)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN003_VLRREALIZADOREC");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn003Grupo).WithMany(p => p.OsusrE9aCsicpNn003s)
                    .HasForeignKey(d => d.Nn003GrupoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN003_OSUSR_E9A_CSICP_NN002_NN003_GRUPO_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn004>(entity =>
            {
                entity.HasKey(e => e.Nn004ClasseId).HasName("OSPRK_OSUSR_E9A_CSICP_NN004");

                entity.ToTable("OSUSR_E9A_CSICP_NN004");

                entity.HasIndex(e => new { e.Nn004FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN004_15NN004_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN004_9TENANT_ID");

                entity.Property(e => e.Nn004ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("NN004_CLASSE_ID");
                entity.Property(e => e.Nn004CodClasse).HasColumnName("NN004_COD_CLASSE");
                entity.Property(e => e.Nn004Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("NN004_DESCRICAO");
                entity.Property(e => e.Nn004Filial).HasColumnName("NN004_FILIAL");
                entity.Property(e => e.Nn004FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN004_FILIAL_ID");
                entity.Property(e => e.Nn004Isactive).HasColumnName("NN004_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn005>(entity =>
            {
                entity.HasKey(e => e.Nn005Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN005");

                entity.ToTable("OSUSR_E9A_CSICP_NN005");

                entity.HasIndex(e => new { e.Nn005Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN005_15NN005_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001CtacorrenteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN005_20NN001_CTACORRENTE_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN005_9TENANT_ID");

                entity.Property(e => e.Nn005Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN005_ID");
                entity.Property(e => e.Nn001CtacorrenteId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CTACORRENTE_ID");
                entity.Property(e => e.Nn005Dinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("NN005_DINCLUSAO");
                entity.Property(e => e.Nn005Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN005_USUARIOID");
                entity.Property(e => e.Nn005Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("NN005_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn001Ctacorrente).WithMany(p => p.OsusrE9aCsicpNn005s)
                    .HasForeignKey(d => d.Nn001CtacorrenteId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN005_OSUSR_E9A_CSICP_NN001_NN001_CTACORRENTE_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn010>(entity =>
            {
                entity.HasKey(e => e.Nn010Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN010");

                entity.ToTable("OSUSR_E9A_CSICP_NN010");

                entity.HasIndex(e => new { e.Nn001GrupoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_14NN001_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001ClasseId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_15NN001_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010CcustoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_15NN010_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_15NN010_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010EstornoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_16NN010_ESTORNO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010TpmovtoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_16NN010_TPMOVTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010TplanctoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_17NN010_TPLANCTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001CtacorrenteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_20NN001_CTACORRENTE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001TransfCcorrId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_21NN001_TRANSF_CCORR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010CtbIsestornadoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_23NN010_CTB_ISESTORNADOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010CtbIscontabilizadoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010_27NN010_CTB_ISCONTABILIZADOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN010_9TENANT_ID");

                entity.Property(e => e.Nn010Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_ID");
                entity.Property(e => e.Nn001ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CLASSE_ID");
                entity.Property(e => e.Nn001CtacorrenteId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CTACORRENTE_ID");
                entity.Property(e => e.Nn001GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_GRUPO_ID");
                entity.Property(e => e.Nn001TransfCcorrId)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_TRANSF_CCORR_ID");
                entity.Property(e => e.Nn010BomPara)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_BOM_PARA");
                entity.Property(e => e.Nn010CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CCUSTO_ID");
                entity.Property(e => e.Nn010CiMovtoBaixa)
                    .HasMaxLength(50)
                    .HasColumnName("NN010_CI_MOVTO_BAIXA");
                entity.Property(e => e.Nn010CixAutenticador)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CIX_AUTENTICADOR");
                entity.Property(e => e.Nn010CodCc).HasColumnName("NN010_COD_CC");
                entity.Property(e => e.Nn010CodgClasse).HasColumnName("NN010_CODG_CLASSE");
                entity.Property(e => e.Nn010CodgGrupo).HasColumnName("NN010_CODG_GRUPO");
                entity.Property(e => e.Nn010Contadesttransf).HasColumnName("NN010_CONTADESTTRANSF");
                entity.Property(e => e.Nn010CtbDtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_CTB_DTREGISTRO");
                entity.Property(e => e.Nn010CtbEstdtreg)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_CTB_ESTDTREG");
                entity.Property(e => e.Nn010CtbEstusuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CTB_ESTUSUARIOID");
                entity.Property(e => e.Nn010CtbIdlancto).HasColumnName("NN010_CTB_IDLANCTO");
                entity.Property(e => e.Nn010CtbIscontabilizadoid).HasColumnName("NN010_CTB_ISCONTABILIZADOID");
                entity.Property(e => e.Nn010CtbIsestornadoid).HasColumnName("NN010_CTB_ISESTORNADOID");
                entity.Property(e => e.Nn010CtbMsg)
                    .HasMaxLength(100)
                    .HasColumnName("NN010_CTB_MSG");
                entity.Property(e => e.Nn010CtbUsuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CTB_USUARIOID");
                entity.Property(e => e.Nn010CtlDtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_CTL_DTREGISTRO");
                entity.Property(e => e.Nn010CtlEstdtreg)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_CTL_ESTDTREG");
                entity.Property(e => e.Nn010CtlEstusuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CTL_ESTUSUARIOID");
                entity.Property(e => e.Nn010CtlIdlancto).HasColumnName("NN010_CTL_IDLANCTO");
                entity.Property(e => e.Nn010CtlIscontabilizadoid).HasColumnName("NN010_CTL_ISCONTABILIZADOID");
                entity.Property(e => e.Nn010CtlIsestornadoid).HasColumnName("NN010_CTL_ISESTORNADOID");
                entity.Property(e => e.Nn010CtlMsg)
                    .HasMaxLength(100)
                    .HasColumnName("NN010_CTL_MSG");
                entity.Property(e => e.Nn010CtlUsuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_CTL_USUARIOID");
                entity.Property(e => e.Nn010DataCompensacao)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_DATA_COMPENSACAO");
                entity.Property(e => e.Nn010DataMovto)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_DATA_MOVTO");
                entity.Property(e => e.Nn010DataPesquisa)
                    .HasColumnType("datetime")
                    .HasColumnName("NN010_DATA_PESQUISA");
                entity.Property(e => e.Nn010Documento)
                    .HasMaxLength(30)
                    .HasColumnName("NN010_DOCUMENTO");
                entity.Property(e => e.Nn010EstornoId).HasColumnName("NN010_ESTORNO_ID");
                entity.Property(e => e.Nn010Favorecido)
                    .HasMaxLength(100)
                    .HasColumnName("NN010_FAVORECIDO");
                entity.Property(e => e.Nn010Filial).HasColumnName("NN010_FILIAL");
                entity.Property(e => e.Nn010FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_FILIAL_ID");
                entity.Property(e => e.Nn010Historico)
                    .HasMaxLength(250)
                    .HasColumnName("NN010_HISTORICO");
                entity.Property(e => e.Nn010Iscompensado).HasColumnName("NN010_ISCOMPENSADO");
                entity.Property(e => e.Nn010Isconciliado).HasColumnName("NN010_ISCONCILIADO");
                entity.Property(e => e.Nn010IspreDatado).HasColumnName("NN010_ISPRE_DATADO");
                entity.Property(e => e.Nn010NoLanctoTransf).HasColumnName("NN010_NO_LANCTO_TRANSF");
                entity.Property(e => e.Nn010NroCheque).HasColumnName("NN010_NRO_CHEQUE");
                entity.Property(e => e.Nn010Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN010_PROTOCOLNUMBER");
                entity.Property(e => e.Nn010TplanctoId).HasColumnName("NN010_TPLANCTO_ID");
                entity.Property(e => e.Nn010TpmovtoId).HasColumnName("NN010_TPMOVTO_ID");
                entity.Property(e => e.Nn010Valor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN010_VALOR");
                entity.Property(e => e.Nn010VlrMovtoAnterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN010_VLR_MOVTO_ANTERIOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn001Classe).WithMany(p => p.OsusrE9aCsicpNn010s)
                    .HasForeignKey(d => d.Nn001ClasseId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN004_NN001_CLASSE_ID");

                entity.HasOne(d => d.Nn001Ctacorrente).WithMany(p => p.OsusrE9aCsicpNn010Nn001Ctacorrentes)
                    .HasForeignKey(d => d.Nn001CtacorrenteId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN001_NN001_CTACORRENTE_ID");

                entity.HasOne(d => d.Nn001Grupo).WithMany(p => p.OsusrE9aCsicpNn010s)
                    .HasForeignKey(d => d.Nn001GrupoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN002_NN001_GRUPO_ID");

                entity.HasOne(d => d.Nn001TransfCcorr).WithMany(p => p.OsusrE9aCsicpNn010Nn001TransfCcorrs)
                    .HasForeignKey(d => d.Nn001TransfCcorrId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN001_NN001_TRANSF_CCORR_ID");

                entity.HasOne(d => d.Nn010Estorno).WithMany(p => p.OsusrE9aCsicpNn010s)
                    .HasForeignKey(d => d.Nn010EstornoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN010_EST_NN010_ESTORNO_ID");

                entity.HasOne(d => d.Nn010Tplancto).WithMany(p => p.OsusrE9aCsicpNn010s)
                    .HasForeignKey(d => d.Nn010TplanctoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN010_TPLAN_NN010_TPLANCTO_ID");

                entity.HasOne(d => d.Nn010Tpmovto).WithMany(p => p.OsusrE9aCsicpNn010s)
                    .HasForeignKey(d => d.Nn010TpmovtoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010_OSUSR_E9A_CSICP_NN010_TMOV_NN010_TPMOVTO_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn010Est>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN010_EST");

                entity.ToTable("OSUSR_E9A_CSICP_NN010_EST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn010Tmov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN010_TMOV");

                entity.ToTable("OSUSR_E9A_CSICP_NN010_TMOV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn010Tplan>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN010_TPLAN");

                entity.ToTable("OSUSR_E9A_CSICP_NN010_TPLAN");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn010o>(entity =>
            {
                entity.HasKey(e => e.Nn010oId).HasName("OSPRK_OSUSR_E9A_CSICP_NN010O");

                entity.ToTable("OSUSR_E9A_CSICP_NN010O");

                entity.HasIndex(e => new { e.Nn010oTipoarq, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010O_14NN010O_TIPOARQ_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn010Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN010O_8NN010_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN010O_9TENANT_ID");

                entity.Property(e => e.Nn010oId)
                    .HasMaxLength(36)
                    .HasColumnName("NN010O_ID");
                entity.Property(e => e.Nn010Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_ID");
                entity.Property(e => e.Nn010oContent).HasColumnName("NN010O_CONTENT");
                entity.Property(e => e.Nn010oDescricao)
                    .HasMaxLength(120)
                    .HasColumnName("NN010O_DESCRICAO");
                entity.Property(e => e.Nn010oFilename)
                    .HasMaxLength(250)
                    .HasColumnName("NN010O_FILENAME");
                entity.Property(e => e.Nn010oFiletype)
                    .HasMaxLength(500)
                    .HasColumnName("NN010O_FILETYPE");
                entity.Property(e => e.Nn010oIsActive).HasColumnName("NN010O_IS_ACTIVE");
                entity.Property(e => e.Nn010oPath)
                    .HasMaxLength(500)
                    .HasColumnName("NN010O_PATH");
                entity.Property(e => e.Nn010oTipoarq).HasColumnName("NN010O_TIPOARQ");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn010).WithMany(p => p.OsusrE9aCsicpNn010os)
                    .HasForeignKey(d => d.Nn010Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN010O_OSUSR_E9A_CSICP_NN010_NN010_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn011>(entity =>
            {
                entity.HasKey(e => e.Nn011Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN011");

                entity.ToTable("OSUSR_E9A_CSICP_NN011");

                entity.HasIndex(e => new { e.Nn011FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN011_15NN011_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn011CtacorrenteId, e.Nn011Data, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN011_20NN011_CTACORRENTE_ID_10NN011_DATA_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn011CtacorrenteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN011_20NN011_CTACORRENTE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn011PkSldanteriorId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN011_23NN011_PK_SLDANTERIOR_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN011_9TENANT_ID");

                entity.Property(e => e.Nn011Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN011_ID");
                entity.Property(e => e.Nn011CodCc).HasColumnName("NN011_COD_CC");
                entity.Property(e => e.Nn011CodgFilial).HasColumnName("NN011_CODG_FILIAL");
                entity.Property(e => e.Nn011CtacorrenteId)
                    .HasMaxLength(36)
                    .HasColumnName("NN011_CTACORRENTE_ID");
                entity.Property(e => e.Nn011Data)
                    .HasColumnType("datetime")
                    .HasColumnName("NN011_DATA");
                entity.Property(e => e.Nn011FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN011_FILIAL_ID");
                entity.Property(e => e.Nn011Isfechado).HasColumnName("NN011_ISFECHADO");
                entity.Property(e => e.Nn011PkSldanteriorId)
                    .HasMaxLength(36)
                    .HasColumnName("NN011_PK_SLDANTERIOR_ID");
                entity.Property(e => e.Nn011SaldoAnterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_SALDO_ANTERIOR");
                entity.Property(e => e.Nn011SaldoDoDia)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_SALDO_DO_DIA");
                entity.Property(e => e.Nn011TotalCheques)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_TOTAL_CHEQUES");
                entity.Property(e => e.Nn011TotalDeposito)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_TOTAL_DEPOSITO");
                entity.Property(e => e.Nn011TotalEntradas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_TOTAL_ENTRADAS");
                entity.Property(e => e.Nn011TotalSaidas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN011_TOTAL_SAIDAS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn011Ctacorrente).WithMany(p => p.OsusrE9aCsicpNn011s)
                    .HasForeignKey(d => d.Nn011CtacorrenteId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN011_OSUSR_E9A_CSICP_NN001_NN011_CTACORRENTE_ID");

                entity.HasOne(d => d.Nn011PkSldanterior).WithMany(p => p.InverseNn011PkSldanterior)
                    .HasForeignKey(d => d.Nn011PkSldanteriorId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN011_OSUSR_E9A_CSICP_NN011_NN011_PK_SLDANTERIOR_ID");
            });

            modelBuilder.Entity<CSICP_NN015>(entity =>
            {
                entity.HasKey(e => e.Nn015CrcpId).HasName("OSPRK_OSUSR_E9A_CSICP_NN015");

                entity.ToTable("OSUSR_E9A_CSICP_NN015");

                entity.HasIndex(e => new { e.Nn015Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_12NN015_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015ContaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_14NN015_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015GrupoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_14NN015_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015CcustoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_15NN015_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015ClasseId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_15NN015_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_15NN015_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015TipoMovtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_18NN015_TIPO_MOVTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015AgcobradorId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_19NN015_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015CtacorrenteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_20NN015_CTACORRENTE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015UsuariopropId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN015_20NN015_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN015_9TENANT_ID");

                entity.Property(e => e.Nn015CrcpId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_CRCP_ID");
                entity.Property(e => e.Nn015AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_AGCOBRADOR_ID");
                entity.Property(e => e.Nn015Agencia)
                    .HasMaxLength(10)
                    .HasColumnName("NN015_AGENCIA");
                entity.Property(e => e.Nn015Banco).HasColumnName("NN015_BANCO");
                entity.Property(e => e.Nn015BomPara)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_BOM_PARA");
                entity.Property(e => e.Nn015CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_CCUSTO_ID");
                entity.Property(e => e.Nn015Ciorigemestorno)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("NN015_CIORIGEMESTORNO");
                entity.Property(e => e.Nn015ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_CLASSE_ID");
                entity.Property(e => e.Nn015Clientefornec).HasColumnName("NN015_CLIENTEFORNEC");
                entity.Property(e => e.Nn015CodgCcorrente).HasColumnName("NN015_CODG_CCORRENTE");
                entity.Property(e => e.Nn015ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_CONTA_ID");
                entity.Property(e => e.Nn015CtacorrenteId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_CTACORRENTE_ID");
                entity.Property(e => e.Nn015DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_DATA_MOVIMENTO");
                entity.Property(e => e.Nn015Dbaixatit)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_DBAIXATIT");
                entity.Property(e => e.Nn015Dcreditotit)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_DCREDITOTIT");
                entity.Property(e => e.Nn015Documento)
                    .HasMaxLength(20)
                    .HasColumnName("NN015_DOCUMENTO");
                entity.Property(e => e.Nn015Favorecido)
                    .HasMaxLength(150)
                    .HasColumnName("NN015_FAVORECIDO");
                entity.Property(e => e.Nn015Filial).HasColumnName("NN015_FILIAL");
                entity.Property(e => e.Nn015FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_FILIAL_ID");
                entity.Property(e => e.Nn015GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_GRUPO_ID");
                entity.Property(e => e.Nn015Historico)
                    .HasMaxLength(150)
                    .HasColumnName("NN015_HISTORICO");
                entity.Property(e => e.Nn015Ischeque).HasColumnName("NN015_ISCHEQUE");
                entity.Property(e => e.Nn015Isestorno).HasColumnName("NN015_ISESTORNO");
                entity.Property(e => e.Nn015NoCheque).HasColumnName("NN015_NO_CHEQUE");
                entity.Property(e => e.Nn015Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN015_PROTOCOLNUMBER");
                entity.Property(e => e.Nn015Status).HasColumnName("NN015_STATUS");
                entity.Property(e => e.Nn015TaxaAntecipacao)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("NN015_TAXA_ANTECIPACAO");
                entity.Property(e => e.Nn015Tcorrmonetaria)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TCORRMONETARIA");
                entity.Property(e => e.Nn015Thonorarios)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_THONORARIOS");
                entity.Property(e => e.Nn015TipoMovtoid).HasColumnName("NN015_TIPO_MOVTOID");
                entity.Property(e => e.Nn015Tipomovimento).HasColumnName("NN015_TIPOMOVIMENTO");
                entity.Property(e => e.Nn015TotalDescontos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_DESCONTOS");
                entity.Property(e => e.Nn015TotalJuros)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_JUROS");
                entity.Property(e => e.Nn015TotalMulta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_MULTA");
                entity.Property(e => e.Nn015TotalPago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_PAGO");
                entity.Property(e => e.Nn015TotalTaxa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_TAXA");
                entity.Property(e => e.Nn015TotalTitulo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTAL_TITULO");
                entity.Property(e => e.Nn015TotaljurosCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTALJUROS_CALC");
                entity.Property(e => e.Nn015TotalmultaCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTALMULTA_CALC");
                entity.Property(e => e.Nn015TotaltaxaCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_TOTALTAXA_CALC");
                entity.Property(e => e.Nn015UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_USUARIOPROP_ID");
                entity.Property(e => e.Nn015ValorTxAntcartao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN015_VALOR_TX_ANTCARTAO");
                entity.Property(e => e.Nn015Venctofinal)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_VENCTOFINAL");
                entity.Property(e => e.Nn015Venctoinicial)
                    .HasColumnType("datetime")
                    .HasColumnName("NN015_VENCTOINICIAL");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

             
            });

            modelBuilder.Entity<OsusrE9aCsicpNn015Rp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN015_RP");

                entity.ToTable("OSUSR_E9A_CSICP_NN015_RP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn015Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN015_STA");

                entity.ToTable("OSUSR_E9A_CSICP_NN015_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn016>(entity =>
            {
                entity.HasKey(e => e.Nn016Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN016");

                entity.ToTable("OSUSR_E9A_CSICP_NN016");

                entity.HasIndex(e => new { e.Nn016CrcpId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN016_13NN016_CRCP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn016TituloId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN016_15NN016_TITULO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn016SituacaotitId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN016_20NN016_SITUACAOTIT_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN016_9TENANT_ID");

                entity.Property(e => e.Nn016Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN016_ID");
                entity.Property(e => e.Nn016BaixarSn).HasColumnName("NN016_BAIXAR_SN");
                entity.Property(e => e.Nn016CliFor).HasColumnName("NN016_CLI_FOR");
                entity.Property(e => e.Nn016CrcpId)
                    .HasMaxLength(36)
                    .HasColumnName("NN016_CRCP_ID");
                entity.Property(e => e.Nn016DataVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("NN016_DATA_VENCIMENTO");
                entity.Property(e => e.Nn016Diasatraso).HasColumnName("NN016_DIASATRASO");
                entity.Property(e => e.Nn016Filial).HasColumnName("NN016_FILIAL");
                entity.Property(e => e.Nn016FilialBaixa).HasColumnName("NN016_FILIAL_BAIXA");
                entity.Property(e => e.Nn016Historico)
                    .HasMaxLength(250)
                    .HasColumnName("NN016_HISTORICO");
                entity.Property(e => e.Nn016IdEstorno)
                    .HasMaxLength(36)
                    .HasColumnName("NN016_ID_ESTORNO");
                entity.Property(e => e.Nn016Mensagem)
                    .HasMaxLength(50)
                    .HasColumnName("NN016_MENSAGEM");
                entity.Property(e => e.Nn016Prefixo)
                    .HasMaxLength(3)
                    .HasColumnName("NN016_PREFIXO");
                entity.Property(e => e.Nn016Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN016_PROTOCOLNUMBER");
                entity.Property(e => e.Nn016SequenciaBaixa).HasColumnName("NN016_SEQUENCIA_BAIXA");
                entity.Property(e => e.Nn016Sfx)
                    .HasMaxLength(2)
                    .HasColumnName("NN016_SFX");
                entity.Property(e => e.Nn016SituacaotitId).HasColumnName("NN016_SITUACAOTIT_ID");
                entity.Property(e => e.Nn016TaxaAntecipacao)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("NN016_TAXA_ANTECIPACAO");
                entity.Property(e => e.Nn016TipoMovimento).HasColumnName("NN016_TIPO_MOVIMENTO");
                entity.Property(e => e.Nn016Titulo)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("NN016_TITULO");
                entity.Property(e => e.Nn016TituloId)
                    .HasMaxLength(36)
                    .HasColumnName("NN016_TITULO_ID");
                entity.Property(e => e.Nn016TotalApagar)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_TOTAL_APAGAR");
                entity.Property(e => e.Nn016ValorDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_DESCONTO");
                entity.Property(e => e.Nn016ValorJuros)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_JUROS");
                entity.Property(e => e.Nn016ValorJurosCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_JUROS_CALC");
                entity.Property(e => e.Nn016ValorMulta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_MULTA");
                entity.Property(e => e.Nn016ValorMultaCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_MULTA_CALC");
                entity.Property(e => e.Nn016ValorPago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_PAGO");
                entity.Property(e => e.Nn016ValorTaxa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_TAXA");
                entity.Property(e => e.Nn016ValorTaxaCalc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_TAXA_CALC");
                entity.Property(e => e.Nn016ValorTxAntcartao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VALOR_TX_ANTCARTAO");
                entity.Property(e => e.Nn016Vcorrmonetaria)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VCORRMONETARIA");
                entity.Property(e => e.Nn016Vhonorarios)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VHONORARIOS");
                entity.Property(e => e.Nn016Vlrabertotitulos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN016_VLRABERTOTITULOS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            
            });

            modelBuilder.Entity<OsusrE9aCsicpNn017>(entity =>
            {
                entity.HasKey(e => e.Nn017Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN017");

                entity.ToTable("OSUSR_E9A_CSICP_NN017");

                entity.HasIndex(e => new { e.Nn017CrcpId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN017_13NN017_CRCP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn017AgcobradorId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN017_19NN017_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN017_9TENANT_ID");

                entity.Property(e => e.Nn017Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN017_ID");
                entity.Property(e => e.Nn017AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("NN017_AGCOBRADOR_ID");
                entity.Property(e => e.Nn017Agencia)
                    .HasMaxLength(10)
                    .HasColumnName("NN017_AGENCIA");
                entity.Property(e => e.Nn017CrcpId)
                    .HasMaxLength(36)
                    .HasColumnName("NN017_CRCP_ID");
                entity.Property(e => e.Nn017Data)
                    .HasColumnType("datetime")
                    .HasColumnName("NN017_DATA");
                entity.Property(e => e.Nn017Documento)
                    .HasMaxLength(20)
                    .HasColumnName("NN017_DOCUMENTO");
                entity.Property(e => e.Nn017Filial).HasColumnName("NN017_FILIAL");
                entity.Property(e => e.Nn017Historico)
                    .HasMaxLength(250)
                    .HasColumnName("NN017_HISTORICO");
                entity.Property(e => e.Nn017NoCheque).HasColumnName("NN017_NO_CHEQUE");
                entity.Property(e => e.Nn017Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN017_PROTOCOLNUMBER");
                entity.Property(e => e.Nn017Seq).HasColumnName("NN017_SEQ");
                entity.Property(e => e.Nn017TipomovimentoId).HasColumnName("NN017_TIPOMOVIMENTO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

             
            });

            modelBuilder.Entity<OsusrE9aCsicpNn018>(entity =>
            {
                entity.HasKey(e => e.Nn018Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN018");

                entity.ToTable("OSUSR_E9A_CSICP_NN018");

                entity.HasIndex(e => new { e.Nn010Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN018_8NN010_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn015Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN018_8NN015_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN018_9TENANT_ID");

                entity.Property(e => e.Nn018Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN018_ID");
                entity.Property(e => e.Nn010Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_ID");
                entity.Property(e => e.Nn010Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN010_PROTOCOLNUMBER");
                entity.Property(e => e.Nn010TransfId)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_TRANSF_ID");
                entity.Property(e => e.Nn015Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_ID");
                entity.Property(e => e.Nn015Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN015_PROTOCOLNUMBER");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn010).WithMany(p => p.OsusrE9aCsicpNn018s)
                    .HasForeignKey(d => d.Nn010Id)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN018_OSUSR_E9A_CSICP_NN010_NN010_ID");

             
            });

            modelBuilder.Entity<OsusrE9aCsicpNn019>(entity =>
            {
                entity.HasKey(e => e.Nn019Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN019");

                entity.ToTable("OSUSR_E9A_CSICP_NN019");

                entity.HasIndex(e => new { e.Nn015EstornoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN019_16NN015_ESTORNO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN019_9TENANT_ID");

                entity.Property(e => e.Nn019Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN019_ID");
                entity.Property(e => e.Nn015BaixaCrcpId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_BAIXA_CRCP_ID");
                entity.Property(e => e.Nn015EstornoId)
                    .HasMaxLength(36)
                    .HasColumnName("NN015_ESTORNO_ID");
                entity.Property(e => e.Nn015PnEstorno)
                    .HasMaxLength(20)
                    .HasColumnName("NN015_PN_ESTORNO");
                entity.Property(e => e.Nn015Protocolnumber).HasColumnName("NN015_PROTOCOLNUMBER");
                entity.Property(e => e.Nn015Protocoloestorno)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("NN015_PROTOCOLOESTORNO");
                entity.Property(e => e.Nn015Protocolonumber)
                    .HasMaxLength(20)
                    .HasColumnName("NN015_PROTOCOLONUMBER");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

               
            });

            modelBuilder.Entity<OsusrE9aCsicpNn020>(entity =>
            {
                entity.HasKey(e => e.Nn020Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN020");

                entity.ToTable("OSUSR_E9A_CSICP_NN020");

                entity.HasIndex(e => new { e.Nn020Statusid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN020_14NN020_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn020Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN020_15NN020_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn001Ctacorrenteid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN020_19NN001_CTACORRENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn020Usuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN020_19NN020_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN020_9TENANT_ID");

                entity.Property(e => e.Nn020Id).HasColumnName("NN020_ID");
                entity.Property(e => e.Nn001Ctacorrenteid)
                    .HasMaxLength(36)
                    .HasColumnName("NN001_CTACORRENTEID");
                entity.Property(e => e.Nn020Acctid)
                    .HasMaxLength(20)
                    .HasColumnName("NN020_ACCTID");
                entity.Property(e => e.Nn020Balamt)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN020_BALAMT");
                entity.Property(e => e.Nn020Bankid)
                    .HasMaxLength(20)
                    .HasColumnName("NN020_BANKID");
                entity.Property(e => e.Nn020Dataupload)
                    .HasColumnType("datetime")
                    .HasColumnName("NN020_DATAUPLOAD");
                entity.Property(e => e.Nn020Dtend)
                    .HasColumnType("datetime")
                    .HasColumnName("NN020_DTEND");
                entity.Property(e => e.Nn020Dtfinalprop)
                    .HasColumnType("datetime")
                    .HasColumnName("NN020_DTFINALPROP");
                entity.Property(e => e.Nn020Dtinicioprop)
                    .HasColumnType("datetime")
                    .HasColumnName("NN020_DTINICIOPROP");
                entity.Property(e => e.Nn020Dtstart)
                    .HasColumnType("datetime")
                    .HasColumnName("NN020_DTSTART");
                entity.Property(e => e.Nn020Statusid).HasColumnName("NN020_STATUSID");
                entity.Property(e => e.Nn020Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("NN020_USUARIOID");
                entity.Property(e => e.Nn020Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("NN020_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn001Ctacorrente).WithMany(p => p.OsusrE9aCsicpNn020s)
                    .HasForeignKey(d => d.Nn001Ctacorrenteid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN020_OSUSR_E9A_CSICP_NN001_NN001_CTACORRENTEID");

                entity.HasOne(d => d.Nn020Status).WithMany(p => p.OsusrE9aCsicpNn020s)
                    .HasForeignKey(d => d.Nn020Statusid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN020_OSUSR_E9A_CSICP_NN020_STAT_NN020_STATUSID");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn020Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN020_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_NN020_STAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpNn021>(entity =>
            {
                entity.HasKey(e => e.Nn021Id).HasName("OSPRK_OSUSR_E9A_CSICP_NN021");

                entity.ToTable("OSUSR_E9A_CSICP_NN021");

                entity.HasIndex(e => new { e.Nn010Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN021_8NN010_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Nn020Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_NN021_8NN020_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_NN021_9TENANT_ID");

                entity.Property(e => e.Nn021Id).HasColumnName("NN021_ID");
                entity.Property(e => e.Nn010Id)
                    .HasMaxLength(36)
                    .HasColumnName("NN010_ID");
                entity.Property(e => e.Nn020Id).HasColumnName("NN020_ID");
                entity.Property(e => e.Nn021Checknum)
                    .HasMaxLength(20)
                    .HasColumnName("NN021_CHECKNUM");
                entity.Property(e => e.Nn021Dpostagem)
                    .HasColumnType("datetime")
                    .HasColumnName("NN021_DPOSTAGEM");
                entity.Property(e => e.Nn021Dtposted)
                    .HasMaxLength(30)
                    .HasColumnName("NN021_DTPOSTED");
                entity.Property(e => e.Nn021Fitid)
                    .HasMaxLength(50)
                    .HasColumnName("NN021_FITID");
                entity.Property(e => e.Nn021Isrepetido).HasColumnName("NN021_ISREPETIDO");
                entity.Property(e => e.Nn021Memo)
                    .HasMaxLength(250)
                    .HasColumnName("NN021_MEMO");
                entity.Property(e => e.Nn021Trnamt)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("NN021_TRNAMT");
                entity.Property(e => e.Nn021Trntype)
                    .HasMaxLength(20)
                    .HasColumnName("NN021_TRNTYPE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Nn010).WithMany(p => p.OsusrE9aCsicpNn021s)
                    .HasForeignKey(d => d.Nn010Id)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN021_OSUSR_E9A_CSICP_NN010_NN010_ID");

                entity.HasOne(d => d.Nn020).WithMany(p => p.OsusrE9aCsicpNn021s)
                    .HasForeignKey(d => d.Nn020Id)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_NN021_OSUSR_E9A_CSICP_NN020_NN020_ID");
            });
            modelBuilder.HasSequence("Seq_PK_ID");

        }
    }
}
