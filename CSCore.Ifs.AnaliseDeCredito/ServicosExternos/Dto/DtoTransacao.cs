using System.Text.Json.Serialization;

namespace CSCore.Ifs.AnaliseDeCredito.ServicosExternos.Dto
{
    public class DtoTransacaoRequest
    {
        public string document { get; set; } = "";
        public int criterion { get; set; } = 0;
    }

    public class DtoTransacaoResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("document")]
        public string Document { get; set; } = "";

        [JsonPropertyName("criterion")]
        public int Criterion { get; set; }

        [JsonPropertyName("creationDateUtc")]
        public DateTime CreationDateUtc { get; set; }

        [JsonPropertyName("scores")]
        public List<ScoreItem> Scores { get; set; } = [];
    }

    public class ScoreItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("value")]
        public string Value { get; set; } = "";
    }

}
