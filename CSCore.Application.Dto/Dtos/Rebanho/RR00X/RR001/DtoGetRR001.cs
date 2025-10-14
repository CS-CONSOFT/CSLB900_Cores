using CSCore.Domain.CS_Models.CSICP_RR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001
{
    public class DtoGetRR001
    {
        public DtoGetRR001(OsusrTo3CsicpRr001 entity)
        {
            TenantId = entity.TenantId;
            Id = entity.Id;
            Rr001Serie = entity.Rr001Serie;
            Rr001Nrorgn = entity.Rr001Nrorgn;
            Rr001Nomeanimal = entity.Rr001Nomeanimal;
            Rr001Apelido = entity.Rr001Apelido;
            Rr001Dtnascimento = entity.Rr001Dtnascimento;
            Rr001Pesonasc = entity.Rr001Pesonasc;
            Rr001Sexoid = entity.Rr001Sexoid;
            Rr001Fazendaid = entity.Rr001Fazendaid;
            Rr001Catid = entity.Rr001Catid;
            Rr001Racaid = entity.Rr001Racaid;
            Rr001PaiId = entity.Rr001PaiId;
            Rr001MaeId = entity.Rr001MaeId;
            Rr001Ativoid = entity.Rr001Ativoid;
            Rr001Situacaoid = entity.Rr001Situacaoid;
            Rr001Dtregistro = entity.Rr001Dtregistro;
            Rr001Usuariopropid = entity.Rr001Usuariopropid;
            Rr001Observacao = entity.Rr001Observacao;
            Rr001Categoriaid = entity.Rr001Categoriaid;
            Rr001Dtcategoria = entity.Rr001Dtcategoria;
            Rr001Ocorrenciaid = entity.Rr001Ocorrenciaid;
            Rr001Dtocorrencia = entity.Rr001Dtocorrencia;
            Rr001Dtultpeso = entity.Rr001Dtultpeso;
            Rr001Ultpeso = entity.Rr001Ultpeso;
            Rr001Ultidadediaspeso = entity.Rr001Ultidadediaspeso;
            Rr001Proprietarioid = entity.Rr001Proprietarioid;
            NavRR001Ativo = entity.NavRR001Ativo;
            NavRR001Cat = entity.NavRR001Cat;
            NavRR001Categoria = entity.NavRR001Categoria;
            NavRR001Fazenda = entity.NavRR001Fazenda;
            NavRR001Mae = entity.NavRR001Mae;
            NavRR001Ocorrencia = entity.NavRR001Ocorrencia;
            NavRR001Pai = entity.NavRR001Pai;
            NavRR001Proprietario = entity.NavRR001Proprietario;
            NavRR001Raca = entity.NavRR001Raca;
            NavRR001Sexo = entity.NavRR001Sexo;
            NavRR001Situacao = entity.NavRR001Situacao;
        }

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

        //NavsGetList
        public OsusrTo3CsicpRr001Ativo? NavRR001Ativo { get; set; }
        public OsusrTo3CsicpRr003? NavRR001Cat { get; set; }
        public OsusrTo3CsicpRr001Cat? NavRR001Categoria { get; set; }
        public OsusrTo3CsicpRr002? NavRR001Fazenda { get; set; }
        public OsusrTo3CsicpRr001? NavRR001Mae { get; set; }
        public OsusrTo3CsicpRr006? NavRR001Ocorrencia { get; set; }
        public OsusrTo3CsicpRr001? NavRR001Pai { get; set; }
        public OsusrTo3CsicpRr007? NavRR001Proprietario { get; set; }
        public OsusrTo3CsicpRr004? NavRR001Raca { get; set; }
        public OsusrTo3CsicpRr001Sexo? NavRR001Sexo { get; set; }
        public OsusrTo3CsicpRr005? NavRR001Situacao { get; set; }
    }
}
