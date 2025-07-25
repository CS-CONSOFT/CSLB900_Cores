using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.Extensao;

namespace GG104Materiais.C82Application.Dto.GG00X.GG004
{
    public class DtoCreateUpdateGG004 : IConverteParaEntidade<CSICP_GG004>
    {
        public int? Gg004Filial { get; set; }

        public string? Gg004Filialid { get; set; }

        public int? Gg004Codigoclasse { get; set; }

        public string? Gg004Descclasse { get; set; }
        public bool? Gg004Isactive { get; set; }
        public CSICP_GG004 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_GG004
            {
                TenantId = tenant,
                Id = id!,
                Gg004Filial = this.Gg004Filial,
                Gg004Filialid = this.Gg004Filialid,
                Gg004Codigoclasse = this.Gg004Codigoclasse,
                Gg004Descclasse = this.Gg004Descclasse,
                Gg004Isactive = Gg004Isactive,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

