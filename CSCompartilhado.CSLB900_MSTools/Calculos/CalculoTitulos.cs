namespace CSLB900.MSTools.Calculos
{
    public static class CalculoTitulos
    {
     

        public static (decimal, int) CalcularJuros
            (DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualJuros,
            int? DiasLiberacao,
            decimal? ValorMultaOuJuros,
            // InFinacEspJuros: Se for true, não calcula juros, apenas retorna 0
            bool InFinacEspJuros)
        {
            if(InFinacEspJuros == true) return (0, 0);

            return CalcularTituloPercentual(
                DataVencimento,
                ValorTitulo,
                PercentualJuros,
                ValorMultaOuJuros,
                DiasLiberacao,
                (valor, dias) => valor * dias);
        }


        public static (decimal, int) CalcularMulta(
            DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualMulta,
            decimal? ValorMultaOuJuros,
            int? DiasLiberacao,
            // InFinacEspMulta: Se for true, não calcula multa, apenas retorna 0
            bool InFinacEspMulta)
        {
            if (InFinacEspMulta == true) return (0, 0);
            return CalcularTituloPercentual
                (DataVencimento,
                ValorTitulo,
                PercentualMulta,
                ValorMultaOuJuros,
                DiasLiberacao, 
                (valor, _) => valor);
        }

        public static (decimal, int) CalcularHonorarios(
             DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualHonorarios,
            int? DiasLiberacao)
        {
            return CalcularTituloPercentual(
                DataVencimento,
                ValorTitulo,
                PercentualHonorarios,
                ValorMultaOuJuros: 0,
                DiasLiberacao,
                (valor, _) => valor);
        }

        public static (decimal, int) CalcularCorrecaoMonetaria(
            DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualCorrMonetaria,
           int? DiasLiberacao)
        {
            return CalcularTituloPercentual(
                DataVencimento,
                ValorTitulo,
                PercentualCorrMonetaria,
                ValorMultaOuJuros: 0,
                DiasLiberacao,
                (valor, _) => valor);
        }


        /*KERNEL*/
        private static (decimal, int) CalcularTituloPercentual(
         DateTime DataVencimento,
         decimal ValorTitulo,
         decimal? Percentual,
         decimal? ValorMultaOuJuros,
         int? DiasLiberacao,
         Func<decimal, int, decimal> calculo)
        {
            (decimal valorBase, int diasAtraso) = RealizaCalculoPercentual(
                DataVencimento, ValorTitulo, Percentual, ValorMultaOuJuros, DiasLiberacao);

            decimal valorFinal = calculo(valorBase, diasAtraso);

            return (Math.Round(valorFinal, 2), diasAtraso);
        }


        /*KERNEL*/
        private static (decimal, int) RealizaCalculoPercentual
            (DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? Percentual,
            decimal? ValorMultaOuJuros,
            int? DiasLiberacao)
        {
            if (Percentual is null) return (0,0);
            int DiasAtraso = CalculaDiasDeAtraso(DataVencimento, DiasLiberacao);
            if (DiasAtraso < 0) return (0, DiasAtraso);
            if (Percentual == 0) return (0, DiasAtraso);

            decimal valorJuros;
            if (ValorMultaOuJuros != null || ValorMultaOuJuros != 0)
                valorJuros = ValorMultaOuJuros ?? 0;
            else 
                valorJuros = ((ValorTitulo * (decimal)Percentual!) / 100);

            return (valorJuros, DiasAtraso);
        }

        private static int CalculaDiasDeAtraso(
            DateTime DataVencimento, int? DiasLiberacao)
        {
            DataVencimento.AddDays(DiasLiberacao is not null ? (double)DiasLiberacao : 0);

            if (DataVencimento >= DateTime.UtcNow) return 0;

            TimeSpan DuracaoAteVencimento = DateTime.UtcNow - DataVencimento;

            int DiasAtraso = DuracaoAteVencimento.Days;
            return DiasAtraso;
        }
    }
}
