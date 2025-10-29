using CSCore.Domain.CS_Models.CSICP_NN;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.NN.NN016.Dto
{
    public class DtoCreateUpdateNN016 : IConverteParaEntidade<CSICP_NN016>
    {
        public string Nn016CrcpId { get; set; }
        public string? Nn016Historico { get; set; }
        public string? Nn016Mensagem { get; set; }

        public List<string> ListaTitulosID { get; set; } = [];

        public CSICP_NN016 ToEntity(int tenant, string? _)
        {
            return new CSICP_NN016
            {
                //Nn016Id = id!,
                TenantId = tenant,
                Nn016CrcpId = this.Nn016CrcpId,
                Nn016Historico = this.Nn016Historico,
                Nn016Mensagem  = this.Nn016Mensagem

            };
        }
    }

   
}
