using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR020;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    /// <summary>
    /// DTO para retornar RR021 (Lote x Animal) com dados do RR020 (Lote)
    /// Usado em: RR031 - Controle de Gestação
    /// </summary>
    public class DtoGetRR021_ComRR020
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr021Loteid { get; set; }

        public string? Rr021Animalid { get; set; }

        public DateTime? Rr021Dtregistro { get; set; }

        // Navegação
        /// <summary>
        /// Dados do Lote (RR020)
        /// </summary>
        public DtoGetRR020Padrao? NavRR020RegLote { get; set; }
    }
}