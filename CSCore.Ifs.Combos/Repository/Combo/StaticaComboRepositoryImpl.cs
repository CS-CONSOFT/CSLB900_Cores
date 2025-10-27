using CSCore.Domain;
using CSCore.Domain.Interfaces.Combo;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.ComboTypes;
using static CSCore.Domain.StaticaTypes;

namespace CSCore.Ifs.Repository.Combo
{
    public class StaticaComboRepositoryImpl(AppDbContext appDbContext) : IStaticaComboRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeAA(StaticaTypes.StaticTypeAA staticTypeAA)
        {
            IQueryable<object> query = staticTypeAA switch
            {
                StaticTypeAA.CSICP_AA032_Csticms => _appDbContext.E9ACSICP_AA032Csticms.AsQueryable()
                .Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Regime, c.Id }),

                StaticTypeAA.CSICP_AA030TpToken => _appDbContext.E9ACSICP_AA030TPToken.AsQueryable()
               .Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA031_Cstoris => _appDbContext.E9ACSICP_AA031Cstoris
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA033_Cstipis => _appDbContext.E9ACSICP_AA033Cstipis
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA034_Cstpis => _appDbContext.E9ACSICP_AA034Cstpis
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA035_Cstcofs => _appDbContext.E9ACSICP_AA035Cstcofs
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA036_Ipiajus => _appDbContext.E9ACSICP_AA036Ipiajus
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA037_Imps => _appDbContext.E9ACSICP_AA037Imps
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA038_Modsts => _appDbContext.E9ACSICP_AA038Modsts
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA039_Mp255s => _appDbContext.E9ACSICP_AA039Mp255s
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.CSICP_AA030_Regimes => _appDbContext.E9ACSICP_AA030Regimes
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),

                StaticTypeAA.csicp_aa146_TpGov => _appDbContext.OsusrE9aCsicpAa146Tpgovs
                .AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeAA), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeGG(StaticaTypes.StaticTypeGG staticTypeGG)
        {
            IQueryable<object> query = staticTypeGG switch
            {
                StaticTypeGG.CSICP_GG001_TP_ALMOX => _appDbContext.CSICP_GG001Talmoxes.AsQueryable().Where(c => c.IsActive == true && c.Label != "Virtual").OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG007_FRA => _appDbContext.OsusrE9aCsicpGg007Fras.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG021_CEST => _appDbContext.OsusrE9aCsicpGg021cests.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG008Con => _appDbContext.OsusrE9aCsicpGg008Cons.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG008Efi => _appDbContext.OsusrE9aCsicpGg008Efis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG008Kit => _appDbContext.OsusrE9aCsicpGg008Kits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG008Gar => _appDbContext.OsusrE9aCsicpGg008Gars.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_GG019Cgbar => _appDbContext.OsusrE9aCsicpGg019Cgbars.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg008Cdn => _appDbContext.OsusrE9aCsicpGg008Cdns.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg008dTp => _appDbContext.OsusrE9aCsicpGg008dTps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg008Tpcon => _appDbContext.OsusrE9aCsicpGg008Tpcons.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg008Tran => _appDbContext.OsusrE9aCsicpGg008Trans.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg021cest => _appDbContext.OsusrE9aCsicpGg021cests.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg023Tipo => _appDbContext.OsusrE9aCsicpGg023Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg016b => _appDbContext.OsusrE9aCsicpGg016bs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg025stum => _appDbContext.OsusrE9aCsicpGg025sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg023Val => _appDbContext.OsusrE9aCsicpGg023Vals.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg028Entsai => _appDbContext.OsusrE9aCsicpGg028Entsais.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg028Nat => _appDbContext.OsusrE9aCsicpGg028Nats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg030Stum => _appDbContext.OsusrE9aCsicpGg030Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg032Stum => _appDbContext.OsusrE9aCsicpGg032Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg032Tpinv => _appDbContext.OsusrE9aCsicpGg032Tpinvs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg034Stum => _appDbContext.OsusrE9aCsicpGg034Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg034Tipo => _appDbContext.OsusrE9aCsicpGg034Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg039Stat => _appDbContext.OsusrE9aCsicpGg039Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg041Tpreq => _appDbContext.OsusrE9aCsicpGg041Tpreqs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg045Stat => _appDbContext.OsusrE9aCsicpGg045Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg054Stum => _appDbContext.OsusrE9aCsicpGg054Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg046Stat => _appDbContext.OsusrE9aCsicpGg046Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg065Tp => _appDbContext.OsusrE9aCsicpGg065Tps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg071Stum => _appDbContext.OsusrE9aCsicpGg071Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg072Stq => _appDbContext.OsusrE9aCsicpGg072Stqs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg073Stat => _appDbContext.OsusrE9aCsicpGg073Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg073Tmov => _appDbContext.OsusrE9aCsicpGg073Tmovs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg902St => _appDbContext.OsusrE9aCsicpGg902Sts.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeGG.CSICP_Gg903tp => _appDbContext.OsusrE9aCsicpGg903tps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeGG), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeBB(StaticaTypes.StaticTypeBB staticTypeBB)
        {
            IQueryable<object> query = staticTypeBB switch
            {
                StaticTypeBB.CSICP_BB001_Aliqs => _appDbContext.E9ACSICP_BB001Aliqs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB001_ATPJS => _appDbContext.E9ACSICP_BB001Atpjs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB001_Capmuns => _appDbContext.E9ACSICP_BB001Capmuns.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB001_Natpjs => _appDbContext.E9ACSICP_BB001Natpjs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB001_Staimgs => _appDbContext.E9ACSICP_BB001Staimgs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB001_Tptris => _appDbContext.E9ACSICP_BB001Tptris.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB008_TIPO => _appDbContext.OsusrE9aCsicpBb008Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB010_TP => _appDbContext.OsusrE9aCsicpBb010Tps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB006_BANCO => _appDbContext.OsusrE9aCsicpBb006Bancos.AsQueryable().OrderBy(c => c.Nomedobanco).Select(c => new { Title = c.Nomedobanco, c.Id }),
                StaticTypeBB.CSICP_BB019_TIPO => _appDbContext.OsusrE9aCsicpBb019Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB026_CLASSE => _appDbContext.OsusrE9aCsicpBb026Classes.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB026_TIPO => _appDbContext.OsusrE9aCsicpBb026Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB026_VIN => _appDbContext.OsusrE9aCsicpBb026Vins.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_BCALC => _appDbContext.OsusrE9aCsicpBb027Bcalcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_CICMS => _appDbContext.OsusrE9aCsicpBb027Cicms.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_DIFER => _appDbContext.OsusrE9aCsicpBb027Difers.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_ENTSAI => _appDbContext.OsusrE9aCsicpBb027Entsais.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_FDESEN => _appDbContext.OsusrE9aCsicpBb027Fdesens.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_IMP => _appDbContext.OsusrE9aCsicpBb027Imps.AsQueryable().OrderBy(c => c.Bb027bAliquota).Select(c => new { Title = c.Bb027bAliquota.ToString(), Id = c.Bb027bId }),
                StaticTypeBB.CSICP_BB027_MODAL => _appDbContext.OsusrE9aCsicpBb027Modals.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_MOTIVO => _appDbContext.OsusrE9aCsicpBb027Motivos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_PTERC => _appDbContext.OsusrE9aCsicpBb027Ptercs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027_SIPI => _appDbContext.OsusrE9aCsicpBb027Sipis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB027A_TPCALC => _appDbContext.OsusrE9aCsicpBb027aTpcalcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB028_TP => _appDbContext.OsusrE9aCsicpBb028Tps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB035_GPA => _appDbContext.OsusrE9aCsicpBb035Gpas.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB035_ORIGEM => _appDbContext.OsusrE9aCsicpBb035Origems.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB035_TRAT => _appDbContext.OsusrE9aCsicpBb035Trats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeBB.CSICP_BB036_ENDER => _appDbContext.OsusrE9aCsicpBb036Enders.AsQueryable().OrderBy(c => c.Bb036CodigoCidade).Select(c => new { Title = c.Bb036CodigoCidade, Id = c.Bb036Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeBB), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeClient(StaticaTypes.StaticTypeClient staticTypeClient)
        {
            IQueryable<object> query = staticTypeClient switch
            {
                StaticTypeClient.CSICP_BB012_CLACTA => _appDbContext.OsusrE9aCsicpBb012Clacta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_GRUCTA => _appDbContext.OsusrE9aCsicpBb012Gructa.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_MDC => _appDbContext.OsusrE9aCsicpBb012mdcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_MTD => _appDbContext.OsusrE9aCsicpBb012mtds.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_MCRED => _appDbContext.OsusrE9aCsicpBb012Mcreds.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_MREL => _appDbContext.OsusrE9aCsicpBb012Mrels.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_SITCTA => _appDbContext.OsusrE9aCsicpBb012Sitcta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_STACTA => _appDbContext.OsusrE9aCsicpBb012Stacta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012_TPCTA => _appDbContext.OsusrE9aCsicpBb012Tpcta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01201_CON => _appDbContext.OsusrE9aCsicpBb01201Cons.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01201_JUR => _appDbContext.OsusrE9aCsicpBb01201Jurs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01201_TGER => _appDbContext.OsusrE9aCsicpBb01201Tgers.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_DOM => _appDbContext.OsusrE9aCsicpBb01202Doms.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_ECIV => _appDbContext.OsusrE9aCsicpBb01202Ecivs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_ESC => _appDbContext.OsusrE9aCsicpBb01202Escs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_INS => _appDbContext.OsusrE9aCsicpBb01202Ins.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_OCU => _appDbContext.OsusrE9aCsicpBb01202Ocus.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_RES => _appDbContext.OsusrE9aCsicpBb01202Res.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB01202_SEX => _appDbContext.OsusrE9aCsicpBb01202Res.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticTypeClient.CSICP_BB012J_TPEND => _appDbContext.OsusrE9aCsicpBb012jTpends.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeClient), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeSped(StaticaTypes.StaticSpedType staticSpedType)
        {
            IQueryable<object> query = staticSpedType switch
            {
                StaticSpedType.SpedInNatBc => _appDbContext.Osusr66cSpedInNatBcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInAjusteIpi => _appDbContext.Osusr66cSpedInAjusteIpis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInAjIcm => _appDbContext.Osusr66cSpedInAjIcms.AsQueryable().Where(c => c.Isactive == true).OrderBy(c => c.Descricao).Select(c => new { Title = c.Descricao, Id = c.Id }),
                StaticSpedType.SpedInCenqIpi => _appDbContext.Osusr66cSpedInCenqIpis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Descricao).Select(c => new { Title = c.Descricao, Id = c.Id }),
                StaticSpedType.SpedInCfop => _appDbContext.Osusr66cSpedInCfops.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Descricao).Select(c => new { Title = c.Descricao, Id = c.Id }),
                StaticSpedType.SpedInCodAjuste => _appDbContext.Osusr66cSpedInCodAjustes.AsQueryable().Where(c => c.Isactive == true).OrderBy(c => c.Descricao).Select(c => new { Title = c.Descricao, Id = c.Id }),
                StaticSpedType.SpedInDispAutor => _appDbContext.Osusr66cSpedInDispAutors.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInEnquadIpi => _appDbContext.Osusr66cSpedInEnquadIpis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInMotInv => _appDbContext.Osusr66cSpedInMotInvs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.STRelevancia => _appDbContext.OsusrSpedNnxCsicpStrelevancia.Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInNatExp => _appDbContext.Osusr66cSpedInNatExps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInSeloIpi => _appDbContext.Osusr66cSpedInSeloIpis.AsQueryable().Where(c => c.Isactive == true).OrderBy(c => c.Descricao).Select(c => new { Title = c.Descricao, Id = c.Id }),
                StaticSpedType.SpedInTotRedZ => _appDbContext.Osusr66cSpedInTotRedZs.AsQueryable().OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInTpAjuste => _appDbContext.Osusr66cSpedInTpAjustes.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInDocIcm => _appDbContext.OsusrNnxSpedInDocIcms.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInEmitente => _appDbContext.OsusrNnxSpedInEmitentes.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInGenItem => _appDbContext.OsusrNnxSpedInGenItems.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInSitDocC => _appDbContext.OsusrNnxSpedInSitDocCs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInTabela => _appDbContext.OsusrNnxSpedInTabelas.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                StaticSpedType.SpedInTipoItem => _appDbContext.OsusrNnxSpedInTipoItems.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticSpedType), "Tipo estático inválido")
            };

            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeFF(StaticTypeFF staticTypeff)
        {
            IQueryable<object> query = staticTypeff switch
            {
                StaticTypeFF.Csicp_Ff000Basecalcs => _appDbContext.OsusrE9aCsicpFf000Basecalcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff000Envapis => _appDbContext.OsusrE9aCsicpFf000Envapis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff000Fbxes => _appDbContext.OsusrE9aCsicpFf000Fbxes.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff003Tpesps => _appDbContext.OsusrE9aCsicpFf003Tpesps.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff006Sta => _appDbContext.OsusrE9aCsicpFf006Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff016Emails => _appDbContext.OsusrE9aCsicpFf016Emails.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff020Emirecs => _appDbContext.OsusrE9aCsicpFf020Emirecs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff021Sits => _appDbContext.OsusrE9aCsicpFf021Sits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff030Sits => _appDbContext.OsusrE9aCsicpFf030Sits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff002Mod => _appDbContext.OsusrE9aCsicpF002Mod.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff032Sta => _appDbContext.OsusrE9aCsicpFf032Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff040Sits => _appDbContext.OsusrE9aCsicpFf040Sits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Adts => _appDbContext.OsusrE9aCsicpFf102Adts.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102ApiBancos => _appDbContext.OsusrE9aCsicpFf102ApiBancos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Auts => _appDbContext.OsusrE9aCsicpFf102Auts.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102C018s => _appDbContext.OsusrE9aCsicpFf102C018s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102C021s => _appDbContext.OsusrE9aCsicpFf102C021s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Cobs => _appDbContext.OsusrE9aCsicpFf102Cobs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Des => _appDbContext.OsusrE9aCsicpFf102Des.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Ents => _appDbContext.OsusrE9aCsicpFf102Ents.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102G073s => _appDbContext.OsusrE9aCsicpFf102G073s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff102Sits => _appDbContext.OsusrE9aCsicpFf102Sits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff103Msgs => _appDbContext.OsusrE9aCsicpFf103Msgs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff103Tpbais => _appDbContext.OsusrE9aCsicpFf103Tpbais.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff105Statuses => _appDbContext.OsusrE9aCsicpFf105Statuses.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff105Statusapis => _appDbContext.OsusrE9aCsicpFf105Statusapis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff107Acrs => _appDbContext.OsusrE9aCsicpFf107Acrs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff107Vcs => _appDbContext.OsusrE9aCsicpFf107Vcs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff110Sits => _appDbContext.OsusrE9aCsicpFf110Sits.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C004s => _appDbContext.OsusrE9aCsicpFf112C004s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C006s => _appDbContext.OsusrE9aCsicpFf112C006s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C007s => _appDbContext.OsusrE9aCsicpFf112C007s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C008s => _appDbContext.OsusrE9aCsicpFf112C008s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C009s => _appDbContext.OsusrE9aCsicpFf112C009s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C010s => _appDbContext.OsusrE9aCsicpFf112C010s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C026s => _appDbContext.OsusrE9aCsicpFf112C026s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C028s => _appDbContext.OsusrE9aCsicpFf112C028s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C029s => _appDbContext.OsusrE9aCsicpFf112C029s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C044s => _appDbContext.OsusrE9aCsicpFf112C044s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C047as => _appDbContext.OsusrE9aCsicpFf112C047as.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C047bs => _appDbContext.OsusrE9aCsicpFf112C047bs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112C047cs => _appDbContext.OsusrE9aCsicpFf112C047cs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112Cnabs => _appDbContext.OsusrE9aCsicpFf112Cnabs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112G005s => _appDbContext.OsusrE9aCsicpFf112G005s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112G025s => _appDbContext.OsusrE9aCsicpFf112G025s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112G028s => _appDbContext.OsusrE9aCsicpFf112G028s.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112OrgNegs => _appDbContext.OsusrE9aCsicpFf112OrgNegs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112Regs => _appDbContext.OsusrE9aCsicpFf112Regs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),                
                StaticTypeFF.Csicp_Ff112apiBaixas => _appDbContext.OsusrE9aCsicpFf112apiBaixas.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112apiLiquidacaos => _appDbContext.OsusrE9aCsicpFf112apiLiquidacaos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff112apiOcorrencia => _appDbContext.OsusrE9aCsicpFf112apiOcorrencia.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff113Tipos => _appDbContext.OsusrE9aCsicpFf113Tipos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff116Tmovs => _appDbContext.OsusrE9aCsicpFf116Tmovs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff118Nivels => _appDbContext.OsusrE9aCsicpFf118Nivels.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff118Stats => _appDbContext.OsusrE9aCsicpFf118Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff120Trackapis => _appDbContext.OsusrE9aCsicpFf120Trackapis.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff125Stats => _appDbContext.OsusrE9aCsicpFf125Stats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff135Statuses => _appDbContext.OsusrE9aCsicpFf135Statuses.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff136Sts => _appDbContext.OsusrE9aCsicpFf136Sts.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff136Tmovs => _appDbContext.OsusrE9aCsicpFf136Tmovs.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff140Exes => _appDbContext.OsusrE9aCsicpFf140Exes.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff140Sta => _appDbContext.OsusrE9aCsicpFf140Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff140Vins => _appDbContext.OsusrE9aCsicpFf140Vins.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff16Tagcars => _appDbContext.OsusrE9aCsicpFf16Tagcars.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeFF.Csicp_Ff996Sta => _appDbContext.OsusrE9aCsicpFf996Sta.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeff), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetComboStaticaByRegistro(StaticaRegistros tipoRegistro)
        {
            IQueryable<object> query = tipoRegistro switch
            {
                StaticaRegistros.Registro_Sim_Nao => _appDbContext.E9ACSICP_Statica.AsQueryable().Where(c => c.Tiporegistro == 1).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticaRegistros.Registro_Ativo_Inativo => _appDbContext.E9ACSICP_Statica.AsQueryable().Where(c => c.Tiporegistro == 2).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticaRegistros.Registro_Setor_Economico => _appDbContext.E9ACSICP_Statica.AsQueryable().Where(c => c.Tiporegistro == 3).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticaRegistros.Registro_999 => _appDbContext.E9ACSICP_Statica.AsQueryable().Where(c => c.Tiporegistro == 999).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticaRegistros.Registro_1000 => _appDbContext.E9ACSICP_Statica.AsQueryable().Where(c => c.Tiporegistro == 1000).Select(c => new { Title = c.Label, Id = c.Id }),
                _ => throw new ArgumentOutOfRangeException(nameof(tipoRegistro), "Tipo do registro")
            };
            return await query.ToListAsync();
        }

        // ComboRR
        public async Task<IReadOnlyCollection<object>> GetComboStaticasByTypeRR(StaticTypeRR staticTypeRR)
        {
            IQueryable<object> query = staticTypeRR switch
            {
                StaticTypeRR.Csicp_RR001_Ativo => _appDbContext.OsusrTo3CsicpRr001Ativos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeRR.Csicp_RR001_Cat => _appDbContext.OsusrTo3CsicpRr001Cats.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),
                StaticTypeRR.Csicp_RR001_Sexo => _appDbContext.OsusrTo3CsicpRr001Sexos.AsQueryable().Where(c => c.IsActive == true).OrderBy(c => c.Label).Select(c => new { Title = c.Label, Id = c.Id }),

                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeRR), "Tipo estático inválido")
            };
            return await query.ToListAsync();
        }
    }

}



