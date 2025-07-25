using CSLB900.MSTools.Extensao;
using Xunit;

namespace CSCore.Ifs.GGTests
{
    internal class ObjetoParaTeste
    {
        public int? ValorInteiroNulavel { get; set; }
        public long? ValorLongNulavel { get; set; }
        public string? ValorStringNulavel { get; set; }

        public ObjetoParaTeste(int? valorInteiroNulavel, long? valorLongNulavel, string? valorStringNulavel)
        {
            ValorInteiroNulavel = valorInteiroNulavel;
            ValorLongNulavel = valorLongNulavel;
            ValorStringNulavel = valorStringNulavel;
        }
    }


    public class TestesNulabilidade
    {
        [Fact]
        public void DevePassarNoTesteAoNaoTrocarTodosOsValoresNulaveisEPadroesParaNulo()
        {
            var objTeste = new ObjetoParaTeste(1, 2, "a");
            objTeste.ConverteValoresPadraoParaNulo();

            Assert.NotNull(objTeste.ValorStringNulavel);
            Assert.NotNull(objTeste.ValorInteiroNulavel);
            Assert.NotNull(objTeste.ValorLongNulavel);
        }

        [Fact]
        public void DevePassarNoTesteAoTrocarTodosOsValoresNulaveisEPadroesParaNulo()
        {
            var objTeste = new ObjetoParaTeste(0, 0, "");
            objTeste.ConverteValoresPadraoParaNulo();

            Assert.Null(objTeste.ValorStringNulavel);
            Assert.Null(objTeste.ValorInteiroNulavel);
            Assert.Null(objTeste.ValorLongNulavel);
        }
    }
}
