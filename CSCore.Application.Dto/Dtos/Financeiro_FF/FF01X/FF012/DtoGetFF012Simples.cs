using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF012
{
    public class DtoGetFF012Simples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff012Filialid { get; set; }
        public int? Ff012CodigoGrupo { get; set; }
        public string? Ff012DescricaoGrupo { get; set; }
        public string? Ff012Usuariosuperid { get; set; }
        public string? Ff014Comissaosuperid { get; set; }
        public string? Ff014Comissaocobradorid { get; set; }
        public string? Ff012Grupopaiid { get; set; }
    }
}
