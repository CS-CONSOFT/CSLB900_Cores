using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF108
{
    public class DtoCreateUpdateFF108 : IConverteParaEntidade<CSICP_FF108>
    {
        public string? Ff105Borderoid { get; set; }

        public DateTime? Ff108Datahora { get; set; }

        public string? Ff108Mensagem { get; set; }

        public string? Ff108UsuarioId { get; set; }

        public CSICP_FF108 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF108
            {
                TenantId = tenant,
                Ff105Borderoid = Ff105Borderoid,
                Ff108Datahora = Ff108Datahora,
                Ff108Mensagem = Ff108Mensagem,
                Ff108UsuarioId = Ff108UsuarioId
            };
        }
    }
}
