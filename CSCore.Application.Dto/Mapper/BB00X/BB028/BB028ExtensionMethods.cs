using CSBS101._82Application.Dto.BB00X.BB028;
using CSBS101._82Application.Dto.BB00X.BB028.BB028B;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB028ExtensionMethods
    {
        public static CSICP_Bb028 ToEntity(this Dto_CreateUpdateBB028 dto)
        {
            var entity = new CSICP_Bb028
            {
                Bb028Codigo = dto.Bb028Codigo,
                Bb028Nomeresponsavel = dto.Bb028Nomeresponsavel,
                Bb028Nomereduzido = dto.Bb028Nomereduzido,
                Bb028Telefone = dto.Bb028Telefone,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB028 ToDtoGet(this CSICP_Bb028 entity)
        {
            return new Dto_GetBB028
            {

                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb028Codigo = entity.Bb028Codigo,
                Bb028Nomeresponsavel = entity.Bb028Nomeresponsavel,
                Bb028Nomereduzido = entity.Bb028Nomereduzido,
                Bb028Telefone = entity.Bb028Telefone,
                Bb028Fax = entity.Bb028Fax,
                Bb028Celular = entity.Bb028Celular,
                Bb028Homepage = entity.Bb028Homepage,
                Bb028Email = entity.Bb028Email,
                Bb028Cnpj = entity.Bb028Cnpj,
                Bb028Inscestadual = entity.Bb028Inscestadual,
                Bb028Inscmunicipal = entity.Bb028Inscmunicipal,
                Bb028Geracpagar = entity.Bb028Geracpagar,
                Bb028Coms1 = entity.Bb028Coms1,
                Bb028Coms2 = entity.Bb028Coms2,
                Bb028Coms3 = entity.Bb028Coms3,
                Bb028Coms4 = entity.Bb028Coms4,
                Bb028Coms5 = entity.Bb028Coms5,
                Bb028Nomebanco = entity.Bb028Nomebanco,
                Bb028Agencia = entity.Bb028Agencia,
                Bb028Conta = entity.Bb028Conta,
                Bb028Observacao = entity.Bb028Observacao,
                Bb028Datanasc = entity.Bb028Datanasc,
                Bb028Isactive = entity.Bb028Isactive,
                Bb028Contafornid = entity.Bb028Contafornid,
                Bb028TipoId = entity.Bb028TipoId,
            };
        }

        public static Dto_GetBB028Completo ToDtoGetCompleto(this CSICP_Bb028 entity)
        {
            return new Dto_GetBB028Completo
            {

                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb028Codigo = entity.Bb028Codigo,
                Bb028Nomeresponsavel = entity.Bb028Nomeresponsavel,
                Bb028Nomereduzido = entity.Bb028Nomereduzido,
                Bb028Telefone = entity.Bb028Telefone,
                Bb028Fax = entity.Bb028Fax,
                Bb028Celular = entity.Bb028Celular,
                Bb028Homepage = entity.Bb028Homepage,
                Bb028Email = entity.Bb028Email,
                Bb028Cnpj = entity.Bb028Cnpj,
                Bb028Inscestadual = entity.Bb028Inscestadual,
                Bb028Inscmunicipal = entity.Bb028Inscmunicipal,
                Bb028Geracpagar = entity.Bb028Geracpagar,
                Bb028Coms1 = entity.Bb028Coms1,
                Bb028Coms2 = entity.Bb028Coms2,
                Bb028Coms3 = entity.Bb028Coms3,
                Bb028Coms4 = entity.Bb028Coms4,
                Bb028Coms5 = entity.Bb028Coms5,
                Bb028Nomebanco = entity.Bb028Nomebanco,
                Bb028Agencia = entity.Bb028Agencia,
                Bb028Conta = entity.Bb028Conta,
                Bb028Observacao = entity.Bb028Observacao,
                Bb028Datanasc = entity.Bb028Datanasc,
                Bb028Isactive = entity.Bb028Isactive,
                Bb028Contafornid = entity.Bb028Contafornid,
                Bb028TipoId = entity.Bb028TipoId,
                NavBB028Tp = entity.NavBB028Tp,
                NavCSICP_BB012 = entity.NavBB012?.ToDtoBB012Simples()
            };
        }

        public static CSICP_Bb028b ToEntity(this Dto_CreateUpdateBB028B dto)
        {
            return new CSICP_Bb028b
            {
                Bb028bFilial = dto.Bb028bFilial,
                Bb028bCodresponsavel = dto.Bb028bCodresponsavel,
                Bb028bCodigocliente = dto.Bb028bCodigocliente,
                Bb028bPerccomissao = dto.Bb028bPerccomissao,
                Bb028bCompradorId = dto.Bb028bCompradorId,
                Bb028bContaid = dto.Bb028bContaid,
            };
        }

        public static Dto_GetBB028B ToDtoGet(this CSICP_Bb028b entity)
        {
            return new Dto_GetBB028B
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb028bFilial = entity.Bb028bFilial,
                Bb028bCodresponsavel = entity.Bb028bCodresponsavel,
                Bb028bCodigocliente = entity.Bb028bCodigocliente,
                Bb028bPerccomissao = entity.Bb028bPerccomissao,
                Bb028bCompradorId = entity.Bb028bCompradorId,
                Bb028bContaid = entity.Bb028bContaid,
                NavCSICP_BB012 = entity.NavBB012?.ToDtoBB012Simples()
            };
        }

    }
}
