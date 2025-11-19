using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.CG003.Filtros
{
    internal class FiltroDescricaoCG003 : ICSFilter<CSICP_CG003>
    {
        private readonly string? _descricao;

        public FiltroDescricaoCG003(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<CSICP_CG003> Apply(IQueryable<CSICP_CG003> query)
        {
            if (!string.IsNullOrEmpty(_descricao))
            {
                query = query.Where(e => e.Cg003Descricao == _descricao);
            }
            return query;
        }
    }
}