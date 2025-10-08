using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy
{
    public abstract class PR21_IQueryImpl
    {
        public AppDbContext AppDbContext;

        protected PR21_IQueryImpl(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public abstract Task<List<CSICP_FF102>> Execute(int InTenant);

        protected virtual IQueryable<T>? GetQuery<T>()
        {
            var ff102WithIncludes = AppDbContext.OsusrE9aCsicpFf102s
                .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF104);
            if (typeof(T) == typeof(CSICP_FF102))
            {
                return ff102WithIncludes as IQueryable<T>;
            }
            throw new NotSupportedException($"Tipo não suportado: {typeof(T).Name}");
        }
    }
}
