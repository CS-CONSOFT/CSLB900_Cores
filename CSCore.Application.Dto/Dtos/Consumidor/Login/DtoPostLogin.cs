using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Consumidor.Login
{
    public class DtoPostLogin
    {
        public string Prm_CodigoConta { get; set; } = string.Empty;
        public string Prm_ChaveAcesso { get; set; } = string.Empty;
    }
}
