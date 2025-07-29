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

        //Navs


    }
}
