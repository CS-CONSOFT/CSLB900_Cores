using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.SiteProperties
{
    public interface IVerificaSiteProperties
    {
        Task<bool> VerificaAsync(int tenant, string identificacao);
    }
}
