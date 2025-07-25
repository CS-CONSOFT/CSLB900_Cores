using CSLB900.MSTools.Enumeradores;
using Xunit;
using static CSLB900.MSTools.Enumeradores.EnumTipoRegistroGG008c;

namespace CSCore.Ifs.GGTests.Enumeradores
{
    public class EnumTipoRegistroGG008cTeste
    {
        [Fact]
        public void Deve_Lancar_Excecao_Invalid_Data_Quando_Tipo_Registro_Nao_Existir()
        {
            Assert.Throws<InvalidDataException>(() => VerificaTipoRegistroGG008c.RetornaStringDoTipoRegistroCorrepondente(TIPO_REGISTRO_GG008c.CARACTERISTICA + 10));
        }
    }
}
