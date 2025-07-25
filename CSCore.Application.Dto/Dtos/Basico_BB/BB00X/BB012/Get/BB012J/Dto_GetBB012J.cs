using CSCore.Domain;



namespace CSBS101._82Application.Dto.BB00X.BB012.Get.BB012J
{
    public class Dto_GetBB012J
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb012Id { get; set; }

        public string? Bb012jTelefone { get; set; }

        public string? Bb012jFax { get; set; }

        public string? Bb012jEmail { get; set; }

        public int? Bb012jTipoendereco { get; set; }

        public CSICP_Bb012jTpend? NavTipoEndereco { get; set; }
        public Dto_GetBB01206? NavBB1206_Enderecos { get; set; }
    }
}
