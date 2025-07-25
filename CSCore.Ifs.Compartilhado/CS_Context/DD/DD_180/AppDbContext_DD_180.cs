using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public virtual DbSet<CSICP_DD181> OsusrTeiCsicpDd181s { get; set; }

        public virtual DbSet<CSICP_DD181Tp> OsusrTeiCsicpDd181Tps { get; set; }

        public virtual DbSet<CSICP_DD182> OsusrTeiCsicpDd182s { get; set; }

        public virtual DbSet<CSICP_DD183> OsusrTeiCsicpDd183s { get; set; }

        public virtual DbSet<CSICP_DD184> OsusrTeiCsicpDd184s { get; set; }

        partial void OnModelCreating_CSICP_DD_180(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_DD181>(entity =>
            {
                entity.HasKey(e => e.Dd181Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD181");

                entity.ToTable("OSUSR_TEI_CSICP_DD181");

                entity.HasIndex(e => new { e.Dd181EstabId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_14DD181_ESTAB_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_14DD181_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181Tpconfid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_14DD181_TPCONFID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_20DD181_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.Dd181Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_8DD040_ID_14DD181_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD181_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD181_9TENANT_ID");

                entity.Property(e => e.Dd181Id).HasColumnName("DD181_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd181Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD181_DATAHORA");
                entity.Property(e => e.Dd181EstabId)
                    .HasMaxLength(36)
                    .HasColumnName("DD181_ESTAB_ID");
                entity.Property(e => e.Dd181Isactive).HasColumnName("DD181_ISACTIVE");
                entity.Property(e => e.Dd181Observacao)
                    .HasMaxLength(100)
                    .HasColumnName("DD181_OBSERVACAO");
                entity.Property(e => e.Dd181Protocolo)
                    .HasMaxLength(20)
                    .HasColumnName("DD181_PROTOCOLO");
                entity.Property(e => e.Dd181Statusid).HasColumnName("DD181_STATUSID");
                entity.Property(e => e.Dd181Tpconfid).HasColumnName("DD181_TPCONFID");
                entity.Property(e => e.Dd181UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD181_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            });

            modelBuilder.Entity<CSICP_DD181Tp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD181_TP");

                entity.ToTable("OSUSR_TEI_CSICP_DD181_TP");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CSICP_DD182>(entity =>
            {
                entity.HasKey(e => e.Dd182Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD182");

                entity.ToTable("OSUSR_TEI_CSICP_DD182");

                entity.HasIndex(e => new { e.Dd182Criarexcid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD182_16DD182_CRIAREXCID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd182ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD182_16DD182_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd182Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD182_18DD182_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd182UsuariopropId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD182_20DD182_USUARIOPROP_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD182_8DD181_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD182_9TENANT_ID");

                entity.Property(e => e.Dd182Id).HasColumnName("DD182_ID");
                entity.Property(e => e.Dd181Id).HasColumnName("DD181_ID");
                entity.Property(e => e.Dd182Codgbarras)
                    .HasMaxLength(20)
                    .HasColumnName("DD182_CODGBARRAS");
                entity.Property(e => e.Dd182Criarexcid).HasColumnName("DD182_CRIAREXCID");
                entity.Property(e => e.Dd182Datahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DD182_DATAHORA");
                entity.Property(e => e.Dd182Isactive).HasColumnName("DD182_ISACTIVE");
                entity.Property(e => e.Dd182Isinseridopdv).HasColumnName("DD182_ISINSERIDOPDV");
                entity.Property(e => e.Dd182Modentregaid).HasColumnName("DD182_MODENTREGAID");
                entity.Property(e => e.Dd182ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD182_PRODUTO_ID");
                entity.Property(e => e.Dd182Qtd)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD182_QTD");
                entity.Property(e => e.Dd182UsuariopropId)
                    .HasMaxLength(36)
                    .HasColumnName("DD182_USUARIOPROP_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD183>(entity =>
            {
                entity.HasKey(e => e.Dd183Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD183");

                entity.ToTable("OSUSR_TEI_CSICP_DD183");

                entity.HasIndex(e => new { e.Cd070Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD183_8CD070_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd040Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD183_8DD040_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd110Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD183_8DD110_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD183_8DD181_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Gg071Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD183_8GG071_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD183_9TENANT_ID");

                entity.Property(e => e.Dd183Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD183_ID");
                entity.Property(e => e.Cd070Id)
                    .HasMaxLength(36)
                    .HasColumnName("CD070_ID");
                entity.Property(e => e.Dd040Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD040_ID");
                entity.Property(e => e.Dd110Id)
                    .HasMaxLength(36)
                    .HasColumnName("DD110_ID");
                entity.Property(e => e.Dd181Id).HasColumnName("DD181_ID");
                entity.Property(e => e.Dd183Protocolodocorigem)
                    .HasMaxLength(44)
                    .HasColumnName("DD183_PROTOCOLODOCORIGEM");
                entity.Property(e => e.Gg041Id)
                    .HasMaxLength(36)
                    .HasColumnName("GG041_ID");
                entity.Property(e => e.Gg071Id).HasColumnName("GG071_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });

            modelBuilder.Entity<CSICP_DD184>(entity =>
            {
                entity.HasKey(e => e.Dd184Id).HasName("OSPRK_OSUSR_TEI_CSICP_DD184");

                entity.ToTable("OSUSR_TEI_CSICP_DD184");

                entity.HasIndex(e => new { e.Dd184Statusid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD184_14DD184_STATUSID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd184ProdutoId, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD184_16DD184_PRODUTO_ID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd184Modentregaid, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD184_18DD184_MODENTREGAID_9TENANT_ID");

                entity.HasIndex(e => new { e.Dd181Id, e.TenantId }, "OSIDX_OSUSR_TEI_CSICP_DD184_8DD181_ID_9TENANT_ID");

                entity.HasIndex(e => e.TenantId, "OSIDX_OSUSR_TEI_CSICP_DD184_9TENANT_ID");

                entity.Property(e => e.Dd184Id).HasColumnName("DD184_ID");
                entity.Property(e => e.Dd181Id).HasColumnName("DD181_ID");
                entity.Property(e => e.Dd184Isinseridopdv).HasColumnName("DD184_ISINSERIDOPDV");
                entity.Property(e => e.Dd184Modentregaid).HasColumnName("DD184_MODENTREGAID");
                entity.Property(e => e.Dd184ProdutoId)
                    .HasMaxLength(36)
                    .HasColumnName("DD184_PRODUTO_ID");
                entity.Property(e => e.Dd184Qconferida)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD184_QCONFERIDA");
                entity.Property(e => e.Dd184Qrealdanfe)
                    .HasColumnType("decimal(37, 8)")
                    .HasColumnName("DD184_QREALDANFE");
                entity.Property(e => e.Dd184Statusid).HasColumnName("DD184_STATUSID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


            });
        }
    }
}
