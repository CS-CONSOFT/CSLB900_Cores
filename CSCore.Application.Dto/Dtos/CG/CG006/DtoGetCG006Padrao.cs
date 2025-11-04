using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG006
{
    public class DtoGetCG006Padrao
    {
        public int TenantId { get; set; }

        public string Cg006Id { get; set; } = null!;

        public string? Cg006FilialId { get; set; }

        public string? Cg006Codigoplano { get; set; }

        public string? Cg006Descricao { get; set; }

        public string? Cg006Descresumida { get; set; }

        public int? Cg006ClassificacaoId { get; set; }

        public int? Cg006NaturezaId { get; set; }

        public int? Cg006TipocontaId { get; set; }

        public int? Cg006Grau { get; set; }

        public string? Cg006CtasuperiorId { get; set; }

        public int? Cg006Codgreduzido { get; set; }

        public string? Cg006GrupoId { get; set; }

        public string? Cg006HistoricoId { get; set; }

        public DateTime? Cg006Dtiniexistencia { get; set; }

        public string? Cg006AmarracaoNivel2 { get; set; }

        public string? Cg006AmarracaoNivel3 { get; set; }

        public string? Cg006AmarracaoNivel4 { get; set; }

        public bool? Cg006Isactive { get; set; }

        public int? Cg006LanctoN2obrig { get; set; }

        public int? Cg006LanctoN3obrig { get; set; }

        public int? Cg006LanctoN4obrig { get; set; }

        public int? Cg006ConsolidaLancto { get; set; }
    }
}
