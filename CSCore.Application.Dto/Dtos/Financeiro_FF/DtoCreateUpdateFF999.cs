using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF
{
    public class DtoCreateUpdateFF999 : IConverteParaEntidade<CSICP_FF999>
    {
        public string? Ff999IdControle { get; set; }

        public int? Ff999Parcela { get; set; }

        public DateTime? Ff999Datavencto { get; set; }

        public decimal? Ff999Valorparcela { get; set; }

        public CSICP_FF999 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF999
            {
                TenantId = tenant,
                Id = id!,
                Ff999IdControle = Ff999IdControle,
                Ff999Parcela = Ff999Parcela,
                Ff999Datavencto = Ff999Datavencto,
                Ff999Valorparcela = Ff999Valorparcela,
            };
        }
    }
}
