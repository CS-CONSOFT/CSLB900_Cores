using CSLB900.MSTools.Calculos;

namespace CSLB900.MSToolsTestes.Calculos
{
    public class CalculoTitulosTeste
    {
        [Fact]
        public void TestandoCalculoJuros()
        {
            var dataVencimento = new DateTime(2025, 1, 14);
            var valorTitulo = 9;
            decimal percentualJuros = 0.33M;
            var diasLiberacao = 0;

            (decimal valorJuros, int diasAtraso) = CalculoTitulos
                .CalcularCorrecaoMonetaria(dataVencimento, valorTitulo, percentualJuros, diasLiberacao);
            Assert.Equal(2.35M, valorJuros);
        }

        [Fact]
        public void TestandoCalculoCorrecaoMonetaria()
        {
            var dataVencimento = new DateTime(2024, 1, 16);
            var valorTitulo = 1000;
            var percentualJuros = 5;
            var diasLiberacao = 5;
            (decimal valorJuros, int diasAtraso) = CalculoTitulos
                .CalcularCorrecaoMonetaria(dataVencimento, valorTitulo, percentualJuros, diasLiberacao);
            Assert.Equal(50, valorJuros);
            Assert.Equal(443, diasAtraso);
        }

        [Fact]
        public void TestandoCalculoMulta()
        {
            var dataVencimento = new DateTime(2024, 1, 16);
            var valorTitulo = 1000;
            var percentualJuros = 5;
            var diasLiberacao = 5;
            (decimal valorJuros, int diasAtraso) = CalculoTitulos
                .CalcularCorrecaoMonetaria(dataVencimento, valorTitulo, percentualJuros, diasLiberacao);
            Assert.Equal(50, valorJuros);
            Assert.Equal(443, diasAtraso);
        }

        [Fact]
        public void TestandoCalculoHonoraios()
        {
            var dataVencimento = new DateTime(2024, 1, 16);
            var valorTitulo = 1000;
            var percentualJuros = 5;
            var diasLiberacao = 5;
            (decimal valorJuros, int diasAtraso) = CalculoTitulos
                .CalcularHonorarios(dataVencimento, valorTitulo, percentualJuros, diasLiberacao);
            Assert.Equal(50, valorJuros);
            Assert.Equal(443, diasAtraso);
        }
    }
}
