using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA042
    {
        [MaxLength(36, ErrorMessage = "O UFID deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Ufid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do produto deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa042Produtoid { get; set; }

        [DefaultValue(null)]
        public int? Aa042CfopId { get; set; }

        [DefaultValue(null)]
        public int? Aa042CstOrigemid { get; set; }

        [DefaultValue(null)]
        public int? Aa042CstId { get; set; }

        [DefaultValue(null)]
        public long? Aa042Coddeclaid { get; set; }
    }
}
