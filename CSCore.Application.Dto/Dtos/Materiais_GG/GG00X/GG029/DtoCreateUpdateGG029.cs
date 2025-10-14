using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG029
{
    public class DtoCreateUpdateGG029 : IConverteParaEntidade<CSICP_GG029>
    {

        public string? Gg029Codganp { get; set; }

        public string? Gg029Descricao { get; set; }

        public string? Gg029Codif { get; set; }

        public decimal? Gg029Pmixgn { get; set; }

        public decimal? Gg029Pglp { get; set; }

        public decimal? Gg029Pgnn { get; set; }

        public decimal? Gg029Pgni { get; set; }

        public decimal? Gg029Vpart { get; set; }

        public decimal? Gg029Adremicms { get; set; }

        public decimal? Gg029Pbio { get; set; }

        public decimal? Gg029AdremicmsBio { get; set; }

        public CSICP_GG029 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG029
            {
                TenantId = tenant,
                Gg029Id = id!,
                Gg029Codganp = this.Gg029Codganp,
                Gg029Descricao = this.Gg029Descricao,
                Gg029Codif = this.Gg029Codif,
                Gg029Pmixgn = this.Gg029Pmixgn,
                Gg029Pglp = this.Gg029Pglp,
                Gg029Pgnn = this.Gg029Pgnn,
                Gg029Pgni = this.Gg029Pgni,
                Gg029Vpart = this.Gg029Vpart,
                Gg029Adremicms = this.Gg029Adremicms,
                Gg029Pbio = this.Gg029Pbio,
                Gg029AdremicmsBio = this.Gg029AdremicmsBio,
            };
        }
    }
}

