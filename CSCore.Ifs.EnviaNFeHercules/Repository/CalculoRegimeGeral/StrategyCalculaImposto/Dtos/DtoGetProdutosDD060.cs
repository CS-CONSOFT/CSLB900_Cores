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
        public int? GetProds_DD061_Imposto_ID { get; init; } = null;
        public decimal GetProds_DD061_ValorImposto { get; init; } = 0;
        public int? dd060Sequencia;
        public decimal? gg021Ncm;
        public int? Get_AA144cClassTrib_cstibsCbs;
        public int? Get_AA144cClassTrib_cclasstrib;
        public decimal? dd060Quantidade;
        public string? gg007Unidade;
        public int? Get_AA144cClassTrib_IS_cstibsCbs1;
        public int? Get_AA144cClassTrib_IS_cclasstrib1;
        public decimal dd061Vicmsufdest;
        public decimal dd061Vfcp;
        public decimal dd061Vfcpufdest;
        public decimal n39Vicmsmono;
        public decimal dd060TotalLiquido;


        public bool HasError { get; init; } = false;

        public DtoGetProdutosDD060(
            bool Csicp_Bb027_Imp_IsComExecao,
            CSICP_Bb027Imp Out_Reg_bb027_Imp,
            OsusrE9aCsicpAa144 Out_Reg_AA144_cClasTrib,
            OsusrE9aCsicpAa144 Out_Reg_AA144_cClasTrib_IS,
            int? GetProds_DD061_Imposto_ID,
            decimal? GetProds_DD061_ValorImposto
,
            int? dd060Sequencia,
            decimal? gg021Ncm,
            int? Get_AA144cClassTrib_cstibsCbs,
            int? Get_AA144cClassTrib_cclasstrib,
            decimal? dd060Quantidade,
            string? gg007Unidade,
            int? Get_AA144cClassTrib_IS_cstibsCbs1,
            int? Get_AA144cClassTrib_IS_cclasstrib1,
            decimal? dd061Vicmsufdest,
            decimal? dd061Vfcp,
            decimal? dd061Vfcpufdest,
            decimal? n39Vicmsmono,
            decimal? dd060TotalLiquido)
        {
            this.Csicp_Bb027_Imp_IsComExecao = Csicp_Bb027_Imp_IsComExecao;
            this.Csicp_Bb027_Imp_PossuiRegra = Out_Reg_bb027_Imp != null;
            this.Out_Reg_bb027_Imp = Out_Reg_bb027_Imp;
            this.Out_Reg_AA144_cClasTrib = Out_Reg_AA144_cClasTrib;
            this.Out_Reg_AA144_cClasTrib_IS = Out_Reg_AA144_cClasTrib_IS;
            this.GetProds_DD061_Imposto_ID = GetProds_DD061_Imposto_ID;
            this.HasError = Csicp_Bb027_Imp_IsComExecao && !Csicp_Bb027_Imp_PossuiRegra;
            this.GetProds_DD061_ValorImposto = GetProds_DD061_ValorImposto ?? 0;
            this.Get_AA144cClassTrib_IS_cclasstrib1 = Get_AA144cClassTrib_IS_cclasstrib1;
            this.Get_AA144cClassTrib_IS_cstibsCbs1 = Get_AA144cClassTrib_IS_cstibsCbs1;
            this.dd060Quantidade = dd060Quantidade;
            this.gg007Unidade = gg007Unidade;
            this.Get_AA144cClassTrib_cclasstrib = Get_AA144cClassTrib_cclasstrib;
            this.Get_AA144cClassTrib_cstibsCbs = Get_AA144cClassTrib_cstibsCbs;
            this.gg021Ncm = gg021Ncm;
            this.dd060Sequencia = dd060Sequencia;
            this.dd061Vicmsufdest =     dd061Vicmsufdest ?? 0m;
            this.dd061Vfcp = dd061Vfcp ?? 0m;
            this.dd061Vfcpufdest = dd061Vfcpufdest ?? 0m;
            this.n39Vicmsmono = n39Vicmsmono ?? 0m;
            this.dd060TotalLiquido = dd060TotalLiquido ?? 0m;
        }
    }
}
