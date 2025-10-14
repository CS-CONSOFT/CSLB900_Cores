using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG016
{
    public class DtoCreateUpdateGG016 : IConverteParaEntidade<CSICP_GG016>
    {
        public string? Gg016Filialid { get; set; }

        public int? Gg016Filial { get; set; }

        public string? Gg016Grade { get; set; }

        public string? Gg016Descricao { get; set; }

        public int? Gg016Lincolid { get; set; }
        public bool? Gg016Ismarcado { get; set; }

        public CSICP_GG016 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG016
            {
                TenantId = tenant,
                Id = id!,
                Gg016Filialid = this.Gg016Filialid,
                Gg016Filial = this.Gg016Filial,
                Gg016Grade = this.Gg016Grade,
                Gg016Descricao = this.Gg016Descricao,
                Gg016Lincolid = this.Gg016Lincolid,
                Gg016Ismarcado = Gg016Ismarcado
            };
        }
    }
}
