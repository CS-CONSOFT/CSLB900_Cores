using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022
{
    public class DtoCreateUpdateRR022 : IConverteParaEntidade<OsusrTo3CsicpRr022>
    {
        public string? Rr022Loteid { get; set; }

        public string? Rr022Animalid { get; set; }
        public decimal? Rr022Peso { get; set; }


        /*public DateTime? Rr022Dtpeso { get; set; }

        public int? Rr022Idadediasatual { get; set; }

        public DateTime? Rr001Dtultpeso { get; set; }

        public decimal? Rr001Ultpeso { get; set; }

        public int? Rr022Idadediasult { get; set; }

        public decimal? Rr022Gmd { get; set; }

        public decimal? Rr022Gpd { get; set; }

        public DateTime? Rr022Dthrregistro { get; set; }*/
        [JsonIgnore]
        public string? Rr022Usuarioid { get; set; }
        public bool? Rr022IsProcessado { get; set; }

        public string? Rr022Observacao { get; set; }
        public decimal? Rr022Circexcrotal { get; set; }
        public long? Rr022Condcriacaid { get; set; }


        public OsusrTo3CsicpRr022 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr022
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Rr022Loteid = Rr022Loteid,
                Rr022Animalid = Rr022Animalid,
                Rr022Peso = Rr022Peso,
                Rr022Usuarioid = Rr022Usuarioid,
                Rr022IsProcessado = Rr022IsProcessado,

                /*
                Rr022Dtpeso = Rr022Dtpeso,
                Rr022Idadediasatual = Rr022Idadediasatual,
                Rr001Dtultpeso = Rr001Dtultpeso,
                Rr001Ultpeso = Rr001Ultpeso,
                Rr022Idadediasult = Rr022Idadediasult,
                Rr022Gmd = Rr022Gmd,
                Rr022Gpd = Rr022Gpd,
                Rr022Dthrregistro = Rr022Dthrregistro,*/

                Rr022Observacao = Rr022Observacao,
                Rr022Circexcrotal = Rr022Circexcrotal,
                Rr022Condcriacaid = Rr022Condcriacaid
            };
        }
    }

    public class DtoCreateUpdateRR022List
    {
        public List<DtoCreateUpdateRR022>? CreateListRR022 { get; set; }
    }
}