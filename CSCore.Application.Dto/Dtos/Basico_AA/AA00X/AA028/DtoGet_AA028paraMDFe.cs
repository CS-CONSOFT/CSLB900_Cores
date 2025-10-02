using CSBS101._82Application.Dto.AA00X;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027;
using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA028
{
    public class DtoGet_AA028paraMDFe
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Aa028Cidade { get; set; }

        public decimal? Aa028Percicmscontrib { get; set; }

        public decimal? A028Percicmsncontrib { get; set; }

        public decimal? A028Percsubsttribut { get; set; }

        public string? A028Mascinsestadual { get; set; }

        public decimal? A028Percicmsentrada { get; set; }

        public string? A028Mascieimpressao { get; set; }

        public int? Aa028Codgibge { get; set; }

        public int? Aa028Zonafranca { get; set; }

        public int? Aa028Estadobrasil { get; set; }

        public string? Ufid { get; set; }

        public string? Aa028ExportCidadeid { get; set; }

        public string? Aa027ExportUfid { get; set; }

        public DtoGet_AA027paraMDFe? NavAA027UfbyBB001 { get; set; }
    }
}
