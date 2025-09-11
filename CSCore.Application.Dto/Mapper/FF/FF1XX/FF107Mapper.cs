using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF107;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Application.Dto.Mapper.FF.FF00X;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF107Mapper
    {
        public static DtoGetFF107 ToDtoGet(this CSICP_FF107 entity)
        {
            return new DtoGetFF107
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff107Tpregistro = entity.Ff107Tpregistro,
                Ff107Filialid = entity.Ff107Filialid,
                Ff107Filial = entity.Ff107Filial,
                Ff102Tituloid = entity.Ff102Tituloid,
                Ff107Pfx = entity.Ff107Pfx,
                Ff107Titulo = entity.Ff107Titulo,
                Ff107Sfx = entity.Ff107Sfx,
                Ff107Codgcliforn = entity.Ff107Codgcliforn,
                Ff107Tipolctocontabil = entity.Ff107Tipolctocontabil,
                Ff107Tipomovto = entity.Ff107Tipomovto,
                Ff107Datamovto = entity.Ff107Datamovto,
                Ff107Usuarioproprid = entity.Ff107Usuarioproprid,
                Ff107Responsavel = entity.Ff107Responsavel,
                Ff107Motivoid = entity.Ff107Motivoid,
                Ff107Codgmotivo = entity.Ff107Codgmotivo,
                Ff107Descmotivo = entity.Ff107Descmotivo,
                Ff107Valor = entity.Ff107Valor,
                Ff107Observacao = entity.Ff107Observacao,
                Ff107Protocolnumber = entity.Ff107Protocolnumber,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavFF102 = entity.NavFF102?.ToDtoGet_Exibicao(),
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavFF002 = entity.NavFF002?.ToDtoGetSimples()
            };
        }
    }
}