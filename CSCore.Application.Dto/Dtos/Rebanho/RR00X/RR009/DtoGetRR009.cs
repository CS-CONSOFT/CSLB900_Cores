using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR009
{
    /// <summary>
    /// DTO para retorno completo de relacionamento Animal x Animal Virtual (RR009)
    /// </summary>
    public class DtoGetRR009
    {
        public int TenantId { get; set; }
        
        public string Id { get; set; } = null!;
        
        public string Rr001Id { get; set; } = null!;
        
        public string Rr001Virtualid { get; set; } = null!;

        // Navegações
        public DtoGetRR001Padrao? NavRR001Animal { get; set; }
        
        public DtoGetRR001Padrao? NavRR001AnimalVirtual { get; set; }
    }
}