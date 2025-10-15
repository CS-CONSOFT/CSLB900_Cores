using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR002
{
    public class DtoCreateUpdateRR002 : IConverteParaEntidade<OsusrTo3CsicpRr002>
    {
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

        public OsusrTo3CsicpRr002 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr002
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr002Nomefazenda = Rr002Nomefazenda,
                Rr002Cnpj = Rr002Cnpj,
                Rr002Endereco = Rr002Endereco,
                Rr002Nroender = Rr002Nroender,
                Rr002Complemento = Rr002Complemento,
                Rr002Bairro = Rr002Bairro,
                Rr002Cep = Rr002Cep,
                Rr002Paisid = Rr002Paisid,
                Rr002Cidadeid = Rr002Cidadeid,
                Rr002Ufid = Rr002Ufid
            };
        }
    }
}