using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG031
{
    public class DtoCreateUpdateGG031 : IConverteParaEntidade<CSICP_GG031>
    {
        public string? Gg031Filialid { get; set; }

        public string? Gg030Id { get; set; }

        public string? Gg031KardexId { get; set; }

        public int? Gg031Produto { get; set; }

        public string? Gg031Produtoid { get; set; }

        public decimal? Gg031Codigobarra { get; set; }

        public DateTime? Gg031DataReferente { get; set; }

        public decimal? Gg031PercAjuste { get; set; }

        public decimal? Gg031PrcAnterior { get; set; }

        public decimal? Gg031PrcMovimento { get; set; }

        public decimal? Gg031PrcCalculado { get; set; }

        public int? Gg031PrecoajusteId { get; set; }

        public string? Gg031Codbarrasalfa { get; set; }
        public CSICP_GG031 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG031
            {
                TenantId = tenant,
                Id = id!,
                Gg031Filialid = this.Gg031Filialid,
                Gg030Id = this.Gg030Id,
                Gg031KardexId = this.Gg031KardexId,
                Gg031Produto = this.Gg031Produto,
                Gg031Produtoid = this.Gg031Produtoid,
                Gg031Codigobarra = this.Gg031Codigobarra,
                Gg031DataReferente = this.Gg031DataReferente,
                Gg031PercAjuste = this.Gg031PercAjuste,
                Gg031PrcAnterior = this.Gg031PrcAnterior,
                Gg031PrcMovimento = this.Gg031PrcMovimento,
                Gg031PrcCalculado = this.Gg031PrcCalculado,
                Gg031PrecoajusteId = this.Gg031PrecoajusteId,
                Gg031Codbarrasalfa = this.Gg031Codbarrasalfa
            };
        }
    }
}














































         
