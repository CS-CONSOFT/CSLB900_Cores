namespace CSCore.Application.Dto.Dtos.Financeiro_FF.VisoesGeraisFinanceiro.Inadimplencia
{
    public class DtoInadimplenciaRequest
    {
        public int TenantId { get; set; }
        public List<string>? FiltroEstabelecimentos { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}