using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF012
{
    public class DtoCreateUpdateFF012 : IConverteParaEntidade<CSICP_FF012>
    {
        public string? Ff012Filialid { get; set; }
        public int? Ff012CodigoGrupo { get; set; }
        public string? Ff012DescricaoGrupo { get; set; }
        public string? Ff012Usuariosuperid { get; set; }
        public string? Ff014Comissaosuperid { get; set; }
        public string? Ff014Comissaocobradorid { get; set; }
        public string? Ff012Grupopaiid { get; set; }

        public CSICP_FF012 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_FF012
            {
                TenantId = tenant,
                Id = id ?? "",
                Ff012Filialid = Ff012Filialid,
                Ff012CodigoGrupo = Ff012CodigoGrupo,
                Ff012DescricaoGrupo = Ff012DescricaoGrupo,
                Ff012Usuariosuperid = Ff012Usuariosuperid,
                Ff014Comissaosuperid = Ff014Comissaosuperid,
                Ff014Comissaocobradorid = Ff014Comissaocobradorid,
                Ff012Grupopaiid = Ff012Grupopaiid
            };
            return entity;
        }
    }
}