using CSBS101._82Application.Dto.AA00X;
using CSBS101._82Application.Mapper.AA00X.AA025;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA027
{
    public static class AA027ExtensionMethods
    {
        public static Dto_GetAA027 ToDtoGet(this CSICP_Aa027 entity)
        {
            return new Dto_GetAA027
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa027Sigla = entity.Aa027Sigla,
                Descricao = entity.Descricao,
                Aa027Percicmscontrib = entity.Aa027Percicmscontrib,
                Aa027Percicmsentrada = entity.Aa027Percicmsentrada,
                Aa027Percicmsncontrib = entity.Aa027Percicmscontrib,
                Aa027Percsubsttribut = entity.Aa027Percsubsttribut,
                Aa027Mascinsestadual = entity.Aa027Mascinsestadual,
                Aa027Mascieimpressao = entity.Aa027Mascieimpressao,
                Aa027Codigoibge = entity.Aa027Codigoibge,
                Paisid = entity.Paisid,
                Regiaoid = entity.Regiaoid,
                Aa027Naturalidade = entity.Aa027Naturalidade,
                Aa027ExportUfid = entity.Aa027ExportUfid,
                Aa025ExportPaisid = entity.Aa025ExportPaisid,
                Aa026ExportRegiaoid = entity.Aa026ExportRegiaoid,
                Pais = entity.Pais,
                Regiao = entity.Regiao
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa027 ToEntity(this Dto_CreateUpdateAA027 dto)
        {
            var entity = new CSICP_Aa027()
            {
                Aa027Sigla = dto.Aa027Sigla,
                Descricao = dto.Descricao,
                Aa027Percicmscontrib = dto.Aa027Percicmscontrib,
                Aa027Percicmsentrada = dto.Aa027Percicmsentrada,
                Aa027Percicmsncontrib = dto.Aa027Percicmscontrib,
                Aa027Percsubsttribut = dto.Aa027Percsubsttribut,
                Aa027Mascinsestadual = dto.Aa027Mascinsestadual,
                Aa027Mascieimpressao = dto.Aa027Mascieimpressao,
                Aa027Codigoibge = dto.Aa027Codigoibge,
                Paisid = dto.Paisid,
                Regiaoid = dto.Regiaoid,
                Aa027Naturalidade = dto.Aa027Naturalidade,
                Aa027ExportUfid = dto.Aa027ExportUfid,
                Aa025ExportPaisid = dto.Aa025ExportPaisid,
                Aa026ExportRegiaoid = dto.Aa026ExportRegiaoid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static DtoGetAA027_Simples ToDtoGetAA027SASimples(this CSICP_Aa027 entity)
        {
            return new DtoGetAA027_Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa027Sigla = entity.Aa027Sigla,
                Descricao = entity.Descricao,
                Aa027Percicmscontrib = entity.Aa027Percicmscontrib,
                Aa027Percicmsncontrib = entity.Aa027Percicmsncontrib,
                Aa027Percsubsttribut = entity.Aa027Percsubsttribut,
                Aa027Mascinsestadual = entity.Aa027Mascinsestadual,
                Aa027Percicmsentrada = entity.Aa027Percicmsentrada,
                Aa027Mascieimpressao = entity.Aa027Mascieimpressao,
                Aa027Codigoibge = entity.Aa027Codigoibge,
                Paisid = entity.Paisid,
                Regiaoid = entity.Regiaoid,
                Aa027Naturalidade = entity.Aa027Naturalidade,
            };
        }

        public static DtoGet_AA027paraMDFe ToDtoGetAA027paraMDFe(this CSICP_Aa027 entity) //Criada para organizar exposição de retorno com Nav Pais 
        {
            return new DtoGet_AA027paraMDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa027Sigla = entity.Aa027Sigla,
                Descricao = entity.Descricao,
                Aa027Percicmscontrib = entity.Aa027Percicmscontrib,
                Aa027Percicmsentrada = entity.Aa027Percicmsentrada,
                Aa027Percicmsncontrib = entity.Aa027Percicmscontrib,
                Aa027Percsubsttribut = entity.Aa027Percsubsttribut,
                Aa027Mascinsestadual = entity.Aa027Mascinsestadual,
                Aa027Mascieimpressao = entity.Aa027Mascieimpressao,
                Aa027Codigoibge = entity.Aa027Codigoibge,
                Paisid = entity.Paisid,
                Regiaoid = entity.Regiaoid,
                Aa027Naturalidade = entity.Aa027Naturalidade,
                Aa027ExportUfid = entity.Aa027ExportUfid,
                Aa025ExportPaisid = entity.Aa025ExportPaisid,
                Aa026ExportRegiaoid = entity.Aa026ExportRegiaoid,
                NavAA025Pais = entity.Pais?.ToDtoGet(),
            };
        }
    }
}