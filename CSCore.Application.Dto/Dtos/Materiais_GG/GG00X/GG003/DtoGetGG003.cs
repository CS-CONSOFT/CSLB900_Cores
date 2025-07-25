using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG060;

namespace GG104Materiais.C82Application.Dto.GG00X.GG003
{
    public class DtoGetGG003
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg003Filial { get; set; }

        public string? Gg003Filialid { get; set; }

        public int? Gg003Codigogrupo { get; set; }

        public string? Gg003Descgrupo { get; set; }

        public decimal? Gg003Plucro { get; set; }

        public bool? Gg003Isactive { get; set; }

        public bool? Gg003Isvisivelcompra { get; set; }

        public bool? Gg003Isvisivelvenda { get; set; }

        public int? Gg003Ordemconsulta { get; set; }

        public string? Gg003Iconegrupoproduto { get; set; }

        public bool? Gg003Isexibepdv { get; set; }
        public List<DtoGetGG060ParaGG003> Nav_List_GG060_SemEstabelecimento { get; set; } = [];
        public IEnumerable<DtoGetGG060ParaGG003> Nav_List_GG060_ComEstabelecimento { get; set; } = [];
    }

    public class DtoGetGG003_Exibicao_2
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg003Filial { get; set; }

        public string? Gg003Filialid { get; set; }

        public int? Gg003Codigogrupo { get; set; }

        public string? Gg003Descgrupo { get; set; }

        public decimal? Gg003Plucro { get; set; }

        public bool? Gg003Isactive { get; set; }

        public bool? Gg003Isvisivelcompra { get; set; }

        public bool? Gg003Isvisivelvenda { get; set; }

        public int? Gg003Ordemconsulta { get; set; }

        public string? Gg003Iconegrupoproduto { get; set; }

        public bool? Gg003Isexibepdv { get; set; }
    }


    public class DtoGetGG003_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg003Codigogrupo { get; set; }
        public string? Gg003Descgrupo { get; set; }

    }
}
