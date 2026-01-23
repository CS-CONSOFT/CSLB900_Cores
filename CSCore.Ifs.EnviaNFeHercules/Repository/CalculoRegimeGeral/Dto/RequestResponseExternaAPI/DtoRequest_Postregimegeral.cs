using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto.RequestResponseExternaAPI
{
    public record DtoRequest_Postregimegeral(string id, string versao, DateTimeOffset dataHoraEmissao, long municipio, string uf,
        List<DtoWorkItensRecord> itens)
    {

    };
}
