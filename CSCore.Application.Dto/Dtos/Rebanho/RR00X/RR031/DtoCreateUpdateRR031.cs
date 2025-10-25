using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031
{
    public class DtoCreateUpdateRR031 : IConverteParaEntidade<OsusrTo3CsicpRr031>
    {
        public string? Rr031IatfId { get; set; }

        public string? Rr031Animalid { get; set; }

        public DateTime? Rr031Dtregistro { get; set; }

        public bool? Rr031Ispositivo { get; set; }

        public string? Rr031Montaanimalid { get; set; }

        public string? Rr031Semenid { get; set; }

        public OsusrTo3CsicpRr031 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr031
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr031IatfId = Rr031IatfId,
                Rr031Animalid = Rr031Animalid,
                Rr031Dtregistro = Rr031Dtregistro,
                Rr031Ispositivo = Rr031Ispositivo,
                Rr031Montaanimalid = Rr031Montaanimalid,
                Rr031Semenid = Rr031Semenid
            };
        }
    }
}