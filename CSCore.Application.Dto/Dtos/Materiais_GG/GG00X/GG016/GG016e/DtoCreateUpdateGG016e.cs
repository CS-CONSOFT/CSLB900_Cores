using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016e
{
    public class DtoCreateUpdateGG016e : IConverteParaEntidade<CSICP_GG016e>
    {
        public string? Gg016eDescricao { get; set; }

        public string? Gg016eDregistro { get; set; }

        public string? Gg016eUsuariopropid { get; set; }

        public CSICP_GG016e ToEntity(int tenant, string? _)
        {
            return new CSICP_GG016e
            {
                TenantId = tenant,
                Gg016eDescricao = this.Gg016eDescricao,
                Gg016eDregistro = this.Gg016eDregistro.ConverteStringVaziaParaDataNula(),
                Gg016eUsuariopropid = this.Gg016eUsuariopropid,
            };
        }
    }
}

