using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG005;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG006;
using CSCore.Application.Dto.Dtos.CG.CG011;
using CSCore.Application.Dto.Dtos.CG.CG05X.CG054;
using CSCore.Application.Dto.Dtos.CG.CG06X.CG060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG062
{
    public class DtoGetCG062
    {
        public int TenantId { get; set; }

        public long Cg062Id { get; set; }

        public long? Cg062Regramentoid { get; set; }

        public long? Cg062Eventovalortpid { get; set; }

        public string? Cg062Contadebid { get; set; }

        public string? Cg062Histdebid { get; set; }

        public string? Cg062Contacredid { get; set; }

        public string? Cg062Histcredid { get; set; }

        public long? Cg062Eventovalortpdebid { get; set; }

        public long? Cg062Eventovalortpcredid { get; set; }

        public bool? Cg062Isignorevalor { get; set; }

        public string? Cg062CtagerencialDebn2Id { get; set; }

        public string? Cg062CtagerencialDebn3Id { get; set; }

        public string? Cg062CtagerencialDebn4Id { get; set; }

        public string? Cg062CtagerencialCren2Id { get; set; }

        public string? Cg062CtagerencialCren3Id { get; set; }

        public string? Cg062CtagerencialCren4Id { get; set; }

        public DtoGetCG005? NavCG005HistDeb_CG062 { get; set; }

        public DtoGetCG005? NavCG005HistCred_CG062 { get; set; }

        public DtoGetCG006? NavCG006ContaDeb_CG062 { get; set; }

        public DtoGetCG006? NavCG006ContaCred_CG062 { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_DebN2ID { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_DebN3ID { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_DebN4ID { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_CredN2ID { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_CredN3ID { get; set; }

        public DtoGetCG011? NavCG011CtaGerencial_CredN4ID { get; set; }

        public DtoGetCG060? NavCG060RegramentoID_CG062 { get; set; }

        public DtoGetCG054? NavCG054EventoValorTpID_CG062 { get; set; }

        public DtoGetCG054? NavCG054EventoValorTpDebID_CG062 { get; set; }

        public DtoGetCG054? NavCG054EventoValorTpCredID_CG062 { get; set; }
    }
}