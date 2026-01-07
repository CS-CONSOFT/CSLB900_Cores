using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD810
{
    public class DtoCreateUpdateDD810 : IConverteParaEntidade<CSICP_DD810>
    {
        public int? Dd810CfopSaida { get; set; }
        public int? Dd810CfopEntrada { get; set; }
        public string? Dd810Anotacao { get; set; }

        public CSICP_DD810 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD810
            {
                TenantId = tenant,
                Dd810Id = id ?? string.Empty,
                Dd810CfopSaida = Dd810CfopSaida,
                Dd810CfopEntrada = Dd810CfopEntrada,
                Dd810Anotacao = Dd810Anotacao
            };
        }
    }
}