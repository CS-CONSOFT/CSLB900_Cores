namespace CSSY103.C82Application.Dto.SY001.SY001
{
    public class Dto_GetSy001Img
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? UsuarioId { get; set; }

        public string? Nome { get; set; }

        public string? Tipo { get; set; }
        //[JsonIgnore]
        //public byte[]? Foto { get; set; }

        public bool? Isactive { get; set; }

        public bool? Ispadrao { get; set; }

        public string? Path { get; set; }


    }
}
