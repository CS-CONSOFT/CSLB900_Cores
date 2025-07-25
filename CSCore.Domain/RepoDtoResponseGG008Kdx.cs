using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos
{
    public class RepoDtoResponseGG008Kdx : CSICP_GG008
    {
        public decimal? CS_SaldoTotal { get; set; }
        public string? CS_KardexId { get; set; }
        public CSICP_GG008Kdx? CS_EstabelecimentoLogadoPrecos { get; set; }
        public CSICP_GG008Kdx? CS_GG008Kdx_Completo_SemPrecos { get; set; }
        public IEnumerable<CSICP_GG008Kdx>? CS_NavListaKardex { get; set; } = [];
        public CSICP_GG008c? CS_NavCaracteristica { get; set; }
        public CSICP_GG008c? CS_NavFichaTecnica { get; set; }
        public List<CSICP_GG008c>? CS_NavListImagens { get; set; }

    }
}
