using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD100> OsusrTeiCsicpDd100s { get; set; }

        public virtual DbSet<CSICP_DD101> OsusrTeiCsicpDd101s { get; set; }

        public virtual DbSet<CSICP_DD101Flent> OsusrTeiCsicpDd101Flents { get; set; }

        public virtual DbSet<CSICP_DD101Stum> OsusrTeiCsicpDd101Sta { get; set; }

        public virtual DbSet<CSICP_DD102> OsusrTeiCsicpDd102s { get; set; }

        public virtual DbSet<CSICP_DD103> OsusrTeiCsicpDd103s { get; set; }

        public virtual DbSet<CSICP_DD104> OsusrTeiCsicpDd104s { get; set; }

        public virtual DbSet<CSICP_DD105> OsusrTeiCsicpDd105s { get; set; }

        public virtual DbSet<CSICP_DD106> OsusrTeiCsicpDd106s { get; set; }

        public virtual DbSet<CSICP_DD107> OsusrTeiCsicpDd107s { get; set; }

        public virtual DbSet<CSICP_DD110> OsusrTeiCsicpDd110s { get; set; }

        public virtual DbSet<CSICP_DD110Mdfe> OsusrTeiCsicpDd110Mdves { get; set; }

        public virtual DbSet<CSICP_DD110Mod> OsusrTeiCsicpDd110Mods { get; set; }

        public virtual DbSet<CSICP_DD110Status> OsusrTeiCsicpDd110Statuses { get; set; }

        public virtual DbSet<CSICP_DD111> OsusrTeiCsicpDd111s { get; set; }

        public virtual DbSet<CSICP_DD111Tde> OsusrTeiCsicpDd111Tdes { get; set; }

        public virtual DbSet<CSICP_DD113> OsusrTeiCsicpDd113s { get; set; }

        public virtual DbSet<CSICP_DD114> OsusrTeiCsicpDd114s { get; set; }

        public virtual DbSet<CSICP_DD115> OsusrTeiCsicpDd115s { get; set; }

        public virtual DbSet<CSICP_DD116> OsusrTeiCsicpDd116s { get; set; }

        public virtual DbSet<CSICP_DD117> OsusrTeiCsicpDd117s { get; set; }

        public virtual DbSet<CSICP_DD120> OsusrTeiCsicpDd120s { get; set; }

        public virtual DbSet<CSICP_DD120Pcartum> OsusrTeiCsicpDd120Pcarta { get; set; }

        public virtual DbSet<CSICP_DD120Status> OsusrTeiCsicpDd120Statuses { get; set; }

        public virtual DbSet<CSICP_DD120tp> OsusrTeiCsicpDd120tps { get; set; }

        public virtual DbSet<CSICP_DD121> OsusrTeiCsicpDd121s { get; set; }

        public virtual DbSet<CSICP_DD122> OsusrTeiCsicpDd122s { get; set; }

        public virtual DbSet<CSICP_DD122Tpde> OsusrTeiCsicpDd122Tpdes { get; set; }

        public virtual DbSet<CSICP_DD123> OsusrTeiCsicpDd123s { get; set; }

        public virtual DbSet<CSICP_DD124> OsusrTeiCsicpDd124s { get; set; }

        public virtual DbSet<CSICP_DD125> OsusrTeiCsicpDd125s { get; set; }

        public virtual DbSet<CSICP_DD125Status> OsusrTeiCsicpDd125Statuses { get; set; }

        public virtual DbSet<CSICP_DD125Tp> OsusrTeiCsicpDd125Tps { get; set; }

        public virtual DbSet<CSICP_DD126> OsusrTeiCsicpDd126s { get; set; }

        public virtual DbSet<CSICP_DD126Tmov> OsusrTeiCsicpDd126Tmovs { get; set; }

        public virtual DbSet<CSICP_DD127> OsusrTeiCsicpDd127s { get; set; }

        public virtual DbSet<CSICP_DD128> OsusrTeiCsicpDd128s { get; set; }

        public virtual DbSet<CSICP_DD129> OsusrTeiCsicpDd129s { get; set; }

        partial void OnModelCreating_CSICP_DD_100_120(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD100>(entity =>
            {
                entity.HasKey(e => e.Dd100Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD100");

                entity.ToTable("OSUSR_TEI_CSICP_DD100");

                entity.HasIndex(e => new { e.Dd100FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD100_15DD100_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd100VeiculoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD100_16DD100_VEICULO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD100_9TENANT_ID");

                entity.Property(e => e.Dd100Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD100_ID");
                entity.Property(e => e.Dd100EmailDiretor)
                    .HasMaxLength(250)
                    .HasColumnName("DD100_EMAIL_DIRETOR");
                entity.Property(e => e.Dd100EmailGerencia)
                    .HasMaxLength(250)
                    .HasColumnName("DD100_EMAIL_GERENCIA");
                entity.Property(e => e.Dd100FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD100_FILIAL_ID");
                entity.Property(e => e.Dd100MotoristaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD100_MOTORISTA_ID");
                entity.Property(e => e.Dd100PercIndiceMinimo)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD100_PERC_INDICE_MINIMO");
                entity.Property(e => e.Dd100Qdiasmax).HasColumnName("DD100_QDIASMAX");
                entity.Property(e => e.Dd100SmsDiretor)
                    .HasMaxLength(20)
                    .HasColumnName("DD100_SMS_DIRETOR");
                entity.Property(e => e.Dd100SmsGerencia)
                    .HasMaxLength(20)
                    .HasColumnName("DD100_SMS_GERENCIA");
                entity.Property(e => e.Dd100Tempomaxhoras)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("DD100_TEMPOMAXHORAS");
                entity.Property(e => e.Dd100ValorCargaInterno)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD100_VALOR_CARGA_INTERNO");
                entity.Property(e => e.Dd100VeiculoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD100_VEICULO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD101>(entity =>
            {
                entity.HasKey(e => e.Dd101EntregaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD101");

                entity.ToTable("OSUSR_TEI_CSICP_DD101");

                entity.HasIndex(e => new { e.Dd101Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_14DD101_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd101VendaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_14DD101_VENDA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd101Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_18DD101_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd101UsuarioproprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_21DD101_USUARIOPROPR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd107Identificadorid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_21DD107_IDENTIFICADORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd101SaldoEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD101_22DD101_SALDO_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD101_9TENANT_ID");

                entity.Property(e => e.Dd101EntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_ENTREGA_ID");
                entity.Property(e => e.Dd101ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_CONTA_ID");
                entity.Property(e => e.Dd101DataGerado)
                    .HasColumnType("datetime")
                    .HasColumnName("DD101_DATA_GERADO");
                entity.Property(e => e.Dd101Datafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DD101_DATAFINAL");
                entity.Property(e => e.Dd101Filialid)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_FILIALID");
                entity.Property(e => e.Dd101Isactive).HasColumnName("DD101_ISACTIVE");
                entity.Property(e => e.Dd101KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_KARDEX_ID");
                entity.Property(e => e.Dd101Modentregaid).HasColumnName("DD101_MODENTREGAID");
                entity.Property(e => e.Dd101Obs)
                    .HasMaxLength(500)
                    .HasColumnName("DD101_OBS");
                entity.Property(e => e.Dd101PercEntregue)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("DD101_PERC_ENTREGUE");
                entity.Property(e => e.Dd101Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD101_PROTOCOLNUMBER");
                entity.Property(e => e.Dd101QtdEntregue)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD101_QTD_ENTREGUE");
                entity.Property(e => e.Dd101QtdVenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD101_QTD_VENDA");
                entity.Property(e => e.Dd101SaldoEntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_SALDO_ENTREGA_ID");
                entity.Property(e => e.Dd101SaldoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_SALDO_ID");
                entity.Property(e => e.Dd101Statusid).HasColumnName("DD101_STATUSID");
                entity.Property(e => e.Dd101UsuarioproprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_USUARIOPROPR_ID");
                entity.Property(e => e.Dd101Valorvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD101_VALORVENDA");
                entity.Property(e => e.Dd101VendaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_VENDA_ID");
                entity.Property(e => e.Dd107Identificadorid).HasColumnName("DD107_IDENTIFICADORID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD101Flent>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD101_FLENT");

                entity.ToTable("OSUSR_TEI_CSICP_DD101_FLENT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD101_FLENT_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD101Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD101_STA");

                entity.ToTable("OSUSR_TEI_CSICP_DD101_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD102>(entity =>
            {
                entity.HasKey(e => e.Dd102ExecEntregaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD102");

                entity.ToTable("OSUSR_TEI_CSICP_DD102", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD102"));

                entity.HasIndex(e => new { e.Dd102Contaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD102_13DD102_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd102CargaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD102_14DD102_CARGA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd102EntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD102_16DD102_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd102FluxoentId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD102_17DD102_FLUXOENT_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD102_9TENANT_ID");

                entity.Property(e => e.Dd102ExecEntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD102_EXEC_ENTREGA_ID");
                entity.Property(e => e.Dd102CargaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD102_CARGA_ID");
                entity.Property(e => e.Dd102Checado).HasColumnName("DD102_CHECADO");
                entity.Property(e => e.Dd102Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD102_CONTAID");
                entity.Property(e => e.Dd102DataEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("DD102_DATA_ENTREGA");
                entity.Property(e => e.Dd102DthrUltsync)
                    .HasColumnType("datetime")
                    .HasColumnName("DD102_DTHR_ULTSYNC");
                entity.Property(e => e.Dd102EntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD102_ENTREGA_ID");
                entity.Property(e => e.Dd102FluxoentId).HasColumnName("DD102_FLUXOENT_ID");
                entity.Property(e => e.Dd102Isactive).HasColumnName("DD102_ISACTIVE");
                entity.Property(e => e.Dd102Issync).HasColumnName("DD102_ISSYNC");
                entity.Property(e => e.Dd102Latitude)
                    .HasMaxLength(30)
                    .HasColumnName("DD102_LATITUDE");
                entity.Property(e => e.Dd102Longitude)
                    .HasMaxLength(30)
                    .HasColumnName("DD102_LONGITUDE");
                entity.Property(e => e.Dd102Obs)
                    .HasMaxLength(500)
                    .HasColumnName("DD102_OBS");
                entity.Property(e => e.Dd102PesoBruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD102_PESO_BRUTO");
                entity.Property(e => e.Dd102PesoLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD102_PESO_LIQUIDO");
                entity.Property(e => e.Dd102Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD102_PROTOCOLNUMBER");
                entity.Property(e => e.Dd102QtdEntregar)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD102_QTD_ENTREGAR");
                entity.Property(e => e.Dd102Separado).HasColumnName("DD102_SEPARADO");
                entity.Property(e => e.Dd102Valorvenda)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD102_VALORVENDA");
                entity.Property(e => e.Dd102Volume).HasColumnName("DD102_VOLUME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD103>(entity =>
            {
                entity.HasKey(e => e.Dd103SeparacaoId).HasName("OSPRK_OSUSR_TEI_CSICP_DD103");

                entity.ToTable("OSUSR_TEI_CSICP_DD103");

                entity.HasIndex(e => new { e.Dd103ExecEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD103_21DD103_EXEC_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd103UsuarioproprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD103_21DD103_USUARIOPROPR_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD103_9TENANT_ID");

                entity.Property(e => e.Dd103SeparacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_SEPARACAO_ID");
                entity.Property(e => e.Dd103Cbarra)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("DD103_CBARRA");
                entity.Property(e => e.Dd103Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD103_CODBARRASALFA");
                entity.Property(e => e.Dd103DataSeparacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD103_DATA_SEPARACAO");
                entity.Property(e => e.Dd103ExecEntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_EXEC_ENTREGA_ID");
                entity.Property(e => e.Dd103Filialid)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_FILIALID");
                entity.Property(e => e.Dd103Isactive).HasColumnName("DD103_ISACTIVE");
                entity.Property(e => e.Dd103KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_KARDEX_ID");
                entity.Property(e => e.Dd103Obs)
                    .HasMaxLength(500)
                    .HasColumnName("DD103_OBS");
                entity.Property(e => e.Dd103PnExecent)
                    .HasMaxLength(20)
                    .HasColumnName("DD103_PN_EXECENT");
                entity.Property(e => e.Dd103Processado).HasColumnName("DD103_PROCESSADO");
                entity.Property(e => e.Dd103QtdSeparada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD103_QTD_SEPARADA");
                entity.Property(e => e.Dd103SeparadoKardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_SEPARADO_KARDEX_ID");
                entity.Property(e => e.Dd103UsuarioproprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD103_USUARIOPROPR_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD104>(entity =>
            {
                entity.HasKey(e => e.Dd104ConferenciaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD104");

                entity.ToTable("OSUSR_TEI_CSICP_DD104");

                entity.HasIndex(e => new { e.Dd104KardexId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD104_15DD104_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd104ExecEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD104_21DD104_EXEC_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD104_9TENANT_ID");

                entity.Property(e => e.Dd104ConferenciaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD104_CONFERENCIA_ID");
                entity.Property(e => e.Dd104Cbarra)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("DD104_CBARRA");
                entity.Property(e => e.Dd104Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD104_CODBARRASALFA");
                entity.Property(e => e.Dd104Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DD104_DATA");
                entity.Property(e => e.Dd104ExecEntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD104_EXEC_ENTREGA_ID");
                entity.Property(e => e.Dd104FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD104_FILIAL_ID");
                entity.Property(e => e.Dd104Isactive).HasColumnName("DD104_ISACTIVE");
                entity.Property(e => e.Dd104KardexId)
                    .HasMaxLength(36)
                    .HasColumnName("DD104_KARDEX_ID");
                entity.Property(e => e.Dd104PnExecent)
                    .HasMaxLength(20)
                    .HasColumnName("DD104_PN_EXECENT");
                entity.Property(e => e.Dd104Processado).HasColumnName("DD104_PROCESSADO");
                entity.Property(e => e.Dd104Qtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD104_QTD");
                entity.Property(e => e.Dd104UsuarioproprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD104_USUARIOPROPR_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD105>(entity =>
            {
                entity.HasKey(e => e.Dd105OcorrenciaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD105");

                entity.ToTable("OSUSR_TEI_CSICP_DD105");

                entity.HasIndex(e => new { e.Dd105Chvmobile, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD105_15DD105_CHVMOBILE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd105MotivoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD105_15DD105_MOTIVO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd105ExecEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD105_21DD105_EXEC_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD105_9TENANT_ID");

                entity.Property(e => e.Dd105OcorrenciaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_OCORRENCIA_ID");
                entity.Property(e => e.Dd105CargaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_CARGA_ID");
                entity.Property(e => e.Dd105Chvmobile)
                    .HasMaxLength(50)
                    .HasColumnName("DD105_CHVMOBILE");
                entity.Property(e => e.Dd105Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DD105_DATA");
                entity.Property(e => e.Dd105DthrUltsync)
                    .HasColumnType("datetime")
                    .HasColumnName("DD105_DTHR_ULTSYNC");
                entity.Property(e => e.Dd105ExecEntregaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_EXEC_ENTREGA_ID");
                entity.Property(e => e.Dd105FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_FILIAL_ID");
                entity.Property(e => e.Dd105Historico)
                    .HasMaxLength(500)
                    .HasColumnName("DD105_HISTORICO");
                entity.Property(e => e.Dd105Isactive).HasColumnName("DD105_ISACTIVE");
                entity.Property(e => e.Dd105Isfechado).HasColumnName("DD105_ISFECHADO");
                entity.Property(e => e.Dd105Issync).HasColumnName("DD105_ISSYNC");
                entity.Property(e => e.Dd105MotivoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_MOTIVO_ID");
                entity.Property(e => e.Dd105Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD105_PROTOCOLNUMBER");
                entity.Property(e => e.Dd105QtdRetorno)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD105_QTD_RETORNO");
                entity.Property(e => e.Dd105UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD105_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD106>(entity =>
            {
                entity.HasKey(e => e.Dd106Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD106");

                entity.ToTable("OSUSR_TEI_CSICP_DD106");

                entity.HasIndex(e => new { e.Dd106UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD106_11DD106_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd106PaisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD106_13DD106_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd106CidadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD106_15DD106_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd101Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD106_8DD101_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD106_9TENANT_ID");

                entity.Property(e => e.Dd106Id).HasColumnName("DD106_ID");
                entity.Property(e => e.Dd101Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD101_ID");
                entity.Property(e => e.Dd106Cep).HasColumnName("DD106_CEP");
                entity.Property(e => e.Dd106CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD106_CIDADE_ID");
                entity.Property(e => e.Dd106Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD106_COMPLEMENTO");
                entity.Property(e => e.Dd106Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD106_LOGRADOURO");
                entity.Property(e => e.Dd106Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD106_NOMEBAIRRO");
                entity.Property(e => e.Dd106Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD106_NUMERO");
                entity.Property(e => e.Dd106PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD106_PAIS_ID");
                entity.Property(e => e.Dd106Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD106_PERIMETRO");
                entity.Property(e => e.Dd106UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD106_UF_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD107>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD107");

                entity.ToTable("OSUSR_TEI_CSICP_DD107");

                entity.HasIndex(e => new { e.Dd107Proprietarioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD107_20DD107_PROPRIETARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD107_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Dd107Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD107_DTREGISTRO");
                entity.Property(e => e.Dd107IdentCurto)
                    .HasMaxLength(10)
                    .HasColumnName("DD107_IDENT_CURTO");
                entity.Property(e => e.Dd107IdentLongo)
                    .HasMaxLength(50)
                    .HasColumnName("DD107_IDENT_LONGO");
                entity.Property(e => e.Dd107Proprietarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD107_PROPRIETARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD110>(entity =>
            {
                entity.HasKey(e => e.Dd110CargaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD110");

                entity.ToTable("OSUSR_TEI_CSICP_DD110");

                entity.HasIndex(e => new { e.Dd110ModId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_12DD110_MOD_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Mdfesit, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_13DD110_MDFESIT_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Seguroid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_14DD110_SEGUROID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_15DD110_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_15DD110_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110UfdestId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_15DD110_UFDEST_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110VeiculoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_16DD110_VEICULO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110PropuserId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_17DD110_PROPUSER_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_18DD110_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_20DD110_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110MotoristaUserid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD110_22DD110_MOTORISTA_USERID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD110_9TENANT_ID");

                entity.Property(e => e.Dd110CargaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_CARGA_ID");
                entity.Property(e => e.Dd110Ajudante1Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_AJUDANTE1_ID");
                entity.Property(e => e.Dd110Ajudante2Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_AJUDANTE2_ID");
                entity.Property(e => e.Dd110Ajudante3Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_AJUDANTE3_ID");
                entity.Property(e => e.Dd110Chaveacessonfe)
                    .HasMaxLength(50)
                    .HasColumnName("DD110_CHAVEACESSONFE");
                entity.Property(e => e.Dd110CtrlSerieNfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_CTRL_SERIE_NF_ID");
                entity.Property(e => e.Dd110DataCarga)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DATA_CARGA");
                entity.Property(e => e.Dd110DataChegada)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DATA_CHEGADA");
                entity.Property(e => e.Dd110DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DATA_SAIDA");
                entity.Property(e => e.Dd110Descritivocarga)
                    .HasMaxLength(200)
                    .HasColumnName("DD110_DESCRITIVOCARGA");
                entity.Property(e => e.Dd110Dtautor)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DTAUTOR");
                entity.Property(e => e.Dd110Dtemiss)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DTEMISS");
                entity.Property(e => e.Dd110DthrUltsync)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_DTHR_ULTSYNC");
                entity.Property(e => e.Dd110FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_FILIAL_ID");
                entity.Property(e => e.Dd110HoraChegada)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_HORA_CHEGADA");
                entity.Property(e => e.Dd110HoraSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD110_HORA_SAIDA");
                entity.Property(e => e.Dd110Issync).HasColumnName("DD110_ISSYNC");
                entity.Property(e => e.Dd110KmChegada).HasColumnName("DD110_KM_CHEGADA");
                entity.Property(e => e.Dd110KmSaida).HasColumnName("DD110_KM_SAIDA");
                entity.Property(e => e.Dd110Mdfesit).HasColumnName("DD110_MDFESIT");
                entity.Property(e => e.Dd110ModId).HasColumnName("DD110_MOD_ID");
                entity.Property(e => e.Dd110Modentregaid).HasColumnName("DD110_MODENTREGAID");
                entity.Property(e => e.Dd110MotoristaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_MOTORISTA_ID");
                entity.Property(e => e.Dd110MotoristaUserid)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_MOTORISTA_USERID");
                entity.Property(e => e.Dd110NoNf).HasColumnName("DD110_NO_NF");
                entity.Property(e => e.Dd110PercIndiceminimo)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD110_PERC_INDICEMINIMO");
                entity.Property(e => e.Dd110PesoBruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD110_PESO_BRUTO");
                entity.Property(e => e.Dd110PesoLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD110_PESO_LIQUIDO");
                entity.Property(e => e.Dd110PropuserId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_PROPUSER_ID");
                entity.Property(e => e.Dd110Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD110_PROTOCOLNUMBER");
                entity.Property(e => e.Dd110QtdNfs).HasColumnName("DD110_QTD_NFS");
                entity.Property(e => e.Dd110Seguroid)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_SEGUROID");
                entity.Property(e => e.Dd110Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD110_SERIE");
                entity.Property(e => e.Dd110StatusId).HasColumnName("DD110_STATUS_ID");
                entity.Property(e => e.Dd110Terceirizada).HasColumnName("DD110_TERCEIRIZADA");
                entity.Property(e => e.Dd110Tvalornfs)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD110_TVALORNFS");
                entity.Property(e => e.Dd110Tvlrcobranca)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD110_TVLRCOBRANCA");
                entity.Property(e => e.Dd110UfdestId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_UFDEST_ID");
                entity.Property(e => e.Dd110Valorfrete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD110_VALORFRETE");
                entity.Property(e => e.Dd110VeiculoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_VEICULO_ID");
                entity.Property(e => e.Dd110Volumes).HasColumnName("DD110_VOLUMES");
                entity.Property(e => e.MdfeCstat)
                    .HasMaxLength(5)
                    .HasColumnName("MDFE_CSTAT");
                entity.Property(e => e.MdfeEpecNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("MDFE_EPEC_NPROT");
                entity.Property(e => e.MdfeNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("MDFE_NPROT");
                entity.Property(e => e.MdfeNrec)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("MDFE_NREC");
                entity.Property(e => e.NfeEpecNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_EPEC_NPROT");
                entity.Property(e => e.NfeNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NPROT");
                entity.Property(e => e.NfeNrec)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NREC");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD110Mdfe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD110_MDFE");

                entity.ToTable("OSUSR_TEI_CSICP_DD110_MDFE");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD110_MDFE_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD110Mod>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD110_MOD");

                entity.ToTable("OSUSR_TEI_CSICP_DD110_MOD");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD110_MOD_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs).HasColumnName("CODG_CS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD110Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD110_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD110_STATUS");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD110_STATUS_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD111>(entity =>
            {
                entity.HasKey(e => e.Dd111Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD111");

                entity.ToTable("OSUSR_TEI_CSICP_DD111");

                entity.HasIndex(e => new { e.Dd111TpdespesaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD111_18DD111_TPDESPESA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD111_9TENANT_ID");

                entity.Property(e => e.Dd111Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD111_ID");
                entity.Property(e => e.Dd111Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("DD111_CODIGO");
                entity.Property(e => e.Dd111Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("DD111_DESCRICAO");
                entity.Property(e => e.Dd111TpdespesaId).HasColumnName("DD111_TPDESPESA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD111Tde>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD111_TDES");

                entity.ToTable("OSUSR_TEI_CSICP_DD111_TDES");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD111_TDES_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD113>(entity =>
            {
                entity.HasKey(e => e.Dd113Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD113");

                entity.ToTable("OSUSR_TEI_CSICP_DD113");

                entity.HasIndex(e => new { e.Dd113CargaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD113_14DD113_CARGA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd113DespesaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD113_16DD113_DESPESA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd113Romaneioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD113_16DD113_ROMANEIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD113_9TENANT_ID");

                entity.Property(e => e.Dd113Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD113_ID");
                entity.Property(e => e.Dd113CargaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD113_CARGA_ID");
                entity.Property(e => e.Dd113DespesaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD113_DESPESA_ID");
                entity.Property(e => e.Dd113Pcomissao)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("DD113_PCOMISSAO");
                entity.Property(e => e.Dd113Romaneioid).HasColumnName("DD113_ROMANEIOID");
                entity.Property(e => e.Dd113Seq).HasColumnName("DD113_SEQ");
                entity.Property(e => e.Dd113Tipolancto).HasColumnName("DD113_TIPOLANCTO");
                entity.Property(e => e.Dd113Valor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD113_VALOR");
                entity.Property(e => e.Dd113Vcomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD113_VCOMISSAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD114>(entity =>
            {
                entity.HasKey(e => e.Dd114Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD114");

                entity.ToTable("OSUSR_TEI_CSICP_DD114");

                entity.HasIndex(e => new { e.Dd114Ufid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD114_10DD114_UFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Cargaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD114_13DD110_CARGAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD114_9TENANT_ID");

                entity.Property(e => e.Dd114Id).HasColumnName("DD114_ID");
                entity.Property(e => e.Dd110Cargaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_CARGAID");
                entity.Property(e => e.Dd114Seq).HasColumnName("DD114_SEQ");
                entity.Property(e => e.Dd114Ufid)
                    .HasMaxLength(36)
                    .HasColumnName("DD114_UFID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD115>(entity =>
            {
                entity.HasKey(e => e.Dd115Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD115");

                entity.ToTable("OSUSR_TEI_CSICP_DD115");

                entity.HasIndex(e => new { e.Dd110Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD115_8DD110_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD115_9TENANT_ID");

                entity.Property(e => e.Dd115Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD115_ID");
                entity.Property(e => e.Dd110Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_ID");
                entity.Property(e => e.Dd115DescricaoCompl).HasColumnName("DD115_DESCRICAO_COMPL");
                entity.Property(e => e.Dd115Tiporegistro).HasColumnName("DD115_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD116>(entity =>
            {
                entity.HasKey(e => e.Dd116Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD116");

                entity.ToTable("OSUSR_TEI_CSICP_DD116", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD116"));

                entity.HasIndex(e => new { e.Dd116EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_14DD116_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd116SenvioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_15DD116_SENVIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd116ServicoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_16DD116_SERVICO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd116UsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_16DD116_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd116TipoenvioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_18DD116_TIPOENVIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD116_8DD110_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD116_9TENANT_ID");

                entity.Property(e => e.Dd116Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD116_ID");
                entity.Property(e => e.Dd110Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_ID");
                entity.Property(e => e.Dd116Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD116_DATAHORA");
                entity.Property(e => e.Dd116EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD116_ESTAB_ID");
                entity.Property(e => e.Dd116SenvioId).HasColumnName("DD116_SENVIO_ID");
                entity.Property(e => e.Dd116Sequencia).HasColumnName("DD116_SEQUENCIA");
                entity.Property(e => e.Dd116ServicoId).HasColumnName("DD116_SERVICO_ID");
                entity.Property(e => e.Dd116TipoenvioId).HasColumnName("DD116_TIPOENVIO_ID");
                entity.Property(e => e.Dd116UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD116_USUARIO_ID");
                entity.Property(e => e.NfeCstat)
                    .HasMaxLength(5)
                    .HasColumnName("NFE_CSTAT");
                entity.Property(e => e.NfeNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NPROT");
                entity.Property(e => e.NfeNrec)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NREC");
                entity.Property(e => e.NfeXmlEnvio).HasColumnName("NFE_XML_ENVIO");
                entity.Property(e => e.NfeXmlEnvio2).HasColumnName("NFE_XML_ENVIO2");
                entity.Property(e => e.NfeXmlRetorno).HasColumnName("NFE_XML_RETORNO");
                entity.Property(e => e.NfeXmotivo)
                    .HasMaxLength(255)
                    .HasColumnName("NFE_XMOTIVO");
                entity.Property(e => e.NfeXmotivoLongo).HasColumnName("NFE_XMOTIVO_LONGO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD117>(entity =>
            {
                entity.HasKey(e => e.Dd117Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD117");

                entity.ToTable("OSUSR_TEI_CSICP_DD117");

                entity.HasIndex(e => new { e.Dd117TobjetoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD117_16DD117_TOBJETO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD117_8DD110_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD117_9TENANT_ID");

                entity.Property(e => e.Dd117Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD117_ID");
                entity.Property(e => e.Dd110Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_ID");
                entity.Property(e => e.Dd117Objeto).HasColumnName("DD117_OBJETO");
                entity.Property(e => e.Dd117TobjetoId).HasColumnName("DD117_TOBJETO_ID");
                entity.Property(e => e.Dd117Xml).HasColumnName("DD117_XML");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD120>(entity =>
            {
                entity.HasKey(e => e.Dd120TrocaId).HasName("OSPRK_OSUSR_TEI_CSICP_DD120");

                entity.ToTable("OSUSR_TEI_CSICP_DD120");

                entity.HasIndex(e => new { e.Dd120Tpdevid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_13DD120_TPDEVID_9TENANT_ID");

                entity.HasIndex(e => new { e.CsicpFf002Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_14CSICP_FF002_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_14DD120_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_15DD120_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_15DD120_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120PossuicartaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_20DD120_POSSUICARTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD120_20DD120_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD120_9TENANT_ID");

                entity.Property(e => e.Dd120TrocaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_TROCA_ID");
                entity.Property(e => e.CsicpFf002Id)
                    .HasMaxLength(36)
                    .HasColumnName("CSICP_FF002_ID");
                entity.Property(e => e.Dd120ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_CONTA_ID");
                entity.Property(e => e.Dd120DataTroca)
                    .HasColumnType("datetime")
                    .HasColumnName("DD120_DATA_TROCA");
                entity.Property(e => e.Dd120FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_FILIAL_ID");
                entity.Property(e => e.Dd120NoImpressoes).HasColumnName("DD120_NO_IMPRESSOES");
                entity.Property(e => e.Dd120Observacao)
                    .HasMaxLength(200)
                    .HasColumnName("DD120_OBSERVACAO");
                entity.Property(e => e.Dd120Pdesconto)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("DD120_PDESCONTO");
                entity.Property(e => e.Dd120PossuicartaId).HasColumnName("DD120_POSSUICARTA_ID");
                entity.Property(e => e.Dd120Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD120_PROTOCOLNUMBER");
                entity.Property(e => e.Dd120StatusId).HasColumnName("DD120_STATUS_ID");
                entity.Property(e => e.Dd120Tpdevid).HasColumnName("DD120_TPDEVID");
                entity.Property(e => e.Dd120UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_USUARIOPROP_ID");
                entity.Property(e => e.Dd120Vacrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD120_VACRESCIMO");
                entity.Property(e => e.Dd120Vdesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD120_VDESCONTO");
                entity.Property(e => e.Dd120VsaldoCartacred)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD120_VSALDO_CARTACRED");
                entity.Property(e => e.Dd120Vtotalbruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD120_VTOTALBRUTO");
                entity.Property(e => e.Dd120Vtotalliquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD120_VTOTALLIQUIDO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD120Pcartum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD120_PCARTA");

                entity.ToTable("OSUSR_TEI_CSICP_DD120_PCARTA");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD120_PCARTA_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD120Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD120_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD120_STATUS");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD120_STATUS_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD120tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD120TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD120TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD121>(entity =>
            {
                entity.HasKey(e => e.Dd121Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD121");

                entity.ToTable("OSUSR_TEI_CSICP_DD121");

                entity.HasIndex(e => new { e.Dd121UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_11DD121_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd121PaisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_13DD121_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd121ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_14DD121_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd121BairroId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_15DD121_BAIRRO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd121CidadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_15DD121_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd121Tipodocto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_15DD121_TIPODOCTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd120Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD121_8DD120_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD121_9TENANT_ID");

                entity.Property(e => e.Dd121Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_ID");
                entity.Property(e => e.Dd120Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_ID");
                entity.Property(e => e.Dd121BairroId)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_BAIRRO_ID");
                entity.Property(e => e.Dd121Cep).HasColumnName("DD121_CEP");
                entity.Property(e => e.Dd121CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_CIDADE_ID");
                entity.Property(e => e.Dd121CnpjCpf)
                    .HasMaxLength(15)
                    .HasColumnName("DD121_CNPJ_CPF");
                entity.Property(e => e.Dd121Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD121_COMPLEMENTO");
                entity.Property(e => e.Dd121ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_CONTA_ID");
                entity.Property(e => e.Dd121Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD121_EMAIL");
                entity.Property(e => e.Dd121IeRg)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD121_IE_RG");
                entity.Property(e => e.Dd121IsSendEmail)
                    .HasMaxLength(250)
                    .HasColumnName("DD121_IS_SEND_EMAIL");
                entity.Property(e => e.Dd121IsSendSms).HasColumnName("DD121_IS_SEND_SMS");
                entity.Property(e => e.Dd121Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD121_LOGRADOURO");
                entity.Property(e => e.Dd121Nome)
                    .HasMaxLength(100)
                    .HasColumnName("DD121_NOME");
                entity.Property(e => e.Dd121Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD121_NOMEBAIRRO");
                entity.Property(e => e.Dd121Nrosms)
                    .HasMaxLength(20)
                    .HasColumnName("DD121_NROSMS");
                entity.Property(e => e.Dd121Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD121_NUMERO");
                entity.Property(e => e.Dd121PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_PAIS_ID");
                entity.Property(e => e.Dd121Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD121_PERIMETRO");
                entity.Property(e => e.Dd121Suframa)
                    .HasMaxLength(20)
                    .HasColumnName("DD121_SUFRAMA");
                entity.Property(e => e.Dd121Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD121_TELEFONE");
                entity.Property(e => e.Dd121Tipo).HasColumnName("DD121_TIPO");
                entity.Property(e => e.Dd121Tipodocto).HasColumnName("DD121_TIPODOCTO");
                entity.Property(e => e.Dd121UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD121_UF_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD122>(entity =>
            {
                entity.HasKey(e => e.Dd122TrocaitemId).HasName("OSPRK_OSUSR_TEI_CSICP_DD122");

                entity.ToTable("OSUSR_TEI_CSICP_DD122");

                entity.HasIndex(e => new { e.Dd120TrocaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_14DD120_TROCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122MotivoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_15DD122_MOTIVO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060VendaitemId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_18DD060_VENDAITEM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122UsuariovendId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_20DD122_USUARIOVEND_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122SaldodestinoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_21DD122_SALDODESTINO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122TipodevolucaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_22DD122_TIPODEVOLUCAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122UsuarioreaverId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_22DD122_USUARIOREAVER_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd122UsuariorecebeuId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD122_23DD122_USUARIORECEBEU_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD122_9TENANT_ID");

                entity.Property(e => e.Dd122TrocaitemId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_TROCAITEM_ID");
                entity.Property(e => e.Dd060VendaitemId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_VENDAITEM_ID");
                entity.Property(e => e.Dd120TrocaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_TROCA_ID");
                entity.Property(e => e.Dd122Anotacao)
                    .HasMaxLength(100)
                    .HasColumnName("DD122_ANOTACAO");
                entity.Property(e => e.Dd122BaseCalcIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_BASE_CALC_ICMS");
                entity.Property(e => e.Dd122BaseCalcIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_BASE_CALC_IPI");
                entity.Property(e => e.Dd122BaseCalcSubst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_BASE_CALC_SUBST");
                entity.Property(e => e.Dd122Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD122_CODBARRASALFA");
                entity.Property(e => e.Dd122CodgBarra)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("DD122_CODG_BARRA");
                entity.Property(e => e.Dd122DataReaver)
                    .HasColumnType("datetime")
                    .HasColumnName("DD122_DATA_REAVER");
                entity.Property(e => e.Dd122DataRecbto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD122_DATA_RECBTO");
                entity.Property(e => e.Dd122Entradasaida).HasColumnName("DD122_ENTRADASAIDA");
                entity.Property(e => e.Dd122Frete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_FRETE");
                entity.Property(e => e.Dd122Isrecebido).HasColumnName("DD122_ISRECEBIDO");
                entity.Property(e => e.Dd122LucroEstimado)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_LUCRO_ESTIMADO");
                entity.Property(e => e.Dd122MotivoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_MOTIVO_ID");
                entity.Property(e => e.Dd122Odespesas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_ODESPESAS");
                entity.Property(e => e.Dd122Pabatimento)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("DD122_PABATIMENTO");
                entity.Property(e => e.Dd122Pacrescimo)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PACRESCIMO");
                entity.Property(e => e.Dd122PercDescproduto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PERC_DESCPRODUTO");
                entity.Property(e => e.Dd122PercIcms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PERC_ICMS");
                entity.Property(e => e.Dd122PercIpi)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PERC_IPI");
                entity.Property(e => e.Dd122PercSubstTrib)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PERC_SUBST_TRIB");
                entity.Property(e => e.Dd122Percreducaobaseicms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD122_PERCREDUCAOBASEICMS");
                entity.Property(e => e.Dd122PrcTabela2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_PRC_TABELA2");
                entity.Property(e => e.Dd122PrecoUnitario)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_PRECO_UNITARIO");
                entity.Property(e => e.Dd122Precotabela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_PRECOTABELA");
                entity.Property(e => e.Dd122QtdTroca)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_QTD_TROCA");
                entity.Property(e => e.Dd122QtdTrocaAnt)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_QTD_TROCA_ANT");
                entity.Property(e => e.Dd122SaldodestinoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_SALDODESTINO_ID");
                entity.Property(e => e.Dd122SaldoorigemId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_SALDOORIGEM_ID");
                entity.Property(e => e.Dd122Seguro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_SEGURO");
                entity.Property(e => e.Dd122Seq).HasColumnName("DD122_SEQ");
                entity.Property(e => e.Dd122St2Liquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_ST2_LIQUIDO");
                entity.Property(e => e.Dd122TipodevolucaoId).HasColumnName("DD122_TIPODEVOLUCAO_ID");
                entity.Property(e => e.Dd122TotalDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_TOTAL_DESCONTO");
                entity.Property(e => e.Dd122TotalLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_TOTAL_LIQUIDO");
                entity.Property(e => e.Dd122Totliqproduto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_TOTLIQPRODUTO");
                entity.Property(e => e.Dd122UsuarioreaverId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_USUARIOREAVER_ID");
                entity.Property(e => e.Dd122UsuariorecebeuId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_USUARIORECEBEU_ID");
                entity.Property(e => e.Dd122UsuariovendId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_USUARIOVEND_ID");
                entity.Property(e => e.Dd122VabatPorvalor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VABAT_PORVALOR");
                entity.Property(e => e.Dd122Vabatimento)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VABATIMENTO");
                entity.Property(e => e.Dd122Vacrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VACRESCIMO");
                entity.Property(e => e.Dd122ValorDescproduto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VALOR_DESCPRODUTO");
                entity.Property(e => e.Dd122ValorIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VALOR_ICMS");
                entity.Property(e => e.Dd122ValorIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VALOR_IPI");
                entity.Property(e => e.Dd122VbrutoTroca)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VBRUTO_TROCA");
                entity.Property(e => e.Dd122Vdescsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VDESCSUFRAMA");
                entity.Property(e => e.Dd122VendedorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD122_VENDEDOR_ID");
                entity.Property(e => e.Dd122VliqTroca)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VLIQ_TROCA");
                entity.Property(e => e.Dd122VlrDescSt1liq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VLR_DESC_ST1LIQ");
                entity.Property(e => e.Dd122Vlrsubsttribaux)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VLRSUBSTTRIBAUX");
                entity.Property(e => e.Dd122Vlrsubsttribut)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD122_VLRSUBSTTRIBUT");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD122Tpde>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD122_TPDE");

                entity.ToTable("OSUSR_TEI_CSICP_DD122_TPDE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD123>(entity =>
            {
                entity.HasKey(e => e.Dd123MovtoNdId).HasName("OSPRK_OSUSR_TEI_CSICP_DD123");

                entity.ToTable("OSUSR_TEI_CSICP_DD123");

                entity.HasIndex(e => new { e.Dd040VendaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_14DD040_VENDA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_14DD123_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_15DD123_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_15DD123_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_19DD123_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123FormapagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_19DD123_FORMAPAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070AtendimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_20DD070_ATENDIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_20DD123_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_20DD123_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD123_20DD123_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD123_9TENANT_ID");

                entity.Property(e => e.Dd123MovtoNdId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_MOVTO_ND_ID");
                entity.Property(e => e.Dd040VendaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_VENDA_ID");
                entity.Property(e => e.Dd070AtendimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ATENDIMENTO_ID");
                entity.Property(e => e.Dd123AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_AGCOBRADOR_ID");
                entity.Property(e => e.Dd123CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_CCUSTO_ID");
                entity.Property(e => e.Dd123ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_CONTA_ID");
                entity.Property(e => e.Dd123DataEmissaoFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DD123_DATA_EMISSAO_FINAL");
                entity.Property(e => e.Dd123DataEmissaoIni)
                    .HasColumnType("datetime")
                    .HasColumnName("DD123_DATA_EMISSAO_INI");
                entity.Property(e => e.Dd123DataMovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD123_DATA_MOVTO");
                entity.Property(e => e.Dd123FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_FILIAL_ID");
                entity.Property(e => e.Dd123FormapagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_FORMAPAGTO_ID");
                entity.Property(e => e.Dd123NatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_NATOPERACAO_ID");
                entity.Property(e => e.Dd123Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD123_PROTOCOLNUMBER");
                entity.Property(e => e.Dd123ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_RESPONSAVEL_ID");
                entity.Property(e => e.Dd123StatusId)
                    .HasMaxLength(50)
                    .HasColumnName("DD123_STATUS_ID");
                entity.Property(e => e.Dd123UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD124>(entity =>
            {
                entity.HasKey(e => e.Dd124Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD124");

                entity.ToTable("OSUSR_TEI_CSICP_DD124");

                entity.HasIndex(e => new { e.Dd120TrocaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD124_14DD120_TROCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd123MovtoNdId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD124_17DD123_MOVTO_ND_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD124_9TENANT_ID");

                entity.Property(e => e.Dd124Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD124_ID");
                entity.Property(e => e.Dd120TrocaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_TROCA_ID");
                entity.Property(e => e.Dd123MovtoNdId)
                    .HasMaxLength(36)
                    .HasColumnName("DD123_MOVTO_ND_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD125>(entity =>
            {
                entity.HasKey(e => e.Dd125CartacredId).HasName("OSPRK_OSUSR_TEI_CSICP_DD125");

                entity.ToTable("OSUSR_TEI_CSICP_DD125", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD125"));

                entity.HasIndex(e => new { e.Dd120TrocaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_14DD120_TROCA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_14DD125_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_15DD125_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_15DD125_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125Tiporegid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_15DD125_TIPOREGID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD125_20DD125_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD125_9TENANT_ID");

                entity.Property(e => e.Dd125CartacredId)
                    .HasMaxLength(36)
                    .HasColumnName("DD125_CARTACRED_ID");
                entity.Property(e => e.Dd120TrocaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD120_TROCA_ID");
                entity.Property(e => e.Dd125ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD125_CONTA_ID");
                entity.Property(e => e.Dd125DataMovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD125_DATA_MOVTO");
                entity.Property(e => e.Dd125Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD125_EMAIL");
                entity.Property(e => e.Dd125FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD125_FILIAL_ID");
                entity.Property(e => e.Dd125Islock).HasColumnName("DD125_ISLOCK");
                entity.Property(e => e.Dd125Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD125_PROTOCOLNUMBER");
                entity.Property(e => e.Dd125Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD125_SMS");
                entity.Property(e => e.Dd125StatusId).HasColumnName("DD125_STATUS_ID");
                entity.Property(e => e.Dd125Tiporegid).HasColumnName("DD125_TIPOREGID");
                entity.Property(e => e.Dd125UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD125_USUARIOPROP_ID");
                entity.Property(e => e.Dd125Vcarta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD125_VCARTA");
                entity.Property(e => e.Dd125VsaldoCarta)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD125_VSALDO_CARTA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD125Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD125_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD125_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD125Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD125_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD125_TP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CsUsocs)
                    .HasMaxLength(20)
                    .HasColumnName("CS_USOCS");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD126>(entity =>
            {
                entity.HasKey(e => e.Dd126RegccredId).HasName("OSPRK_OSUSR_TEI_CSICP_DD126");

                entity.ToTable("OSUSR_TEI_CSICP_DD126");

                entity.HasIndex(e => new { e.Dd126FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD126_15DD126_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd126TmovtoCcreId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD126_20DD126_TMOVTO_CCRE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd126UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD126_20DD126_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd126CartacreditoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD126_21DD126_CARTACREDITO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd142HashCalculador, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD126_21DD142_HASH_CALCULADOR_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD126_9TENANT_ID");

                entity.Property(e => e.Dd126RegccredId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_REGCCRED_ID");
                entity.Property(e => e.Dd126CartacreditoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_CARTACREDITO_ID");
                entity.Property(e => e.Dd126DataCredito)
                    .HasColumnType("datetime")
                    .HasColumnName("DD126_DATA_CREDITO");
                entity.Property(e => e.Dd126DataMovto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD126_DATA_MOVTO");
                entity.Property(e => e.Dd126FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_FILIAL_ID");
                entity.Property(e => e.Dd126Historico)
                    .HasMaxLength(200)
                    .HasColumnName("DD126_HISTORICO");
                entity.Property(e => e.Dd126PdvId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_PDV_ID");
                entity.Property(e => e.Dd126Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD126_PROTOCOLNUMBER");
                entity.Property(e => e.Dd126TmovtoCcreId).HasColumnName("DD126_TMOVTO_CCRE_ID");
                entity.Property(e => e.Dd126UsoInternoWs)
                    .HasMaxLength(200)
                    .HasColumnName("DD126_USO_INTERNO_WS");
                entity.Property(e => e.Dd126UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_USUARIOPROP_ID");
                entity.Property(e => e.Dd126VlrUtilizado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD126_VLR_UTILIZADO");
                entity.Property(e => e.Dd142HashCalculador)
                    .HasMaxLength(36)
                    .HasColumnName("DD142_HASH_CALCULADOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");




            });

            modelBuilder.Entity<CSICP_DD126Tmov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD126_TMOV");

                entity.ToTable("OSUSR_TEI_CSICP_DD126_TMOV");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD127>(entity =>
            {
                entity.HasKey(e => e.Dd127LogccredId).HasName("OSPRK_OSUSR_TEI_CSICP_DD127");

                entity.ToTable("OSUSR_TEI_CSICP_DD127");

                entity.HasIndex(e => new { e.Dd126UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD127_20DD126_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd127CartacreditoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD127_21DD127_CARTACREDITO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD127_9TENANT_ID");

                entity.Property(e => e.Dd127LogccredId)
                    .HasMaxLength(36)
                    .HasColumnName("DD127_LOGCCRED_ID");
                entity.Property(e => e.Dd126DataReg)
                    .HasColumnType("datetime")
                    .HasColumnName("DD126_DATA_REG");
                entity.Property(e => e.Dd126Mensagem)
                    .HasMaxLength(200)
                    .HasColumnName("DD126_MENSAGEM");
                entity.Property(e => e.Dd126UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_USUARIOPROP_ID");
                entity.Property(e => e.Dd127CartacreditoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD127_CARTACREDITO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD128>(entity =>
            {
                entity.HasKey(e => e.Dd128Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD128");

                entity.ToTable("OSUSR_TEI_CSICP_DD128");

                entity.HasIndex(e => new { e.Dd042Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD128_8DD042_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd072Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD128_8DD072_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd125Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD128_8DD125_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Pd014Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD128_8PD014_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD128_9TENANT_ID");

                entity.Property(e => e.Dd128Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD128_ID");
                entity.Property(e => e.Dd042Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ID");
                entity.Property(e => e.Dd072Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_ID");
                entity.Property(e => e.Dd125Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD125_ID");
                entity.Property(e => e.Key)
                    .HasMaxLength(36)
                    .HasColumnName("KEY");
                entity.Property(e => e.Pd014Id)
                    .HasMaxLength(36)
                    .HasColumnName("PD014_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");






            });

            modelBuilder.Entity<CSICP_DD129>(entity =>
            {
                entity.HasKey(e => e.Dd129Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD129");

                entity.ToTable("OSUSR_TEI_CSICP_DD129");

                entity.HasIndex(e => new { e.Dd040NotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD129_13DD040_NOTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Ff102Tituloid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD129_14FF102_TITULOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd126RegccredId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD129_17DD126_REGCCRED_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD129_9TENANT_ID");

                entity.Property(e => e.Dd129Id).HasColumnName("DD129_ID");
                entity.Property(e => e.Dd040NotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_NOTA_ID");
                entity.Property(e => e.Dd126RegccredId)
                    .HasMaxLength(36)
                    .HasColumnName("DD126_REGCCRED_ID");
                entity.Property(e => e.Dd129Isprocessado).HasColumnName("DD129_ISPROCESSADO");
                entity.Property(e => e.Dd129Vtitulo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD129_VTITULO");
                entity.Property(e => e.Ff102Tituloid)
                    .HasMaxLength(36)
                    .HasColumnName("FF102_TITULOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });
        }
    }
}
