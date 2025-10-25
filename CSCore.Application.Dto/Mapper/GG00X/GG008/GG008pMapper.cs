using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008p;

namespace CSCore.Application.Dto.Mapper.GG00X;

    public static class GG008pMapper
    {
        public static DtoGetGG008p ToDtoGet(this CSICP_GG008p entity)
        {
            return new DtoGetGG008p
            {
                TenantId = entity.TenantId,
                Gg008Id = entity.Gg008Id,
                Gg008pPrecoBase = entity.Gg008pPrecoBase,
                Gg008pPercVenda1 = entity.Gg008pPercVenda1,
                Gg008pPrecoVenda1 = entity.Gg008pPrecoVenda1,
                Gg008pPercVenda2 = entity.Gg008pPercVenda2,
                Gg008pPrecoVenda2 = entity.Gg008pPrecoVenda2,
                Gg008pPercVenda3 = entity.Gg008pPercVenda3,
                Gg008pPrecoVenda3 = entity.Gg008pPrecoVenda3,
                Gg008pPercVenda4 = entity.Gg008pPercVenda4,
                Gg008pPrecoVenda4 = entity.Gg008pPrecoVenda4,
                Gg008pPercVenda5 = entity.Gg008pPercVenda5,
                Gg008pPrecoVenda5 = entity.Gg008pPrecoVenda5,
                Gg008pPercVenda6 = entity.Gg008pPercVenda6,
                Gg008pPrecoVenda6 = entity.Gg008pPrecoVenda6,
                Gg008pPercVenda7 = entity.Gg008pPercVenda7,
                Gg008pPrecoVenda7 = entity.Gg008pPrecoVenda7,
                Gg008pPercVenda8 = entity.Gg008pPercVenda8,
                Gg008pPrecoVenda8 = entity.Gg008pPrecoVenda8,
                Gg008pPercVenda9 = entity.Gg008pPercVenda9,
                Gg008pPrecoVenda9 = entity.Gg008pPrecoVenda9,

            };
        }
    }

