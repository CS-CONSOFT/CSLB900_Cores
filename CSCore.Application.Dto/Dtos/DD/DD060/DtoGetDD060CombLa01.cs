using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD060
{
    public class DtoGetDD060CombLa01
    {
        public int TenantId { get; set; }

        public long Id { get; set; }

        public string? Dd060Id { get; set; }

        public string? La02Cprodanp { get; set; }

        public string? La03Descanp { get; set; }

        public decimal? La03aPglp { get; set; }

        public decimal? La03bPgnn { get; set; }

        public decimal? La03cPgni { get; set; }

        public decimal? La03dVpart { get; set; }

        public string? La04Codif { get; set; }

        public decimal? La05Qtemp { get; set; }

        public decimal? La17Pbio { get; set; }

        public string? La06Ufcons { get; set; }
    }
}
