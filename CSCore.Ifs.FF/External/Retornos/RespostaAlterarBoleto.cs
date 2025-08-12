using System.Text.Json.Serialization;

namespace CSCore.Ifs.FF.External.Retornos
{
    public class AlterarBoletoBancarioResponse
    {
        [JsonPropertyName("numeroContratoCobranca")]
        public long NumeroContratoCobranca { get; set; }

        [JsonPropertyName("dataAtualizacao")]
        public string? DataAtualizacao { get; set; }

        [JsonPropertyName("horarioAtualizacao")]
        public string? HorarioAtualizacao { get; set; }
    }
}
