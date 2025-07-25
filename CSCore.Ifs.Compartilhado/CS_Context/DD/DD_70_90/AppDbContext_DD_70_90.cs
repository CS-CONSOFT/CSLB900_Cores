using CSCore.Domain.CS_Models.CSICP_DD;

using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD070> OsusrTeiCsicpDd070s { get; set; }

        public virtual DbSet<CSICP_DD070040> OsusrTeiCsicpDd070040s { get; set; }

        public virtual DbSet<CSICP_DD070Estq> OsusrTeiCsicpDd070Estqs { get; set; }

        public virtual DbSet<CSICP_DD070Sit> OsusrTeiCsicpDd070Sits { get; set; }

        public virtual DbSet<CSICP_DD070Tpate> OsusrTeiCsicpDd070Tpates { get; set; }

        public virtual DbSet<CSICP_DD070W> OsusrTeiCsicpDd070Ws { get; set; }

        public virtual DbSet<CSICP_DD070Wsstat> OsusrTeiCsicpDd070Wsstats { get; set; }

        public virtual DbSet<CSICP_DD071> OsusrTeiCsicpDd071s { get; set; }

        public virtual DbSet<CSICP_DD072> OsusrTeiCsicpDd072s { get; set; }

        public virtual DbSet<CSICP_DD073> OsusrTeiCsicpDd073s { get; set; }

        public virtual DbSet<CSICP_DD074> OsusrTeiCsicpDd074s { get; set; }

        public virtual DbSet<CSICP_DD075> OsusrTeiCsicpDd075s { get; set; }

        public virtual DbSet<CSICP_DD076> OsusrTeiCsicpDd076s { get; set; }

        public virtual DbSet<CSICP_DD077> OsusrTeiCsicpDd077s { get; set; }

        public virtual DbSet<CSICP_DD078> OsusrTeiCsicpDd078s { get; set; }

        public virtual DbSet<CSICP_DD079> OsusrTeiCsicpDd079s { get; set; }

        public virtual DbSet<CSICP_DD079Evento> OsusrTeiCsicpDd079Eventos { get; set; }

        public virtual DbSet<CSICP_DD080> OsusrTeiCsicpDd080s { get; set; }

        public virtual DbSet<CSICP_DD080Estq> OsusrTeiCsicpDd080Estqs { get; set; }

        public virtual DbSet<CSICP_DD080Regra> OsusrTeiCsicpDd080Regras { get; set; }

        public virtual DbSet<CSICP_DD080comb> OsusrTeiCsicpDd080combs { get; set; }

        public virtual DbSet<CSICP_DD080combla01> OsusrTeiCsicpDd080combla01s { get; set; }

        public virtual DbSet<CSICP_DD081> OsusrTeiCsicpDd081s { get; set; }

        public virtual DbSet<CSICP_DD081Cfgimp> OsusrTeiCsicpDd081Cfgimps { get; set; }

        public virtual DbSet<CSICP_DD082> OsusrTeiCsicpDd082s { get; set; }

        public virtual DbSet<CSICP_DD083> OsusrTeiCsicpDd083s { get; set; }

        public virtual DbSet<CSICP_DD084> OsusrTeiCsicpDd084s { get; set; }

        public virtual DbSet<CSICP_DD084Stat> OsusrTeiCsicpDd084Stats { get; set; }

        public virtual DbSet<CSICP_DD085> OsusrTeiCsicpDd085s { get; set; }

        public virtual DbSet<CSICP_DD085Status> OsusrTeiCsicpDd085Statuses { get; set; }

        public virtual DbSet<CSICP_DD085json> OsusrTeiCsicpDd085jsons { get; set; }

        public virtual DbSet<CSICP_DD086> OsusrTeiCsicpDd086s { get; set; }

        public virtual DbSet<CSICP_DD086Constum> OsusrTeiCsicpDd086Consta { get; set; }

        public virtual DbSet<CSICP_DD086Tpcon> OsusrTeiCsicpDd086Tpcons { get; set; }

        public virtual DbSet<CSICP_DD087> OsusrTeiCsicpDd087s { get; set; }

        public virtual DbSet<CSICP_DD087Lib> OsusrTeiCsicpDd087Libs { get; set; }

        public virtual DbSet<CSICP_DD088> OsusrTeiCsicpDd088s { get; set; }

        public virtual DbSet<CSICP_DD088Tpreg> OsusrTeiCsicpDd088Tpregs { get; set; }

        public virtual DbSet<CSICP_DD089> OsusrTeiCsicpDd089s { get; set; }

        public virtual DbSet<CSICP_DD090> OsusrTeiCsicpDd090s { get; set; }

        public virtual DbSet<CSICP_DD092> OsusrTeiCsicpDd092s { get; set; }

        public virtual DbSet<CSICP_DD092stum> OsusrTeiCsicpDd092sta { get; set; }

        public virtual DbSet<CSICP_DD093> OsusrTeiCsicpDd093s { get; set; }

        partial void OnModelCreating_CSICP_DD_70_90(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD070>(entity =>
            {
                entity.HasKey(e => e.Dd070Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070");

                entity.ToTable("OSUSR_TEI_CSICP_DD070", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD070"));

                entity.HasIndex(e => new { e.Dd070CfnfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_13DD070_CFNF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Indpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_13DD070_INDPRES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_14DD070_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Situacao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_14DD070_SITUACAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040TpnotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD040_TPNOTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070CcustoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_CCUSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Empresaid, e.Dd070DataEmissao, e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_18DD070_DATA_EMISSAO_20DD070_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Empresaid, e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_20DD070_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Empresaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_15DD070_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Romaneioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_16DD070_ROMANEIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Arquitetoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_17DD070_ARQUITETOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070AvalistaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_17DD070_AVALISTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070ContarealId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_CONTAREAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070DataEmissao, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_DATA_EMISSAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Keyecommerce, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_18DD070_KEYECOMMERCE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070AgcobradorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_AGCOBRADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Chavecashback, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_CHAVECASHBACK_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070CompContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_COMP_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070CondPagtoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_COND_PAGTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Statusestoque, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_19DD070_STATUSESTOQUE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070ClassecontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_CLASSECONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070NatoperacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_NATOPERACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_20DD070_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070AlmoxdestinoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_21DD070_ALMOXDESTINO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_21DD070_MODALIDADEFRETE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070UsuarioProprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_22DD070_USUARIO_PROPR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_22DD070_VICMSDESONSUB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070TipoatendimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_24DD070_TIPOATENDIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070UsuarioAtendenteid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_25DD070_USUARIO_ATENDENTEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD070_9TENANT_ID");

                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd0070IsPvResultante).HasColumnName("DD0070_IS_PV_RESULTANTE");
                entity.Property(e => e.Dd040TpnotaId).HasColumnName("DD040_TPNOTA_ID");
                entity.Property(e => e.Dd070Acrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_ACRESCIMO");
                entity.Property(e => e.Dd070AgcobradorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_AGCOBRADOR_ID");
                entity.Property(e => e.Dd070AlmoxdestinoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ALMOXDESTINO_ID");
                entity.Property(e => e.Dd070Arquitetoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ARQUITETOID");
                entity.Property(e => e.Dd070Arredondamento)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_ARREDONDAMENTO");
                entity.Property(e => e.Dd070AvalistaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_AVALISTA_ID");
                entity.Property(e => e.Dd070CcustoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_CCUSTO_ID");
                entity.Property(e => e.Dd070CfnfId).HasColumnName("DD070_CFNF_ID");
                entity.Property(e => e.Dd070Chavecashback)
                    .HasMaxLength(10)
                    .HasColumnName("DD070_CHAVECASHBACK");
                entity.Property(e => e.Dd070CiOrcamento)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD070_CI_ORCAMENTO");
                entity.Property(e => e.Dd070ClassecontaId).HasColumnName("DD070_CLASSECONTA_ID");
                entity.Property(e => e.Dd070CnpjMarketplace)
                    .HasMaxLength(14)
                    .HasColumnName("DD070_CNPJ_MARKETPLACE");
                entity.Property(e => e.Dd070Codalmoxdestino).HasColumnName("DD070_CODALMOXDESTINO");
                entity.Property(e => e.Dd070CodgAgcobrador).HasColumnName("DD070_CODG_AGCOBRADOR");
                entity.Property(e => e.Dd070CodgAtendente).HasColumnName("DD070_CODG_ATENDENTE");
                entity.Property(e => e.Dd070CodgCcusto).HasColumnName("DD070_CODG_CCUSTO");
                entity.Property(e => e.Dd070CodgCondPagto).HasColumnName("DD070_CODG_COND_PAGTO");
                entity.Property(e => e.Dd070Codnatoperacao)
                    .HasMaxLength(10)
                    .HasColumnName("DD070_CODNATOPERACAO");
                entity.Property(e => e.Dd070Codrespcomprador).HasColumnName("DD070_CODRESPCOMPRADOR");
                entity.Property(e => e.Dd070Codrespvendedor).HasColumnName("DD070_CODRESPVENDEDOR");
                entity.Property(e => e.Dd070Codtabelapreco)
                    .HasMaxLength(7)
                    .HasColumnName("DD070_CODTABELAPRECO");
                entity.Property(e => e.Dd070Comissao).HasColumnName("DD070_COMISSAO");
                entity.Property(e => e.Dd070CompContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_COMP_CONTA_ID");
                entity.Property(e => e.Dd070CondPagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_COND_PAGTO_ID");
                entity.Property(e => e.Dd070ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_CONTA_ID");
                entity.Property(e => e.Dd070ContarealId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_CONTAREAL_ID");
                entity.Property(e => e.Dd070CtrlSerieNfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_CTRL_SERIE_NF_ID");
                entity.Property(e => e.Dd070DataEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATA_EMISSAO");
                entity.Property(e => e.Dd070DataImpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATA_IMPRESSAO");
                entity.Property(e => e.Dd070DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATA_MOVIMENTO");
                entity.Property(e => e.Dd070DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATA_SAIDA");
                entity.Property(e => e.Dd070Datahoraemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATAHORAEMISSAO");
                entity.Property(e => e.Dd070Datavalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_DATAVALIDADE");
                entity.Property(e => e.Dd070Desconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_DESCONTO");
                entity.Property(e => e.Dd070Empenho)
                    .HasMaxLength(10)
                    .HasColumnName("DD070_EMPENHO");
                entity.Property(e => e.Dd070Empresaid)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_EMPRESAID");
                entity.Property(e => e.Dd070Especie)
                    .HasMaxLength(60)
                    .HasColumnName("DD070_ESPECIE");
                entity.Property(e => e.Dd070Filial).HasColumnName("DD070_FILIAL");
                entity.Property(e => e.Dd070Finnfe)
                    .HasMaxLength(1)
                    .HasColumnName("DD070_FINNFE");
                entity.Property(e => e.Dd070FlagRegra).HasColumnName("DD070_FLAG_REGRA");
                entity.Property(e => e.Dd070FreteCifFob).HasColumnName("DD070_FRETE_CIF_FOB");
                entity.Property(e => e.Dd070HoraImpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_HORA_IMPRESSAO");
                entity.Property(e => e.Dd070HoraSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD070_HORA_SAIDA");
                entity.Property(e => e.Dd070Indpres).HasColumnName("DD070_INDPRES");
                entity.Property(e => e.Dd070Isaprovacao).HasColumnName("DD070_ISAPROVACAO");
                entity.Property(e => e.Dd070Ismarcado).HasColumnName("DD070_ISMARCADO");
                entity.Property(e => e.Dd070Isorigemcotacao).HasColumnName("DD070_ISORIGEMCOTACAO");
                entity.Property(e => e.Dd070Isromdiverg).HasColumnName("DD070_ISROMDIVERG");
                entity.Property(e => e.Dd070Isvendacasada).HasColumnName("DD070_ISVENDACASADA");
                entity.Property(e => e.Dd070Keyecommerce)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_KEYECOMMERCE");
                entity.Property(e => e.Dd070Marca)
                    .HasMaxLength(60)
                    .HasColumnName("DD070_MARCA");
                entity.Property(e => e.Dd070Marketplace)
                    .HasMaxLength(60)
                    .HasColumnName("DD070_MARKETPLACE");
                entity.Property(e => e.Dd070Modalidadefrete).HasColumnName("DD070_MODALIDADEFRETE");
                entity.Property(e => e.Dd070Motdesoneracaoid).HasColumnName("DD070_MOTDESONERACAOID");
                entity.Property(e => e.Dd070Natop)
                    .HasMaxLength(60)
                    .HasColumnName("DD070_NATOP");
                entity.Property(e => e.Dd070NatoperacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_NATOPERACAO_ID");
                entity.Property(e => e.Dd070NoCupom).HasColumnName("DD070_NO_CUPOM");
                entity.Property(e => e.Dd070NoEstacao).HasColumnName("DD070_NO_ESTACAO");
                entity.Property(e => e.Dd070NoNf).HasColumnName("DD070_NO_NF");
                entity.Property(e => e.Dd070NoPdv).HasColumnName("DD070_NO_PDV");
                entity.Property(e => e.Dd070NoPedido).HasColumnName("DD070_NO_PEDIDO");
                entity.Property(e => e.Dd070NoRequisicao)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD070_NO_REQUISICAO");
                entity.Property(e => e.Dd070NroContrato)
                    .HasMaxLength(50)
                    .HasColumnName("DD070_NRO_CONTRATO");
                entity.Property(e => e.Dd070NroPvDav)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD070_NRO_PV_DAV");
                entity.Property(e => e.Dd070NroRomaneio)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD070_NRO_ROMANEIO");
                entity.Property(e => e.Dd070NumImpressoes).HasColumnName("DD070_NUM_IMPRESSOES");
                entity.Property(e => e.Dd070NumeroPreco).HasColumnName("DD070_NUMERO_PRECO");
                entity.Property(e => e.Dd070Nvol)
                    .HasMaxLength(60)
                    .HasColumnName("DD070_NVOL");
                entity.Property(e => e.Dd070Origemregpv).HasColumnName("DD070_ORIGEMREGPV");
                entity.Property(e => e.Dd070Perc1Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERC1_DESCONTO");
                entity.Property(e => e.Dd070Perc2Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERC2_DESCONTO");
                entity.Property(e => e.Dd070Perc3Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERC3_DESCONTO");
                entity.Property(e => e.Dd070Perc4Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERC4_DESCONTO");
                entity.Property(e => e.Dd070Perc5Desconto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERC5_DESCONTO");
                entity.Property(e => e.Dd070Percdescservico)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD070_PERCDESCSERVICO");
                entity.Property(e => e.Dd070PesoBruto)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("DD070_PESO_BRUTO");
                entity.Property(e => e.Dd070PesoLiquido)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("DD070_PESO_LIQUIDO");
                entity.Property(e => e.Dd070Picmsdesonerado)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD070_PICMSDESONERADO");
                entity.Property(e => e.Dd070PrazoEntrega)
                    .HasMaxLength(50)
                    .HasColumnName("DD070_PRAZO_ENTREGA");
                entity.Property(e => e.Dd070Processo)
                    .HasMaxLength(15)
                    .HasColumnName("DD070_PROCESSO");
                entity.Property(e => e.Dd070Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD070_PROTOCOLNUMBER");
                entity.Property(e => e.Dd070PvGrupadaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_PV_GRUPADA_ID");
                entity.Property(e => e.Dd070QtdVolumes).HasColumnName("DD070_QTD_VOLUMES");
                entity.Property(e => e.Dd070QtdeParcelas).HasColumnName("DD070_QTDE_PARCELAS");
                entity.Property(e => e.Dd070ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_RESPONSAVEL_ID");
                entity.Property(e => e.Dd070Romaneioid).HasColumnName("DD070_ROMANEIOID");
                entity.Property(e => e.Dd070Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD070_SERIE");
                entity.Property(e => e.Dd070SerieCupom)
                    .HasMaxLength(5)
                    .HasColumnName("DD070_SERIE_CUPOM");
                entity.Property(e => e.Dd070ServCregtrib).HasColumnName("DD070_SERV_CREGTRIB");
                entity.Property(e => e.Dd070ServDcompet).HasColumnName("DD070_SERV_DCOMPET");
                entity.Property(e => e.Dd070ServVbc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VBC");
                entity.Property(e => e.Dd070ServVcofins)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VCOFINS");
                entity.Property(e => e.Dd070ServVdesccond)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VDESCCOND");
                entity.Property(e => e.Dd070ServVdescincond)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VDESCINCOND");
                entity.Property(e => e.Dd070ServViss)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VISS");
                entity.Property(e => e.Dd070ServVissret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VISSRET");
                entity.Property(e => e.Dd070ServVoutro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VOUTRO");
                entity.Property(e => e.Dd070ServVpis)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_SERV_VPIS");
                entity.Property(e => e.Dd070Situacao).HasColumnName("DD070_SITUACAO");
                entity.Property(e => e.Dd070Statusestoque).HasColumnName("DD070_STATUSESTOQUE");
                entity.Property(e => e.Dd070Texto)
                    .HasMaxLength(500)
                    .HasColumnName("DD070_TEXTO");
                entity.Property(e => e.Dd070TipoMovimento).HasColumnName("DD070_TIPO_MOVIMENTO");
                entity.Property(e => e.Dd070TipoatendimentoId).HasColumnName("DD070_TIPOATENDIMENTO_ID");
                entity.Property(e => e.Dd070TotValorAproxImp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOT_VALOR_APROX_IMP");
                entity.Property(e => e.Dd070TotalBruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_BRUTO");
                entity.Property(e => e.Dd070TotalDescsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_DESCSUFRAMA");
                entity.Property(e => e.Dd070TotalFrete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_FRETE");
                entity.Property(e => e.Dd070TotalLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_LIQUIDO");
                entity.Property(e => e.Dd070TotalOutdespesas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_OUTDESPESAS");
                entity.Property(e => e.Dd070TotalSeguro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_SEGURO");
                entity.Property(e => e.Dd070TotalServico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTAL_SERVICO");
                entity.Property(e => e.Dd070TotalprodEServ)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTALPROD_E_SERV");
                entity.Property(e => e.Dd070Totliqservico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_TOTLIQSERVICO");
                entity.Property(e => e.Dd070Transcomtef).HasColumnName("DD070_TRANSCOMTEF");
                entity.Property(e => e.Dd070UsuarioAtendenteid)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_USUARIO_ATENDENTEID");
                entity.Property(e => e.Dd070UsuarioImp)
                    .HasMaxLength(50)
                    .HasColumnName("DD070_USUARIO_IMP");
                entity.Property(e => e.Dd070UsuarioProprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_USUARIO_PROPR_ID");
                entity.Property(e => e.Dd070ValorEntrada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VALOR_ENTRADA");
                entity.Property(e => e.Dd070Vbc)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VBC");
                entity.Property(e => e.Dd070Vbcst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VBCST");
                entity.Property(e => e.Dd070Vcofins)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VCOFINS");
                entity.Property(e => e.Dd070Vfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VFCP");
                entity.Property(e => e.Dd070Vfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VFCPST");
                entity.Property(e => e.Dd070Vfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VFCPSTRET");
                entity.Property(e => e.Dd070Vfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VFCPUFDEST");
                entity.Property(e => e.Dd070Vicms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VICMS");
                entity.Property(e => e.Dd070Vicmsdeson)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VICMSDESON");
                entity.Property(e => e.Dd070VicmsdesonsubId).HasColumnName("DD070_VICMSDESONSUB_ID");
                entity.Property(e => e.Dd070Vicmsufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VICMSUFDEST");
                entity.Property(e => e.Dd070Vicmsufremet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VICMSUFREMET");
                entity.Property(e => e.Dd070Vii)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VII");
                entity.Property(e => e.Dd070Vipi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VIPI");
                entity.Property(e => e.Dd070Vipidevol)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VIPIDEVOL");
                entity.Property(e => e.Dd070Vlrafinanciar)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VLRAFINANCIAR");
                entity.Property(e => e.Dd070Vlrdescservico)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VLRDESCSERVICO");
                entity.Property(e => e.Dd070Vpis)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VPIS");
                entity.Property(e => e.Dd070Vst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD070_VST");
                entity.Property(e => e.Processid).HasColumnName("PROCESSID");
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




            });

            modelBuilder.Entity<CSICP_DD070040>(entity =>
            {
                entity.HasKey(e => e.Dd070LinkId).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_040");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_040");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_040_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_040_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Pd010Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_040_8PD010_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD070_040_9TENANT_ID");

                entity.Property(e => e.Dd070LinkId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_LINK_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Pd010Id)
                    .HasMaxLength(36)
                    .HasColumnName("PD010_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD070Estq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_ESTQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_ESTQ");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD070_ESTQ_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD070Sit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_SIT");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_SIT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD070_SIT_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD070Tpate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_TPATE");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_TPATE");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD070_TPATE_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD070W>(entity =>
            {
                entity.HasKey(e => e.Dd070Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_WS");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_WS");

                entity.HasIndex(e => new { e.Dd070StatId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_WS_13DD070_STAT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070ControleId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_WS_17DD070_CONTROLE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD070_WS_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD070_WS_9TENANT_ID");

                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd070ControleId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_CONTROLE_ID");
                entity.Property(e => e.Dd070Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD070_PROTOCOLNUMBER");
                entity.Property(e => e.Dd070StatId).HasColumnName("DD070_STAT_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Dd070).WithOne(p => p.OsusrTeiCsicpDd070W)
                    .HasForeignKey<CSICP_DD070W>(d => d.Dd070Id)
                    .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD070_WS_OSUSR_TEI_CSICP_DD070_DD070_ID");


            });

            modelBuilder.Entity<CSICP_DD070Wsstat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD070_WSSTAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD070_WSSTAT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD070_WSSTAT_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD071>(entity =>
            {
                entity.HasKey(e => e.Dd071Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD071");

                entity.ToTable("OSUSR_TEI_CSICP_DD071");

                entity.HasIndex(e => new { e.Dd071UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_11DD071_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071PaisId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_13DD071_PAIS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071ContaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_14DD071_CONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071CidadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_15DD071_CIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071Tipodocto, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_15DD071_TIPODOCTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071Ufveiculo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_15DD071_UFVEICULO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071UfreboqueId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_18DD071_UFREBOQUE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd071Modalidadefrete, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_21DD071_MODALIDADEFRETE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070UserOperadorId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_22DD070_USER_OPERADOR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD071_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD071_9TENANT_ID");

                entity.Property(e => e.Dd071Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd070SendEmail).HasColumnName("DD070_SEND_EMAIL");
                entity.Property(e => e.Dd070SendSms).HasColumnName("DD070_SEND_SMS");
                entity.Property(e => e.Dd070UserOperadorId)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_USER_OPERADOR_ID");
                entity.Property(e => e.Dd071BairroId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_BAIRRO_ID");
                entity.Property(e => e.Dd071Balsa)
                    .HasMaxLength(20)
                    .HasColumnName("DD071_BALSA");
                entity.Property(e => e.Dd071Cep).HasColumnName("DD071_CEP");
                entity.Property(e => e.Dd071CidadeId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_CIDADE_ID");
                entity.Property(e => e.Dd071CnpjCpf)
                    .HasMaxLength(15)
                    .HasColumnName("DD071_CNPJ_CPF");
                entity.Property(e => e.Dd071Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("DD071_COMPLEMENTO");
                entity.Property(e => e.Dd071ContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_CONTA_ID");
                entity.Property(e => e.Dd071DataCaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("DD071_DATA_CAIXA");
                entity.Property(e => e.Dd071Email)
                    .HasMaxLength(250)
                    .HasColumnName("DD071_EMAIL");
                entity.Property(e => e.Dd071EnderecoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_ENDERECO_ID");
                entity.Property(e => e.Dd071IdentEstrangeiro)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_IDENT_ESTRANGEIRO");
                entity.Property(e => e.Dd071IeRg)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD071_IE_RG");
                entity.Property(e => e.Dd071Indfinal)
                    .HasMaxLength(1)
                    .HasColumnName("DD071_INDFINAL");
                entity.Property(e => e.Dd071Logradouro)
                    .HasMaxLength(100)
                    .HasColumnName("DD071_LOGRADOURO");
                entity.Property(e => e.Dd071Marcaveiculo)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_MARCAVEICULO");
                entity.Property(e => e.Dd071Modalidadefrete).HasColumnName("DD071_MODALIDADEFRETE");
                entity.Property(e => e.Dd071Nome)
                    .HasMaxLength(100)
                    .HasColumnName("DD071_NOME");
                entity.Property(e => e.Dd071Nomebairro)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_NOMEBAIRRO");
                entity.Property(e => e.Dd071Numero)
                    .HasMaxLength(20)
                    .HasColumnName("DD071_NUMERO");
                entity.Property(e => e.Dd071Numtransp)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_NUMTRANSP");
                entity.Property(e => e.Dd071Numtranspreboq)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_NUMTRANSPREBOQ");
                entity.Property(e => e.Dd071PaisId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_PAIS_ID");
                entity.Property(e => e.Dd071Perimetro)
                    .HasMaxLength(100)
                    .HasColumnName("DD071_PERIMETRO");
                entity.Property(e => e.Dd071Placareboque)
                    .HasMaxLength(1050)
                    .HasColumnName("DD071_PLACAREBOQUE");
                entity.Property(e => e.Dd071Placaveiculo)
                    .HasMaxLength(10)
                    .HasColumnName("DD071_PLACAVEICULO");
                entity.Property(e => e.Dd071Sms)
                    .HasMaxLength(20)
                    .HasColumnName("DD071_SMS");
                entity.Property(e => e.Dd071Suframa)
                    .HasMaxLength(20)
                    .HasColumnName("DD071_SUFRAMA");
                entity.Property(e => e.Dd071Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD071_TELEFONE");
                entity.Property(e => e.Dd071Tipo).HasColumnName("DD071_TIPO");
                entity.Property(e => e.Dd071Tipodocto).HasColumnName("DD071_TIPODOCTO");
                entity.Property(e => e.Dd071UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_UF_ID");
                entity.Property(e => e.Dd071UfreboqueId)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_UFREBOQUE_ID");
                entity.Property(e => e.Dd071Ufveiculo)
                    .HasMaxLength(36)
                    .HasColumnName("DD071_UFVEICULO");
                entity.Property(e => e.Dd071Vagao)
                    .HasMaxLength(50)
                    .HasColumnName("DD071_VAGAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD072>(entity =>
            {
                entity.HasKey(e => e.Dd072Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD072");

                entity.ToTable("OSUSR_TEI_CSICP_DD072");

                entity.HasIndex(e => new { e.Dd072Fpagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD072_14DD072_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd072Condicaoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD072_16DD072_CONDICAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd072Administradoraid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD072_22DD072_ADMINISTRADORAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD072_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD072_9TENANT_ID");

                entity.Property(e => e.Dd072Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd072Administradoraid)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_ADMINISTRADORAID");
                entity.Property(e => e.Dd072Caut)
                    .HasMaxLength(20)
                    .HasColumnName("DD072_CAUT");
                entity.Property(e => e.Dd072Cautorizadora)
                    .HasMaxLength(50)
                    .HasColumnName("DD072_CAUTORIZADORA");
                entity.Property(e => e.Dd072Cdatacanc)
                    .HasMaxLength(20)
                    .HasColumnName("DD072_CDATACANC");
                entity.Property(e => e.Dd072Cdatamovimento)
                    .HasMaxLength(20)
                    .HasColumnName("DD072_CDATAMOVIMENTO");
                entity.Property(e => e.Dd072Cdoc)
                    .HasMaxLength(20)
                    .HasColumnName("DD072_CDOC");
                entity.Property(e => e.Dd072ChaveVincId)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_CHAVE_VINC_ID");
                entity.Property(e => e.Dd072Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD072_CI");
                entity.Property(e => e.Dd072Cinstituicaoctf)
                    .HasMaxLength(50)
                    .HasColumnName("DD072_CINSTITUICAOCTF");
                entity.Property(e => e.Dd072Cnsu)
                    .HasMaxLength(40)
                    .HasColumnName("DD072_CNSU");
                entity.Property(e => e.Dd072Cnsucanc)
                    .HasMaxLength(40)
                    .HasColumnName("DD072_CNSUCANC");
                entity.Property(e => e.Dd072Cnsuctf)
                    .HasMaxLength(40)
                    .HasColumnName("DD072_CNSUCTF");
                entity.Property(e => e.Dd072Condicaoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_CONDICAOID");
                entity.Property(e => e.Dd072Cpv).HasColumnName("DD072_CPV");
                entity.Property(e => e.Dd072Cvanctf)
                    .HasMaxLength(50)
                    .HasColumnName("DD072_CVANCTF");
                entity.Property(e => e.Dd072DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD072_DATA_MOVIMENTO");
                entity.Property(e => e.Dd072Fatoracresc)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD072_FATORACRESC");
                entity.Property(e => e.Dd072Filial).HasColumnName("DD072_FILIAL");
                entity.Property(e => e.Dd072FormaPagto).HasColumnName("DD072_FORMA_PAGTO");
                entity.Property(e => e.Dd072Fpagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_FPAGTOID");
                entity.Property(e => e.Dd072Nroparcelas).HasColumnName("DD072_NROPARCELAS");
                entity.Property(e => e.Dd072Operador).HasColumnName("DD072_OPERADOR");
                entity.Property(e => e.Dd072Produtoservico).HasColumnName("DD072_PRODUTOSERVICO");
                entity.Property(e => e.Dd072Qtd).HasColumnName("DD072_QTD");
                entity.Property(e => e.Dd072Regtransferido)
                    .HasMaxLength(1)
                    .HasColumnName("DD072_REGTRANSFERIDO");
                entity.Property(e => e.Dd072RetCompcanc).HasColumnName("DD072_RET_COMPCANC");
                entity.Property(e => e.Dd072RetCompcliente).HasColumnName("DD072_RET_COMPCLIENTE");
                entity.Property(e => e.Dd072RetCompestab).HasColumnName("DD072_RET_COMPESTAB");
                entity.Property(e => e.Dd072Valor1aparcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD072_VALOR_1APARCELA");
                entity.Property(e => e.Dd072ValorPago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD072_VALOR_PAGO");
                entity.Property(e => e.Dd072ValorTotalpago)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD072_VALOR_TOTALPAGO");
                entity.Property(e => e.Dd072ValorTroco)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD072_VALOR_TROCO");
                entity.Property(e => e.Dd072Valordesconto)
                    .HasMaxLength(50)
                    .HasColumnName("DD072_VALORDESCONTO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD073>(entity =>
            {
                entity.HasKey(e => e.Dd073Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD073");

                entity.ToTable("OSUSR_TEI_CSICP_DD073");

                entity.HasIndex(e => new { e.Dd072Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD073_8DD072_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD073_9TENANT_ID");

                entity.Property(e => e.Dd073Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD073_ID");
                entity.Property(e => e.Dd072Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD072_ID");
                entity.Property(e => e.Dd073Agencia)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("DD073_AGENCIA");
                entity.Property(e => e.Dd073Banco).HasColumnName("DD073_BANCO");
                entity.Property(e => e.Dd073Cheque).HasColumnName("DD073_CHEQUE");
                entity.Property(e => e.Dd073ChequeTerceiro).HasColumnName("DD073_CHEQUE_TERCEIRO");
                entity.Property(e => e.Dd073Compensacao).HasColumnName("DD073_COMPENSACAO");
                entity.Property(e => e.Dd073Conta)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("DD073_CONTA");
                entity.Property(e => e.Dd073DataVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD073_DATA_VENCTO");
                entity.Property(e => e.Dd073DataVenctoOri)
                    .HasColumnType("datetime")
                    .HasColumnName("DD073_DATA_VENCTO_ORI");
                entity.Property(e => e.Dd073Dvagencia)
                    .HasMaxLength(1)
                    .HasColumnName("DD073_DVAGENCIA");
                entity.Property(e => e.Dd073Dvconta)
                    .HasMaxLength(1)
                    .HasColumnName("DD073_DVCONTA");
                entity.Property(e => e.Dd073NoCartao)
                    .HasMaxLength(16)
                    .HasColumnName("DD073_NO_CARTAO");
                entity.Property(e => e.Dd073Parcela).HasColumnName("DD073_PARCELA");
                entity.Property(e => e.Dd073Rg)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("DD073_RG");
                entity.Property(e => e.Dd073Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("DD073_TELEFONE");
                entity.Property(e => e.Dd073UsuarioidAltdtvc)
                    .HasMaxLength(36)
                    .HasColumnName("DD073_USUARIOID_ALTDTVC");
                entity.Property(e => e.Dd073ValorParcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD073_VALOR_PARCELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD074>(entity =>
            {
                entity.HasKey(e => e.Dd074Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD074");

                entity.ToTable("OSUSR_TEI_CSICP_DD074");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD074_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD074_9TENANT_ID");

                entity.Property(e => e.Dd074Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD074_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd074DescricaoCompl).HasColumnName("DD074_DESCRICAO_COMPL");
                entity.Property(e => e.Dd074Tiporegistro).HasColumnName("DD074_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD075>(entity =>
            {
                entity.HasKey(e => e.Dd075Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD075");

                entity.ToTable("OSUSR_TEI_CSICP_DD075");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD075_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD075_9TENANT_ID");

                entity.Property(e => e.Dd075Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD075_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd075DescricaoCompl)
                    .HasMaxLength(60)
                    .HasColumnName("DD075_DESCRICAO_COMPL");
                entity.Property(e => e.Dd075Nomecampo)
                    .HasMaxLength(20)
                    .HasColumnName("DD075_NOMECAMPO");
                entity.Property(e => e.Dd075Tiporegistro).HasColumnName("DD075_TIPOREGISTRO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD076>(entity =>
            {
                entity.HasKey(e => e.Dd076Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD076");

                entity.ToTable("OSUSR_TEI_CSICP_DD076");

                entity.HasIndex(e => new { e.Dd076OrigemProcesso, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD076_21DD076_ORIGEM_PROCESSO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD076_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD076_9TENANT_ID");

                entity.Property(e => e.Dd076Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD076_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd076NumProcesso)
                    .HasMaxLength(15)
                    .HasColumnName("DD076_NUM_PROCESSO");
                entity.Property(e => e.Dd076OrigemProcesso).HasColumnName("DD076_ORIGEM_PROCESSO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD077>(entity =>
            {
                entity.HasKey(e => e.Dd077Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD077");

                entity.ToTable("OSUSR_TEI_CSICP_DD077");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD077_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD077_9TENANT_ID");

                entity.Property(e => e.Dd077Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD077_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd077Autenticacao)
                    .HasMaxLength(60)
                    .HasColumnName("DD077_AUTENTICACAO");
                entity.Property(e => e.Dd077CodDocArrec).HasColumnName("DD077_COD_DOC_ARREC");
                entity.Property(e => e.Dd077DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD077_DT_PAGAMENTO");
                entity.Property(e => e.Dd077DtVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD077_DT_VENCIMENTO");
                entity.Property(e => e.Dd077NumDocArrec)
                    .HasMaxLength(60)
                    .HasColumnName("DD077_NUM_DOC_ARREC");
                entity.Property(e => e.Dd077UfBenef)
                    .HasMaxLength(2)
                    .HasColumnName("DD077_UF_BENEF");
                entity.Property(e => e.Dd077UfBeneficiaria)
                    .HasMaxLength(36)
                    .HasColumnName("DD077_UF_BENEFICIARIA");
                entity.Property(e => e.Dd077ValorDocArrec)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD077_VALOR_DOC_ARREC");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD078>(entity =>
            {
                entity.HasKey(e => e.Dd078Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD078");

                entity.ToTable("OSUSR_TEI_CSICP_DD078");

                entity.HasIndex(e => new { e.Dd078Tipo, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD078_10DD078_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd078UfId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD078_11DD078_UF_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd078Chaveacesso, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD078_17DD078_CHAVEACESSO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD078_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd075Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD078_8DD075_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD078_9TENANT_ID");

                entity.Property(e => e.Dd078Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD078_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd075Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD075_ID");
                entity.Property(e => e.Dd078Chaveacesso)
                    .HasMaxLength(50)
                    .HasColumnName("DD078_CHAVEACESSO");
                entity.Property(e => e.Dd078Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD078_CI");
                entity.Property(e => e.Dd078Cnpj)
                    .HasMaxLength(15)
                    .HasColumnName("DD078_CNPJ");
                entity.Property(e => e.Dd078DtEmisDocto)
                    .HasColumnType("datetime")
                    .HasColumnName("DD078_DT_EMIS_DOCTO");
                entity.Property(e => e.Dd078Filial).HasColumnName("DD078_FILIAL");
                entity.Property(e => e.Dd078IndEmitente)
                    .HasMaxLength(1)
                    .HasColumnName("DD078_IND_EMITENTE");
                entity.Property(e => e.Dd078IndOperacao)
                    .HasMaxLength(1)
                    .HasColumnName("DD078_IND_OPERACAO");
                entity.Property(e => e.Dd078ModDocFiscal)
                    .HasMaxLength(5)
                    .HasColumnName("DD078_MOD_DOC_FISCAL");
                entity.Property(e => e.Dd078NumDocto)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD078_NUM_DOCTO");
                entity.Property(e => e.Dd078NumEcf)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD078_NUM_ECF");
                entity.Property(e => e.Dd078Participante)
                    .HasMaxLength(15)
                    .HasColumnName("DD078_PARTICIPANTE");
                entity.Property(e => e.Dd078Serie)
                    .HasMaxLength(9)
                    .HasColumnName("DD078_SERIE");
                entity.Property(e => e.Dd078SubSerie).HasColumnName("DD078_SUB_SERIE");
                entity.Property(e => e.Dd078Tipo).HasColumnName("DD078_TIPO");
                entity.Property(e => e.Dd078Uf)
                    .HasMaxLength(2)
                    .HasColumnName("DD078_UF");
                entity.Property(e => e.Dd078UfId)
                    .HasMaxLength(36)
                    .HasColumnName("DD078_UF_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD079>(entity =>
            {
                entity.HasKey(e => e.Dd079Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD079");

                entity.ToTable("OSUSR_TEI_CSICP_DD079");

                entity.HasIndex(e => new { e.Dd079CaixaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD079_14DD079_CAIXA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd079EventoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD079_15DD079_EVENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd079Usuarioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD079_15DD079_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd079EstacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD079_16DD079_ESTACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD079_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD079_9TENANT_ID");

                entity.Property(e => e.Dd079Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD079_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd079CaixaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD079_CAIXA_ID");
                entity.Property(e => e.Dd079Datacreate)
                    .HasColumnType("datetime")
                    .HasColumnName("DD079_DATACREATE");
                entity.Property(e => e.Dd079EstacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD079_ESTACAO_ID");
                entity.Property(e => e.Dd079EventoId).HasColumnName("DD079_EVENTO_ID");
                entity.Property(e => e.Dd079Nomeevento)
                    .HasMaxLength(50)
                    .HasColumnName("DD079_NOMEEVENTO");
                entity.Property(e => e.Dd079Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("DD079_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD079Evento>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD079_EVENTO");

                entity.ToTable("OSUSR_TEI_CSICP_DD079_EVENTO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD079_EVENTO_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD080>(entity =>
            {
                entity.HasKey(e => e.Dd080Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD080");

                entity.ToTable("OSUSR_TEI_CSICP_DD080", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD080"));

                entity.HasIndex(e => new { e.Dd080UnId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_11DD080_UN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Fpagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_14DD080_FPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Produtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_15DD080_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080UnSecId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_15DD080_UN_SEC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_18DD080_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080TransacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_18DD080_TRANSACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Atendimentoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_19DD080_ATENDIMENTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Regraaplicada, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_19DD080_REGRAAPLICADA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Statusestoque, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_19DD080_STATUSESTOQUE_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080ResponsavelId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_20DD080_RESPONSAVEL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080UsuariovendId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_20DD080_USUARIOVEND_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Condicaopagtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_21DD080_CONDICAOPAGTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080SaldovirtualId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_21DD080_SALDOVIRTUAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080VicmsdesonsubId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_22DD080_VICMSDESONSUB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080UnSecTipoconvId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080_24DD080_UN_SEC_TIPOCONV_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD080_9TENANT_ID");

                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd060Descprodsecund)
                    .HasMaxLength(120)
                    .HasColumnName("DD060_DESCPRODSECUND");
                entity.Property(e => e.Dd060RespComprador).HasColumnName("DD060_RESP_COMPRADOR");
                entity.Property(e => e.Dd060ValorIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD060_VALOR_IPI");
                entity.Property(e => e.Dd080Almoxtransfsaida).HasColumnName("DD080_ALMOXTRANSFSAIDA");
                entity.Property(e => e.Dd080Ambiente)
                    .HasMaxLength(5)
                    .HasColumnName("DD080_AMBIENTE");
                entity.Property(e => e.Dd080Ambienteid).HasColumnName("DD080_AMBIENTEID");
                entity.Property(e => e.Dd080Atendimentoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ATENDIMENTOID");
                entity.Property(e => e.Dd080BaseCalcIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_BASE_CALC_ICMS");
                entity.Property(e => e.Dd080BaseCalcIpi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_BASE_CALC_IPI");
                entity.Property(e => e.Dd080BaseCalcSubst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_BASE_CALC_SUBST");
                entity.Property(e => e.Dd080Cbenefic)
                    .HasMaxLength(20)
                    .HasColumnName("DD080_CBENEFIC");
                entity.Property(e => e.Dd080Cfop)
                    .HasMaxLength(10)
                    .HasColumnName("DD080_CFOP");
                entity.Property(e => e.Dd080Ci)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD080_CI");
                entity.Property(e => e.Dd080Cicronologicaent)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD080_CICRONOLOGICAENT");
                entity.Property(e => e.Dd080Cicronologicasai)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD080_CICRONOLOGICASAI");
                entity.Property(e => e.Dd080Cnpjfabricante)
                    .HasMaxLength(14)
                    .HasColumnName("DD080_CNPJFABRICANTE");
                entity.Property(e => e.Dd080Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasColumnName("DD080_CODBARRASALFA");
                entity.Property(e => e.Dd080CodgColuna)
                    .HasMaxLength(3)
                    .HasColumnName("DD080_CODG_COLUNA");
                entity.Property(e => e.Dd080CodgLinha)
                    .HasMaxLength(3)
                    .HasColumnName("DD080_CODG_LINHA");
                entity.Property(e => e.Dd080CodgTransacao).HasColumnName("DD080_CODG_TRANSACAO");
                entity.Property(e => e.Dd080Codgalmox).HasColumnName("DD080_CODGALMOX");
                entity.Property(e => e.Dd080CodigoBarras)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD080_CODIGO_BARRAS");
                entity.Property(e => e.Dd080CodigoProduto).HasColumnName("DD080_CODIGO_PRODUTO");
                entity.Property(e => e.Dd080CompContaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_COMP_CONTA_ID");
                entity.Property(e => e.Dd080Condicaopagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_CONDICAOPAGTOID");
                entity.Property(e => e.Dd080CorSerieMerc)
                    .HasMaxLength(40)
                    .HasColumnName("DD080_COR_SERIE_MERC");
                entity.Property(e => e.Dd080Cst)
                    .HasMaxLength(5)
                    .HasColumnName("DD080_CST");
                entity.Property(e => e.Dd080DataMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DD080_DATA_MOVIMENTO");
                entity.Property(e => e.Dd080Descproduto)
                    .HasMaxLength(120)
                    .HasColumnName("DD080_DESCPRODUTO");
                entity.Property(e => e.Dd080Dpreventrega)
                    .HasColumnType("datetime")
                    .HasColumnName("DD080_DPREVENTREGA");
                entity.Property(e => e.Dd080Entregar).HasColumnName("DD080_ENTREGAR");
                entity.Property(e => e.Dd080Espessura)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD080_ESPESSURA");
                entity.Property(e => e.Dd080Filial).HasColumnName("DD080_FILIAL");
                entity.Property(e => e.Dd080Filialtransfsaida).HasColumnName("DD080_FILIALTRANSFSAIDA");
                entity.Property(e => e.Dd080Fpagtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_FPAGTOID");
                entity.Property(e => e.Dd080Frete)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_FRETE");
                entity.Property(e => e.Dd080GeraMinuta).HasColumnName("DD080_GERA_MINUTA");
                entity.Property(e => e.Dd080GeraRequisicao).HasColumnName("DD080_GERA_REQUISICAO");
                entity.Property(e => e.Dd080GeraRequisicaoexterna).HasColumnName("DD080_GERA_REQUISICAOEXTERNA");
                entity.Property(e => e.Dd080Ierelevanteid).HasColumnName("DD080_IERELEVANTEID");
                entity.Property(e => e.Dd080Infadprod)
                    .HasMaxLength(500)
                    .HasColumnName("DD080_INFADPROD");
                entity.Property(e => e.Dd080Isfixarcalcimp).HasColumnName("DD080_ISFIXARCALCIMP");
                entity.Property(e => e.Dd080Isinseridopdv).HasColumnName("DD080_ISINSERIDOPDV");
                entity.Property(e => e.Dd080Ismontar).HasColumnName("DD080_ISMONTAR");
                entity.Property(e => e.Dd080Isselecionado).HasColumnName("DD080_ISSELECIONADO");
                entity.Property(e => e.Dd080Isservico).HasColumnName("DD080_ISSERVICO");
                entity.Property(e => e.Dd080ItemTrocado).HasColumnName("DD080_ITEM_TROCADO");
                entity.Property(e => e.Dd080Largura)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD080_LARGURA");
                entity.Property(e => e.Dd080Localizacao)
                    .HasMaxLength(20)
                    .HasColumnName("DD080_LOCALIZACAO");
                entity.Property(e => e.Dd080Lote)
                    .HasMaxLength(10)
                    .HasColumnName("DD080_LOTE");
                entity.Property(e => e.Dd080LucroEstimado)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_LUCRO_ESTIMADO");
                entity.Property(e => e.Dd080Modentregaid).HasColumnName("DD080_MODENTREGAID");
                entity.Property(e => e.Dd080Motdesoneracaoid).HasColumnName("DD080_MOTDESONERACAOID");
                entity.Property(e => e.Dd080Nitemped).HasColumnName("DD080_NITEMPED");
                entity.Property(e => e.Dd080Nomefabricante)
                    .HasMaxLength(150)
                    .HasColumnName("DD080_NOMEFABRICANTE");
                entity.Property(e => e.Dd080Nroprctabela).HasColumnName("DD080_NROPRCTABELA");
                entity.Property(e => e.Dd080Odespesas)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_ODESPESAS");
                entity.Property(e => e.Dd080Pacrescimo)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PACRESCIMO");
                entity.Property(e => e.Dd080PercDescproduto)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PERC_DESCPRODUTO");
                entity.Property(e => e.Dd080PercIcms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PERC_ICMS");
                entity.Property(e => e.Dd080PercIpi)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PERC_IPI");
                entity.Property(e => e.Dd080PercSubstTrib)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PERC_SUBST_TRIB");
                entity.Property(e => e.Dd080Percreducaobaseicms)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD080_PERCREDUCAOBASEICMS");
                entity.Property(e => e.Dd080Picmsdesonerado)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD080_PICMSDESONERADO");
                entity.Property(e => e.Dd080PrcTabela2)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRC_TABELA2");
                entity.Property(e => e.Dd080PrcVendaOrigin)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRC_VENDA_ORIGIN");
                entity.Property(e => e.Dd080Prccustomedioent)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRCCUSTOMEDIOENT");
                entity.Property(e => e.Dd080PrecoTabela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECO_TABELA");
                entity.Property(e => e.Dd080PrecoUnitario)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECO_UNITARIO");
                entity.Property(e => e.Dd080Precocusto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECOCUSTO");
                entity.Property(e => e.Dd080Precocustomedio)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECOCUSTOMEDIO");
                entity.Property(e => e.Dd080Precocustoreal)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECOCUSTOREAL");
                entity.Property(e => e.Dd080Precoreposicao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_PRECOREPOSICAO");
                entity.Property(e => e.Dd080Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_PRODUTOID");
                entity.Property(e => e.Dd080QtdAnterior)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_QTD_ANTERIOR");
                entity.Property(e => e.Dd080Quantidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_QUANTIDADE");
                entity.Property(e => e.Dd080Regraaplicada).HasColumnName("DD080_REGRAAPLICADA");
                entity.Property(e => e.Dd080RespVendedor).HasColumnName("DD080_RESP_VENDEDOR");
                entity.Property(e => e.Dd080ResponsavelId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_RESPONSAVEL_ID");
                entity.Property(e => e.Dd080Saldoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_SALDOID");
                entity.Property(e => e.Dd080SaldovirtualId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_SALDOVIRTUAL_ID");
                entity.Property(e => e.Dd080Seguro)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_SEGURO");
                entity.Property(e => e.Dd080Sequencia).HasColumnName("DD080_SEQUENCIA");
                entity.Property(e => e.Dd080SolicitaNsNegativa).HasColumnName("DD080_SOLICITA_NS_NEGATIVA");
                entity.Property(e => e.Dd080St2Liquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_ST2_LIQUIDO");
                entity.Property(e => e.Dd080Statusestoque).HasColumnName("DD080_STATUSESTOQUE");
                entity.Property(e => e.Dd080SubLote)
                    .HasMaxLength(10)
                    .HasColumnName("DD080_SUB_LOTE");
                entity.Property(e => e.Dd080Tamanho)
                    .HasColumnType("decimal(20, 8)")
                    .HasColumnName("DD080_TAMANHO");
                entity.Property(e => e.Dd080TotalDescCascata)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_TOTAL_DESC_CASCATA");
                entity.Property(e => e.Dd080TotalDesconto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_TOTAL_DESCONTO");
                entity.Property(e => e.Dd080TotalLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_TOTAL_LIQUIDO");
                entity.Property(e => e.Dd080Totalbruto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_TOTALBRUTO");
                entity.Property(e => e.Dd080Totliqproduto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_TOTLIQPRODUTO");
                entity.Property(e => e.Dd080Tpdesc).HasColumnName("DD080_TPDESC");
                entity.Property(e => e.Dd080TransacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_TRANSACAO_ID");
                entity.Property(e => e.Dd080Transferir).HasColumnName("DD080_TRANSFERIR");
                entity.Property(e => e.Dd080UnId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_UN_ID");
                entity.Property(e => e.Dd080UnSec)
                    .HasMaxLength(3)
                    .HasColumnName("DD080_UN_SEC");
                entity.Property(e => e.Dd080UnSecFatorconv)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_UN_SEC_FATORCONV");
                entity.Property(e => e.Dd080UnSecId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_UN_SEC_ID");
                entity.Property(e => e.Dd080UnSecQtde)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_UN_SEC_QTDE");
                entity.Property(e => e.Dd080UnSecTipoconvId).HasColumnName("DD080_UN_SEC_TIPOCONV_ID");
                entity.Property(e => e.Dd080UnSecValor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_UN_SEC_VALOR");
                entity.Property(e => e.Dd080UnSecValorLiquido)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_UN_SEC_VALOR_LIQUIDO");
                entity.Property(e => e.Dd080Unidade)
                    .HasMaxLength(3)
                    .HasColumnName("DD080_UNIDADE");
                entity.Property(e => e.Dd080UsuariovendId)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_USUARIOVEND_ID");
                entity.Property(e => e.Dd080Vacrescimo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VACRESCIMO");
                entity.Property(e => e.Dd080ValorAproxImp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VALOR_APROX_IMP");
                entity.Property(e => e.Dd080ValorDescproduto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VALOR_DESCPRODUTO");
                entity.Property(e => e.Dd080ValorIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VALOR_ICMS");
                entity.Property(e => e.Dd080Vdesccupom)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VDESCCUPOM");
                entity.Property(e => e.Dd080Vdescsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VDESCSUFRAMA");
                entity.Property(e => e.Dd080Vicmsdesonerado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VICMSDESONERADO");
                entity.Property(e => e.Dd080VicmsdesonsubId).HasColumnName("DD080_VICMSDESONSUB_ID");
                entity.Property(e => e.Dd080VlrDescSt1liq)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VLR_DESC_ST1LIQ");
                entity.Property(e => e.Dd080Vlrsubsttribaux)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VLRSUBSTTRIBAUX");
                entity.Property(e => e.Dd080Vlrsubsttribut)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD080_VLRSUBSTTRIBUT");
                entity.Property(e => e.Dd080Xped)
                    .HasMaxLength(15)
                    .HasColumnName("DD080_XPED");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD080Estq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD080_ESTQ");

                entity.ToTable("OSUSR_TEI_CSICP_DD080_ESTQ");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD080_ESTQ_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD080Regra>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD080_REGRAS");

                entity.ToTable("OSUSR_TEI_CSICP_DD080_REGRAS");

                entity.HasIndex(e => e.CsCodginterno, "OSIDX_OSUSR_TEI_CSICP_DD080_REGRAS_14CS_CODGINTERNO");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD080_REGRAS_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsCodginterno)
                    .HasMaxLength(10)
                    .HasColumnName("CS_CODGINTERNO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD080comb>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD080COMB");

                entity.ToTable("OSUSR_TEI_CSICP_DD080COMB");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080COMB_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD080COMB_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Cuforig)
                    .HasMaxLength(2)
                    .HasColumnName("CUFORIG");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Indimport)
                    .HasMaxLength(1)
                    .HasColumnName("INDIMPORT");
                entity.Property(e => e.Porig)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("PORIG");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD080combla01>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD080COMBLA01");

                entity.ToTable("OSUSR_TEI_CSICP_DD080COMBLA01");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD080COMBLA01_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD080COMBLA01_9TENANT_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
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
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("LA05_QTEMP");
                entity.Property(e => e.La06Ufcons)
                    .HasMaxLength(2)
                    .HasColumnName("LA06_UFCONS");
                entity.Property(e => e.La17Pbio)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("LA17_PBIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD081>(entity =>
            {
                entity.HasKey(e => e.Dd081Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD081");

                entity.ToTable("OSUSR_TEI_CSICP_DD081");

                entity.HasIndex(e => new { e.Dd081Produtoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_15DD081_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081ImpostoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_16DD081_IMPOSTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081Agregasubtribut, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_21DD081_AGREGASUBTRIBUT_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081BaseliqbrutaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_21DD081_BASELIQBRUTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081SomaIpiBaseId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_22DD081_SOMA_IPI_BASE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD081_9TENANT_ID");

                entity.Property(e => e.Dd081Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD081_ID");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd081Agregasubtribut).HasColumnName("DD081_AGREGASUBTRIBUT");
                entity.Property(e => e.Dd081Aliquota)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_ALIQUOTA");
                entity.Property(e => e.Dd081BaseCalculo)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_BASE_CALCULO");
                entity.Property(e => e.Dd081BaseliqbrutaId).HasColumnName("DD081_BASELIQBRUTA_ID");
                entity.Property(e => e.Dd081Cancelamentos).HasColumnName("DD081_CANCELAMENTOS");
                entity.Property(e => e.Dd081Cfop)
                    .HasMaxLength(5)
                    .HasColumnName("DD081_CFOP");
                entity.Property(e => e.Dd081CodgImposto)
                    .HasMaxLength(5)
                    .HasColumnName("DD081_CODG_IMPOSTO");
                entity.Property(e => e.Dd081Codgproduto).HasColumnName("DD081_CODGPRODUTO");
                entity.Property(e => e.Dd081Cst)
                    .HasMaxLength(5)
                    .HasColumnName("DD081_CST");
                entity.Property(e => e.Dd081Descimposto)
                    .HasMaxLength(50)
                    .HasColumnName("DD081_DESCIMPOSTO");
                entity.Property(e => e.Dd081Descontos)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_DESCONTOS");
                entity.Property(e => e.Dd081ImpostoId).HasColumnName("DD081_IMPOSTO_ID");
                entity.Property(e => e.Dd081Impostodevol)
                    .HasMaxLength(50)
                    .HasColumnName("DD081_IMPOSTODEVOL");
                entity.Property(e => e.Dd081Impostoid)
                    .HasMaxLength(50)
                    .HasColumnName("DD081_IMPOSTOID");
                entity.Property(e => e.Dd081Ipi)
                    .HasMaxLength(50)
                    .HasColumnName("DD081_IPI");
                entity.Property(e => e.Dd081Isento)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_ISENTO");
                entity.Property(e => e.Dd081Lucroestimado)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_LUCROESTIMADO");
                entity.Property(e => e.Dd081Outros)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_OUTROS");
                entity.Property(e => e.Dd081Pcredsn)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PCREDSN");
                entity.Property(e => e.Dd081Pdevol)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD081_PDEVOL");
                entity.Property(e => e.Dd081Pdif)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_PDIF");
                entity.Property(e => e.Dd081Percreducbase)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_PERCREDUCBASE");
                entity.Property(e => e.Dd081Pfcp)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PFCP");
                entity.Property(e => e.Dd081Pfcpst)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PFCPST");
                entity.Property(e => e.Dd081Pfcpstret)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PFCPSTRET");
                entity.Property(e => e.Dd081Pfcpufdest)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PFCPUFDEST");
                entity.Property(e => e.Dd081Picmsefet)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_PICMSEFET");
                entity.Property(e => e.Dd081Picmsinter)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PICMSINTER");
                entity.Property(e => e.Dd081Picmsinterpart)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PICMSINTERPART");
                entity.Property(e => e.Dd081Picmsst)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD081_PICMSST");
                entity.Property(e => e.Dd081Picmsufdest)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("DD081_PICMSUFDEST");
                entity.Property(e => e.Dd081Predbcefet)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_PREDBCEFET");
                entity.Property(e => e.Dd081Predbcst)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD081_PREDBCST");
                entity.Property(e => e.Dd081Produtoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD081_PRODUTOID");
                entity.Property(e => e.Dd081Pst)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DD081_PST");
                entity.Property(e => e.Dd081Psuframa)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD081_PSUFRAMA");
                entity.Property(e => e.Dd081QtdTributada)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_QTD_TRIBUTADA");
                entity.Property(e => e.Dd081SomaIpiBaseId).HasColumnName("DD081_SOMA_IPI_BASE_ID");
                entity.Property(e => e.Dd081ValorContabil)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VALOR_CONTABIL");
                entity.Property(e => e.Dd081Valorimposto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VALORIMPOSTO");
                entity.Property(e => e.Dd081Vbcefet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCEFET");
                entity.Property(e => e.Dd081Vbcfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCFCP");
                entity.Property(e => e.Dd081Vbcfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCFCPST");
                entity.Property(e => e.Dd081Vbcfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCFCPSTRET");
                entity.Property(e => e.Dd081Vbcfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCFCPUFDEST");
                entity.Property(e => e.Dd081Vbcst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCST");
                entity.Property(e => e.Dd081Vbcstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCSTRET");
                entity.Property(e => e.Dd081Vbcsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCSUFRAMA");
                entity.Property(e => e.Dd081Vbcufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VBCUFDEST");
                entity.Property(e => e.Dd081Vcredicmssn)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VCREDICMSSN");
                entity.Property(e => e.Dd081Vfcp)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VFCP");
                entity.Property(e => e.Dd081Vfcpst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VFCPST");
                entity.Property(e => e.Dd081Vfcpstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VFCPSTRET");
                entity.Property(e => e.Dd081Vfcpufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VFCPUFDEST");
                entity.Property(e => e.Dd081VicmsDesonerado)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMS_DESONERADO");
                entity.Property(e => e.Dd081Vicmsdif)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSDIF");
                entity.Property(e => e.Dd081Vicmsefet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSEFET");
                entity.Property(e => e.Dd081Vicmsop)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSOP");
                entity.Property(e => e.Dd081Vicmsst)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSST");
                entity.Property(e => e.Dd081Vicmsstret)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSSTRET");
                entity.Property(e => e.Dd081Vicmssubstituto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSSUBSTITUTO");
                entity.Property(e => e.Dd081Vicmsufdest)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSUFDEST");
                entity.Property(e => e.Dd081Vicmsufremet)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VICMSUFREMET");
                entity.Property(e => e.Dd081Vipidevol)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VIPIDEVOL");
                entity.Property(e => e.Dd081VlrImposto)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VLR_IMPOSTO");
                entity.Property(e => e.Dd081VlrUnidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VLR_UNIDADE");
                entity.Property(e => e.Dd081Vltribaux)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VLTRIBAUX");
                entity.Property(e => e.Dd081VpautaIcms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VPAUTA_ICMS");
                entity.Property(e => e.Dd081Vredbcicms)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VREDBCICMS");
                entity.Property(e => e.Dd081Vsuframa)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD081_VSUFRAMA");
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

            modelBuilder.Entity<CSICP_DD081Cfgimp>(entity =>
            {
                entity.HasKey(e => e.Dd080Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD081_CFGIMP");

                entity.ToTable("OSUSR_TEI_CSICP_DD081_CFGIMP");

                entity.HasIndex(e => new { e.Dd081Bb027bIndpres, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_20DD081_BB027B_INDPRES_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081NatBcCredPis, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_21DD081_NAT_BC_CRED_PIS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081Bb027bCfgimpId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_22DD081_BB027B_CFGIMP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081NatBcCredCofins, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_24DD081_NAT_BC_CRED_COFINS_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd081Bb027bCenquadIpiId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_27DD081_BB027B_CENQUAD_IPI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD081_CFGIMP_9TENANT_ID");

                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd081Bb027CfopId).HasColumnName("DD081_BB027_CFOP_ID");
                entity.Property(e => e.Dd081Bb027Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD081_BB027_ID");
                entity.Property(e => e.Dd081Bb027bAliqInternauf)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("DD081_BB027B_ALIQ_INTERNAUF");
                entity.Property(e => e.Dd081Bb027bAliquota)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("DD081_BB027B_ALIQUOTA");
                entity.Property(e => e.Dd081Bb027bCenquadIpiId).HasColumnName("DD081_BB027B_CENQUAD_IPI_ID");
                entity.Property(e => e.Dd081Bb027bCfgimpId)
                    .HasMaxLength(36)
                    .HasColumnName("DD081_BB027B_CFGIMP_ID");
                entity.Property(e => e.Dd081Bb027bCfopExcecaoId).HasColumnName("DD081_BB027B_CFOP_EXCECAO_ID");
                entity.Property(e => e.Dd081Bb027bCfopStaticaId).HasColumnName("DD081_BB027B_CFOP_STATICA_ID");
                entity.Property(e => e.Dd081Bb027bClassecontaId).HasColumnName("DD081_BB027B_CLASSECONTA_ID");
                entity.Property(e => e.Dd081Bb027bCodgcst)
                    .HasMaxLength(5)
                    .HasColumnName("DD081_BB027B_CODGCST");
                entity.Property(e => e.Dd081Bb027bCstCofinsId).HasColumnName("DD081_BB027B_CST_COFINS_ID");
                entity.Property(e => e.Dd081Bb027bCstIcmsId).HasColumnName("DD081_BB027B_CST_ICMS_ID");
                entity.Property(e => e.Dd081Bb027bCstIpiId).HasColumnName("DD081_BB027B_CST_IPI_ID");
                entity.Property(e => e.Dd081Bb027bCstPisId).HasColumnName("DD081_BB027B_CST_PIS_ID");
                entity.Property(e => e.Dd081Bb027bIndpres).HasColumnName("DD081_BB027B_INDPRES");
                entity.Property(e => e.Dd081Bb027bInforcofins)
                    .HasMaxLength(200)
                    .HasColumnName("DD081_BB027B_INFORCOFINS");
                entity.Property(e => e.Dd081Bb027bInforipi)
                    .HasMaxLength(200)
                    .HasColumnName("DD081_BB027B_INFORIPI");
                entity.Property(e => e.Dd081Bb027bInfornf)
                    .HasMaxLength(200)
                    .HasColumnName("DD081_BB027B_INFORNF");
                entity.Property(e => e.Dd081Bb027bInforpis)
                    .HasMaxLength(200)
                    .HasColumnName("DD081_BB027B_INFORPIS");
                entity.Property(e => e.Dd081Bb027bModalbcIcmsSt).HasColumnName("DD081_BB027B_MODALBC_ICMS_ST");
                entity.Property(e => e.Dd081Bb027bModbcId).HasColumnName("DD081_BB027B_MODBC_ID");
                entity.Property(e => e.Dd081Bb027bMotdesoneracao).HasColumnName("DD081_BB027B_MOTDESONERACAO");
                entity.Property(e => e.Dd081Bb027bMp255Id).HasColumnName("DD081_BB027B_MP255_ID");
                entity.Property(e => e.Dd081Bb027bOrigemId).HasColumnName("DD081_BB027B_ORIGEM_ID");
                entity.Property(e => e.Dd081Bb027bReducaobase)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("DD081_BB027B_REDUCAOBASE");
                entity.Property(e => e.Dd081Bb027bReducaobcst)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("DD081_BB027B_REDUCAOBCST");
                entity.Property(e => e.Dd081Bb027bRegimeId).HasColumnName("DD081_BB027B_REGIME_ID");
                entity.Property(e => e.Dd081Bb027bUfDestId)
                    .HasMaxLength(36)
                    .HasColumnName("DD081_BB027B_UF_DEST_ID");
                entity.Property(e => e.Dd081NatBcCredCofins).HasColumnName("DD081_NAT_BC_CRED_COFINS");
                entity.Property(e => e.Dd081NatBcCredPis).HasColumnName("DD081_NAT_BC_CRED_PIS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Dd080).WithOne(p => p.OsusrTeiCsicpDd081Cfgimp)
                    .HasForeignKey<CSICP_DD081Cfgimp>(d => d.Dd080Id)
                    .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD081_CFGIMP_OSUSR_TEI_CSICP_DD080_DD080_ID");


            });

            modelBuilder.Entity<CSICP_DD082>(entity =>
            {
                entity.HasKey(e => e.Dd080Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD082");

                entity.ToTable("OSUSR_TEI_CSICP_DD082");

                entity.HasIndex(e => new { e.Dd082ModalId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD082_14DD082_MODAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd082Ufterceiro, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD082_16DD082_UFTERCEIRO_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd082TpintermId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD082_17DD082_TPINTERM_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd082UfdesembId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD082_17DD082_UFDESEMB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD082_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD082_9TENANT_ID");

                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd082Cexportador)
                    .HasMaxLength(60)
                    .HasColumnName("DD082_CEXPORTADOR");
                entity.Property(e => e.Dd082Cnpj)
                    .HasMaxLength(14)
                    .HasColumnName("DD082_CNPJ");
                entity.Property(e => e.Dd082DataDi)
                    .HasColumnType("datetime")
                    .HasColumnName("DD082_DATA_DI");
                entity.Property(e => e.Dd082Datadesemb)
                    .HasColumnType("datetime")
                    .HasColumnName("DD082_DATADESEMB");
                entity.Property(e => e.Dd082ModalId).HasColumnName("DD082_MODAL_ID");
                entity.Property(e => e.Dd082NumeroDi)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD082_NUMERO_DI");
                entity.Property(e => e.Dd082Regimedrawback)
                    .HasMaxLength(50)
                    .HasColumnName("DD082_REGIMEDRAWBACK");
                entity.Property(e => e.Dd082TpintermId).HasColumnName("DD082_TPINTERM_ID");
                entity.Property(e => e.Dd082Ufdesemb)
                    .HasMaxLength(2)
                    .HasColumnName("DD082_UFDESEMB");
                entity.Property(e => e.Dd082UfdesembId)
                    .HasMaxLength(36)
                    .HasColumnName("DD082_UFDESEMB_ID");
                entity.Property(e => e.Dd082Ufterceiro)
                    .HasMaxLength(36)
                    .HasColumnName("DD082_UFTERCEIRO");
                entity.Property(e => e.Dd082Vafmm)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD082_VAFMM");
                entity.Property(e => e.Dd082Xlocdesemb)
                    .HasMaxLength(60)
                    .HasColumnName("DD082_XLOCDESEMB");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Dd080).WithOne(p => p.OsusrTeiCsicpDd082)
                    .HasForeignKey<CSICP_DD082>(d => d.Dd080Id)
                    .HasConstraintName("OSFRK_OSUSR_TEI_CSICP_DD082_OSUSR_TEI_CSICP_DD080_DD080_ID");


            });

            modelBuilder.Entity<CSICP_DD083>(entity =>
            {
                entity.HasKey(e => e.Dd083Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD083");

                entity.ToTable("OSUSR_TEI_CSICP_DD083");

                entity.HasIndex(e => new { e.Dd082Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD083_8DD082_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD083_9TENANT_ID");

                entity.Property(e => e.Dd083Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD083_ID");
                entity.Property(e => e.Dd082Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD082_ID");
                entity.Property(e => e.Dd083Cfabricante)
                    .HasMaxLength(60)
                    .HasColumnName("DD083_CFABRICANTE");
                entity.Property(e => e.Dd083Nadicao)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD083_NADICAO");
                entity.Property(e => e.Dd083Ndraw)
                    .HasMaxLength(11)
                    .HasColumnName("DD083_NDRAW");
                entity.Property(e => e.Dd083Nitemped).HasColumnName("DD083_NITEMPED");
                entity.Property(e => e.Dd083SequenciaAd).HasColumnName("DD083_SEQUENCIA_AD");
                entity.Property(e => e.Dd083Vdescdi)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD083_VDESCDI");
                entity.Property(e => e.Dd083Xped)
                    .HasMaxLength(2)
                    .HasColumnName("DD083_XPED");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD084>(entity =>
            {
                entity.HasKey(e => e.Dd084Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD084");

                entity.ToTable("OSUSR_TEI_CSICP_DD084", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD084"));

                entity.HasIndex(e => new { e.Dd084StatId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD084_13DD084_STAT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd084SaldoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD084_14DD084_SALDO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd084Itemdoatendimento, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD084_24DD084_ITEMDOATENDIMENTO__9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD084_9TENANT_ID");

                entity.Property(e => e.Dd084Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD084_ID");
                entity.Property(e => e.Dd084Itemdoatendimento)
                    .HasMaxLength(36)
                    .HasColumnName("DD084_ITEMDOATENDIMENTO_");
                entity.Property(e => e.Dd084Quantidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD084_QUANTIDADE");
                entity.Property(e => e.Dd084RiId)
                    .HasMaxLength(36)
                    .HasColumnName("DD084_RI_ID");
                entity.Property(e => e.Dd084SaldoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD084_SALDO_ID");
                entity.Property(e => e.Dd084StatId).HasColumnName("DD084_STAT_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD084Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD084_STAT");

                entity.ToTable("OSUSR_TEI_CSICP_DD084_STAT");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD084_STAT_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD085>(entity =>
            {
                entity.HasKey(e => e.Dd085Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD085");

                entity.ToTable("OSUSR_TEI_CSICP_DD085", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD085"));

                entity.HasIndex(e => new { e.Dd085FilialId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085_15DD085_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085StatusId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085_15DD085_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085AtendimentoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085_20DD085_ATENDIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085StatuscontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085_20DD085_STATUSCONTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085SituacaocontaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085_22DD085_SITUACAOCONTA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD085_9TENANT_ID");

                entity.Property(e => e.Dd085Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_ID");
                entity.Property(e => e.Dd085AtendimentoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_ATENDIMENTO_ID");
                entity.Property(e => e.Dd085CiD04)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD085_CI_D04");
                entity.Property(e => e.Dd085CiOrigem)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("DD085_CI_ORIGEM");
                entity.Property(e => e.Dd085Filial).HasColumnName("DD085_FILIAL");
                entity.Property(e => e.Dd085FilialId)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_FILIAL_ID");
                entity.Property(e => e.Dd085LimitecreAnt)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_LIMITECRE_ANT");
                entity.Property(e => e.Dd085Limitecredito)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_LIMITECREDITO");
                entity.Property(e => e.Dd085Limiteparcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_LIMITEPARCELA");
                entity.Property(e => e.Dd085Limporparcelaant)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_LIMPORPARCELAANT");
                entity.Property(e => e.Dd085Novolimcredito)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_NOVOLIMCREDITO");
                entity.Property(e => e.Dd085Novolimporparcela)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_NOVOLIMPORPARCELA");
                entity.Property(e => e.Dd085Observacao)
                    .HasMaxLength(500)
                    .HasColumnName("DD085_OBSERVACAO");
                entity.Property(e => e.Dd085Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD085_PROTOCOLNUMBER");
                entity.Property(e => e.Dd085Saldodevedor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_SALDODEVEDOR");
                entity.Property(e => e.Dd085Saldodisponivel)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_SALDODISPONIVEL");
                entity.Property(e => e.Dd085SituacaocontaId).HasColumnName("DD085_SITUACAOCONTA_ID");
                entity.Property(e => e.Dd085StatusId).HasColumnName("DD085_STATUS_ID");
                entity.Property(e => e.Dd085StatuscontaId).HasColumnName("DD085_STATUSCONTA_ID");
                entity.Property(e => e.Dd085Valorcotacao)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD085_VALORCOTACAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD085Status>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD085_STATUS");

                entity.ToTable("OSUSR_TEI_CSICP_DD085_STATUS");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD085_STATUS_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD085json>(entity =>
            {
                entity.HasKey(e => e.Dd085jsId).HasName("OSPRK_OSUSR_TEI_CSICP_DD085JSON");

                entity.ToTable("OSUSR_TEI_CSICP_DD085JSON");

                entity.HasIndex(e => new { e.Dd085Aprovacaodecreditoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD085JSON_26DD085_APROVACAODECREDITOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD085JSON_9TENANT_ID");

                entity.Property(e => e.Dd085jsId).HasColumnName("DD085JS_ID");
                entity.Property(e => e.Dd085Aprovacaodecreditoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_APROVACAODECREDITOID");
                entity.Property(e => e.Dd085jsJson).HasColumnName("DD085JS_JSON");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD086>(entity =>
            {
                entity.HasKey(e => e.Dd086Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD086");

                entity.ToTable("OSUSR_TEI_CSICP_DD086");

                entity.HasIndex(e => new { e.Dd086SituacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD086_17DD086_SITUACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd086Tipoconsulta, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD086_18DD086_TIPOCONSULTA_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd086Protocolnumber, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD086_20DD086_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd086UsuarioproprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD086_21DD086_USUARIOPROPR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD086_8DD085_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD086_9TENANT_ID");

                entity.Property(e => e.Dd086Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD086_ID");
                entity.Property(e => e.Dd085Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_ID");
                entity.Property(e => e.Dd086Dataconsulta)
                    .HasColumnType("datetime")
                    .HasColumnName("DD086_DATACONSULTA");
                entity.Property(e => e.Dd086Isactive).HasColumnName("DD086_ISACTIVE");
                entity.Property(e => e.Dd086Observacao)
                    .HasMaxLength(50)
                    .HasColumnName("DD086_OBSERVACAO");
                entity.Property(e => e.Dd086Orgaoconsulta)
                    .HasMaxLength(50)
                    .HasColumnName("DD086_ORGAOCONSULTA");
                entity.Property(e => e.Dd086Protocolnumber)
                    .HasMaxLength(36)
                    .HasColumnName("DD086_PROTOCOLNUMBER");
                entity.Property(e => e.Dd086Responsavel)
                    .HasMaxLength(50)
                    .HasColumnName("DD086_RESPONSAVEL");
                entity.Property(e => e.Dd086SituacaoId).HasColumnName("DD086_SITUACAO_ID");
                entity.Property(e => e.Dd086Tipoconsulta).HasColumnName("DD086_TIPOCONSULTA");
                entity.Property(e => e.Dd086UsuarioproprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD086_USUARIOPROPR_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD086Constum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD086_CONSTA");

                entity.ToTable("OSUSR_TEI_CSICP_DD086_CONSTA");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD086_CONSTA_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD086Tpcon>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD086_TPCON");

                entity.ToTable("OSUSR_TEI_CSICP_DD086_TPCON");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD086_TPCON_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD087>(entity =>
            {
                entity.HasKey(e => e.Dd087Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD087");

                entity.ToTable("OSUSR_TEI_CSICP_DD087", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD087"));

                entity.HasIndex(e => new { e.Dd087SituacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD087_17DD087_SITUACAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd087UsuarioproprId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD087_21DD087_USUARIOPROPR_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd085Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD087_8DD085_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD087_9TENANT_ID");

                entity.Property(e => e.Dd087Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD087_ID");
                entity.Property(e => e.Dd085Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD085_ID");
                entity.Property(e => e.Dd087Dataaprovacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DD087_DATAAPROVACAO");
                entity.Property(e => e.Dd087Isactive).HasColumnName("DD087_ISACTIVE");
                entity.Property(e => e.Dd087Observacao)
                    .HasMaxLength(200)
                    .HasColumnName("DD087_OBSERVACAO");
                entity.Property(e => e.Dd087Protocolnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DD087_PROTOCOLNUMBER");
                entity.Property(e => e.Dd087SituacaoId).HasColumnName("DD087_SITUACAO_ID");
                entity.Property(e => e.Dd087UsuarioproprId)
                    .HasMaxLength(36)
                    .HasColumnName("DD087_USUARIOPROPR_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<CSICP_DD087Lib>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD087_LIB");

                entity.ToTable("OSUSR_TEI_CSICP_DD087_LIB");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD087_LIB_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD088>(entity =>
            {
                entity.HasKey(e => e.Dd088Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD088");

                entity.ToTable("OSUSR_TEI_CSICP_DD088");

                entity.HasIndex(e => new { e.Dd088TipoRegId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD088_17DD088_TIPO_REG_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd088AprovacaoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD088_18DD088_APROVACAO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD088_9TENANT_ID");

                entity.Property(e => e.Dd088Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD088_ID");
                entity.Property(e => e.Dd088Ano).HasColumnName("DD088_ANO");
                entity.Property(e => e.Dd088AprovacaoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD088_APROVACAO_ID");
                entity.Property(e => e.Dd088Mes).HasColumnName("DD088_MES");
                entity.Property(e => e.Dd088TipoRegId).HasColumnName("DD088_TIPO_REG_ID");
                entity.Property(e => e.Dd088Valor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD088_VALOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });

            modelBuilder.Entity<CSICP_DD088Tpreg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD088_TPREG");

                entity.ToTable("OSUSR_TEI_CSICP_DD088_TPREG");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_TEI_CSICP_DD088_TPREG_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD089>(entity =>
            {
                entity.HasKey(e => e.Dd089Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD089");

                entity.ToTable("OSUSR_TEI_CSICP_DD089", tb => tb.HasTrigger("OSTRG_EI__OSUSR_TEI_CSICP_DD089"));

                entity.HasIndex(e => new { e.Dd089KdxId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD089_12DD089_KDX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd089StabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD089_13DD089_STAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD089_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD089_9TENANT_ID");

                entity.Property(e => e.Dd089Id).HasColumnName("DD089_ID");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd089ItemReId)
                    .HasMaxLength(36)
                    .HasColumnName("DD089_ITEM_RE_ID");
                entity.Property(e => e.Dd089KdxId)
                    .HasMaxLength(36)
                    .HasColumnName("DD089_KDX_ID");
                entity.Property(e => e.Dd089Quantidade)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD089_QUANTIDADE");
                entity.Property(e => e.Dd089StabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD089_STAB_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });

            modelBuilder.Entity<CSICP_DD090>(entity =>
            {
                entity.HasKey(e => e.Dd090Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD090");

                entity.ToTable("OSUSR_TEI_CSICP_DD090");

                entity.HasIndex(e => new { e.Cc049SeveridadeId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD090_19CC049_SEVERIDADE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD090_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd080Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD090_8DD080_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD090_9TENANT_ID");

                entity.Property(e => e.Dd090Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD090_ID");
                entity.Property(e => e.Cc049SeveridadeId).HasColumnName("CC049_SEVERIDADE_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Dd090Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD090_DATAHORA");
                entity.Property(e => e.Dd090Isactive).HasColumnName("DD090_ISACTIVE");
                entity.Property(e => e.Dd090Mensagem)
                    .HasMaxLength(250)
                    .HasColumnName("DD090_MENSAGEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





            });

            modelBuilder.Entity<CSICP_DD092>(entity =>
            {
                entity.HasKey(e => e.Dd092Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD092");

                entity.ToTable("OSUSR_TEI_CSICP_DD092");

                entity.HasIndex(e => new { e.Dd092RotaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD092_13DD092_ROTA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd092EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD092_14DD092_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd092Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD092_14DD092_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd092VeiculoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD092_16DD092_VEICULO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd092MotoristaId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD092_18DD092_MOTORISTA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD092_9TENANT_ID");

                entity.Property(e => e.Dd092Id).HasColumnName("DD092_ID");
                entity.Property(e => e.Dd092Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DD092_DATA");
                entity.Property(e => e.Dd092Datasaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DD092_DATASAIDA");
                entity.Property(e => e.Dd092EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD092_ESTAB_ID");
                entity.Property(e => e.Dd092MotoristaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD092_MOTORISTA_ID");
                entity.Property(e => e.Dd092Protocolo)
                    .HasMaxLength(20)
                    .HasColumnName("DD092_PROTOCOLO");
                entity.Property(e => e.Dd092Qnfs).HasColumnName("DD092_QNFS");
                entity.Property(e => e.Dd092RotaId)
                    .HasMaxLength(36)
                    .HasColumnName("DD092_ROTA_ID");
                entity.Property(e => e.Dd092Statusid).HasColumnName("DD092_STATUSID");
                entity.Property(e => e.Dd092Tfaturasnfs).HasColumnName("DD092_TFATURASNFS");
                entity.Property(e => e.Dd092Ttitulos).HasColumnName("DD092_TTITULOS");
                entity.Property(e => e.Dd092VeiculoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD092_VEICULO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD092stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD092STA");

                entity.ToTable("OSUSR_TEI_CSICP_DD092STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD093>(entity =>
            {
                entity.HasKey(e => e.Dd093Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD093");

                entity.ToTable("OSUSR_TEI_CSICP_DD093");

                entity.HasIndex(e => new { e.Dd093Saldoid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD093_13DD093_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd093Romaneioid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD093_16DD093_ROMANEIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD093_9TENANT_ID");

                entity.Property(e => e.Dd093Id).HasColumnName("DD093_ID");
                entity.Property(e => e.Dd093Ismarcado).HasColumnName("DD093_ISMARCADO");
                entity.Property(e => e.Dd093Motivo)
                    .HasMaxLength(50)
                    .HasColumnName("DD093_MOTIVO");
                entity.Property(e => e.Dd093Qatendida)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD093_QATENDIDA");
                entity.Property(e => e.Dd093Qdisponivel)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD093_QDISPONIVEL");
                entity.Property(e => e.Dd093Qvendida)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD093_QVENDIDA");
                entity.Property(e => e.Dd093Romaneioid).HasColumnName("DD093_ROMANEIOID");
                entity.Property(e => e.Dd093Saldoid)
                    .HasMaxLength(36)
                    .HasColumnName("DD093_SALDOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });
        }
    }
}
