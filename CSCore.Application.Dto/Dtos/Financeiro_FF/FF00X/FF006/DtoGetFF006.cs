using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF006
{
    public class DtoGetFF006
    {
        public int TenantId { get; set; }

        public long Ff006Id { get; set; }

        public string? Ff102Id { get; set; }

        public decimal? Ff006Vdescjuros { get; set; }

        public decimal? Ff006Pdescjuros { get; set; }

        public DateTime? Ff006Dsolicitacao { get; set; }

        public string? Ff006Usuariosolicid { get; set; }

        public DateTime? Ff006Dresgate { get; set; }

        public string? Ff006Usuarioresgid { get; set; }

        public string? Ff006Chaveautoriz { get; set; }

        public decimal? Ff006Vabertotit { get; set; }

        public decimal? Ff006Vjurostit { get; set; }

        public int? Ff006Datrasotit { get; set; }

        public int? Ff006Statusid { get; set; }

        public string? Ff006Chave { get; set; }

        public string? Ff006Tabela { get; set; }

        public virtual CSICP_FF102? Ff102 { get; set; }

        public Dto_GetSY001Simples? NavSy001Solicitante { get; set; }
        public Dto_GetSY001Simples? NavSy001Resgate { get; set; }
        public OsusrE9aCsicpFf006Stum? NavFF006Sta { get; set; }
    }
}
