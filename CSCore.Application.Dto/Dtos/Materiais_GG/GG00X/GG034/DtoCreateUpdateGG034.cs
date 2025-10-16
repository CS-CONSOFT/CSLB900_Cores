using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG034
{
    public class DtoCreateUpdateGG034 : IConverteParaEntidade<CSICP_GG034>
    {
        public string? Gg034Usuarioid { get; set; }

        public int? Gg034Filial { get; set; }

        public string? Gg034Filialid { get; set; }

        public DateTime? Gg034DataMovimento { get; set; }

        public string? Gg034Observacao { get; set; }

        public string? Gg034NomePromocao { get; set; }

        public DateTime? Gg034Dtinicioprom { get; set; }

        public DateTime? Gg034Dtfimprom { get; set; }

        public int? Gg034Status { get; set; }

        public int? Gg034Tipopromocao { get; set; }

        public string? Gg034Protocolnumber { get; set; }
        public CSICP_GG034 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG034
            {
                TenantId = tenant,
                Id = id!,
                Gg034Usuarioid = this.Gg034Usuarioid,
                Gg034Filial = this.Gg034Filial,
                Gg034Filialid = this.Gg034Filialid,
                Gg034DataMovimento = this.Gg034DataMovimento,
                Gg034Observacao = this.Gg034Observacao,
                Gg034NomePromocao = this.Gg034NomePromocao,
                Gg034Dtinicioprom = this.Gg034Dtinicioprom,
                Gg034Dtfimprom = this.Gg034Dtfimprom,
                Gg034Status = this.Gg034Status,
                Gg034Tipopromocao = this.Gg034Tipopromocao,
                Gg034Protocolnumber = this.Gg034Protocolnumber,
            };
        }
    }
}

