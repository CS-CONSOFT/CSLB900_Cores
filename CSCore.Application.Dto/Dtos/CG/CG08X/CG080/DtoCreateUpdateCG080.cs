using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG080
{
    public class DtoCreateUpdateCG080 : IConverteParaEntidade<Osusr8dwCsicpCg080>
    {
        public string? Cg080Nome { get; set; }

        public DateTime? Cg080Dtvigenciaini { get; set; }

        public DateTime? Cg080Dtvigenciafim { get; set; }

        public bool? Cg080Isactive { get; set; }

        public bool? Cg080Isprojfromprov { get; set; }

        public Osusr8dwCsicpCg080 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg080
            {
                TenantId = tenant,
                Cg080Nome = Cg080Nome,
                Cg080Dtvigenciaini = Cg080Dtvigenciaini,
                Cg080Dtvigenciafim = Cg080Dtvigenciafim,
                Cg080Isactive = Cg080Isactive,
                Cg080Isprojfromprov = Cg080Isprojfromprov
            };
        }
    }
}