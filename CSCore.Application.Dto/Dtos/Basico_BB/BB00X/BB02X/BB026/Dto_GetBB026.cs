using CSBS101._82Application.Dto.BB00X.BB020;
using CSBS101._82Application.Dto.BB00X.BB026;
using System.Text.Json.Serialization;

namespace CSBS101.C82Application.Dto.BB00X.BB00X.BB008
{
    /// <summary>
    /// Ler descricao do Dto_GetBB008SemFatoresList para entender
    /// </summary>
    public class Dto_GetBB026 : Dto_GetBB026SemList
    {
        //[JsonPropertyOrder(150)]
        //public List<Dto_GetBB017> NavListBB017_FatoresAcrescimos { get; set; } = [];
        [JsonPropertyOrder(151)]
        public List<Dto_GetBB020> NavListBB020_FatoresCartaoCredito { get; set; } = [];

    }
}
