using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD131> OsusrTeiCsicpDd131s { get; set; }

        public virtual DbSet<CSICP_DD131Tpmovto> OsusrTeiCsicpDd131Tpmovtos { get; set; }

        public virtual DbSet<CSICP_DD132> OsusrTeiCsicpDd132s { get; set; }

        public virtual DbSet<CSICP_DD132Controle> OsusrTeiCsicpDd132Controles { get; set; }

        public virtual DbSet<CSICP_DD132Status> OsusrTeiCsicpDd132Statuses { get; set; }

        public virtual DbSet<CSICP_DD133> OsusrTeiCsicpDd133s { get; set; }

        public virtual DbSet<CSICP_DD134> OsusrTeiCsicpDd134s { get; set; }

        public virtual DbSet<CSICP_DD135> OsusrTeiCsicpDd135s { get; set; }

        public virtual DbSet<CSICP_DD136> OsusrTeiCsicpDd136s { get; set; }

        public virtual DbSet<CSICP_DD136Tp> OsusrTeiCsicpDd136Tps { get; set; }

        public virtual DbSet<CSICP_DD137> OsusrTeiCsicpDd137s { get; set; }

        public virtual DbSet<CSICP_DD137St> OsusrTeiCsicpDd137Sts { get; set; }

        public virtual DbSet<CSICP_DD138> OsusrTeiCsicpDd138s { get; set; }

        public virtual DbSet<CSICP_DD140> OsusrTeiCsicpDd140s { get; set; }

        public virtual DbSet<CSICP_DD140Mcb> OsusrTeiCsicpDd140Mcbs { get; set; }

        public virtual DbSet<CSICP_DD141> OsusrTeiCsicpDd141s { get; set; }

        public virtual DbSet<CSICP_DD142> OsusrTeiCsicpDd142s { get; set; }

        public virtual DbSet<CSICP_DD143Stum> OsusrTeiCsicpDd143Sta { get; set; }

        partial void OnModelCreating_CSICP_DD_130_140(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD131>(entity =>
            {
                entity.HasKey(e => e.Dd131Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD131");

                entity.ToTable("OSUSR_TEI_CSICP_DD131");

                entity.HasIndex(e => new { e.Dd131Datahora, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD131_14DD131_DATAHORA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd131TpMovto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD131_14DD131_TP_MOVTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd131FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD131_15DD131_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Ff103Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD131_8FF103_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD131_9TENANT_ID");

                entity.Property(e => e.Dd131Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD131_ID");
                entity.Property(e => e.Dd131Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD131_DATAHORA");
                entity.Property(e => e.Dd131FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD131_FILIAL_ID");
                entity.Property(e => e.Dd131Status)
                    .HasMaxLength(1)
                    .HasColumnName("DD131_STATUS");
                entity.Property(e => e.Dd131TpMovto).HasColumnName("DD131_TP_MOVTO");
                entity.Property(e => e.Ff103Id)
                    .HasMaxLength(36)
                    .HasColumnName("FF103_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD131Tpmovto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD131_TPMOVTO");

                entity.ToTable("OSUSR_TEI_CSICP_DD131_TPMOVTO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD132>(entity =>
            {
                entity.HasKey(e => e.Dd132Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD132");

                entity.ToTable("OSUSR_TEI_CSICP_DD132");

                entity.HasIndex(e => new { e.Dd132Status, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_12DD132_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_14DD132_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132TipoMovto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_16DD132_TIPO_MOVTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132UsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_16DD132_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132MontadorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_17DD132_MONTADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132ArquitetoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_18DD132_ARQUITETO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132Tpcomissaoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_18DD132_TPCOMISSAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd132ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_20DD132_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd042Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8DD042_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd136Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8DD136_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd150Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8DD150_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Ff103Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_8FF103_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD132_9TENANT_ID");

                entity.Property(e => e.Dd132Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd042Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ID");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd132ArquitetoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_ARQUITETO_ID");
                entity.Property(e => e.Dd132DataCalculo)
                    .HasColumnType("datetime")
                    .HasColumnName("DD132_DATA_CALCULO");
                entity.Property(e => e.Dd132EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_ESTAB_ID");
                entity.Property(e => e.Dd132IdPai)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_ID_PAI");
                entity.Property(e => e.Dd132Ispagarcomissao).HasColumnName("DD132_ISPAGARCOMISSAO");
                entity.Property(e => e.Dd132MontadorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_MONTADOR_ID");
                entity.Property(e => e.Dd132PercComissao)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD132_PERC_COMISSAO");
                entity.Property(e => e.Dd132ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_RESPONSAVEL_ID");
                entity.Property(e => e.Dd132SeqBaixa).HasColumnName("DD132_SEQ_BAIXA");
                entity.Property(e => e.Dd132Sequencia).HasColumnName("DD132_SEQUENCIA");
                entity.Property(e => e.Dd132Status).HasColumnName("DD132_STATUS");
                entity.Property(e => e.Dd132TipoMovto).HasColumnName("DD132_TIPO_MOVTO");
                entity.Property(e => e.Dd132Tpcomissaoid).HasColumnName("DD132_TPCOMISSAOID");
                entity.Property(e => e.Dd132UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD132_USUARIO_ID");
                entity.Property(e => e.Dd132ValorBaixa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD132_VALOR_BAIXA");
                entity.Property(e => e.Dd132ValorComissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD132_VALOR_COMISSAO");
                entity.Property(e => e.Dd132ValorComissaoUnit)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD132_VALOR_COMISSAO_UNIT");
                entity.Property(e => e.Dd132Vbasecomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD132_VBASECOMISSAO");
                entity.Property(e => e.Dd136Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD136_ID");
                entity.Property(e => e.Dd150Id).HasColumnName("DD150_ID");
                entity.Property(e => e.Ff103Id)
                    .HasMaxLength(36)
                    .HasColumnName("FF103_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD132Controle>(entity =>
            {
                entity.HasKey(e => e.Dd132CtrId).HasName("OSPRK_OSUSR_TEI_CSICP_DD132_CONTROLE");

                entity.ToTable("OSUSR_TEI_CSICP_DD132_CONTROLE");

                entity.HasIndex(e => new { e.Dd132CtrStatus, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD132_CONTROLE_16DD132_CTR_STATUS_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD132_CONTROLE_9TENANT_ID");

                entity.Property(e => e.Dd132CtrId).HasColumnName("DD132_CTR_ID");
                entity.Property(e => e.Dd132CtrAno).HasColumnName("DD132_CTR_ANO");
                entity.Property(e => e.Dd132CtrDataCalculo)
                    .HasColumnType("datetime")
                    .HasColumnName("DD132_CTR_DATA_CALCULO");
                entity.Property(e => e.Dd132CtrMes).HasColumnName("DD132_CTR_MES");
                entity.Property(e => e.Dd132CtrStatus).HasColumnName("DD132_CTR_STATUS");
                entity.Property(e => e.Dd132HoraFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DD132_HORA_FINAL");
                entity.Property(e => e.Dd132HoraInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DD132_HORA_INICIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD132Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD132_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD132_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD133>(entity =>
            {
                entity.HasKey(e => e.Dd133Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD133");

                entity.ToTable("OSUSR_TEI_CSICP_DD133");

                entity.HasIndex(e => new { e.Dd133Loteid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_12DD133_LOTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd133UsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_16DD133_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd133MontadorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_17DD133_MONTADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd133ArquitetoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_18DD133_ARQUITETO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd133ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_20DD133_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd133EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_24DD133_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Ff102Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD133_8FF102_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD133_9TENANT_ID");

                entity.Property(e => e.Dd133Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_ID");
                entity.Property(e => e.Dd133AnomesRef)
                    .HasMaxLength(10)
                    .HasColumnName("DD133_ANOMES_REF");
                entity.Property(e => e.Dd133ArquitetoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_ARQUITETO_ID");
                entity.Property(e => e.Dd133DataRef)
                    .HasColumnType("datetime")
                    .HasColumnName("DD133_DATA_REF");
                entity.Property(e => e.Dd133DfinalComissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD133_DFINAL_COMISSAO");
                entity.Property(e => e.Dd133Dprocessamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD133_DPROCESSAMENTO");
                entity.Property(e => e.Dd133EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd133Loteid)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_LOTEID");
                entity.Property(e => e.Dd133MontadorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_MONTADOR_ID");
                entity.Property(e => e.Dd133Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD133_PROTOCOLNUMBER");
                entity.Property(e => e.Dd133ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_RESPONSAVEL_ID");
                entity.Property(e => e.Dd133UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD133_USUARIO_ID");
                entity.Property(e => e.Dd133Vcomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD133_VCOMISSAO");
                entity.Property(e => e.Dd133Vfaturamento)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD133_VFATURAMENTO");
                entity.Property(e => e.Ff102Id)
                    .HasMaxLength(36)
                    .HasColumnName("FF102_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD134>(entity =>
            {
                entity.HasKey(e => e.Dd134Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD134");

                entity.ToTable("OSUSR_TEI_CSICP_DD134");

                entity.HasIndex(e => new { e.Dd134EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD134_24DD134_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD134_9TENANT_ID");

                entity.Property(e => e.Dd134Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD134_ID");
                entity.Property(e => e.Dd134Descricao)
                    .HasMaxLength(150)
                    .HasColumnName("DD134_DESCRICAO");
                entity.Property(e => e.Dd134EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD134_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd134MargemFinal)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD134_MARGEM_FINAL");
                entity.Property(e => e.Dd134MargemInicial)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD134_MARGEM_INICIAL");
                entity.Property(e => e.Dd134PercComissao)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD134_PERC_COMISSAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD135>(entity =>
            {
                entity.HasKey(e => e.Dd135Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD135");

                entity.ToTable("OSUSR_TEI_CSICP_DD135");

                entity.HasIndex(e => new { e.Dd135GrupoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_14DD135_GRUPO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135MarcaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_14DD135_MARCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_15DD135_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135ClasseId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_15DD135_CLASSE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_16DD135_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135FormaPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_20DD135_FORMA_PAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd135ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_20DD135_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd134Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD135_8DD134_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD135_9TENANT_ID");

                entity.Property(e => e.Dd135Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_ID");
                entity.Property(e => e.Dd134Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD134_ID");
                entity.Property(e => e.Dd135CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_CCUSTO_ID");
                entity.Property(e => e.Dd135ClasseId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_CLASSE_ID");
                entity.Property(e => e.Dd135FormaPagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_FORMA_PAGTO_ID");
                entity.Property(e => e.Dd135GrupoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_GRUPO_ID");
                entity.Property(e => e.Dd135MarcaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_MARCA_ID");
                entity.Property(e => e.Dd135PercComissao)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DD135_PERC_COMISSAO");
                entity.Property(e => e.Dd135Prioridade).HasColumnName("DD135_PRIORIDADE");
                entity.Property(e => e.Dd135ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_PRODUTO_ID");
                entity.Property(e => e.Dd135ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD135_RESPONSAVEL_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD136>(entity =>
            {
                entity.HasKey(e => e.Dd136Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD136");

                entity.ToTable("OSUSR_TEI_CSICP_DD136");

                entity.HasIndex(e => new { e.Dd136Userpropid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD136_16DD136_USERPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd136Tpcomissaoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD136_18DD136_TPCOMISSAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd136EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD136_24DD136_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD136_9TENANT_ID");

                entity.Property(e => e.Dd136Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD136_ID");
                entity.Property(e => e.Dd136DataRef)
                    .HasColumnType("datetime")
                    .HasColumnName("DD136_DATA_REF");
                entity.Property(e => e.Dd136Descricao)
                    .HasMaxLength(150)
                    .HasColumnName("DD136_DESCRICAO");
                entity.Property(e => e.Dd136Dfimperiodo)
                    .HasColumnType("datetime")
                    .HasColumnName("DD136_DFIMPERIODO");
                entity.Property(e => e.Dd136Dinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD136_DINCLUSAO");
                entity.Property(e => e.Dd136Dinicioperiodo)
                    .HasColumnType("datetime")
                    .HasColumnName("DD136_DINICIOPERIODO");
                entity.Property(e => e.Dd136EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD136_ESTABELECIMENTO_ID");
                entity.Property(e => e.Dd136Isaberto).HasColumnName("DD136_ISABERTO");
                entity.Property(e => e.Dd136Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD136_PROTOCOLNUMBER");
                entity.Property(e => e.Dd136Tpcomissaoid).HasColumnName("DD136_TPCOMISSAOID");
                entity.Property(e => e.Dd136Userpropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD136_USERPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD136Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD136_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD136_TP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD137>(entity =>
            {
                entity.HasKey(e => e.Dd137Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD137");

                entity.ToTable("OSUSR_TEI_CSICP_DD137");

                entity.HasIndex(e => new { e.Dd137Contaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD137_13DD137_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd137Marcaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD137_13DD137_MARCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd137EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD137_14DD137_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd137Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD137_14DD137_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd137Usuariopropid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD137_19DD137_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD137_9TENANT_ID");

                entity.Property(e => e.Dd137Id).HasColumnName("DD137_ID");
                entity.Property(e => e.Dd137Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD137_CONTAID");
                entity.Property(e => e.Dd137Descricao).HasColumnName("DD137_DESCRICAO");
                entity.Property(e => e.Dd137Dfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DD137_DFINAL");
                entity.Property(e => e.Dd137Dinicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DD137_DINICIO");
                entity.Property(e => e.Dd137Dregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD137_DREGISTRO");
                entity.Property(e => e.Dd137EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD137_ESTAB_ID");
                entity.Property(e => e.Dd137Marcaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD137_MARCAID");
                entity.Property(e => e.Dd137Statusid).HasColumnName("DD137_STATUSID");
                entity.Property(e => e.Dd137Usuariopropid)
                    .HasMaxLength(36)
                    .HasColumnName("DD137_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD137St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD137_ST");

                entity.ToTable("OSUSR_TEI_CSICP_DD137_ST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD138>(entity =>
            {
                entity.HasKey(e => e.Dd13Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD138");

                entity.ToTable("OSUSR_TEI_CSICP_DD138");

                entity.HasIndex(e => new { e.Dd138Produtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD138_15DD138_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd137Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD138_8DD137_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD138_9TENANT_ID");

                entity.Property(e => e.Dd13Id).HasColumnName("DD13_ID");
                entity.Property(e => e.Dd137Id).HasColumnName("DD137_ID");
                entity.Property(e => e.Dd138Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD138_PRODUTOID");
                entity.Property(e => e.Dd138Vincentivo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD138_VINCENTIVO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD140>(entity =>
            {
                entity.HasKey(e => e.Dd140Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD140");

                entity.ToTable("OSUSR_TEI_CSICP_DD140");

                entity.HasIndex(e => new { e.Dd140Modalidadeid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD140_18DD140_MODALIDADEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD140_9TENANT_ID");

                entity.Property(e => e.Dd140Id).HasColumnName("DD140_ID");
                entity.Property(e => e.Dd140Dtfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DD140_DTFINAL");
                entity.Property(e => e.Dd140Dtinicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DD140_DTINICIO");
                entity.Property(e => e.Dd140Modalidadeid).HasColumnName("DD140_MODALIDADEID");
                entity.Property(e => e.Dd140Qdiasliberarcash).HasColumnName("DD140_QDIASLIBERARCASH");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD140Mcb>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD140_MCB");

                entity.ToTable("OSUSR_TEI_CSICP_DD140_MCB");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD141>(entity =>
            {
                entity.HasKey(e => e.Dd141Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD141");

                entity.ToTable("OSUSR_TEI_CSICP_DD141");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD141_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD141_9TENANT_ID");

                entity.Property(e => e.Dd141Id).HasColumnName("DD141_ID");
                entity.Property(e => e.Dd141Psvliquida)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD141_PSVLIQUIDA");
                entity.Property(e => e.Dd141Vunvendida)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD141_VUNVENDIDA");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD142>(entity =>
            {
                entity.HasKey(e => e.Dd142Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD142");

                entity.ToTable("OSUSR_TEI_CSICP_DD142");

                entity.HasIndex(e => new { e.Dd142Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_14DD142_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd142Dtregistro, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_16DD142_DTREGISTRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd142Cartacreditoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_20DD142_CARTACREDITOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd142HashCalculador, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_21DD142_HASH_CALCULADOR_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_8BB012_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD142_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD142_9TENANT_ID");

                entity.Property(e => e.Dd142Id).HasColumnName("DD142_ID");
                entity.Property(e => e.Bb012Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB012_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd142Cartacreditoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD142_CARTACREDITOID");
                entity.Property(e => e.Dd142Dhregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD142_DHREGISTRO");
                entity.Property(e => e.Dd142Dtliberacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD142_DTLIBERACAO");
                entity.Property(e => e.Dd142Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD142_DTREGISTRO");
                entity.Property(e => e.Dd142HashCalculador)
                    .HasMaxLength(36)
                    .HasColumnName("DD142_HASH_CALCULADOR");
                entity.Property(e => e.Dd142Statusid).HasColumnName("DD142_STATUSID");
                entity.Property(e => e.Dd142Vcashback)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD142_VCASHBACK");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD143Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD143_STA");

                entity.ToTable("OSUSR_TEI_CSICP_DD143_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });
        }
    }
}
