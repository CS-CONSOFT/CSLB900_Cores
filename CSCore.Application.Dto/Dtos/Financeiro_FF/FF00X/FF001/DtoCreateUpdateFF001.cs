using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF001
{
    public class DtoCreateUpdateFF001 : IConverteParaEntidade<CSICP_FF001>                                                                         
    {
        public string? Ff001Filialid { get; set; }

        public int? Ff001Filial { get; set; }

        public DateTime? Ff001Data { get; set; }

        public string? Ff001Descferiado { get; set; }

        public string? Ff001NomeDoDia { get; set; }

        public CSICP_FF001 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF001
            {
                TenantId = tenant,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                Id = id!,
                Ff001Filialid = Ff001Filialid,
                Ff001Filial = Ff001Filial,
                Ff001Data = Ff001Data,
                Ff001Descferiado = Ff001Descferiado,
                Ff001NomeDoDia = Ff001NomeDoDia,
            };
        }
    }
}
