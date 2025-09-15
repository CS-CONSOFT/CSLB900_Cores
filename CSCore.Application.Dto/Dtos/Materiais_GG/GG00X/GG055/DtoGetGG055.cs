using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Application.Dto.Mapper.GG00X;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using GG104Materiais.C82Application.Dto.GG00X.GG001;
using GG104Materiais.C82Application.Dto.GG00X.GG008;
using GG104Materiais.C82Application.Mapper.GG008;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG055
{
    public class DtoGetGG055
    {
        public int TenantId { get; set; }

        public long Gg055Id { get; set; }

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


        public DtoGetGG008Kdx_Simples? Nav_Gg008Kdx { get; set; }

        public DtoGetGG520Simples? Nav_GG520Saldo { get; set; }

        public DtoGetGG001Simples? Nav_GG001Almox { get; set; }

        public DtoGetGG008_Exibicao_Simples? Nav_GG008Produto { get; set; }
    }
}
