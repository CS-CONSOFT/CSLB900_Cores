using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.RR._00X.IRR022
{
    public class PrmProcessaPesoRR022
    {
        public string? In_LoteId { get; set; }

        [Required(ErrorMessage = "A data do peso é obrigatória para processamento.")]
        public DateTime? In_DataPeso { get; set; }
    }
}
