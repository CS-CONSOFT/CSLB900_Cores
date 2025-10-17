using CSCore.Domain.CS_Models.CSICP_TT;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT031
{
    public class DtoCreateUpdateTT031 : IConverteParaEntidade<CSICP_TT031>
    {
        public long? Tt030Id { get; set; }

        public string? CsCodgproduto { get; set; }

        public decimal? CsQtd { get; set; }

        public decimal? CsValor { get; set; }

        public decimal? CsDesc { get; set; }

        [JsonIgnore]
        public string? Gg008Id { get; set; }
        [JsonIgnore]
        public string? Gg008kdxId { get; set; }
        [JsonIgnore]
        public string? Gg520Id { get; set; }
        [JsonIgnore]
        public string? Campoespecial1 { get; set; }
        [JsonIgnore]
        public string? Campoespecial2 { get; set; }
        public string? Tt030Estabid { get; set; }
        public string? GG007UnidadeID { get; set; }

        public CSICP_TT031 ToEntity(int tenant, string? id)
        {
            return new CSICP_TT031
            {
                TenantId = tenant,
                //Tt031Id = long.Parse(id!),
                Tt030Id = this.Tt030Id,
                CsCodgproduto = this.CsCodgproduto,
                CsQtd = this.CsQtd,
                CsValor = this.CsValor,
                CsDesc = this.CsDesc,
                Gg008Id = this.Gg008Id,
                Gg008kdxId = this.Gg008kdxId,
                Gg520Id = this.Gg520Id,
                Campoespecial1 = this.Campoespecial1,
                Campoespecial2 = this.Campoespecial2,
                gg007_UnID = this.GG007UnidadeID
            };
        }
    }
}
