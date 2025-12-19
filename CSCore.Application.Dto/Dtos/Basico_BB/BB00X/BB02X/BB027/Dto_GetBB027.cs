using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSBS101._82Application.Dto.BB00X.BB027
{
    public class Dto_GetBB027
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb027Filial { get; set; }

        public int? Bb027Codigo { get; set; }

        public string? Bb027Descricao { get; set; }

        public int? Bb027Baixaestoque { get; set; }
        
        public int? Bb027Geracreceber { get; set; }

        public int? Bb027Atualizaprcompra { get; set; }

        public int? Bb027Calcsubstituicao { get; set; }

        public int? Bb027Calculaiss { get; set; }

        public string? Bb027Cfopdentroestado { get; set; }

        public string? Bb027Cfopforaestado { get; set; }

        public int? Bb027Agregasubstrib { get; set; }

        public int? Bb027Difa { get; set; }

        public int? Bb027Icst { get; set; }

        public int? Bb027Irrf { get; set; }

        public int? Bb027Pis { get; set; }

        public int? Bb027Cofins { get; set; }

        public int? Bb027Irpj { get; set; }

        public int? Bb027Icmsdiferido { get; set; }

        public int? Bb027Geraestatistica { get; set; }

        public string? Bb027Codgcst { get; set; }

        public int? Bb027Transdevolucao { get; set; }

        public decimal? Bb027Reducaoicms { get; set; }

        public decimal? Bb027Reducaoipi { get; set; }

        public decimal? Bb027Reducaoicmsst { get; set; }

        public decimal? Bb027Reducaoiss { get; set; }

        public string? Empresaid { get; set; }

        public int? Bb027EntsaiId { get; set; }

        public int? Bb027PodertercId { get; set; }

        public int? Bb027CalcicmsId { get; set; }

        public int? Bb027CalcipiId { get; set; }

        public int? Bb027SomaipiBaseicmsId { get; set; }

        public int? Bb027IpiBrutoId { get; set; }

        public int? Bb027BaseicmsbrutaliqId { get; set; }

        public int? Bb027BasesubsbrutaliqId { get; set; }

        public int? Bb027CfopStaticaId { get; set; }

        public string? Bb027TdevolucaoId { get; set; }

        public int? Bb027RegimeId { get; set; }

        public int? Bb027CfopForaestadoId { get; set; }

        public string? Bb027Hashid { get; set; }

        public string? Bb027Descnatoper { get; set; }

        public int? Bb027CalcajusteicmsId { get; set; }

        public int? Bb027CodgajusteicmsId { get; set; }

        public int? Bb027Icmsdiferidoid { get; set; }

        public decimal? Bb027PicmsDiferido { get; set; }

        public int? BB027_CalcIS_ID { get; set; }

        public CSICP_Statica? NavBB027BaixaEstoque { get; set; }
        public CSICP_Statica? NavBB027GeraCReceber { get; set; }
        public CSICP_Statica? NavBB027AtualizaPrCompra { get; set; }
        public CSICP_Statica? NavBB027CalcSubstituicao { get; set; }
        public CSICP_Statica? NavBB027CalculaISS { get; set; }
        public CSICP_Statica? NavBB027AgregaSubsTrib { get; set; }
        public CSICP_Statica? NavBB027DIFA { get; set; }
        public CSICP_Statica? NavBB027ICST { get; set; }
        public CSICP_Statica? NavBB027IRRF { get; set; }
        public CSICP_Statica? NavBB027PIS { get; set; }
        public CSICP_Statica? NavBB027COFINS { get; set; }
        public CSICP_Statica? NavBB027IRPJ { get; set; }
        public CSICP_Statica? NavBB027ICMSDiferido { get; set; }
        public CSICP_Statica? NavBB027GeraEstatistica { get; set; }
        public CSICP_Statica? NavBB027CalcAjusteICMS { get; set; }
        public CSICP_Statica? NavBB027CalcIS { get; set; }

        // Navegações para outras tabelas BB027
        public CSICP_Bb027Entsai? NavBB027Entsai { get; set; }
        public CSICP_Bb027Cicm? NavBB027CalcICMS { get; set; }
        public CSICP_Bb027Cicm? NavBB027CalcIPI { get; set; }
        public CSICP_Bb027Sipi? NavBB027SomaIPIBaseICMS { get; set; }
        public CSICP_Bb027Bcalc? NavBB027IPIBruto { get; set; }
        public CSICP_Bb027Bcalc? NavBB027BaseICMSBrutaLiq { get; set; }
        public CSICP_Bb027Bcalc? NavBB027BaseSubsBrutaLiq { get; set; }

        // Navegações para SPED
        public Osusr66cSpedInCfop? NavBB027CFOPStatica { get; set; }
        public Osusr66cSpedInCfop? NavBB027CFOPForaEstado { get; set; }
        public Osusr66cSpedInCodAjuste? NavBB027CodgAjusteICMS { get; set; }

        // Navegação auto-relacionamento
        public DtoGetBB027SemNavs? NavBB027Tdevolucao { get; set; }

        // Navegação para Regime
        public CSICP_AA030Regime? NavAA030_BB027Regime { get; set; }

    }
}
