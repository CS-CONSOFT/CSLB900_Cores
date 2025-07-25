using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.Util;
using Xunit;

namespace CSCore.Ifs.GGTests
{
    public class TestesRepositorioMudaAtivo
    {

        [Fact]
        public void DeveRetornarAEntidadeCasoPossuaPropriedadeIsAtivo()
        {
            (bool temPropriedade, _) =
            VerificadorPropriedadesEntidade.TemPropriedade<CSICP_GG004>(["IsActive", "isActive", "isactive", "Isactive"]);
            Assert.True(temPropriedade);
        }
    }
}
