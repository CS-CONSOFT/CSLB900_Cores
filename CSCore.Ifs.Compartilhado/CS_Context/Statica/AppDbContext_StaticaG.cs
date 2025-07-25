using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_Models.Staticas.PD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_GG001Talmox> CSICP_GG001Talmoxes { get; set; }
        public DbSet<OsusrE9aCsicpGg007Fra> OsusrE9aCsicpGg007Fras { get; set; }
        public DbSet<OsusrE9aCsicpGg008Cdn> OsusrE9aCsicpGg008Cdns { get; set; }

        public DbSet<CSICP_GG008Con> OsusrE9aCsicpGg008Cons { get; set; }

        public DbSet<CSICP_GG008Efi> OsusrE9aCsicpGg008Efis { get; set; }

        public DbSet<CSICP_GG008Gar> OsusrE9aCsicpGg008Gars { get; set; }

        public DbSet<CSICP_GG008Kit> OsusrE9aCsicpGg008Kits { get; set; }

        public DbSet<OsusrE9aCsicpGg008Tpcon> OsusrE9aCsicpGg008Tpcons { get; set; }

        public DbSet<OsusrE9aCsicpGg008Tran> OsusrE9aCsicpGg008Trans { get; set; }

        public DbSet<OsusrE9aCsicpGg008dTp> OsusrE9aCsicpGg008dTps { get; set; }

        public DbSet<CSICP_GG019Cgbar> OsusrE9aCsicpGg019Cgbars { get; set; }

        public DbSet<OsusrE9aCsicpGg021cest> OsusrE9aCsicpGg021cests { get; set; }

        public DbSet<OsusrE9aCsicpGg023Tipo> OsusrE9aCsicpGg023Tipos { get; set; }

        public DbSet<CSICP_GG023Val> OsusrE9aCsicpGg023Vals { get; set; }

        public DbSet<OsusrE9aCsicpGg025stum> OsusrE9aCsicpGg025sta { get; set; }

        public DbSet<CSICP_GG028Entsai> OsusrE9aCsicpGg028Entsais { get; set; }

        public DbSet<OsusrE9aCsicpGg028Nat> OsusrE9aCsicpGg028Nats { get; set; }

        public DbSet<CSICP_GG028Tree> OsusrE9aCsicpGg028Trees { get; set; }
        public DbSet<CSICP_GG030Sta> OsusrE9aCsicpGg030Sta { get; set; }

        public DbSet<CSICP_GG030Est> OsusrE9aCsicpGg030ests { get; set; }
        public DbSet<OsusrE9aCsicpGg032Stum> OsusrE9aCsicpGg032Sta { get; set; }

        public DbSet<OsusrE9aCsicpGg032Tpinv> OsusrE9aCsicpGg032Tpinvs { get; set; }
        public DbSet<OsusrE9aCsicpGg034Stum> OsusrE9aCsicpGg034Sta { get; set; }

        public DbSet<OsusrE9aCsicpGg034Tipo> OsusrE9aCsicpGg034Tipos { get; set; }

        public DbSet<OsusrE9aCsicpGg035Super> OsusrE9aCsicpGg035Supers { get; set; }
        public DbSet<OsusrE9aCsicpGg039Stat> OsusrE9aCsicpGg039Stats { get; set; }

        public DbSet<OsusrE9aCsicpGg041Tpreq> OsusrE9aCsicpGg041Tpreqs { get; set; }
        public DbSet<OsusrE9aCsicpGg045Stat> OsusrE9aCsicpGg045Stats { get; set; }
        public DbSet<OsusrE9aCsicpGg046Stat> OsusrE9aCsicpGg046Stats { get; set; }
        public DbSet<OsusrE9aCsicpGg054Stum> OsusrE9aCsicpGg054Sta { get; set; }

        public DbSet<OsusrE9aCsicpGg055Stum> OsusrE9aCsicpGg055Sta { get; set; }
        public DbSet<OsusrE9aCsicpGg065Tp> OsusrE9aCsicpGg065Tps { get; set; }
        public DbSet<OsusrE9aCsicpGg071Stum> OsusrE9aCsicpGg071Sta { get; set; }

        public DbSet<CSICP_GG072Stq> OsusrE9aCsicpGg072Stqs { get; set; }
        public DbSet<OsusrE9aCsicpGg073Stat> OsusrE9aCsicpGg073Stats { get; set; }

        public DbSet<OsusrE9aCsicpGg073Tmov> OsusrE9aCsicpGg073Tmovs { get; set; }
        public DbSet<OsusrE9aCsicpGg902St> OsusrE9aCsicpGg902Sts { get; set; }

        public DbSet<OsusrE9aCsicpGg903tp> OsusrE9aCsicpGg903tps { get; set; }

        public DbSet<CSICP_PD001Ctef> OsusrT5lCsicpPd001Ctefs { get; set; }

        public DbSet<CSICP_PF001Imp> OsusrT5lCsicpPd001Imps { get; set; }
        partial void OnModelCreatingStaticaGG(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_PD001Ctef>(entity =>
            {
                entity.ToTable("OSUSR_T5L_CSICP_PD001_CTEF");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.TipotefId)
                    .HasColumnName("TIPOTEF_ID");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL");

                entity.Property(e => e.Order)
                    .HasColumnName("ORDER");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE");
            });




            modelBuilder.Entity<CSICP_GG001Talmox>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG001_TALMOX");

                entity.ToTable("OSUSR_E9A_CSICP_GG001_TALMOX");

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
            modelBuilder.Entity<OsusrE9aCsicpGg007Fra>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG007_FRA");

                entity.ToTable("OSUSR_E9A_CSICP_GG007_FRA");

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

            modelBuilder.Entity<OsusrE9aCsicpGg008Cdn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_CDN");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_CDN");

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

            modelBuilder.Entity<CSICP_GG008Con>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_CON");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_CON");

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
            modelBuilder.Entity<CSICP_GG008Kit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_KIT");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_KIT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });
            modelBuilder.Entity<CSICP_GG008Efi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_EFIS");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_EFIS");

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

            modelBuilder.Entity<CSICP_GG008Gar>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_GAR");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_GAR");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Labelplural)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABELPLURAL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });





            modelBuilder.Entity<OsusrE9aCsicpGg008Tpcon>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_TPCON");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_TPCON");

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

            modelBuilder.Entity<OsusrE9aCsicpGg008Tran>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008_TRANS");

                entity.ToTable("OSUSR_E9A_CSICP_GG008_TRANS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Idcs)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("IDCS");
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

            modelBuilder.Entity<OsusrE9aCsicpGg008dTp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG008D_TP");

                entity.ToTable("OSUSR_E9A_CSICP_GG008D_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
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

            modelBuilder.Entity<CSICP_GG019Cgbar>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG019_CGBAR");

                entity.ToTable("OSUSR_E9A_CSICP_GG019_CGBAR");

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


            modelBuilder.Entity<OsusrE9aCsicpGg021cest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG021CEST");

                entity.ToTable("OSUSR_E9A_CSICP_GG021CEST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.CsCodg)
                    .HasMaxLength(2)
                    .HasDefaultValue("")
                    .HasColumnName("CS_CODG");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg023Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG023_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_GG023_TIPO");

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

            modelBuilder.Entity<CSICP_GG023Val>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG023_VAL");

                entity.ToTable("OSUSR_E9A_CSICP_GG023_VAL");

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

            modelBuilder.Entity<OsusrE9aCsicpGg025stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG025STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG025STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CodgCs)
                    .HasDefaultValue(0)
                    .HasColumnName("CODG_CS");
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

            modelBuilder.Entity<CSICP_GG028Entsai>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG028_ENTSAI");

                entity.ToTable("OSUSR_E9A_CSICP_GG028_ENTSAI");

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

            modelBuilder.Entity<OsusrE9aCsicpGg028Nat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG028_NAT");

                entity.ToTable("OSUSR_E9A_CSICP_GG028_NAT");

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

            modelBuilder.Entity<CSICP_GG028Tree>(entity =>
            {
                entity.HasKey(e => e.Gg028TreeId).HasName("OSPRK_OSUSR_E9A_CSICP_GG028_TREE");

                entity.ToTable("OSUSR_E9A_CSICP_GG028_TREE");

                entity.HasIndex(e => new { e.Gg028DoctoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_TREE_14GG028_DOCTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DoctoTipo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_TREE_16GG028_DOCTO_TIPO_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg028DoctoParentId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG028_TREE_21GG028_DOCTO_PARENT_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG028_TREE_9TENANT_ID");

                entity.Property(e => e.Gg028TreeId)
                    .HasMaxLength(36)
                    .HasColumnName("GG028_TREE_ID");
                entity.Property(e => e.Gg028Datahora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("GG028_DATAHORA");
                entity.Property(e => e.Gg028DoctoId)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_DOCTO_ID");
                entity.Property(e => e.Gg028DoctoParentId)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_DOCTO_PARENT_ID");
                entity.Property(e => e.Gg028DoctoProtocolnumber)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("GG028_DOCTO_PROTOCOLNUMBER");
                entity.Property(e => e.Gg028DoctoTipo)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG028_DOCTO_TIPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });


            modelBuilder.Entity<CSICP_GG030Sta>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG030_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG030_STA");

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

            modelBuilder.Entity<CSICP_GG030Est>(entity =>
            {
                entity.HasKey(e => e.Gg030aId).HasName("OSPRK_OSUSR_E9A_CSICP_GG030EST");

                entity.ToTable("OSUSR_E9A_CSICP_GG030EST");

                entity.HasIndex(e => new { e.Bb001Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030EST_8BB001_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg030Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG030EST_8GG030_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG030EST_9TENANT_ID");

                entity.Property(e => e.Gg030aId).HasColumnName("GG030A_ID");
                entity.Property(e => e.Bb001Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_ID");
                entity.Property(e => e.Gg030Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG030_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavBB001).WithOne().HasForeignKey<CSICP_GG030Est>(e => e.Bb001Id);

            });

            modelBuilder.Entity<OsusrE9aCsicpGg032Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG032_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG032_STA");

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
                entity.Property(e => e.Codgcs)
               .HasDefaultValue(0)
               .HasColumnName("CS_CODIGO");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg032Tpinv>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG032_TPINV");

                entity.ToTable("OSUSR_E9A_CSICP_GG032_TPINV");

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
                entity.Property(e => e.Codgcs)
                  .HasDefaultValue(0)
                  .HasColumnName("CS_CODIGO");
            });

            modelBuilder.Entity<OsusrE9aCsicpGg034Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG034_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG034_STA");

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

            modelBuilder.Entity<OsusrE9aCsicpGg034Tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG034_TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_GG034_TIPO");

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

            modelBuilder.Entity<OsusrE9aCsicpGg035Super>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG035_SUPER");

                entity.ToTable("OSUSR_E9A_CSICP_GG035_SUPER");

                entity.HasIndex(e => new { e.Gg035Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_SUPER_14GG035_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg035SaldoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_SUPER_14GG035_SALDO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg035Promocaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_GG035_SUPER_16GG035_PROMOCAOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_GG035_SUPER_9TENANT_ID");

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
                entity.Property(e => e.Gg035Produtoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_PRODUTOID");
                entity.Property(e => e.Gg035Promocaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_PROMOCAOID");
                entity.Property(e => e.Gg035SaldoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GG035_SALDO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<OsusrE9aCsicpGg039Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG039_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_GG039_STAT");

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

            modelBuilder.Entity<OsusrE9aCsicpGg041Tpreq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG041_TPREQ");

                entity.ToTable("OSUSR_E9A_CSICP_GG041_TPREQ");

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
            modelBuilder.Entity<OsusrE9aCsicpGg045Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG045_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_GG045_STAT");

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



            modelBuilder.Entity<OsusrE9aCsicpGg046Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG046_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_GG046_STAT");

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

            modelBuilder.Entity<OsusrE9aCsicpGg054Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG054_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG054_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
                    .HasColumnName("CODGCS");
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

            modelBuilder.Entity<OsusrE9aCsicpGg055Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG055_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG055_STA");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
                    .HasColumnName("CODGCS");
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

            modelBuilder.Entity<OsusrE9aCsicpGg065Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG065_TP");

                entity.ToTable("OSUSR_E9A_CSICP_GG065_TP");

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

            modelBuilder.Entity<OsusrE9aCsicpGg071Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG071_STA");

                entity.ToTable("OSUSR_E9A_CSICP_GG071_STA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
                    .HasColumnName("CODGCS");
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



            modelBuilder.Entity<CSICP_GG072Stq>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG072_STQ");

                entity.ToTable("OSUSR_E9A_CSICP_GG072_STQ");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codgcs)
                    .HasDefaultValue(0)
                    .HasColumnName("CODGCS");
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

            modelBuilder.Entity<OsusrE9aCsicpGg073Stat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG073_STAT");

                entity.ToTable("OSUSR_E9A_CSICP_GG073_STAT");

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

            modelBuilder.Entity<OsusrE9aCsicpGg073Tmov>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG073_TMOV");

                entity.ToTable("OSUSR_E9A_CSICP_GG073_TMOV");

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

            modelBuilder.Entity<OsusrE9aCsicpGg902St>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG902_ST");

                entity.ToTable("OSUSR_E9A_CSICP_GG902_ST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
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

            modelBuilder.Entity<OsusrE9aCsicpGg903tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_GG903TP");

                entity.ToTable("OSUSR_E9A_CSICP_GG903TP");

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

        }
    }
}
