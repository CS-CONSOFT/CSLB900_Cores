using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR030;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR035;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031
{
    public class DtoGetRR031Timeline
    {
        // Dados completos da RR031
        public int TenantId { get; set; }
        public string? Id { get; set; }
        public string? Rr031IatfId { get; set; }
        public string? Rr031Animalid { get; set; }
        public DateTime? Rr031Dtregistro { get; set; }
        public bool? Rr031Ispositivo { get; set; }
        public string? Rr031Montaanimalid { get; set; }
        public string? Rr031Semenid { get; set; }
        public int? Rr031Tiporeg { get; set; }
        public bool? Rr031Isabsorveu { get; set; }

        // Usando DTOs Padrao para evitar ciclos infinitos
        public DtoGetRR030? RR030Header { get; set; }
        public DtoGetRR001Padrao? Animal { get; set; }
        public DtoGetRR001Padrao? AnimalMonta { get; set; }
        public DtoGetRR035Padrao? Semen { get; set; }
    }
}