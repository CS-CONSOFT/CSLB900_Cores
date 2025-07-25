using CSCore.Domain.CS_Models.Staticas.NFS;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<Osusr66cCsicpNfsInccult> Osusr66cCsicpNfsInccults { get; set; }

        public DbSet<Osusr66cCsicpNfsLstserv> Osusr66cCsicpNfsLstservs { get; set; }

        public DbSet<Osusr66cCsicpNfsNatoper> Osusr66cCsicpNfsNatopers { get; set; }

        public DbSet<Osusr66cCsicpNfsOptsn> Osusr66cCsicpNfsOptsns { get; set; }

        public DbSet<Osusr66cCsicpNfsPadrao> Osusr66cCsicpNfsPadraos { get; set; }

        public DbSet<Osusr66cCsicpNfsRegtrib> Osusr66cCsicpNfsRegtribs { get; set; }

        public DbSet<Osusr66cCsicpNfsRelPnat> Osusr66cCsicpNfsRelPnats { get; set; }

        partial void OnModelCreatingStaticaNFS(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osusr66cCsicpNfsInccult>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_INCCULT");

                entity.ToTable("OSUSR_66C_CSICP_NFS_INCCULT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod).HasColumnName("COD");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsLstserv>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_LSTSERV");

                entity.ToTable("OSUSR_66C_CSICP_NFS_LSTSERV");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod)
                    .HasMaxLength(5)
                    .HasColumnName("COD");
                entity.Property(e => e.Desc)
                    .HasMaxLength(500)
                    .HasColumnName("DESC");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Value)
                    .HasMaxLength(5)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsNatoper>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_NATOPER");

                entity.ToTable("OSUSR_66C_CSICP_NFS_NATOPER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod).HasColumnName("COD");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsOptsn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_OPTSN");

                entity.ToTable("OSUSR_66C_CSICP_NFS_OPTSN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod).HasColumnName("COD");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsPadrao>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_PADRAO");

                entity.ToTable("OSUSR_66C_CSICP_NFS_PADRAO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsRegtrib>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_REGTRIB");

                entity.ToTable("OSUSR_66C_CSICP_NFS_REGTRIB");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Cod).HasColumnName("COD");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(250)
                    .HasColumnName("LABEL");
            });

            modelBuilder.Entity<Osusr66cCsicpNfsRelPnat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_66C_CSICP_NFS_REL_PNAT");

                entity.ToTable("OSUSR_66C_CSICP_NFS_REL_PNAT");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("LABEL");
                entity.Property(e => e.Natop).HasColumnName("NATOP");
                entity.Property(e => e.Padrao).HasColumnName("PADRAO");
            });
        }
    }
}
