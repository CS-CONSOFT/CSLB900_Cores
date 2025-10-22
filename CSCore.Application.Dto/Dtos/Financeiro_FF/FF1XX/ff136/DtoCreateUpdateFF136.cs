using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.ff136
{
    public class DtoCreateUpdateFF136 : IConverteParaEntidade<CSICP_FF136>
    {
        public string Ff136RegccredId { get; set; } = null!;

        public string? Ff136FilialId { get; set; }

        public string? Ff136Cdebitoid { get; set; }

        public string? Ff136Protocolnumber { get; set; }

        public string? Ff136UsuariopropId { get; set; }

        public DateTime? Ff136DataMovto { get; set; }

        public DateTime? Ff136DataCredito { get; set; }

        public decimal? Ff136VlrUtilizado { get; set; }

        public string? Ff136Historico { get; set; }

        public string? Ff136UsoInternoWs { get; set; }

        public int? Ff136Tpmovid { get; set; }

        public string? Ff102Id { get; set; }

        public string? Ff103Id { get; set; }

        public int? Ff136Statusid { get; set; }

        public CSICP_FF136 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF136
            {
                TenantId = tenant,
                Ff136RegccredId = id,

        Ff136FilialId = this.Ff136FilialId,

        Ff136Cdebitoid = this.Ff136Cdebitoid,

        Ff136Protocolnumber = this.Ff136Protocolnumber,

        Ff136UsuariopropId = this.Ff136UsuariopropId,

        Ff136DataMovto = this.Ff136DataMovto,

        Ff136DataCredito = this.Ff136DataCredito,

        Ff136VlrUtilizado = this.Ff136VlrUtilizado,

        Ff136Historico = this.Ff136Historico,

        Ff136UsoInternoWs = this.Ff136UsoInternoWs,

        Ff136Tpmovid = this.Ff136Tpmovid,

        Ff102Id = this.Ff102Id,

        Ff103Id = this.Ff103Id,

        Ff136Statusid = this.Ff136Statusid,
    };
        }
    }
}
