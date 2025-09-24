using CSLB900.MSTools.CalculoAdicaoDataStrategy;

namespace CSLB900.MSTools.Calculos
{

    public static class CalculoParcelasPorCondicao
    {
        public static List<RetCalculoParcelasPorCondicao> Calcular(
            PrmCalculoParcelasPorCondicao prm, IIncrementarDataStrategy IncrementarDataStrategy)
        {
            /*PERIGO PEGAR O VALOR DE FORMA DIRETA DO ARRAY*/
            int _aux_qtd_parcelas = int.Parse(prm.InCondicaoPagtoDividida.GetCondicaoPagamentoDividida()[0]);
            int entrada = int.Parse(prm.InCondicaoPagtoDividida.GetCondicaoPagamentoDividida()[1]);
            int intervaloParcelas = int.Parse(prm.InCondicaoPagtoDividida.GetCondicaoPagamentoDividida()[2]);
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
        public CondicaoPagamentoDividia InCondicaoPagtoDividida { get; set; } = null!;
        public decimal InFaturaTotal { get; set; }
        public decimal InValorEntrada { get; set; } = 0;
        public DateTime InDataCalculo { get; set; }
    }






    /*CLASSE QUE REPRESENTA A CONDIÇÃO DE PAGAMENTO DIVIDIDA*/
    public class CondicaoPagamentoDividia
    {
        private string[] InCondicaoPagto { get; set; } = null!;
    
        public CondicaoPagamentoDividia(string[] inCondicaoPagto)
        {
            var inCondicaoPagtoJoined = string.Join(";", inCondicaoPagto);
            if (inCondicaoPagtoJoined is null)
                throw new ArgumentNullException("A condição de pagamento não pode ser nula.");

            if (inCondicaoPagtoJoined.Trim() == "")
                throw new ArgumentException("A condição de pagamento não pode ser vazia.");

            if (inCondicaoPagtoJoined.Split(';').Length < 3)
                throw new ArgumentException("A condição de pagamento deve conter PELO MENOS três partes separadas por ponto e vírgula.");

            if (inCondicaoPagtoJoined.Split(';').Any(part => !int.TryParse(part, out _)))
                throw new ArgumentException("Todas as partes da condição de pagamento devem ser números inteiros.");

            if (int.Parse(inCondicaoPagtoJoined.Split(';')[0]) <= 0)
                throw new ArgumentException("A quantidade de parcelas deve ser maior que zero.");

            InCondicaoPagto = inCondicaoPagtoJoined.Split(';');
        }



        public CondicaoPagamentoDividia GetCondicaoPagamento()
        {
            return this;
        }

        public string[] GetCondicaoPagamentoDividida()
        {
            return InCondicaoPagto;
        }
    }

}


