using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas;
using CSCore.Domain.CS_Models.Staticas.CC;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<OsusrNnxCscolor> OsusrNnxCscolors { get; set; }
        public DbSet<OsusrNnxCsicpModulo> OsusrNnxCsicpModulos { get; set; }
        public DbSet<CSICP_Email> OsusrE9aCsicpEmails { get; set; }
        public DbSet<CSICP_Statica> E9ACSICP_Statica { get; set; }
        public DbSet<CsicpCc081Cd> OsusrE9aCsicpCc081Cd { get; set; }
        partial void OnModelCreatingStatica(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_Statica>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_STATICA");

                entity.ToTable("OSUSR_E9A_CSICP_STATICA");

                entity.HasIndex(e => new { e.Tiporegistro, e.Order }, "OSIDX_OSUSR_E9A_CSICP_STATICA_12TIPOREGISTRO_5ORDER");

                entity.HasIndex(e => e.Label, "OSIDX_OSUSR_E9A_CSICP_STATICA_5LABEL");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order)
                    .HasDefaultValue(0)
                    .HasColumnName("ORDER");
                entity.Property(e => e.Tiporegistro)
                    .HasDefaultValue(0)
                    .HasColumnName("TIPOREGISTRO");
            });

            modelBuilder.Entity<CSICP_Email>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_EMAIL");

                entity.ToTable("OSUSR_E9A_CSICP_EMAIL");
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Order).HasColumnName("ORDER");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Descricao).HasColumnName("DESCRICAO");
                entity.Property(e => e.Tipo).HasColumnName("TIPO");


            });


            modelBuilder.Entity<OsusrNnxCscolor>(entity =>
            {
                entity.HasKey(e => e.Color).HasName("OSPRK_OSUSR_NNX_CSCOLOR");

                entity.ToTable("OSUSR_NNX_CSCOLOR");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("COLOR");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<OsusrNnxCsicpModulo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_NNX_CSICP_MODULOS");

                entity.ToTable("OSUSR_NNX_CSICP_MODULOS");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Codigo).HasColumnName("CODIGO");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });

            modelBuilder.Entity<CsicpCc081Cd>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("csicp_cc081_cd");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Order).HasColumnName("ORDER");
            });


            modelBuilder.HasSequence("Seq_PK_ID");
        }
    }
}
