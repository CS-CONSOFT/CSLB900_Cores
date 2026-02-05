using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR002;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR003;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR004;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR005;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR006;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR007;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_RR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001
{
    public class DtoGetRR001
    {

        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

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

        public long? Rr001Proprietario2id { get; set; }

        public long? Rr001Criadorid { get; set; }

        //NavsGetList
        public DtoGetRR001Padrao? NavRR001Pai { get; set; }
        public DtoGetRR001Padrao? NavRR001Mae { get; set; }
        public DtoGetRR002Padrao? NavRR001Fazenda { get; set; }
        public DtoGetRR003? NavRR001Cat { get; set; }
        public DtoGetRR004? NavRR001Raca { get; set; }
        public DtoGetRR005? NavRR001Situacao { get; set; }
        public DtoGetRR006? NavRR001Ocorrencia { get; set; }
        public DtoGetRR007? NavRR001Proprietario { get; set; }
        public OsusrTo3CsicpRr001Ativo? NavRR001Ativo { get; set; }
        public OsusrTo3CsicpRr001Cat? NavRR001Categoria { get; set; }
        public OsusrTo3CsicpRr001Sexo? NavRR001Sexo { get; set; }
        public Dto_GetSY001Simples? NavSy001 { get; set; }

        public OsusrTo3CsicpRr007? NavRR007Proprietario2id_RR001 { get; set; }
        public OsusrTo3CsicpRr007? NavRR001Criadorid_RR001 { get; set; }


    }
}
