using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG046
{
    public class DtoCreateUpdateGG046 : IConverteParaEntidade<CSICP_GG046>
    {
        public int? Gg046Seq { get; set; }

        public string? Gg045Id { get; set; }

        public string? Gg046SaldoentId { get; set; }

        public decimal? Gg046Qtd { get; set; }

        public int? Gg046StatId { get; set; }

        public int? Gg046EntsaiId { get; set; }

        public bool? Gg046Isnovo { get; set; }

        public string? Gg046Descricaosaldo { get; set; }

        public string? Gg046Codbarrasalfa { get; set; }
        public CSICP_GG046 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG046
            {
                TenantId = tenant,
                Gg046Id = id!,
                Gg046Seq = this.Gg046Seq,
                Gg045Id = this.Gg045Id ,
                Gg046SaldoentId = this.Gg046SaldoentId ,
                Gg046Qtd = this.Gg046Qtd ,
                Gg046StatId = this.Gg046StatId ,
                Gg046EntsaiId = this.Gg046EntsaiId ,
                Gg046Isnovo = this.Gg046Isnovo ,
                Gg046Descricaosaldo = this.Gg046Descricaosaldo ,
                Gg046Codbarrasalfa = this.Gg046Codbarrasalfa ,
            };
        }
    }
}
