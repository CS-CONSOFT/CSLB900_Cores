using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF011
{
    public class DtoCreateUpdateFF011 : IConverteParaEntidade<CSICP_FF011>
    {
        public int? Ff011Codigo { get; set; }

        public int? Ff011DiasAtrasosDe { get; set; }

        public int? Ff011DiasAtrasosAte { get; set; }

        public string? Ff011Tipocobrancaid { get; set; }

        public string? Ff011Categoriaid { get; set; }

        public int? Ff011SitcobrancaentId { get; set; }

        public int? Ff011SituacaoentId { get; set; }

        public int? Ff011SituacaosaiId { get; set; }
        public CSICP_FF011 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_FF011
            {
                TenantId = tenant,
                Id = id ?? "",
                Ff011Codigo = Ff011Codigo,
                Ff011DiasAtrasosDe = Ff011DiasAtrasosDe,
                Ff011DiasAtrasosAte = Ff011DiasAtrasosAte,
                Ff011Tipocobrancaid = Ff011Tipocobrancaid,
                Ff011Categoriaid = Ff011Categoriaid,
                Ff011SitcobrancaentId = Ff011SitcobrancaentId,
                Ff011SituacaoentId = Ff011SituacaoentId,
                Ff011SituacaosaiId = Ff011SituacaosaiId
            };
            return entity;
        }
    }
}
