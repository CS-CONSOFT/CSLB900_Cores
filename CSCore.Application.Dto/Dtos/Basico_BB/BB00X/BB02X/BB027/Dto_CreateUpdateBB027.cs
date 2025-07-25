using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB027
{
    public class Dto_CreateUpdateBB027
    {
        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Filial deve ser um número positivo.")]
        public int? Bb027Filial { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Codigo deve ser um número positivo.")]
        public int? Bb027Codigo { get; set; }

        [MaxLength(120, ErrorMessage = "Bb027Descricao não pode ter mais que 120 caracteres.")]
        public string? Bb027Descricao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Baixaestoque deve ser um número positivo.")]
        public int? Bb027Baixaestoque { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Geracreceber deve ser um número positivo.")]
        public int? Bb027Geracreceber { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Atualizaprcompra deve ser um número positivo.")]
        public int? Bb027Atualizaprcompra { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Calcsubstituicao deve ser um número positivo.")]
        public int? Bb027Calcsubstituicao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Calculaiss deve ser um número positivo.")]
        public int? Bb027Calculaiss { get; set; }

        [MaxLength(5, ErrorMessage = "Bb027Cfopdentroestado não pode ter mais que 5 caracteres.")]
        public string? Bb027Cfopdentroestado { get; set; }

        [MaxLength(5, ErrorMessage = "Bb027Cfopforaestado não pode ter mais que 5 caracteres.")]
        public string? Bb027Cfopforaestado { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Agregasubstrib deve ser um número positivo.")]
        public int? Bb027Agregasubstrib { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Difa deve ser um número positivo.")]
        public int? Bb027Difa { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Icst deve ser um número positivo.")]
        public int? Bb027Icst { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Irrf deve ser um número positivo.")]
        public int? Bb027Irrf { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Pis deve ser um número positivo.")]
        public int? Bb027Pis { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Cofins deve ser um número positivo.")]
        public int? Bb027Cofins { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Irpj deve ser um número positivo.")]
        public int? Bb027Irpj { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Icmsdiferido deve ser um número positivo.")]
        public int? Bb027Icmsdiferido { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Geraestatistica deve ser um número positivo.")]
        public int? Bb027Geraestatistica { get; set; }

        [MaxLength(5, ErrorMessage = "Bb027Codgcst não pode ter mais que 5 caracteres.")]
        public string? Bb027Codgcst { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Transdevolucao deve ser um número positivo.")]
        public int? Bb027Transdevolucao { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor de Bb027Reducaoicms deve ser um número positivo.")]
        public decimal? Bb027Reducaoicms { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor de Bb027Reducaoipi deve ser um número positivo.")]
        public decimal? Bb027Reducaoipi { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor de Bb027Reducaoicmsst deve ser um número positivo.")]
        public decimal? Bb027Reducaoicmsst { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor de Bb027Reducaoiss deve ser um número positivo.")]
        public decimal? Bb027Reducaoiss { get; set; }

        [MaxLength(36, ErrorMessage = "Empresaid não pode ter mais que 36 caracteres.")]
        public string? Empresaid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027EntsaiId deve ser um número positivo.")]
        public int? Bb027EntsaiId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027PodertercId deve ser um número positivo.")]
        public int? Bb027PodertercId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CalcicmsId deve ser um número positivo.")]
        public int? Bb027CalcicmsId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CalcipiId deve ser um número positivo.")]
        public int? Bb027CalcipiId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027SomaipiBaseicmsId deve ser um número positivo.")]
        public int? Bb027SomaipiBaseicmsId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027IpiBrutoId deve ser um número positivo.")]
        public int? Bb027IpiBrutoId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027BaseicmsbrutaliqId deve ser um número positivo.")]
        public int? Bb027BaseicmsbrutaliqId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027BasesubsbrutaliqId deve ser um número positivo.")]
        public int? Bb027BasesubsbrutaliqId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CfopStaticaId deve ser um número positivo.")]
        public int? Bb027CfopStaticaId { get; set; }

        [MaxLength(36, ErrorMessage = "Bb027TdevolucaoId não pode ter mais que 36 caracteres.")]
        public string? Bb027TdevolucaoId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027RegimeId deve ser um número positivo.")]
        public int? Bb027RegimeId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CfopForaestadoId deve ser um número positivo.")]
        public int? Bb027CfopForaestadoId { get; set; }

        [MaxLength(36, ErrorMessage = "Bb027Hashid não pode ter mais que 36 caracteres.")]
        public string? Bb027Hashid { get; set; }

        [MaxLength(100, ErrorMessage = "Bb027Descnatoper não pode ter mais que 100 caracteres.")]
        public string? Bb027Descnatoper { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CalcajusteicmsId deve ser um número positivo.")]
        public int? Bb027CalcajusteicmsId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027CodgajusteicmsId deve ser um número positivo.")]
        public int? Bb027CodgajusteicmsId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Bb027Icmsdiferidoid deve ser um número positivo.")]
        public int? Bb027Icmsdiferidoid { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor de Bb027PicmsDiferido deve ser um número positivo.")]
        public decimal? Bb027PicmsDiferido { get; set; }
    }
}
