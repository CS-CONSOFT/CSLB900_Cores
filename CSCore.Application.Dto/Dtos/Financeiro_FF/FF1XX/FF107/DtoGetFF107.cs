using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002;
using CSCore.Application.Dto.Dtos.Sistema;
using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF107
{
    public class DtoGetFF107
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public int? Ff107Tpregistro { get; set; }
        public string? Ff107Filialid { get; set; }
        public int? Ff107Filial { get; set; }
        public string? Ff102Tituloid { get; set; }
        public string? Ff107Pfx { get; set; }
        public decimal? Ff107Titulo { get; set; }
        public string? Ff107Sfx { get; set; }
        public int? Ff107Codgcliforn { get; set; }
        public string? Ff107Tipolctocontabil { get; set; }
        public string? Ff107Tipomovto { get; set; }
        public DateTime? Ff107Datamovto { get; set; }
        public string? Ff107Usuarioproprid { get; set; }
        public int? Ff107Responsavel { get; set; }
        public string? Ff107Motivoid { get; set; }
        public int? Ff107Codgmotivo { get; set; }
        public string? Ff107Descmotivo { get; set; }
        public decimal? Ff107Valor { get; set; }
        public string? Ff107Observacao { get; set; }
        public string? Ff107Protocolnumber { get; set; }

        // Navegações
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public DtoGetFF102_Exibicao? NavFF102 { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }
        public DtoGetFF002Simples? NavFF002 { get; set; }
    }
}