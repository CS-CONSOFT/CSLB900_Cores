using CSBS101._82Application.Dto.AA00X;
using CSBS101._82Application.Mapper.AA00X.AA027;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA028;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA028
{
    public static class AA028ExtensionMethods
    {
        public static Dto_GetAA028 ToDtoGet(this CSICP_Aa028 entity)
        {
            return new Dto_GetAA028
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa028Cidade = entity.Aa028Cidade,
                A028Percicmsentrada = entity.A028Percicmsentrada,
                A028Percicmsncontrib = entity.A028Percicmsncontrib,
                Aa028Percicmscontrib = entity.Aa028Percicmscontrib,
                A028Percsubsttribut = entity.A028Percsubsttribut,
                A028Mascinsestadual = entity.A028Mascinsestadual,
                A028Mascieimpressao = entity.A028Mascieimpressao,
                Aa028Codgibge = entity.Aa028Codgibge,
                Aa028Zonafranca = entity.Aa028Zonafranca,
                Aa028Estadobrasil = entity.Aa028Estadobrasil,
                Ufid = entity.Ufid,
                Aa028ExportCidadeid = entity.Aa028ExportCidadeid,
                Aa027ExportUfid = entity.Aa027ExportUfid,
                NavZonaFranca = entity.NavZonaFranca,
                NavUFBrasil = entity.NavUFBrasil,
                NavUf = entity.NavUf,
            };
        }

        public static Dto_GetAA028_Exibicao ToDtoGetSimples(this CSICP_Aa028 entity)
        {
            return new Dto_GetAA028_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa028Cidade = entity.Aa028Cidade,
                Aa028Codgibge = entity.Aa028Codgibge
            };
        }


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_Aa028 ToEntity(this Dto_CreateUpdateAA028 dto)
        {
            var entity = new CSICP_Aa028()
            {
                Aa028Cidade = dto.Aa028Cidade,
                A028Percicmsentrada = dto.A028Percicmsentrada,
                A028Percicmsncontrib = dto.A028Percicmsncontrib,
                Aa028Percicmscontrib = dto.Aa028Percicmscontrib,
                A028Percsubsttribut = dto.A028Percsubsttribut,
                A028Mascinsestadual = dto.A028Mascinsestadual,
                A028Mascieimpressao = dto.A028Mascieimpressao,
                Aa028Codgibge = dto.Aa028Codgibge,
                Aa028Zonafranca = dto.Aa028Zonafranca,
                Aa028Estadobrasil = dto.Aa028Estadobrasil,
                Ufid = dto.Ufid,
                Aa028ExportCidadeid = dto.Aa028ExportCidadeid,
                Aa027ExportUfid = dto.Aa027ExportUfid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static DtoGet_AA028paraMDFe ToDtoGetAA028paraMDFe(this CSICP_Aa028 entity) //criado para organizar exposição e evitar problemas com o mapeamento automatico do entity para o dto
        {
            return new DtoGet_AA028paraMDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa028Cidade = entity.Aa028Cidade,
                A028Percicmsentrada = entity.A028Percicmsentrada,
                A028Percicmsncontrib = entity.A028Percicmsncontrib,
                Aa028Percicmscontrib = entity.Aa028Percicmscontrib,
                A028Percsubsttribut = entity.A028Percsubsttribut,
                A028Mascinsestadual = entity.A028Mascinsestadual,
                A028Mascieimpressao = entity.A028Mascieimpressao,
                Aa028Codgibge = entity.Aa028Codgibge,
                Aa028Zonafranca = entity.Aa028Zonafranca,
                Aa028Estadobrasil = entity.Aa028Estadobrasil,
                Ufid = entity.Ufid,
                Aa028ExportCidadeid = entity.Aa028ExportCidadeid,
                Aa027ExportUfid = entity.Aa027ExportUfid,
                NavAA027Uf = entity.NavUf?.ToDtoGetAA027paraMDFe(),
            };
        }

        public static DtoGetAA028_Simples ToDtoGet_Simples(this CSICP_Aa028 entity)
        {
            return new DtoGetAA028_Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa028Cidade = entity.Aa028Cidade,
                A028Percicmsentrada = entity.A028Percicmsentrada,
                A028Percicmsncontrib = entity.A028Percicmsncontrib,
                Aa028Percicmscontrib = entity.Aa028Percicmscontrib,
                A028Percsubsttribut = entity.A028Percsubsttribut,
                A028Mascinsestadual = entity.A028Mascinsestadual,
                A028Mascieimpressao = entity.A028Mascieimpressao,
                Aa028Codgibge = entity.Aa028Codgibge,
                Aa028Zonafranca = entity.Aa028Zonafranca,
                Aa028Estadobrasil = entity.Aa028Estadobrasil,
                Ufid = entity.Ufid,
                Aa028ExportCidadeid = entity.Aa028ExportCidadeid,
                Aa027ExportUfid = entity.Aa027ExportUfid,
            };
        }
    }
}
