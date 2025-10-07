using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG021;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG021Mapper
    {
        public static DtoGetGG021 ToDtoGet(this CSICP_GG021 entity)
        {
            return new DtoGetGG021
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg021Ncm = entity.Gg021Ncm,
                Gg021ExNcm = entity.Gg021ExNcm,
                Gg021Descricao = entity.Gg021Descricao,
                Gg021Unidade = entity.Gg021Unidade,
                Gg021Unid = entity.Gg021Unid,
                Gg021PercIpi = entity.Gg021PercIpi,
                Gg021PercIcms = entity.Gg021PercIcms,
                Gg021Tipi = entity.Gg021Tipi,
                Gg021ExNbm = entity.Gg021ExNbm,
                Gg021IsActive = entity.Gg021IsActive,
                Gg021NcmGenero = entity.Gg021NcmGenero,
                Gg021Mp255Id = entity.Gg021Mp255Id,
                Gg021GeneroId = entity.Gg021GeneroId,
                Gg021CnaeId = entity.Gg021CnaeId,
                Gg021IsinalanteId = entity.Gg021IsinalanteId,
                Gg021CestId = entity.Gg021CestId,
                Gg021CestN2 = entity.Gg021CestN2,
                Gg021CestN3 = entity.Gg021CestN3,
                Gg021PercCsll = entity.Gg021PercCsll,
                Gg021PercCofins = entity.Gg021PercCofins,
                Gg021PercPis = entity.Gg021PercPis,
                Gg021IcmsPauta = entity.Gg021IcmsPauta,
                Gg021IpiPauta = entity.Gg021IpiPauta,
                Gg021AliquotaIrpj = entity.Gg021AliquotaIrpj,
                Gg021Ierelevanteid = entity.Gg021Ierelevanteid,
                Gg021Dtiniciovigencia = entity.Gg021Dtiniciovigencia,
                Gg021Dtfimvigencia = entity.Gg021Dtfimvigencia,
                NavGg021Cest = entity.NavGg021Cest,
                NavGg007Un = entity.NavGg007Un,
                NavGenero = entity.NavSpedGenero
            };
        }

        public static DtoGetGG021Simples_ComGG021Cest ToDtoGetSimples(this CSICP_GG021 entity)
        {
            return new DtoGetGG021Simples_ComGG021Cest
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg021Ncm = entity.Gg021Ncm,
                Gg021ExNcm = entity.Gg021ExNcm,
                Gg021Descricao = entity.Gg021Descricao,
                Gg021Unidade = entity.Gg021Unidade,
                Gg021Unid = entity.Gg021Unid,
                Gg021PercIpi = entity.Gg021PercIpi,
                Gg021PercIcms = entity.Gg021PercIcms,
                Gg021Tipi = entity.Gg021Tipi,
                Gg021ExNbm = entity.Gg021ExNbm,
                Gg021IsActive = entity.Gg021IsActive,
                Gg021NcmGenero = entity.Gg021NcmGenero,
                Gg021Mp255Id = entity.Gg021Mp255Id,
                Gg021GeneroId = entity.Gg021GeneroId,
                Gg021CnaeId = entity.Gg021CnaeId,
                Gg021IsinalanteId = entity.Gg021IsinalanteId,
                Gg021CestId = entity.Gg021CestId,
                Gg021CestN2 = entity.Gg021CestN2,
                Gg021CestN3 = entity.Gg021CestN3,
                Gg021PercCsll = entity.Gg021PercCsll,
                Gg021PercCofins = entity.Gg021PercCofins,
                Gg021PercPis = entity.Gg021PercPis,
                Gg021IcmsPauta = entity.Gg021IcmsPauta,
                Gg021IpiPauta = entity.Gg021IpiPauta,
                Gg021AliquotaIrpj = entity.Gg021AliquotaIrpj,
                Gg021Ierelevanteid = entity.Gg021Ierelevanteid,
                Gg021Dtiniciovigencia = entity.Gg021Dtiniciovigencia,
                Gg021Dtfimvigencia = entity.Gg021Dtfimvigencia,
                NavGG021Cest = entity.NavGg021Cest
            };
        }
    }
}
