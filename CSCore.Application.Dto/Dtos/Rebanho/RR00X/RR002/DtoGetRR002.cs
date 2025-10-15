using CSBS101._82Application.Dto.AA00X;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA028;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR002
{
    public class DtoGetRR002
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr002Nomefazenda { get; set; }

        public string? Rr002Cnpj { get; set; }

        public string? Rr002Endereco { get; set; }

        public string? Rr002Nroender { get; set; }

        public string? Rr002Complemento { get; set; }

        public string? Rr002Bairro { get; set; }

        public int? Rr002Cep { get; set; }

        public string? Rr002Paisid { get; set; }

        public string? Rr002Cidadeid { get; set; }

        public string? Rr002Ufid { get; set; }

        public DtoGetAA028_Simples? NavAA028Cidade { get; set; }
        public DtoGetAA027_Simples? NavAA027UF { get; set; }
        public Dto_GetAA025? NavAA025Pais { get; set; }
    }
}