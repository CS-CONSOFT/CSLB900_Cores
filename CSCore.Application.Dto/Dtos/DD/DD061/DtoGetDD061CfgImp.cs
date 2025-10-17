using CSBS101._82Application.Dto.BB00X.BB027;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.Staticas.AA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD061
{
    public class DtoGetDD061CfgImp
    {
        public int TenantId { get; set; }

        public string Dd060Id { get; set; } = null!;

        public string? Dd061Bb027Id { get; set; }

        public string? Dd061Bb027bCfgimpId { get; set; }

        public string? Dd061Bb027bCodgcst { get; set; }

        public int? Dd061Bb027bRegimeId { get; set; }

        public int? Dd061Bb027bOrigemId { get; set; }

        public int? Dd061Bb027bCstIcmsId { get; set; }

        public int? Dd061Bb027bCstIpiId { get; set; }

        public int? Dd061Bb027bCstPisId { get; set; }

        public int? Dd061NatBcCredPis { get; set; }

        public int? Dd061Bb027bCstCofinsId { get; set; }

        public int? Dd061NatBcCredCofins { get; set; }

        public string? Dd061Bb027bInfornf { get; set; }

        public string? Dd061Bb027bInforipi { get; set; }

        public string? Dd061Bb027bInforpis { get; set; }

        public string? Dd061Bb027bInforcofins { get; set; }

        public int? Dd061Bb027bModbcId { get; set; }

        public int? Dd061Bb027bMotdesoneracao { get; set; }

        public string? Dd061Bb027bUfDestId { get; set; }

        public int? Dd061Bb027bClassecontaId { get; set; }

        public int? Dd061Bb027bCfopStaticaId { get; set; }

        public int? Dd061Bb027bModalbcIcmsSt { get; set; }

        public decimal? Dd061Bb027bAliquota { get; set; }

        public decimal? Dd061Bb027bReducaobase { get; set; }

        public int? Dd061Bb027bMp255Id { get; set; }

        public decimal? Dd061Bb027bReducaobcst { get; set; }

        public int? Dd061Bb027CfopId { get; set; }

        public int? Dd061Bb027bCfopExcecaoId { get; set; }

        public int? Dd061Bb027bCenquadIpiId { get; set; }

        public decimal? Dd061Bb027bAliqInternauf { get; set; }

        public int? Dd061Bb027bIndpres { get; set; }

        //---------Reforma Tributária----------//
        public long? Ub13Ub14RfclasstribId { get; set; }
        public string? Dd061RflcId { get; set; }
        public long? Ub03IsRfclasstribId { get; set; }
        public long? Ub6970RfclasstribregId { get; set; }
        public int? Ub7479Ccredpresid { get; set; }
        public string? Dd061RfBb027Id { get; set; }
        public string? Dd061RfBb027bCfgimpId { get; set; }

        //public CSICP_AA143? NavCsicpAa143 { get; set; }

        //public OsusrE9aCsicpAa144? NavCsicpAa144 { get; set; }
        
        //public OsusrE9aCsicpAa144? NavCsicpAa144_1 { get; set; }

        //public OsusrE9aCsicpAa144? NavCsicpAa144_2 { get; set; }
        
        //public OsusrE9aCsicpAa150Ccredpre? NavAa150Ccredpre { get; set; }

        public Dto_GetBB027? NavBB027 { get; set; }
        
        public DtoGetBB027Imp? NavBB027Imp { get; set; }

    }
}
