using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112Faixa
{
    public class DtoCreateUpdateFF112Faixa : IConverteParaEntidade<CSICP_FF112Faixa>
    {
        public string? Ff112Id { get; set; }

        public decimal? Ff112NossonroInicial { get; set; }

        public decimal? Ff112NossonroFinal { get; set; }

        public decimal? Ff112NossonroAtual { get; set; }

        public decimal? Ff112Avisonossonro { get; set; }

        public bool? Ff112Isactive { get; set; }
        public CSICP_FF112Faixa ToEntity(int tenant, string? id)
        {
            return new CSICP_FF112Faixa
            {
                TenantId = tenant,
                Ff112FaixaId = id!,
                Ff112Id = Ff112Id,
                Ff112NossonroInicial = Ff112NossonroInicial,
                Ff112NossonroFinal = Ff112NossonroFinal,
                Ff112NossonroAtual = Ff112NossonroAtual,
                Ff112Avisonossonro = Ff112Avisonossonro,
                Ff112Isactive = Ff112Isactive
            };
        }
    }
}
