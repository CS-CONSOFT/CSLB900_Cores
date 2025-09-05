namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro
{
    public class Prm_Renegociacao_Cria_Titulo : Prm_Renegociacao_Cria_TituloController
    {
        public int InTenantID { get; set; }
        public string? InFF999ControleID { get; set; }
        public int InStIDFF102EntEntrada { get; set; }
        public int InStIDFF102EntParcela { get; set; }
        public int InStIDFF102SitAberto { get; set; }
        public int InSTIDFF102SitRenegociado { get; set; }
        public int InSTIDFF102SitLiquidado { get; set; }
        public int InSTIDStaticaSim { get; set; }
        public int InSTIDStaticaNao { get; set; }
        public int InSTIDFF102AutPgtoAutorizado { get; set; }
        public int InSTIDFF102AutPgtoNaoAutorizado { get; set; }
        public int InSTIDFf103TpBai { get; set; }
    }

    public class Prm_Renegociacao_Cria_TituloController
    {
        public string? InFF017ID { get; set; }
        public string? InSy001ID { get; set; }
        public string InBB001FilialID { get; set; } = null!;
        public bool InEntLiquidada { get; set; }
    }
}
