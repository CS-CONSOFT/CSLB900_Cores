using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF116;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF116Mapper
    {
        public static DtoGetFF116 ToDtoGet(this RepoDtoCSICP_FF116 entity)
        {
            return new DtoGetFF116
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff116Tipomovto = entity.Ff116Tipomovto,
                Ff116Filialid = entity.Ff116Filialid,
                Ff116Datamovto = entity.Ff116Datamovto,
                Ff116Usuariopropid = entity.Ff116Usuariopropid,
                Ff102Tituloid = entity.Ff102Tituloid,
                Ff116Datavencto = entity.Ff116Datavencto,
                Ff116Novovencto = entity.Ff116Novovencto,
                Ff116Protocolnumber = entity.Ff116Protocolnumber,
                Ff116Vnovovlr = entity.Ff116Vnovovlr,
                Ff116Vvaloranterior = entity.Ff116Vvaloranterior,
                Ff116Msg = entity.Ff116Msg,
                NavFF116TMov = entity.NavFF116TMov,
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavFF102 = entity.NavFF102?.ToDtoGet_Exibicao(),
            };
        }
    }
}