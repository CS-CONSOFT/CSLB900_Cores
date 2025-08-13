using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF131
{
    public class DtoGetFF131
    {
        public int TenantId { get; set; }

        public long Ff131Id { get; set; }

        public string? Ff131Filialid { get; set; }

        public DateTime? Ff131Dregistro { get; set; }

        public string? Ff131Contaid { get; set; }

        public string? Ff131TomadorContaid { get; set; }

        public string? Ff131Usuarioid { get; set; }

        public string? Ff131Observacao { get; set; }

        public bool? Ff131Isefetivado { get; set; }

        public string? Ff131Protocolo { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Filial { get; set; }

        public Dto_GetBB012_Exibicao? NavBB012Conta { get; set; }

        public Dto_GetBB012_Exibicao? NavBB012TomadorConta { get; set; }

        public Dto_GetSY001Simples? NavSy001Usuario { get; set; }
    }
}
