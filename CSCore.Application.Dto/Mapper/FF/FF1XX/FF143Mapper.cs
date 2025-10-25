using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF143;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF143Mapper
    {
        public static DtoGetFF143 ToDtoGetFF143(this CSICP_FF143 entity)
        {
            if (entity == null) return null!;
            return new DtoGetFF143
            {
                TenantId = entity.TenantId,
                Ff143Id = entity.Ff143Id,
                Ff140RdId = entity.Ff140RdId,
                Ff143Objeto = entity.Ff143Objeto,
                Ff143Filetype = entity.Ff143Filetype,
                Ff143Texto = entity.Ff143Texto,
                Filename = entity.Filename,
                Ff143Path = entity.Ff143Path
            };
        }
        
    }
}
