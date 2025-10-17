using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022
{
    public class DtoCreateUpdateRR022 : IConverteParaEntidade<OsusrTo3CsicpRr022>
    {
        public string? Rr022Loteid { get; set; }

        public string? Rr022Animalid { get; set; }

        public DateTime? Rr022Dtpeso { get; set; }

        public int? Rr022Idadediasatual { get; set; }

        public decimal? Rr022Peso { get; set; }

        public DateTime? Rr001Dtultpeso { get; set; }

        public decimal? Rr001Ultpeso { get; set; }

        public int? Rr022Idadediasult { get; set; }

        public decimal? Rr022Gmd { get; set; }

        public decimal? Rr022Gpd { get; set; }

        public DateTime? Rr022Dthrregistro { get; set; }

        public string? Rr022Usuarioid { get; set; }

        public OsusrTo3CsicpRr022 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr022
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr022Loteid = Rr022Loteid,
                Rr022Animalid = Rr022Animalid,
                Rr022Dtpeso = Rr022Dtpeso,
                Rr022Idadediasatual = Rr022Idadediasatual,
                Rr022Peso = Rr022Peso,
                Rr001Dtultpeso = Rr001Dtultpeso,
                Rr001Ultpeso = Rr001Ultpeso,
                Rr022Idadediasult = Rr022Idadediasult,
                Rr022Gmd = Rr022Gmd,
                Rr022Gpd = Rr022Gpd,
                Rr022Dthrregistro = Rr022Dthrregistro,
                Rr022Usuarioid = Rr022Usuarioid
            };
        }
    }
}