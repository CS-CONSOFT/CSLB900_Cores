namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG520GeraSaldoParametros
    {
        public int Tenant_ID { get; set; } = default;
        public string gg001_almoxID { get; set; } = string.Empty;
        public string bb001_filialID { get; set; } = string.Empty;
        public string gg008_kdxID { get; set; } = string.Empty;
        /// <summary>
        /// Número de série do produto. Se o produto não for controlado por número de série, o valor deve ser nulo ou zero.
        /// </summary>
        public decimal? prmNumeroSerie { get; set; } = default;

        /// <summary>
        /// Número de série do produto. Se o produto não for controlado por número de série, o valor deve ser nulo ou zero.
        /// </summary>
        public string? prmDescricao { get; set; } = default;
        public string? lote { get; set; } = string.Empty;
        public string? subLote { get; set; } = string.Empty;
        public string? descricaoLote { get; set; } = string.Empty;
        public string? gradeLinhaID { get; set; } = string.Empty;
        public string? gradeColunaID { get; set; } = string.Empty;
        public bool? prm_ExbirEmConsulta { get; set; } = true;
        public string? prm_LocalizacaoWMS { get; set; } = string.Empty;
        public string? contaID { get; set; } = string.Empty;
        public string? usuarioID { get; set; } = string.Empty;
        public bool? isPDV { get; set; } = default;
        public string? Prm_SaldoId_Origem_VendaFutura { get; set; } = string.Empty;

    }
}
