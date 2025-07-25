using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X.AA006;

public class Dto_CreateUpdateAA006
{
    public int? Aa006Filial { get; set; }

    [StringLength(10, ErrorMessage = "Aa006Arquivo não pode ter mais de 10 caracteres.")]
    [DefaultValue("")]
    public string? Aa006Arquivo { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Aa006Ci deve ser um valor decimal válido.")]
    public decimal? Aa006Ci { get; set; }

    [StringLength(36, ErrorMessage = "Aa006Filialid não pode ter mais de 36 caracteres.")]
    [DefaultValue(null)]
    public string? Aa006Filialid { get; set; }

    [DataType(DataType.DateTime, ErrorMessage = "Aa006Dataultcaptura deve ser uma data e hora válida.")]
    [DefaultValue(typeof(DateTime), "1900-01-01")]
    public string? Aa006Dataultcaptura { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Aa006Circular deve ser um valor inteiro válido.")]
    public int? Aa006Circular { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Aa006Maxcircular deve ser um valor decimal válido.")]
    public decimal? Aa006Maxcircular { get; set; }
}
