using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB028.BB028B;
using System.Text.Json.Serialization;

namespace CSBS101._82Application.Dto.BB00X.BB028
{
    public class Dto_GetBB028Completo : Dto_GetBB028
    {
        [JsonPropertyOrder(115)]
        public Dto_GetBB012Simples? NavCSICP_BB012 { get; set; }

        [JsonPropertyOrder(120)]
        public List<Dto_GetBB028B> NavListBB028B_ContasClientes { get; set; } = [];
    }
}
