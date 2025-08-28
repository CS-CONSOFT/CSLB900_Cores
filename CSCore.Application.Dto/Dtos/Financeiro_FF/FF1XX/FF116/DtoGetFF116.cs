using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF116
{
    public class DtoGetFF116
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = "";
        public int? Ff116Tipomovto { get; set; }
        public string? Ff116Filialid { get; set; }
        public DateTime? Ff116Datamovto { get; set; }
        public string? Ff116Usuariopropid { get; set; }
        public string? Ff102Tituloid { get; set; }
        public DateTime? Ff116Datavencto { get; set; }
        public DateTime? Ff116Novovencto { get; set; }
        public string? Ff116Protocolnumber { get; set; }
        public decimal? Ff116Vnovovlr { get; set; }
        public decimal? Ff116Vvaloranterior { get; set; }
        public string? Ff116Msg { get; set; }

        // Navegações
        public OsusrE9aCsicpFf116Tmov? NavFF116TMov { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }
        public DtoGetFF102_Exibicao? NavFF102 { get; set; }
    }
}