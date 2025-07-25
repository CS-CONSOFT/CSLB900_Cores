using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace GG104Materiais.C82Application.Dto.GG00X.GG008.GG008p
{
    public class DtoCreateUpdateGG008p : IConverteParaEntidade<CSICP_GG008p>
    {
        public decimal? Gg008pPrecoBase { get; set; }

        public decimal? Gg008pPercVenda1 { get; set; }

        public decimal? Gg008pPrecoVenda1 { get; set; }

        public decimal? Gg008pPercVenda2 { get; set; }

        public decimal? Gg008pPrecoVenda2 { get; set; }

        public decimal? Gg008pPercVenda3 { get; set; }

        public decimal? Gg008pPrecoVenda3 { get; set; }

        public decimal? Gg008pPercVenda4 { get; set; }

        public decimal? Gg008pPrecoVenda4 { get; set; }

        public decimal? Gg008pPercVenda5 { get; set; }

        public decimal? Gg008pPrecoVenda5 { get; set; }

        public decimal? Gg008pPercVenda6 { get; set; }

        public decimal? Gg008pPrecoVenda6 { get; set; }

        public decimal? Gg008pPercVenda7 { get; set; }

        public decimal? Gg008pPrecoVenda7 { get; set; }

        public decimal? Gg008pPercVenda8 { get; set; }

        public decimal? Gg008pPrecoVenda8 { get; set; }

        public decimal? Gg008pPercVenda9 { get; set; }

        public decimal? Gg008pPrecoVenda9 { get; set; }

        public CSICP_GG008p ToEntity(int tenant, string? id)
        {
            return new CSICP_GG008p
            {
                Gg008Id = id!,
                TenantId = tenant,
                Gg008pPrecoBase = this.Gg008pPrecoBase,
                Gg008pPercVenda1 = this.Gg008pPercVenda1,
                Gg008pPrecoVenda1 = this.Gg008pPrecoVenda1,
                Gg008pPercVenda2 = this.Gg008pPercVenda2,
                Gg008pPrecoVenda2 = this.Gg008pPrecoVenda2,
                Gg008pPercVenda3 = this.Gg008pPercVenda3,
                Gg008pPrecoVenda3 = this.Gg008pPrecoVenda3,
                Gg008pPercVenda4 = this.Gg008pPercVenda4,
                Gg008pPrecoVenda4 = this.Gg008pPrecoVenda4,
                Gg008pPercVenda5 = this.Gg008pPercVenda5,
                Gg008pPrecoVenda5 = this.Gg008pPrecoVenda5,
                Gg008pPercVenda6 = this.Gg008pPercVenda6,
                Gg008pPrecoVenda6 = this.Gg008pPrecoVenda6,
                Gg008pPercVenda7 = this.Gg008pPercVenda7,
                Gg008pPrecoVenda7 = this.Gg008pPrecoVenda7,
                Gg008pPercVenda8 = this.Gg008pPercVenda8,
                Gg008pPrecoVenda8 = this.Gg008pPrecoVenda8,
                Gg008pPercVenda9 = this.Gg008pPercVenda9,
                Gg008pPrecoVenda9 = this.Gg008pPrecoVenda9,
            };
        }
    }
}

