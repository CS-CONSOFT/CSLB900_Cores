using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG045
{
    public class DtoCreateUpdateGG032 : IConverteParaEntidade<CSICP_GG032>
    {

        public string? Gg032Filialid { get; set; }

        public string? Gg032Usuarioid { get; set; }

        public int? Gg032Filial { get; set; }

        public DateTime? Gg032Datamovimento { get; set; }

        public string? Gg032Observacao { get; set; }

        public string? Gg032Almoxid { get; set; }

        public int? Gg032Codgalmox { get; set; }

        public decimal? Gg032Totalcusto { get; set; }

        public decimal? Gg032Totalcreal { get; set; }

        public decimal? Gg032Totalcmedio { get; set; }

        public decimal? Gg032Totalvenda { get; set; }

        public DateTime? Gg032DataHoraBloqueado { get; set; }

        public DateTime? Gg032DataHoraProcessado { get; set; }

        public int? Gg032QtosPodutos { get; set; }

        public int? Gg032QtosNaoconform { get; set; }

        public int? Gg032QtosNaoinventariado { get; set; }

        public decimal? Gg032QtdRegraNconf { get; set; }

        public int? Gg032TipoinventarioId { get; set; }

        public int? Gg032StatusId { get; set; }

        public string? Gg032Protocolnumber { get; set; }
        public CSICP_GG032 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG032
            {
                TenantId = tenant,
                Id = id!,
                Gg032Filialid = this.Gg032Filialid,
                Gg032Usuarioid = this.Gg032Usuarioid,
                Gg032Filial = this.Gg032Filial,
                Gg032Datamovimento = this.Gg032Datamovimento,
                Gg032Observacao = this.Gg032Observacao,
                Gg032Almoxid = this.Gg032Almoxid,
                Gg032Codgalmox = this.Gg032Codgalmox,
                Gg032Totalcusto = this.Gg032Totalcusto,
                Gg032Totalcreal = this.Gg032Totalcreal,
                Gg032Totalcmedio = this.Gg032Totalcmedio,
                Gg032Totalvenda = this.Gg032Totalvenda,
                Gg032DataHoraBloqueado = this.Gg032DataHoraBloqueado,
                Gg032DataHoraProcessado = this.Gg032DataHoraProcessado,
                Gg032QtosPodutos = this.Gg032QtosPodutos,
                Gg032QtosNaoconform = this.Gg032QtosNaoconform,
                Gg032QtosNaoinventariado = this.Gg032QtosNaoinventariado,
                Gg032QtdRegraNconf = this.Gg032QtdRegraNconf,
                Gg032TipoinventarioId = this.Gg032TipoinventarioId,
                Gg032StatusId = this.Gg032StatusId,
                Gg032Protocolnumber = this.Gg032Protocolnumber,
            };
        }
    }
}
