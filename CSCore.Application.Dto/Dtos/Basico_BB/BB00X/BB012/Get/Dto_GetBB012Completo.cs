using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012C;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012J;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012M;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012Q;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB1209;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB1210;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Contatos;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Membros;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Notas;
using CSBS101._82Application.Dto.BB00X.BB012.Get.RetencaoImpostos;
using System.Text.Json.Serialization;

namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB012Completo : Dto_GetBB012
    {
        [JsonPropertyOrder(100)] // Ordem elevada para aparecer por último
        public List<Dto_GetBB012J> NavOutrosEnderecosList { get; set; } = [];

        [JsonPropertyOrder(101)]
        public List<Dto_GetBB01203> NavNotasList { get; set; } = [];

        [JsonPropertyOrder(102)]
        public List<Dto_GetBB012o> NavRetencaoImpostosList { get; set; } = [];


        [JsonPropertyOrder(103)]
        public List<Dto_GetBB1208> NavContatosList { get; set; } = [];

        [JsonPropertyOrder(104)]
        public Dto_GetBB1207MembrosCompleto? NavMembrosCompleto { get; set; } = null;

        [JsonPropertyOrder(105)]
        public List<Dto_GetBB012C> NavBensList { get; set; } = [];

        [JsonPropertyOrder(106)]
        public List<Dto_GetBB012Q> NavDadosBancariosList { get; set; } = [];

        [JsonPropertyOrder(107)]
        public List<Dto_GetBB012M> NavGEDList { get; set; } = [];

        [JsonPropertyOrder(108)]
        public List<Dto_GetBB1210> NavAnaliseCreditoList { get; set; } = [];

        [JsonPropertyOrder(109)]
        public List<Dto_GetBB1209> NavMeuCrediarioList { get; set; } = [];
    }

}
