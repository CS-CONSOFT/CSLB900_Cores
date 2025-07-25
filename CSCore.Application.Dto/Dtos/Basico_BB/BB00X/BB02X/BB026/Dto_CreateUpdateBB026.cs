using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB026
{
    public class Dto_CreateUpdateBB026
    {
        [StringLength(36, ErrorMessage = "O campo 'Empresaid' deve ter no máximo 36 caracteres.")]
        public string? Empresaid { get; set; }


        public int? Bb026Filial { get; set; }

        public int? Bb026Codigo { get; set; }

        [StringLength(50, ErrorMessage = "O campo 'Bb026Formapagamento' deve ter no máximo 50 caracteres.")]
        public string? Bb026Formapagamento { get; set; }

        public int? Bb026Dadoschequesn { get; set; }

        public int? Bb026Dadoscartaosn { get; set; }

        public int? Bb026Vinccupomfiscal { get; set; }

        public int? Bb026Classificacao { get; set; }

        [StringLength(36, ErrorMessage = "O campo 'Bb026Crplanocontaid' deve ter no máximo 36 caracteres.")]
        public string? Bb026Crplanocontaid { get; set; }

        [StringLength(36, ErrorMessage = "O campo 'Bb026Dbplanocontaid2' deve ter no máximo 36 caracteres.")]
        public string? Bb026Dbplanocontaid2 { get; set; }

        public int? Bb026NroAutenticacoes { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor mínimo deve ser maior ou igual a zero.")]
        public decimal? Bb026ValorMinimo { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor máximo deve ser maior ou igual a zero.")]
        public decimal? Bb026ValorMaximo { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O troco máximo deve ser maior ou igual a zero.")]
        public decimal? Bb026TrocoMaximo { get; set; }

        public decimal? Bb026Pontosangria { get; set; }

        public int? Bb026Tipo { get; set; }

        public bool? Bb026Parcelapordepto { get; set; }

        [StringLength(36, ErrorMessage = "O campo 'Bb026Condpagtofixoid' deve ter no máximo 36 caracteres.")]
        public string? Bb026Condpagtofixoid { get; set; }

        [StringLength(36, ErrorMessage = "O campo 'Bb026Administradoraid' deve ter no máximo 36 caracteres.")]
        public string? Bb026Administradoraid { get; set; }

        public bool? Bb026UtilizaPinpad { get; set; }

        public bool? Bb026Consultacheque { get; set; }

        public bool? Bb026Impressaocheque { get; set; }

        public bool? Bb026Chequebompara { get; set; }

        public bool? Bb026Solicitaemitente { get; set; }

        public bool? Bb026Solicitaqtd { get; set; }

        public bool? Bb026Solicitacondpagto { get; set; }

        public bool? Bb026Aceitapagto { get; set; }

        public bool? Bb026Aceitarecebimento { get; set; }

        public bool? Bb026Permitetroco { get; set; }

        public bool? Bb026Sangriaautomatica { get; set; }

        public bool? Bb026Naoabregaveta { get; set; }

        public int? Bb026TipovinculoId { get; set; }

        public int? Bb026ClasseId { get; set; }

        [StringLength(36, ErrorMessage = "O campo 'Bb026EspecieId' deve ter no máximo 36 caracteres.")]
        public string? Bb026EspecieId { get; set; }

        [StringLength(50, ErrorMessage = "O campo 'Bb026Meiopagtoimpfiscal' deve ter no máximo 50 caracteres.")]
        public string? Bb026Meiopagtoimpfiscal { get; set; }

        public int? Bb026Tipoespecie { get; set; }

        [Range(0, 100, ErrorMessage = "A porcentagem de comissão deve ser entre 0 e 100.")]
        public decimal? Bb026Pcomissaovend { get; set; }

        public bool? Bb026Aceitavpresente { get; set; }

        public bool? Bb026Capturarecebpvpdv { get; set; }

        public bool? Bb026Islibentregaliq { get; set; }

        public bool? Bb026Isaplicaaprovcond { get; set; }

        public bool? Bb026Isagrupa { get; set; }
    }
}
