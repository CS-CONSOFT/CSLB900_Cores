using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022;
using CSCore.Application.Dto.Mapper.Rebanho.RR001;
using CSCore.Application.Dto.Mapper.Rebanho.RR010;
using CSCore.Application.Dto.Mapper.Rebanho.RR021;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR022
{
    public static class RR022Mapper
    {
        public static DtoGetRR022 ToDtoGetRR022(this OsusrTo3CsicpRr022 entity)
        {
            return new DtoGetRR022
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr022Loteid = entity.Rr022Loteid,
                Rr022Animalid = entity.Rr022Animalid,
                Rr022Dtpeso = entity.Rr022Dtpeso,
                Rr022Idadediasatual = entity.Rr022Idadediasatual,
                Rr022Peso = entity.Rr022Peso,
                Rr001Dtultpeso = entity.Rr001Dtultpeso,
                Rr001Ultpeso = entity.Rr001Ultpeso,
                Rr022Idadediasult = entity.Rr022Idadediasult,
                Rr022Gmd = entity.Rr022Gmd,
                Rr022Gpd = entity.Rr022Gpd,
                Rr022Dthrregistro = entity.Rr022Dthrregistro,
                Rr022Usuarioid = entity.Rr022Usuarioid,
                Rr022IsProcessado = entity.Rr022IsProcessado,
                Rr022Observacao = entity.Rr022Observacao,
                Rr022Circexcrotal = entity.Rr022Circexcrotal,
                Rr022Condcriacaid = entity.Rr022Condcriacaid,

                // Navegações
                NavRR001Animal = entity.NavRR001Animal_RR022?.ToDtoGetRR001Padrao(),
                NavRR021LoteXAnimal = entity.NavRR021LoteXAnimal_RR022?.ToDtoGetRR021Padrao(),
                NavUltimos5Registros = entity.NavUltimos5Registros?
                    .Select(x => x.ToDtoGetRR022Historico())
                    .ToList(),
                NavRR010CondCriacao_RR022 = entity.NavRR010CondCriacao_RR022?.ToDtoGetRR010()
            };
        }

        public static DtoGetRR022Padrao ToDtoGetRR022Padrao(this OsusrTo3CsicpRr022 entity)
        {
            return new DtoGetRR022Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr022Loteid = entity.Rr022Loteid,
                Rr022Animalid = entity.Rr022Animalid,
                Rr022Dtpeso = entity.Rr022Dtpeso,
                Rr022Idadediasatual = entity.Rr022Idadediasatual,
                Rr022Peso = entity.Rr022Peso,
                Rr001Dtultpeso = entity.Rr001Dtultpeso,
                Rr001Ultpeso = entity.Rr001Ultpeso,
                Rr022Idadediasult = entity.Rr022Idadediasult,
                Rr022Gmd = entity.Rr022Gmd,
                Rr022Gpd = entity.Rr022Gpd,
                Rr022Dthrregistro = entity.Rr022Dthrregistro,
                Rr022Usuarioid = entity.Rr022Usuarioid,
                Rr022IsProcessado = entity.Rr022IsProcessado,
                Rr022Observacao = entity.Rr022Observacao,
                Rr022Circexcrotal = entity.Rr022Circexcrotal,
                Rr022Condcriacaid = entity.Rr022Condcriacaid
            };
        }

        public static DtoGetRR022Historico ToDtoGetRR022Historico(this OsusrTo3CsicpRr022 entity)
        {
            return new DtoGetRR022Historico
            {
                Rr022Animalid = entity.Rr022Animalid,
                Rr022Dtpeso = entity.Rr022Dtpeso,
                Rr022Idadediasatual = entity.Rr022Idadediasatual,
                Rr022Peso = entity.Rr022Peso,
                Rr022Gmd = entity.Rr022Gmd,
                Rr022Gpd = entity.Rr022Gpd,
                
            };
        }
    }
}