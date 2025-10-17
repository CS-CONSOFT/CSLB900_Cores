using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG055
{
    public class DtoCreateGG055 : IConverteParaEntidade<CSICP_GG055>
    {
        public long? Gg054Id { get; set; }

        public int? Gg055Codgproduto { get; set; }

        public string? Gg055Codgbarras { get; set; }

        public string? Gg055ProdutoId { get; set; }

        public string? Gg055Saldoid { get; set; }

        public string? Gg055KdxId { get; set; }

        public string? Gg055Unidade { get; set; }

        public string? Gg055Gradelinhaid { get; set; }

        public string? Gg055Gradecolunaid { get; set; }

        public string? Gg055Lote { get; set; }

        public string? Gg055Sublote { get; set; }

        public decimal? Gg055Quantidade { get; set; }

        public int? Gg055Status { get; set; }

        public string? Gg055UsuarioId { get; set; }

        public DateTime? Gg055DataInc { get; set; }

        public DateTime? Gg055HoraInc { get; set; }

        public string? Gg055UsuarioAlt { get; set; }

        public DateTime? Gg055DataAlt { get; set; }

        public DateTime? Gg055HoraAlt { get; set; }

        public int? Gg055Criarexcid { get; set; }

        public CSICP_GG055 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG055
            {
                TenantId = tenant,
                Gg054Id = this.Gg054Id,
                Gg055Codgproduto = this.Gg055Codgproduto,
                Gg055Codgbarras = this.Gg055Codgbarras,
                Gg055ProdutoId = this.Gg055ProdutoId,
                Gg055Saldoid = this.Gg055Saldoid,
                Gg055KdxId = this.Gg055KdxId,
                Gg055Unidade = this.Gg055Unidade,
                Gg055Gradelinhaid = this.Gg055Gradelinhaid,
                Gg055Gradecolunaid = this.Gg055Gradecolunaid,
                Gg055Lote = this.Gg055Lote,
                Gg055Sublote = this.Gg055Sublote,
                Gg055Quantidade = this.Gg055Quantidade,
                Gg055Status = this.Gg055Status,
                Gg055UsuarioId = this.Gg055UsuarioId,
                Gg055DataInc = this.Gg055DataInc,
                Gg055HoraInc = this.Gg055HoraInc,
                Gg055UsuarioAlt = this.Gg055UsuarioAlt,
                Gg055DataAlt = this.Gg055DataAlt,
                Gg055HoraAlt = this.Gg055HoraAlt,
                Gg055Criarexcid = this.Gg055Criarexcid,
            };
        }
    }
}
