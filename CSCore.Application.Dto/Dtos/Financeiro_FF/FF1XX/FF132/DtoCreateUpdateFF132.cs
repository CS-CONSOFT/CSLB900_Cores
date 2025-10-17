using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF132
{
    public class DtoCreateUpdateFF132 : IConverteParaEntidade<CSICP_FF132>
    {
        public long? Ff131Id { get; set; }

        public IEnumerable<string> ListFF102Id { get; set; }

        public CSICP_FF132 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF132
            {
                
            };
        }
    }

    public partial class DtoCreateCSICP_FF141 : IConverteParaEntidade<CSICP_FF141>
    {
        public long? Ff140RdId { get; set; }

        public string? Ff141Descricao { get; set; }

        public decimal? Ff141Vunitario { get; set; }

        public decimal? Ff141Qtd { get; set; }

        public decimal? Ff141Total { get; set; }

        public CSICP_FF141 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF141
            {
                TenantId = tenant,
                Ff140RdId = this.Ff140RdId,
                Ff141Descricao = this.Ff141Descricao,
                Ff141Vunitario = this.Ff141Vunitario,
                Ff141Qtd = this.Ff141Qtd,
                Ff141Total = this.Ff141Total,
            };
        }
    }
    }
