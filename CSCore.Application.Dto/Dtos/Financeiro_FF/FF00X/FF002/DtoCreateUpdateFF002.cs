using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002
{
    public class DtoCreateUpdateFF002 : IConverteParaEntidade<CSICP_FF002>
    {
        public int? Ff002Tiporegistro { get; set; }

        public int? Ff002Codigo { get; set; }

        public string? Ff002Motivo { get; set; }

        public int? Ff002Peso { get; set; }

        public CSICP_FF002 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF002
            {
                TenantId = tenant,
                Id = id!,
                Ff002Tiporegistro = Ff002Tiporegistro,
                Ff002Codigo = Ff002Codigo,
                Ff002Motivo = Ff002Motivo,
                Ff002Peso = Ff002Peso
            };
        }
    }
}
