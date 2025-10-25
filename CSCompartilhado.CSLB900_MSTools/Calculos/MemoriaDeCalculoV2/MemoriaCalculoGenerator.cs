namespace CSLB900.MSTools.Calculos.MemoriaDeCalculoV2
{
    public record MemoriaCalculoItem(
        /// <summary> pode ser nulo ou 0 se não houver parcela</summary>
        int? InNumeroParcelas,
        string CondicaoPagamento,
        int BB008_Tipo_ID,
        decimal? Prm_Total_Fatura,
        decimal? Prm_Valor_Entrada,
        DateOnly Prm_1o_Vencto
        );

    public record Rec_Memoria(int Parcela, DateOnly Data_Vencto, decimal Valor_Parcela, int Nro_Parcelas);

    public static class MemoriaCalculoGenerator
    {
        public static List<Rec_Memoria> GerarMemoriaCalculo(MemoriaCalculoItem prm, CS_Get_Qtd_ParcelasParameters prm2)
        {
            var numeroParcelas = prm.InNumeroParcelas;

            if (numeroParcelas == null || numeroParcelas == 0)
            {
                CS_Get_Qtd_ParcelasResult resultadoCS_Get_Qtd_Parcelas
                    = CS_Get_Qtd_Parcelas.Executar(prm.CondicaoPagamento, prm.BB008_Tipo_ID, prm2);
                numeroParcelas = resultadoCS_Get_Qtd_Parcelas.Qtd_Parcelas;

            }

            if (numeroParcelas <= 0)
                throw new ArgumentException("Número de parcelas deve ser maior que zero.");

            var V_Valor_Financiado = prm.Prm_Total_Fatura - (prm.Prm_Valor_Entrada ?? 0) ?? 0;
            var V_Valor_Parcela = V_Valor_Financiado / numeroParcelas.Value;
            var V_Valor_Resto_Parcela = V_Valor_Financiado - (V_Valor_Parcela * numeroParcelas.Value);

            List<Rec_Memoria> listaMemoriaCalculo = new List<Rec_Memoria>();

            var condicaoPagtoDividida = prm.CondicaoPagamento.Split(';');
            if (EhTipoDiasPagamento(prm, prm2))
                GerarMemoriaCalculoPorDias(numeroParcelas, V_Valor_Parcela, V_Valor_Resto_Parcela, listaMemoriaCalculo, prm.Prm_1o_Vencto,condicaoPagtoDividida);

            if (EhTipoPagamentoAVista(prm, prm2))
                GerarMemoriaCalculoAVista(numeroParcelas, V_Valor_Financiado, prm.Prm_1o_Vencto, listaMemoriaCalculo);

            if (EhTipoPagamentoPorPeriodo(prm, prm2))
                GerarMemoriaCalculoPorPeriodo(prm,prm2, numeroParcelas, V_Valor_Financiado, V_Valor_Resto_Parcela, listaMemoriaCalculo, condicaoPagtoDividida);
            

            return listaMemoriaCalculo;

        }

        private static void GerarMemoriaCalculoPorPeriodo(
            MemoriaCalculoItem prm,
            CS_Get_Qtd_ParcelasParameters prm2,
            int? numeroParcelas, decimal V_ValorFinanciado, decimal V_Valor_Resto_Parcela, List<Rec_Memoria> listaMemoriaCalculo, string[] condicaoPagtoDividida)
        {
            var entrada = int.Parse(condicaoPagtoDividida[1]);
            var intervalo = int.Parse(condicaoPagtoDividida[2]);
            var V_Nro_Parcela_Atual = 1;
            var V_Data_Vencto_Aux = prm.Prm_1o_Vencto;
            var V_Valor_Parcela = 0m;

            for (int i = 1; i <= numeroParcelas; i++)
            {
                var parcelasRestantes = entrada != 0 ? numeroParcelas - 1 : numeroParcelas;
                var valorParcela = Decimal.Round(V_ValorFinanciado / parcelasRestantes ?? 0, 2);

                if (V_Nro_Parcela_Atual == 1)
                {
                    V_Data_Vencto_Aux = prm.Prm_1o_Vencto;
                    V_Valor_Parcela = prm.Prm_Valor_Entrada > 0 ? prm.Prm_Valor_Entrada ?? 0 + V_Valor_Resto_Parcela : valorParcela;
                }
                else
                {
                    V_Data_Vencto_Aux = prm.BB008_Tipo_ID == prm2.InStID_BB008_ParcelaDias ?
                        V_Data_Vencto_Aux.AddDays(intervalo) :
                        V_Data_Vencto_Aux.AddMonths(intervalo);

                    V_Valor_Parcela = valorParcela + V_Valor_Resto_Parcela;
                }
               
                var recMemoria = new Rec_Memoria(
                    Parcela: V_Nro_Parcela_Atual,
                    Data_Vencto: V_Data_Vencto_Aux,
                    Valor_Parcela: V_Valor_Parcela,
                    Nro_Parcelas: numeroParcelas ?? 0
                    );
                listaMemoriaCalculo.Add(recMemoria);
                V_Nro_Parcela_Atual++;
                V_Valor_Resto_Parcela = 0;
            }
        }

        private static bool EhTipoPagamentoPorPeriodo(MemoriaCalculoItem prm, CS_Get_Qtd_ParcelasParameters prm2)
        {
            return prm.BB008_Tipo_ID == prm2.InStID_BB008_ParcelaDias || prm.BB008_Tipo_ID == prm2.InStID_BB008_ParcelaMes;
        }

        private static void GerarMemoriaCalculoAVista(
            int? numeroParcelas,
            decimal V_ValorFinanciado,
              DateOnly Data,
            List<Rec_Memoria> listaMemoriaCalculo)
        {
            var recMemoria = new Rec_Memoria(
                                Parcela: 1,
                                Data_Vencto: Data,
                                Valor_Parcela: V_ValorFinanciado,
                                Nro_Parcelas: 0
                                );
            listaMemoriaCalculo.Add(recMemoria);
        }

        private static bool EhTipoPagamentoAVista(MemoriaCalculoItem prm, CS_Get_Qtd_ParcelasParameters prm2)
        {
            return prm.BB008_Tipo_ID == prm2.InStID_BB008_AVista;
        }



        private static void GerarMemoriaCalculoPorDias(
            int? numeroParcelas,
            decimal V_Valor_Parcela,
            decimal V_Valor_Resto_Parcela,
            List<Rec_Memoria> listaMemoriaCalculo,
            DateOnly Data,
            string[] condicaoPagtoDividida)
        {
            var parcelaAtual = 1;
            foreach (var current in condicaoPagtoDividida.ToList())
            {
                var recMemoria = new Rec_Memoria(
                    Parcela: parcelaAtual,
                    Data_Vencto: Data.AddDays(int.Parse(current)),
                    Valor_Parcela: V_Valor_Parcela + V_Valor_Resto_Parcela,
                    Nro_Parcelas: numeroParcelas ?? 0
                    );
                listaMemoriaCalculo.Add(recMemoria);
                parcelaAtual++;
            }
        }

        private static bool EhTipoDiasPagamento(MemoriaCalculoItem prm, CS_Get_Qtd_ParcelasParameters prm2)
        {
            return prm.BB008_Tipo_ID == prm2.InStID_BB008_TP_DIAS;
        }
    }
}
