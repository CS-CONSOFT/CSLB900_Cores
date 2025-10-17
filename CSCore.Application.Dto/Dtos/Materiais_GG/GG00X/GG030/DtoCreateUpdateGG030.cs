using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG030
{
    public class DtoCreateUpdateGG030 : IConverteParaEntidade<CSICP_GG030>
    {
        public string? Gg030Usuarioid { get; set; }

        public int? Gg030Filial { get; set; }

        public string? Gg030Filialid { get; set; }

        public string? Gg030DataMovimento { get; set; }

        public string? Gg030Observacao { get; set; }

        public int? Gg030CodgCCusto { get; set; }

        public string? Gg030Ccustoid { get; set; }

        public int? Gg030NoDocto { get; set; }

        public decimal? Gg030Percajuste { get; set; }

        public int? Gg030Responsavel { get; set; }

        public string? Gg030Responsavelid { get; set; }

        public decimal? Gg030TotalMovimento { get; set; }

        public int? Gg030Status { get; set; }

        public int? Gg030PrecoajusteId { get; set; }

        public string? Gg030Protocolnumber { get; set; }

        public CSICP_GG030 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG030
            {
                Id = id!,
                TenantId = tenant,
                Gg030Usuarioid = this.Gg030Usuarioid,
                Gg030Filial = this.Gg030Filial,
                Gg030Filialid = this.Gg030Filialid,
                Gg030DataMovimento = this.Gg030DataMovimento.ConverteStringVaziaParaDataNula(),
                Gg030Observacao = this.Gg030Observacao,
                Gg030CodgCCusto = this.Gg030CodgCCusto,
                Gg030Ccustoid = this.Gg030Ccustoid,
                Gg030NoDocto = this.Gg030NoDocto,
                Gg030Percajuste = this.Gg030Percajuste,
                Gg030Responsavel = this.Gg030Responsavel,
                Gg030Responsavelid = this.Gg030Responsavelid,
                Gg030TotalMovimento = this.Gg030TotalMovimento,
                Gg030Status = this.Gg030Status,
                Gg030PrecoajusteId = this.Gg030PrecoajusteId,
                Gg030Protocolnumber = this.Gg030Protocolnumber,
            };
        }
    }
}
