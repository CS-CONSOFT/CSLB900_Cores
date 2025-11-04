using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.NN.Dto
{
    public class DtoGetNN016
    {
        public int TenantId { get; set; }

        public string Nn016Id { get; set; } = null!;
        public string? Nn016CrcpId { get; set; }

        public int? Nn016Filial { get; set; }

        public int? Nn016TipoMovimento { get; set; }

        public int? Nn016FilialBaixa { get; set; }

        public string? Nn016TituloId { get; set; }

        public string? Nn016Prefixo { get; set; }

        public decimal? Nn016Titulo { get; set; }

        public string? Nn016Sfx { get; set; }

        public int? Nn016SequenciaBaixa { get; set; }

        public DateTime? Nn016DataVencimento { get; set; }

        public int? Nn016Diasatraso { get; set; }

        public decimal? Nn016Vlrabertotitulos { get; set; }

        public decimal? Nn016ValorJuros { get; set; }

        public decimal? Nn016ValorDesconto { get; set; }

        public decimal? Nn016ValorMulta { get; set; }

        public decimal? Nn016ValorTaxa { get; set; }

        public decimal? Nn016ValorPago { get; set; }

        public int? Nn016SituacaotitId { get; set; }

        public bool? Nn016BaixarSn { get; set; }

        public int? Nn016CliFor { get; set; }

        public string? Nn016Historico { get; set; }

        public string? Nn016Mensagem { get; set; }

        public decimal? Nn016ValorJurosCalc { get; set; }

        public decimal? Nn016ValorMultaCalc { get; set; }

        public decimal? Nn016ValorTaxaCalc { get; set; }

        public decimal? Nn016TotalApagar { get; set; }

        public string? Nn016Protocolnumber { get; set; }

        public string? Nn016IdEstorno { get; set; }

        public decimal? Nn016TaxaAntecipacao { get; set; }

        public decimal? Nn016ValorTxAntcartao { get; set; }

        public decimal? Nn016Vcorrmonetaria { get; set; }

        public decimal? Nn016Vhonorarios { get; set; }

        public Dto_GetBB001Simples? Nav_GetBB001Simples { get; set; }
        public Dto_GetBB012_ExibSimples? Nav_GetBB012Simples { get; set; }
        public CSICP_FF102Sit? Nav_FF102Sit { get; set; }

        public CSICP_NN016 ToEntity()
        {
            return new CSICP_NN016
            {
                TenantId = this.TenantId,
                Nn016Id = this.Nn016Id,
                Nn016CrcpId = this.Nn016CrcpId,
                Nn016Filial = this.Nn016Filial,
                Nn016TipoMovimento = this.Nn016TipoMovimento,
                Nn016FilialBaixa = this.Nn016FilialBaixa,
                Nn016TituloId = this.Nn016TituloId,
                Nn016Prefixo = this.Nn016Prefixo,
                Nn016Titulo = this.Nn016Titulo,
                Nn016Sfx = this.Nn016Sfx,
                Nn016SequenciaBaixa = this.Nn016SequenciaBaixa,
                Nn016DataVencimento = this.Nn016DataVencimento,
                Nn016Diasatraso = this.Nn016Diasatraso,
                Nn016Vlrabertotitulos = this.Nn016Vlrabertotitulos,
                Nn016ValorJuros = this.Nn016ValorJuros,
                Nn016ValorDesconto = this.Nn016ValorDesconto,
                Nn016ValorMulta = this.Nn016ValorMulta,
                Nn016ValorTaxa = this.Nn016ValorTaxa,
                Nn016ValorPago = this.Nn016ValorPago,
                Nn016SituacaotitId = this.Nn016SituacaotitId,
                Nn016BaixarSn = this.Nn016BaixarSn,
                Nn016CliFor = this.Nn016CliFor,
                Nn016Historico = this.Nn016Historico,
                Nn016Mensagem = this.Nn016Mensagem,
                Nn016ValorJurosCalc = this.Nn016ValorJurosCalc,
                Nn016ValorMultaCalc = this.Nn016ValorMultaCalc,
                Nn016ValorTaxaCalc = this.Nn016ValorTaxaCalc,
                Nn016TotalApagar = this.Nn016TotalApagar,
                Nn016Protocolnumber = this.Nn016Protocolnumber,
                Nn016IdEstorno = this.Nn016IdEstorno,
                Nn016TaxaAntecipacao = this.Nn016TaxaAntecipacao,
                Nn016ValorTxAntcartao = this.Nn016ValorTxAntcartao,
                Nn016Vcorrmonetaria = this.Nn016Vcorrmonetaria,
                Nn016Vhonorarios = this.Nn016Vhonorarios,

            };
        }

      
    }
}
