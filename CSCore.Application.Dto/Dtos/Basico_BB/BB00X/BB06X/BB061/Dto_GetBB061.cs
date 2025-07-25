using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Contatos;
using CSBS101._82Application.Dto.BB00X.BB06X.BB060;
using CSCore.Domain;


namespace CSBS101._82Application.Dto.BB00X.BB06X.BB061
{
    public class Dto_GetBB061
    {
        public long Bb061Id { get; set; }

        public long? Bb060Convenioid { get; set; }

        public int? Bb061Tipoassid { get; set; }

        public string? Bb012Contaid { get; set; }

        public string? Bb061Dependenteid { get; set; }

        public decimal? Bb061Valor { get; set; }

        public bool? Bb061Isactive { get; set; }

        public Dto_GetBB060_Exibicao? NavBb060Convenio { get; set; }

        public CSICP_Bb061Tp? NavBb061Tipoass { get; set; }
        public Dto_GetBB012_Exibicao? NavBB012 { get; set; }
        public Dto_GetBB1208? NavBB1208 { get; set; }
    }
}
