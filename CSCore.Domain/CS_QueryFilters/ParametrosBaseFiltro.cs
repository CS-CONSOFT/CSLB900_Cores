using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CSLB900.MSTools.CS_QueryFilters;

public class ParametrosBaseFiltro
{
    const int maxPageSize = 50;
    [Required]
    public int PageNumber { get; set; } = 1;

    
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

public class ParametrosBaseFiltroSemExcederOMaxPageSize
{
    const int maxPageSize = 50;
    [Required]
    public int PageNumber { get; set; } = 1;
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
            _pageSize = value > maxPageSize ? maxPageSize : value;
        }
    }
}

public record ParametrosBaseFiltroRecord(int PageNumber = 1, int PageSize = 50, bool? DeveExcederOMaxPageSize = false);
