using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG045
{
    public class DtoCreateUpdateGG045 : IConverteParaEntidade<CSICP_GG045>
    {
        public string? Gg045EstabelecimentoId { get; set; }

        public string? Gg045Saldoid { get; set; }

        public decimal? Gg045Qtd { get; set; }

        public string? Gg045Protocolnumber { get; set; }

        public DateTime? Gg045Datamovto { get; set; }

        public string? Gg045UsuariopropId { get; set; }

        public string? Gg045Descricao { get; set; }

        public string? Cc040Id { get; set; }

        public int? Gg045Statid { get; set; }

        public string? Cc060Id { get; set; }
        public CSICP_GG045 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG045
            {
                Gg045Id = id!,
                TenantId = tenant,
                Gg045EstabelecimentoId = this.Gg045EstabelecimentoId,
                Gg045Saldoid = this.Gg045Saldoid,
                Gg045Qtd = this.Gg045Qtd,
                Gg045Protocolnumber = this.Gg045Protocolnumber,
                Gg045Datamovto = this.Gg045Datamovto,
                Gg045UsuariopropId = this.Gg045UsuariopropId,
                Gg045Descricao = this.Gg045Descricao,
                Cc040Id = this.Cc040Id,
                Gg045Statid = this.Gg045Statid,
                Cc060Id = this.Cc060Id,
            };
        }
    }
}
