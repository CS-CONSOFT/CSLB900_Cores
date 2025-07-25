
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_BB.BB06X;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; }

        public DbSet<CSICP_Bb061> OsusrE9aCsicpBb061s { get; set; }

        public DbSet<CSICP_Bb061Tp> OsusrE9aCsicpBb061Tps { get; set; }

        public DbSet<CSICP_Bb062> OsusrE9aCsicpBb062s { get; set; }

        public DbSet<CSICP_Bb062Stum> OsusrE9aCsicpBb062Sta { get; set; }

        public DbSet<CSICP_Bb064> OsusrE9aCsicpBb064s { get; set; }

        public DbSet<CSICP_Bb065> OsusrE9aCsicpBb065s { get; set; }

        public DbSet<CSICP_BB063> CsicpBb063s { get; set; }

        public DbSet<CSICP_Bb066> OsusrE9aCsicpBb066s { get; set; }

        public DbSet<CSICP_Bb067> OsusrE9aCsicpBb067s { get; set; }
        partial void OnModelCreating_CSICP_BB06X(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CSICP_Bb060>(entity =>
            {
                entity.HasKey(e => e.Bb060Convenioid).HasName("OSPRK_OSUSR_E9A_CSICP_BB060");

                entity.ToTable("OSUSR_E9A_CSICP_BB060");

                entity.HasIndex(e => new { e.Bb060Codigo, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_12BB060_CODIGO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Ccustoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_14BB060_CCUSTOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_15BB060_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Condicaoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_16BB060_CONDICAOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Usuarioalt, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_16BB060_USUARIOALT_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Usuarioinc, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_16BB060_USUARIOINC_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Agcobradorid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_18BB060_AGCOBRADORID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Convmasterid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_18BB060_CONVMASTERID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Responsavelid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_19BB060_RESPONSAVELID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Tipocobrancaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_20BB060_TIPOCOBRANCAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Usuarioproprieid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB060_22BB060_USUARIOPROPRIEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB060_9TENANT_ID");

                entity.Property(e => e.Bb060Convenioid).HasColumnName("BB060_CONVENIOID");
                entity.Property(e => e.Bb060Agcobradorid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_AGCOBRADORID");
                entity.Property(e => e.Bb060Ccustoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_CCUSTOID");
                entity.Property(e => e.Bb060Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB060_CODIGO");
                entity.Property(e => e.Bb060Condicaoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_CONDICAOID");
                entity.Property(e => e.Bb060Convmasterid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_CONVMASTERID");
                entity.Property(e => e.Bb060Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB060_DESCRICAO");
                entity.Property(e => e.Bb060Dthralt)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB060_DTHRALT");
                entity.Property(e => e.Bb060Dthrinc)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB060_DTHRINC");
                entity.Property(e => e.Bb060Especieid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_ESPECIEID");
                entity.Property(e => e.Bb060FpagtoId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_FPAGTO_ID");
                entity.Property(e => e.Bb060Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB060_ISACTIVE");
                entity.Property(e => e.Bb060Responsavelid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_RESPONSAVELID");
                entity.Property(e => e.Bb060Tipocobrancaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_TIPOCOBRANCAID");
                entity.Property(e => e.Bb060Usuarioalt)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_USUARIOALT");
                entity.Property(e => e.Bb060Usuarioinc)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_USUARIOINC");
                entity.Property(e => e.Bb060Usuarioproprieid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_USUARIOPROPRIEID");
                entity.Property(e => e.Bb060Vbase)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB060_VBASE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb060Agcobrador).WithMany(p => p.OsusrE9aCsicpBb060s)
                //    .HasForeignKey(d => d.Bb060Agcobradorid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB006_BB060_AGCOBRADORID");

                entity.HasOne(d => d.Bb060Ccusto).WithOne()
                    .HasForeignKey<CSICP_Bb060>(d => d.Bb060Ccustoid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB005_BB060_CCUSTOID");

                entity.HasOne(d => d.FormaPagamento).WithOne()
                    .HasForeignKey<CSICP_Bb060>(d => d.Bb060FpagtoId);



                //entity.HasOne(d => d.Bb060Condicao).WithMany(p => p.OsusrE9aCsicpBb060s)
                //    .HasForeignKey(d => d.Bb060Condicaoid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB008_BB060_CONDICAOID");

                //entity.HasOne(d => d.Bb060Convmaster).WithMany(p => p.OsusrE9aCsicpBb060s)
                //    .HasForeignKey(d => d.Bb060Convmasterid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB067_BB060_CONVMASTERID");

                //entity.HasOne(d => d.Bb060Responsavel).WithMany(p => p.OsusrE9aCsicpBb060s)
                //    .HasForeignKey(d => d.Bb060Responsavelid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB007_BB060_RESPONSAVELID");

                //entity.HasOne(d => d.Bb060Tipocobranca).WithMany(p => p.OsusrE9aCsicpBb060s)
                //    .HasForeignKey(d => d.Bb060Tipocobrancaid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB060_OSUSR_E9A_CSICP_BB009_BB060_TIPOCOBRANCAID");
            });

            modelBuilder.Entity<CSICP_Bb061>(entity =>
            {
                entity.HasKey(e => e.Bb061Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB061");

                entity.ToTable("OSUSR_E9A_CSICP_BB061");

                entity.HasIndex(e => new { e.Bb012Contaid, e.Bb061Dependenteid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB061_13BB012_CONTAID_18BB061_DEPENDENTEID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb012Contaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB061_13BB012_CONTAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb061Tipoassid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB061_15BB061_TIPOASSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb060Convenioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB061_16BB060_CONVENIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb061Dependenteid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB061_18BB061_DEPENDENTEID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB061_9TENANT_ID");

                entity.Property(e => e.Bb061Id).HasColumnName("BB061_ID");
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.Bb060Convenioid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB060_CONVENIOID");
                entity.Property(e => e.Bb061Dependenteid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB061_DEPENDENTEID");
                entity.Property(e => e.Bb061Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB061_ISACTIVE");
                entity.Property(e => e.Bb061Tipoassid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB061_TIPOASSID");
                entity.Property(e => e.Bb061Valor)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB061_VALOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.CSICP_BB012).WithOne()
                    .HasForeignKey<CSICP_Bb061>(d => d.Bb012Contaid);

                entity.HasOne(d => d.NavBb060Convenio).WithOne()
                    .HasForeignKey<CSICP_Bb061>(d => d.Bb060Convenioid);


                entity.HasOne(d => d.Bb061Tipoass).WithOne()
                    .HasForeignKey<CSICP_Bb061>(d => d.Bb061Tipoassid);

                entity.HasOne(d => d.CSICP_BB01208).WithOne()
                     .HasForeignKey<CSICP_Bb061>(d => d.Bb061Dependenteid);
            });

            modelBuilder.Entity<CSICP_Bb061Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB061_TP");

                entity.ToTable("OSUSR_E9A_CSICP_BB061_TP");

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

            modelBuilder.Entity<CSICP_Bb062>(entity =>
            {
                entity.HasKey(e => e.Bb062Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB062");

                entity.ToTable("OSUSR_E9A_CSICP_BB062");

                entity.HasIndex(e => new { e.Bb062Estabid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB062_13BB062_ESTABID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb062Statusid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB062_14BB062_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb062Diavenctoid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB062_17BB062_DIAVENCTOID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB062_9TENANT_ID");

                entity.Property(e => e.Bb062Id).HasColumnName("BB062_ID");
                entity.Property(e => e.Bb062Ano)
                    .HasDefaultValue(0)
                    .HasColumnName("BB062_ANO");
                entity.Property(e => e.Bb062Descritivo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB062_DESCRITIVO");
                entity.Property(e => e.Bb062Diavenctoid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB062_DIAVENCTOID");
                entity.Property(e => e.Bb062Dtemissao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB062_DTEMISSAO");
                entity.Property(e => e.Bb062Estabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB062_ESTABID");
                entity.Property(e => e.Bb062Mes)
                    .HasDefaultValue(0)
                    .HasColumnName("BB062_MES");
                entity.Property(e => e.Bb062Statusid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB062_STATUSID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.NavBB037Diavencto).WithOne()
                    .HasForeignKey<CSICP_Bb062>(d => d.Bb062Diavenctoid);

                entity.HasOne(d => d.NavBb062Status).WithMany(p => p.OsusrE9aCsicpBb062s)
                    .HasForeignKey(d => d.Bb062Statusid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB062_OSUSR_E9A_CSICP_BB062_STA_BB062_STATUSID");
            });

            modelBuilder.Entity<CSICP_Bb062Stum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB062_STA");

                entity.ToTable("OSUSR_E9A_CSICP_BB062_STA");

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

            modelBuilder.Entity<CSICP_BB063>(entity =>
            {
                entity.Property(e => e.Bb012Contaid)
                    .HasMaxLength(36)
                    .HasColumnName("BB012_CONTAID");
                entity.Property(e => e.Bb061Tipoassid).HasColumnName("BB061_TIPOASSID");
                entity.Property(e => e.Bb062RefId).HasColumnName("BB062_REF_ID");
                entity.Property(e => e.Bb063Agcobradorid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_AGCOBRADORID");
                entity.Property(e => e.Bb063Condicaoid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_CONDICAOID");
                entity.Property(e => e.Bb063Convenioid).HasColumnName("BB063_CONVENIOID");
                entity.Property(e => e.Bb063Convmasterid).HasColumnName("BB063_CONVMASTERID");
                entity.Property(e => e.Bb063Custoid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_CUSTOID");
                entity.Property(e => e.Bb063Dependenteid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_DEPENDENTEID");
                entity.Property(e => e.Bb063FpagtoId)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_FPAGTO_ID");
                entity.Property(e => e.Bb063Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BB063_ID");
                entity.Property(e => e.Bb063Responsavelid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_RESPONSAVELID");
                entity.Property(e => e.Bb063Tipocobrancaid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_TIPOCOBRANCAID");
                entity.Property(e => e.Bb063Usuarioproprieid)
                    .HasMaxLength(36)
                    .HasColumnName("BB063_USUARIOPROPRIEID");
                entity.Property(e => e.Bb063Valor)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB063_VALOR");
                entity.Property(e => e.Ff102Id)
                    .HasMaxLength(36)
                    .HasColumnName("FF102_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb064>(entity =>
            {
                entity.HasKey(e => e.Bb064Fxetariaid).HasName("OSPRK_OSUSR_E9A_CSICP_BB064");

                entity.ToTable("OSUSR_E9A_CSICP_BB064");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB064_9TENANT_ID");

                entity.Property(e => e.Bb064Fxetariaid).HasColumnName("BB064_FXETARIAID");
                entity.Property(e => e.Bb064Descricao)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB064_DESCRICAO");
                entity.Property(e => e.Bb064Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB064_ISACTIVE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_Bb065>(entity =>
            {
                entity.HasKey(e => e.Bb065Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB065");

                entity.ToTable("OSUSR_E9A_CSICP_BB065");

                entity.HasIndex(e => new { e.Bb062Convenioid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB065_16BB062_CONVENIOID_9TENANT_ID");

                entity.HasIndex(e => new { e.Bb064Fxetariaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB065_16BB064_FXETARIAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB065_9TENANT_ID");

                entity.Property(e => e.Bb065Id).HasColumnName("BB065_ID");
                entity.Property(e => e.Bb062Convenioid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB062_CONVENIOID");
                entity.Property(e => e.Bb064Fxetariaid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB064_FXETARIAID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb062Convenio).WithMany(p => p.OsusrE9aCsicpBb065s)
                //    .HasForeignKey(d => d.Bb062Convenioid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB065_OSUSR_E9A_CSICP_BB060_BB062_CONVENIOID");

                //entity.HasOne(d => d.Bb064Fxetaria).WithMany(p => p.OsusrE9aCsicpBb065s)
                //    .HasForeignKey(d => d.Bb064Fxetariaid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB065_OSUSR_E9A_CSICP_BB064_BB064_FXETARIAID");

                //entity
                //  .HasOne(e => e.Bb064Fxetaria)
                //  .WithOne()
                //  .HasForeignKey<CSICP_Bb065>(e => e.Bb064Fxetariaid);

                //entity
                //    .HasOne(e => e.CSICP_Bb066)
                //    .WithOne()
                //    .HasForeignKey<CSICP_Bb065>(e => e.Bb064Fxetariaid)
                //    .HasPrincipalKey<CSICP_Bb066>(e => e.Bb066Fxetariaid);
            });

            modelBuilder.Entity<CSICP_Bb066>(entity =>
            {
                entity.HasKey(e => e.Bb066Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB066");

                entity.ToTable("OSUSR_E9A_CSICP_BB066");

                entity.HasIndex(e => new { e.Bb066Fxetariaid, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB066_16BB066_FXETARIAID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB066_9TENANT_ID");

                entity.Property(e => e.Bb066Id).HasColumnName("BB066_ID");
                entity.Property(e => e.Bb066Faixaate)
                    .HasDefaultValue(0)
                    .HasColumnName("BB066_FAIXAATE");
                entity.Property(e => e.Bb066Faixade)
                    .HasDefaultValue(0)
                    .HasColumnName("BB066_FAIXADE");
                entity.Property(e => e.Bb066Fxetariaid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB066_FXETARIAID");
                entity.Property(e => e.Bb066Valor)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("BB066_VALOR");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb066Fxetaria).WithOne()
                //    .HasForeignKey<CSICP_Bb066>(d => d.Bb066Fxetariaid)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB066_OSUSR_E9A_CSICP_BB064_BB066_FXETARIAID");
            });

            modelBuilder.Entity<CSICP_Bb067>(entity =>
            {
                entity.HasKey(e => e.Bb067Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB067");

                entity.ToTable("OSUSR_E9A_CSICP_BB067");

                entity.HasIndex(e => new { e.Bb067Descricao, e.TenantId }, "OSIDX_OSUSR_E9A_CSICP_BB067_15BB067_DESCRICAO_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_E9A_CSICP_BB067_9TENANT_ID");

                entity.Property(e => e.Bb067Id).HasColumnName("BB067_ID");
                entity.Property(e => e.Bb067Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB067_CODIGO");
                entity.Property(e => e.Bb067Descricao)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB067_DESCRICAO");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });
        }
    }
}
