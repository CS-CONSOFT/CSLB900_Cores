using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto
{
    public class Rbt_CS_BaixaMvto_EntSaida
    {
        public int Tenant_ID { get; set; }
        public CSICP_GG073 GG073Corrente { get; set; } = null!;
        public List<CSICP_GG074> ListaGG074 { get; set; } = [];
        public ParametrosBaixaSaldo ParametrosBaixaSaldo { get; set; } = null!;
    }
    public class ParametrosBaixaSaldo
    {
        public CSICP_GG074 NavCurrentGG074 { get; set; } = null!;
        public CSICP_GG073 GG073Corrente { get; set; } = null!;
        public string GG073_ID { get; set; } = string.Empty;
        public string? BB001_ID { get; set; } = string.Empty;
        public string GG520_ID { get; set; } = string.Empty;
        public decimal QuantidadeASerBaixada { get; set; } = decimal.Zero;

        /// <summary>
        /// Identifica o ID do movimento origem para ser utilizado na geração do extrato do produto
        /// </summary>
        public string Detalhe_Movimento_ID { get; set; } = null!;

        public string Header_Movimento_ID { get; set; } = string.Empty;

        public DateTime Movimento_DataMovimento { get; set; } = default;

        public decimal? ValorUnitario { get; set; } = decimal.Zero;

        /// <summary>
        /// Identifica o ID do usuario SY001
        /// </summary>
        public string? UsuarioID { get; set; } = string.Empty;

        /// <summary>
        /// Identifica o ID da conta BB012
        /// </summary>
        public string? ContaID { get; set; } = string.Empty;

        public string? TransacaoID { get; set; } = string.Empty;

        /// <summary>
        /// identifica o nome do programa origem - utilizar o nome da tabela
        /// </summary>
        public string ProgramaOrigem { get; set; } = string.Empty;

        public decimal ProtocoloGG028 { get; set; } = decimal.Zero;

        public int? NumeroPDV { get; set; } = 0;
        public string? Protocolo_Documento { get; set; } = string.Empty;
        public decimal? NF_ou_CUPOM { get; set; } = decimal.Zero;
        public int StID_GG028_Nat_ID { get; set; } = 0;
        public int StID_GG028_EntSaida_Entrada_ID { get; set; } = 0;
        public int StID_GG028_EntSaida_Saida_ID { get; set; } = 0;
        public int StID_GG073_EntSaida_Saida_ID { get; set; } = 0;
        public int StID_IdGG072StqAberto { get; set; } = 0;
        public int StID_IdGG072StqErro { get; set; } = 0;
        public int StID_IdGG072StqInvetario { get; set; } = 0;
        public int StID_IdGG072StqSemSaldo { get; set; } = 0;
        public int StID_IdGG073Status_Fechado { get; set; } = 0;
        public int StID_IdGG073Status_Aberto { get; set; } = 0;
        public int StID_IdGG073Status_Erro { get; set; } = 0;
        public int StID_Estatica_SIM_Id { get; set; } = 0;

    }
}
