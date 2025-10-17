using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF016
{
    public class DtoCreateUpdateFF016 : IConverteParaEntidade<CSICP_FF016>
    {
        public string? Ff016DescricaoCarta { get; set; }
        public byte[]? Ff016Texto { get; set; }
        public int? Ff016EmailsdestId { get; set; }
        public string? Ff016Textocarta { get; set; }
        public CSICP_FF016 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF016
            {
                TenantId = tenant,
                Id = id!,
                Ff016DescricaoCarta = Ff016DescricaoCarta,
                Ff016Texto = Ff016Texto,
                Ff016EmailsdestId = Ff016EmailsdestId,
                Ff016Textocarta = Ff016Textocarta,
            };
        }
    }
}
