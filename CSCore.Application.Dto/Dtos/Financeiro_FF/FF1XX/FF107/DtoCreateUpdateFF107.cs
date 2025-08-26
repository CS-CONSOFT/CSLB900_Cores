using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF107
{
    public class DtoCreateUpdateFF107 : IConverteParaEntidade<CSICP_FF107>
    {
        public int? Ff107Tpregistro { get; set; }
        public string? Ff102Tituloid { get; set; }
        public string? Ff107Tipomovto { get; set; }
        public DateTime? Ff107Datamovto { get; set; }
        public string? Ff107Usuarioproprid { get; set; }
        public string? Ff107Motivoid { get; set; }
        public decimal? Ff107Valor { get; set; }
        public string? Ff107Observacao { get; set; }

        public CSICP_FF107 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF107
            {
                TenantId = tenant,
                Id = id!,
                Ff107Tpregistro = Ff107Tpregistro,
                Ff102Tituloid = Ff102Tituloid,
                Ff107Tipomovto = Ff107Tipomovto,
                Ff107Datamovto = Ff107Datamovto ?? DateTime.Now,
                Ff107Usuarioproprid = Ff107Usuarioproprid,
                Ff107Motivoid = Ff107Motivoid,
                Ff107Valor = Ff107Valor,
                Ff107Observacao = Ff107Observacao
            };
        }
    }
}