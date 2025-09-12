using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Domain.Interfaces.PrmFiltros.FF125;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF125.IncludesFF125List;
using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.Extensao;
using GG104Materiais.C82Application.Service.FF1XX.FF125;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF125
{
    public class FF125RepositoryImpl : IFF125Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF125RepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF125>, int)> GetListAsync(int InTenantID, PrmFiltrosFF125 InPrmFiltrosFF125)
        {
            var query = _appDbContext.OsusrE9aCsicpFf125s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == InTenantID);

            query = AplicaIncludes(query, GetIncludesParaAplicar());
            query = FiltraQuandoExisteFiltro(query, InPrmFiltrosFF125, GetFiltrosParaAplicar(InPrmFiltrosFF125));

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(InPrmFiltrosFF125.PageNumber, InPrmFiltrosFF125.PageSize);

            return (await query.ToListAsync(), count);
        }

        private ICSInclude<CSICP_FF125>[] GetIncludesParaAplicar()
        {
            return
            [
                new IncludeNavBB012Conta(),
                new IncludeNavFF002Motivo(),
            ];
        }   

        private ICSFilter<CSICP_FF125>[] GetFiltrosParaAplicar(PrmFiltrosFF125 InPrmFiltrosFF125)
        {
            return
            [
                new SitCtaIdFiltro(InPrmFiltrosFF125.InBB012_SitCtaId),
            ];
        }

        private IQueryable<CSICP_FF125> AplicaIncludes(IQueryable<CSICP_FF125> query, params ICSInclude<CSICP_FF125>[] InIncludes)
        {
            foreach (var include in InIncludes)
            {
                query = include.ApplyIncludes(query);
            }
            return query;
        }

        private IQueryable<CSICP_FF125> FiltraQuandoExisteFiltro(IQueryable<CSICP_FF125> query, PrmFiltrosFF125 InPrmFiltrosFF125, params ICSFilter<CSICP_FF125>[] InFiltros)
        {
            foreach (var filtro in InFiltros)
            {
                query = filtro.Apply(query);
            }

            if (InPrmFiltrosFF125.InBB010_ZonaCobrancaId != "" || InPrmFiltrosFF125.InBB010_ZonaCobrancaId != null)
            {
                query = from ff125 in query
                        join bb012 in _appDbContext.OsusrE9aCsicpBb012s on ff125.Ff125ContaId equals bb012.Id
                        join bb01201 in _appDbContext.OsusrE9aCsicpBb01201s on bb012.Id equals bb01201.Id
                        where bb01201.Bb012Zonaid == InPrmFiltrosFF125.InBB010_ZonaCobrancaId
                        select ff125;
            }

            if (!string.IsNullOrEmpty(InPrmFiltrosFF125.InBB006_CobradorID))
                query = query.Where(e => e.Ff125AgcobradorId == InPrmFiltrosFF125.InBB006_CobradorID);

            if (InPrmFiltrosFF125.InDataPrevisaoInicial.HasValue && InPrmFiltrosFF125.InDataPrevisaoFinal.HasValue)
            {
                query = query.Where(e => e.Ff125Dtprevisaogeral >= InPrmFiltrosFF125.InDataPrevisaoInicial.Value
                && e.Ff125Dtprevisaogeral <= InPrmFiltrosFF125.InDataPrevisaoFinal.Value);
            }


            if (InPrmFiltrosFF125.InDataRegistroInicial.HasValue && InPrmFiltrosFF125.InDataRegistroFinal.HasValue)
            {
                query = query.Where(e => e.Ff125Dtregistro >= InPrmFiltrosFF125.InDataRegistroInicial.Value
                && e.Ff125Dtregistro <= InPrmFiltrosFF125.InDataRegistroFinal.Value);
            }

            if (!string.IsNullOrEmpty(InPrmFiltrosFF125.InNomeCliente))
            {
                query = from ff125 in query
                        join bb012 in _appDbContext.OsusrE9aCsicpBb012s on ff125.Ff125ContaId equals bb012.Id
                        where bb012.Bb012NomeCliente!.Contains(InPrmFiltrosFF125.InNomeCliente)
                        select ff125;
            }

            if (InPrmFiltrosFF125.InRegistroCobrado.HasValue && InPrmFiltrosFF125.InRegistroCobrado.Value != EnumRegistroCobradoFF125.Nenhum)
                query = query.Where(e => e.Ff125Iscobrado == (InPrmFiltrosFF125.InRegistroCobrado == EnumRegistroCobradoFF125.Cobrado));

            return query;
        }

    }
}
