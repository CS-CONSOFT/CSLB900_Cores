using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get.BB012MDFe
{
    public class DtoGet_BB012MDFe
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb012Codigo { get; set; }

        public string? Bb012NomeCliente { get; set; }

        public string? Bb012NomeFantasia { get; set; }

        public DateTime? Bb012DataAniversario { get; set; }

        public DateTime? Bb012DataCadastro { get; set; }

        public string? Bb012Telefone { get; set; } = default;

        public string? Bb012Faxcelular { get; set; }

        public string? Bb012HomePage { get; set; }

        public string? Bb012Email { get; set; }

        public DateTime? Bb012DataEntradaSit { get; set; }

        public DateTime? Bb012DataSaidaSit { get; set; }

        public string? Bb012Descricao { get; set; }

        public bool? Bb012IsActive { get; set; }

        public int? Bb012TipoContaId { get; set; }

        public int? Bb012GrupocontaId { get; set; }

        public int? Bb012ClassecontaId { get; set; }

        public int? Bb012StatuscontaId { get; set; }

        public int? Bb012SitContaId { get; set; }

        public int Bb012ModrelacaoId { get; set; } = -1;

        public long? Bb012Sequence { get; set; }

        public DateTime? Bb012Dultalteracao { get; set; }

        public string? Bb012Estabcadid { get; set; }

        public string? Bb012Keyacess { get; set; }

        public string? Bb012IdIndicador { get; set; }

        public int? Bb012Countappmcon { get; set; }

        public int? Bb012Oricadastroid { get; set; }

        public DtoGet_BB01201MDFe? Nav_BB01201 { get; set; }
        public DtoGet_BB01202MDFe? Nav_BB01202 { get; set; }
    }
}
