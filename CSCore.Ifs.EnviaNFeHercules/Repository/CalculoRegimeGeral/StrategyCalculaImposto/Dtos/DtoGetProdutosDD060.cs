using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Dtos
{
    public record DtoGetProdutosDD060
    {
        public string IDProduto { get; init; } = string.Empty;
        /// <summary>
        /// isso é calculado a partir da query, quando o bb027Imp_full que vem 
        /// junto com o DD060 nao existir, isso vai ser true.
        /// </summary>
        public bool Csicp_Bb027_Imp_IsComExecao { get; init; } = false;
        /// <summary>
        /// isso é true quando o Csicp_Bb027_Imp_IsComExecao é false e o Get_Regra que vem junto com o DD060 existir
        /// </summary>
        public bool Csicp_Bb027_Imp_PossuiRegra { get; init; } = false;

        public CSICP_Bb027Imp? Out_Reg_bb027_Imp { get; init; } = null;
        public OsusrE9aCsicpAa144? Out_Reg_AA144_cClasTrib { get; init; } = null;
        public OsusrE9aCsicpAa144? Out_Reg_AA144_cClasTrib_IS { get; init; } = null;
        public int? dd060Sequencia;
        public decimal? gg021Ncm;
        public int? Get_AA144cClassTrib_cstibsCbs;
        public int? Get_AA144cClassTrib_cclasstrib;
        public decimal? dd060Quantidade;
        public string? gg007Unidade;
        public int? Get_AA144cClassTrib_IS_cstibsCbs1;
        public int? Get_AA144cClassTrib_IS_cclasstrib1;
        public decimal n39Vicmsmono;
        public decimal dd060TotalLiquido;
        public int GG008_Servico = 0;

        public bool HasError { get; init; } = false;

        public ICollection<Dto_GetDD061Impostos> DD061_Impostos { get; init; } = [];  

        public DtoGetProdutosDD060(
            string IDProduto,
            CSICP_Bb027Imp bb027Imp_full,
            CSICP_Bb027Imp Out_Reg_bb027_Imp,
            OsusrE9aCsicpAa144 Out_Reg_AA144_cClasTrib,
            OsusrE9aCsicpAa144 Out_Reg_AA144_cClasTrib_IS,
            int? dd060Sequencia,
            decimal? gg021Ncm,
            int? Get_AA144cClassTrib_cstibsCbs,
            int? Get_AA144cClassTrib_cclasstrib,
            decimal? dd060Quantidade,
            string? gg007Unidade,
            int? Get_AA144cClassTrib_IS_cstibsCbs1,
            int? Get_AA144cClassTrib_IS_cclasstrib1,
            decimal? dd060TotalLiquido,
            int? GG008_Servico,
            ICollection<Dto_GetDD061Impostos>? DD061_Impostos)
        {
            this.IDProduto = IDProduto;
            this.Csicp_Bb027_Imp_IsComExecao = bb027Imp_full != null;
            this.Csicp_Bb027_Imp_PossuiRegra = Out_Reg_bb027_Imp != null;
            this.Out_Reg_bb027_Imp = Out_Reg_bb027_Imp;
            this.Out_Reg_AA144_cClasTrib = Out_Reg_AA144_cClasTrib;
            this.Out_Reg_AA144_cClasTrib_IS = Out_Reg_AA144_cClasTrib_IS;
            this.HasError = Csicp_Bb027_Imp_IsComExecao && !Csicp_Bb027_Imp_PossuiRegra;
            this.Get_AA144cClassTrib_IS_cclasstrib1 = Get_AA144cClassTrib_IS_cclasstrib1;
            this.Get_AA144cClassTrib_IS_cstibsCbs1 = Get_AA144cClassTrib_IS_cstibsCbs1;
            this.dd060Quantidade = dd060Quantidade;
            this.gg007Unidade = gg007Unidade;
            this.Get_AA144cClassTrib_cclasstrib = Get_AA144cClassTrib_cclasstrib;
            this.Get_AA144cClassTrib_cstibsCbs = Get_AA144cClassTrib_cstibsCbs;
            this.gg021Ncm = gg021Ncm;
            this.dd060Sequencia = dd060Sequencia;
            this.dd060TotalLiquido = dd060TotalLiquido ?? 0m;
            this.DD061_Impostos = DD061_Impostos ?? [];
            this.GG008_Servico = GG008_Servico ?? 0;
        }
    }

    public record Dto_GetDD061Impostos
    {
        public string DD061_ID { get; init; } = string.Empty;
        public int? DD061_ImpostoId { get; init; } = 0;
        public decimal? DD061_ValorImposto { get; init; } = 0m;
        public decimal? DD061_Vicmsufdest { get; init; } = 0m;
        public decimal? DD061_Vfcp { get; init; } = 0m;
        public decimal? DD061_Vfcpufdest { get; init; } = 0m;
        public decimal? DD061_n39Vicmsmono { get; init; } = 0m;

        public Dto_GetDD061Impostos(
            string DD061_ID,
            int? DD061_ImpostoId,
            decimal? DD061_ValorImposto,
            decimal? DD061_Vicmsufdest,
            decimal? DD061_Vfcp,
                        decimal? DD061_Vfcpufdest
,
                        decimal? n39Vicmsmono)
        {
            this.DD061_ID = DD061_ID;
            this.DD061_ImpostoId = DD061_ImpostoId;
            this.DD061_ValorImposto = DD061_ValorImposto;
            this.DD061_Vicmsufdest = DD061_Vicmsufdest;
            this.DD061_Vfcp = DD061_Vfcp;
            this.DD061_Vfcpufdest = DD061_Vfcpufdest;
            this.DD061_n39Vicmsmono = n39Vicmsmono;
        }
    }
}
