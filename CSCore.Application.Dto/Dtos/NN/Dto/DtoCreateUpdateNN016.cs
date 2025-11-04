using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Ifs.NN.NN016.Dto
{
    public class DtoCreateUpdateNN016 : IConverteParaEntidade<CSICP_NN016>
    {
        public string Nn016CrcpId { get; set; }

        public List<string> ListaTitulosID { get; set; } = [];

        public CSICP_NN016 ToEntity(int tenant, string? id)
        {
            return new CSICP_NN016
            {
                Nn016Id = id!,
                TenantId = tenant,
                Nn016CrcpId = this.Nn016CrcpId,
                Nn016Historico = string.Empty,
                Nn016Mensagem  = string.Empty
            };
        }
    }

    public class DtoUpdateNN016 
    {
        public decimal? Nn016ValorJuros { get; set; }

        public decimal? Nn016ValorDesconto { get; set; }

        public decimal? Nn016ValorMulta { get; set; }

        public decimal? Nn016ValorTaxa { get; set; }

        public decimal? Nn016ValorPago { get; set; }

    }
}
