using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG060
{
    public class DtoUpdateGG060 : IConverteParaEntidade<CSICP_GG060>
    {
        public string? Gg060EstabId { get; set; }

        public string? Gg060Grupoid { get; set; }

        public string? Gg060Subgrupoid { get; set; }

        public decimal? Gg060Plucro { get; set; }

        public decimal? Gg060Pmaxdesconto { get; set; }

        public bool? Gg060Ispadrao { get; set; }

        public CSICP_GG060 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG060
            {
                TenantId = tenant,
                Gg060Id = int.Parse(id!),
                Gg060EstabId = this.Gg060EstabId,
                Gg060Grupoid = this.Gg060Grupoid,
                Gg060Subgrupoid = this.Gg060Subgrupoid,
                Gg060Plucro = this.Gg060Plucro,
                Gg060Isactive = true,
                Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                Gg060Pmaxdesconto = this.Gg060Pmaxdesconto,
                Gg060Ispadrao = this.Gg060Ispadrao
            };

        }
    }
}
