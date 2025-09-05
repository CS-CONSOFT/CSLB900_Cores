using CSBS101._82Application.Dto.BB00X.BB009;
using CSBS101._82Application.Dto.BB00X.BB029;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF011
{
    public class DtoGetFF011
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Ff011Codigo { get; set; }

        public int? Ff011DiasAtrasosDe { get; set; }

        public int? Ff011DiasAtrasosAte { get; set; }

        public string? Ff011Tipocobrancaid { get; set; }

        public string? Ff011Categoriaid { get; set; }

        public int? Ff011SitcobrancaentId { get; set; }

        public int? Ff011SituacaoentId { get; set; }

        public int? Ff011SituacaosaiId { get; set; }

        public Dto_GetBB009_Exibicao? NavBB009 { get; set; }

        public Dto_GetBB029? NavBB029 { get; set; }

        public CSICP_FF998? NavFF998SitCobrancaEnt { get; set; }

        public Dto_GetBB012_ExibSimples? NavBB012Ent { get; set; }

        public Dto_GetBB012_ExibSimples? NavBB012Sai { get; set; }
    }
}
