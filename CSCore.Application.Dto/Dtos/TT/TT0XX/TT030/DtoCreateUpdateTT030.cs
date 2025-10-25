using CSCore.Domain.CS_Models.CSICP_TT;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT030
{
    public class DtoCreateUpdateTT030 : IConverteParaEntidade<CSICP_TT030>
    {
        [Required]
        public string Tt030Estabid { get; set; } = "";

        [JsonIgnore]
        public string? Tt030Protocolonumber { get; set; }

        public DateTime? Tt030Datahora { get; set; }

        public string? Tt030Usuariopropid { get; set; }

        public string? Tt030Usuariovendedorid { get; set; }

        public string? Tt030Observacao { get; set; }
        [JsonIgnore]
        public string? Tt030Protocolnumber { get; set; }
        public CSICP_TT030 ToEntity(int tenant, string? _)
        {
            return new CSICP_TT030
            {
                TenantId = tenant,
                Tt030Estabid = Tt030Estabid,
                Tt030Datahora = Tt030Datahora,
                Tt030Usuariopropid = Tt030Usuariopropid,
                Tt030Usuariovendedorid = Tt030Usuariovendedorid,
                Tt030Observacao = Tt030Observacao,
                Tt030Protocolnumber = Tt030Protocolnumber,
            };
        }
    }
}



























