using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.PrmFiltros.FF125;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.CS_QueryFilters
{
    // Na classe abstrata
    public abstract class GetListFiltrosBaseImplementacaoAbstract<TEntity, TFiltros>
        where TEntity : class
        where TFiltros : ParametrosBaseFiltro
    {
        protected virtual ICSInclude<TEntity>[] GetIncludesParaAplicar()
        {
            throw new NotImplementedException("Implementação do GetInclude deve ser feita na classe filha");
        }


        protected abstract ICSFilter<TEntity>[] GetOutrosFiltros(int TenantId, TFiltros Filtros);

        protected virtual ICSFilter<TEntity>[] GetFiltrosParaAplicar(int TenantId, TFiltros Filtros)
        {
            var filtrosPersonalizados = GetOutrosFiltros(TenantId, Filtros) ?? [];
            
            return new ICSFilter<TEntity>[] { new FiltroBaseTenantId<TEntity>(TenantId) }
                .Concat(filtrosPersonalizados)
                .ToArray();
        }

        protected IQueryable<TEntity> AplicaIncludes(IQueryable<TEntity> query, params ICSInclude<TEntity>[] InIncludes)
        {
            foreach (var include in InIncludes)
            {
                query = include.ApplyIncludes(query);
            }
            return query;
        }

        protected IQueryable<TEntity> AplicaFiltro(IQueryable<TEntity> query, params ICSFilter<TEntity>[] InFiltros)
        {
            foreach (var filtro in InFiltros)
            {
                query = filtro.Apply(query);
            }
            return query;
        }
    }


}
