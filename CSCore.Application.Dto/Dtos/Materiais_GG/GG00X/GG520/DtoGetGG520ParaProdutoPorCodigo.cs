using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx;
using GG104Materiais.C82Application.Dto.GG00X.GG008.GG008Kdx;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520
{
    public class DtoGetGG520ParaProdutoPorCodigo
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg520Filialid { get; set; }

        public string? Gg520KardexId { get; set; }

        public string? Gg520Almoxid { get; set; }

        public decimal? Gg520NsNumerosaldo { get; set; }

        public string? Gg520Descricaosaldo { get; set; }

        public int? Gg520Filial { get; set; }

        public int? Gg520Codalmoxarifado { get; set; }

        public int? Gg520Produto { get; set; }

        public decimal? Gg520Saldo { get; set; }

        public DtoGetGG008Kdx_Exibicao? NavGG008Kdx { get; set; }
    }

    public class DtoGetGG520ParaProdutoPorCodigo_ComDoisSaldos
    {
        public IEnumerable<DtoGetGG520ParaProdutoPorCodigo> List_Saldos_Almoxarifado1 { get; set; } = [];
        public IEnumerable<DtoGetGG520ParaProdutoPorCodigo> List_Saldos_Almoxarifado2 { get; set; } = [];

        public DtoGetGG520ParaProdutoPorCodigo_ComDoisSaldos(
            IEnumerable<DtoGetGG520ParaProdutoPorCodigo> list_Saldos_Almoxarifado1,
            IEnumerable<DtoGetGG520ParaProdutoPorCodigo> list_Saldos_Almoxarifado2)
        {
            List_Saldos_Almoxarifado1 = list_Saldos_Almoxarifado1;
            List_Saldos_Almoxarifado2 = list_Saldos_Almoxarifado2;
        }
    }
}
