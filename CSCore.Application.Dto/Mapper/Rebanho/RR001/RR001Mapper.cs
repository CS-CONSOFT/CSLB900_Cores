using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Mapper.Rebanho.RR002;
using CSCore.Application.Dto.Mapper.Rebanho.RR003;
using CSCore.Application.Dto.Mapper.Rebanho.RR004;
using CSCore.Application.Dto.Mapper.Rebanho.RR005;
using CSCore.Application.Dto.Mapper.Rebanho.RR006;
using CSCore.Application.Dto.Mapper.Rebanho.RR007;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR001
{
    public static class RR001Mapper
    {
        public static DtoGetRR001 ToDtoGetRR001(this OsusrTo3CsicpRr001 entity)
        {
            //if (entity == null) return null!;
            return new DtoGetRR001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr001Serie = entity.Rr001Serie,
                Rr001Nrorgn = entity.Rr001Nrorgn,
                Rr001Nomeanimal = entity.Rr001Nomeanimal,
                Rr001Apelido = entity.Rr001Apelido,
                Rr001Dtnascimento = entity.Rr001Dtnascimento,
                Rr001Pesonasc = entity.Rr001Pesonasc,
                Rr001Sexoid = entity.Rr001Sexoid,
                Rr001Fazendaid = entity.Rr001Fazendaid,
                Rr001Catid = entity.Rr001Catid,
                Rr001Racaid = entity.Rr001Racaid,
                Rr001PaiId = entity.Rr001PaiId,
                Rr001MaeId = entity.Rr001MaeId,
                Rr001Ativoid = entity.Rr001Ativoid,
                Rr001Situacaoid = entity.Rr001Situacaoid,
                Rr001Dtregistro = entity.Rr001Dtregistro,
                Rr001Usuariopropid = entity.Rr001Usuariopropid,
                Rr001Observacao = entity.Rr001Observacao,
                Rr001Categoriaid = entity.Rr001Categoriaid,
                Rr001Dtcategoria = entity.Rr001Dtcategoria,
                Rr001Ocorrenciaid = entity.Rr001Ocorrenciaid,
                Rr001Dtocorrencia = entity.Rr001Dtocorrencia,
                Rr001Dtultpeso = entity.Rr001Dtultpeso,
                Rr001Ultpeso = entity.Rr001Ultpeso,
                Rr001Ultidadediaspeso = entity.Rr001Ultidadediaspeso,
                Rr001Proprietarioid = entity.Rr001Proprietarioid,
                Rr001Proprietario2id = entity.Rr001Proprietario2id,
                Rr001Criadorid = entity.Rr001Criadorid,

                NavRR001Pai = entity.NavRR001Pai?.ToDtoGetRR001Padrao(),
                NavRR001Mae = entity.NavRR001Mae?.ToDtoGetRR001Padrao(),
                NavRR001Fazenda = entity.NavRR002Fazenda_RR001?.ToDtoGetRR002Padrao(),
                NavRR001Cat = entity.NavRR003CadastroCat_RR001?.ToDtoGetRR003(),
                NavRR001Raca = entity.NavRR004Raca_RR001?.ToDtoGetRR004(),
                NavRR001Situacao = entity.NavRR005Situacao_RR001?.ToDtoGetRR005(),
                NavRR001Ocorrencia = entity.NavRR006Ocorrencia_RR001?.ToDtoGetRR006(),
                NavRR001Proprietario = entity.NavRR007Proprietario_RR001?.ToDtoGetRR007(),
                NavRR001Ativo = entity.NavRR001Ativo_RR001,
                NavRR001Categoria = entity.NavRR001Categoria_RR001,
                NavRR001Sexo = entity.NavRR001Sexo_RR001,
                NavSy001 = entity.NavSy001_RR001?.ToDtoGetSimples(),
                NavRR007Proprietario2id_RR001 = entity.NavRR007Proprietario2id_RR001,
                NavRR001Criadorid_RR001 = entity.NavRR001Criadorid_RR001
            };
        }

        public static DtoGetRR001Padrao ToDtoGetRR001Padrao(this OsusrTo3CsicpRr001 entity)
        {
            //if (entity == null) return null!;
            return new DtoGetRR001Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr001Serie = entity.Rr001Serie,
                Rr001Nrorgn = entity.Rr001Nrorgn,
                Rr001Nomeanimal = entity.Rr001Nomeanimal,
                Rr001Apelido = entity.Rr001Apelido,
                Rr001Dtnascimento = entity.Rr001Dtnascimento,
                Rr001Pesonasc = entity.Rr001Pesonasc,
                Rr001Sexoid = entity.Rr001Sexoid,
                Rr001Fazendaid = entity.Rr001Fazendaid,
                Rr001Catid = entity.Rr001Catid,
                Rr001Racaid = entity.Rr001Racaid,
                Rr001PaiId = entity.Rr001PaiId,
                Rr001MaeId = entity.Rr001MaeId,
                Rr001Ativoid = entity.Rr001Ativoid,
                Rr001Situacaoid = entity.Rr001Situacaoid,
                Rr001Dtregistro = entity.Rr001Dtregistro,
                Rr001Usuariopropid = entity.Rr001Usuariopropid,
                Rr001Observacao = entity.Rr001Observacao,
                Rr001Categoriaid = entity.Rr001Categoriaid,
                Rr001Dtcategoria = entity.Rr001Dtcategoria,
                Rr001Ocorrenciaid = entity.Rr001Ocorrenciaid,
                Rr001Dtocorrencia = entity.Rr001Dtocorrencia,
                Rr001Dtultpeso = entity.Rr001Dtultpeso,
                Rr001Ultpeso = entity.Rr001Ultpeso,
                Rr001Ultidadediaspeso = entity.Rr001Ultidadediaspeso,
                Rr001Proprietarioid = entity.Rr001Proprietarioid
            };
        }
    }
}
