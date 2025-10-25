using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003
{
    public class DtoCreateUpdateFF003 : IConverteParaEntidade<CSICP_FF003>
    {
        public string? Ff003Filialid { get; set; }

        public int? Ff003Tipoespecie { get; set; }

        public int? Ff003Codigo { get; set; }

        public string? Ff003Descricao { get; set; }

        public string? Ff003Descresumida { get; set; }

        public string? Ff003Pfx { get; set; }

        public int? Ff003Provisao { get; set; }

        public string? Ff003Ccustoid { get; set; }

        public string? Ff003Lctoenttitulosid { get; set; }

        public string? Ff003Lctobxnormalid { get; set; }

        public string? Ff003Lctobxdevolucaoid { get; set; }

        public decimal? Ff003Seqnrotitulo { get; set; }

        public CSICP_FF003 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF003
            {
                TenantId = tenant,
                Id = id!,
                Ff003Filialid = Ff003Filialid,
                Ff003Tipoespecie = Ff003Tipoespecie,
                Ff003Codigo = Ff003Codigo,
                Ff003Descricao = Ff003Descricao,
                Ff003Descresumida = Ff003Descresumida,
                Ff003Pfx = Ff003Pfx,
                Ff003Provisao = Ff003Provisao,
                Ff003Ccustoid = Ff003Ccustoid,
                Ff003Lctoenttitulosid = Ff003Lctoenttitulosid,
                Ff003Lctobxnormalid = Ff003Lctobxnormalid,
                Ff003Lctobxdevolucaoid = Ff003Lctobxdevolucaoid,
                Ff003Seqnrotitulo = Ff003Seqnrotitulo,
            };
        }
    }
}
