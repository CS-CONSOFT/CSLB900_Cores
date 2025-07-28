using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;
using CSSY103.C82Application.Dto.SY001.SY001;

namespace CSCore.Application.Dto.Mapper.Sistema
{
    public static class SY001ExtensionMethods
    {
        public static Csicp_Sy001 ToEntity(this Dto_CreateUpdateSY001 dto)
        {
            return new Csicp_Sy001
            {
                Sy001Usuario = dto.Sy001Usuario,
                Sy001Nome = dto.Sy001Nome,
                Sy001Bloqueado = dto.Sy001Bloqueado,
                Sy001DataValidade = dto.Sy001DataValidade.ConverteStringVaziaParaDataNula(),
                Sy001Autalterarsenha = dto.Sy001Autalterarsenha,
                Sy001Altsenhapxlogin = dto.Sy001Altsenhapxlogin,
                Sy001ExpiraSenha = dto.Sy001ExpiraSenha,
                Sy001Senhexpaposndias = dto.Sy001Senhexpaposndias,
                Sy001Dtexpiracaologin = dto.Sy001Dtexpiracaologin.ConverteStringVaziaParaDataNula(),
                Sy001Deptolotado = dto.Sy001Deptolotado,
                Sy001Cargo = dto.Sy001Cargo,
                Sy001Email = dto.Sy001Email,
                Sy001Imagem = dto.Sy001Imagem,
                Sy001Dataultimoacesso = dto.Sy001Dataultimoacesso.ConverteStringVaziaParaDataNula(),
                //Userid = dto.Userid,
                Sy001IdiomaId = dto.Sy001IdiomaId,
                Sy001Senhacs = dto.Sy001Senhacs,
                Sy001Celular = dto.Sy001Celular
            };
        }

        public static Dto_GetSy001 ToDtoGetSy001(this Csicp_Sy001 entity)
        {
            return new Dto_GetSy001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy001Usuario = entity.Sy001Usuario,
                Sy001Nome = entity.Sy001Nome,
                Sy001Senha = entity.Sy001Senha,
                Sy001Bloqueado = entity.Sy001Bloqueado,
                Sy001DataValidade = entity.Sy001DataValidade,
                Sy001Autalterarsenha = entity.Sy001Autalterarsenha,
                Sy001Altsenhapxlogin = entity.Sy001Altsenhapxlogin,
                Sy001ExpiraSenha = entity.Sy001ExpiraSenha,
                Sy001Senhexpaposndias = entity.Sy001Senhexpaposndias,
                Sy001Dtexpiracaologin = entity.Sy001Dtexpiracaologin,
                Sy001Deptolotado = entity.Sy001Deptolotado,
                Sy001Cargo = entity.Sy001Cargo,
                Sy001Email = entity.Sy001Email,
                Sy001Imagem = entity.Sy001Imagem,
                Sy001Dataultimoacesso = entity.Sy001Dataultimoacesso,
                Userid = entity.Userid,
                Sy001IdiomaId = entity.Sy001IdiomaId,
                Sy001Senhacs = entity.Sy001Senhacs,
                Sy001Celular = entity.Sy001Celular,
                NavSY001_AlterarSenha = entity.NavSY001_AlterarSenha,
                NavSy001Altsenhapxlogin = entity.NavSy001Altsenhapxlogin,
                NavSy001ExpiraSenha = entity.NavSy001ExpiraSenha,
                NavSy001IdiomaId = entity.NavSy001IdiomaId,
                NavListImagens = entity.OsusrE9aCsicpSy001Imgs.ToList(),
            };
        }



        public static Dto_GetSY001Simples ToDtoGetSimples(this Csicp_Sy001 entity)
        {
            return new Dto_GetSY001Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy001Usuario = entity.Sy001Usuario,
                Sy001Nome = entity.Sy001Nome
            };
        }
    }
}

