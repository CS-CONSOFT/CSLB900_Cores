namespace CSCore.Application.Dto.Dtos.CG.CG020
{
    public class DtoAbrirFecharLoteCG020
    {
        public string Cg020Id { get; set; } = null!;
        public string StatusLoteAtual { get; set; } = null!;
        public DtoGetCG020 RegistroAtualizado { get; set; } = null!;
    }
}