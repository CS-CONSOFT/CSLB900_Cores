using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008RFTransacao
{
    public class DtoGetGG008RFTransacao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg008tTiporegistro { get; set; }

        public string? Gg008tFilialid { get; set; }

        public string? Gg008tKardexId { get; set; }

        public string? Gg008tNcmId { get; set; }

        public string? Gg008tTransacaoid { get; set; }
    }
}
