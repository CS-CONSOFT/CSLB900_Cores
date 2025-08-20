namespace CSLB900.MSTools.Calculos
{
    public static class CalculoTitulos
    {
     

        public static (decimal, int) CalcularJuros
            (DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualJuros,
            int? DiasLiberacao,
            // InFinacEspJuros: Se for true, não calcula juros, apenas retorna 0
            bool InFinacEspJuros)
        {
            if(InFinacEspJuros == true) return (0, 0);


            return CalcularTituloPercentual(
                DataVencimento,
                ValorTitulo,
                PercentualJuros,
                DiasLiberacao,
                (valor, dias) => valor * dias);
        }


        public static (decimal, int) CalcularMulta(
            DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? PercentualMulta,
            int? DiasLiberacao,
            // InFinacEspMulta: Se for true, não calcula multa, apenas retorna 0
            bool InFinacEspMulta)
        {
            if (InFinacEspMulta == true) return (0, 0);
            return CalcularTituloPercentual
                (DataVencimento,
                ValorTitulo,
                PercentualMulta,
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
                DiasLiberacao,
                (valor, _) => valor);
        }

        private static (decimal, int) CalcularTituloPercentual(
         DateTime DataVencimento,
         decimal ValorTitulo,
         decimal? Percentual,
         int? DiasLiberacao,
         Func<decimal, int, decimal> calculo)
        {
            (decimal valorBase, int diasAtraso) = RealizaCalculoPercentual(
                DataVencimento, ValorTitulo, Percentual, DiasLiberacao);

            decimal valorFinal = calculo(valorBase, diasAtraso);

            return (Math.Round(valorFinal, 2), diasAtraso);
        }


        private static (decimal, int) RealizaCalculoPercentual
            (DateTime DataVencimento,
            decimal ValorTitulo,
            decimal? Percentual,
            int? DiasLiberacao)
        {
            if (Percentual is null) throw new Exception("Percentual nao pode ser nulo");
            int DiasAtraso = CalculaDiasDeAtraso(DataVencimento, DiasLiberacao);
            if (DiasAtraso < 0) return (0, DiasAtraso);
            if (Percentual == 0) return (0, DiasAtraso);

            decimal valorJuros = ((ValorTitulo * (decimal)Percentual!) / 100);

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
