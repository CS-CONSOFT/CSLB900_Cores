using CSBS101._82Application.Mapper.AA00X.AA025;
using CSBS101._82Application.Mapper.AA00X.AA027;
using CSBS101._82Application.Mapper.AA00X.AA028;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR002;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR002
{
    public static class RR002Mapper
    {
        public static DtoGetRR002 ToDtoGetRR002(this OsusrTo3CsicpRr002 entity)
        {
            return new DtoGetRR002
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr002Nomefazenda = entity.Rr002Nomefazenda,
                Rr002Cnpj = entity.Rr002Cnpj,
                Rr002Endereco = entity.Rr002Endereco,
                Rr002Nroender = entity.Rr002Nroender,
                Rr002Complemento = entity.Rr002Complemento,
                Rr002Bairro = entity.Rr002Bairro,
                Rr002Cep = entity.Rr002Cep,
                Rr002Paisid = entity.Rr002Paisid,
                Rr002Cidadeid = entity.Rr002Cidadeid,
                Rr002Ufid = entity.Rr002Ufid,
                NavAA025Pais = entity.NavAA025Pais?.ToDtoGet(),
                NavAA027UF = entity.NavAA027UF?.ToDtoGetAA027SASimples(),
                NavAA028Cidade = entity.NavAA028Cidade?.ToDtoGet_Simples()
            };
        }

        public static DtoGetRR002Padrao ToDtoGetRR002Padrao(this OsusrTo3CsicpRr002 entity)
        {
            return new DtoGetRR002Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr002Nomefazenda = entity.Rr002Nomefazenda,
                Rr002Cnpj = entity.Rr002Cnpj,
                Rr002Endereco = entity.Rr002Endereco,
                Rr002Nroender = entity.Rr002Nroender,
                Rr002Complemento = entity.Rr002Complemento,
                Rr002Bairro = entity.Rr002Bairro,
                Rr002Cep = entity.Rr002Cep,
                Rr002Paisid = entity.Rr002Paisid,
                Rr002Cidadeid = entity.Rr002Cidadeid,
                Rr002Ufid = entity.Rr002Ufid
            };
        }
    }
}