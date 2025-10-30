using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF005
{
    public class DtoGetFF005
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff005Filialid { get; set; }

        public int? Ff005Tipo { get; set; }

        public string? Ff003Especieid { get; set; }

        public decimal? Ff005Sequencia { get; set; }

        public string? Ff005Contafornid { get; set; }

        public int? Ff005Diavencimento { get; set; }

        public string? Ff005Pfx { get; set; }

        public int? Ff005ImpostoId { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Filial { get; set; }

        public Dto_GetBB012_ExibSimples? NavBB012ContaFornecedor { get; set; }

        public Dto_GetFF003_Exibicao? NavFF003 { get; set; }

        public OsusrE9aCsicpFf003Tpesp? NavFF003TpEsp { get; set; }

        public CSICP_AA037Imp? NavAA037Imp { get; set; }


    }
}
