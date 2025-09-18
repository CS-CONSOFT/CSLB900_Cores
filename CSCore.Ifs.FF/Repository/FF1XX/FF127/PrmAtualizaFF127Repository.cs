using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127
{
    public class PrmAtualizaFF127Repository
    {
        private PrmAtualizaFF127Repository() { }
        public ICS_GenerateId InCS_GenerateID { get; set; } = null!;
        public string InNovoProtocoloFF127 { get; set; } = string.Empty;
        public string InSY001Id { get; set; } = string.Empty;
        public int InTenantID { get; set; } = 0;
        public int InSTIDFF102SitAberto { get; set; } = 0;
        public int InSTIDFF102SitBxParcial { get; set; } = 0;
        public string InBB012_ID { get; set; } = string.Empty;
        public string InMensagem { get; set; } = string.Empty;
        public DateTime? InDataPrevisao { get; set; } = default;
        public DateTime? InDataVisita { get; set; } = default;
        public string? InFF002_ID_Motivo { get; set; } = string.Empty;

        public static async Task<PrmAtualizaFF127Repository> CreateInstanceAsync(
            IStaticaLabelRepository staticaLabelRepository,
            ICS_GenerateId inCS_GenerateID,
            IGenerateProtocolo generateProtocolo,
            string inBB001_ID,
            string inSY001Id,
            int inTenantID,
            string inBB012_ID,
            string inMensagem,
            DateTime? inDataPrevisao,
            DateTime? inDataVisita,
            string? inFF002_ID_Motivo
            )
        {
            var idBxParcial = await staticaLabelRepository.GetIDStaticaByLabel<CSICP_FF102Sit>(Entities.FF102_Sit.BxParcial);
            var idAberto = await staticaLabelRepository.GetIDStaticaByLabel<CSICP_FF102Sit>(Entities.FF102_Sit.Aberto);
            var protoclo = await generateProtocolo.Fcn_Protocolo10(inBB001_ID, "COBRANÇA", inTenantID);
            return new PrmAtualizaFF127Repository
            {
                InCS_GenerateID = inCS_GenerateID,
                InNovoProtocoloFF127 = protoclo.ToString(),
                InSY001Id = inSY001Id,
                InTenantID = inTenantID,
                InSTIDFF102SitAberto = idAberto,
                InSTIDFF102SitBxParcial = idBxParcial,
                InBB012_ID = inBB012_ID,
                InMensagem = inMensagem,
                InDataPrevisao = inDataPrevisao,
                InDataVisita = inDataVisita,
                InFF002_ID_Motivo = inFF002_ID_Motivo
            };
        }
    }
}
