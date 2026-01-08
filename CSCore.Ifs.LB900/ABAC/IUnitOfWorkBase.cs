using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC
{
    public interface IUnitOfWorkBase
    {
        Task<int> SaveChangesAsync();
    }
}
