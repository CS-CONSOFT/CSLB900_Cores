using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain
{
    public enum RetornoPadraoProcessos
    {
        Sucesso = 0,
        ErroGenerico = 1,
        ErroValidacao = 2,
        NaoEncontrado = 3,
        JaExiste = 4,
        SemPermissao = 5
    }
    public class RetornoPadraoProcessosVoid
    {
        private RetornoPadraoProcessosVoid()
        {
        
        }

        public static RetornoPadraoProcessosVoid Create(RetornoPadraoProcessos retorno, bool sucesso)
        {
            return new RetornoPadraoProcessosVoid
            {
                RETORNO = retorno,
                SUCESSO = sucesso
            };
        }

        public RetornoPadraoProcessos RETORNO { get; private set; } = RetornoPadraoProcessos.ErroGenerico;
        public bool SUCESSO { get; private set; } = false;
    }
}
