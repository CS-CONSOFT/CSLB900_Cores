using CSCore.Application.Dto;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Ifs.GG.Repository.Extrato
{
    public class ParametroGeraExtrato : ParametrosBaixaSaldo
    {
        public CSICP_GG520 Nav_CSICP_GG520 { get; set; } = null!;
        public long? Origem_PKID { get; set; } = -1;
        public string? Almoxarifado_ID { get; set; } = string.Empty;
        public decimal? SaldoAnterior { get; set; } = decimal.Zero;
        public int GG028_Tmov_EntradaSaida_ID { get; set; } = 0;
        public string Doc_PKID { get; set; } = string.Empty;

    }

    public class ParametroGeraExtrato_2
    {
        public string Doc_PKID { get; set; } = string.Empty;
        public string in_origemID { get; set; } = string.Empty;
        public DateTime Movimento_DataMovimento { get; set; } = default;
        public string GG520_ID { get; set; } = string.Empty;
        public decimal? ValorUnitario { get; set; } = decimal.Zero;
        public string? UsuarioID { get; set; } = string.Empty;
        public decimal QuantidadeASerBaixada { get; set; } = decimal.Zero;
        public decimal QuantidadeAnterior { get; set; } = decimal.Zero;
        public string? Protocolo_Documento { get; set; } = string.Empty;
        public int GG028_Nat_ID { get; set; } = 0;
        public string ProgramaOrigem { get; set; } = string.Empty;
        public CSICP_GG520 Nav_CSICP_GG520 { get; set; } = null!;
        public int GG028_Tmov_EntradaSaida_ID { get; set; } = 0;


    }
}
