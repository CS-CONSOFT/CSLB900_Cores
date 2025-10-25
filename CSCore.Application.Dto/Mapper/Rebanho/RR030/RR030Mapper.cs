using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR030;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR030
{
    public static class RR030Mapper
    {
        public static DtoGetRR030 ToDtoGetRR030(this OsusrTo3CsicpRr030 entity)
        {
            return new DtoGetRR030
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr030Descricao = entity.Rr030Descricao,
                Rr030IaData = entity.Rr030IaData,
                Rr030IaNrodias = entity.Rr030IaNrodias,
                Rr030IaDatadg = entity.Rr030IaDatadg,
                Rr030Datamontainicial = entity.Rr030Datamontainicial,
                Rr030Montainicialdias = entity.Rr030Montainicialdias,
                Rr030Datamontafinal = entity.Rr030Datamontafinal,
                Rr030Montafinaldias = entity.Rr030Montafinaldias,
                Rr030Dataprovontainicial = entity.Rr030Dataprovontainicial,
                Rr030Dataprovontafinal = entity.Rr030Dataprovontafinal
            };
        }
    }
}