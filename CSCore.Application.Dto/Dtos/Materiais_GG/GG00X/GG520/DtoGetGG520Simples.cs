using GG104Materiais.C82Application.Dto.GG00X.GG001;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520
{
    public class DtoGetGG520Simples
    {
        public string Id { get; set; } = null!;
        public string? Gg520Filialid { get; set; }
        public string? Gg520KardexId { get; set; }
        public string? Gg520Almoxid { get; set; }      
        public decimal? Gg520NsNumerosaldo { get; set; }
        public string? Gg520Descricaosaldo { get; set; }
        public DateTime? Gg520Ultinventario { get; set; }
        public bool? Gg520ItemEmContagem { get; set; }
        public DateTime? Gg520Ultrecebimento { get; set; }
        public decimal? Gg520Qtdultrecebto { get; set; }
        public DateTime? Gg520UltimaVenda { get; set; }
        public decimal? Gg520QtdeUltVenda { get; set; }
        public string? Gg520DescricaoLote { get; set; }
        public DateTime? Gg520DataValidade { get; set; }
        public decimal? Gg520EstqMinimo { get; set; }
        public decimal? Gg520Estoquemaximo { get; set; }
        public decimal? Gg520Superpromocao { get; set; }
        public string? Gg520Lote { get; set; }
        public decimal? Gg520Saldo { get; set; }
        public string? Gg001AlmoxarifadoCodigo { get; set; }
        public string? Gg001AlmoxarifadoDescricao { get; set; }
       
    }
}
