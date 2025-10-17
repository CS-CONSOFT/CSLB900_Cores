using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF007
{
    public class DtoCreateUpdateFF007 : IConverteParaEntidade<CSICP_FF007>
    {
        public string? Ff007Estabid { get; set; }
        public int? Ff007Diasate { get; set; }
        public decimal? Ff007Pdesconto { get; set; }

        public CSICP_FF007 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF007
            {
                TenantId = tenant,
                //Ff007Id = long.Parse(id!),
                Ff007Estabid = Ff007Estabid,
                Ff007Diasate = Ff007Diasate,
                Ff007Pdesconto = Ff007Pdesconto,
            };
        }
    }
}
