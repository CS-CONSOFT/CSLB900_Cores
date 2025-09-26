using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_AA.AA1XX.AA143
{
    public class DtoCreateUpdateAA143
    {
        public string? Aa043Artigo { get; set; }

        public string? Aa043LcRedacao { get; set; }

        public string? Aa043Ec { get; set; }
        public CSICP_AA143 ToEntity(string? id)
        {
            return new CSICP_AA143
            {
                Id = id!,
                Aa043Artigo = Aa043Artigo,
                Aa043LcRedacao = Aa043LcRedacao,
                Aa043Ec = Aa043Ec,
            };
        }
    } 
}
