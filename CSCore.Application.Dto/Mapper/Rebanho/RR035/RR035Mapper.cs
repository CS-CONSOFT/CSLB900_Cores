using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR035;
using CSCore.Application.Dto.Mapper.Rebanho.RR004;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR035
{
    public static class RR035Mapper
    {
        public static DtoGetRR035 ToDtoGetRR035(this OsusrTo3CsicpRr035 entity)
        {
            return new DtoGetRR035
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr035Descricao = entity.Rr035Descricao,
                Rr035Nrosemem = entity.Rr035Nrosemem,
                Rr035Lote = entity.Rr035Lote,
                Rr035Nomefornecedor = entity.Rr035Nomefornecedor,
                Rr035Identtouro = entity.Rr035Identtouro,
                Rr035Racaid = entity.Rr035Racaid,
                Rr035Nroregtouro = entity.Rr035Nroregtouro,
                Rr035Dtcongelamento = entity.Rr035Dtcongelamento,
                Rr035Volume = entity.Rr035Volume,
                Rr035Concespermatica = entity.Rr035Concespermatica,
                Rr035Observacao = entity.Rr035Observacao,

                // Navegação
                NavRR004Raca = entity.NavRR004Raca_RR035?.ToDtoGetRR004()
            };
        }

        public static DtoGetRR035Padrao ToDtoGetRR035Padrao(this OsusrTo3CsicpRr035 entity)
        {
            return new DtoGetRR035Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr035Descricao = entity.Rr035Descricao,
                Rr035Nrosemem = entity.Rr035Nrosemem,
                Rr035Lote = entity.Rr035Lote,
                Rr035Identtouro = entity.Rr035Identtouro,
                Rr035Racaid = entity.Rr035Racaid,
                Rr035Nroregtouro = entity.Rr035Nroregtouro,
                Rr035Dtcongelamento = entity.Rr035Dtcongelamento,
                Rr035Volume = entity.Rr035Volume,
                Rr035Concespermatica = entity.Rr035Concespermatica,
                Rr035Observacao = entity.Rr035Observacao
            };
        }
    }
}