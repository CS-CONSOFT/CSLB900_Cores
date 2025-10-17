using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR030
{
    public class DtoCreateUpdateRR030 : IConverteParaEntidade<OsusrTo3CsicpRr030>
    {
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string? Rr030Descricao { get; set; }

        public DateTime? Rr030IaData { get; set; }

        public int? Rr030IaNrodias { get; set; }

        public DateTime? Rr030IaDatadg { get; set; }

        public DateTime? Rr030Datamontainicial { get; set; }

        public int? Rr030Montainicialdias { get; set; }

        public DateTime? Rr030Datamontafinal { get; set; }

        public int? Rr030Montafinaldias { get; set; }

        public DateTime? Rr030Dataprovontainicial { get; set; }

        public DateTime? Rr030Dataprovontafinal { get; set; }

        public OsusrTo3CsicpRr030 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr030
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr030Descricao = Rr030Descricao,
                Rr030IaData = Rr030IaData,
                Rr030IaNrodias = Rr030IaNrodias,
                Rr030IaDatadg = Rr030IaDatadg,
                Rr030Datamontainicial = Rr030Datamontainicial,
                Rr030Montainicialdias = Rr030Montainicialdias,
                Rr030Datamontafinal = Rr030Datamontafinal,
                Rr030Montafinaldias = Rr030Montafinaldias,
                Rr030Dataprovontainicial = Rr030Dataprovontainicial,
                Rr030Dataprovontafinal = Rr030Dataprovontafinal
            };
        }
    }
}