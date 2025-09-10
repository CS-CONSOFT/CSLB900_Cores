using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD040> OsusrTeiCsicpDd040s { get; set; }

        public virtual DbSet<CSICP_DD040Estq> OsusrTeiCsicpDd040Estqs { get; set; }

        public virtual DbSet<CSICP_DD040Ipre> OsusrTeiCsicpDd040Ipres { get; set; }

        public virtual DbSet<CSICP_DD040Nfe> OsusrTeiCsicpDd040Nves { get; set; }

        public virtual DbSet<CSICP_DD040Sit> OsusrTeiCsicpDd040Sits { get; set; }

        public virtual DbSet<CSICP_DD040Stent> OsusrTeiCsicpDd040Stents { get; set; }

        public virtual DbSet<CSICP_DD040Tnt> OsusrTeiCsicpDd040Tnts { get; set; }

        public virtual DbSet<CSICP_DD041> OsusrTeiCsicpDd041s { get; set; }

        public virtual DbSet<CSICP_DD041Docto> OsusrTeiCsicpDd041Doctos { get; set; }

        public virtual DbSet<CSICP_DD041Frete> OsusrTeiCsicpDd041Fretes { get; set; }

        public virtual DbSet<CSICP_DD042> OsusrTeiCsicpDd042s { get; set; }

        public virtual DbSet<CSICP_DD043> OsusrTeiCsicpDd043s { get; set; }

        public virtual DbSet<CSICP_DD044> OsusrTeiCsicpDd044s { get; set; }

        public virtual DbSet<CSICP_DD045> OsusrTeiCsicpDd045s { get; set; }

        public virtual DbSet<CSICP_DD046> OsusrTeiCsicpDd046s { get; set; }

        public virtual DbSet<CSICP_DD046Pro> OsusrTeiCsicpDd046Pros { get; set; }

        public virtual DbSet<CSICP_DD047> OsusrTeiCsicpDd047s { get; set; }

        public virtual DbSet<CSICP_DD048> OsusrTeiCsicpDd048s { get; set; }

        public virtual DbSet<CSICP_DD048Tipo> OsusrTeiCsicpDd048Tipos { get; set; }

        public virtual DbSet<CSICP_DD049> OsusrTeiCsicpDd049s { get; set; }

        public virtual DbSet<CSICP_DD050> OsusrTeiCsicpDd050s { get; set; }

        public virtual DbSet<CSICP_DD050Tipo> OsusrTeiCsicpDd050Tipos { get; set; }

        public virtual DbSet<CSICP_DD051> OsusrTeiCsicpDd051s { get; set; }

        public virtual DbSet<CSICP_DD052> OsusrTeiCsicpDd052s { get; set; }

        public virtual DbSet<CSICP_DD052Tp> OsusrTeiCsicpDd052Tps { get; set; }

        public virtual DbSet<CSICP_DD053> OsusrTeiCsicpDd053s { get; set; }

        public virtual DbSet<CSICP_DD054> OsusrTeiCsicpDd054s { get; set; }

        public virtual DbSet<CSICP_DD055> OsusrTeiCsicpDd055s { get; set; }

        public virtual DbSet<CSICP_DD060> OsusrTeiCsicpDd060s { get; set; }

        public virtual DbSet<CSICP_DD060Estq> OsusrTeiCsicpDd060Estqs { get; set; }

        public virtual DbSet<CSICP_DD060comb> OsusrTeiCsicpDd060combs { get; set; }

        public virtual DbSet<CSICP_DD060combla01> OsusrTeiCsicpDd060combla01s { get; set; }

        public virtual DbSet<CSICP_DD061> OsusrTeiCsicpDd061s { get; set; }

        public virtual DbSet<CSICP_DD061Cfgimp> OsusrTeiCsicpDd061Cfgimps { get; set; }

        public virtual DbSet<CSICP_DD062> OsusrTeiCsicpDd062s { get; set; }

        public virtual DbSet<CSICP_DD062Imp> OsusrTeiCsicpDd062Imps { get; set; }

        public virtual DbSet<CSICP_DD063> OsusrTeiCsicpDd063s { get; set; }

        public virtual DbSet<CSICP_DD066> OsusrTeiCsicpDd066s { get; set; }

        public virtual DbSet<CSICP_DD066Tp> OsusrTeiCsicpDd066Tps { get; set; }

        partial void OnModelCreating_CSICP_DD_40_60(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD040>(entity =>
            {
                entity.HasKey(e => e.Dd040Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040");

                entity.ToTable("OSUSR_TEI_CSICP_DD040", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD040"));

                entity.HasIndex(e => new { e.Dd040Serie, e.Dd040NoNf, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_11DD040_SERIE_11DD040_NO_NF_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040ModId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_12DD040_MOD_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Tpemis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_12DD040_TPEMIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040DispId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_13DD040_DISP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Indpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_13DD040_INDPRES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_14DD040_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Situacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_14DD040_SITUACAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Empresaid, e.Dd040TiponotaId, e.Dd040NumImpressoes, e.Dd040SitNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_EMPRESAID_17DD040_TIPONOTA_ID_20DD040_NUM_IMPRESSOES_16DD040_SIT_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_15DD040_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040SitNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_16DD040_SIT_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Arquitetoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_ARQUITETOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040AvalistaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_AVALISTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Origemregpv, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_ORIGEMREGPV_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040TiponotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_17DD040_TIPONOTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040ContarealId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_CONTAREAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040DataEmissao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_DATA_EMISSAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Keyecommerce, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_KEYECOMMERCE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_18DD040_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Chavecashback, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_CHAVECASHBACK_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040CompContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_COMP_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040CondPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_COND_PAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040StEntregaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_19DD040_ST_ENTREGA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040ClassecontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_CLASSECONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD040_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd042Chaveacessonfe, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_20DD042_CHAVEACESSONFE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040AlmoxdestinoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_21DD040_ALMOXDESTINO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_21DD040_MODALIDADEFRETE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040UsuarioProprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_22DD040_USUARIO_PROPR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_22DD040_VICMSDESONSUB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040CtbIsestornadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_23DD040_CTB_ISESTORNADOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040StatusEstoqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_23DD040_STATUS_ESTOQUE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Usuariofaturistaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_24DD040_USUARIOFATURISTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040UsuarioAtendenteid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_25DD040_USUARIO_ATENDENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040CtbIscontabilizadoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD040_27DD040_CTB_ISCONTABILIZADOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD040_9TENANT_ID");

                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd040Acrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_ACRESCIMO");
                entity.Property(e => e.Dd040AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_AGCOBRADOR_ID");
                entity.Property(e => e.Dd040Alfa50)
                    .HasMaxLength(50)
                    .HasColumnName("DD040_ALFA_50");
                entity.Property(e => e.Dd040AlmoxdestinoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ALMOXDESTINO_ID");
                entity.Property(e => e.Dd040Arquitetoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ARQUITETOID");
                entity.Property(e => e.Dd040AvalistaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_AVALISTA_ID");
                entity.Property(e => e.Dd040CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CCUSTO_ID");
                entity.Property(e => e.Dd040Chavecashback)
                    .HasMaxLength(10)
                    .HasColumnName("DD040_CHAVECASHBACK");
                entity.Property(e => e.Dd040CiOrcamento)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD040_CI_ORCAMENTO");
                entity.Property(e => e.Dd040ClassecontaId).HasColumnName("DD040_CLASSECONTA_ID");
                entity.Property(e => e.Dd040CnpjMarketplace)
                    .HasMaxLength(14)
                    .HasColumnName("DD040_CNPJ_MARKETPLACE");
                entity.Property(e => e.Dd040Codalmoxdestino).HasColumnName("DD040_CODALMOXDESTINO");
                entity.Property(e => e.Dd040CodgAgcobrador).HasColumnName("DD040_CODG_AGCOBRADOR");
                entity.Property(e => e.Dd040CodgAtendente).HasColumnName("DD040_CODG_ATENDENTE");
                entity.Property(e => e.Dd040CodgCcusto).HasColumnName("DD040_CODG_CCUSTO");
                entity.Property(e => e.Dd040CodgCondPagto).HasColumnName("DD040_CODG_COND_PAGTO");
                entity.Property(e => e.Dd040Codnatoperacao)
                    .HasMaxLength(10)
                    .HasColumnName("DD040_CODNATOPERACAO");
                entity.Property(e => e.Dd040Codrespcomprador).HasColumnName("DD040_CODRESPCOMPRADOR");
                entity.Property(e => e.Dd040Codrespvendedor).HasColumnName("DD040_CODRESPVENDEDOR");
                entity.Property(e => e.Dd040Codtabelapreco)
                    .HasMaxLength(7)
                    .HasColumnName("DD040_CODTABELAPRECO");
                entity.Property(e => e.Dd040Comissao).HasColumnName("DD040_COMISSAO");
                entity.Property(e => e.Dd040CompContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_COMP_CONTA_ID");
                entity.Property(e => e.Dd040CondPagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_COND_PAGTO_ID");
                entity.Property(e => e.Dd040ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CONTA_ID");
                entity.Property(e => e.Dd040ContarealId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CONTAREAL_ID");
                entity.Property(e => e.Dd040CorreiosCodRastreio)
                    .HasMaxLength(20)
                    .HasColumnName("DD040_CORREIOS_COD_RASTREIO");
                entity.Property(e => e.Dd040CorreiosDetalhe)
                    .HasMaxLength(255)
                    .HasColumnName("DD040_CORREIOS_DETALHE");
                entity.Property(e => e.Dd040CorreiosSiglaTriagem)
                    .HasMaxLength(3)
                    .HasColumnName("DD040_CORREIOS_SIGLA_TRIAGEM");
                entity.Property(e => e.Dd040CtbDtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_CTB_DTREGISTRO");
                entity.Property(e => e.Dd040CtbEstdtreg)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_CTB_ESTDTREG");
                entity.Property(e => e.Dd040CtbEstusuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CTB_ESTUSUARIOID");
                entity.Property(e => e.Dd040CtbIdlancto).HasColumnName("DD040_CTB_IDLANCTO");
                entity.Property(e => e.Dd040CtbIscontabilizadoid).HasColumnName("DD040_CTB_ISCONTABILIZADOID");
                entity.Property(e => e.Dd040CtbIsestornadoid).HasColumnName("DD040_CTB_ISESTORNADOID");
                entity.Property(e => e.Dd040CtbMsg)
                    .HasMaxLength(100)
                    .HasColumnName("DD040_CTB_MSG");
                entity.Property(e => e.Dd040CtbUsuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CTB_USUARIOID");
                entity.Property(e => e.Dd040CtrlSerieNfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_CTRL_SERIE_NF_ID");
                entity.Property(e => e.Dd040DataEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DATA_EMISSAO");
                entity.Property(e => e.Dd040DataImpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DATA_IMPRESSAO");
                entity.Property(e => e.Dd040DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DATA_MOVIMENTO");
                entity.Property(e => e.Dd040DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DATA_SAIDA");
                entity.Property(e => e.Dd040Datahoraemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DATAHORAEMISSAO");
                entity.Property(e => e.Dd040Desconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_DESCONTO");
                entity.Property(e => e.Dd040DhCanc)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DH_CANC");
                entity.Property(e => e.Dd040Dhaut)
                    .HasMaxLength(30)
                    .HasColumnName("DD040_DHAUT");
                entity.Property(e => e.Dd040Dhcont)
                    .HasMaxLength(30)
                    .HasColumnName("DD040_DHCONT");
                entity.Property(e => e.Dd040Dhentrega)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_DHENTREGA");
                entity.Property(e => e.Dd040Digval)
                    .HasMaxLength(28)
                    .HasColumnName("DD040_DIGVAL");
                entity.Property(e => e.Dd040DispId).HasColumnName("DD040_DISP_ID");
                entity.Property(e => e.Dd040Empenho)
                    .HasMaxLength(10)
                    .HasColumnName("DD040_EMPENHO");
                entity.Property(e => e.Dd040Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_EMPRESAID");
                entity.Property(e => e.Dd040Especie)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_ESPECIE");
                entity.Property(e => e.Dd040Filial).HasColumnName("DD040_FILIAL");
                entity.Property(e => e.Dd040Finnfe)
                    .HasMaxLength(1)
                    .HasColumnName("DD040_FINNFE");
                entity.Property(e => e.Dd040FreteCifFob).HasColumnName("DD040_FRETE_CIF_FOB");
                entity.Property(e => e.Dd040HoraImpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_HORA_IMPRESSAO");
                entity.Property(e => e.Dd040HoraSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD040_HORA_SAIDA");
                entity.Property(e => e.Dd040Indpres).HasColumnName("DD040_INDPRES");
                entity.Property(e => e.Dd040Isgrupada).HasColumnName("DD040_ISGRUPADA");
                entity.Property(e => e.Dd040Islibentregaliq).HasColumnName("DD040_ISLIBENTREGALIQ");
                entity.Property(e => e.Dd040Islocksat).HasColumnName("DD040_ISLOCKSAT");
                entity.Property(e => e.Dd040Isorigemdecupom).HasColumnName("DD040_ISORIGEMDECUPOM");
                entity.Property(e => e.Dd040Isvendaonline).HasColumnName("DD040_ISVENDAONLINE");
                entity.Property(e => e.Dd040Keyecommerce)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_KEYECOMMERCE");
                entity.Property(e => e.Dd040Marca)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_MARCA");
                entity.Property(e => e.Dd040Marketplace)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_MARKETPLACE");
                entity.Property(e => e.Dd040ModId).HasColumnName("DD040_MOD_ID");
                entity.Property(e => e.Dd040Modalidadefrete).HasColumnName("DD040_MODALIDADEFRETE");
                entity.Property(e => e.Dd040Modentregaid).HasColumnName("DD040_MODENTREGAID");
                entity.Property(e => e.Dd040Motdesoneracaoid).HasColumnName("DD040_MOTDESONERACAOID");
                entity.Property(e => e.Dd040Natop)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_NATOP");
                entity.Property(e => e.Dd040NatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_NATOPERACAO_ID");
                entity.Property(e => e.Dd040NfEntregueSn)
                    .HasMaxLength(1)
                    .HasColumnName("DD040_NF_ENTREGUE_SN");
                entity.Property(e => e.Dd040NoCupom).HasColumnName("DD040_NO_CUPOM");
                entity.Property(e => e.Dd040NoEstacao).HasColumnName("DD040_NO_ESTACAO");
                entity.Property(e => e.Dd040NoNf).HasColumnName("DD040_NO_NF");
                entity.Property(e => e.Dd040NoPdv).HasColumnName("DD040_NO_PDV");
                entity.Property(e => e.Dd040NoPedido).HasColumnName("DD040_NO_PEDIDO");
                entity.Property(e => e.Dd040NoRequisicao)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD040_NO_REQUISICAO");
                entity.Property(e => e.Dd040NroContrato)
                    .HasMaxLength(50)
                    .HasColumnName("DD040_NRO_CONTRATO");
                entity.Property(e => e.Dd040NroRomaneio)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD040_NRO_ROMANEIO");
                entity.Property(e => e.Dd040NumImpressoes).HasColumnName("DD040_NUM_IMPRESSOES");
                entity.Property(e => e.Dd040NumeroPreco).HasColumnName("DD040_NUMERO_PRECO");
                entity.Property(e => e.Dd040Numeroautorizacao)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_NUMEROAUTORIZACAO");
                entity.Property(e => e.Dd040Nvol)
                    .HasMaxLength(60)
                    .HasColumnName("DD040_NVOL");
                entity.Property(e => e.Dd040OrigemNota)
                    .HasMaxLength(20)
                    .HasColumnName("DD040_ORIGEM_NOTA");
                entity.Property(e => e.Dd040Origemregpv).HasColumnName("DD040_ORIGEMREGPV");
                entity.Property(e => e.Dd040Perc1Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERC1_DESCONTO");
                entity.Property(e => e.Dd040Perc2Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERC2_DESCONTO");
                entity.Property(e => e.Dd040Perc3Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERC3_DESCONTO");
                entity.Property(e => e.Dd040Perc4Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERC4_DESCONTO");
                entity.Property(e => e.Dd040Perc5Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERC5_DESCONTO");
                entity.Property(e => e.Dd040Percdescservico)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD040_PERCDESCSERVICO");
                entity.Property(e => e.Dd040PesoBruto)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("DD040_PESO_BRUTO");
                entity.Property(e => e.Dd040PesoLiquido)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("DD040_PESO_LIQUIDO");
                entity.Property(e => e.Dd040Picmsdesonerado)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD040_PICMSDESONERADO");
                entity.Property(e => e.Dd040PrazoEntrega)
                    .HasMaxLength(50)
                    .HasColumnName("DD040_PRAZO_ENTREGA");
                entity.Property(e => e.Dd040Processo)
                    .HasMaxLength(15)
                    .HasColumnName("DD040_PROCESSO");
                entity.Property(e => e.Dd040Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD040_PROTOCOLNUMBER");
                entity.Property(e => e.Dd040QtdVolumes).HasColumnName("DD040_QTD_VOLUMES");
                entity.Property(e => e.Dd040QtdeParcelas).HasColumnName("DD040_QTDE_PARCELAS");
                entity.Property(e => e.Dd040ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_RESPONSAVEL_ID");
                entity.Property(e => e.Dd040Romaneioid).HasColumnName("DD040_ROMANEIOID");
                entity.Property(e => e.Dd040SatChaveCanc)
                    .HasMaxLength(50)
                    .HasColumnName("DD040_SAT_CHAVE_CANC");
                entity.Property(e => e.Dd040SatNoCfeCanc).HasColumnName("DD040_SAT_NO_CFE_CANC");
                entity.Property(e => e.Dd040SatQrcodeCanc)
                    .HasMaxLength(600)
                    .HasColumnName("DD040_SAT_QRCODE_CANC");
                entity.Property(e => e.Dd040SatSerieCanc)
                    .HasMaxLength(9)
                    .HasColumnName("DD040_SAT_SERIE_CANC");
                entity.Property(e => e.Dd040Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD040_SERIE");
                entity.Property(e => e.Dd040SerieCupom)
                    .HasMaxLength(5)
                    .HasColumnName("DD040_SERIE_CUPOM");
                entity.Property(e => e.Dd040ServCregtrib).HasColumnName("DD040_SERV_CREGTRIB");
                entity.Property(e => e.Dd040ServDcompet).HasColumnName("DD040_SERV_DCOMPET");
                entity.Property(e => e.Dd040ServVbc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VBC");
                entity.Property(e => e.Dd040ServVcofins)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VCOFINS");
                entity.Property(e => e.Dd040ServVdesccond)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VDESCCOND");
                entity.Property(e => e.Dd040ServVdescincond)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VDESCINCOND");
                entity.Property(e => e.Dd040ServViss)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VISS");
                entity.Property(e => e.Dd040ServVissret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VISSRET");
                entity.Property(e => e.Dd040ServVoutro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VOUTRO");
                entity.Property(e => e.Dd040ServVpis)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_SERV_VPIS");
                entity.Property(e => e.Dd040SitNfeId).HasColumnName("DD040_SIT_NFE_ID");
                entity.Property(e => e.Dd040Situacao).HasColumnName("DD040_SITUACAO");
                entity.Property(e => e.Dd040StEntregaId).HasColumnName("DD040_ST_ENTREGA_ID");
                entity.Property(e => e.Dd040Status).HasColumnName("DD040_STATUS");
                entity.Property(e => e.Dd040StatusEstoqueId).HasColumnName("DD040_STATUS_ESTOQUE_ID");
                entity.Property(e => e.Dd040Texto)
                    .HasMaxLength(500)
                    .HasColumnName("DD040_TEXTO");
                entity.Property(e => e.Dd040TipoMovimento).HasColumnName("DD040_TIPO_MOVIMENTO");
                entity.Property(e => e.Dd040TiponotaId).HasColumnName("DD040_TIPONOTA_ID");
                entity.Property(e => e.Dd040TotValorAproxImp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOT_VALOR_APROX_IMP");
                entity.Property(e => e.Dd040TotalBruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_BRUTO");
                entity.Property(e => e.Dd040TotalDescsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_DESCSUFRAMA");
                entity.Property(e => e.Dd040TotalFrete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_FRETE");
                entity.Property(e => e.Dd040TotalLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_LIQUIDO");
                entity.Property(e => e.Dd040TotalOutdespesas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_OUTDESPESAS");
                entity.Property(e => e.Dd040TotalSeguro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_SEGURO");
                entity.Property(e => e.Dd040TotalServico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTAL_SERVICO");
                entity.Property(e => e.Dd040TotalprodEServ)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTALPROD_E_SERV");
                entity.Property(e => e.Dd040Totliqservico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_TOTLIQSERVICO");
                entity.Property(e => e.Dd040Tpamb).HasColumnName("DD040_TPAMB");
                entity.Property(e => e.Dd040Tpemis).HasColumnName("DD040_TPEMIS");
                entity.Property(e => e.Dd040Transcomtef).HasColumnName("DD040_TRANSCOMTEF");
                entity.Property(e => e.Dd040Tzd)
                    .HasMaxLength(20)
                    .HasColumnName("DD040_TZD");
                entity.Property(e => e.Dd040Urlqrcode)
                    .HasMaxLength(600)
                    .HasColumnName("DD040_URLQRCODE");
                entity.Property(e => e.Dd040UsuarioAtendenteid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_USUARIO_ATENDENTEID");
                entity.Property(e => e.Dd040UsuarioEntregaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_USUARIO_ENTREGAID");
                entity.Property(e => e.Dd040UsuarioImp)
                    .HasMaxLength(50)
                    .HasColumnName("DD040_USUARIO_IMP");
                entity.Property(e => e.Dd040UsuarioProprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_USUARIO_PROPR_ID");
                entity.Property(e => e.Dd040Usuariofaturistaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_USUARIOFATURISTAID");
                entity.Property(e => e.Dd040Valor1)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_1");
                entity.Property(e => e.Dd040Valor2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_2");
                entity.Property(e => e.Dd040Valor3)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_3");
                entity.Property(e => e.Dd040Valor4)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_4");
                entity.Property(e => e.Dd040Valor5)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_5");
                entity.Property(e => e.Dd040ValorEntrada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VALOR_ENTRADA");
                entity.Property(e => e.Dd040Vbc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VBC");
                entity.Property(e => e.Dd040Vbcst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VBCST");
                entity.Property(e => e.Dd040Vcofins)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VCOFINS");
                entity.Property(e => e.Dd040Vfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VFCP");
                entity.Property(e => e.Dd040Vfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VFCPST");
                entity.Property(e => e.Dd040Vfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VFCPSTRET");
                entity.Property(e => e.Dd040Vfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VFCPUFDEST");
                entity.Property(e => e.Dd040Vicms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VICMS");
                entity.Property(e => e.Dd040Vicmsdeson)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VICMSDESON");
                entity.Property(e => e.Dd040VicmsdesonsubId).HasColumnName("DD040_VICMSDESONSUB_ID");
                entity.Property(e => e.Dd040Vicmsufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VICMSUFDEST");
                entity.Property(e => e.Dd040Vicmsufremet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VICMSUFREMET");
                entity.Property(e => e.Dd040Vii)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VII");
                entity.Property(e => e.Dd040Vipi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VIPI");
                entity.Property(e => e.Dd040Vipidevol)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VIPIDEVOL");
                entity.Property(e => e.Dd040Vlrafinanciar)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VLRAFINANCIAR");
                entity.Property(e => e.Dd040Vlrdescservico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VLRDESCSERVICO");
                entity.Property(e => e.Dd040Vpis)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VPIS");
                entity.Property(e => e.Dd040Vst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD040_VST");
                entity.Property(e => e.Dd040Xjust)
                    .HasMaxLength(256)
                    .HasColumnName("DD040_XJUST");
                entity.Property(e => e.Dd042Chaveacessonfe)
                    .HasMaxLength(50)
                    .HasColumnName("DD042_CHAVEACESSONFE");
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
                entity.Property(e => e.W06b1Qbcmono)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06B_1_QBCMONO");
                entity.Property(e => e.W06c1Qbcmonoreten)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06C_1_QBCMONORETEN");
                entity.Property(e => e.W06cVicmsmono)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06C_VICMSMONO");
                entity.Property(e => e.W06d1Qbcmonoret)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06D_1_QBCMONORET");
                entity.Property(e => e.W06dVicmsmonoreten)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06D_VICMSMONORETEN");
                entity.Property(e => e.W06eVicmsmonoret)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("W06E_VICMSMONORET");

                // CSICP_DD040 -> CSICP_BB001
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavBB001)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040Empresaid)
                    .HasPrincipalKey(b => b.Id);



                // CSICP_DD040 -> CSICP_DD040Tnt
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavDD040Tnt)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040TiponotaId)
                    .HasPrincipalKey(t => t.Id);


                // CSICP_DD040 -> OsusrNnxSpedInDocIcm
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavSpedIcm)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040ModId)
                    .HasPrincipalKey(i => i.Id);

                // CSICP_DD040 -> CSICP_DD909
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavDD909)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040Tpemis)
                    .HasPrincipalKey(d => d.Id);

                // CSICP_DD040 -> CSICP_DD040Ipre
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavDD040Ipre)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040Indpres)
                    .HasPrincipalKey(i => i.Id);

                // CSICP_DD040 -> CSICP_DD041Frete
                modelBuilder.Entity<CSICP_DD040>()
                    .HasOne(e => e.NavDD041Frete)
                    .WithMany()
                    .HasForeignKey(e => e.Dd040Modalidadefrete)
                    .HasPrincipalKey(f => f.Id);
            });

            modelBuilder.Entity<CSICP_DD040Estq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_ESTQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_ESTQ");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD040_ESTQ_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD040Ipre>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_IPRES");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_IPRES");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD040_IPRES_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Indpres)
                    .HasMaxLength(1)
                    .HasColumnName("INDPRES");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD040Nfe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_NFE");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_NFE");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD040_NFE_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD040Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_SIT");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_SIT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD040_SIT_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD040Stent>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_STENT");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_STENT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD040Tnt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD040_TNT");

                entity.ToTable("OSUSR_TEI_CSICP_DD040_TNT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD040_TNT_5LABEL");

                entity.HasIndex(e => e.CsCodg, "OSIDX_OSUSR_TEI_CSICP_DD040_TNT_7CS_CODG");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsCodg).HasColumnName("CS_CODG");
                entity.Property(e => e.Finalidadeemissao)
                    .HasMaxLength(1)
                    .HasColumnName("FINALIDADEEMISSAO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.Tipooperacao).HasColumnName("TIPOOPERACAO");
            });

            modelBuilder.Entity<CSICP_DD041>(entity =>
            {
                entity.HasKey(e => e.Dd041Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD041");

                entity.ToTable("OSUSR_TEI_CSICP_DD041");

                entity.HasIndex(e => new { e.Dd041UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_11DD041_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041PaisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_13DD041_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_14DD041_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041BairroId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_15DD041_BAIRRO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041CidadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_15DD041_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041Tipodocto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_15DD041_TIPODOCTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041Ufveiculo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_15DD041_UFVEICULO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041UfreboqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_18DD041_UFREBOQUE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_21DD041_MODALIDADEFRETE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041UserOperadorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_22DD041_USER_OPERADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd041TransportadoraId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_23DD041_TRANSPORTADORA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD041_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD041_9TENANT_ID");

                entity.Property(e => e.Dd041Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd041BairroId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_BAIRRO_ID");
                entity.Property(e => e.Dd041Balsa)
                    .HasMaxLength(20)
                    .HasColumnName("DD041_BALSA");
                entity.Property(e => e.Dd041Cep).HasColumnName("DD041_CEP");
                entity.Property(e => e.Dd041CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_CIDADE_ID");
                entity.Property(e => e.Dd041CnpjCpf)
                    .HasMaxLength(15)
                    .HasColumnName("DD041_CNPJ_CPF");
                entity.Property(e => e.Dd041Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD041_COMPLEMENTO");
                entity.Property(e => e.Dd041ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_CONTA_ID");
                entity.Property(e => e.Dd041DataCaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("DD041_DATA_CAIXA");
                entity.Property(e => e.Dd041Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD041_EMAIL");
                entity.Property(e => e.Dd041EnderecoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_ENDERECO_ID");
                entity.Property(e => e.Dd041IdentEstrangeiro)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_IDENT_ESTRANGEIRO");
                entity.Property(e => e.Dd041IeRg)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD041_IE_RG");
                entity.Property(e => e.Dd041Indfinal)
                    .HasMaxLength(1)
                    .HasColumnName("DD041_INDFINAL");
                entity.Property(e => e.Dd041Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD041_LOGRADOURO");
                entity.Property(e => e.Dd041Marcaveiculo)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_MARCAVEICULO");
                entity.Property(e => e.Dd041Modalidadefrete).HasColumnName("DD041_MODALIDADEFRETE");
                entity.Property(e => e.Dd041Nome)
                    .HasMaxLength(100)
                    .HasColumnName("DD041_NOME");
                entity.Property(e => e.Dd041Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_NOMEBAIRRO");
                entity.Property(e => e.Dd041Nometransp)
                    .HasMaxLength(100)
                    .HasColumnName("DD041_NOMETRANSP");
                entity.Property(e => e.Dd041Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD041_NUMERO");
                entity.Property(e => e.Dd041Numtransp)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_NUMTRANSP");
                entity.Property(e => e.Dd041Numtranspreboq)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_NUMTRANSPREBOQ");
                entity.Property(e => e.Dd041PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_PAIS_ID");
                entity.Property(e => e.Dd041Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD041_PERIMETRO");
                entity.Property(e => e.Dd041Placareboque)
                    .HasMaxLength(1050)
                    .HasColumnName("DD041_PLACAREBOQUE");
                entity.Property(e => e.Dd041Placaveiculo)
                    .HasMaxLength(10)
                    .HasColumnName("DD041_PLACAVEICULO");
                entity.Property(e => e.Dd041SendEmail).HasColumnName("DD041_SEND_EMAIL");
                entity.Property(e => e.Dd041SendSms).HasColumnName("DD041_SEND_SMS");
                entity.Property(e => e.Dd041Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD041_SMS");
                entity.Property(e => e.Dd041Suframa)
                    .HasMaxLength(20)
                    .HasColumnName("DD041_SUFRAMA");
                entity.Property(e => e.Dd041Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD041_TELEFONE");
                entity.Property(e => e.Dd041Tipo).HasColumnName("DD041_TIPO");
                entity.Property(e => e.Dd041Tipodocto).HasColumnName("DD041_TIPODOCTO");
                entity.Property(e => e.Dd041TransportadoraId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_TRANSPORTADORA_ID");
                entity.Property(e => e.Dd041UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_UF_ID");
                entity.Property(e => e.Dd041UfreboqueId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_UFREBOQUE_ID");
                entity.Property(e => e.Dd041Ufveiculo)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_UFVEICULO");
                entity.Property(e => e.Dd041UserOperadorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD041_USER_OPERADOR_ID");
                entity.Property(e => e.Dd041Vagao)
                    .HasMaxLength(50)
                    .HasColumnName("DD041_VAGAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                
                entity.HasOne(e => e.NavBB012Trasportadora).WithMany().HasForeignKey(e => e.Dd041TransportadoraId);
                entity.HasOne(e => e.NavAA025).WithMany().HasForeignKey(e => e.Dd041PaisId);
                entity.HasOne(e => e.NavAA027).WithMany().HasForeignKey(e => e.Dd041UfId);
                entity.HasOne(e => e.NavAA028).WithMany().HasForeignKey(e => e.Dd041CidadeId);
                entity.HasOne(e => e.NavDD041Doc).WithMany().HasForeignKey(e => e.Dd041Tipodocto);
                
                
            });

            modelBuilder.Entity<CSICP_DD041Docto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD041_DOCTO");

                entity.ToTable("OSUSR_TEI_CSICP_DD041_DOCTO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD041_DOCTO_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD041Frete>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD041_FRETE");

                entity.ToTable("OSUSR_TEI_CSICP_DD041_FRETE");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD041_FRETE_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodigoSefaz)
                    .HasMaxLength(1)
                    .HasColumnName("CODIGO_SEFAZ");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD042>(entity =>
            {
                entity.HasKey(e => e.Dd042Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD042");

                entity.ToTable("OSUSR_TEI_CSICP_DD042");

                entity.HasIndex(e => new { e.Dd042Fpagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD042_14DD042_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd042Condicaoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD042_16DD042_CONDICAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd042Administradoraid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD042_22DD042_ADMINISTRADORAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD042_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD042_9TENANT_ID");

                entity.Property(e => e.Dd042Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd042Administradoraid)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ADMINISTRADORAID");
                entity.Property(e => e.Dd042Caut)
                    .HasMaxLength(20)
                    .HasColumnName("DD042_CAUT");
                entity.Property(e => e.Dd042Cautorizadora)
                    .HasMaxLength(50)
                    .HasColumnName("DD042_CAUTORIZADORA");
                entity.Property(e => e.Dd042Cdatacanc)
                    .HasMaxLength(20)
                    .HasColumnName("DD042_CDATACANC");
                entity.Property(e => e.Dd042Cdatamovimento)
                    .HasMaxLength(20)
                    .HasColumnName("DD042_CDATAMOVIMENTO");
                entity.Property(e => e.Dd042Cdoc)
                    .HasMaxLength(20)
                    .HasColumnName("DD042_CDOC");
                entity.Property(e => e.Dd042ChaveVincId)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_CHAVE_VINC_ID");
                entity.Property(e => e.Dd042Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD042_CI");
                entity.Property(e => e.Dd042Cinstituicaoctf)
                    .HasMaxLength(50)
                    .HasColumnName("DD042_CINSTITUICAOCTF");
                entity.Property(e => e.Dd042Cnsu)
                    .HasMaxLength(40)
                    .HasColumnName("DD042_CNSU");
                entity.Property(e => e.Dd042Cnsucanc)
                    .HasMaxLength(40)
                    .HasColumnName("DD042_CNSUCANC");
                entity.Property(e => e.Dd042Cnsuctf)
                    .HasMaxLength(40)
                    .HasColumnName("DD042_CNSUCTF");
                entity.Property(e => e.Dd042Condicaoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_CONDICAOID");
                entity.Property(e => e.Dd042Cpv).HasColumnName("DD042_CPV");
                entity.Property(e => e.Dd042Cvanctf)
                    .HasMaxLength(50)
                    .HasColumnName("DD042_CVANCTF");
                entity.Property(e => e.Dd042DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD042_DATA_MOVIMENTO");
                entity.Property(e => e.Dd042Fatoracresc)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD042_FATORACRESC");
                entity.Property(e => e.Dd042Filial).HasColumnName("DD042_FILIAL");
                entity.Property(e => e.Dd042FormaPagto).HasColumnName("DD042_FORMA_PAGTO");
                entity.Property(e => e.Dd042Fpagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_FPAGTOID");
                entity.Property(e => e.Dd042Nroparcelas).HasColumnName("DD042_NROPARCELAS");
                entity.Property(e => e.Dd042Nrotitulo)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD042_NROTITULO");
                entity.Property(e => e.Dd042Operador).HasColumnName("DD042_OPERADOR");
                entity.Property(e => e.Dd042Perccomissao)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD042_PERCCOMISSAO");
                entity.Property(e => e.Dd042Produtoservico).HasColumnName("DD042_PRODUTOSERVICO");
                entity.Property(e => e.Dd042Qtd).HasColumnName("DD042_QTD");
                entity.Property(e => e.Dd042Regtransferido)
                    .HasMaxLength(1)
                    .HasColumnName("DD042_REGTRANSFERIDO");
                entity.Property(e => e.Dd042RetCompcanc).HasColumnName("DD042_RET_COMPCANC");
                entity.Property(e => e.Dd042RetCompcliente).HasColumnName("DD042_RET_COMPCLIENTE");
                entity.Property(e => e.Dd042RetCompestab).HasColumnName("DD042_RET_COMPESTAB");
                entity.Property(e => e.Dd042Valor1aparcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD042_VALOR_1APARCELA");
                entity.Property(e => e.Dd042ValorPago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD042_VALOR_PAGO");
                entity.Property(e => e.Dd042ValorTotalpago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD042_VALOR_TOTALPAGO");
                entity.Property(e => e.Dd042ValorTroco)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD042_VALOR_TROCO");
                entity.Property(e => e.Dd042Valorcomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD042_VALORCOMISSAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD043>(entity =>
            {
                entity.HasKey(e => e.Dd043Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD043");

                entity.ToTable("OSUSR_TEI_CSICP_DD043");

                entity.HasIndex(e => new { e.Dd042Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD043_8DD042_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD043_9TENANT_ID");

                entity.Property(e => e.Dd043Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD043_ID");
                entity.Property(e => e.Dd042Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD042_ID");
                entity.Property(e => e.Dd043Agencia)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("DD043_AGENCIA");
                entity.Property(e => e.Dd043Banco).HasColumnName("DD043_BANCO");
                entity.Property(e => e.Dd043Cheque).HasColumnName("DD043_CHEQUE");
                entity.Property(e => e.Dd043ChequeTerceiro).HasColumnName("DD043_CHEQUE_TERCEIRO");
                entity.Property(e => e.Dd043Compensacao).HasColumnName("DD043_COMPENSACAO");
                entity.Property(e => e.Dd043Conta)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("DD043_CONTA");
                entity.Property(e => e.Dd043DataVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD043_DATA_VENCTO");
                entity.Property(e => e.Dd043DataVenctoOri)
                    .HasColumnType("datetime")
                    .HasColumnName("DD043_DATA_VENCTO_ORI");
                entity.Property(e => e.Dd043Dvagencia)
                    .HasMaxLength(1)
                    .HasColumnName("DD043_DVAGENCIA");
                entity.Property(e => e.Dd043Dvconta)
                    .HasMaxLength(1)
                    .HasColumnName("DD043_DVCONTA");
                entity.Property(e => e.Dd043NoCartao)
                    .HasMaxLength(16)
                    .HasColumnName("DD043_NO_CARTAO");
                entity.Property(e => e.Dd043Parcela).HasColumnName("DD043_PARCELA");
                entity.Property(e => e.Dd043Rg)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("DD043_RG");
                entity.Property(e => e.Dd043Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD043_TELEFONE");
                entity.Property(e => e.Dd043UsuarioidAltdtvc)
                    .HasMaxLength(36)
                    .HasColumnName("DD043_USUARIOID_ALTDTVC");
                entity.Property(e => e.Dd043ValorParcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD043_VALOR_PARCELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD044>(entity =>
            {
                entity.HasKey(e => e.Dd044Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD044");

                entity.ToTable("OSUSR_TEI_CSICP_DD044");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD044_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD044_9TENANT_ID");

                entity.Property(e => e.Dd044Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD044_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd044Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD044_CI");
                entity.Property(e => e.Dd044DescricaoCompl).HasColumnName("DD044_DESCRICAO_COMPL");
                entity.Property(e => e.Dd044Filial).HasColumnName("DD044_FILIAL");
                entity.Property(e => e.Dd044Tiporegistro).HasColumnName("DD044_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD045>(entity =>
            {
                entity.HasKey(e => e.Dd045Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD045");

                entity.ToTable("OSUSR_TEI_CSICP_DD045");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD045_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD045_9TENANT_ID");

                entity.Property(e => e.Dd045Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD045_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd045DescricaoCompl)
                    .HasMaxLength(60)
                    .HasColumnName("DD045_DESCRICAO_COMPL");
                entity.Property(e => e.Dd045Nomecampo)
                    .HasMaxLength(20)
                    .HasColumnName("DD045_NOMECAMPO");
                entity.Property(e => e.Dd045Tiporegistro).HasColumnName("DD045_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD046>(entity =>
            {
                entity.HasKey(e => e.Dd046Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD046");

                entity.ToTable("OSUSR_TEI_CSICP_DD046");

                entity.HasIndex(e => new { e.Dd046OrigemProcesso, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD046_21DD046_ORIGEM_PROCESSO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD046_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd045Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD046_8DD045_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD046_9TENANT_ID");

                entity.Property(e => e.Dd046Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD046_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd045Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD045_ID");
                entity.Property(e => e.Dd046Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD046_CI");
                entity.Property(e => e.Dd046Filial).HasColumnName("DD046_FILIAL");
                entity.Property(e => e.Dd046NumProcesso)
                    .HasMaxLength(15)
                    .HasColumnName("DD046_NUM_PROCESSO");
                entity.Property(e => e.Dd046OrigemProcesso).HasColumnName("DD046_ORIGEM_PROCESSO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD046Pro>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD046_PRO");

                entity.ToTable("OSUSR_TEI_CSICP_DD046_PRO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD046_PRO_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .HasColumnName("CODIGO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD047>(entity =>
            {
                entity.HasKey(e => e.Dd047Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD047");

                entity.ToTable("OSUSR_TEI_CSICP_DD047");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD047_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd045Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD047_8DD045_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD047_9TENANT_ID");

                entity.Property(e => e.Dd047Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD047_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd045Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD045_ID");
                entity.Property(e => e.Dd047Autenticacao)
                    .HasMaxLength(60)
                    .HasColumnName("DD047_AUTENTICACAO");
                entity.Property(e => e.Dd047Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD047_CI");
                entity.Property(e => e.Dd047CodDocArrec).HasColumnName("DD047_COD_DOC_ARREC");
                entity.Property(e => e.Dd047DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD047_DT_PAGAMENTO");
                entity.Property(e => e.Dd047DtVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD047_DT_VENCIMENTO");
                entity.Property(e => e.Dd047Filial).HasColumnName("DD047_FILIAL");
                entity.Property(e => e.Dd047NumDocArrec)
                    .HasMaxLength(60)
                    .HasColumnName("DD047_NUM_DOC_ARREC");
                entity.Property(e => e.Dd047UfBenef)
                    .HasMaxLength(2)
                    .HasColumnName("DD047_UF_BENEF");
                entity.Property(e => e.Dd047UfBeneficiaria)
                    .HasMaxLength(36)
                    .HasColumnName("DD047_UF_BENEFICIARIA");
                entity.Property(e => e.Dd047ValorDocArrec)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD047_VALOR_DOC_ARREC");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD048>(entity =>
            {
                entity.HasKey(e => e.Dd048Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD048");

                entity.ToTable("OSUSR_TEI_CSICP_DD048");

                entity.HasIndex(e => new { e.Dd048Tipo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD048_10DD048_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd048UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD048_11DD048_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD048_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd045Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD048_8DD045_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD048_9TENANT_ID");

                entity.Property(e => e.Dd048Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD048_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd045Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD045_ID");
                entity.Property(e => e.Dd048Chaveacesso)
                    .HasMaxLength(50)
                    .HasColumnName("DD048_CHAVEACESSO");
                entity.Property(e => e.Dd048Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD048_CI");
                entity.Property(e => e.Dd048Cnpj)
                    .HasMaxLength(15)
                    .HasColumnName("DD048_CNPJ");
                entity.Property(e => e.Dd048DtEmisDocto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD048_DT_EMIS_DOCTO");
                entity.Property(e => e.Dd048Filial).HasColumnName("DD048_FILIAL");
                entity.Property(e => e.Dd048IndEmitente)
                    .HasMaxLength(1)
                    .HasColumnName("DD048_IND_EMITENTE");
                entity.Property(e => e.Dd048IndOperacao)
                    .HasMaxLength(1)
                    .HasColumnName("DD048_IND_OPERACAO");
                entity.Property(e => e.Dd048ModDocFiscal)
                    .HasMaxLength(5)
                    .HasColumnName("DD048_MOD_DOC_FISCAL");
                entity.Property(e => e.Dd048NumDocto)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD048_NUM_DOCTO");
                entity.Property(e => e.Dd048NumEcf)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD048_NUM_ECF");
                entity.Property(e => e.Dd048Participante)
                    .HasMaxLength(15)
                    .HasColumnName("DD048_PARTICIPANTE");
                entity.Property(e => e.Dd048Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD048_SERIE");
                entity.Property(e => e.Dd048SubSerie).HasColumnName("DD048_SUB_SERIE");
                entity.Property(e => e.Dd048Tipo).HasColumnName("DD048_TIPO");
                entity.Property(e => e.Dd048Uf)
                    .HasMaxLength(2)
                    .HasColumnName("DD048_UF");
                entity.Property(e => e.Dd048UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD048_UF_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD048Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD048_TIPO");

                entity.ToTable("OSUSR_TEI_CSICP_DD048_TIPO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD048_TIPO_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD049>(entity =>
            {
                entity.HasKey(e => e.Dd049Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD049");

                entity.ToTable("OSUSR_TEI_CSICP_DD049");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD049_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD049_9TENANT_ID");

                entity.Property(e => e.Dd049Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD049_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd049Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD049_CI");
                entity.Property(e => e.Dd049DtEmisDocto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD049_DT_EMIS_DOCTO");
                entity.Property(e => e.Dd049Filial).HasColumnName("DD049_FILIAL");
                entity.Property(e => e.Dd049ModDocFiscal)
                    .HasMaxLength(2)
                    .HasColumnName("DD049_MOD_DOC_FISCAL");
                entity.Property(e => e.Dd049NumeroCoo).HasColumnName("DD049_NUMERO_COO");
                entity.Property(e => e.Dd049NumeroEcf).HasColumnName("DD049_NUMERO_ECF");
                entity.Property(e => e.Dd049SerieEquip)
                    .HasMaxLength(20)
                    .HasColumnName("DD049_SERIE_EQUIP");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD050>(entity =>
            {
                entity.HasKey(e => e.Dd050Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD050");

                entity.ToTable("OSUSR_TEI_CSICP_DD050");

                entity.HasIndex(e => new { e.Dd050Tipo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD050_10DD050_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd050Usuarioproprietario, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD050_25DD050_USUARIOPROPRIETARIO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD050_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD050_9TENANT_ID");

                entity.Property(e => e.Dd050Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD050_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd050Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD050_CI");
                entity.Property(e => e.Dd050DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD050_DT_INCLUSAO");
                entity.Property(e => e.Dd050Filial).HasColumnName("DD050_FILIAL");
                entity.Property(e => e.Dd050HrInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD050_HR_INCLUSAO");
                entity.Property(e => e.Dd050Motivo)
                    .HasMaxLength(200)
                    .HasColumnName("DD050_MOTIVO");
                entity.Property(e => e.Dd050Tipo).HasColumnName("DD050_TIPO");
                entity.Property(e => e.Dd050Usuarioproprietario)
                    .HasMaxLength(36)
                    .HasColumnName("DD050_USUARIOPROPRIETARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD050Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD050_TIPO");

                entity.ToTable("OSUSR_TEI_CSICP_DD050_TIPO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD050_TIPO_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD051>(entity =>
            {
                entity.HasKey(e => e.Dd051Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD051");

                entity.ToTable("OSUSR_TEI_CSICP_DD051", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD051"));

                entity.HasIndex(e => new { e.Dd051ModId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_12DD051_MOD_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_14DD051_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051SerieId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_14DD051_SERIE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051SenvioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_15DD051_SENVIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051ServicoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_16DD051_SERVICO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051UsuarioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_16DD051_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051TipoenvioId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_18DD051_TIPOENVIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD051_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD051_9TENANT_ID");

                entity.Property(e => e.Dd051Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD051_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd051Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD051_DATAHORA");
                entity.Property(e => e.Dd051EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD051_ESTAB_ID");
                entity.Property(e => e.Dd051ModId).HasColumnName("DD051_MOD_ID");
                entity.Property(e => e.Dd051NronfeFinal).HasColumnName("DD051_NRONFE_FINAL");
                entity.Property(e => e.Dd051NronfeInicio).HasColumnName("DD051_NRONFE_INICIO");
                entity.Property(e => e.Dd051SenvioId).HasColumnName("DD051_SENVIO_ID");
                entity.Property(e => e.Dd051Sequencia).HasColumnName("DD051_SEQUENCIA");
                entity.Property(e => e.Dd051Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD051_SERIE");
                entity.Property(e => e.Dd051SerieId)
                    .HasMaxLength(36)
                    .HasColumnName("DD051_SERIE_ID");
                entity.Property(e => e.Dd051ServicoId).HasColumnName("DD051_SERVICO_ID");
                entity.Property(e => e.Dd051TipoenvioId).HasColumnName("DD051_TIPOENVIO_ID");
                entity.Property(e => e.Dd051UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD051_USUARIO_ID");
                entity.Property(e => e.NfeCstat)
                    .HasMaxLength(5)
                    .HasColumnName("NFE_CSTAT");
                entity.Property(e => e.NfeInutJustificativ)
                    .HasMaxLength(255)
                    .HasColumnName("NFE_INUT_JUSTIFICATIV");
                entity.Property(e => e.NfeNprot)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NPROT");
                entity.Property(e => e.NfeNrec)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("NFE_NREC");
                entity.Property(e => e.NfeXmlEnvio).HasColumnName("NFE_XML_ENVIO");
                entity.Property(e => e.NfeXmlRetorno).HasColumnName("NFE_XML_RETORNO");
                entity.Property(e => e.NfeXmotivo)
                    .HasMaxLength(255)
                    .HasColumnName("NFE_XMOTIVO");
                entity.Property(e => e.NfeXmotivoLongo).HasColumnName("NFE_XMOTIVO_LONGO");
                entity.Property(e => e.Processid).HasColumnName("PROCESSID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD052>(entity =>
            {
                entity.HasKey(e => e.Dd052Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD052");

                entity.ToTable("OSUSR_TEI_CSICP_DD052");

                entity.HasIndex(e => new { e.Dd052TobjetoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD052_16DD052_TOBJETO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD052_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD052_9TENANT_ID");

                entity.Property(e => e.Dd052Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD052_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd052Objeto).HasColumnName("DD052_OBJETO");
                entity.Property(e => e.Dd052Text).HasColumnName("DD052_TEXT");
                entity.Property(e => e.Dd052TobjetoId).HasColumnName("DD052_TOBJETO_ID");
                entity.Property(e => e.Dd052Xml).HasColumnName("DD052_XML");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");




            });

            modelBuilder.Entity<CSICP_DD052Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD052_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD052_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD053>(entity =>
            {
                entity.HasKey(e => e.Dd053Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD053");

                entity.ToTable("OSUSR_TEI_CSICP_DD053");

                entity.HasIndex(e => new { e.Dd040SitNfeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD053_16DD040_SIT_NFE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040NotageradaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD053_19DD040_NOTAGERADA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb001Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD053_8BB001_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD053_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD053_9TENANT_ID");

                entity.Property(e => e.Dd053Id).HasColumnName("DD053_ID");
                entity.Property(e => e.Aa013Id)
                    .HasMaxLength(36)
                    .HasColumnName("AA013_ID");
                entity.Property(e => e.Bb001Id)
                    .HasMaxLength(36)
                    .HasColumnName("BB001_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd040NotageradaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_NOTAGERADA_ID");
                entity.Property(e => e.Dd040SitNfeId).HasColumnName("DD040_SIT_NFE_ID");
                entity.Property(e => e.Dd053Chavenfce)
                    .HasMaxLength(50)
                    .HasColumnName("DD053_CHAVENFCE");
                entity.Property(e => e.Dd053Dh)
                    .HasColumnType("datetime")
                    .HasColumnName("DD053_DH");
                entity.Property(e => e.Dd053Digival)
                    .HasMaxLength(28)
                    .HasColumnName("DD053_DIGIVAL");
                entity.Property(e => e.Dd053NoNf).HasColumnName("DD053_NO_NF");
                entity.Property(e => e.Dd053Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD053_SERIE");
                entity.Property(e => e.Dd053Urlqrcode)
                    .HasMaxLength(600)
                    .HasColumnName("DD053_URLQRCODE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD054>(entity =>
            {
                entity.HasKey(e => e.Dd054Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD054");

                entity.ToTable("OSUSR_TEI_CSICP_DD054");

                entity.HasIndex(e => new { e.Dd053Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD054_8DD053_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD054_9TENANT_ID");

                entity.Property(e => e.Dd054Id).HasColumnName("DD054_ID");
                entity.Property(e => e.Dd053Id).HasColumnName("DD053_ID");
                entity.Property(e => e.Objeto).HasColumnName("OBJETO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD055>(entity =>
            {
                entity.HasKey(e => e.Dd055Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD055");

                entity.ToTable("OSUSR_TEI_CSICP_DD055");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD055_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd055Dh, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD055_8DD055_DH_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD055_9TENANT_ID");

                entity.Property(e => e.Dd055Id).HasColumnName("DD055_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd055Dh)
                    .HasColumnType("datetime")
                    .HasColumnName("DD055_DH");
                entity.Property(e => e.Dd055Tipo).HasColumnName("DD055_TIPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD060>(entity =>
            {
                entity.HasKey(e => e.Dd060Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD060");

                entity.ToTable("OSUSR_TEI_CSICP_DD060", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD060"));

                entity.HasIndex(e => new { e.Dd060UnId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_11DD060_UN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Fpagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_14DD060_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Produtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_15DD060_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060UnSecId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_15DD060_UN_SEC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Baixaestoque, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_18DD060_BAIXAESTOQUE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_18DD060_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Permsaldoneg, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_18DD060_PERMSALDONEG_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060TransacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_18DD060_TRANSACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Controlasaldo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_19DD060_CONTROLASALDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Contsaldolote, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_19DD060_CONTSALDOLOTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Contsaldolocal, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_20DD060_CONTSALDOLOCAL_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060CorSerieMerc, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_20DD060_COR_SERIE_MERC_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_20DD060_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060SaldotransfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_20DD060_SALDOTRANSF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060UsuariovendId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_20DD060_USUARIOVEND_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Condicaopagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_21DD060_CONDICAOPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060SaldovirtualId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_21DD060_SALDOVIRTUAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060RegraaplicadaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_22DD060_REGRAAPLICADA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060StatusestoqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_22DD060_STATUSESTOQUE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_22DD060_VICMSDESONSUB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060UnSecTipoconvId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_24DD060_UN_SEC_TIPOCONV_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD060_9TENANT_ID");

                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd060Almoxtransfsaida).HasColumnName("DD060_ALMOXTRANSFSAIDA");
                entity.Property(e => e.Dd060Ambiente)
                    .HasMaxLength(5)
                    .HasColumnName("DD060_AMBIENTE");
                entity.Property(e => e.Dd060Ambienteid).HasColumnName("DD060_AMBIENTEID");
                entity.Property(e => e.Dd060Baixaestoque).HasColumnName("DD060_BAIXAESTOQUE");
                entity.Property(e => e.Dd060BaseCalcIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_BASE_CALC_ICMS");
                entity.Property(e => e.Dd060BaseCalcIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_BASE_CALC_IPI");
                entity.Property(e => e.Dd060BaseCalcSubst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_BASE_CALC_SUBST");
                entity.Property(e => e.Dd060CashbackPvendaliq)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD060_CASHBACK_PVENDALIQ");
                entity.Property(e => e.Dd060CashbackVpremio)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_CASHBACK_VPREMIO");
                entity.Property(e => e.Dd060CashbackVunvendida)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_CASHBACK_VUNVENDIDA");
                entity.Property(e => e.Dd060Cbenefic)
                    .HasMaxLength(20)
                    .HasColumnName("DD060_CBENEFIC");
                entity.Property(e => e.Dd060Cfop)
                    .HasMaxLength(10)
                    .HasColumnName("DD060_CFOP");
                entity.Property(e => e.Dd060Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD060_CI");
                entity.Property(e => e.Dd060Cicronologicaent)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD060_CICRONOLOGICAENT");
                entity.Property(e => e.Dd060Cicronologicasai)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD060_CICRONOLOGICASAI");
                entity.Property(e => e.Dd060Cnpjfabricante)
                    .HasMaxLength(14)
                    .HasColumnName("DD060_CNPJFABRICANTE");
                entity.Property(e => e.Dd060Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD060_CODBARRASALFA");
                entity.Property(e => e.Dd060CodgColuna)
                    .HasMaxLength(3)
                    .HasColumnName("DD060_CODG_COLUNA");
                entity.Property(e => e.Dd060CodgLinha)
                    .HasMaxLength(3)
                    .HasColumnName("DD060_CODG_LINHA");
                entity.Property(e => e.Dd060CodgTransacao).HasColumnName("DD060_CODG_TRANSACAO");
                entity.Property(e => e.Dd060Codgalmox).HasColumnName("DD060_CODGALMOX");
                entity.Property(e => e.Dd060CodigoBarras)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD060_CODIGO_BARRAS");
                entity.Property(e => e.Dd060CodigoProduto).HasColumnName("DD060_CODIGO_PRODUTO");
                entity.Property(e => e.Dd060CompContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_COMP_CONTA_ID");
                entity.Property(e => e.Dd060Condicaopagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_CONDICAOPAGTOID");
                entity.Property(e => e.Dd060Controlasaldo).HasColumnName("DD060_CONTROLASALDO");
                entity.Property(e => e.Dd060Contsaldograde).HasColumnName("DD060_CONTSALDOGRADE");
                entity.Property(e => e.Dd060Contsaldolocal).HasColumnName("DD060_CONTSALDOLOCAL");
                entity.Property(e => e.Dd060Contsaldolote).HasColumnName("DD060_CONTSALDOLOTE");
                entity.Property(e => e.Dd060CorSerieMerc)
                    .HasMaxLength(200)
                    .HasColumnName("DD060_COR_SERIE_MERC");
                entity.Property(e => e.Dd060Cst)
                    .HasMaxLength(5)
                    .HasColumnName("DD060_CST");
                entity.Property(e => e.Dd060DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD060_DATA_MOVIMENTO");
                entity.Property(e => e.Dd060Descprodsecund)
                    .HasMaxLength(120)
                    .HasColumnName("DD060_DESCPRODSECUND");
                entity.Property(e => e.Dd060Descproduto)
                    .HasMaxLength(120)
                    .HasColumnName("DD060_DESCPRODUTO");
                entity.Property(e => e.Dd060Dpreventrega)
                    .HasColumnType("datetime")
                    .HasColumnName("DD060_DPREVENTREGA");
                entity.Property(e => e.Dd060Dprevmontagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DD060_DPREVMONTAGEM");
                entity.Property(e => e.Dd060Entregar).HasColumnName("DD060_ENTREGAR");
                entity.Property(e => e.Dd060Espessura)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD060_ESPESSURA");
                entity.Property(e => e.Dd060Filial).HasColumnName("DD060_FILIAL");
                entity.Property(e => e.Dd060Filialtransfsaida).HasColumnName("DD060_FILIALTRANSFSAIDA");
                entity.Property(e => e.Dd060Fpagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_FPAGTOID");
                entity.Property(e => e.Dd060Frete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_FRETE");
                entity.Property(e => e.Dd060GeraMinuta).HasColumnName("DD060_GERA_MINUTA");
                entity.Property(e => e.Dd060GeraRequisicao).HasColumnName("DD060_GERA_REQUISICAO");
                entity.Property(e => e.Dd060GeraRequisicaoexterna).HasColumnName("DD060_GERA_REQUISICAOEXTERNA");
                entity.Property(e => e.Dd060Ierelevanteid).HasColumnName("DD060_IERELEVANTEID");
                entity.Property(e => e.Dd060Indtot).HasColumnName("DD060_INDTOT");
                entity.Property(e => e.Dd060Infadprod)
                    .HasMaxLength(500)
                    .HasColumnName("DD060_INFADPROD");
                entity.Property(e => e.Dd060Isentregue).HasColumnName("DD060_ISENTREGUE");
                entity.Property(e => e.Dd060Isfixarcalcimp).HasColumnName("DD060_ISFIXARCALCIMP");
                entity.Property(e => e.Dd060Isinseridopdv).HasColumnName("DD060_ISINSERIDOPDV");
                entity.Property(e => e.Dd060Isservico).HasColumnName("DD060_ISSERVICO");
                entity.Property(e => e.Dd060ItemTrocado).HasColumnName("DD060_ITEM_TROCADO");
                entity.Property(e => e.Dd060Largura)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD060_LARGURA");
                entity.Property(e => e.Dd060Localizacao)
                    .HasMaxLength(20)
                    .HasColumnName("DD060_LOCALIZACAO");
                entity.Property(e => e.Dd060Lote)
                    .HasMaxLength(10)
                    .HasColumnName("DD060_LOTE");
                entity.Property(e => e.Dd060LucroEstimado)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_LUCRO_ESTIMADO");
                entity.Property(e => e.Dd060Mlucro)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DD060_MLUCRO");
                entity.Property(e => e.Dd060Modentregaid).HasColumnName("DD060_MODENTREGAID");
                entity.Property(e => e.Dd060Motdesoneracaoid).HasColumnName("DD060_MOTDESONERACAOID");
                entity.Property(e => e.Dd060Nitemped).HasColumnName("DD060_NITEMPED");
                entity.Property(e => e.Dd060Nomefabricante)
                    .HasMaxLength(150)
                    .HasColumnName("DD060_NOMEFABRICANTE");
                entity.Property(e => e.Dd060Nroprctabela).HasColumnName("DD060_NROPRCTABELA");
                entity.Property(e => e.Dd060Odespesas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_ODESPESAS");
                entity.Property(e => e.Dd060Pacrescimo)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("DD060_PACRESCIMO");
                entity.Property(e => e.Dd060PercDesconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERC_DESCONTO");
                entity.Property(e => e.Dd060PercIcms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERC_ICMS");
                entity.Property(e => e.Dd060PercIpi)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERC_IPI");
                entity.Property(e => e.Dd060PercSubstTrib)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERC_SUBST_TRIB");
                entity.Property(e => e.Dd060Perccomissao)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERCCOMISSAO");
                entity.Property(e => e.Dd060Percreducaobaseicms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD060_PERCREDUCAOBASEICMS");
                entity.Property(e => e.Dd060Permsaldoneg).HasColumnName("DD060_PERMSALDONEG");
                entity.Property(e => e.Dd060Picmsdesonerado)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD060_PICMSDESONERADO");
                entity.Property(e => e.Dd060PrcTabela2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRC_TABELA_2");
                entity.Property(e => e.Dd060PrcVendaOrigin)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRC_VENDA_ORIGIN");
                entity.Property(e => e.Dd060Prccustomedioent)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRCCUSTOMEDIOENT");
                entity.Property(e => e.Dd060PrecoTabela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECO_TABELA");
                entity.Property(e => e.Dd060PrecoUnitario)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECO_UNITARIO");
                entity.Property(e => e.Dd060Precocusto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECOCUSTO");
                entity.Property(e => e.Dd060Precocustomedio)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECOCUSTOMEDIO");
                entity.Property(e => e.Dd060Precocustoreal)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECOCUSTOREAL");
                entity.Property(e => e.Dd060Precoreposicao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_PRECOREPOSICAO");
                entity.Property(e => e.Dd060Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_PRODUTOID");
                entity.Property(e => e.Dd060QtdAnterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_QTD_ANTERIOR");
                entity.Property(e => e.Dd060Quantidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_QUANTIDADE");
                entity.Property(e => e.Dd060RegraaplicadaId).HasColumnName("DD060_REGRAAPLICADA_ID");
                entity.Property(e => e.Dd060RespComprador).HasColumnName("DD060_RESP_COMPRADOR");
                entity.Property(e => e.Dd060RespVendedor).HasColumnName("DD060_RESP_VENDEDOR");
                entity.Property(e => e.Dd060ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_RESPONSAVEL_ID");
                entity.Property(e => e.Dd060Saldoanterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_SALDOANTERIOR");
                entity.Property(e => e.Dd060Saldoatual)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_SALDOATUAL");
                entity.Property(e => e.Dd060Saldoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_SALDOID");
                entity.Property(e => e.Dd060SaldotransfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_SALDOTRANSF_ID");
                entity.Property(e => e.Dd060SaldovirtualId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_SALDOVIRTUAL_ID");
                entity.Property(e => e.Dd060Seguro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_SEGURO");
                entity.Property(e => e.Dd060Sequencia).HasColumnName("DD060_SEQUENCIA");
                entity.Property(e => e.Dd060St2Liquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_ST2_LIQUIDO");
                entity.Property(e => e.Dd060StatusestoqueId).HasColumnName("DD060_STATUSESTOQUE_ID");
                entity.Property(e => e.Dd060SubLote)
                    .HasMaxLength(10)
                    .HasColumnName("DD060_SUB_LOTE");
                entity.Property(e => e.Dd060Tamanho)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD060_TAMANHO");
                entity.Property(e => e.Dd060TotalDescCascata)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_TOTAL_DESC_CASCATA");
                entity.Property(e => e.Dd060TotalDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_TOTAL_DESCONTO");
                entity.Property(e => e.Dd060TotalLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_TOTAL_LIQUIDO");
                entity.Property(e => e.Dd060Totalbruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_TOTALBRUTO");
                entity.Property(e => e.Dd060Totliqproduto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_TOTLIQPRODUTO");
                entity.Property(e => e.Dd060Tpdesc).HasColumnName("DD060_TPDESC");
                entity.Property(e => e.Dd060TransacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_TRANSACAO_ID");
                entity.Property(e => e.Dd060Transferir).HasColumnName("DD060_TRANSFERIR");
                entity.Property(e => e.Dd060UnId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_UN_ID");
                entity.Property(e => e.Dd060UnSec)
                    .HasMaxLength(3)
                    .HasColumnName("DD060_UN_SEC");
                entity.Property(e => e.Dd060UnSecFatorconv)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_UN_SEC_FATORCONV");
                entity.Property(e => e.Dd060UnSecId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_UN_SEC_ID");
                entity.Property(e => e.Dd060UnSecQtde)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_UN_SEC_QTDE");
                entity.Property(e => e.Dd060UnSecTipoconvId).HasColumnName("DD060_UN_SEC_TIPOCONV_ID");
                entity.Property(e => e.Dd060UnSecValor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_UN_SEC_VALOR");
                entity.Property(e => e.Dd060UnSecValorLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_UN_SEC_VALOR_LIQUIDO");
                entity.Property(e => e.Dd060Unidade)
                    .HasMaxLength(3)
                    .HasColumnName("DD060_UNIDADE");
                entity.Property(e => e.Dd060UsuariovendId)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_USUARIOVEND_ID");
                entity.Property(e => e.Dd060Vacrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VACRESCIMO");
                entity.Property(e => e.Dd060ValorAproxImp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALOR_APROX_IMP");
                entity.Property(e => e.Dd060ValorDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALOR_DESCONTO");
                entity.Property(e => e.Dd060ValorIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALOR_ICMS");
                entity.Property(e => e.Dd060ValorIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALOR_IPI");
                entity.Property(e => e.Dd060Valorcomissao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALORCOMISSAO");
                entity.Property(e => e.Dd060Vdesccupom)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VDESCCUPOM");
                entity.Property(e => e.Dd060Vdescsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VDESCSUFRAMA");
                entity.Property(e => e.Dd060Vicmsdesonerado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VICMSDESONERADO");
                entity.Property(e => e.Dd060VicmsdesonsubId).HasColumnName("DD060_VICMSDESONSUB_ID");
                entity.Property(e => e.Dd060VlrDescSt1liq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VLR_DESC_ST1LIQ");
                entity.Property(e => e.Dd060Vlrsubsttribaux)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VLRSUBSTTRIBAUX");
                entity.Property(e => e.Dd060Vlrsubsttribut)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VLRSUBSTTRIBUT");
                entity.Property(e => e.Dd060Xped)
                    .HasMaxLength(15)
                    .HasColumnName("DD060_XPED");
                entity.Property(e => e.Dd08Ismontar).HasColumnName("DD08_ISMONTAR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD060Estq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD060_ESTQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD060_ESTQ");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD060_ESTQ_5LABEL");

                entity.HasIndex(e => e.PdvId, "OSIDX_OSUSR_TEI_CSICP_DD060_ESTQ_6PDV_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.PdvId).HasColumnName("PDV_ID");
            });

            modelBuilder.Entity<CSICP_DD060comb>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD060COMB");

                entity.ToTable("OSUSR_TEI_CSICP_DD060COMB");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060COMB_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD060COMB_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Cuforig)
                    .HasMaxLength(2)
                    .HasColumnName("CUFORIG");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Indimport)
                    .HasMaxLength(1)
                    .HasColumnName("INDIMPORT");
                entity.Property(e => e.Porig)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("PORIG");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD060combla01>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD060COMBLA01");

                entity.ToTable("OSUSR_TEI_CSICP_DD060COMBLA01");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD060COMBLA01_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD060COMBLA01_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.La02Cprodanp)
                    .HasMaxLength(9)
                    .HasColumnName("LA02_CPRODANP");
                entity.Property(e => e.La03Descanp)
                    .HasMaxLength(95)
                    .HasColumnName("LA03_DESCANP");
                entity.Property(e => e.La03aPglp)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("LA03A_PGLP");
                entity.Property(e => e.La03bPgnn)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("LA03B_PGNN");
                entity.Property(e => e.La03cPgni)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("LA03C_PGNI");
                entity.Property(e => e.La03dVpart)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("LA03D_VPART");
                entity.Property(e => e.La04Codif)
                    .HasMaxLength(21)
                    .HasColumnName("LA04_CODIF");
                entity.Property(e => e.La05Qtemp)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("LA05_QTEMP");
                entity.Property(e => e.La06Ufcons)
                    .HasMaxLength(2)
                    .HasColumnName("LA06_UFCONS");
                entity.Property(e => e.La17Pbio)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("LA17_PBIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD061>(entity =>
            {
                entity.HasKey(e => e.Dd061Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD061");

                entity.ToTable("OSUSR_TEI_CSICP_DD061");

                entity.HasIndex(e => new { e.Dd061Produtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_15DD061_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061ImpostoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_16DD061_IMPOSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061Agregasubtribut, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_21DD061_AGREGASUBTRIBUT_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061BaseliqbrutaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_21DD061_BASELIQBRUTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061SomaIpiBaseId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_22DD061_SOMA_IPI_BASE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD061_9TENANT_ID");

                entity.Property(e => e.Dd061Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD061_ID");
                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd061Agregasubtribut).HasColumnName("DD061_AGREGASUBTRIBUT");
                entity.Property(e => e.Dd061Aliquota)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_ALIQUOTA");
                entity.Property(e => e.Dd061BaseCalculo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_BASE_CALCULO");
                entity.Property(e => e.Dd061BaseliqbrutaId).HasColumnName("DD061_BASELIQBRUTA_ID");
                entity.Property(e => e.Dd061Cancelamentos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_CANCELAMENTOS");
                entity.Property(e => e.Dd061Cfop)
                    .HasMaxLength(5)
                    .HasColumnName("DD061_CFOP");
                entity.Property(e => e.Dd061CodgImposto)
                    .HasMaxLength(5)
                    .HasColumnName("DD061_CODG_IMPOSTO");
                entity.Property(e => e.Dd061Codgproduto).HasColumnName("DD061_CODGPRODUTO");
                entity.Property(e => e.Dd061Cst)
                    .HasMaxLength(5)
                    .HasColumnName("DD061_CST");
                entity.Property(e => e.Dd061Descimposto)
                    .HasMaxLength(50)
                    .HasColumnName("DD061_DESCIMPOSTO");
                entity.Property(e => e.Dd061Descontos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_DESCONTOS");
                entity.Property(e => e.Dd061ImpostoId).HasColumnName("DD061_IMPOSTO_ID");
                entity.Property(e => e.Dd061Impostodevol)
                    .HasMaxLength(50)
                    .HasColumnName("DD061_IMPOSTODEVOL");
                entity.Property(e => e.Dd061ImpostoidGeneric)
                    .HasMaxLength(50)
                    .HasColumnName("DD061_IMPOSTOID");
                entity.Property(e => e.Dd061Ipi)
                    .HasMaxLength(50)
                    .HasColumnName("DD061_IPI");
                entity.Property(e => e.Dd061Isento)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_ISENTO");
                entity.Property(e => e.Dd061Lucroestimado)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_LUCROESTIMADO");
                entity.Property(e => e.Dd061Outros)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_OUTROS");
                entity.Property(e => e.Dd061Pcredsn)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PCREDSN");
                entity.Property(e => e.Dd061Pdevol)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD061_PDEVOL");
                entity.Property(e => e.Dd061Pdif)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_PDIF");
                entity.Property(e => e.Dd061Percreducbase)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_PERCREDUCBASE");
                entity.Property(e => e.Dd061Pfcp)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PFCP");
                entity.Property(e => e.Dd061Pfcpst)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PFCPST");
                entity.Property(e => e.Dd061Pfcpstret)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PFCPSTRET");
                entity.Property(e => e.Dd061Pfcpufdest)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PFCPUFDEST");
                entity.Property(e => e.Dd061Picmsefet)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_PICMSEFET");
                entity.Property(e => e.Dd061Picmsinter)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PICMSINTER");
                entity.Property(e => e.Dd061Picmsinterpart)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PICMSINTERPART");
                entity.Property(e => e.Dd061Picmsst)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD061_PICMSST");
                entity.Property(e => e.Dd061Picmsufdest)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD061_PICMSUFDEST");
                entity.Property(e => e.Dd061Predbcefet)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_PREDBCEFET");
                entity.Property(e => e.Dd061Predbcst)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD061_PREDBCST");
                entity.Property(e => e.Dd061Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD061_PRODUTOID");
                entity.Property(e => e.Dd061Pst)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD061_PST");
                entity.Property(e => e.Dd061Psuframa)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD061_PSUFRAMA");
                entity.Property(e => e.Dd061QtdTributada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_QTD_TRIBUTADA");
                entity.Property(e => e.Dd061SomaIpiBaseId).HasColumnName("DD061_SOMA_IPI_BASE_ID");
                entity.Property(e => e.Dd061ValorContabil)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VALOR_CONTABIL");
                entity.Property(e => e.Dd061Valorimposto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VALORIMPOSTO");
                entity.Property(e => e.Dd061Vbcefet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCEFET");
                entity.Property(e => e.Dd061Vbcfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCFCP");
                entity.Property(e => e.Dd061Vbcfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCFCPST");
                entity.Property(e => e.Dd061Vbcfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCFCPSTRET");
                entity.Property(e => e.Dd061Vbcfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCFCPUFDEST");
                entity.Property(e => e.Dd061Vbcst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCST");
                entity.Property(e => e.Dd061Vbcstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCSTRET");
                entity.Property(e => e.Dd061Vbcsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCSUFRAMA");
                entity.Property(e => e.Dd061Vbcufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VBCUFDEST");
                entity.Property(e => e.Dd061Vcredicmssn)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VCREDICMSSN");
                entity.Property(e => e.Dd061Vfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VFCP");
                entity.Property(e => e.Dd061Vfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VFCPST");
                entity.Property(e => e.Dd061Vfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VFCPSTRET");
                entity.Property(e => e.Dd061Vfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VFCPUFDEST");
                entity.Property(e => e.Dd061VicmsDesonerado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMS_DESONERADO");
                entity.Property(e => e.Dd061Vicmsdif)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSDIF");
                entity.Property(e => e.Dd061Vicmsefet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSEFET");
                entity.Property(e => e.Dd061Vicmsop)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSOP");
                entity.Property(e => e.Dd061Vicmsst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSST");
                entity.Property(e => e.Dd061Vicmsstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSSTRET");
                entity.Property(e => e.Dd061Vicmssubstituto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSSUBSTITUTO");
                entity.Property(e => e.Dd061Vicmsufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSUFDEST");
                entity.Property(e => e.Dd061Vicmsufremet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VICMSUFREMET");
                entity.Property(e => e.Dd061Vipidevol)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VIPIDEVOL");
                entity.Property(e => e.Dd061VlrImposto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VLR_IMPOSTO");
                entity.Property(e => e.Dd061VlrUnidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VLR_UNIDADE");
                entity.Property(e => e.Dd061Vltribaux)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VLTRIBAUX");
                entity.Property(e => e.Dd061VpautaIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VPAUTA_ICMS");
                entity.Property(e => e.Dd061Vredbcicms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VREDBCICMS");
                entity.Property(e => e.Dd061Vsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD061_VSUFRAMA");
                entity.Property(e => e.N37aQbcmono)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("N37A_QBCMONO");
                entity.Property(e => e.N38Adremicms)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("N38_ADREMICMS");
                entity.Property(e => e.N39Vicmsmono)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("N39_VICMSMONO");
                entity.Property(e => e.N39aQbcmonoreten)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("N39A_QBCMONORETEN");
                entity.Property(e => e.N40Adremicmsreten)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("N40_ADREMICMSRETEN");
                entity.Property(e => e.N41Vicmsmonoreten)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("N41_VICMSMONORETEN");
                entity.Property(e => e.N41aVicmsmonoop)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("N41A_VICMSMONOOP");
                entity.Property(e => e.N42Pdif)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("N42_PDIF");
                entity.Property(e => e.N43Vicmsmonodif)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("N43_VICMSMONODIF");
                entity.Property(e => e.N43aQbcmonoret)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("N43A_QBCMONORET");
                entity.Property(e => e.N44Adremicmsret)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("N44_ADREMICMSRET");
                entity.Property(e => e.N45Vicmsmonoret)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("N45_VICMSMONORET");
                entity.Property(e => e.N47Predadrem)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("N47_PREDADREM");
                entity.Property(e => e.N48Motredadrem)
                    .HasMaxLength(1)
                    .HasColumnName("N48_MOTREDADREM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD061Cfgimp>(entity =>
            {
                entity.HasKey(e => e.Dd060Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD061_CFGIMP");

                entity.ToTable("OSUSR_TEI_CSICP_DD061_CFGIMP");

                entity.HasIndex(e => new { e.Dd061Bb027bIndpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_20DD061_BB027B_INDPRES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061NatBcCredPis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_21DD061_NAT_BC_CRED_PIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061Bb027bCfgimpId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_22DD061_BB027B_CFGIMP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061NatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_24DD061_NAT_BC_CRED_COFINS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd061Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_27DD061_BB027B_CENQUAD_IPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD061_CFGIMP_9TENANT_ID");

                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd061Bb027CfopId).HasColumnName("DD061_BB027_CFOP_ID");
                entity.Property(e => e.Dd061Bb027Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD061_BB027_ID");
                entity.Property(e => e.Dd061Bb027bAliqInternauf)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD061_BB027B_ALIQ_INTERNAUF");
                entity.Property(e => e.Dd061Bb027bAliquota)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("DD061_BB027B_ALIQUOTA");
                entity.Property(e => e.Dd061Bb027bCenquadIpiId).HasColumnName("DD061_BB027B_CENQUAD_IPI_ID");
                entity.Property(e => e.Dd061Bb027bCfgimpId)
                    .HasMaxLength(36)
                    .HasColumnName("DD061_BB027B_CFGIMP_ID");
                entity.Property(e => e.Dd061Bb027bCfopExcecaoId).HasColumnName("DD061_BB027B_CFOP_EXCECAO_ID");
                entity.Property(e => e.Dd061Bb027bCfopStaticaId).HasColumnName("DD061_BB027B_CFOP_STATICA_ID");
                entity.Property(e => e.Dd061Bb027bClassecontaId).HasColumnName("DD061_BB027B_CLASSECONTA_ID");
                entity.Property(e => e.Dd061Bb027bCodgcst)
                    .HasMaxLength(5)
                    .HasColumnName("DD061_BB027B_CODGCST");
                entity.Property(e => e.Dd061Bb027bCstCofinsId).HasColumnName("DD061_BB027B_CST_COFINS_ID");
                entity.Property(e => e.Dd061Bb027bCstIcmsId).HasColumnName("DD061_BB027B_CST_ICMS_ID");
                entity.Property(e => e.Dd061Bb027bCstIpiId).HasColumnName("DD061_BB027B_CST_IPI_ID");
                entity.Property(e => e.Dd061Bb027bCstPisId).HasColumnName("DD061_BB027B_CST_PIS_ID");
                entity.Property(e => e.Dd061Bb027bIndpres).HasColumnName("DD061_BB027B_INDPRES");
                entity.Property(e => e.Dd061Bb027bInforcofins)
                    .HasMaxLength(200)
                    .HasColumnName("DD061_BB027B_INFORCOFINS");
                entity.Property(e => e.Dd061Bb027bInforipi)
                    .HasMaxLength(200)
                    .HasColumnName("DD061_BB027B_INFORIPI");
                entity.Property(e => e.Dd061Bb027bInfornf)
                    .HasMaxLength(200)
                    .HasColumnName("DD061_BB027B_INFORNF");
                entity.Property(e => e.Dd061Bb027bInforpis)
                    .HasMaxLength(200)
                    .HasColumnName("DD061_BB027B_INFORPIS");
                entity.Property(e => e.Dd061Bb027bModalbcIcmsSt).HasColumnName("DD061_BB027B_MODALBC_ICMS_ST");
                entity.Property(e => e.Dd061Bb027bModbcId).HasColumnName("DD061_BB027B_MODBC_ID");
                entity.Property(e => e.Dd061Bb027bMotdesoneracao).HasColumnName("DD061_BB027B_MOTDESONERACAO");
                entity.Property(e => e.Dd061Bb027bMp255Id).HasColumnName("DD061_BB027B_MP255_ID");
                entity.Property(e => e.Dd061Bb027bOrigemId).HasColumnName("DD061_BB027B_ORIGEM_ID");
                entity.Property(e => e.Dd061Bb027bReducaobase)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("DD061_BB027B_REDUCAOBASE");
                entity.Property(e => e.Dd061Bb027bReducaobcst)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("DD061_BB027B_REDUCAOBCST");
                entity.Property(e => e.Dd061Bb027bRegimeId).HasColumnName("DD061_BB027B_REGIME_ID");
                entity.Property(e => e.Dd061Bb027bUfDestId)
                    .HasMaxLength(36)
                    .HasColumnName("DD061_BB027B_UF_DEST_ID");
                entity.Property(e => e.Dd061NatBcCredCofins).HasColumnName("DD061_NAT_BC_CRED_COFINS");
                entity.Property(e => e.Dd061NatBcCredPis).HasColumnName("DD061_NAT_BC_CRED_PIS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD062>(entity =>
            {
                entity.HasKey(e => e.Dd060Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD062");

                entity.ToTable("OSUSR_TEI_CSICP_DD062");

                entity.HasIndex(e => new { e.Dd062ModalId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD062_14DD062_MODAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd062Ufterceiro, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD062_16DD062_UFTERCEIRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd062TpintermId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD062_17DD062_TPINTERM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd062UfdesembId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD062_17DD062_UFDESEMB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd060Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD062_8DD060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD062_9TENANT_ID");

                entity.Property(e => e.Dd060Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD060_ID");
                entity.Property(e => e.Dd062Cexportador)
                    .HasMaxLength(60)
                    .HasColumnName("DD062_CEXPORTADOR");
                entity.Property(e => e.Dd062Cnpj)
                    .HasMaxLength(14)
                    .HasColumnName("DD062_CNPJ");
                entity.Property(e => e.Dd062DataDi)
                    .HasColumnType("datetime")
                    .HasColumnName("DD062_DATA_DI");
                entity.Property(e => e.Dd062Datadesemb)
                    .HasColumnType("datetime")
                    .HasColumnName("DD062_DATADESEMB");
                entity.Property(e => e.Dd062ModalId).HasColumnName("DD062_MODAL_ID");
                entity.Property(e => e.Dd062NumeroDi)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD062_NUMERO_DI");
                entity.Property(e => e.Dd062Regimedrawback)
                    .HasMaxLength(50)
                    .HasColumnName("DD062_REGIMEDRAWBACK");
                entity.Property(e => e.Dd062TpintermId).HasColumnName("DD062_TPINTERM_ID");
                entity.Property(e => e.Dd062Ufdesemb)
                    .HasMaxLength(2)
                    .HasColumnName("DD062_UFDESEMB");
                entity.Property(e => e.Dd062UfdesembId)
                    .HasMaxLength(36)
                    .HasColumnName("DD062_UFDESEMB_ID");
                entity.Property(e => e.Dd062Ufterceiro)
                    .HasMaxLength(36)
                    .HasColumnName("DD062_UFTERCEIRO");
                entity.Property(e => e.Dd062Vafmm)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD062_VAFMM");
                entity.Property(e => e.Dd062Xlocdesemb)
                    .HasMaxLength(60)
                    .HasColumnName("DD062_XLOCDESEMB");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD062Imp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD062_IMP");

                entity.ToTable("OSUSR_TEI_CSICP_DD062_IMP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codnfe)
                    .HasMaxLength(2)
                    .HasColumnName("CODNFE");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD063>(entity =>
            {
                entity.HasKey(e => e.Dd063Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD063");

                entity.ToTable("OSUSR_TEI_CSICP_DD063");

                entity.HasIndex(e => new { e.Dd062Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD063_8DD062_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD063_9TENANT_ID");

                entity.Property(e => e.Dd063Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD063_ID");
                entity.Property(e => e.Dd062Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD062_ID");
                entity.Property(e => e.Dd063Cfabricante)
                    .HasMaxLength(60)
                    .HasColumnName("DD063_CFABRICANTE");
                entity.Property(e => e.Dd063Nadicao)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD063_NADICAO");
                entity.Property(e => e.Dd063Ndraw)
                    .HasMaxLength(11)
                    .HasColumnName("DD063_NDRAW");
                entity.Property(e => e.Dd063Nitemped).HasColumnName("DD063_NITEMPED");
                entity.Property(e => e.Dd063SequenciaAd).HasColumnName("DD063_SEQUENCIA_AD");
                entity.Property(e => e.Dd063Vdescdi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD063_VDESCDI");
                entity.Property(e => e.Dd063Xped)
                    .HasMaxLength(2)
                    .HasColumnName("DD063_XPED");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD066>(entity =>
            {
                entity.HasKey(e => e.Dd066Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD066");

                entity.ToTable("OSUSR_TEI_CSICP_DD066");

                entity.HasIndex(e => new { e.Dd066Tpobjeto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD066_14DD066_TPOBJETO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd051Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD066_8DD051_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD066_9TENANT_ID");

                entity.Property(e => e.Dd066Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD066_ID");
                entity.Property(e => e.Dd051Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD051_ID");
                entity.Property(e => e.Dd066Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD066_DATAHORA");
                entity.Property(e => e.Dd066Mensagem).HasColumnName("DD066_MENSAGEM");
                entity.Property(e => e.Dd066Objeto).HasColumnName("DD066_OBJETO");
                entity.Property(e => e.Dd066Order).HasColumnName("DD066_ORDER");
                entity.Property(e => e.Dd066Tpobjeto).HasColumnName("DD066_TPOBJETO");
                entity.Property(e => e.Dd066UsuarioId)
                    .HasMaxLength(36)
                    .HasColumnName("DD066_USUARIO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD066Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD066_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD066_TP");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD066_TP_5LABEL");

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
