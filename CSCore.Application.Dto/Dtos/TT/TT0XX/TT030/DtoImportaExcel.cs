using Microsoft.AspNetCore.Http;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT030
{
    public class DtoImportaExcel
    {
        public int Tenant_ID { get; set; }
        public string EstabId { get; set; }
        public long Tt030Id { get; set; }
        public IFormFile ArquivoExcel { get; set; }
    }
}
