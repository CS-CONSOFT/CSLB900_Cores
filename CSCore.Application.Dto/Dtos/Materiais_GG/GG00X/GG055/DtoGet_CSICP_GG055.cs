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
    public class DtoGet_CSICP_GG055
    {
        public DtoGet_CSICP_GG055(CSICP_GG055 entity)
        {
            TenantId = entity.TenantId;
            Gg055Id = entity.Gg055Id;
                Gg054Id = entity.Gg054Id;
                Gg055Codgproduto = entity.Gg055Codgproduto;
                Gg055Codgbarras = entity.Gg055Codgbarras;
                Gg055ProdutoId = entity.Gg055ProdutoId;
                Gg055Saldoid = entity.Gg055Saldoid;
                Gg055KdxId = entity.Gg055KdxId;
                Gg055Unidade = entity.Gg055Unidade;
                Gg055Gradelinhaid = entity.Gg055Gradelinhaid;
                Gg055Gradecolunaid = entity.Gg055Gradecolunaid;
                Gg055Lote = entity.Gg055Lote;
                Gg055Sublote = entity.Gg055Sublote;
                Gg055Quantidade = entity.Gg055Quantidade;
                Gg055Status = entity.Gg055Status;
                Gg055UsuarioId = entity.Gg055UsuarioId;
                Gg055DataInc = entity.Gg055DataInc;
                Gg055HoraInc = entity.Gg055HoraInc;
                Gg055UsuarioAlt = entity.Gg055UsuarioAlt;
                Gg055DataAlt = entity.Gg055DataAlt;
                Gg055HoraAlt = entity.Gg055HoraAlt;
                Gg055Criarexcid = entity.Gg055Criarexcid;
                Nav_Gg008Kdx = entity.Nav_Gg008Kdx?.ToDtoGetSimples();
                Nav_GG520Saldo = entity.Nav_GG520Saldo?.ToDtoGetSimples();
        }

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
