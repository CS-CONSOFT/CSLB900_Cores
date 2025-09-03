using CSCore.Domain.CS_Models.CSICP_GG;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG022> OsusrE9aCsicpGg022s { get; set; }


        public DbSet<CSICP_GG028> OsusrE9aCsicpGg028s { get; set; }



        public DbSet<CSICP_GG029> OsusrE9aCsicpGg029s { get; set; }

        public DbSet<CSICP_GG030> OsusrE9aCsicpGg030s { get; set; }



        public DbSet<CSICP_GG031> OsusrE9aCsicpGg031s { get; set; }

        public DbSet<CSICP_GG032> OsusrE9aCsicpGg032s { get; set; }



        public DbSet<CSICP_GG033> OsusrE9aCsicpGg033s { get; set; }

        public DbSet<CSICP_GG034> OsusrE9aCsicpGg034s { get; set; }


        public DbSet<OsusrE9aCsicpGg035> OsusrE9aCsicpGg035s { get; set; }





        public DbSet<OsusrE9aCsicpGg039> OsusrE9aCsicpGg039s { get; set; }




        public DbSet<CSICP_GG045> OsusrE9aCsicpGg045s { get; set; }


        public DbSet<CSICP_GG046> OsusrE9aCsicpGg046s { get; set; }

        public DbSet<OSUSR_E9A_CSICP_GG046_ES> OsusrE9aCsicpGg046Es { get; set; }


        public DbSet<CSICP_GG054> OsusrE9aCsicpGg054s { get; set; }


        public DbSet<CSICP_GG055> OsusrE9aCsicpGg055s { get; set; }


        public DbSet<CSICP_GG056> OsusrE9aCsicpGg056s { get; set; }

        public DbSet<OsusrE9aCsicpGg058> OsusrE9aCsicpGg058s { get; set; }

        public DbSet<OsusrE9aCsicpGg059> OsusrE9aCsicpGg059s { get; set; }

        public DbSet<CSICP_GG060> OsusrE9aCsicpGg060s { get; set; }

        public DbSet<OsusrE9aCsicpGg065> OsusrE9aCsicpGg065s { get; set; }

        public DbSet<OsusrE9aCsicpGg066> OsusrE9aCsicpGg066s { get; set; }

        public DbSet<OsusrE9aCsicpGg067> OsusrE9aCsicpGg067s { get; set; }

        public DbSet<OsusrE9aCsicpGg068> OsusrE9aCsicpGg068s { get; set; }

        public DbSet<CSICP_GG070> OsusrE9aCsicpGg070s { get; set; }

        public DbSet<CSICP_GG071> OsusrE9aCsicpGg071s { get; set; }



        public DbSet<CSICP_GG072> OsusrE9aCsicpGg072s { get; set; }


        public DbSet<CSICP_GG073> OsusrE9aCsicpGg073s { get; set; }


        public DbSet<CSICP_GG074> OsusrE9aCsicpGg074s { get; set; }

        public DbSet<CSICP_GG100> OsusrE9aCsicpGg100s { get; set; }

        public DbSet<CSICP_GG520> OsusrE9aCsicpGg520s { get; set; }

        public DbSet<OsusrE9aCsicpGg898> OsusrE9aCsicpGg898s { get; set; }

        public DbSet<OsusrE9aCsicpGg899> OsusrE9aCsicpGg899s { get; set; }

        public DbSet<OsusrE9aCsicpGg900> OsusrE9aCsicpGg900s { get; set; }

        public DbSet<OsusrE9aCsicpGg902> OsusrE9aCsicpGg902s { get; set; }

        public DbSet<OsusrE9aCsicpGg903> OsusrE9aCsicpGg903s { get; set; }


        public DbSet<OsusrE9aCsicpGg991> OsusrE9aCsicpGg991s { get; set; }

        public DbSet<OsusrE9aCsicpGg992> OsusrE9aCsicpGg992s { get; set; }

        public DbSet<OsusrE9aCsicpGg993> OsusrE9aCsicpGg993s { get; set; }

        public DbSet<OsusrE9aCsicpGg994> OsusrE9aCsicpGg994s { get; set; }

        public DbSet<OsusrE9aCsicpGg999> OsusrE9aCsicpGg999s { get; set; }
        partial void OnModelCreating_CSICP_GG(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CSICP_GG022>(entity =>
            {
                entity.HasKey(e => e.Gg022Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG022");

                entity.ToTable("OSUSR_E9A_CSICP_GG022");

                entity.HasIndex(e => new { e.Gg022Ufid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG022_10GG022_UFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg022Ncmid, e.Gg022Ufid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG022_11GG022_NCMID_10GG022_UFID_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Gg022Ncmid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG022_11GG022_NCMID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG022_9TENANT_ID");

                entity.Property(e => e.Gg022Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG022_ID");
                entity.Property(e => e.Gg022Ncmid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG022_NCMID");
                entity.Property(e => e.Gg022Pfcp)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG022_PFCP");
                entity.Property(e => e.Gg022Ufid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG022_UFID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(e => e.NavGg021Ncm).WithOne().HasForeignKey<CSICP_GG022>(e => e.Gg022Ncmid);

            });

            modelBuilder.Entity<CSICP_GG028>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("OSPRK_OSUSR_E9A_CSICP_GG028")
                    .HasFillFactor(70);

                entity.ToTable("OSUSR_E9A_CSICP_GG028", tb => tb.HasTrigger("OSTRG_EI__OSUSR_E9A_CSICP_GG028"));

                entity.HasIndex(e => new { e.Gg028Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_13GG028_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DoctoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_14GG028_DOCTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028EntsaidaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_17GG028_ENTSAIDA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028NaturezaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_17GG028_NATUREZA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DataMovimento, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_20GG028_DATA_MOVIMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DataReferente, e.Gg028OrigemPkid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_20GG028_DATA_REFERENTE_17GG028_ORIGEM_PKID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DataReferente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_20GG028_DATA_REFERENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028Protocolnumber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_20GG028_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG028_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg028Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_ALMOXID");
                entity.Property(e => e.Gg028Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_CONTAID");
                entity.Property(e => e.Gg028DataMovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG028_DATA_MOVIMENTO");
                entity.Property(e => e.Gg028DataReferente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG028_DATA_REFERENTE");
                entity.Property(e => e.Gg028DocProtocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_DOC_PROTOCOLNUMBER");
                entity.Property(e => e.Gg028DoctoId)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_DOCTO_ID");
                entity.Property(e => e.Gg028EntsaidaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_ENTSAIDA_ID");
                entity.Property(e => e.Gg028Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG028_FILIAL");
                entity.Property(e => e.Gg028Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_FILIALID");
                entity.Property(e => e.Gg028KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_KARDEX_ID");
                entity.Property(e => e.Gg028NPdv)
                    .HasDefaultValue(0)
                    .HasColumnName("GG028_N_PDV");
                entity.Property(e => e.Gg028NaturezaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_NATUREZA_ID");
                entity.Property(e => e.Gg028NfOuCupom)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("GG028_NF_OU_CUPOM");
                entity.Property(e => e.Gg028OrigemPkid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_ORIGEM_PKID");
                entity.Property(e => e.Gg028Origemprograma)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_ORIGEMPROGRAMA");
                entity.Property(e => e.Gg028Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_PRODUTOID");
                entity.Property(e => e.Gg028Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_PROTOCOLNUMBER");
                entity.Property(e => e.Gg028QtdMovimento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG028_QTD_MOVIMENTO");
                entity.Property(e => e.Gg028SaldoAnterior)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG028_SALDO_ANTERIOR");
                entity.Property(e => e.Gg028Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_SALDOID");

                entity.Property(e => e.Gg028Transacaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_TRANSACAOID");
                entity.Property(e => e.Gg028Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_USUARIOID");
                entity.Property(e => e.Gg028ValorUnitario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG028_VALOR_UNITARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });


            modelBuilder.Entity<CSICP_GG029>(entity =>
            {
                entity.HasKey(e => e.Gg029Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG029");

                entity.ToTable("OSUSR_E9A_CSICP_GG029");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG029_9TENANT_ID");

                entity.Property(e => e.Gg029Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG029_ID");
                entity.Property(e => e.Gg029Adremicms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG029_ADREMICMS");
                entity.Property(e => e.Gg029AdremicmsBio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG029_ADREMICMS_BIO");
                entity.Property(e => e.Gg029Codganp)
                    .HasMaxLength(9)
                    .HasDefaultValue("")
                    .HasColumnName("GG029_CODGANP");
                entity.Property(e => e.Gg029Codif)
                    .HasMaxLength(21)
                    .HasDefaultValue("")
                    .HasColumnName("GG029_CODIF");
                entity.Property(e => e.Gg029Descricao)
                    .HasMaxLength(95)
                    .HasDefaultValue("")
                    .HasColumnName("GG029_DESCRICAO");
                entity.Property(e => e.Gg029Pbio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG029_PBIO");
                entity.Property(e => e.Gg029Pglp)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("GG029_PGLP");
                entity.Property(e => e.Gg029Pgni)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("GG029_PGNI");
                entity.Property(e => e.Gg029Pgnn)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("GG029_PGNN");
                entity.Property(e => e.Gg029Pmixgn)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("GG029_PMIXGN");
                entity.Property(e => e.Gg029Vpart)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("GG029_VPART");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_GG030>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG030");

                entity.ToTable("OSUSR_E9A_CSICP_GG030");

                entity.HasIndex(e => new { e.Gg030Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_12GG030_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_14GG030_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_14GG030_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_15GG030_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Responsavelid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_19GG030_RESPONSAVELID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030PrecoajusteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_20GG030_PRECOAJUSTE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Protocolnumber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030_20GG030_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG030_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg030Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_CCUSTOID");
                entity.Property(e => e.Gg030CodgCCusto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG030_CODG_C_CUSTO");
                entity.Property(e => e.Gg030DataMovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG030_DATA_MOVIMENTO");
                entity.Property(e => e.Gg030Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG030_FILIAL");
                entity.Property(e => e.Gg030Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_FILIALID");
                entity.Property(e => e.Gg030NoDocto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG030_NO_DOCTO");
                entity.Property(e => e.Gg030Observacao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("GG030_OBSERVACAO");
                entity.Property(e => e.Gg030Percajuste)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG030_PERCAJUSTE");
                entity.Property(e => e.Gg030PrecoajusteId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_PRECOAJUSTE_ID");
                entity.Property(e => e.Gg030Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG030_PROTOCOLNUMBER");
                entity.Property(e => e.Gg030Responsavel)
                    .HasDefaultValue(0)
                    .HasColumnName("GG030_RESPONSAVEL");
                entity.Property(e => e.Gg030Responsavelid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_RESPONSAVELID");
                entity.Property(e => e.Gg030Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_STATUS");
                entity.Property(e => e.Gg030TotalMovimento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG030_TOTAL_MOVIMENTO");
                entity.Property(e => e.Gg030Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavGG031).WithOne().HasForeignKey<CSICP_GG031>(e => e.Gg030Id);
                entity.HasOne(e => e.NavSY001).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030Usuarioid);
                entity.HasOne(e => e.NavBB005).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030Ccustoid);
                entity.HasOne(e => e.NavBB001).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030Filialid);
                entity.HasOne(e => e.NavBB007).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030Responsavelid);
                entity.HasOne(e => e.NavGG030Sta).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030Status);
                entity.HasOne(e => e.NavGG023Val).WithOne().HasForeignKey<CSICP_GG030>(e => e.Gg030PrecoajusteId);
            });



            modelBuilder.Entity<CSICP_GG031>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG031");

                entity.ToTable("OSUSR_E9A_CSICP_GG031");

                entity.HasIndex(e => new { e.Gg031Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG031_14GG031_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg031KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG031_15GG031_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg031PrecoajusteId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG031_20GG031_PRECOAJUSTE_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG031_8GG030_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG031_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg030Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_ID");
                entity.Property(e => e.Gg031Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG031_CODBARRASALFA");
                entity.Property(e => e.Gg031Codigobarra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG031_CODIGOBARRA");
                entity.Property(e => e.Gg031DataReferente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG031_DATA_REFERENTE");
                entity.Property(e => e.Gg031Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG031_FILIALID");
                entity.Property(e => e.Gg031KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG031_KARDEX_ID");
                entity.Property(e => e.Gg031PercAjuste)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("GG031_PERC_AJUSTE");
                entity.Property(e => e.Gg031PrcAnterior)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG031_PRC_ANTERIOR");
                entity.Property(e => e.Gg031PrcCalculado)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG031_PRC_CALCULADO");
                entity.Property(e => e.Gg031PrcMovimento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG031_PRC_MOVIMENTO");
                entity.Property(e => e.Gg031PrecoajusteId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG031_PRECOAJUSTE_ID");
                entity.Property(e => e.Gg031Produto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG031_PRODUTO");
                entity.Property(e => e.Gg031Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG031_PRODUTOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



                //entity.HasOne(d => d.Gg031Kardex).WithMany(p => p.OsusrE9aCsicpGg031s)
                //    .HasForeignKey(d => d.Gg031KardexId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG031_OSUSR_E9A_CSICP_GG008_KDX_GG031_KARDEX_ID");


            });

            modelBuilder.Entity<CSICP_GG032>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG032");

                entity.ToTable("OSUSR_E9A_CSICP_GG032", tb => tb.HasTrigger("OSTRG_EI__OSUSR_E9A_CSICP_GG032"));

                entity.HasIndex(e => new { e.Gg032Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_13GG032_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_14GG032_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032StatusId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_15GG032_STATUS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_15GG032_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Protocolnumber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_20GG032_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032TipoinventarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG032_23GG032_TIPOINVENTARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG032_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg032Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_ALMOXID");
                entity.Property(e => e.Gg032Codgalmox)
                    .HasDefaultValue(0)
                    .HasColumnName("GG032_CODGALMOX");
                entity.Property(e => e.Gg032DataHoraBloqueado)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG032_DATA_HORA_BLOQUEADO");
                entity.Property(e => e.Gg032DataHoraProcessado)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG032_DATA_HORA_PROCESSADO");
                entity.Property(e => e.Gg032Datamovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG032_DATAMOVIMENTO");
                entity.Property(e => e.Gg032Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG032_FILIAL");
                entity.Property(e => e.Gg032Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_FILIALID");
                entity.Property(e => e.Gg032Observacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("GG032_OBSERVACAO");
                entity.Property(e => e.Gg032Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG032_PROTOCOLNUMBER");
                entity.Property(e => e.Gg032QtdRegraNconf)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG032_QTD_REGRA_NCONF");
                entity.Property(e => e.Gg032QtosNaoconform)
                    .HasDefaultValue(0)
                    .HasColumnName("GG032_QTOS_NAOCONFORM");
                entity.Property(e => e.Gg032QtosNaoinventariado)
                    .HasDefaultValue(0)
                    .HasColumnName("GG032_QTOS_NAOINVENTARIADO");
                entity.Property(e => e.Gg032QtosPodutos)
                    .HasDefaultValue(0)
                    .HasColumnName("GG032_QTOS_PODUTOS");
                entity.Property(e => e.Gg032StatusId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_STATUS_ID");
                entity.Property(e => e.Gg032TipoinventarioId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_TIPOINVENTARIO_ID");
                entity.Property(e => e.Gg032Totalcmedio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG032_TOTALCMEDIO");
                entity.Property(e => e.Gg032Totalcreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG032_TOTALCREAL");
                entity.Property(e => e.Gg032Totalcusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG032_TOTALCUSTO");
                entity.Property(e => e.Gg032Totalvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG032_TOTALVENDA");
                entity.Property(e => e.Gg032Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavSy001Usuario).WithOne().HasForeignKey<CSICP_GG032>(e => e.Gg032Usuarioid);
                entity.HasOne(e => e.NavGG032Status).WithOne().HasForeignKey<CSICP_GG032>(e => e.Gg032StatusId);
                entity.HasOne(e => e.NavGG032Tinventario).WithOne().HasForeignKey<CSICP_GG032>(e => e.Gg032TipoinventarioId);
            });



            modelBuilder.Entity<CSICP_GG033>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("OSPRK_OSUSR_E9A_CSICP_GG033")
                    .HasFillFactor(70);

                entity.ToTable("OSUSR_E9A_CSICP_GG033");

                entity.HasIndex(e => new { e.Gg033Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG033_13GG033_SALDOID_9TENANT_ID").HasFillFactor(70);

                entity.HasIndex(e => new { e.Gg033Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG033_14GG033_FILIALID_9TENANT_ID").HasFillFactor(70);

                entity.HasIndex(e => new { e.Gg033Datareferente, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG033_19GG033_DATAREFERENTE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Id, e.Gg033Posicao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG033_8GG032_ID_13GG033_POSICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG033_8GG032_ID_9TENANT_ID").HasFillFactor(70);

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG033_9TENANT_ID").HasFillFactor(70);

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg032Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_ID");
                entity.Property(e => e.Gg033Alterado)
                    .HasDefaultValue(false)
                    .HasColumnName("GG033_ALTERADO");
                entity.Property(e => e.Gg033Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG033_CODBARRASALFA");
                entity.Property(e => e.Gg033Codigobarras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG033_CODIGOBARRAS");
                entity.Property(e => e.Gg033Datafechanterior)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG033_DATAFECHANTERIOR");
                entity.Property(e => e.Gg033Datareferente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG033_DATAREFERENTE");
                entity.Property(e => e.Gg033Entsai)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("GG033_ENTSAI");
                entity.Property(e => e.Gg033Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_FILIALID");
                entity.Property(e => e.Gg033Naoinventariar)
                    .HasDefaultValue(false)
                    .HasColumnName("GG033_NAOINVENTARIAR");
                entity.Property(e => e.Gg033NnArtigoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_ARTIGO_ID");
                entity.Property(e => e.Gg033NnClasseId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_CLASSE_ID");
                entity.Property(e => e.Gg033NnGrupoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_GRUPO_ID");
                entity.Property(e => e.Gg033NnLinhaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_LINHA_ID");
                entity.Property(e => e.Gg033NnMarcaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_MARCA_ID");
                entity.Property(e => e.Gg033NnSubgrupoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_NN_SUBGRUPO_ID");
                entity.Property(e => e.Gg033Posicao)
                    .HasDefaultValue(0)
                    .HasColumnName("GG033_POSICAO");
                entity.Property(e => e.Gg033Precocusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_PRECOCUSTO");
                entity.Property(e => e.Gg033Precocustomedio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_PRECOCUSTOMEDIO");
                entity.Property(e => e.Gg033Precocustoreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_PRECOCUSTOREAL");
                entity.Property(e => e.Gg033Precovenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_PRECOVENDA");
                entity.Property(e => e.Gg033Produto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG033_PRODUTO");
                entity.Property(e => e.Gg033Qtdajuste)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_QTDAJUSTE");
                entity.Property(e => e.Gg033Qtdfechanterior)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_QTDFECHANTERIOR");
                entity.Property(e => e.Gg033Qtdinventario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_QTDINVENTARIO");
                entity.Property(e => e.Gg033QuemcontouUserid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_QUEMCONTOU_USERID");
                entity.Property(e => e.Gg033QuemdigitouUserId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_QUEMDIGITOU_USER_ID");
                entity.Property(e => e.Gg033Saldoestoque)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG033_SALDOESTOQUE");
                entity.Property(e => e.Gg033Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG033_SALDOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.NavGG033_Saldo).WithOne().HasForeignKey<CSICP_GG033>(e => e.Gg033Saldoid);
                entity.HasOne(e => e.NavBB001Estab).WithOne().HasForeignKey<CSICP_GG033>(e => e.Gg033Filialid);

            });

            modelBuilder.Entity<CSICP_GG034>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG034");

                entity.ToTable("OSUSR_E9A_CSICP_GG034");

                entity.HasIndex(e => new { e.Gg034Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG034_12GG034_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg034Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG034_14GG034_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg034Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG034_15GG034_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg034Tipopromocao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG034_18GG034_TIPOPROMOCAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg034Protocolnumber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG034_20GG034_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG034_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg034DataMovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG034_DATA_MOVIMENTO");
                entity.Property(e => e.Gg034Dtfimprom)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG034_DTFIMPROM");
                entity.Property(e => e.Gg034Dtinicioprom)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG034_DTINICIOPROM");
                entity.Property(e => e.Gg034Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG034_FILIAL");
                entity.Property(e => e.Gg034Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG034_FILIALID");
                entity.Property(e => e.Gg034NomePromocao)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("GG034_NOME_PROMOCAO");
                entity.Property(e => e.Gg034Observacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("GG034_OBSERVACAO");
                entity.Property(e => e.Gg034Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG034_PROTOCOLNUMBER");
                entity.Property(e => e.Gg034Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG034_STATUS");
                entity.Property(e => e.Gg034Tipopromocao)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG034_TIPOPROMOCAO");
                entity.Property(e => e.Gg034Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG034_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });



            modelBuilder.Entity<OsusrE9aCsicpGg035>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG035");

                entity.ToTable("OSUSR_E9A_CSICP_GG035");

                entity.HasIndex(e => new { e.Gg035Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_14GG035_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg035KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_15GG035_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg035Promocaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_16GG035_PROMOCAOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG035_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg035Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG035_CODBARRASALFA");
                entity.Property(e => e.Gg035Codigobarra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG035_CODIGOBARRA");
                entity.Property(e => e.Gg035Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_FILIALID");
                entity.Property(e => e.Gg035KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_KARDEX_ID");
                entity.Property(e => e.Gg035PercPromocao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("GG035_PERC_PROMOCAO");
                entity.Property(e => e.Gg035PrecoPromocao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG035_PRECO_PROMOCAO");
                entity.Property(e => e.Gg035PrecoVenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG035_PRECO_VENDA");
                entity.Property(e => e.Gg035Produto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG035_PRODUTO");
                entity.Property(e => e.Gg035Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_PRODUTOID");
                entity.Property(e => e.Gg035Promocaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_PROMOCAOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });





            modelBuilder.Entity<OsusrE9aCsicpGg039>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG039");

                entity.ToTable("OSUSR_E9A_CSICP_GG039", tb => tb.HasTrigger("OSTRG_EI__OSUSR_E9A_CSICP_GG039"));

                entity.HasIndex(e => new { e.Gg039UnId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_11GG039_UN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_12GG039_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_13GG039_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_14GG039_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_14GG039_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_15GG039_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_15GG039_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Destsaldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_17GG039_DESTSALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg039Tipomovtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG039_17GG039_TIPOMOVTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG039_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg039AlmoxDestino)
                    .HasDefaultValue(0)
                    .HasColumnName("GG039_ALMOX_DESTINO");
                entity.Property(e => e.Gg039AlmoxOrigem)
                    .HasDefaultValue(0)
                    .HasColumnName("GG039_ALMOX_ORIGEM");
                entity.Property(e => e.Gg039Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_ALMOXID");
                entity.Property(e => e.Gg039Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_CCUSTOID");
                entity.Property(e => e.Gg039Codcolunadestino)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_CODCOLUNADESTINO");
                entity.Property(e => e.Gg039Codgresponsavel)
                    .HasDefaultValue(0)
                    .HasColumnName("GG039_CODGRESPONSAVEL");
                entity.Property(e => e.Gg039Codigobarras)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG039_CODIGOBARRAS");
                entity.Property(e => e.Gg039Codlinhadestino)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_CODLINHADESTINO");
                entity.Property(e => e.Gg039Datamovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG039_DATAMOVIMENTO");
                entity.Property(e => e.Gg039Datareferente)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG039_DATAREFERENTE");
                entity.Property(e => e.Gg039Destalmoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_DESTALMOXID");
                entity.Property(e => e.Gg039Destgradeid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_DESTGRADEID");
                entity.Property(e => e.Gg039Destloteid2)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_DESTLOTEID2");
                entity.Property(e => e.Gg039Destsaldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_DESTSALDOID");
                entity.Property(e => e.Gg039Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_FILIALID");
                entity.Property(e => e.Gg039Gradeid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_GRADEID");
                entity.Property(e => e.Gg039KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_KARDEX_ID");
                entity.Property(e => e.Gg039LoteDestino)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_LOTE_DESTINO");
                entity.Property(e => e.Gg039Loteid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_LOTEID");
                entity.Property(e => e.Gg039ObjOrigemid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_OBJ_ORIGEMID");
                entity.Property(e => e.Gg039ObjOrigemlabel)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_OBJ_ORIGEMLABEL");
                entity.Property(e => e.Gg039Observacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_OBSERVACAO");
                entity.Property(e => e.Gg039Produto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG039_PRODUTO");
                entity.Property(e => e.Gg039ProdutoDestino)
                    .HasDefaultValue(0)
                    .HasColumnName("GG039_PRODUTO_DESTINO");
                entity.Property(e => e.Gg039Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_PRODUTOID");
                entity.Property(e => e.Gg039Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_PROTOCOLNUMBER");
                entity.Property(e => e.Gg039Qtdanterior)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG039_QTDANTERIOR");
                entity.Property(e => e.Gg039Quantidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG039_QUANTIDADE");
                entity.Property(e => e.Gg039Retornoprocessamento)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_RETORNOPROCESSAMENTO");
                entity.Property(e => e.Gg039Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_SALDOID");
                entity.Property(e => e.Gg039SaldovirtualId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_SALDOVIRTUAL_ID");
                entity.Property(e => e.Gg039Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_STATUS");
                entity.Property(e => e.Gg039SubLoteDestino)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_SUB_LOTE_DESTINO");
                entity.Property(e => e.Gg039Tipomovtoestq)
                    .HasMaxLength(1)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_TIPOMOVTOESTQ");
                entity.Property(e => e.Gg039Tipomovtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_TIPOMOVTOID");
                entity.Property(e => e.Gg039UnId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_UN_ID");
                entity.Property(e => e.Gg039Unidade)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG039_UNIDADE");
                entity.Property(e => e.Gg039Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG039_USUARIOID");
                entity.Property(e => e.Gg039Valorunitario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG039_VALORUNITARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });





            modelBuilder.Entity<CSICP_GG045>(entity =>
            {
                entity.HasKey(e => e.Gg045Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG045");

                entity.ToTable("OSUSR_E9A_CSICP_GG045");

                entity.HasIndex(e => new { e.Gg045Statid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_12GG045_STATID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg045Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_13GG045_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg045UsuariopropId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_20GG045_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg045EstabelecimentoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_24GG045_ESTABELECIMENTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc040Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_8CC040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc060Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG045_8CC060_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG045_9TENANT_ID");

                entity.Property(e => e.Gg045Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG045_ID");
                entity.Property(e => e.Cc040Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CC040_ID");
                entity.Property(e => e.Cc060Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CC060_ID");
                entity.Property(e => e.Gg045Datamovto)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG045_DATAMOVTO");
                entity.Property(e => e.Gg045Descricao)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("GG045_DESCRICAO");
                entity.Property(e => e.Gg045EstabelecimentoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG045_ESTABELECIMENTO_ID");
                entity.Property(e => e.Gg045Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG045_PROTOCOLNUMBER");
                entity.Property(e => e.Gg045Qtd)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG045_QTD");
                entity.Property(e => e.Gg045Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG045_SALDOID");
                entity.Property(e => e.Gg045Statid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG045_STATID");
                entity.Property(e => e.Gg045UsuariopropId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG045_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });


            modelBuilder.Entity<CSICP_GG046>(entity =>
            {
                entity.HasKey(e => e.Gg046Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG046");

                entity.ToTable("OSUSR_E9A_CSICP_GG046");

                entity.HasIndex(e => new { e.Gg046StatId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG046_13GG046_STAT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg046EntsaiId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG046_15GG046_ENTSAI_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg046SaldoentId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG046_17GG046_SALDOENT_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg045Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG046_8GG045_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG046_9TENANT_ID");

                entity.Property(e => e.Gg046Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG046_ID");
                entity.Property(e => e.Gg045Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG045_ID");
                entity.Property(e => e.Gg046Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG046_CODBARRASALFA");
                entity.Property(e => e.Gg046Descricaosaldo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG046_DESCRICAOSALDO");
                entity.Property(e => e.Gg046EntsaiId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG046_ENTSAI_ID");
                entity.Property(e => e.Gg046Isnovo)
                    .HasDefaultValue(false)
                    .HasColumnName("GG046_ISNOVO");
                entity.Property(e => e.Gg046Qtd)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG046_QTD");
                entity.Property(e => e.Gg046SaldoentId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG046_SALDOENT_ID");
                entity.Property(e => e.Gg046Seq)
                    .HasDefaultValue(0)
                    .HasColumnName("GG046_SEQ");
                entity.Property(e => e.Gg046StatId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG046_STAT_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");





                entity.HasOne(d => d.Nav_Gg250Saldoent).WithOne()
                    .HasForeignKey<CSICP_GG046>(d => d.Gg046SaldoentId);

            });

            modelBuilder.Entity<OSUSR_E9A_CSICP_GG046_ES>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG046_ES");

                entity.ToTable("OSUSR_E9A_CSICP_GG046_ES");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });


            modelBuilder.Entity<CSICP_GG054>(entity =>
            {
                entity.HasKey(e => e.Gg054Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG054");

                entity.ToTable("OSUSR_E9A_CSICP_GG054");

                entity.HasIndex(e => new { e.Gg054Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG054_12GG054_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg054Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG054_14GG054_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg054UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG054_16GG054_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG054_9TENANT_ID");

                entity.Property(e => e.Gg054Id).HasColumnName("GG054_ID");
                entity.Property(e => e.Gg032Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_ID");
                entity.Property(e => e.Gg054Almox)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_ALMOX");
                entity.Property(e => e.Gg054DataAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG054_DATA_ALT");
                entity.Property(e => e.Gg054DataColeta)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG054_DATA_COLETA");
                entity.Property(e => e.Gg054DataInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG054_DATA_INC");
                entity.Property(e => e.Gg054DocInvent)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG054_DOC_INVENT");
                entity.Property(e => e.Gg054Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_FILIALID");
                entity.Property(e => e.Gg054HoraAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG054_HORA_ALT");
                entity.Property(e => e.Gg054HoraInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG054_HORA_INC");
                entity.Property(e => e.Gg054Ismarcado)
                    .HasDefaultValue(false)
                    .HasColumnName("GG054_ISMARCADO");
                entity.Property(e => e.Gg054Observacao)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("GG054_OBSERVACAO");
                entity.Property(e => e.Gg054Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG054_PROTOCOLNUMBER");
                entity.Property(e => e.Gg054Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_STATUS");
                entity.Property(e => e.Gg054UsuarioAlt)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_USUARIO_ALT");
                entity.Property(e => e.Gg054UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_USUARIO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });



            modelBuilder.Entity<CSICP_GG055>(entity =>
            {
                entity.HasKey(e => e.Gg055Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG055");

                entity.ToTable("OSUSR_E9A_CSICP_GG055");

                entity.HasIndex(e => new { e.Gg055KdxId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_12GG055_KDX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Status, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_12GG055_STATUS_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_13GG055_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Unidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_13GG055_UNIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Criarexcid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_16GG055_CRIAREXCID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055ProdutoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_16GG055_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_16GG055_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Gradelinhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_18GG055_GRADELINHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg055Gradecolunaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG055_19GG055_GRADECOLUNAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG055_9TENANT_ID");

                entity.Property(e => e.Gg055Id).HasColumnName("GG055_ID");
                entity.Property(e => e.Gg054Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG054_ID");
                entity.Property(e => e.Gg055Codgbarras)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG055_CODGBARRAS");
                entity.Property(e => e.Gg055Codgproduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG055_CODGPRODUTO");
                entity.Property(e => e.Gg055Criarexcid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_CRIAREXCID");
                entity.Property(e => e.Gg055DataAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG055_DATA_ALT");
                entity.Property(e => e.Gg055DataInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG055_DATA_INC");
                entity.Property(e => e.Gg055Gradecolunaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_GRADECOLUNAID");
                entity.Property(e => e.Gg055Gradelinhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_GRADELINHAID");
                entity.Property(e => e.Gg055HoraAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG055_HORA_ALT");
                entity.Property(e => e.Gg055HoraInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG055_HORA_INC");
                entity.Property(e => e.Gg055KdxId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_KDX_ID");
                entity.Property(e => e.Gg055Lote)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("GG055_LOTE");
                entity.Property(e => e.Gg055ProdutoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_PRODUTO_ID");
                entity.Property(e => e.Gg055Quantidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG055_QUANTIDADE");
                entity.Property(e => e.Gg055Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_SALDOID");
                entity.Property(e => e.Gg055Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_STATUS");
                entity.Property(e => e.Gg055Sublote)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG055_SUBLOTE");
                entity.Property(e => e.Gg055Unidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_UNIDADE");
                entity.Property(e => e.Gg055UsuarioAlt)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_USUARIO_ALT");
                entity.Property(e => e.Gg055UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG055_USUARIO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });



            modelBuilder.Entity<CSICP_GG056>(entity =>
            {
                entity.HasKey(e => e.Gg056Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG056");

                entity.ToTable("OSUSR_E9A_CSICP_GG056");

                entity.HasIndex(e => new { e.Gg056Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_13GG056_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056Unidade, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_13GG056_UNIDADE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056IdCol01, e.Gg056Produtoid, e.Gg056Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_15GG056_ID_COL_01_15GG056_PRODUTOID_13GG056_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056IdCol01, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_15GG056_ID_COL_01_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056IdCol02, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_15GG056_ID_COL_02_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_15GG056_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg056UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG056_16GG056_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG056_9TENANT_ID");

                entity.Property(e => e.Gg056Id).HasColumnName("GG056_ID");
                entity.Property(e => e.Gg056Codgbarras)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG056_CODGBARRAS");
                entity.Property(e => e.Gg056Codgproduto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG056_CODGPRODUTO");
                entity.Property(e => e.Gg056DataAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG056_DATA_ALT");
                entity.Property(e => e.Gg056DataInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG056_DATA_INC");
                entity.Property(e => e.Gg056HoraAlt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG056_HORA_ALT");
                entity.Property(e => e.Gg056HoraInc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG056_HORA_INC");
                entity.Property(e => e.Gg056IdCol01)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_ID_COL_01");
                entity.Property(e => e.Gg056IdCol02)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_ID_COL_02");
                entity.Property(e => e.Gg056Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_PRODUTOID");
                entity.Property(e => e.Gg056Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG056_PROTOCOLNUMBER");
                entity.Property(e => e.Gg056QtdeCol01)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG056_QTDE_COL_01");
                entity.Property(e => e.Gg056QtdeCol02)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG056_QTDE_COL_02");
                entity.Property(e => e.Gg056Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_SALDOID");
                entity.Property(e => e.Gg056Unidade)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_UNIDADE");
                entity.Property(e => e.Gg056UsuarioAlt)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_USUARIO_ALT");
                entity.Property(e => e.Gg056UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG056_USUARIO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<OsusrE9aCsicpGg058>(entity =>
            {
                entity.HasKey(e => e.Gg058Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG058");

                entity.ToTable("OSUSR_E9A_CSICP_GG058");

                entity.HasIndex(e => new { e.Gg058FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG058_15GG058_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg058KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG058_15GG058_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG058_9TENANT_ID");

                entity.Property(e => e.Gg058Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG058_ID");
                entity.Property(e => e.Gg058Data)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG058_DATA");
                entity.Property(e => e.Gg058Dtfim)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG058_DTFIM");
                entity.Property(e => e.Gg058Dtinicio)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG058_DTINICIO");
                entity.Property(e => e.Gg058FilialId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG058_FILIAL_ID");
                entity.Property(e => e.Gg058Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG058_ISACTIVE");
                entity.Property(e => e.Gg058KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG058_KARDEX_ID");
                entity.Property(e => e.Gg058Protocolnumber)
                    .HasDefaultValue(0)
                    .HasColumnName("GG058_PROTOCOLNUMBER");
                entity.Property(e => e.Gg058Tprccusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG058_TPRCCUSTO");
                entity.Property(e => e.Gg058Tprccustoreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG058_TPRCCUSTOREAL");
                entity.Property(e => e.Gg058Tprcvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG058_TPRCVENDA");
                entity.Property(e => e.Gg058Vprcvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG058_VPRCVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Gg058Kardex).WithMany(p => p.OsusrE9aCsicpGg058s)
                //    .HasForeignKey(d => d.Gg058KardexId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG058_OSUSR_E9A_CSICP_GG008_KDX_GG058_KARDEX_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg059>(entity =>
            {
                entity.HasKey(e => e.Gg059Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG059");

                entity.ToTable("OSUSR_E9A_CSICP_GG059");

                entity.HasIndex(e => new { e.Gg058Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG059_8GG058_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG059_9TENANT_ID");

                entity.Property(e => e.Gg059Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG059_ID");
                entity.Property(e => e.Gg058Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG058_ID");
                entity.Property(e => e.Gg059Pdesconto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG059_PDESCONTO");
                entity.Property(e => e.Gg059Pparticipacao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("GG059_PPARTICIPACAO");
                entity.Property(e => e.Gg059Quantidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_QUANTIDADE");
                entity.Property(e => e.Gg059Tvendabru)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_TVENDABRU");
                entity.Property(e => e.Gg059Tvendaliq)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_TVENDALIQ");
                entity.Property(e => e.Gg059Vcreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_VCREAL");
                entity.Property(e => e.Gg059Vcusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_VCUSTO");
                entity.Property(e => e.Gg059Vdesconto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_VDESCONTO");
                entity.Property(e => e.Gg059Vprctabela)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_VPRCTABELA");
                entity.Property(e => e.Gg059Vprcvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG059_VPRCVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Gg058).WithMany(p => p.OsusrE9aCsicpGg059s)
                    .HasForeignKey(d => d.Gg058Id)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG059_OSUSR_E9A_CSICP_GG058_GG058_ID");
            });

            modelBuilder.Entity<CSICP_GG060>(entity =>
            {
                entity.HasKey(e => e.Gg060Id)
                .HasName("OSPRK_OSUSR_E9A_CSICP_GG060");

                entity.ToTable("OSUSR_E9A_CSICP_GG060");

                entity.HasIndex(e => new { e.Gg060Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG060_13GG060_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg060EstabId, e.Gg060Grupoid, e.Gg060Subgrupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG060_14GG060_ESTAB_ID_13GG060_GRUPOID_16GG060_SUBGRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg060EstabId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG060_14GG060_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg060Subgrupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG060_16GG060_SUBGRUPOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG060_9TENANT_ID");

                entity.Property(e => e.Gg060Id).HasColumnName("GG060_ID");
                entity.Property(e => e.Gg060Dregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG060_DREGISTRO");
                entity.Property(e => e.Gg060EstabId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG060_ESTAB_ID");
                entity.Property(e => e.Gg060Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG060_GRUPOID");
                entity.Property(e => e.Gg060Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG060_ISACTIVE");
                entity.Property(e => e.Gg060Ispadrao)
                    .HasDefaultValue(false)
                    .HasColumnName("GG060_ISPADRAO");
                entity.Property(e => e.Gg060Plucro)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG060_PLUCRO");
                entity.Property(e => e.Gg060Pmaxdesconto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("GG060_PMAXDESCONTO");
                entity.Property(e => e.Gg060Subgrupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG060_SUBGRUPOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(e => e.NavGg003Grupo).WithOne().HasForeignKey<CSICP_GG060>(e => e.Gg060Grupoid);
                entity.HasOne(e => e.NavGg015Subgrupo).WithOne().HasForeignKey<CSICP_GG060>(e => e.Gg060Subgrupoid);
                entity.HasOne(e => e.NavBB001Filial).WithOne().HasForeignKey<CSICP_GG060>(e => e.Gg060EstabId);
            });

            modelBuilder.Entity<OsusrE9aCsicpGg065>(entity =>
            {
                entity.HasKey(e => e.Gg065Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG065");

                entity.ToTable("OSUSR_E9A_CSICP_GG065");

                entity.HasIndex(e => new { e.Gg065IdUnico, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG065_14GG065_ID_UNICO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg065Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG065_15GG065_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG065_9TENANT_ID");

                entity.Property(e => e.Gg065Id).HasColumnName("GG065_ID");
                entity.Property(e => e.Gg065Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG065_DESCRICAO");
                entity.Property(e => e.Gg065IdUnico)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG065_ID_UNICO");
                entity.Property(e => e.Gg065Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("GG065_ORDEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });



            modelBuilder.Entity<OsusrE9aCsicpGg066>(entity =>
            {
                entity.HasKey(e => e.Gg066Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG066");

                entity.ToTable("OSUSR_E9A_CSICP_GG066");

                entity.HasIndex(e => new { e.Gg066Idunico, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG066_13GG066_IDUNICO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg066Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG066_15GG066_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg065Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG066_8GG065_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG066_9TENANT_ID");

                entity.Property(e => e.Gg066Id).HasColumnName("GG066_ID");
                entity.Property(e => e.Gg065Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG065_ID");
                entity.Property(e => e.Gg066Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG066_DESCRICAO");
                entity.Property(e => e.Gg066Idunico)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG066_IDUNICO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Gg065).WithMany(p => p.OsusrE9aCsicpGg066s)
                    .HasForeignKey(d => d.Gg065Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG066_OSUSR_E9A_CSICP_GG065_GG065_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg067>(entity =>
            {
                entity.HasKey(e => e.Gg067Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG067");

                entity.ToTable("OSUSR_E9A_CSICP_GG067");

                entity.HasIndex(e => new { e.Gg008Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG067_8GG008_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg066Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG067_8GG066_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG067_9TENANT_ID");

                entity.Property(e => e.Gg067Id).HasColumnName("GG067_ID");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.Gg066Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG066_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.Gg066).WithMany(p => p.OsusrE9aCsicpGg067s)
                    .HasForeignKey(d => d.Gg066Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG067_OSUSR_E9A_CSICP_GG066_GG066_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg068>(entity =>
            {
                entity.HasKey(e => e.Gg068Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG068");

                entity.ToTable("OSUSR_E9A_CSICP_GG068");

                entity.HasIndex(e => new { e.Gg003Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG068_8GG003_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg065Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG068_8GG065_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG068_9TENANT_ID");

                entity.Property(e => e.Gg068Id).HasColumnName("GG068_ID");
                entity.Property(e => e.Gg003Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG003_ID");
                entity.Property(e => e.Gg065Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG065_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.Gg065).WithMany(p => p.OsusrE9aCsicpGg068s)
                    .HasForeignKey(d => d.Gg065Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG068_OSUSR_E9A_CSICP_GG065_GG065_ID");
            });

            modelBuilder.Entity<CSICP_GG070>(entity =>
            {
                entity.HasKey(e => e.Gg070Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG070");

                entity.ToTable("OSUSR_E9A_CSICP_GG070");

                entity.HasIndex(e => new { e.Gg070EstabId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG070_14GG070_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg070Motivoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG070_14GG070_MOTIVOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg070Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG070_15GG070_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg070Usuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG070_19GG070_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg070Unvendavarejoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG070_21GG070_UNVENDAVAREJOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG070_9TENANT_ID");

                entity.Property(e => e.Gg070Id).HasColumnName("GG070_ID");
                entity.Property(e => e.Gg070Artigoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_ARTIGOID");
                entity.Property(e => e.Gg070Classeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_CLASSEID");
                entity.Property(e => e.Gg070Descproduto)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG070_DESCPRODUTO");
                entity.Property(e => e.Gg070Dregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG070_DREGISTRO");
                entity.Property(e => e.Gg070EstabId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_ESTAB_ID");
                entity.Property(e => e.Gg070Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_GRUPOID");
                entity.Property(e => e.Gg070Marcaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_MARCAID");
                entity.Property(e => e.Gg070Motivoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_MOTIVOID");
                entity.Property(e => e.Gg070Nomecliente)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG070_NOMECLIENTE");
                entity.Property(e => e.Gg070Pcreal)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG070_PCREAL");
                entity.Property(e => e.Gg070Pcusto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG070_PCUSTO");
                entity.Property(e => e.Gg070Peso)
                    .HasDefaultValue(0)
                    .HasColumnName("GG070_PESO");
                entity.Property(e => e.Gg070Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_PRODUTOID");
                entity.Property(e => e.Gg070Pvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG070_PVENDA");
                entity.Property(e => e.Gg070Qtdregistrada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG070_QTDREGISTRADA");
                entity.Property(e => e.Gg070Saldoprod)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG070_SALDOPROD");
                entity.Property(e => e.Gg070Subgrupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_SUBGRUPOID");
                entity.Property(e => e.Gg070Unvendavarejoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_UNVENDAVAREJOID");
                entity.Property(e => e.Gg070Usuariopropid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG070_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_GG071>(entity =>
            {
                entity.HasKey(e => e.Gg071Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG071");

                entity.ToTable("OSUSR_E9A_CSICP_GG071", tb => tb.HasTrigger("OSTRG_EI__OSUSR_E9A_CSICP_GG071"));

                entity.HasIndex(e => new { e.Gg071Estabid, e.Gg071Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_13GG071_ESTABID_14GG071_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Estabid, e.Gg071DataMovimento, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_13GG071_ESTABID_20GG071_DATA_MOVIMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_13GG071_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Tpreqid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_13GG071_TPREQID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_14GG071_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Statusid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_14GG071_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_15GG071_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Almoxentid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_16GG071_ALMOXENTID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Almoxsaidaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_18GG071_ALMOXSAIDAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Protocolnumber, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_20GG071_PROTOCOLNUMBER_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071AtendenteUsuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_25GG071_ATENDENTE_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd070Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG071_8DD070_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG071_9TENANT_ID");

                entity.Property(e => e.Gg071Id).HasColumnName("GG071_ID");
                entity.Property(e => e.Dd070Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DD070_ID");
                entity.Property(e => e.Gg071Almoxentid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_ALMOXENTID");
                entity.Property(e => e.Gg071Almoxsaidaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_ALMOXSAIDAID");
                entity.Property(e => e.Gg071AtendenteUsuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_ATENDENTE_USUARIOID");
                entity.Property(e => e.Gg071Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_CCUSTOID");
                entity.Property(e => e.Gg071DataMovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG071_DATA_MOVIMENTO");
                entity.Property(e => e.Gg071Datendimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG071_DATENDIMENTO");
                entity.Property(e => e.Gg071Dhsolicitacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG071_DHSOLICITACAO");
                entity.Property(e => e.Gg071Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_ESTABID");
                entity.Property(e => e.Gg071NoDocto)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG071_NO_DOCTO");
                entity.Property(e => e.Gg071Observacao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("GG071_OBSERVACAO");
                entity.Property(e => e.Gg071Protocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG071_PROTOCOLNUMBER");
                entity.Property(e => e.Gg071Statusid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_STATUSID");
                entity.Property(e => e.Gg071Tpreqid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_TPREQID");
                entity.Property(e => e.Gg071Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });


            modelBuilder.Entity<CSICP_GG072>(entity =>
            {
                entity.HasKey(e => e.Gg072Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG072");

                entity.ToTable("OSUSR_E9A_CSICP_GG072");

                entity.HasIndex(e => new { e.Gg072UnId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_11GG072_UN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_15GG072_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072UnSecId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_15GG072_UN_SEC_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072Saidasaldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_18GG072_SAIDASALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072Statusestqid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_18GG072_STATUSESTQID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072Entradasaldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_20GG072_ENTRADASALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg072UnSecTipoconvId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_24GG072_UN_SEC_TIPOCONV_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG072_8GG071_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG072_9TENANT_ID");

                entity.Property(e => e.Gg072Id).HasColumnName("GG072_ID");
                entity.Property(e => e.Dd080Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DD080_ID");
                entity.Property(e => e.Gg071Id)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG071_ID");
                entity.Property(e => e.Gg072Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG072_CODBARRASALFA");
                entity.Property(e => e.Gg072Entradasaldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_ENTRADASALDOID");
                entity.Property(e => e.Gg072KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_KARDEX_ID");
                entity.Property(e => e.Gg072QtdAnterior)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG072_QTD_ANTERIOR");
                entity.Property(e => e.Gg072Qtdsolicitada)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG072_QTDSOLICITADA");
                entity.Property(e => e.Gg072Quantidade)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG072_QUANTIDADE");
                entity.Property(e => e.Gg072Saidasaldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_SAIDASALDOID");
                entity.Property(e => e.Gg072Statusestqid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_STATUSESTQID");
                entity.Property(e => e.Gg072UnId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_UN_ID");
                entity.Property(e => e.Gg072UnSecFatorconv)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG072_UN_SEC_FATORCONV");
                entity.Property(e => e.Gg072UnSecId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_UN_SEC_ID");
                entity.Property(e => e.Gg072UnSecQtde)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG072_UN_SEC_QTDE");
                entity.Property(e => e.Gg072UnSecTipoconvId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG072_UN_SEC_TIPOCONV_ID");
                entity.Property(e => e.Gg072ValorUnitario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG072_VALOR_UNITARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



            });


            modelBuilder.Entity<CSICP_GG073>(entity =>
            {
                entity.HasKey(e => e.Gg073Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG073");

                entity.ToTable("OSUSR_E9A_CSICP_GG073");

                entity.HasIndex(e => new { e.Dd190Obraid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_12DD190_OBRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Tmovid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_12GG073_TMOVID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_13GG073_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_14GG073_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Statusid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_14GG073_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Almoxmovd, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_15GG073_ALMOXMOVD_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_15GG073_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Almoxmovsaida, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_19GG073_ALMOXMOVSAIDA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073DataMovimento, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_20GG073_DATA_MOVIMENTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Valorizarporid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG073_20GG073_VALORIZARPORID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG073_9TENANT_ID");

                entity.Property(e => e.Gg073Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG073_ID");
                entity.Property(e => e.Dd190Obraid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DD190_OBRAID");
                entity.Property(e => e.Gg073Almoxmovd)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_ALMOXMOVD");
                entity.Property(e => e.Gg073Almoxmovsaida)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_ALMOXMOVSAIDA");
                entity.Property(e => e.Gg073Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_CCUSTOID");
                entity.Property(e => e.Gg073DataMovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG073_DATA_MOVIMENTO");
                entity.Property(e => e.Gg073Dhregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG073_DHREGISTRO");
                entity.Property(e => e.Gg073Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_ESTABID");
                entity.Property(e => e.Gg073IdOrig)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_ID_ORIG");
                entity.Property(e => e.Gg073Observacao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("GG073_OBSERVACAO");

                entity.Property(e => e.Gg073Protocolonro)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG073_PROTOCOLONRO");


                entity.Property(e => e.Gg073QtdeItens)
                    .HasDefaultValue(0L)
                    .HasColumnName("GG073_QTDE_ITENS");
                entity.Property(e => e.Gg073Statusid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_STATUSID");
                entity.Property(e => e.Gg073Tmovid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_TMOVID");
                entity.Property(e => e.Gg073Tmovimento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG073_TMOVIMENTO");
                entity.Property(e => e.Gg073Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_USUARIOID");
                entity.Property(e => e.Gg073Valorizarporid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_VALORIZARPORID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavSY001).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Usuarioid);
                entity.HasOne(e => e.Gg073AlmoxmovsaidaNavigation).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Almoxmovsaida);
                entity.HasOne(e => e.Gg073AlmoxmovdNavigation).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Almoxmovd);
                entity.HasOne(e => e.Gg073Status).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Statusid);
                entity.HasOne(e => e.Gg073Tmov).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Tmovid);
                entity.HasOne(e => e.Gg073Valorizarpor).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Valorizarporid);
                entity.HasOne(e => e.NavBB005).WithOne().HasForeignKey<CSICP_GG073>(e => e.Gg073Ccustoid);
            });



            modelBuilder.Entity<CSICP_GG074>(entity =>
            {
                entity.HasKey(e => e.Gg074Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG074");

                entity.ToTable("OSUSR_E9A_CSICP_GG074");

                entity.HasIndex(e => new { e.Gg074UnId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_11GG074_UN_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg074Tmovid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_12GG074_TMOVID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg074Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_13GG074_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg074KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_15GG074_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg074Statusestqid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_18GG074_STATUSESTQID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg073Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG074_8GG073_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG074_9TENANT_ID");

                entity.Property(e => e.Gg074Id).HasColumnName("GG074_ID");
                entity.Property(e => e.Gg073Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG073_ID");
                entity.Property(e => e.Gg074Codbarrasalfa)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG074_CODBARRASALFA");
                entity.Property(e => e.Gg074KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG074_KARDEX_ID");
                entity.Property(e => e.Gg074Qtd)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG074_QTD");
                entity.Property(e => e.Gg074Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG074_SALDOID");
                entity.Property(e => e.Gg074Statusestqid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG074_STATUSESTQID");
                entity.Property(e => e.Gg074Tmovid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG074_TMOVID");
                entity.Property(e => e.Gg074Tproduto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG074_TPRODUTO");
                entity.Property(e => e.Gg074UnId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG074_UN_ID");
                entity.Property(e => e.Gg074Vunitario)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG074_VUNITARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.NavGG073).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg073Id);
                entity.HasOne(d => d.NavGG008Kdx).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg074KardexId);
                entity.HasOne(d => d.NavGG520).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg074Saldoid);
                entity.HasOne(d => d.NavGG007).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg074UnId);
                entity.HasOne(d => d.NavGG072Stq).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg074Statusestqid);
                entity.HasOne(d => d.NavGG073TpMov).WithOne().HasForeignKey<CSICP_GG074>(d => d.Gg074Tmovid);


            });

            modelBuilder.Entity<CSICP_GG100>(entity =>
            {
                entity.HasKey(e => e.Gg100Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG100");

                entity.ToTable("OSUSR_E9A_CSICP_GG100");

                entity.HasIndex(e => new { e.Gg100Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG100_13GG100_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg100Pdtipoprodutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG100_21GG100_PDTIPOPRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg100PdvendaAlmoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG100_21GG100_PDVENDA_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg100Pdtransfalmoxid2, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG100_22GG100_PDTRANSFALMOXID2_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG100_9TENANT_ID");

                entity.Property(e => e.Gg100Id).HasColumnName("GG100_ID");
                entity.Property(e => e.Gg100AwsBucket)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG100_AWS_BUCKET");
                entity.Property(e => e.Gg100Awsaccesskeyid)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG100_AWSACCESSKEYID");
                entity.Property(e => e.Gg100Awsregion)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG100_AWSREGION");
                entity.Property(e => e.Gg100Awssecretaccesskey)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG100_AWSSECRETACCESSKEY");
                entity.Property(e => e.Gg100Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG100_ESTABID");
                entity.Property(e => e.Gg100Iscopia)
                    .HasDefaultValue(false)
                    .HasColumnName("GG100_ISCOPIA");
                entity.Property(e => e.Gg100Pdtipoprodutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG100_PDTIPOPRODUTOID");
                entity.Property(e => e.Gg100Pdtransfalmoxid2)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG100_PDTRANSFALMOXID2");
                entity.Property(e => e.Gg100PdvendaAlmoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG100_PDVENDA_ALMOXID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Gg100Pdtipoproduto).WithOne()
                    .HasForeignKey<CSICP_GG100>(d => d.Gg100Pdtipoprodutoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG100_OSUSR_E9A_CSICP_GG002_GG100_PDTIPOPRODUTOID");


            });

            modelBuilder.Entity<CSICP_GG520>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("OSPRK_OSUSR_E9A_CSICP_GG520")
                    .HasFillFactor(70);

                entity.ToTable("OSUSR_E9A_CSICP_GG520", tb => tb.HasTrigger("OSTRG_EI__OSUSR_E9A_CSICP_GG520"));

                entity.HasIndex(e => new { e.Gg520Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_13GG520_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_13GG520_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Filialid, e.Gg520Compraid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_14GG520_FILIALID_14GG520_COMPRAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Filialid, e.Gg520KardexId, e.Gg520Almoxid, e.Gg520NsNumerosaldo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_14GG520_FILIALID_15GG520_KARDEX_ID_13GG520_ALMOXID_20GG520_NS_NUMEROSALDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_14GG520_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520KardexId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_15GG520_KARDEX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Timestamp, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_15GG520_TIMESTAMP_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520CodbarrasId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_18GG520_CODBARRAS_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Gradelinhaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_18GG520_GRADELINHAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Gradecolunaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_19GG520_GRADECOLUNAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520Descricaosaldo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_20GG520_DESCRICAOSALDO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg520NsNumerosaldo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG520_20GG520_NS_NUMEROSALDO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG520_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg520Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_ALMOXID");
                entity.Property(e => e.Gg520Codalmoxarifado)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_CODALMOXARIFADO");
                entity.Property(e => e.Gg520CodbarrasId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_CODBARRAS_ID");
                entity.Property(e => e.Gg520CodgFornecedor)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_CODG_FORNECEDOR");
                entity.Property(e => e.Gg520Codggradecoluna)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_CODGGRADECOLUNA");
                entity.Property(e => e.Gg520Codggradelinha)
                    .HasMaxLength(3)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_CODGGRADELINHA");
                entity.Property(e => e.Gg520Compraentrada)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_COMPRAENTRADA");
                entity.Property(e => e.Gg520Compraid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_COMPRAID");
                entity.Property(e => e.Gg520Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_CONTAID");
                entity.Property(e => e.Gg520DataFabricacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_DATA_FABRICACAO");
                entity.Property(e => e.Gg520DataValidade)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_DATA_VALIDADE");
                entity.Property(e => e.Gg520DescricaoLote)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_DESCRICAO_LOTE");
                entity.Property(e => e.Gg520Descricaosaldo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_DESCRICAOSALDO");
                entity.Property(e => e.Gg520DiasValidade)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_DIAS_VALIDADE");
                entity.Property(e => e.Gg520Docto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_DOCTO");
                entity.Property(e => e.Gg520Estoquemaximo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_ESTOQUEMAXIMO");
                entity.Property(e => e.Gg520EstqMinimo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_ESTQ_MINIMO");
                entity.Property(e => e.Gg520Exibiremconsulta)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_EXIBIREMCONSULTA");
                entity.Property(e => e.Gg520Filial)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_FILIAL");
                entity.Property(e => e.Gg520Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_FILIALID");
                entity.Property(e => e.Gg520Gradecolunaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_GRADECOLUNAID");
                entity.Property(e => e.Gg520Gradelinhaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_GRADELINHAID");
                entity.Property(e => e.Gg520Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_ISACTIVE");
                entity.Property(e => e.Gg520Ispdv)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_ISPDV");
                entity.Property(e => e.Gg520ItemEmContagem)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_ITEM_EM_CONTAGEM");
                entity.Property(e => e.Gg520KardexId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_KARDEX_ID");
                entity.Property(e => e.Gg520Localizacaowms)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_LOCALIZACAOWMS");
                entity.Property(e => e.Gg520Lote)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_LOTE");
                entity.Property(e => e.Gg520NsNumerosaldo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("GG520_NS_NUMEROSALDO");
                entity.Property(e => e.Gg520Periodicidadeinv)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_PERIODICIDADEINV");
                entity.Property(e => e.Gg520Permitetroca)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_PERMITETROCA");
                entity.Property(e => e.Gg520Produto)
                    .HasDefaultValue(0)
                    .HasColumnName("GG520_PRODUTO");
                entity.Property(e => e.Gg520Proxinventario)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_PROXINVENTARIO");
                entity.Property(e => e.Gg520Qnpt)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QNPT");
                entity.Property(e => e.Gg520QtdEmpenho)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTD_EMPENHO");
                entity.Property(e => e.Gg520QtdProducao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTD_PRODUCAO");
                entity.Property(e => e.Gg520QtdReserva)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTD_RESERVA");
                entity.Property(e => e.Gg520Qtdcomprometida)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTDCOMPROMETIDA");
                entity.Property(e => e.Gg520QtdeUltVenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTDE_ULT_VENDA");
                entity.Property(e => e.Gg520Qtdpedidocompra)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTDPEDIDOCOMPRA");
                entity.Property(e => e.Gg520Qtdultfechamento)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTDULTFECHAMENTO");
                entity.Property(e => e.Gg520Qtdultrecebto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTDULTRECEBTO");
                entity.Property(e => e.Gg520Qtnp)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_QTNP");
                entity.Property(e => e.Gg520Saldo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_SALDO");
                entity.Property(e => e.Gg520Saldozerodesabautom)
                    .HasDefaultValue(false)
                    .HasColumnName("GG520_SALDOZERODESABAUTOM");
                entity.Property(e => e.Gg520Serie)
                    .HasMaxLength(9)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_SERIE");
                entity.Property(e => e.Gg520Sublote)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("GG520_SUBLOTE");
                entity.Property(e => e.Gg520Superpromocao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_SUPERPROMOCAO");
                entity.Property(e => e.Gg520Timestamp)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_TIMESTAMP");
                entity.Property(e => e.Gg520Ultfechamento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_ULTFECHAMENTO");
                entity.Property(e => e.Gg520UltimaVenda)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_ULTIMA_VENDA");
                entity.Property(e => e.Gg520Ultinventario)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_ULTINVENTARIO");
                entity.Property(e => e.Gg520Ultrecebimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG520_ULTRECEBIMENTO");
                entity.Property(e => e.Gg520Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_USUARIOID");
                entity.Property(e => e.Gg520Vbcstret)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_VBCSTRET");
                entity.Property(e => e.Gg520VfuturaSaldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_VFUTURA_SALDOID");
                entity.Property(e => e.Gg520Vicmsstret)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_VICMSSTRET");
                entity.Property(e => e.Gg520Vicmssubstituto)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG520_VICMSSUBSTITUTO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.Nav_GG008Kardex)
                .WithMany(e => e.CS_NavListaSaldos).HasForeignKey(d => d.Gg520KardexId);
                entity.HasOne(d => d.NavGG001Almox).WithOne().HasForeignKey<CSICP_GG520>(d => d.Gg520Almoxid);
                entity.HasOne(d => d.NavGG016Gradecoluna).WithOne().HasForeignKey<CSICP_GG520>(d => d.Gg520Gradecolunaid);
                entity.HasOne(d => d.NavGG016Gradlinha).WithOne().HasForeignKey<CSICP_GG520>(d => d.Gg520Gradelinhaid);
            });

            modelBuilder.Entity<OsusrE9aCsicpGg898>(entity =>
            {
                entity.HasKey(e => e.Gg898Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG898");

                entity.ToTable("OSUSR_E9A_CSICP_GG898");

                entity.HasIndex(e => new { e.Gg898Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG898_13GG898_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg898Hashunico, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG898_15GG898_HASHUNICO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG898_9TENANT_ID");

                entity.Property(e => e.Gg898Id).HasColumnName("GG898_ID");
                entity.Property(e => e.Gg898Descricao)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG898_DESCRICAO");
                entity.Property(e => e.Gg898Dfinal)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG898_DFINAL");
                entity.Property(e => e.Gg898Dinicio)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG898_DINICIO");
                entity.Property(e => e.Gg898Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG898_ESTABID");
                entity.Property(e => e.Gg898Hashunico)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG898_HASHUNICO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg899>(entity =>
            {
                entity.HasKey(e => e.Gg899Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG899");

                entity.ToTable("OSUSR_E9A_CSICP_GG899");

                entity.HasIndex(e => new { e.Gg899Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG899_13GG899_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg899EstabId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG899_14GG899_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg899Hashunico, e.Gg899Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG899_15GG899_HASHUNICO_13GG899_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg899Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG899_15GG899_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG899_9TENANT_ID");

                entity.Property(e => e.Gg899Id).HasColumnName("GG899_ID");
                entity.Property(e => e.Gg899Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_ALMOXID");
                entity.Property(e => e.Gg899Artigoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_ARTIGOID");
                entity.Property(e => e.Gg899Classeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_CLASSEID");
                entity.Property(e => e.Gg899Descproduto)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG899_DESCPRODUTO");
                entity.Property(e => e.Gg899Dultmovto)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG899_DULTMOVTO");
                entity.Property(e => e.Gg899EstabId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_ESTAB_ID");
                entity.Property(e => e.Gg899Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_GRUPOID");
                entity.Property(e => e.Gg899Hashunico)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG899_HASHUNICO");
                entity.Property(e => e.Gg899Marcaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_MARCAID");
                entity.Property(e => e.Gg899Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_PRODUTOID");
                entity.Property(e => e.Gg899Protocolo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG899_PROTOCOLO");
                entity.Property(e => e.Gg899Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_SALDOID");
                entity.Property(e => e.Gg899Saldoperiodo)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG899_SALDOPERIODO");
                entity.Property(e => e.Gg899Subgrupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG899_SUBGRUPOID");
                entity.Property(e => e.Gg899Totqtdvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG899_TOTQTDVENDA");
                entity.Property(e => e.Gg899Totvenda)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG899_TOTVENDA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg900>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG900");

                entity.ToTable("OSUSR_E9A_CSICP_GG900");

                entity.HasIndex(e => new { e.Gg900Chave, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_11GG900_CHAVE_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg900Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_13GG900_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg900Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_15GG900_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg900Produtoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_15GG900_PRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg900Usuarioid, e.Gg900Chaveprograma, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_15GG900_USUARIOID_19GG900_CHAVEPROGRAMA_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg900Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG900_15GG900_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG900_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg900Chave)
                    .HasMaxLength(38)
                    .HasDefaultValue("")
                    .HasColumnName("GG900_CHAVE");
                entity.Property(e => e.Gg900Chaveprograma)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG900_CHAVEPROGRAMA");
                entity.Property(e => e.Gg900Createon)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG900_CREATEON");
                entity.Property(e => e.Gg900Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG900_EMPRESAID");
                entity.Property(e => e.Gg900Percentual)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG900_PERCENTUAL");
                entity.Property(e => e.Gg900Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG900_PRODUTOID");
                entity.Property(e => e.Gg900QtdeCesta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG900_QTDE_CESTA");
                entity.Property(e => e.Gg900Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG900_SALDOID");
                entity.Property(e => e.Gg900Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG900_USUARIOID");
                entity.Property(e => e.Gg900Valor)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG900_VALOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg902>(entity =>
            {
                entity.HasKey(e => e.Gg902Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG902");

                entity.ToTable("OSUSR_E9A_CSICP_GG902");

                entity.HasIndex(e => new { e.Gg902Almoxid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_13GG902_ALMOXID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg902Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_13GG902_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg902EstabId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_14GG902_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg902Motivoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_14GG902_MOTIVOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg902Statusid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_14GG902_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg902Usuariopropid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG902_19GG902_USUARIOPROPID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG902_9TENANT_ID");

                entity.Property(e => e.Gg902Id).HasColumnName("GG902_ID");
                entity.Property(e => e.Gg902Almoxid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_ALMOXID");
                entity.Property(e => e.Gg902Dmovimento)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG902_DMOVIMENTO");
                entity.Property(e => e.Gg902Dregistro)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG902_DREGISTRO");
                entity.Property(e => e.Gg902Dsaldodia)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG902_DSALDODIA");
                entity.Property(e => e.Gg902EstabId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_ESTAB_ID");
                entity.Property(e => e.Gg902Motivoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_MOTIVOID");
                entity.Property(e => e.Gg902Observacao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("GG902_OBSERVACAO");
                entity.Property(e => e.Gg902Qaferida)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG902_QAFERIDA");
                entity.Property(e => e.Gg902Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_SALDOID");
                entity.Property(e => e.Gg902Slddisponnodia)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG902_SLDDISPONNODIA");
                entity.Property(e => e.Gg902Statusid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_STATUSID");
                entity.Property(e => e.Gg902Usuariopropid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG902_USUARIOPROPID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });



            modelBuilder.Entity<OsusrE9aCsicpGg903>(entity =>
            {
                entity.HasKey(e => e.Gg903Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG903");

                entity.ToTable("OSUSR_E9A_CSICP_GG903");

                entity.HasIndex(e => new { e.Gg903Cprod, e.Gg903Cean, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_11GG903_CPROD_10GG903_CEAN_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg903Cprod, e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_11GG903_CPROD_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg903Nitem, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_11GG903_NITEM_9TENANT_ID");

                entity.HasIndex(e => new { e.Cc070XmlId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_12CC070_XML_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contaid, e.Gg008Codgindustrial, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_13BB012_CONTAID_20GG008_CODGINDUSTRIAL_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg903Usuarioaltid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_18GG903_USUARIOALTID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg903Usuarioincid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_18GG903_USUARIOINCID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg008Tipoprodutoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_19GG008_TIPOPRODUTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg903Tpintegracaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG903_20GG903_TPINTEGRACAOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG903_9TENANT_ID");

                entity.Property(e => e.Gg903Id).HasColumnName("GG903_ID");
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.Cc070XmlId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CC070_XML_ID");
                entity.Property(e => e.Gg008Artigoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ARTIGOID");
                entity.Property(e => e.Gg008Classeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_CLASSEID");
                entity.Property(e => e.Gg008Codgindustrial)
                    .HasMaxLength(15)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_CODGINDUSTRIAL");
                entity.Property(e => e.Gg008Complemento)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_COMPLEMENTO");
                entity.Property(e => e.Gg008Descricaoreduz)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_DESCRICAOREDUZ");
                entity.Property(e => e.Gg008Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_GRUPOID");
                entity.Property(e => e.Gg008Marcaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_MARCAID");
                entity.Property(e => e.Gg008Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_PRODUTOID");
                entity.Property(e => e.Gg008Referencia)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG008_REFERENCIA");
                entity.Property(e => e.Gg008Subgrupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_SUBGRUPOID");
                entity.Property(e => e.Gg008Tipoprodutoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_TIPOPRODUTOID");
                entity.Property(e => e.Gg903Cean)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("GG903_CEAN");
                entity.Property(e => e.Gg903Codgempresa)
                    .HasDefaultValue(0)
                    .HasColumnName("GG903_CODGEMPRESA");
                entity.Property(e => e.Gg903Cprod)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("GG903_CPROD");
                entity.Property(e => e.Gg903Dtalteracao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG903_DTALTERACAO");
                entity.Property(e => e.Gg903Dtinclusao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG903_DTINCLUSAO");
                entity.Property(e => e.Gg903Ncm)
                    .HasMaxLength(8)
                    .HasDefaultValue("")
                    .HasColumnName("GG903_NCM");
                entity.Property(e => e.Gg903Nitem)
                    .HasDefaultValue(0)
                    .HasColumnName("GG903_NITEM");
                entity.Property(e => e.Gg903Precoreposicao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG903_PRECOREPOSICAO");
                entity.Property(e => e.Gg903Tpintegracaoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG903_TPINTEGRACAOID");
                entity.Property(e => e.Gg903UnidadeId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG903_UNIDADE_ID");
                entity.Property(e => e.Gg903Usuarioaltid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG903_USUARIOALTID");
                entity.Property(e => e.Gg903Usuarioincid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG903_USUARIOINCID");
                entity.Property(e => e.Gg903Xprod)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("GG903_XPROD");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Gg008Tipoproduto).WithOne()
                    .HasForeignKey<OsusrE9aCsicpGg903>(d => d.Gg008Tipoprodutoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG903_OSUSR_E9A_CSICP_GG002_GG008_TIPOPRODUTOID");
            });



            modelBuilder.Entity<OsusrE9aCsicpGg991>(entity =>
            {
                entity.HasKey(e => e.Gg991OrganogramaId).HasName("OSPRK_OSUSR_E9A_CSICP_GG991");

                entity.ToTable("OSUSR_E9A_CSICP_GG991");

                entity.HasIndex(e => new { e.Gg991FilialId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG991_15GG991_FILIAL_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg991UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG991_16GG991_USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG991_9TENANT_ID");

                entity.Property(e => e.Gg991OrganogramaId)
                    .HasMaxLength(36)
                    .HasColumnName("GG991_ORGANOGRAMA_ID");
                entity.Property(e => e.Gg991Atender)
                    .HasDefaultValue(false)
                    .HasColumnName("GG991_ATENDER");
                entity.Property(e => e.Gg991Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("GG991_DESCRICAO");
                entity.Property(e => e.Gg991FilialId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG991_FILIAL_ID");
                entity.Property(e => e.Gg991Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("GG991_ISACTIVE");
                entity.Property(e => e.Gg991Isconfirmar)
                    .HasDefaultValue(false)
                    .HasColumnName("GG991_ISCONFIRMAR");
                entity.Property(e => e.Gg991Nivel)
                    .HasDefaultValue(0)
                    .HasColumnName("GG991_NIVEL");
                entity.Property(e => e.Gg991UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG991_USUARIO_ID");
                entity.Property(e => e.Gg991UsuarioPaiId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG991_USUARIO_PAI_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg992>(entity =>
            {
                entity.HasKey(e => e.Gg992Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG992");

                entity.ToTable("OSUSR_E9A_CSICP_GG992");

                entity.HasIndex(e => new { e.Gg992AlmoxId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG992_14GG992_ALMOX_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg992OrganogramaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG992_20GG992_ORGANOGRAMA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG992_9TENANT_ID");

                entity.Property(e => e.Gg992Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG992_ID");
                entity.Property(e => e.Gg992AlmoxId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG992_ALMOX_ID");
                entity.Property(e => e.Gg992OrganogramaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG992_ORGANOGRAMA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");



                entity.HasOne(d => d.Gg992Organograma).WithMany(p => p.OsusrE9aCsicpGg992s)
                    .HasForeignKey(d => d.Gg992OrganogramaId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_GG992_OSUSR_E9A_CSICP_GG991_GG992_ORGANOGRAMA_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg993>(entity =>
            {
                entity.HasKey(e => e.Gg993Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG993");

                entity.ToTable("OSUSR_E9A_CSICP_GG993");

                entity.HasIndex(e => new { e.Gg993Saldoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG993_13GG993_SALDOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg993Empresaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG993_15GG993_EMPRESAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG993_9TENANT_ID");

                entity.Property(e => e.Gg993Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG993_ID");
                entity.Property(e => e.Gg028Extratoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_EXTRATOID");
                entity.Property(e => e.Gg041RiId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG041_RI_ID");
                entity.Property(e => e.Gg993Createon)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG993_CREATEON");
                entity.Property(e => e.Gg993Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG993_EMPRESAID");
                entity.Property(e => e.Gg993EstoqMin)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG993_ESTOQ_MIN");
                entity.Property(e => e.Gg993EstqMax)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG993_ESTQ_MAX");
                entity.Property(e => e.Gg993Isprocessado)
                    .HasDefaultValue(false)
                    .HasColumnName("GG993_ISPROCESSADO");
                entity.Property(e => e.Gg993QtdeReposicao)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG993_QTDE_REPOSICAO");
                entity.Property(e => e.Gg993Saldoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG993_SALDOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg994>(entity =>
            {
                entity.HasKey(e => e.Gg994Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG994");

                entity.ToTable("OSUSR_E9A_CSICP_GG994");

                entity.HasIndex(e => new { e.Gg994CodgProduto, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG994_18GG994_CODG_PRODUTO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg994Codgimportado, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG994_19GG994_CODGIMPORTADO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg032Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG994_8GG032_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG994_9TENANT_ID");

                entity.Property(e => e.Gg994Id).HasColumnName("GG994_ID");
                entity.Property(e => e.Gg008Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008_ID");
                entity.Property(e => e.Gg008kdxId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG008KDX_ID");
                entity.Property(e => e.Gg032Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG032_ID");
                entity.Property(e => e.Gg520Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG520_ID");
                entity.Property(e => e.Gg994CodgProduto)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG994_CODG_PRODUTO");
                entity.Property(e => e.Gg994Codgimportado)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG994_CODGIMPORTADO");
                entity.Property(e => e.Gg994Descproduto)
                    .HasMaxLength(150)
                    .HasDefaultValue("")
                    .HasColumnName("GG994_DESCPRODUTO");
                entity.Property(e => e.Gg994Dinclusao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG994_DINCLUSAO");
                entity.Property(e => e.Gg994Qtd)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("GG994_QTD");
                entity.Property(e => e.Gg994Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG994_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<OsusrE9aCsicpGg999>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG999");

                entity.ToTable("OSUSR_E9A_CSICP_GG999");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG999_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Gg999ObjDestinoid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG999_OBJ_DESTINOID");
                entity.Property(e => e.Gg999ObjDestinolabel)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG999_OBJ_DESTINOLABEL");
                entity.Property(e => e.Gg999ObjOrigemid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG999_OBJ_ORIGEMID");
                entity.Property(e => e.Gg999ObjOrigemlabel)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("GG999_OBJ_ORIGEMLABEL");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });
        }
    }
}
