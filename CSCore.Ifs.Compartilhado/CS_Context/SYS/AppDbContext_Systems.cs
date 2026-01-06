
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;
using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<Csicp_Sy001> OsusrE9aCsicpSy001s { get; set; }

        public DbSet<Csicp_Sy001Bio> OsusrE9aCsicpSy001Bios { get; set; }

        public DbSet<Csicp_Sy001Img> OsusrE9aCsicpSy001Imgs { get; set; }

        public DbSet<Csicp_Sy002> OsusrE9aCsicpSy002s { get; set; }

        public DbSet<Csicp_Sy003Regra> OsusrE9aCsicpSy003Regras { get; set; }

        public DbSet<Csicp_Sy004Rest> OsusrE9aCsicpSy004Rests { get; set; }

        public DbSet<CSICP_SY906_SPACE> CSICP_SY906_SPACE { get; set; }
        public DbSet<Csicp_Sy005> OsusrE9aCsicpSy005s { get; set; }

        public DbSet<Csicp_Sy006> OsusrE9aCsicpSy006s { get; set; }

        public DbSet<Csicp_Sy007> OsusrE9aCsicpSy007s { get; set; }

        public DbSet<Csicp_Sy008> OsusrE9aCsicpSy008s { get; set; }

        public DbSet<Csicp_Sy009> OsusrE9aCsicpSy009s { get; set; }


        //public DbSet<Csicp_Sy010> OsusrE9aCsicpSy010s { get; set; }

        //public DbSet<Csicp_Sy011> OsusrE9aCsicpSy011s { get; set; }

        //public DbSet<Csicp_Sy012> OsusrE9aCsicpSy012s { get; set; }

        public DbSet<Csicp_Sy013> OsusrE9aCsicpSy013s { get; set; }

        public DbSet<Csicp_Sy014> OsusrE9aCsicpSy014s { get; set; }

        public DbSet<Csicp_Sy015> OsusrE9aCsicpSy015s { get; set; }

        public DbSet<Csicp_Sy016> OsusrE9aCsicpSy016s { get; set; }

        public DbSet<Csicp_Sy016tipo> OsusrE9aCsicpSy016tipos { get; set; }

        public DbSet<Csicp_Sy017> OsusrE9aCsicpSy017s { get; set; }

        public DbSet<Csicp_Sy019> OsusrE9aCsicpSy019s { get; set; }

        public DbSet<Csicp_Sy020> OsusrE9aCsicpSy020s { get; set; }

        public DbSet<Csicp_Sy021> OsusrE9aCsicpSy021s { get; set; }
        public DbSet<Csicp_Sy025> OsusrE9aCsicpSy025s { get; set; }


        public DbSet<Csicp_Sy807Cssp> OsusrE9aCsicpSy807Cssps { get; set; }

        public DbSet<Csicp_Sy809Idioma> OsusrE9aCsicpSy809Idiomas { get; set; }

        public DbSet<Csicp_Sy899> OsusrE9aCsicpSy899s { get; set; }

        public DbSet<Csicp_Sy990> OsusrE9aCsicpSy990s { get; set; }

        public DbSet<Csicp_Sy991> OsusrE9aCsicpSy991s { get; set; }

        public DbSet<Csicp_Sy992> OsusrE9aCsicpSy992s { get; set; }

        public DbSet<Csicp_Sy993> OsusrE9aCsicpSy993s { get; set; }

        public DbSet<Csicp_Sy994> OsusrE9aCsicpSy994s { get; set; }

        public DbSet<Csicp_Sy994Padrao> OsusrE9aCsicpSy994Padraos { get; set; }

        public DbSet<Csicp_Sy995> OsusrE9aCsicpSy995s { get; set; }

        public DbSet<Csicp_Sy996> OsusrE9aCsicpSy996s { get; set; }

        public DbSet<Csicp_Sy999> OsusrE9aCsicpSy999s { get; set; }

        public DbSet<CsicpSy902Menu> OsusrI4yCsicpSy902Menus { get; set; }

        public DbSet<CsicpSy903Smenu> OsusrI4yCsicpSy903Smenus { get; set; }

        public DbSet<CsicpSy904Prg> OsusrI4yCsicpSy904Prgs { get; set; }

        public DbSet<CsicpSy905Smprg> OsusrI4yCsicpSy905Smprgs { get; set; }
        public DbSet<CSICP_SY997_LOGS> OsusrE9aCsicpSy997s { get; set; }

        public DbSet<OsusrE9aCsicpSy030> OsusrE9aCsicpSy030s { get; set; }

        public DbSet<OsusrE9aCsicpSy031> OsusrE9aCsicpSy031s { get; set; }

        public DbSet<OsusrE9aCsicpSy032> OsusrE9aCsicpSy032s { get; set; }

        public DbSet<OsusrE9aCsicpSy035> OsusrE9aCsicpSy035s { get; set; }

        public DbSet<OsusrE9aCsicpSy036> OsusrE9aCsicpSy036s { get; set; }

        public DbSet<OsusrE9aCsicpSy037> OsusrE9aCsicpSy037s { get; set; }

        public DbSet<OsusrE9aCsicpSy038> OsusrE9aCsicpSy038s { get; set; }

        public DbSet<OsusrE9aCsicpSy039> OsusrE9aCsicpSy039s { get; set; }

        public DbSet<OsusrE9aCsicpSy040> OsusrE9aCsicpSy040s { get; set; }

        public DbSet<OsusrE9aCsicpSy041> OsusrE9aCsicpSy041s { get; set; }

        public DbSet<OsusrE9aCsicpSy042> OsusrE9aCsicpSy042s { get; set; }

        public DbSet<OsusrE9aCsicpSy043> OsusrE9aCsicpSy043s { get; set; }


        partial void OnModelCreating_CSICP_Systems(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OsusrE9aCsicpSy030>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY030");

                entity.ToTable("OSUSR_E9A_CSICP_SY030");

                entity.HasIndex(e => new { e.Sy030Name, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY030_10SY030_NAME_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy030Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY030_15SY030_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY030_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy030Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("SY030_DESCRICAO");
                entity.Property(e => e.Sy030Isactive).HasColumnName("SY030_ISACTIVE");
                entity.Property(e => e.Sy030Name)
                    .HasMaxLength(100)
                    .HasColumnName("SY030_NAME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy031>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY031");

                entity.ToTable("OSUSR_E9A_CSICP_SY031");

                entity.HasIndex(e => new { e.Sy031Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY031_13SY031_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy031Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY031_15SY031_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY031_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy031Grupoid)
                    .HasMaxLength(36)
                    .HasColumnName("SY031_GRUPOID");
                entity.Property(e => e.Sy031Isactive).HasColumnName("SY031_ISACTIVE");
                entity.Property(e => e.Sy031Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("SY031_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<OsusrE9aCsicpSy032>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY032");

                entity.ToTable("OSUSR_E9A_CSICP_SY032");

                entity.HasIndex(e => new { e.Sy032Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY032_15SY032_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY032_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Attributename)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTENAME");
                entity.Property(e => e.Attributetype)
                    .HasMaxLength(20)
                    .HasColumnName("ATTRIBUTETYPE");
                entity.Property(e => e.Attributevalue)
                    .HasMaxLength(250)
                    .HasColumnName("ATTRIBUTEVALUE");
                entity.Property(e => e.Sy032Usuarioid)
                    .HasMaxLength(36)
                    .HasColumnName("SY032_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy035>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY035");

                entity.ToTable("OSUSR_E9A_CSICP_SY035");

                entity.HasIndex(e => e.Displayname, "OSIDX_OSUSR_E9A_CSICP_SY035_11DISPLAYNAME");

                entity.HasIndex(e => e.Name, "OSIDX_OSUSR_E9A_CSICP_SY035_4NAME");

                entity.HasIndex(e => e.Module, "OSIDX_OSUSR_E9A_CSICP_SY035_6MODULE");

                entity.HasIndex(e => e.Parentid, "OSIDX_OSUSR_E9A_CSICP_SY035_8PARENTID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Displayname)
                    .HasMaxLength(100)
                    .HasColumnName("DISPLAYNAME");
                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .HasColumnName("MODULE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.Parentid)
                    .HasMaxLength(36)
                    .HasColumnName("PARENTID");
                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .HasColumnName("PATH");
                entity.Property(e => e.Resourcetype)
                    .HasMaxLength(50)
                    .HasColumnName("RESOURCETYPE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY035_OSUSR_E9A_CSICP_SY035_PARENTID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy036>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY036");

                entity.ToTable("OSUSR_E9A_CSICP_SY036");

                entity.HasIndex(e => e.Resourceid, "OSIDX_OSUSR_E9A_CSICP_SY036_10RESOURCEID");

                entity.HasIndex(e => new { e.Resourceid, e.Actionname }, "OSIDX_OSUSR_E9A_CSICP_SY036_10RESOURCEID_10ACTIONNAME");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Actionname)
                    .HasMaxLength(50)
                    .HasColumnName("ACTIONNAME");
                entity.Property(e => e.Resourceid)
                    .HasMaxLength(36)
                    .HasColumnName("RESOURCEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Resource).WithMany(p => p.OsusrE9aCsicpSy036s)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY036_OSUSR_E9A_CSICP_SY035_RESOURCEID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy037>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY037");

                entity.ToTable("OSUSR_E9A_CSICP_SY037");

                entity.HasIndex(e => e.Resourceid, "OSIDX_OSUSR_E9A_CSICP_SY037_10RESOURCEID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Attributename)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTENAME");
                entity.Property(e => e.Attributetype)
                    .HasMaxLength(20)
                    .HasColumnName("ATTRIBUTETYPE");
                entity.Property(e => e.Attributevalue)
                    .HasMaxLength(250)
                    .HasColumnName("ATTRIBUTEVALUE");
                entity.Property(e => e.Resourceid)
                    .HasMaxLength(36)
                    .HasColumnName("RESOURCEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Resource).WithMany(p => p.OsusrE9aCsicpSy037s)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY037_OSUSR_E9A_CSICP_SY035_RESOURCEID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy038>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY038");

                entity.ToTable("OSUSR_E9A_CSICP_SY038");

                entity.HasIndex(e => e.Descripton, "OSIDX_OSUSR_E9A_CSICP_SY038_10DESCRIPTON");

                entity.HasIndex(e => e.Name, "OSIDX_OSUSR_E9A_CSICP_SY038_4NAME");

                entity.HasIndex(e => e.Priority, "OSIDX_OSUSR_E9A_CSICP_SY038_8PRIORITY");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Descripton)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTON");
                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.Policyjson).HasColumnName("POLICYJSON");
                entity.Property(e => e.Priority).HasColumnName("PRIORITY");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy039>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY039");

                entity.ToTable("OSUSR_E9A_CSICP_SY039");

                entity.HasIndex(e => e.Policyid, "OSIDX_OSUSR_E9A_CSICP_SY039_8POLICYID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Actions)
                    .HasMaxLength(250)
                    .HasColumnName("ACTIONS");
                entity.Property(e => e.Conditions)
                    .HasMaxLength(100)
                    .HasColumnName("CONDITIONS");
                entity.Property(e => e.Effect)
                    .HasMaxLength(50)
                    .HasColumnName("EFFECT");
                entity.Property(e => e.Policyid)
                    .HasMaxLength(36)
                    .HasColumnName("POLICYID");
                entity.Property(e => e.Priority).HasColumnName("PRIORITY");
                entity.Property(e => e.Resources)
                    .HasMaxLength(250)
                    .HasColumnName("RESOURCES");
                entity.Property(e => e.Rulename)
                    .HasMaxLength(50)
                    .HasColumnName("RULENAME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Policy).WithMany(p => p.OsusrE9aCsicpSy039s)
                    .HasForeignKey(d => d.Policyid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY039_OSUSR_E9A_CSICP_SY038_POLICYID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy040>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY040");

                entity.ToTable("OSUSR_E9A_CSICP_SY040");

                entity.HasIndex(e => e.Displayname, "OSIDX_OSUSR_E9A_CSICP_SY040_11DISPLAYNAME");

                entity.HasIndex(e => e.Fieldname, "OSIDX_OSUSR_E9A_CSICP_SY040_9FIELDNAME");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Controltype)
                    .HasMaxLength(30)
                    .HasColumnName("CONTROLTYPE");
                entity.Property(e => e.Datatype)
                    .HasMaxLength(20)
                    .HasColumnName("DATATYPE");
                entity.Property(e => e.Displayname)
                    .HasMaxLength(100)
                    .HasColumnName("DISPLAYNAME");
                entity.Property(e => e.Fieldname)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDNAME");
                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
                entity.Property(e => e.Optionssource)
                    .HasMaxLength(250)
                    .HasColumnName("OPTIONSSOURCE");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy041>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY041");

                entity.ToTable("OSUSR_E9A_CSICP_SY041");

                entity.HasIndex(e => e.Operator, "OSIDX_OSUSR_E9A_CSICP_SY041_8OPERATOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");
                entity.Property(e => e.Operator)
                    .HasMaxLength(20)
                    .HasColumnName("OPERATOR");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy042>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY042");

                entity.ToTable("OSUSR_E9A_CSICP_SY042");

                entity.HasIndex(e => e.Operatorid, "OSIDX_OSUSR_E9A_CSICP_SY042_10OPERATORID");

                entity.HasIndex(e => e.Filterid, "OSIDX_OSUSR_E9A_CSICP_SY042_8FILTERID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Filterid)
                    .HasMaxLength(36)
                    .HasColumnName("FILTERID");
                entity.Property(e => e.Operatorid)
                    .HasMaxLength(36)
                    .HasColumnName("OPERATORID");

                entity.HasOne(d => d.Filter).WithMany(p => p.OsusrE9aCsicpSy042s)
                    .HasForeignKey(d => d.Filterid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY042_OSUSR_E9A_CSICP_SY040_FILTERID");

                entity.HasOne(d => d.Operator).WithMany(p => p.OsusrE9aCsicpSy042s)
                    .HasForeignKey(d => d.Operatorid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY042_OSUSR_E9A_CSICP_SY041_OPERATORID");
            });

            modelBuilder.Entity<OsusrE9aCsicpSy043>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY043");

                entity.ToTable("OSUSR_E9A_CSICP_SY043");

                entity.HasIndex(e => e.Resourceid, "OSIDX_OSUSR_E9A_CSICP_SY043_10RESOURCEID");

                entity.HasIndex(e => e.Filterid, "OSIDX_OSUSR_E9A_CSICP_SY043_8FILTERID");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Filterid)
                    .HasMaxLength(36)
                    .HasColumnName("FILTERID");
                entity.Property(e => e.Isrequired).HasColumnName("ISREQUIRED");
                entity.Property(e => e.Orderindex).HasColumnName("ORDERINDEX");
                entity.Property(e => e.Resourceid)
                    .HasMaxLength(36)
                    .HasColumnName("RESOURCEID");

                entity.HasOne(d => d.Filter).WithMany(p => p.OsusrE9aCsicpSy043s)
                    .HasForeignKey(d => d.Filterid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY043_OSUSR_E9A_CSICP_SY040_FILTERID");

                entity.HasOne(d => d.Resource).WithMany(p => p.OsusrE9aCsicpSy043s)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY043_OSUSR_E9A_CSICP_SY035_RESOURCEID");
            });
            modelBuilder.HasSequence("Seq_PK_ID");

            modelBuilder.Entity<CSICP_SY997_LOGS>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY997");

                entity.ToTable("OSUSR_E9A_CSICP_SY997");

                entity.HasIndex(e => new { e.Sy997Datainc, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY997_13SY997_DATAINC_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy997ExternalId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY997_17SY997_EXTERNAL_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY997_9TENANT_ID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ID");
                entity.Property(e => e.JsonBody).HasColumnName("JSON_BODY");
                entity.Property(e => e.JsonHeader).HasColumnName("JSON_HEADER");
                entity.Property(e => e.JsonQuery).HasColumnName("JSON_QUERY");
                entity.Property(e => e.Sy997Datainc)
                    .HasColumnType("datetime")
                    .HasColumnName("SY997_DATAINC");
                entity.Property(e => e.Sy997ExternalId)
                    .HasMaxLength(36)
                    .HasColumnName("SY997_EXTERNAL_ID");
                entity.Property(e => e.Sy997Isexibiu).HasColumnName("SY997_ISEXIBIU");
                entity.Property(e => e.Sy997Mensagem).HasColumnName("SY997_MENSAGEM");
                entity.Property(e => e.Sy997Nomeusuario)
                    .HasMaxLength(100)
                    .HasColumnName("SY997_NOMEUSUARIO");
                entity.Property(e => e.Sy997Severidade)
                    .HasMaxLength(50)
                    .HasColumnName("SY997_SEVERIDADE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });


            modelBuilder.Entity<Csicp_Sy001>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY001");

                entity.ToTable("OSUSR_E9A_CSICP_SY001");

                entity.HasIndex(e => new { e.Sy001Nome, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_10SY001_NOME_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy001Usuario, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_13SY001_USUARIO_9TENANT_ID").IsUnique();

                entity.HasIndex(e => new { e.Sy001IdiomaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_15SY001_IDIOMA_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy001ExpiraSenha, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_18SY001_EXPIRA_SENHA_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy001Altsenhapxlogin, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_21SY001_ALTSENHAPXLOGIN_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy001Autalterarsenha, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_21SY001_AUTALTERARSENHA_9TENANT_ID");

                entity.HasIndex(e => new { e.Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_6USERID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY001_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy001Altsenhapxlogin)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY001_ALTSENHAPXLOGIN");
                entity.Property(e => e.Sy001Autalterarsenha)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY001_AUTALTERARSENHA");
                entity.Property(e => e.Sy001Bloqueado)
                    .HasDefaultValue(false)
                    .HasColumnName("SY001_BLOQUEADO");
                entity.Property(e => e.Sy001Cargo)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_CARGO");
                entity.Property(e => e.Sy001Celular)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_CELULAR");
                entity.Property(e => e.Sy001DataValidade)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY001_DATA_VALIDADE");
                entity.Property(e => e.Sy001Dataultimoacesso)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY001_DATAULTIMOACESSO");
                entity.Property(e => e.Sy001Deptolotado)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_DEPTOLOTADO");
                entity.Property(e => e.Sy001Dtexpiracaologin)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY001_DTEXPIRACAOLOGIN");
                entity.Property(e => e.Sy001Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_EMAIL");
                entity.Property(e => e.Sy001ExpiraSenha)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY001_EXPIRA_SENHA");
                entity.Property(e => e.Sy001IdiomaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY001_IDIOMA_ID");
                entity.Property(e => e.Sy001Imagem)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY001_IMAGEM");
                entity.Property(e => e.Sy001Nome)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_NOME");
                entity.Property(e => e.Sy001Senha)
                    .HasMaxLength(32)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_SENHA");
                entity.Property(e => e.Sy001Senhacs)
                    .HasMaxLength(128)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_SENHACS");
                entity.Property(e => e.Sy001Senhexpaposndias)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("SY001_SENHEXPAPOSNDIAS");
                entity.Property(e => e.Sy001Usuario)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY001_USUARIO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Userid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USERID");

                //entity.HasOne(d => d.Sy001Idioma).WithMany(p => p.OsusrE9aCsicpSy001s)
                //    .HasForeignKey(d => d.Sy001IdiomaId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY001_OSUSR_E9A_CSICP_SY809_IDIOMA_SY001_IDIOMA_ID");

                entity.HasOne(d => d.NavSY001_AlterarSenha).WithOne()
                    .HasForeignKey<Csicp_Sy001>(d => d.Sy001Autalterarsenha);

                entity.HasOne(d => d.NavSy001Altsenhapxlogin).WithOne()
                    .HasForeignKey<Csicp_Sy001>(d => d.Sy001Altsenhapxlogin);

                entity.HasOne(d => d.NavSy001ExpiraSenha).WithOne()
                    .HasForeignKey<Csicp_Sy001>(d => d.Sy001ExpiraSenha);

                entity.HasOne(d => d.NavSy001IdiomaId).WithOne()
                    .HasForeignKey<Csicp_Sy001>(d => d.Sy001IdiomaId);

                //entity.HasMany(d => d.OsusrE9aCsicpSy005s).WithOne()
                //    .HasForeignKey(g => g.Sy005Userid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY005_OSUSR_E9A_CSICP_SY001_SY005_USERID");

                entity.HasMany(d => d.OsusrE9aCsicpSy001Imgs).WithOne()
                    .HasForeignKey(g => g.UsuarioId);

                //entity.HasMany(d => d.OsusrE9aCsicpSy006s).WithOne()
                //     .HasForeignKey(r => r.Sy006Userid);


                //entity.HasMany(d => d.OsusrE9aCsicpSy021s).WithOne()
                //      .HasForeignKey(r => r.Sy0221Usuarioid);


            });

            modelBuilder.Entity<Csicp_Sy001Bio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY001_BIO");

                entity.ToTable("OSUSR_E9A_CSICP_SY001_BIO");

                entity.HasIndex(e => new { e.UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_BIO_10USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY001_BIO_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Biometria)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BIOMETRIA");
                entity.Property(e => e.BiometriaTexto)
                    .HasDefaultValue("")
                    .HasColumnName("BIOMETRIA_TEXTO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("NOME");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("TIPO");
                entity.Property(e => e.UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USUARIO_ID");

                //entity.HasOne(d => d.Usuario).WithMany(p => p.OsusrE9aCsicpSy001Bios)
                //    .HasForeignKey(d => d.UsuarioId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY001_BIO_OSUSR_E9A_CSICP_SY001_USUARIO_ID");
            });

            modelBuilder.Entity<Csicp_Sy001Img>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY001_IMG");

                entity.ToTable("OSUSR_E9A_CSICP_SY001_IMG");

                entity.HasIndex(e => new { e.UsuarioId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY001_IMG_10USUARIO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY001_IMG_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Ispadrao)
                    .HasDefaultValue(false)
                    .HasColumnName("ISPADRAO");
                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("NOME");
                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("PATH");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("TIPO");

                entity.Property(e => e.UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USUARIO_ID");

                //entity.HasOne(d => d.UsuarioId).WithMany(p => p.OsusrE9aCsicpSy001Imgs)
                //    .HasForeignKey(d => d.UsuarioId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY001_IMG_OSUSR_E9A_CSICP_SY001_USUARIO_ID");
            });

            modelBuilder.Entity<Csicp_Sy002>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY002");

                entity.ToTable("OSUSR_E9A_CSICP_SY002");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY002_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy002Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("SY002_DESCRICAO");
                entity.Property(e => e.Sy002Grupo)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("SY002_GRUPO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasMany(e => e.ListCSICP_Sy014).WithOne().HasForeignKey(e => e.Sy014Grupoid);
                //entity.HasMany(e => e.Lista_CSICP_SY015).WithOne().HasForeignKey(e => e.Sy015Grupoid);
                //entity.HasMany(e => e.List_CSICP_SY009).WithOne().HasForeignKey(e => e.Sy009Grupoid);
            });

            modelBuilder.Entity<Csicp_Sy003Regra>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY003_REGRAS");

                entity.ToTable("OSUSR_E9A_CSICP_SY003_REGRAS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CsOrder)
                    .HasDefaultValue(0)
                    .HasColumnName("CS_ORDER");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(120)
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

            modelBuilder.Entity<Csicp_Sy004Rest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY004_REST");

                entity.ToTable("OSUSR_E9A_CSICP_SY004_REST");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(120)
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

            modelBuilder.Entity<Csicp_Sy005>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY005");

                entity.ToTable("OSUSR_E9A_CSICP_SY005");

                entity.HasIndex(e => new { e.Sy005Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY005_12SY005_USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy005Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY005_13SY005_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY005_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy005Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY005_GRUPOID");
                entity.Property(e => e.Sy005Userid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY005_USERID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Sy005Grupo).WithOne()
                    .HasForeignKey<Csicp_Sy005>(d => d.Sy005Grupoid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY005_OSUSR_E9A_CSICP_SY002_SY005_GRUPOID");

                entity.HasOne(d => d.Sy014GrupoMenu).WithOne()
                .HasForeignKey<Csicp_Sy005>(d => d.Sy005Grupoid)
                .HasPrincipalKey<Csicp_Sy014>(u => u.Sy014Grupoid);

            });

            modelBuilder.Entity<Csicp_Sy006>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY006");

                entity.ToTable("OSUSR_E9A_CSICP_SY006");

                entity.HasIndex(e => new { e.Sy006Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY006_12SY006_USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy006RegraestaticaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY006_22SY006_REGRAESTATICA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY006_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy006RegraestaticaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY006_REGRAESTATICA_ID");
                entity.Property(e => e.Sy006Userid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY006_USERID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Sy006Regraestatica).WithMany(p => p.OsusrE9aCsicpSy006s)
                //    .HasForeignKey(d => d.Sy006RegraestaticaId)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY006_OSUSR_E9A_CSICP_SY003_REGRAS_SY006_REGRAESTATICA_ID");


            });

            modelBuilder.Entity<Csicp_Sy007>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY007");

                entity.ToTable("OSUSR_E9A_CSICP_SY007");

                entity.HasIndex(e => new { e.Sy007Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY007_13SY007_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy007RegraestaticaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY007_22SY007_REGRAESTATICA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY007_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy007Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY007_GRUPOID");
                entity.Property(e => e.Sy007RegraestaticaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY007_REGRAESTATICA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });

            modelBuilder.Entity<Csicp_Sy008>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY008");

                entity.ToTable("OSUSR_E9A_CSICP_SY008");

                entity.HasIndex(e => new { e.Sy008Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY008_12SY008_USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy008RestricaoestatId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY008_23SY008_RESTRICAOESTAT_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY008_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy008RestricaoestatId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY008_RESTRICAOESTAT_ID");
                entity.Property(e => e.Sy008Userid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY008_USERID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Sy008Restricaoestat).WithMany(p => p.OsusrE9aCsicpSy008s)
                    .HasForeignKey(d => d.Sy008RestricaoestatId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY008_OSUSR_E9A_CSICP_SY004_REST_SY008_RESTRICAOESTAT_ID");

            });

            modelBuilder.Entity<Csicp_Sy009>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY009");

                entity.ToTable("OSUSR_E9A_CSICP_SY009");

                entity.HasIndex(e => new { e.Sy009Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY009_13SY009_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy904ProgramaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY009_17SY904_PROGRAMA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY009_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy009Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY009_GRUPOID");
                entity.Property(e => e.Sy904ProgramaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY904_PROGRAMA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(e => e.NavSY904Prg).WithOne().HasForeignKey<Csicp_Sy009>(e => e.Sy904ProgramaId);
            });

            modelBuilder.Entity<CsicpSy902Menu>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_I4Y_CSICP_SY902_MENU");

                entity.ToTable("OSUSR_I4Y_CSICP_SY902_MENU");

                entity.HasIndex(e => e.Categoriaid, "OSIDX_OSUSR_I4Y_CSICP_SY902_MENU_11CATEGORIAID");

                entity.HasIndex(e => e.PropCsSisproId, "OSIDX_OSUSR_I4Y_CSICP_SY902_MENU_17PROP_CS_SISPRO_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Categoriaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CATEGORIAID");
                entity.Property(e => e.Cor)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("COR");
                entity.Property(e => e.Datacreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATACREATE");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.DescricaoEnglish)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_ENGLISH");
                entity.Property(e => e.DescricaoSpanish)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_SPANISH");
                entity.Property(e => e.Dimensoes)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DIMENSOES");
                entity.Property(e => e.Fonticon)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("FONTICON");
                entity.Property(e => e.IdSy802)
                    .HasDefaultValue(0)
                    .HasColumnName("ID_SY802");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.LabelEnglish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_ENGLISH");
                entity.Property(e => e.LabelSpanish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_SPANISH");
                entity.Property(e => e.Menu)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("MENU");
                entity.Property(e => e.Menutipo)
                    .HasDefaultValue(0)
                    .HasColumnName("MENUTIPO");
                entity.Property(e => e.Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDEM");
                entity.Property(e => e.PropCsSisproId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROP_CS_SISPRO_ID");
                entity.Property(e => e.Url)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("URL");

                entity.HasMany(e => e.ListaSubmenus).WithOne().HasForeignKey(e => e.Menu);


                //entity.HasMany(e => e.ListCSICP_Sy014).WithOne().HasForeignKey(e => e.Sy902MenuId);
            });

            modelBuilder.Entity<CsicpSy903Smenu>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_I4Y_CSICP_SY903_SMENU");

                entity.ToTable("OSUSR_I4Y_CSICP_SY903_SMENU");

                entity.HasIndex(e => e.Categoriaid, "OSIDX_OSUSR_I4Y_CSICP_SY903_SMENU_11CATEGORIAID");

                entity.HasIndex(e => e.PropCsSisproId, "OSIDX_OSUSR_I4Y_CSICP_SY903_SMENU_17PROP_CS_SISPRO_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Categoriaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CATEGORIAID");
                entity.Property(e => e.Cor)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("COR");
                entity.Property(e => e.Datacreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATACREATE");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.DescricaoEnglish)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_ENGLISH");
                entity.Property(e => e.DescricaoSpanish)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_SPANISH");
                entity.Property(e => e.Dimensao)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DIMENSAO");
                entity.Property(e => e.Fonticon)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("FONTICON");
                entity.Property(e => e.IdSy803)
                    .HasDefaultValue(0)
                    .HasColumnName("ID_SY803");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.LabelEnglish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_ENGLISH");
                entity.Property(e => e.LabelSpanish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_SPANISH");
                entity.Property(e => e.Menu)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("MENU");
                entity.Property(e => e.Menutipo)
                    .HasDefaultValue(0)
                    .HasColumnName("MENUTIPO");
                entity.Property(e => e.Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDEM");
                entity.Property(e => e.PropCsSisproId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROP_CS_SISPRO_ID");
                entity.Property(e => e.Submenu)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SUBMENU");
                entity.Property(e => e.Url)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("URL");

                entity.HasMany(e => e.ListaSubMenuProgramas).WithOne().HasForeignKey(e => e.Submenu);
                //entity.HasMany(e => e.Lista_CSICP_SY015).WithOne().HasForeignKey(e => e.Sy903SubmenuId);


            });

            modelBuilder.Entity<CsicpSy904Prg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_I4Y_CSICP_SY904_PRG");

                entity.ToTable("OSUSR_I4Y_CSICP_SY904_PRG");

                entity.HasIndex(e => e.Categoriaid, "OSIDX_OSUSR_I4Y_CSICP_SY904_PRG_11CATEGORIAID");

                entity.HasIndex(e => e.PropCsSisproId, "OSIDX_OSUSR_I4Y_CSICP_SY904_PRG_17PROP_CS_SISPRO_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Categoriaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CATEGORIAID");
                entity.Property(e => e.Cor)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("COR");
                entity.Property(e => e.Datacreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATACREATE");
                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO");
                entity.Property(e => e.DescricaoEnglish)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_ENGLISH");
                entity.Property(e => e.DescricaoSpanish)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRICAO_SPANISH");
                entity.Property(e => e.Dimensao)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("DIMENSAO");
                entity.Property(e => e.Fonticon)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("FONTICON");
                entity.Property(e => e.IdSy804)
                    .HasDefaultValue(0)
                    .HasColumnName("ID_SY804");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.LabelEnglish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_ENGLISH");
                entity.Property(e => e.LabelSpanish)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_SPANISH");
                entity.Property(e => e.Menutipo)
                    .HasDefaultValue(0)
                    .HasColumnName("MENUTIPO");
                entity.Property(e => e.Nivelprograma)
                    .HasDefaultValue(0)
                    .HasColumnName("NIVELPROGRAMA");
                entity.Property(e => e.Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDEM");
                entity.Property(e => e.Programa)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("PROGRAMA");
                entity.Property(e => e.PropCsSisproId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROP_CS_SISPRO_ID");
                entity.Property(e => e.SpacenameId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SPACENAME_ID");
                entity.Property(e => e.Url)
                    .HasMaxLength(120)
                    .HasDefaultValue("")
                    .HasColumnName("URL");

                //entity.HasOne(e => e.NavSY905SMprg).WithOne().HasForeignKey<CsicpSy905Smprg>(e => e.Programa);
            });

            modelBuilder.Entity<CsicpSy905Smprg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_I4Y_CSICP_SY905_SMPRG");

                entity.ToTable("OSUSR_I4Y_CSICP_SY905_SMPRG");

                entity.HasIndex(e => e.PropCsSisproId, "OSIDX_OSUSR_I4Y_CSICP_SY905_SMPRG_17PROP_CS_SISPRO_ID");

                entity.HasIndex(e => new { e.Submenu, e.Programa, e.Ordem }, "OSIDX_OSUSR_I4Y_CSICP_SY905_SMPRG_7SUBMENU_8PROGRAMA_5ORDEM");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.IdSy805)
                    .HasDefaultValue(0)
                    .HasColumnName("ID_SY805");
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(false)
                    .HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Ordem)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDEM");
                entity.Property(e => e.Programa)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROGRAMA");
                entity.Property(e => e.PropCsSisproId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROP_CS_SISPRO_ID");
                entity.Property(e => e.Submenu)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SUBMENU");

                entity.HasOne(e => e.NavPrograma).WithOne()
                     .HasForeignKey<CsicpSy905Smprg>(e => e.Programa);


            });


            modelBuilder.Entity<Csicp_Sy013>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY013");

                entity.ToTable("OSUSR_E9A_CSICP_SY013");

                entity.HasIndex(e => new { e.Sy013Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY013_14SY013_FILIALID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy013Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY013_15SY013_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY013_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy013Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY013_FILIALID");
                entity.Property(e => e.Sy013Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY013_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.NavCSICP_BB001).WithOne().HasForeignKey<Csicp_Sy013>(e => e.Sy013Filialid);

            });

            modelBuilder.Entity<Csicp_Sy014>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY014");

                entity.ToTable("OSUSR_E9A_CSICP_SY014");

                entity.HasIndex(e => new { e.Sy014Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY014_13SY014_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy902MenuId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY014_13SY902_MENU_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY014_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy014Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY014_GRUPOID");
                entity.Property(e => e.Sy902MenuId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY902_MENU_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(e => e.CsicpSy902Menu).WithOne().HasForeignKey<Csicp_Sy014>(e => e.Sy902MenuId);
                entity.HasOne(e => e.Sy014Grupo).WithOne().HasForeignKey<Csicp_Sy014>(e => e.Sy014Grupoid);
            });

            modelBuilder.Entity<Csicp_Sy015>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY015");

                entity.ToTable("OSUSR_E9A_CSICP_SY015");

                entity.HasIndex(e => new { e.Sy015Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY015_13SY015_GRUPOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy903SubmenuId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY015_16SY903_SUBMENU_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY015_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy015Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY015_GRUPOID");
                entity.Property(e => e.Sy903SubmenuId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY903_SUBMENU_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.HasOne(e => e.NavSY903SubMenu).WithOne().HasForeignKey<Csicp_Sy015>(e => e.Sy903SubmenuId);

            });

            modelBuilder.Entity<Csicp_Sy016>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY016");

                entity.ToTable("OSUSR_E9A_CSICP_SY016");

                entity.HasIndex(e => e.Codigoacesso, "OSIDX_OSUSR_E9A_CSICP_SY016_12CODIGOACESSO").IsUnique();

                entity.HasIndex(e => e.Usuariocriacao, "OSIDX_OSUSR_E9A_CSICP_SY016_14USUARIOCRIACAO");

                entity.HasIndex(e => e.Tipoacessorapidoid, "OSIDX_OSUSR_E9A_CSICP_SY016_18TIPOACESSORAPIDOID");

                entity.HasIndex(e => e.Linkusuarioestabecimentoid, "OSIDX_OSUSR_E9A_CSICP_SY016_26LINKUSUARIOESTABECIMENTOID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Codigoacesso)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("CODIGOACESSO");
                entity.Property(e => e.Dataativacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATAATIVACAO");
                entity.Property(e => e.Datacriacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATACRIACAO");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Linkusuarioestabecimentoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("LINKUSUARIOESTABECIMENTOID");
                entity.Property(e => e.TenantId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipoacessorapidoid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("TIPOACESSORAPIDOID");
                entity.Property(e => e.Usuariocriacao)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USUARIOCRIACAO");

                entity.HasOne(d => d.Linkusuarioestabecimento).WithOne()
                    .HasForeignKey<Csicp_Sy016>(d => d.Linkusuarioestabecimentoid);

                entity.HasOne(d => d.Tipoacessorapido).WithMany(p => p.OsusrE9aCsicpSy016s)
                    .HasForeignKey(d => d.Tipoacessorapidoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY016_OSUSR_E9A_CSICP_SY016TIPO_TIPOACESSORAPIDOID");


            });

            modelBuilder.Entity<Csicp_Sy016tipo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY016TIPO");

                entity.ToTable("OSUSR_E9A_CSICP_SY016TIPO");

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

            modelBuilder.Entity<Csicp_Sy017>(entity =>
            {
                entity.HasKey(e => e.Sy017Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY017");

                entity.ToTable("OSUSR_E9A_CSICP_SY017");

                entity.HasIndex(e => new { e.Sy017Hashunico, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY017_15SY017_HASHUNICO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY017_9TENANT_ID");

                entity.Property(e => e.Sy017Id)
                    .HasMaxLength(36)
                    .HasColumnName("SY017_ID");
                entity.Property(e => e.ProcessId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("PROCESS_ID");
                entity.Property(e => e.Sy017CountAtualizados)
                    .HasDefaultValue(0)
                    .HasColumnName("SY017_COUNT_ATUALIZADOS");
                entity.Property(e => e.Sy017CountRelatorios)
                    .HasDefaultValue(0)
                    .HasColumnName("SY017_COUNT_RELATORIOS");
                entity.Property(e => e.Sy017Dataultatualizacao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY017_DATAULTATUALIZACAO");
                entity.Property(e => e.Sy017Hashunico)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("SY017_HASHUNICO");
                entity.Property(e => e.Sy017Mensagem)
                    .HasMaxLength(512)
                    .HasDefaultValue("")
                    .HasColumnName("SY017_MENSAGEM");
                entity.Property(e => e.Sy017Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY017_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy019>(entity =>
            {
                entity.HasKey(e => e.Sy019Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY019");

                entity.ToTable("OSUSR_E9A_CSICP_SY019");

                entity.HasIndex(e => new { e.Sy019Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY019_12SY019_USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy904ProgramaId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY019_17SY904_PROGRAMA_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY019_9TENANT_ID");

                entity.Property(e => e.Sy019Id).HasColumnName("SY019_ID");
                entity.Property(e => e.Sy019Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("SY019_ISACTIVE");
                entity.Property(e => e.Sy019Userid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY019_USERID");
                entity.Property(e => e.Sy904ProgramaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY904_PROGRAMA_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<Csicp_Sy020>(entity =>
            {
                entity.HasKey(e => e.Sy020Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY020");

                entity.ToTable("OSUSR_E9A_CSICP_SY020");

                entity.HasIndex(e => new { e.Sy020Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY020_15SY020_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy020Mac, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY020_9SY020_MAC_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY020_9TENANT_ID");

                entity.Property(e => e.Sy020Id).HasColumnName("SY020_ID");
                entity.Property(e => e.Sy020Dcreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY020_DCREATE");
                entity.Property(e => e.Sy020Isautorizado)
                    .HasDefaultValue(false)
                    .HasColumnName("SY020_ISAUTORIZADO");
                entity.Property(e => e.Sy020Mac)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY020_MAC");
                entity.Property(e => e.Sy020Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY020_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<Csicp_Sy021>(entity =>
            {
                entity.HasKey(e => e.Sy021Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY021");

                entity.ToTable("OSUSR_E9A_CSICP_SY021");

                entity.HasIndex(e => new { e.Sy0221Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY021_16SY0221_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY021_9TENANT_ID");

                entity.Property(e => e.Sy021Id).HasColumnName("SY021_ID");
                entity.Property(e => e.Sy021Acesso)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("SY021_ACESSO");
                entity.Property(e => e.Sy021Dlimite)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY021_DLIMITE");
                entity.Property(e => e.Sy0221Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY0221_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });
            modelBuilder.Entity<Csicp_Sy025>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY025");

                entity.ToTable("OSUSR_E9A_CSICP_SY025");

                entity.HasIndex(e => new { e.Sy025Tipotoken, e.Sy025Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY025_15SY025_TIPOTOKEN_15SY025_USUARIOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY025_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy025Dtcreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY025_DTCREATE");
                entity.Property(e => e.Sy025Refreshexpiredtime)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY025_REFRESHEXPIREDTIME");
                entity.Property(e => e.Sy025Refreshtoken)
                    .HasMaxLength(500)
                    .HasDefaultValue("")
                    .HasColumnName("SY025_REFRESHTOKEN");
                entity.Property(e => e.Sy025Tipotoken)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY025_TIPOTOKEN");
                entity.Property(e => e.Sy025Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY025_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy807Cssp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY807_CSSP");

                entity.ToTable("OSUSR_E9A_CSICP_SY807_CSSP");

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

            modelBuilder.Entity<Csicp_Sy809Idioma>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY809_IDIOMA");

                entity.ToTable("OSUSR_E9A_CSICP_SY809_IDIOMA");

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

            modelBuilder.Entity<Csicp_Sy899>(entity =>
            {
                entity.HasKey(e => e.Sy899Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY899");

                entity.ToTable("OSUSR_E9A_CSICP_SY899");

                entity.HasIndex(e => new { e.Sy899Tabela, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY899_12SY899_TABELA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY899_9TENANT_ID");

                entity.Property(e => e.Sy899Id).HasColumnName("SY899_ID");
                entity.Property(e => e.Sy899Dcreate)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY899_DCREATE");
                entity.Property(e => e.Sy899Sequence)
                    .HasDefaultValue(0L)
                    .HasColumnName("SY899_SEQUENCE");
                entity.Property(e => e.Sy899Tabela)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("SY899_TABELA");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy990>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY990");

                entity.ToTable("OSUSR_E9A_CSICP_SY990");

                entity.HasIndex(e => new { e.Auditarsistema, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY990_14AUDITARSISTEMA_9TENANT_ID");

                entity.HasIndex(e => new { e.Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY990_6USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Auditar, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY990_7AUDITAR_9TENANT_ID");

                entity.HasIndex(e => new { e.Grupoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY990_7GRUPOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY990_9TENANT_ID");

                entity.HasIndex(e => new { e.Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY990_9USUARIOID_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Auditar)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AUDITAR");
                entity.Property(e => e.Auditarsistema)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AUDITARSISTEMA");
                entity.Property(e => e.Grupoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("GRUPOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Userid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USERID");
                entity.Property(e => e.Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USUARIOID");

            });

            modelBuilder.Entity<Csicp_Sy991>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY991");

                entity.ToTable("OSUSR_E9A_CSICP_SY991");

                entity.HasIndex(e => new { e.Userid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY991_6USERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Datahora, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY991_8DATAHORA_9TENANT_ID");

                entity.HasIndex(e => new { e.Filialid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY991_8FILIALID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY991_9TENANT_ID");

                entity.HasIndex(e => new { e.Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY991_9USUARIOID_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Datahora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("DATAHORA");
                entity.Property(e => e.EstacaoIp)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("ESTACAO_IP");
                entity.Property(e => e.EstacaoNome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("ESTACAO_NOME");
                entity.Property(e => e.Filialid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("FILIALID");
                entity.Property(e => e.Funcionalidadechave)
                    .HasMaxLength(256)
                    .HasDefaultValue("")
                    .HasColumnName("FUNCIONALIDADECHAVE");
                entity.Property(e => e.Operacao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("OPERACAO");
                entity.Property(e => e.Registroid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("REGISTROID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Userid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USERID");
                entity.Property(e => e.Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("USUARIOID");
                entity.Property(e => e.Usuarionome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("USUARIONOME");

            });

            modelBuilder.Entity<Csicp_Sy992>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY992");

                entity.ToTable("OSUSR_E9A_CSICP_SY992");

                entity.HasIndex(e => new { e.Auditoriaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY992_11AUDITORIAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY992_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Auditoriaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("AUDITORIAID");
                entity.Property(e => e.Entidadeid)
                    .HasDefaultValue(0)
                    .HasColumnName("ENTIDADEID");
                entity.Property(e => e.Entidateattrid)
                    .HasDefaultValue(0)
                    .HasColumnName("ENTIDATEATTRID");
                entity.Property(e => e.EspaceidEntidade)
                    .HasDefaultValue(0)
                    .HasColumnName("ESPACEID_ENTIDADE");
                entity.Property(e => e.LabelEntidade)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL_ENTIDADE");
                entity.Property(e => e.Labelcampo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABELCAMPO");
                entity.Property(e => e.NomeEntidade)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("NOME_ENTIDADE");
                entity.Property(e => e.Nomecampo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("NOMECAMPO");
                entity.Property(e => e.Registroid)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("REGISTROID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipodedado)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("TIPODEDADO");
                entity.Property(e => e.Valorantigo)
                    .HasMaxLength(1500)
                    .HasDefaultValue("")
                    .HasColumnName("VALORANTIGO");
                entity.Property(e => e.Valornovo)
                    .HasMaxLength(1500)
                    .HasDefaultValue("")
                    .HasColumnName("VALORNOVO");

                entity.HasOne(d => d.Auditoria).WithMany(p => p.OsusrE9aCsicpSy992s)
                    .HasForeignKey(d => d.Auditoriaid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY992_OSUSR_E9A_CSICP_SY991_AUDITORIAID");
            });

            modelBuilder.Entity<Csicp_Sy993>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY993");

                entity.ToTable("OSUSR_E9A_CSICP_SY993");

                entity.HasIndex(e => new { e.Sy993EmpresaId, e.Sy993Modulo, e.Sy993Data, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY993_16SY993_EMPRESA_ID_12SY993_MODULO_10SY993_DATA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY993_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy993Data)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY993_DATA");
                entity.Property(e => e.Sy993Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("SY993_DESCRICAO");
                entity.Property(e => e.Sy993EmpresaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY993_EMPRESA_ID");
                entity.Property(e => e.Sy993Modulo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY993_MODULO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy994>(entity =>
            {
                entity.HasKey(e => e.Sy994Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY994");

                entity.ToTable("OSUSR_E9A_CSICP_SY994");

                entity.HasIndex(e => new { e.Sy994PadraoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY994_15SY994_PADRAO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Sy994ExternalId, e.Sy994PadraoId, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY994_17SY994_EXTERNAL_ID_15SY994_PADRAO_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY994_9TENANT_ID");

                entity.Property(e => e.Sy994Id)
                    .HasMaxLength(36)
                    .HasColumnName("SY994_ID");
                entity.Property(e => e.Sy994Datainclusao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY994_DATAINCLUSAO");
                entity.Property(e => e.Sy994EstabId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY994_ESTAB_ID");
                entity.Property(e => e.Sy994ExternalId)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("SY994_EXTERNAL_ID");
                entity.Property(e => e.Sy994PadraoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY994_PADRAO_ID");
                entity.Property(e => e.Sy994Padraofixo)
                    .HasDefaultValue(false)
                    .HasColumnName("SY994_PADRAOFIXO");
                entity.Property(e => e.Sy994UsuarioId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY994_USUARIO_ID");
                entity.Property(e => e.Sy994UsuarioincId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY994_USUARIOINC_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Sy994Padrao).WithMany(p => p.OsusrE9aCsicpSy994s)
                    .HasForeignKey(d => d.Sy994PadraoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_SY994_OSUSR_E9A_CSICP_SY994_PADRAO_SY994_PADRAO_ID");
            });

            modelBuilder.Entity<Csicp_Sy994Padrao>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY994_PADRAO");

                entity.ToTable("OSUSR_E9A_CSICP_SY994_PADRAO");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Descritivo)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("DESCRITIVO");
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

            modelBuilder.Entity<Csicp_Sy995>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY995");

                entity.ToTable("OSUSR_E9A_CSICP_SY995");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY995_9TENANT_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Mensagem)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("MENSAGEM");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy996>(entity =>
            {
                entity.HasKey(e => e.Sy996Id).HasName("OSPRK_OSUSR_E9A_CSICP_SY996");

                entity.ToTable("OSUSR_E9A_CSICP_SY996");

                entity.HasIndex(e => new { e.Sy996EmpresaId, e.Sy996Objeto, e.Sy996Datahora, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY996_16SY996_EMPRESA_ID_12SY996_OBJETO_14SY996_DATAHORA_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY996_9TENANT_ID");

                entity.Property(e => e.Sy996Id)
                    .HasMaxLength(36)
                    .HasColumnName("SY996_ID");
                entity.Property(e => e.Sy996Datahora)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY996_DATAHORA");
                entity.Property(e => e.Sy996Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("SY996_DESCRICAO");
                entity.Property(e => e.Sy996EmpresaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY996_EMPRESA_ID");
                entity.Property(e => e.Sy996Nometimer)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY996_NOMETIMER");
                entity.Property(e => e.Sy996Nomeusuario)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY996_NOMEUSUARIO");
                entity.Property(e => e.Sy996Objeto)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("SY996_OBJETO");
                entity.Property(e => e.Sy996Objid)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("SY996_OBJID");
                entity.Property(e => e.Sy996Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY996_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<Csicp_Sy999>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("OSPRK_OSUSR_E9A_CSICP_SY999")
                    .HasFillFactor(70);

                entity.ToTable("OSUSR_E9A_CSICP_SY999");

                entity.HasIndex(e => new { e.Sy999Dataalt, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY999_13SY999_DATAALT_9TENANT_ID").HasFillFactor(70);

                entity.HasIndex(e => new { e.Sy999Usuarioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY999_15SY999_USUARIOID_9TENANT_ID").HasFillFactor(70);

                entity.HasIndex(e => new { e.Id, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_SY999_2ID_9TENANT_ID")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_SY999_9TENANT_ID").HasFillFactor(70);

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Sy999Alteradopor)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY999_ALTERADOPOR");
                entity.Property(e => e.Sy999Criadopor)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("SY999_CRIADOPOR");
                entity.Property(e => e.Sy999Dataalt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY999_DATAALT");
                entity.Property(e => e.Sy999Datainc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY999_DATAINC");
                entity.Property(e => e.Sy999Horaalt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY999_HORAALT");
                entity.Property(e => e.Sy999Horainc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("SY999_HORAINC");
                entity.Property(e => e.Sy999Usuarioid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("SY999_USUARIOID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            });
        }
    }
}
