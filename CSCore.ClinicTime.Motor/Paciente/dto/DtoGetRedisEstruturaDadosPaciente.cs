namespace CSCore.ClinicTime.Motor.Paciente.dto
{
    public record DtoGetRedisEstruturaDadosPaciente
    {
        public int PacientePcd { get; init; }
        public int PacienteIdoso { get; init; }
        public int PacienteGestante { get; init; }
        public int CheckInApp { get; init; }
        public int CheckInNoLocal { get; init; }
        public double DistanciaClinica_Metros { get; init; }
        public double TempoChegada_Minutos { get; init; }
        public double VelocidadeAtual_KMH { get; init; }
        public DateTime UltimaAtualizacaoLoc { get; init; }
        public decimal PrioridadeEfetiva { get; init; }

        public static DtoGetRedisEstruturaDadosPaciente FromDict(Dictionary<string,string> dicionarioEstruraUsuarios)
        {
            return new DtoGetRedisEstruturaDadosPaciente
            {
                PacientePcd = int.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("PacientePcd", "0")),
                PacienteIdoso = int.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("PacienteIdoso", "0")),
                PacienteGestante = int.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("PacienteGestante", "0")),
                CheckInApp = int.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("CheckInApp", "0")),
                CheckInNoLocal = int.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("CheckInNoLocal", "0")),
                DistanciaClinica_Metros = double.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("DistanciaClinica_Metros", "0")),
                TempoChegada_Minutos = double.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("TempoChegada_Minutos", "0")),
                VelocidadeAtual_KMH = double.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("VelocidadeAtual_KMH", "0")),
                UltimaAtualizacaoLoc = DateTime.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("UltimaAtualizacaoLoc", DateTime.MinValue.ToString())),
                PrioridadeEfetiva = decimal.Parse(dicionarioEstruraUsuarios.GetValueOrDefault("PrioridadeEfetiva", "0"))
            };
        }

        public Dictionary<string,string> ToDict()
        {
            return new Dictionary<string, string>
            {
                { "PacientePcd", PacientePcd.ToString() },
                { "PacienteIdoso", PacienteIdoso.ToString() },
                { "PacienteGestante", PacienteGestante.ToString() },
                { "CheckInApp", CheckInApp.ToString() },
                { "CheckInNoLocal", CheckInNoLocal.ToString() },
                { "DistanciaClinica_Metros", DistanciaClinica_Metros.ToString() },
                { "TempoChegada_Minutos", TempoChegada_Minutos.ToString() },
                { "VelocidadeAtual_KMH", VelocidadeAtual_KMH.ToString() },
                { "UltimaAtualizacaoLoc", UltimaAtualizacaoLoc.ToString("o") }, // ISO 8601 format
                { "PrioridadeEfetiva", PrioridadeEfetiva.ToString() }
            };
        }
    }
}