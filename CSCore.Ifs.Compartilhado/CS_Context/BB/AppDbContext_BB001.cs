using CSCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CS_Context
{
    public partial class AppDbContext
    {
        public DbSet<CSICP_BB001> E9ACSICP_BB001s { get; set; }
        public DbSet<CSICP_BB001Spls> OsusrE9aCsicpBb001Spls { get; set; }
        public DbSet<CSICP_BB001Cfgfi> E9ACSICP_BB001Cfgfis { get; set; }
        public DbSet<CSICP_BB001Cnaes> OSUSR_E9A_CSICP_BB001_CNAE { get; set; }
        public DbSet<CSICP_BB001_AXML> E9ACSICP_BB001Axmls { get; set; }
        public DbSet<CSICP_BB001Img> E9ACSICP_BB001Imgs { get; set; }
        partial void OnModelCreating_CSICP_BB001(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSICP_BB001>(entity =>
            {
                // entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001");

                entity.ToTable("OSUSR_E9A_CSICP_BB001");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Bb001Almoxpadrao)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_ALMOXPADRAO");
                entity.Property(e => e.Bb001Almoxtransfer)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_ALMOXTRANSFER");
                entity.Property(e => e.Bb001AutToken)
                    .HasMaxLength(600)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_AUT_TOKEN");
                entity.Property(e => e.Bb001Bairro)
                    .HasMaxLength(30)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_BAIRRO");
                entity.Property(e => e.Bb001Bddistribuida)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_BDDISTRIBUIDA");
                entity.Property(e => e.Bb001Capitalmunicipio)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_CAPITALMUNICIPIO");
                entity.Property(e => e.Bb001Cep)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_CEP");
                entity.Property(e => e.Bb001ChaveApl)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_CHAVE_APL");
                entity.Property(e => e.Bb001Cix)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_CIX");
                entity.Property(e => e.Bb001Cnaefiscal)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_CNAEFISCAL");
                entity.Property(e => e.Bb001Cnpj)
                    .HasColumnName("BB001_CNPJ");
                entity.Property(e => e.Bb001Codgcartorio)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(9, 0)")
                    .HasColumnName("BB001_CODGCARTORIO");
                entity.Property(e => e.Bb001Codgclienteaux)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_CODGCLIENTEAUX");
                entity.Property(e => e.Bb001Codigoempresa)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_CODIGOEMPRESA");
                entity.Property(e => e.Bb001Complemento)
                    .HasMaxLength(255)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_COMPLEMENTO");
                entity.Property(e => e.Bb001Cor1Hexa)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_COR1_HEXA");
                entity.Property(e => e.Bb001Cor2Hexa)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_COR2_HEXA");
                entity.Property(e => e.Bb001CpfOficial)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB001_CPF_OFICIAL");
                entity.Property(e => e.Bb001Datainscricao)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnType("datetime")
                    .HasColumnName("BB001_DATAINSCRICAO");
                entity.Property(e => e.Bb001Descricaooficial)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_DESCRICAOOFICIAL");
                entity.Property(e => e.Bb001Email)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_EMAIL");
                entity.Property(e => e.Bb001Endereco)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_ENDERECO");
                entity.Property(e => e.Bb001Fax)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_FAX");
                entity.Property(e => e.Bb001Homepage)
                    .HasMaxLength(40)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_HOMEPAGE");
                entity.Property(e => e.Bb001IdiomaId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_IDIOMA_ID");
                entity.Property(e => e.Bb001Inscestadual)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_INSCESTADUAL");
                entity.Property(e => e.Bb001Inscjunta)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BB001_INSCJUNTA");
                entity.Property(e => e.Bb001Inscmunicipal)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_INSCMUNICIPAL");
                entity.Property(e => e.Bb001Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("BB001_ISACTIVE");
                entity.Property(e => e.Bb001Nomefantasia)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_NOMEFANTASIA");
                entity.Property(e => e.Bb001Nomeoficial)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_NOMEOFICIAL");
                entity.Property(e => e.Bb001Nomesubstituto)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_NOMESUBSTITUTO");
                entity.Property(e => e.Bb001Numresidencial)
                    .HasMaxLength(10)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_NUMRESIDENCIAL");
                entity.Property(e => e.Bb001Paisid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_PAISID");
                entity.Property(e => e.Bb001Ramoempresa)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_RAMOEMPRESA");
                entity.Property(e => e.Bb001Razaosocial)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_RAZAOSOCIAL");
                entity.Property(e => e.Bb001Senhasirc)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_SENHASIRC");
                entity.Property(e => e.Bb001Slogamempresa1)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_SLOGAMEMPRESA1");
                entity.Property(e => e.Bb001Slogamempresa2)
                    .HasMaxLength(60)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_SLOGAMEMPRESA2");
                entity.Property(e => e.Bb001Suframaemp)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_SUFRAMAEMP");
                entity.Property(e => e.Bb001Telefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_TELEFONE");
                entity.Property(e => e.Bb001Tenantfiscal)
                    .HasDefaultValue(0)
                    .HasColumnName("BB001_TENANTFISCAL");
                entity.Property(e => e.Bb001Token)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_TOKEN");
                entity.Property(e => e.Bb001TokenCspix)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_TOKEN_CSPIX");
                entity.Property(e => e.Bb001TokenEsitef)
                    .HasMaxLength(36)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_TOKEN_ESITEF");
                entity.Property(e => e.Bb001Ufid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_UFID");
                entity.Property(e => e.Bb001UrlAppstore)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_URL_APPSTORE");
                entity.Property(e => e.Bb001UrlGoogleplay)
                    .HasMaxLength(200)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_URL_GOOGLEPLAY");
                entity.Property(e => e.Bb001Usuariosirc)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("BB001_USUARIOSIRC");
                entity.Property(e => e.Bb002Grupoempresa)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB002_GRUPOEMPRESA");
                entity.Property(e => e.Cidadeid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("CIDADEID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");


                entity.HasOne(d => d.Bb001RamoempresaNavigation).WithOne()
                    .HasForeignKey<CSICP_BB001>(d => d.Bb001Ramoempresa)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_OSUSR_E9A_CSICP_STATICA_BB001_RAMOEMPRESA");

                entity.HasMany(d => d.OsusrE9aCsicpBb001Imgs).WithOne().HasForeignKey(d => d.Empresaid);

                entity.HasMany(d => d.NavBB001AXML).WithOne().HasForeignKey(d => d.Bb001aEstabid);
                entity.HasMany(d => d.Bb001CnaesList).WithOne().HasForeignKey(d => d.Bb001Id);
                entity.HasMany(d => d.OsusrE9aCsicpBb001Spls).WithOne().HasForeignKey(d => d.Bb001Id);
                entity.HasMany(d => d.OsusrE9aCsicpBb001Cfgfis).WithOne().HasForeignKey(d => d.Bb001EmpresaId);


            });

            modelBuilder.Entity<CSICP_BB001Spls>(entity =>
            {
                entity.HasKey(e => e.Bb001SimplesId).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_SPLS");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_SPLS");

                entity.Property(e => e.Bb001SimplesId)
                    .HasMaxLength(36)
                    .HasColumnName("BB001_SIMPLES_ID");
                entity.Property(e => e.Bb001AliqCofins)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_COFINS");
                entity.Property(e => e.Bb001AliqCpp)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_CPP");
                entity.Property(e => e.Bb001AliqCsll)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_CSLL");
                entity.Property(e => e.Bb001AliqIcms)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_ICMS");
                entity.Property(e => e.Bb001AliqIpi)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_IPI");
                entity.Property(e => e.Bb001AliqIrpj)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_IRPJ");
                entity.Property(e => e.Bb001AliqIss)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_ISS");
                entity.Property(e => e.Bb001AliqPisPasep)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_PIS_PASEP");
                entity.Property(e => e.Bb001AliqSimples)
                            .HasDefaultValue(0m)
                            .HasColumnType("decimal(5, 2)")
                            .HasColumnName("BB001_ALIQ_SIMPLES");
                entity.Property(e => e.Bb001Id)
                            .HasMaxLength(36)
                            .HasDefaultValueSql("(NULL)")
                            .HasColumnName("BB001_ID");
                entity.Property(e => e.Bb001SimplespartId)
                            .HasDefaultValueSql("(NULL)")
                            .HasColumnName("BB001_SIMPLESPART_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                entity.HasOne(d => d.Bb001Simplespart).WithOne()
                            .HasForeignKey<CSICP_BB001Spls>(d => d.Bb001SimplespartId)
                            .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CSICP_BB001Cfgfi>(entity =>
            {
                entity.HasKey(e => e.Bb001CfgId).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_CFGFIS");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_CFGFIS");

                entity.Property(e => e.Bb001CfgId)
                    .HasMaxLength(36)
                    .HasColumnName("BB001_CFG_ID");
                entity.Property(e => e.Bb001EmpresaId)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_EMPRESA_ID");
                entity.Property(e => e.Bb001NaturezapjId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_NATUREZAPJ_ID");
                entity.Property(e => e.Bb001PercCsllBc)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB001_PERC_CSLL_BC");
                entity.Property(e => e.Bb001PercCsllBcServico)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB001_PERC_CSLL_BC_SERVICO");
                entity.Property(e => e.Bb001PercIcms)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB001_PERC_ICMS");
                entity.Property(e => e.Bb001PercIrpjBc)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB001_PERC_IRPJ_BC");
                entity.Property(e => e.Bb001PercIrpjBcServico)
                    .HasDefaultValue(0m)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("BB001_PERC_IRPJ_BC_SERVICO");
                entity.Property(e => e.Bb001Regimetributarioid)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_REGIMETRIBUTARIOID");
                entity.Property(e => e.Bb001TpatividadeId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_TPATIVIDADE_ID");
                entity.Property(e => e.Bb001TptributacaoId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001_TPTRIBUTACAO_ID");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb001Empresa).WithMany(p => p.OsusrE9aCsicpBb001Cfgfis)
                //    .HasForeignKey(d => d.Bb001EmpresaId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CFGFIS_OSUSR_E9A_CSICP_BB001_BB001_EMPRESA_ID");

                entity.HasOne(d => d.Bb001Naturezapj).WithMany()
                    .HasForeignKey(d => d.Bb001NaturezapjId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CFGFIS_OSUSR_E9A_CSICP_BB001_NATPJ_BB001_NATUREZAPJ_ID");

                entity.HasOne(d => d.Bb001Regimetributario).WithMany()
                    .HasForeignKey(d => d.Bb001Regimetributarioid)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CFGFIS_OSUSR_E9A_CSICP_AA030_REGIME_BB001_REGIMETRIBUTARIOID");

                entity.HasOne(d => d.Bb001Tpatividade).WithMany()
                    .HasForeignKey(d => d.Bb001TpatividadeId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CFGFIS_OSUSR_E9A_CSICP_BB001_ATPJ_BB001_TPATIVIDADE_ID");

                entity.HasOne(d => d.Bb001Tptributacao).WithMany()
                    .HasForeignKey(d => d.Bb001TptributacaoId)
                    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CFGFIS_OSUSR_E9A_CSICP_BB001_TPTRI_BB001_TPTRIBUTACAO_ID");
            });

            modelBuilder.Entity<CSICP_BB001Img>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_IMG");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_IMG");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("ID");
                entity.Property(e => e.Empresaid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("EMPRESAID");
                entity.Property(e => e.ExibirEmformapagto)
                    .HasDefaultValue(false)
                    .HasColumnName("EXIBIR_EMFORMAPAGTO");
                entity.Property(e => e.Filename)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("FILENAME");
                //entity.Property(e => e.Imagem)
                //    .HasDefaultValueSql("(NULL)")
                //    .HasColumnName("IMAGEM");
                entity.Property(e => e.Isactive)
                    .HasDefaultValue(false)
                    .HasColumnName("ISACTIVE");
                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("NOME");
                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("PATH");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("STATUS");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasDefaultValue("")
                    .HasColumnName("TIPO");


                entity.HasOne(bb001img => bb001img.StatusNavigation)
                .WithOne()
                .HasForeignKey<CSICP_BB001Img>(b => b.Status);
            });

            modelBuilder.Entity<CSICP_BB001Cnaes>(entity =>
            {

                entity.ToTable("OSUSR_E9A_CSICP_BB001_CNAE");

                // Configuração explícita das colunas existentes
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
                entity.Property(e => e.Bb001PkId).HasColumnName("BB001_PK_ID").HasMaxLength(36);
                entity.Property(e => e.Bb001Id).HasColumnName("BB001_ID").HasMaxLength(36);
                entity.Property(e => e.Bb001CnaeId).HasColumnName("BB001_CNAE_ID").HasMaxLength(36);
                entity.Property(e => e.Bb001Isactive).HasColumnName("BB001_ISACTIVE");
                entity.Property(e => e.Bb001IscnaeFiscal).HasColumnName("BB001_ISCNAE_FISCAL");

                entity.HasOne(d => d.NavCnae).WithOne()
               .HasForeignKey<CSICP_BB001Cnaes>(d => d.Bb001CnaeId);

                // entity.HasOne(d => d.Bb001).WithMany(p => p.OsusrE9aCsicpBb001Cnaes)
                //     .HasForeignKey(d => d.Bb001Id)
                //     .OnDelete(DeleteBehavior.Cascade)
                //     .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_CNAE_OSUSR_E9A_CSICP_BB001_BB001_ID");
            });

            modelBuilder.Entity<CSICP_BB001_AXML>(entity =>
            {
                entity.HasKey(e => e.Bb001aId).HasName("OSPRK_OSUSR_E9A_CSICP_BB001_AXML");

                entity.ToTable("OSUSR_E9A_CSICP_BB001_AXML");
                entity.Ignore(e => e.Bb001aEstabid);

                entity.Property(e => e.Bb001aId).HasColumnName("BB001A_ID");

                entity.Property(e => e.Bb001aCpfcnpj)
                    .HasMaxLength(14)
                    .HasDefaultValue("")
                    .HasColumnName("BB001A_CPFCNPJ");
                entity.Property(e => e.Bb001aEmail)
                    .HasMaxLength(250)
                    .HasDefaultValue("")
                    .HasColumnName("BB001A_EMAIL");
                entity.Property(e => e.Bb001aEstabid)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("BB001A_ESTABID");
                entity.Property(e => e.Bb001aIscpf)
                    .HasDefaultValue(false)
                    .HasColumnName("BB001A_ISCPF");
                entity.Property(e => e.Bb001aNome)
                    .HasMaxLength(100)
                    .HasDefaultValue("")
                    .HasColumnName("BB001A_NOME");
                entity.Property(e => e.Bb001aTelefone)
                    .HasMaxLength(20)
                    .HasDefaultValue("")
                    .HasColumnName("BB001A_TELEFONE");
                entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

                //entity.HasOne(d => d.Bb001aEstab).WithMany(p => p.NavBB001AXML)
                //    .HasForeignKey(d => d.Bb001aEstabid)
                //    .HasConstraintName("OSFRK_OSUSR_E9A_CSICP_BB001_AXML_OSUSR_E9A_CSICP_BB001_BB001A_ESTABID");
            });
        }
    }
}
