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
        [Required(ErrorMessage = "O ID do lote é obrigatório.")]
        public string? In_LoteId { get; set; }

        [Required(ErrorMessage = "A data do peso é obrigatória.")]
        public DateTime? In_DataPeso { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public string? In_UsuarioID { get; set; }
        }
}
