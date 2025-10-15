using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    public class DtoCreateUpdateRR021 : IConverteParaEntidade<OsusrTo3CsicpRr021>
    {
        public string? Rr021Loteid { get; set; }

        public string? Rr021Animalid { get; set; }

        public DateTime? Rr021Dtregistro { get; set; }

        public OsusrTo3CsicpRr021 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr021
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr021Loteid = Rr021Loteid,
                Rr021Animalid = Rr021Animalid,
                Rr021Dtregistro = Rr021Dtregistro
            };
        }
    }
}