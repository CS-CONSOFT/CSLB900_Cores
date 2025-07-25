using System.ComponentModel.DataAnnotations;

namespace CSLB900.MSTools.CS_QueryFilters;

public class ParametrosBaseFiltro
{
    const int maxPageSize = 50;
    /// <summary>
    /// Obrigatorio
    /// </summary>
    [Required]
    public int PageNumber { get; set; } = 1;
    private int _pageSize;

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
