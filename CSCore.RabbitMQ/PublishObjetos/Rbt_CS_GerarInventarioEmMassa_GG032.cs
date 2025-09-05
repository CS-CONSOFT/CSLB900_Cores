using CSCore.Domain.CS_QueryFilters.GG032;

namespace CSCore.RabbitMQ.PublishObjetos
{
    public class Rbt_CS_GerarInventarioEmMassa_GG032
    {
        public int in_tenantId { get; set; }
        public bool isQtdZero { get; set; }
        public FiltroProdutoRequest request { get; set; }
        public int idgg001_talmox_virtual { get; set; }
        public string in_usuarioId { get; set; }
    }
}
