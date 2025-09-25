using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF140
{
    public record DtoGetFF140Simples(
        int TenantId,
        string Ff140Id,
        DateTime? Ff140Data,
        string? Ff140Contaid,
        string? Ff140Especieid,
        string? Ff140Ccustoid,
        string? Ff140Usuarioproprieid,
        string? Ff140Agcobradorid,
        string? Ff140FpagtoId,
        string? Ff140Condicaoid,
        string? Ff140Tipocobrancaid,
        string? Ff140Descricao,
        string? Ff140Protocolnumber,
        decimal? Ff140Vrequisicao,
        string? Ff140Projetoid,
        int? Ff140Statusid,
        int? Ff140Execucaoid,
        int? Ff140Tpvinculoid,
        int? Ff140QtdeParcelas,
        string? Ff140Estabid,
        int? Ff140AdtoId
    );

    public class DtoGetCSICP_FF140
    {
        public DtoGetCSICP_FF140(CSICP_FF140 entity)
        {
            TenantId = entity.TenantId;
            Ff140Id = entity.Ff140Id;
            Ff140Data = entity.Ff140Data;
            Ff140Contaid = entity.Ff140Contaid;
            Ff140Especieid = entity.Ff140Especieid;
            Ff140Ccustoid = entity.Ff140Ccustoid;
            Ff140Usuarioproprieid = entity.Ff140Usuarioproprieid;
            Ff140Agcobradorid = entity.Ff140Agcobradorid;
            Ff140FpagtoId = entity.Ff140FpagtoId;
            Ff140Condicaoid = entity.Ff140Condicaoid;
            Ff140Tipocobrancaid = entity.Ff140Tipocobrancaid;
            Ff140Descricao = entity.Ff140Descricao;
            Ff140Protocolnumber = entity.Ff140Protocolnumber;
            Ff140Vrequisicao = entity.Ff140Vrequisicao;
            Ff140Projetoid = entity.Ff140Projetoid;
            Ff140Statusid = entity.Ff140Statusid;
            Ff140Execucaoid = entity.Ff140Execucaoid;
            Ff140Tpvinculoid = entity.Ff140Tpvinculoid;
            Ff140QtdeParcelas = entity.Ff140QtdeParcelas;
            Ff140Estabid = entity.Ff140Estabid;
            Ff140AdtoId = entity.Ff140AdtoId;
        }

        public int TenantId { get; set; }

        public long Ff140Id { get; set; }

        public DateTime? Ff140Data { get; set; }

        public string? Ff140Contaid { get; set; }

        public string? Ff140Especieid { get; set; }

        public string? Ff140Ccustoid { get; set; }

        public string? Ff140Usuarioproprieid { get; set; }

        public string? Ff140Agcobradorid { get; set; }

        public string? Ff140FpagtoId { get; set; }

        public string? Ff140Condicaoid { get; set; }

        public string? Ff140Tipocobrancaid { get; set; }

        public string? Ff140Descricao { get; set; }

        public string? Ff140Protocolnumber { get; set; }

        public decimal? Ff140Vrequisicao { get; set; }

        public string? Ff140Projetoid { get; set; }

        public int? Ff140Statusid { get; set; }

        public int? Ff140Execucaoid { get; set; }

        public int? Ff140Tpvinculoid { get; set; }

        public int? Ff140QtdeParcelas { get; set; }

        public string? Ff140Estabid { get; set; }

        public int? Ff140AdtoId { get; set; }
    }
}
