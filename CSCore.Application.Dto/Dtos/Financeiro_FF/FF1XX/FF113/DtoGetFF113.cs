using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF113
{
    public class DtoGetFF113
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff113Usuariopropr { get; set; }

        public string? Ff113Filialid { get; set; }

        public string? Ff113RefConfBanco { get; set; }

        public DateTime? Ff113Dataregistro { get; set; }

        public string? Ff113Nota { get; set; }

        public int? Ff113Lote { get; set; }

        public string? Ff113Desclote { get; set; }

        public string? Ff113Borderoid { get; set; }

        public int? Ff113Tipo { get; set; }

        public string? Ff113Retornoid { get; set; }

        public string? Nn015Bxtesourariaid { get; set; }

        public int? Ff113Codgmovtoremessa { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public DtoGetFF112Simples? NavFF112 { get; set; }
        public OsusrE9aCsicpFf113Tipo? NavFF113Tipo { get; set; }
        public Dto_GetSY001Simples? NavSy001 { get; set; }


    }
}
