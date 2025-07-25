using CSBS101._82Application.Dto.AA00X;
using CSBS101._82Application.Mapper.AA00X.AA027;
using CSBS101._82Application.Mapper.AA00X.AA041;
using CSBS101._82Application.Mapper.AA00X.AA042;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.AA00X.AA042
{
    public static class AA042ExtensionMethods
    {
        public static Dto_GetAA042 ToDtoGet(this CSICP_Aa042 entity)
        {
            return new Dto_GetAA042
            {
                TenantId = entity.TenantId,
                Aa042Id = entity.Aa042Id,
                Ufid = entity.Ufid,
                Aa042Produtoid = entity.Aa042Produtoid,
                Aa042CfopId = entity.Aa042CfopId,
                Aa042CstOrigemid = entity.Aa042CstOrigemid,
                NavAa042Cst = entity.Aa042Cst,
                Aa042CstId = entity.Aa042CstId,
                Aa042Coddeclaid = entity.Aa042Coddeclaid,
                NavAa042Cfop = entity.Aa042Cfop,
                NavAa042Coddecla = entity.Aa042Coddecla?.ToDtoGet(),
                NavAa042CstOrigem = entity.Aa042CstOrigem,
                NavUf = entity.Uf?.ToDtoGet()
            };
        }


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_Aa042 ToEntity(this Dto_CreateUpdateAA042 dto)
        {
            var entity = new CSICP_Aa042
            {
                Ufid = dto.Ufid,
                Aa042Produtoid = dto.Aa042Produtoid,
                Aa042CfopId = dto.Aa042CfopId,
                Aa042CstOrigemid = dto.Aa042CstOrigemid,
                Aa042CstId = dto.Aa042CstId,
                Aa042Coddeclaid = dto.Aa042Coddeclaid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}
