using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG001;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG071
{
    public class DtoGetGG071
    {
        public int TenantId { get; set; }

        public long Gg071Id { get; set; }

        
        public string? Gg071Estabid { get; set; }
        public Dto_GetBB001Simples? NavBB001Estab { get; set; }

        public string? Gg071Protocolnumber { get; set; }

        public DateTime? Gg071DataMovimento { get; set; }

        
        public string? Gg071Usuarioid { get; set; }
        public Dto_GetSY001Simples? NavUsuarioProprietarioSY001 { get; set; }

        public string? Gg071Observacao { get; set; }

        
        public string? Gg071Ccustoid { get; set; }
        public Dto_GetBB005_Exibicao? NavBB005CentroCusto { get; set; }

        public string? Gg071NoDocto { get; set; }

        
        public int? Gg071Statusid { get; set; }
        public OsusrE9aCsicpGg071Stum? NavGG071Status { get; set; }


        public string? Dd070Id { get; set; }

        
        public string? Gg071Almoxsaidaid { get; set; }
        public DtoGetGG001Simples? NavGg071Almoxsaida { get; set; }


        
        public string? Gg071Almoxentid { get; set; }
        public DtoGetGG001Simples? NavGg071Almoxent { get; set; }


        
        public string? Gg071AtendenteUsuarioid { get; set; }
        public Dto_GetSY001Simples? NavAtendenteUsuarioSY001 { get; set; }

        public DateTime? Gg071Datendimento { get; set; }


        
        public int? Gg071Tpreqid { get; set; }
        public OsusrE9aCsicpGg041Tpreq? NavGG071TipoReq { get; set; }

        public DateTime? Gg071Dhsolicitacao { get; set; }
    }
}
