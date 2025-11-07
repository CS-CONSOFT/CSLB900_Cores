using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR020
{
    public class DtoCreateUpdateRR020 : IConverteParaEntidade<OsusrTo3CsicpRr020>
    {
        public string? Rr020Identificador { get; set; }

        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string? Rr020Descricao { get; set; }

        public DateTime? Rr020Dtinicio { get; set; }

        public DateTime? Rr020Dtfinal { get; set; }

        public long? Rr020Regalimentarid { get; set; }

        public bool? Rr020IsActive { get; set; }

        public OsusrTo3CsicpRr020 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr020
            {
                TenantId = tenant,
                Id = id!,
                Rr020Identificador = Rr020Identificador,
                Rr020Descricao = Rr020Descricao,
                Rr020Dtinicio = Rr020Dtinicio,
                Rr020Dtfinal = Rr020Dtfinal,
                Rr020Regalimentarid = Rr020Regalimentarid,
                Rr020IsActive = Rr020IsActive
            };
        }
    }
}