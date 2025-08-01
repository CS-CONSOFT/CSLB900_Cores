using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static CSCore.Domain.StaticaTypes;

namespace CSCore.Ifs.Repository.Statica
{
    public class StaticaRepositoryImpl(AppDbContext appDbContext) : IStaticaRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<IReadOnlyCollection<CSICP_Email>> GetStaticaEmail()
        {
            return await _appDbContext.OsusrE9aCsicpEmails.ToListAsync();
        }

        private static IQueryable<T> ApplyActiveFilter<T>(IQueryable<T> query)
        {
            var param = Expression.Parameter(typeof(T), "c");
            var property = Expression.Property(param, "IsActive");
            var constant = Expression.Constant(true);
            var body = Expression.Equal(property, constant);
            var predicate = Expression.Lambda<Func<T, bool>>(body, param);

            return query.Where(predicate);
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeAA(StaticaTypes.StaticTypeAA staticTypeAA)
        {
            IQueryable query = staticTypeAA switch
            {
                StaticTypeAA.CSICP_AA032_Csticms => _appDbContext.E9ACSICP_AA032Csticms.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA031_Cstoris => _appDbContext.E9ACSICP_AA031Cstoris.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA033_Cstipis => _appDbContext.E9ACSICP_AA033Cstipis.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA034_Cstpis => _appDbContext.E9ACSICP_AA034Cstpis.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA035_Cstcofs => _appDbContext.E9ACSICP_AA035Cstcofs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA036_Ipiajus => _appDbContext.E9ACSICP_AA036Ipiajus.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA037_Imps => _appDbContext.E9ACSICP_AA037Imps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA038_Modsts => _appDbContext.E9ACSICP_AA038Modsts.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA039_Mp255s => _appDbContext.E9ACSICP_AA039Mp255s.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeAA.CSICP_AA030_Regimes => _appDbContext.E9ACSICP_AA030Regimes.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeAA), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeBB(StaticaTypes.StaticTypeBB staticTypeBB)
        {
            IQueryable query = staticTypeBB switch
            {
                StaticTypeBB.CSICP_BB001_Aliqs => _appDbContext.E9ACSICP_BB001Aliqs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB001_ATPJS => _appDbContext.E9ACSICP_BB001Atpjs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB001_Capmuns => _appDbContext.E9ACSICP_BB001Capmuns.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB001_Natpjs => _appDbContext.E9ACSICP_BB001Natpjs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB001_Staimgs => _appDbContext.E9ACSICP_BB001Staimgs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB001_Tptris => _appDbContext.E9ACSICP_BB001Tptris.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB008_TIPO => _appDbContext.OsusrE9aCsicpBb008Tipos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB010_TP => _appDbContext.OsusrE9aCsicpBb010Tps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB006_BANCO => _appDbContext.OsusrE9aCsicpBb006Bancos.OrderBy(c => c.Nomedobanco),
                StaticTypeBB.CSICP_BB019_TIPO => _appDbContext.OsusrE9aCsicpBb019Tipos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB026_CLASSE => _appDbContext.OsusrE9aCsicpBb026Classes.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB026_TIPO => _appDbContext.OsusrE9aCsicpBb026Tipos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB026_VIN => _appDbContext.OsusrE9aCsicpBb026Vins.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_BCALC => _appDbContext.OsusrE9aCsicpBb027Bcalcs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_CICMS => _appDbContext.OsusrE9aCsicpBb027Cicms.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_DIFER => _appDbContext.OsusrE9aCsicpBb027Difers.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_ENTSAI => _appDbContext.OsusrE9aCsicpBb027Entsais.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_FDESEN => _appDbContext.OsusrE9aCsicpBb027Fdesens.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_IMP => _appDbContext.OsusrE9aCsicpBb027Imps,
                StaticTypeBB.CSICP_BB027_MODAL => _appDbContext.OsusrE9aCsicpBb027Modals.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_MOTIVO => _appDbContext.OsusrE9aCsicpBb027Motivos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_PTERC => _appDbContext.OsusrE9aCsicpBb027Ptercs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027_SIPI => _appDbContext.OsusrE9aCsicpBb027Sipis.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB027A_TPCALC => _appDbContext.OsusrE9aCsicpBb027aTpcalcs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB028_TP => _appDbContext.OsusrE9aCsicpBb028Tps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB035_END => _appDbContext.OsusrE9aCsicpBb035Ends,
                StaticTypeBB.CSICP_BB035_GPA => _appDbContext.OsusrE9aCsicpBb035Gpas.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB035_ORIGEM => _appDbContext.OsusrE9aCsicpBb035Origems.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB035_TRAT => _appDbContext.OsusrE9aCsicpBb035Trats.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeBB.CSICP_BB036_ENDER => _appDbContext.OsusrE9aCsicpBb036Enders,
                StaticTypeBB.CSICP_BB062_STA => _appDbContext.OsusrE9aCsicpBb062Sta.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeBB), "Tipo estático inválido")
            };

            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeClient(StaticaTypes.StaticTypeClient staticTypeClient)
        {
            IQueryable query = staticTypeClient switch
            {
                StaticTypeClient.CSICP_BB012_CLACTA => _appDbContext.OsusrE9aCsicpBb012Clacta.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_MDC => _appDbContext.OsusrE9aCsicpBb012mdcs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_MTD => _appDbContext.OsusrE9aCsicpBb012mtds.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_GRUCTA => _appDbContext.OsusrE9aCsicpBb012Gructa.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_MCRED => _appDbContext.OsusrE9aCsicpBb012Mcreds.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_MREL => _appDbContext.OsusrE9aCsicpBb012Mrels.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_SITCTA => _appDbContext.OsusrE9aCsicpBb012Sitcta.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_STACTA => _appDbContext.OsusrE9aCsicpBb012Stacta.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012_TPCTA => _appDbContext.OsusrE9aCsicpBb012Tpcta.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01201_CON => _appDbContext.OsusrE9aCsicpBb01201Cons.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01201_JUR => _appDbContext.OsusrE9aCsicpBb01201Jurs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01201_TGER => _appDbContext.OsusrE9aCsicpBb01201Tgers.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_DOM => _appDbContext.OsusrE9aCsicpBb01202Doms.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_ECIV => _appDbContext.OsusrE9aCsicpBb01202Ecivs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_ESC => _appDbContext.OsusrE9aCsicpBb01202Escs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_INS => _appDbContext.OsusrE9aCsicpBb01202Ins.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_OCU => _appDbContext.OsusrE9aCsicpBb01202Ocus.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_RES => _appDbContext.OsusrE9aCsicpBb01202Res.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB01202_SEX => _appDbContext.OsusrE9aCsicpBb01202Sexes.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeClient.CSICP_BB012J_TPEND => _appDbContext.OsusrE9aCsicpBb012jTpends.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeClient), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeFF(StaticTypeFF staticTypeFF)
        {
            IQueryable query = staticTypeFF switch
            {
                StaticTypeFF.Csicp_Ff003Tpesps => _appDbContext.OsusrE9aCsicpFf003Tpesps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeFF.Csicp_Ff102ApiBancos => _appDbContext.OsusrE9aCsicpFf102ApiBancos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeFF.Csicp_FF103TPEsp => _appDbContext.OsusrE9aCsicpFf003Tpesps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeFF), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeGG(StaticTypeGG staticTypeFF)
        {
            IQueryable query = staticTypeFF switch
            {
                StaticTypeGG.CSICP_GG007_FRA => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg007Fras).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG021_CEST => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg021cests).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG008Con => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Cons).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG008Efi => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Efis).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG008Kit => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Kits).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG008Gar => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Gars).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_GG019Cgbar => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg019Cgbars).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg008Cdn => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Cdns).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg008dTp => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008dTps).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg008Tpcon => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Tpcons).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg008Tran => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg008Trans).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg016b => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg016bs).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg021cest => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg021cests).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg023Tipo => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg023Tipos).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg025stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg025sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg023Val => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg023Vals).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg028Entsai => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg028Entsais).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg028Nat => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg028Nats).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg030Stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg030Sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg032Stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg032Sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg032Tpinv => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg032Tpinvs).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg034Stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg034Sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg034Tipo => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg034Tipos).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg039Stat => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg039Stats).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg041Tpreq => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg041Tpreqs).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg045Stat => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg045Stats).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg054Stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg054Sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg046Stat => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg046Stats).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg065Tp => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg065Tps).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg071Stum => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg071Sta).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg072Stq => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg072Stqs).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg073Stat => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg073Stats).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg073Tmov => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg073Tmovs).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg902St => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg902Sts).OrderBy(c => c.Label),
                StaticTypeGG.CSICP_Gg903tp => ApplyActiveFilter(_appDbContext.OsusrE9aCsicpGg903tps).OrderBy(c => c.Label),

                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeFF), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeSped(StaticaTypes.StaticSpedType staticSpedType)
        {
            IQueryable query = staticSpedType switch
            {
                StaticSpedType.SpedInNatBc => _appDbContext.Osusr66cSpedInNatBcs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInAjusteIpi => _appDbContext.Osusr66cSpedInAjusteIpis.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInAjIcm => _appDbContext.Osusr66cSpedInAjIcms.Where(c => c.Isactive == true).OrderBy(c => c.Descricao),
                StaticSpedType.SpedInCenqIpi => _appDbContext.Osusr66cSpedInCenqIpis.Where(c => c.IsActive == true).OrderBy(c => c.Descricao),
                StaticSpedType.SpedInCfop => _appDbContext.Osusr66cSpedInCfops.Where(c => c.IsActive == true).OrderBy(c => c.Descricao),
                StaticSpedType.SpedInCodAjuste => _appDbContext.Osusr66cSpedInCodAjustes.Where(c => c.Isactive == true).OrderBy(c => c.Descricao),
                StaticSpedType.SpedInDispAutor => _appDbContext.Osusr66cSpedInDispAutors.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInEnquadIpi => _appDbContext.Osusr66cSpedInEnquadIpis.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInMotInv => _appDbContext.Osusr66cSpedInMotInvs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInNatExp => _appDbContext.Osusr66cSpedInNatExps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInSeloIpi => _appDbContext.Osusr66cSpedInSeloIpis.Where(c => c.Isactive == true).OrderBy(c => c.Descricao),
                StaticSpedType.STRelevancia => _appDbContext.OsusrSpedNnxCsicpStrelevancia.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInTotRedZ => _appDbContext.Osusr66cSpedInTotRedZs.OrderBy(c => c.Label),
                StaticSpedType.SpedInTpAjuste => _appDbContext.Osusr66cSpedInTpAjustes.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInDocIcm => _appDbContext.OsusrNnxSpedInDocIcms.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInEmitente => _appDbContext.OsusrNnxSpedInEmitentes.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInGenItem => _appDbContext.OsusrNnxSpedInGenItems.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInSitDocC => _appDbContext.OsusrNnxSpedInSitDocCs.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInTabela => _appDbContext.OsusrNnxSpedInTabelas.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticSpedType.SpedInTipoItem => _appDbContext.OsusrNnxSpedInTipoItems.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                _ => throw new ArgumentOutOfRangeException(nameof(staticSpedType), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }

        public async Task<IReadOnlyCollection<object>> GetStaticasByTypeSys(StaticaTypes.StaticTypeSys staticTypeSys)
        {
            IQueryable query = staticTypeSys switch
            {
                StaticTypeSys.CSICP_sy003Regra => _appDbContext.OsusrE9aCsicpSy003Regras.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeSys.CSICP_sy004Rest => _appDbContext.OsusrE9aCsicpSy004Rests.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeSys.CSICP_sy016tipo => _appDbContext.OsusrE9aCsicpSy016tipos.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeSys.CSICP_SY807cSSP => _appDbContext.OsusrE9aCsicpSy807Cssps.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeSys.CSICP_SY809Idioma => _appDbContext.OsusrE9aCsicpSy809Idiomas.Where(c => c.IsActive == true).OrderBy(c => c.Label),
                StaticTypeSys.CSICP_SY994Padrao => _appDbContext.OsusrE9aCsicpSy994Padraos.Where(c => c.IsActive == true).OrderBy(c => c.Label),

                _ => throw new ArgumentOutOfRangeException(nameof(staticTypeSys), "Tipo estático inválido")
            };
            return await query.Cast<object>().ToListAsync();
        }
    }
}