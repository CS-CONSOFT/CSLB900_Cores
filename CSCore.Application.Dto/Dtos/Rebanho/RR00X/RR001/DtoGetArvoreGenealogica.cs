namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;

/// <summary>
/// Nó da árvore genealógica
/// </summary>
public class DtoNoArvoreGenealogica
{
    public string Id { get; set; } = null!;
    public int Nivel { get; set; } // Negativo = ancestral, Positivo = descendente, 0 = base
    public string? Serie { get; set; }
    public int? Numero { get; set; }
    public string? Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? PaiId { get; set; }
    public string? MaeId { get; set; }
}

/// <summary>
/// Resposta completa da árvore
/// </summary>
public class DtoArvoreGenealogica
{
    public string AnimalBaseId { get; set; } = null!;
    public string? NomeAnimalBase { get; set; }
    public List<DtoNoArvoreGenealogica> Ancestrais { get; set; } = new(); // Níveis negativos
    public DtoNoArvoreGenealogica? AnimalBase { get; set; } // Nível 0
    public List<DtoNoArvoreGenealogica> Descendentes { get; set; } = new(); // Níveis positivos
    public int TotalRegistros => Ancestrais.Count + (AnimalBase != null ? 1 : 0) + Descendentes.Count;
}