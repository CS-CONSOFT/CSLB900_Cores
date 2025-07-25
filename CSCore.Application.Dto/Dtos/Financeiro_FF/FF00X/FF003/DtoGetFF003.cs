using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003
{
    public class DtoGetFF003
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff003Filialid { get; set; }

        public int? Ff003Tipoespecie { get; set; }

        public int? Ff003Codigo { get; set; }

        public string? Ff003Descricao { get; set; }

        public string? Ff003Descresumida { get; set; }

        public string? Ff003Pfx { get; set; }

        public int? Ff003Provisao { get; set; }

        public string? Ff003Ccustoid { get; set; }

        public string? Ff003Lctoenttitulosid { get; set; }

        public string? Ff003Lctobxnormalid { get; set; }

        public string? Ff003Lctobxdevolucaoid { get; set; }

        public decimal? Ff003Seqnrotitulo { get; set; }
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public OsusrE9aCsicpFf003Tpesp? NavFF003TpEsp { get; set; }
        public CSICP_Statica? NavStatica { get; set; }
    }
    public class Dto_GetFF003_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        //public string? Ff003Filialid { get; set; }

        //public int? Ff003Tipoespecie { get; set; }

        public int? Ff003Codigo { get; set; }

        public string? Ff003Descricao { get; set; }
    }
}
