namespace CSCore.Application.Dto.Dtos.Consumidor
{
    public class DtoGetLogoEmpresa
    {
        public string Nome { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;

        public DtoGetLogoEmpresa(string nome, string path)
        {
            Nome = nome;
            Path = path;
        }
    }
}
