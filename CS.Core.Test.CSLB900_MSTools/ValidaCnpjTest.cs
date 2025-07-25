using CSLB900.MSTools.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSToolsTestes
{
    public class ValidaCnpjTest
    {

        [Theory]
        [InlineData("11222333000181")] // CNPJ válido
        [InlineData("11.222.333/0001-81")] // CNPJ válido com máscara
        [InlineData("11444777000161")] // Outro CNPJ válido
        public void CnpjValido_DeveRetornarTrue_ParaCnpjsValidos(string cnpj)
        {
            Assert.True(ValidaCnpj.CnpjValido(cnpj));
        }

        [Theory]
        [InlineData("11222333000180")] // Dígito verificador inválido
        [InlineData("11.222.333/0001-80")] // Com máscara, inválido
        [InlineData("00000000000000")] // Todos iguais
        [InlineData("11111111111111")] // Todos iguais
        [InlineData("123")] // Muito curto
        [InlineData("")] // Vazio
        [InlineData(null)] // Nulo
        public void CnpjValido_DeveRetornarFalse_ParaCnpjsInvalidos(string cnpj)
        {
            Assert.False(ValidaCnpj.CnpjValido(cnpj));
        }
    }
}
