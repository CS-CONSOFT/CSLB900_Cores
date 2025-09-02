using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class GravaOcorrencia : IGravaOcorrencia
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;


        public GravaOcorrencia(AppDbContext appDbContext, ICS_GenerateId generateId, IGenerateProtocolo generateProtocolo)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _generateProtocolo = generateProtocolo;
        }

        public async Task GravaOcorrenciaPrms(PrmGravaOcorrencia parametros)
        {
            var protocolNumber = await _generateProtocolo.Fcn_Protocolo10(
                parametros.InFilialID ?? string.Empty,
                "O_CR");

            var ocorrencia = new CSICP_FF116
            {
                Id = _generateId.GenerateUuId(),
                TenantId = parametros.InTenantID,
                Ff116Tipomovto = parametros.InTipoMovimento,
                Ff116Filialid = parametros.InFilialID,
                Ff116Datamovto = DateTime.UtcNow.ToLocalTime(),
                Ff116Usuariopropid = parametros.InUsuarioPropID,
                Ff102Tituloid = parametros.InFF102TituloID,
                Ff116Datavencto = null,
                Ff116Protocolnumber = protocolNumber.ToString(),
                Ff116Msg = Mensagem(parametros)
            };

            _appDbContext.Add(ocorrencia);
        }

        private static string Mensagem(PrmGravaOcorrencia parametros)
        {
            if (string.IsNullOrEmpty(parametros.InMsgMotivo))
                return string.Empty;

            var mensagem = parametros.TipoOperacao switch
            {
                TipoOperacaoOcorrencia.AplicaSemJuros => $"Aplicação de não cobrança de juros - Motivo: {parametros.InMsgMotivo}",
                _ => parametros.InMsgMotivo
            };

            return mensagem.Length > 100 ? mensagem.Substring(0, 100) : mensagem;
        }
    }
}