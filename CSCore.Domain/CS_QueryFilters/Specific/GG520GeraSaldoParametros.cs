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
        public string? lote { get; set; } = null;
        public string? subLote { get; set; } = null;
        public string? descricaoLote { get; set; } = null;
        public string? gradeLinhaID { get; set; } = null;
        public string? gradeColunaID { get; set; } = null;
        public bool? prm_ExbirEmConsulta { get; set; } = true;
        public string? prm_LocalizacaoWMS { get; set; } = null;
        public string? contaID { get; set; } = null;
        public string? usuarioID { get; set; } = null;
        public bool? isPDV { get; set; } = default;
        public string? Prm_SaldoId_Origem_VendaFutura { get; set; } = null;

    }
}
