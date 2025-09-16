using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CSLB900.MSTools.CS_QueryFilters;

public class ParametrosBaseFiltro
{
    const int maxPageSize = 50;
    [Required]
    public int PageNumber { get; set; } = 1;
    [JsonIgnore]
    public bool? DeveExcederOMaxPageSize { get; set; } = false;
    private int _pageSize = 50;

    [Required]
    public int PageSize
    {
        get
        {
            return _pageSize;
        }

        set
        {
            _pageSize = value > maxPageSize && DeveExcederOMaxPageSize == false ? maxPageSize : value;
        }
    }
}
