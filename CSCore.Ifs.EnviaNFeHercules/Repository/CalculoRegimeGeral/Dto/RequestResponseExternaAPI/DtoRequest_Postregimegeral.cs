using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto.RequestResponseExternaAPI
{
    public record DtoRequest_Postregimegeral(string Id, string Versao, DateTime DataHoraEmissao, long Municipio, string Uf, List<DtoWorkItensRecord> Itens)
    
}
