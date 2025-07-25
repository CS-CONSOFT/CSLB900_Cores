namespace CSBS101.C82Application.Dto.DashBoard
{
    public class Dto_GetDashboardCount
    {
        public string Entidade { get; set; } = string.Empty;
        public int TotalRegistro { get; set; }
        public int NumeroAtivos { get; set; }
        public int NumeroInativos { get; set; }
    }
}
