using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF119
{
    public class DtoGetFF119
    {
        public int TenantId { get; set; }
        public long Ff119Id { get; set; }
        public string Ff112Id { get; set; } = null!;
        public int? Ff119Regid { get; set; }
        public int? Ff119Posicaode { get; set; }
        public int? Ff119Posicaoate { get; set; }
        public string? Ff119Conteudo { get; set; }
        public string? Ff119Descricao { get; set; }
        public OsusrE9aCsicpFf112Reg? NavFF112Reg { get; set; }
    }
}
