namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF125
{
    public class DtoGetFF125ContadorCobrancaConsulta
    {
        public int TenantID { get; set; }
        public string NomeTabela { get; set; } = string.Empty;
        public int Contador { get; set; }
    }
}