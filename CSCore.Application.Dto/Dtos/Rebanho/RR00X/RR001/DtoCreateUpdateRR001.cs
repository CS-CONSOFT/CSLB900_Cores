using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001
{
    public class DtoCreateUpdateRR001 : IConverteParaEntidade<OsusrTo3CsicpRr001>
    {
        public string? Rr001Serie { get; set; }

        public int? Rr001Nrorgn { get; set; }

        public string? Rr001Nomeanimal { get; set; }

        public string? Rr001Apelido { get; set; }

        public DateTime? Rr001Dtnascimento { get; set; }

        public decimal? Rr001Pesonasc { get; set; }

        public int? Rr001Sexoid { get; set; }

        public string? Rr001Fazendaid { get; set; }

        public long? Rr001Catid { get; set; }

        public long? Rr001Racaid { get; set; }

        public string? Rr001PaiId { get; set; }

        public string? Rr001MaeId { get; set; }

        public int? Rr001Ativoid { get; set; }

        public long? Rr001Situacaoid { get; set; }

        public DateTime? Rr001Dtregistro { get; set; }

        public string? Rr001Usuariopropid { get; set; }

        public string? Rr001Observacao { get; set; }

        public int? Rr001Categoriaid { get; set; }

        public DateTime? Rr001Dtcategoria { get; set; }

        public long? Rr001Ocorrenciaid { get; set; }

        public DateTime? Rr001Dtocorrencia { get; set; }

        public DateTime? Rr001Dtultpeso { get; set; }

        public decimal? Rr001Ultpeso { get; set; }

        public int? Rr001Ultidadediaspeso { get; set; }

        public long? Rr001Proprietarioid { get; set; }

        public OsusrTo3CsicpRr001 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr001
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr001Serie = Rr001Serie,
                Rr001Nrorgn = Rr001Nrorgn,
                Rr001Nomeanimal = Rr001Nomeanimal,
                Rr001Apelido = Rr001Apelido,
                Rr001Dtnascimento = Rr001Dtnascimento,
                Rr001Pesonasc = Rr001Pesonasc,
                Rr001Sexoid = Rr001Sexoid,
                Rr001Fazendaid = Rr001Fazendaid,
                Rr001Catid = Rr001Catid,
                Rr001Racaid = Rr001Racaid,
                Rr001PaiId = Rr001PaiId,
                Rr001MaeId = Rr001MaeId,
                Rr001Ativoid = Rr001Ativoid,
                Rr001Situacaoid = Rr001Situacaoid,
                Rr001Dtregistro = Rr001Dtregistro,
                Rr001Usuariopropid = Rr001Usuariopropid,
                Rr001Observacao = Rr001Observacao,
                Rr001Categoriaid = Rr001Categoriaid,
                Rr001Dtcategoria = Rr001Dtcategoria,
                Rr001Ocorrenciaid = Rr001Ocorrenciaid,
                Rr001Dtocorrencia = Rr001Dtocorrencia,
                Rr001Dtultpeso = Rr001Dtultpeso,
                Rr001Ultpeso = Rr001Ultpeso,
                Rr001Ultidadediaspeso = Rr001Ultidadediaspeso,
                Rr001Proprietarioid = Rr001Proprietarioid
            };
        }
    }
}
