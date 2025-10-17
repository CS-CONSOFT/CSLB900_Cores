using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF140
{
    public class DtoCreateFF140 : IConverteParaEntidade<CSICP_FF140>
    {
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

        public CSICP_FF140 ToEntity(int tenant, string? _)
        {
            return CSICP_FF140.CreateInstance(
                tenant,
                0,
                Ff140Data,
                Ff140Contaid,
                Ff140Especieid,
                Ff140Ccustoid,
                Ff140Usuarioproprieid,
                Ff140Agcobradorid,
                Ff140FpagtoId,
                Ff140Condicaoid,
                Ff140Tipocobrancaid,
                Ff140Descricao,
                Ff140Protocolnumber,
                Ff140Vrequisicao,
                Ff140Projetoid,
                Ff140Statusid,
                Ff140Execucaoid,
                Ff140Tpvinculoid,
                Ff140QtdeParcelas,
                Ff140Estabid,
                Ff140AdtoId
            );
        }
    }
}
