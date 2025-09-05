using CSLB900.MSTools.CalculoAdicaoDataStrategy;

namespace CSLB900.MSTools.Calculos
{

    public static class CalculoParcelasPorCondicao
    {
        public static List<RetCalculoParcelasPorCondicao> Calcular(
            PrmCalculoParcelasPorCondicao prm, IIncrementarDataStrategy IncrementarDataStrategy)
        {
            int _aux_qtd_parcelas = int.Parse(prm.InCondicaoPagtoDividida[0]);
            int entrada = int.Parse(prm.InCondicaoPagtoDividida[1]);
            int intervaloParcelas = int.Parse(prm.InCondicaoPagtoDividida[2]);
            int ultimoIntervaloParcelaSalvo = intervaloParcelas + entrada;

            var parcelasRestantes = entrada != 0 ? _aux_qtd_parcelas - 1 : _aux_qtd_parcelas;
            var valorFinanciado = prm.InFaturaTotal - prm.InValorEntrada;
            var valorParcela = Decimal.Round(valorFinanciado / parcelasRestantes, 2);
            var valorRestoParcela = valorFinanciado - (valorParcela * parcelasRestantes);


            List<RetCalculoParcelasPorCondicao> listaParcelas = [];
            for (int parcelaAtual = 1; parcelaAtual <= _aux_qtd_parcelas; parcelaAtual++)
            {
                var isEntrada = PossuiEntrada(prm.InValorEntrada, parcelaAtual, entrada);

                RetCalculoParcelasPorCondicao workCalculo;
                if (isEntrada)
                {
                    workCalculo = new RetCalculoParcelasPorCondicao
                    {
                        ValorParcela = prm.InValorEntrada + valorRestoParcela,
                        Parcela = parcelaAtual,
                        DataVencimento = IncrementarDataStrategy.IncrementarData(prm.InDataCalculo, entrada)
                    };
                    listaParcelas.Add(workCalculo);
                    continue;
                }

                workCalculo = new RetCalculoParcelasPorCondicao
                {
                    ValorParcela = valorParcela,
                    Parcela = parcelaAtual,
                    DataVencimento = IncrementarDataStrategy.IncrementarData(prm.InDataCalculo, ultimoIntervaloParcelaSalvo)
                };

                valorRestoParcela = 0;
                ultimoIntervaloParcelaSalvo += intervaloParcelas;
                listaParcelas.Add(workCalculo);
            }
            return listaParcelas;
        }

        private static bool PossuiEntrada(
         decimal work_valor_entrada,
         int aux_parcela_atual,
         int aux_dias_mes_entrada)
        {
            return aux_parcela_atual == 1 && aux_dias_mes_entrada != 0 && work_valor_entrada > 0;
        }

    }

    public class RetCalculoParcelasPorCondicao
    {
        public decimal ValorParcela { get; set; }
        public int Parcela { get; set; }
        public DateTime DataVencimento { get; set; }
    }

    public class PrmCalculoParcelasPorCondicao
    {
        public string[] InCondicaoPagtoDividida { get; set; } = null!;
        public decimal InFaturaTotal { get; set; }
        public decimal InValorEntrada { get; set; } = 0;
        public DateTime InDataCalculo { get; set; }
    }

}


