using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSToolsTestes
{
    public class ValidaCPF
    {
        [Fact]
        public void CpfValido_ValidCpf_ReturnsTrue()
        {
            decimal cpfDecimal = 12345678909; // Válido
            Assert.True(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }

        [Fact]
        public void CpfValido_ValidCpfWithLeadingZeros_ReturnsTrue()
        {
            decimal cpfDecimal = 39053344705; // Válido, começa com zero
            Assert.True(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }

        [Fact]
        public void CpfValido_InvalidCpf_WrongCheckDigits_ReturnsFalse()
        {
            decimal cpfDecimal = 12345678900; // Inválido, dígitos verificadores errados
            Assert.False(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }

        [Fact]
        public void CpfValido_InvalidCpf_AllDigitsSame_ReturnsFalse()
        {
            decimal cpfDecimal = 11111111111; // Inválido, todos dígitos iguais
            Assert.False(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }

        [Fact]
        public void CpfValido_InvalidCpf_LessThan11Digits_ReturnsFalse()
        {
            decimal cpfDecimal = 123456789; // Inválido, menos de 11 dígitos
            Assert.False(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }

        [Fact]
        public void CpfValido_InvalidCpf_Zero_ReturnsFalse()
        {
            decimal cpfDecimal = 0; // Inválido, todos zeros
            Assert.False(CSLB900.MSTools.Util.ValidaCpf.CpfValido(cpfDecimal));
        }
    }
}
