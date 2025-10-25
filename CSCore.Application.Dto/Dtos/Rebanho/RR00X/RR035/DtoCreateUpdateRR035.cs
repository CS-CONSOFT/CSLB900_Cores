using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR035
{
    public class DtoCreateUpdateRR035 : IConverteParaEntidade<OsusrTo3CsicpRr035>
    {
        public string? Rr035Descricao { get; set; }

        public string? Rr035Nrosemem { get; set; }

        public string? Rr035Lote { get; set; }

        public string? Rr035Nomefornecedor { get; set; }

        public string? Rr035Identtouro { get; set; }

        public long? Rr035Racaid { get; set; }

        public string? Rr035Nroregtouro { get; set; }

        public DateTime? Rr035Dtcongelamento { get; set; }

        public string? Rr035Volume { get; set; }

        public string? Rr035Concespermatica { get; set; }

        public string? Rr035Observacao { get; set; }

        public OsusrTo3CsicpRr035 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr035
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr035Descricao = Rr035Descricao,
                Rr035Nrosemem = Rr035Nrosemem,
                Rr035Lote = Rr035Lote,
                Rr035Nomefornecedor = Rr035Nomefornecedor,
                Rr035Identtouro = Rr035Identtouro,
                Rr035Racaid = Rr035Racaid,
                Rr035Nroregtouro = Rr035Nroregtouro,
                Rr035Dtcongelamento = Rr035Dtcongelamento,
                Rr035Volume = Rr035Volume,
                Rr035Concespermatica = Rr035Concespermatica,
                Rr035Observacao = Rr035Observacao
            };
        }
    }
}