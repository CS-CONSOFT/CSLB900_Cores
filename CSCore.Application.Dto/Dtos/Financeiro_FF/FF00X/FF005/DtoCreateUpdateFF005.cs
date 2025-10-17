using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF005
{
    public class DtoCreateUpdateFF005 : IConverteParaEntidade<CSICP_FF005>
    {
        public string? Ff005Filialid { get; set; }

        public int? Ff005Tipo { get; set; }

        public string? Ff003Especieid { get; set; }

        public decimal? Ff005Sequencia { get; set; }

        public string? Ff005Contafornid { get; set; }

        public int? Ff005Diavencimento { get; set; }

        public string? Ff005Pfx { get; set; }

        public int? Ff005ImpostoId { get; set; }

        public CSICP_FF005 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF005
            {
                TenantId = tenant,
                Id = id!,
                Ff005Filialid = Ff005Filialid,
                Ff005Tipo = Ff005Tipo,
                Ff003Especieid = Ff003Especieid,
                Ff005Sequencia = Ff005Sequencia,
                Ff005Contafornid = Ff005Contafornid,
                Ff005Diavencimento = Ff005Diavencimento,
                Ff005Pfx = Ff005Pfx,
                Ff005ImpostoId = Ff005ImpostoId
            };
        }
    }
}
