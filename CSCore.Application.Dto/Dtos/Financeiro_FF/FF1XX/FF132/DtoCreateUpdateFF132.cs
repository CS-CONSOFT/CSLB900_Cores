using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
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
}
