
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X;

public class Dto_CreateUpdateAA012
{
    [MaxLength(3, ErrorMessage = "A tabela deve ter no máximo 3 caracteres.")]
    [DefaultValue("")]
    public string? Aa012Tabela { get; set; }

    [MaxLength(6, ErrorMessage = "O código deve ter no máximo 6 caracteres.")]
    [DefaultValue("")]
    public string Aa012Codigo { get; set; } = string.Empty;

    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres.")]
    [DefaultValue("")]
    public string? Aa012Descricao { get; set; }

    [MaxLength(500, ErrorMessage = "A descrição grande deve ter no máximo 500 caracteres.")]
    [DefaultValue("")]
    public string? Aa012DescricaoGrande { get; set; }
}
