using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF131
{
    public class DtoCreateUpdateFF131 : IConverteParaEntidade<CSICP_FF131>
    {
        public string? Ff131Filialid { get; set; }

        public DateTime? Ff131Dregistro { get; set; }

        public string? Ff131Contaid { get; set; }

        public string? Ff131TomadorContaid { get; set; }

        public string? Ff131Usuarioid { get; set; }

        public string? Ff131Observacao { get; set; }

        public bool? Ff131Isefetivado { get; set; }

        public string? Ff131Protocolo { get; set; }

        public CSICP_FF131 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF131
            {
                TenantId = tenant,
                Ff131Filialid = Ff131Filialid,
                Ff131Dregistro = Ff131Dregistro,
                Ff131Contaid = Ff131Contaid,
                Ff131TomadorContaid = Ff131TomadorContaid,
                Ff131Usuarioid = Ff131Usuarioid,
                Ff131Observacao = Ff131Observacao,
                Ff131Isefetivado = Ff131Isefetivado,
                Ff131Protocolo = Ff131Protocolo,
            };
        }
    }
}
