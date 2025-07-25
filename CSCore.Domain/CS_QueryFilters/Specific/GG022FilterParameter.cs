using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG022FilterParameter : ParametrosBaseFiltro
    {
            public string? Gg022Ncmid { get; set; } = string.Empty;
            public string? Gg022Ufid { get; set; } = string.Empty;

            public decimal? Gg022Pfcp { get; set; } = decimal.Zero; 
    }
}
