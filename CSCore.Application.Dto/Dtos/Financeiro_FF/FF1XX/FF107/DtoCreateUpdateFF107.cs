using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF107
{
    public class DtoCreateUpdateFF107 : IConverteParaEntidade<CSICP_FF107>
    {
        public int? Ff107Tpregistro { get; set; }

        public string? Ff107Filialid { get; set; }

        public int? Ff107Filial { get; set; }

        public string? Ff102Tituloid { get; set; }

        public string? Ff107Pfx { get; set; }

        public decimal? Ff107Titulo { get; set; }

        public string? Ff107Sfx { get; set; }

        public int? Ff107Codgcliforn { get; set; }

        public string? Ff107Tipolctocontabil { get; set; }

        public string? Ff107Tipomovto { get; set; }

        public DateTime? Ff107Datamovto { get; set; }

        public string? Ff107Usuarioproprid { get; set; }

        public int? Ff107Responsavel { get; set; }

        public string? Ff107Motivoid { get; set; }

        public int? Ff107Codgmotivo { get; set; }

        public string? Ff107Descmotivo { get; set; }

        public decimal? Ff107Valor { get; set; }

        public string? Ff107Observacao { get; set; }

        public string? Ff107Protocolnumber { get; set; }

        public CSICP_FF107 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF107
            {
                TenantId = tenant,
                Id = id!,   
                Ff107Tpregistro = Ff107Tpregistro,
                Ff107Filialid = Ff107Filialid,
                Ff107Filial = Ff107Filial,
                Ff102Tituloid = Ff102Tituloid,
                Ff107Pfx = Ff107Pfx,
                Ff107Titulo = Ff107Titulo,
                Ff107Sfx = Ff107Sfx,
                Ff107Codgcliforn = Ff107Codgcliforn,
                Ff107Tipolctocontabil = Ff107Tipolctocontabil,
                Ff107Tipomovto = Ff107Tipomovto,
                Ff107Datamovto = Ff107Datamovto ?? DateTime.Now,
                Ff107Usuarioproprid = Ff107Usuarioproprid,
                Ff107Responsavel = Ff107Responsavel,
                Ff107Motivoid = Ff107Motivoid,
                Ff107Codgmotivo = Ff107Codgmotivo,
                Ff107Descmotivo = Ff107Descmotivo,
                Ff107Valor = Ff107Valor,
                Ff107Observacao = Ff107Observacao,
                Ff107Protocolnumber = Ff107Protocolnumber
            };
        }
    }
}