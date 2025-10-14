using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG003
{
    public class DtoCreateUpdateGG003 : IConverteParaEntidade<CSICP_GG003>
    {
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

        public CSICP_GG003 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG003
            {
                TenantId = tenant,
                Id = id!,
                Gg003Filial = Gg003Filial,
                Gg003Filialid = Gg003Filialid,
                Gg003Codigogrupo = Gg003Codigogrupo,
                Gg003Descgrupo = Gg003Descgrupo,
                Gg003Plucro = Gg003Plucro,
                Gg003Isactive = Gg003Isactive,
                Gg003Isvisivelcompra = Gg003Isvisivelcompra,
                Gg003Isvisivelvenda = Gg003Isvisivelvenda,
                Gg003Ordemconsulta = Gg003Ordemconsulta,
                Gg003Iconegrupoproduto = Gg003Iconegrupoproduto,
                Gg003Isexibepdv = Gg003Isexibepdv,
            };
        }
    }
}
