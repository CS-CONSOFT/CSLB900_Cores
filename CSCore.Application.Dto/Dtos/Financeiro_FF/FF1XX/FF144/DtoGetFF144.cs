using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF144
{
    public class DtoGetFF144
    {
        public int TenantId { get; set; }

        public long Ff144Id { get; set; }

        public long? Ff144RdId { get; set; }

        public DateTime? Ff144Dhregistro { get; set; }

        public string? Ff144Usuarioproprieid { get; set; }

        public int? Ff144Statusid { get; set; }

        public int? Ff144Execucaoid { get; set; }

        public string? F144Observacao { get; set; }

        public CSICP_FF140Sta? NavFF140StatusFF144 { get; set; }
        public OsusrE9aCsicpFf140Exe? NavFF140ExecucaoFF144 { get; set; }
        public Dto_GetSY001Simples? NavSY001UsuarioFF144 { get; set; }
    }
}
