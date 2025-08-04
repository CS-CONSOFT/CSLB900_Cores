using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF114
{
    public class DtoCreateUpdateFF114 : IConverteParaEntidade<CSICP_FF114>
    {
        public string? Ff114Refconfigbanco { get; set; }

        public decimal? Ff114Lote { get; set; }

        public int? Ff114Ordem { get; set; }

        public string? Ff114Linha240 { get; set; }

        public string? Ff114Linha400 { get; set; }

        public string? Ff114Idcontrole { get; set; }
        public CSICP_FF114 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF114
            {
                TenantId = tenant,
                Id = id!,
                Ff114Refconfigbanco = Ff114Refconfigbanco,
                Ff114Lote = Ff114Lote,
                Ff114Ordem = Ff114Ordem,
                Ff114Linha240 = Ff114Linha240,
                Ff114Linha400 = Ff114Linha400,
                Ff114Idcontrole = Ff114Idcontrole
            };
        }
    }
}
