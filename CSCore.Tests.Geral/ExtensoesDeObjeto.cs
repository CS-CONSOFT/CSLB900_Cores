using CSLB900.MSTools.Extensao;

namespace CSLB900.MSToolsTestes
{
    public class ExtensoesDeObjeto
    {
        [Fact]
        public void ConverteStringVaziaParaDataNula_QuandoStringVazia_RetornaNulo()
        {
            string? date = "25/06/2000";
            DateTime? result = date.ConverteStringVaziaParaDataNula();
            Assert.Null(result);
        }
    }
}
