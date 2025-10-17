using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF115
{
    public class DtoCreateUpdateFF115 : IConverteParaEntidade<CSICP_FF115>
    {
        public string? Ff115Filialid { get; set; }

        public string? Ff113Controleid { get; set; }

        public int? Ff115Codgfilial { get; set; }

        public string? Ff115Pfx { get; set; }

        public decimal? Ff115Titulo { get; set; }

        public string? Ff115Sfx { get; set; }

        public decimal? Ff115Conta { get; set; }

        public string? Ff115Nossonumero { get; set; }

        public string? Ff115Codgmovtoretorno { get; set; }

        public DateTime? Ff115Datavencimento { get; set; }

        public decimal? Ff115Valornominaltitulo { get; set; }

        public decimal? Ff115Jurosmultaencargos { get; set; }

        public decimal? Ff115Vlrdescontoconcedido { get; set; }

        public decimal? Ff115Abatimentocancelamento { get; set; }

        public decimal? Ff115Valorpago { get; set; }

        public decimal? Ff115Valorliquido { get; set; }

        public DateTime? Ff115Datacredito { get; set; }

        public string? Ff102TituloId { get; set; }

        public bool? Ff115IsincluirBaixa { get; set; }

        public string? Ff115Codgmovc044 { get; set; }

        public string? Ff115Desccodgmovimento { get; set; }

        public string? Ff115Codgocorrcc047 { get; set; }

        public string? Ff115Desccodgocorrcc047 { get; set; }
        // ...
        public CSICP_FF115 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF115
            {
                TenantId = tenant,
                Id = id!,
                Ff115Filialid = Ff115Filialid,
                Ff113Controleid = Ff113Controleid,
                Ff115Codgfilial = Ff115Codgfilial,
                Ff115Pfx = Ff115Pfx,
                Ff115Titulo = Ff115Titulo,
                Ff115Sfx = Ff115Sfx,
                Ff115Conta = Ff115Conta,
                Ff115Nossonumero = Ff115Nossonumero,
                Ff115Codgmovtoretorno = Ff115Codgmovtoretorno,
                Ff115Datavencimento = Ff115Datavencimento,
                Ff115Valornominaltitulo = Ff115Valornominaltitulo,
                Ff115Jurosmultaencargos = Ff115Jurosmultaencargos,
                Ff115Vlrdescontoconcedido = Ff115Vlrdescontoconcedido,
                Ff115Abatimentocancelamento = Ff115Abatimentocancelamento,
                Ff115Valorpago = Ff115Valorpago,
                Ff115Valorliquido = Ff115Valorliquido,
                Ff115Datacredito = Ff115Datacredito,
                Ff102TituloId = Ff102TituloId,
                Ff115IsincluirBaixa = Ff115IsincluirBaixa,
                Ff115Codgmovc044 = Ff115Codgmovc044,
                Ff115Desccodgmovimento = Ff115Desccodgmovimento,
                Ff115Codgocorrcc047 = Ff115Codgocorrcc047,
                Ff115Desccodgocorrcc047 = Ff115Desccodgocorrcc047
            };
        }
    }
}
