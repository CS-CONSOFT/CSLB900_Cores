using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class GravaOcorrencia : IGravaOcorrencia
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;

        public GravaOcorrencia(AppDbContext appDbContext, ICS_GenerateId generateId)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
        }

        public void GravaOcorrenciaPrms(PrmGravaOcorrencia parametros)
        {
            var ocorrencia = new CSICP_FF116
            {
                Id = _generateId.GenerateUuId(),
                TenantId = parametros.InTenantID,
                Ff102Tituloid = parametros.InFF102ID,
                Ff116Datamovto = DateTime.UtcNow.ToLocalTime(),
                Ff116Usuariopropid = parametros.InUsuarioID,
                Ff116Filialid = parametros.InFilialIDBB001,
                Ff116Tipomovto = parametros.TipoMovimento,
                Ff116Datavencto = parametros.DataVencimento,
                Ff116Novovencto = parametros.NovaDataVencimento,
                Ff116Vvaloranterior = parametros.ValorAntigo,
                Ff116Vnovovlr = parametros.ValorNovo,
                Ff116Msg = FormatarMensagem(parametros)
            };

            _appDbContext.Add(ocorrencia);
        }

        private static string FormatarMensagem(PrmGravaOcorrencia parametros)
        {
            if (string.IsNullOrEmpty(parametros.Motivo))
                return string.Empty;

            var mensagem = parametros.TipoOperacao switch
            {
                TipoOperacaoOcorrencia.AlteracaoDataVencimento => $"Alteração de data de vencimento - Motivo: {parametros.Motivo}",
                TipoOperacaoOcorrencia.AplicaSemJuros => $"Aplicação de não cobrança de juros - Motivo: {parametros.Motivo}",
                _ => parametros.Motivo
            };

            return mensagem.Length > 100 ? mensagem.Substring(0, 100) : mensagem;
        }
    }
}