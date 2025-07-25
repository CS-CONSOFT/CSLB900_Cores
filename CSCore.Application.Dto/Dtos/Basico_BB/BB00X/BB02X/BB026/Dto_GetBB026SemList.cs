using CSBS101._82Application.Dto.BB00X.BB019;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB026
{
    public class Dto_GetBB026SemList
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public int? Bb026Filial { get; set; }

        public int? Bb026Codigo { get; set; }

        public string? Bb026Formapagamento { get; set; }

        public int? Bb026Dadoschequesn { get; set; }

        public int? Bb026Dadoscartaosn { get; set; }

        public int? Bb026Vinccupomfiscal { get; set; }

        public int? Bb026Classificacao { get; set; }

        public string? Bb026Crplanocontaid { get; set; }

        public string? Bb026Dbplanocontaid2 { get; set; }

        public int? Bb026NroAutenticacoes { get; set; }

        public decimal? Bb026ValorMinimo { get; set; }

        public decimal? Bb026ValorMaximo { get; set; }

        public decimal? Bb026TrocoMaximo { get; set; }

        public decimal? Bb026Pontosangria { get; set; }

        public int? Bb026Tipo { get; set; }

        public bool? Bb026Parcelapordepto { get; set; }

        public string? Bb026Condpagtofixoid { get; set; }

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

        public bool? Bb026Isactive { get; set; }

        public int? Bb026ClasseId { get; set; }

        public string? Bb026EspecieId { get; set; }

        public string? Bb026Meiopagtoimpfiscal { get; set; }

        public int? Bb026Tipoespecie { get; set; }

        public decimal? Bb026Pcomissaovend { get; set; }

        public bool? Bb026Aceitavpresente { get; set; }

        public bool? Bb026Capturarecebpvpdv { get; set; }

        public bool? Bb026Islibentregaliq { get; set; }

        public bool? Bb026Isaplicaaprovcond { get; set; }

        public bool? Bb026Isagrupa { get; set; }

        public Dto_GetBB019? NavBb019Administradora { get; set; }

        public Dto_GetBB008? NavBb008Condpagtofixo { get; set; }

        public CSICP_Bb026Classe? NavBb026Classe { get; set; }
        public CSICP_Bb026Tipo? NavBb026Tipo { get; set; }
        public CSICP_Bb026Vin? NavBb026Vin { get; set; }
        public CSICP_Statica? NavBB026_DadosCartaoSN { get; set; }
        public CSICP_Statica? NavBB026_DadosChequeSN { get; set; }
        public CSICP_Statica? NavBB026_VincCupomFiscal { get; set; }

        //public CSICP_FF003Tpesp? Nav_CSICP_FF003Tpesp { get; set; }
    }

    public class Dto_GetBB026_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb026Codigo { get; set; }

        public string? Bb026Formapagamento { get; set; }


    }

    public class Dto_GetBB026_ComBB026Classe
    {
            public int TenantId { get; set; }

            public string Id { get; set; } = null!;

            public string? Empresaid { get; set; }

            public int? Bb026Filial { get; set; }

            public int? Bb026Codigo { get; set; }

            public string? Bb026Formapagamento { get; set; }

            public int? Bb026Dadoschequesn { get; set; }

            public int? Bb026Dadoscartaosn { get; set; }

            public int? Bb026Vinccupomfiscal { get; set; }

            public int? Bb026Classificacao { get; set; }

            public string? Bb026Crplanocontaid { get; set; }

            public string? Bb026Dbplanocontaid2 { get; set; }

            public int? Bb026NroAutenticacoes { get; set; }

            public decimal? Bb026ValorMinimo { get; set; }

            public decimal? Bb026ValorMaximo { get; set; }

            public decimal? Bb026TrocoMaximo { get; set; }

            public decimal? Bb026Pontosangria { get; set; }

            public int? Bb026Tipo { get; set; }

            public bool? Bb026Parcelapordepto { get; set; }

            public string? Bb026Condpagtofixoid { get; set; }

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

            public bool? Bb026Isactive { get; set; }

            public int? Bb026ClasseId { get; set; }

            public string? Bb026EspecieId { get; set; }

            public string? Bb026Meiopagtoimpfiscal { get; set; }

            public int? Bb026Tipoespecie { get; set; }

            public decimal? Bb026Pcomissaovend { get; set; }

            public bool? Bb026Aceitavpresente { get; set; }

            public bool? Bb026Capturarecebpvpdv { get; set; }

            public bool? Bb026Islibentregaliq { get; set; }

            public bool? Bb026Isaplicaaprovcond { get; set; }

            public bool? Bb026Isagrupa { get; set; }

            public CSICP_Bb026Classe? NavBb026Classe { get; set; }

        }
}
