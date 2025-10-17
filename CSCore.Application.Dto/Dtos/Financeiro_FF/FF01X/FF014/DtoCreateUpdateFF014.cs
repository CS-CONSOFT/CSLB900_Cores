using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF014
{
    public class DtoCreateUpdateFF014 : IConverteParaEntidade<CSICP_FF014>
    {
        public string? Ff014Filialid { get; set; }
        public int? Ff014Handle { get; set; }
        public string? Ff014Descricao { get; set; }
        public string? Ff014Comissaoid { get; set; }
        public int? Ff014Diasde { get; set; }
        public int? Ff014Diasate { get; set; }
        public decimal? Ff014Perccomissao { get; set; }

        public CSICP_FF014 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_FF014
            {
                TenantId = tenant,
                Id = id ?? "",
                Ff014Filialid = Ff014Filialid,
                Ff014Handle = Ff014Handle,
                Ff014Descricao = Ff014Descricao,
                Ff014Comissaoid = Ff014Comissaoid,
                Ff014Diasde = Ff014Diasde,
                Ff014Diasate = Ff014Diasate,
                Ff014Perccomissao = Ff014Perccomissao
            };
            return entity;
        }
    }
}