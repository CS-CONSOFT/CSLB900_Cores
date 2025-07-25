using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Consumidor.MinhasEntrega
{
    public class DtoMinhasEntregas
    {
        public string? Protocolo { get; set; }
        public string? Produto { get; set; }
        public decimal? Quantidade { get; set; }
        public string? Unidade { get; set; }
       // public string Imagem { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string? StatusEntrega { get; set; }
        public DateTime? EmissaoNF { get; set; }
        public string? Serie { get; set; }

    }
}
