using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF013
{
    public class DtoCreateUpdateFF013 : IConverteParaEntidade<CSICP_FF013>
    {
        public string? Ff013Filialid { get; set; }
        public string? Ff013Grupocobrancaid { get; set; }
        public string? Ff013Cobradorid { get; set; }
        public string? Ff013Zonaid { get; set; }
        public string? Ff013Contaid { get; set; }
        public int? Ff013Tpregistro { get; set; }

        public CSICP_FF013 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_FF013
            {
                TenantId = tenant,
                Id = id!,
                Ff013Filialid = Ff013Filialid,
                Ff013Grupocobrancaid = Ff013Grupocobrancaid,
                Ff013Cobradorid = Ff013Cobradorid,
                Ff013Zonaid = Ff013Zonaid,
                Ff013Contaid = Ff013Contaid,
                Ff013Tpregistro = Ff013Tpregistro
            };
            return entity;
        }
    }
}