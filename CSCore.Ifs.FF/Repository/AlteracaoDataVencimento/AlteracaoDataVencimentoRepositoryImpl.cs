using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public class AlteracaoDataVencimentoRepositoryImpl : IAlteracaoDataVencimentoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IStaticaLabelRepository _staticaLabelRepository;

        public AlteracaoDataVencimentoRepositoryImpl(
            AppDbContext appDbContext, 
            ICS_GenerateId generateId, 
            IStaticaLabelRepository staticaLabelRepository)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _staticaLabelRepository = staticaLabelRepository;
        }

        public async Task<bool> ExecutarAlteracaoDataVencimento(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(InPrmAlteracaoDataVencimento);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(InPrmAlteracaoDataVencimento);

                // Valida regras de negócio
                await ValidarRegrasNegocio(titulo, InPrmAlteracaoDataVencimento);

                // Aplica alteração na data de vencimento
                AplicarAlteracaoDataVencimento(titulo, InPrmAlteracaoDataVencimento);

                // Grava ocorrência
                GravaOcorrencia(titulo, InPrmAlteracaoDataVencimento);

                // Salva alterações
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private static void ValidarParametros(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            if (InPrmAlteracaoDataVencimento == null)
                throw new ArgumentNullException(nameof(InPrmAlteracaoDataVencimento), "Parâmetro de entrada não pode ser nulo");

            if (string.IsNullOrEmpty(InPrmAlteracaoDataVencimento.InFF102ID))
                throw new ArgumentException("ID do título é obrigatório", nameof(InPrmAlteracaoDataVencimento.InFF102ID));

            if (string.IsNullOrEmpty(InPrmAlteracaoDataVencimento.InUsuarioID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(InPrmAlteracaoDataVencimento.InUsuarioID));

            if (InPrmAlteracaoDataVencimento.InNovaDataVencimento == default)
                throw new ArgumentException("Nova data de vencimento é obrigatória", nameof(InPrmAlteracaoDataVencimento.InNovaDataVencimento));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == InPrmAlteracaoDataVencimento.InTenantID
                       && e.Id == InPrmAlteracaoDataVencimento.InFF102ID
                       && e.Ff102Tiporegistro == InPrmAlteracaoDataVencimento.InTipoRegistro)
                .FirstOrDefaultAsync();

            if (titulo == null)
                throw new KeyNotFoundException("Título não encontrado");

            return titulo;
        }

        private async Task ValidarRegrasNegocio(CSICP_FF102 titulo, PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            // Validação 1: Situação deve estar Aberto
            if (titulo.Ff102Situacaoid != InPrmAlteracaoDataVencimento.InStIDFF102SitAberto)
            {
                throw new InvalidOperationException("O título precisa estar 'Aberto' para continuar a operação!");
            }

            // Validação 2: Validar regras por tipo de registro
            await ValidarRegrasPermissao(InPrmAlteracaoDataVencimento.InTipoRegistro);

            // Validação 3: Nova data de vencimento não pode ser menor que data de emissão nem data atual
            if (InPrmAlteracaoDataVencimento.InNovaDataVencimento < titulo.Ff102DataEmissao ||
                InPrmAlteracaoDataVencimento.InNovaDataVencimento < DateTime.Now.Date)
            {
                throw new InvalidOperationException("A nova data de vencimento não pode ser menor que a data de emissão, nem menor que a data atual.");
            }
        }

        private async Task ValidarRegrasPermissao(int tipoRegistro)
        {
            string regraRequerida = tipoRegistro == 1 || tipoRegistro == 2 ? 
                "FF002_PRORROGAR_VENCTO_CR" : 
                "FF002_PRORROGAR_VENCTO_CP";

            // Aqui você pode implementar a validação das regras conforme necessário
            // Por exemplo, verificar se o usuário tem permissão para a regra específica
            // Esta implementação pode variar conforme a arquitetura de permissões do sistema
        }

        private static void AplicarAlteracaoDataVencimento(CSICP_FF102 titulo, PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            // Alterar a data de vencimento
            titulo.Ff102DataVencimento = InPrmAlteracaoDataVencimento.InNovaDataVencimento;
            
            // Limpar campos conforme especificação
            titulo.Ff102CodigoBarras = "";
            titulo.Ff102LinhaDigital = "";
            
            // Atualizar timestamp
            titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
        }

        private void GravaOcorrencia(CSICP_FF102 titulo, PrmAlteracaoDataVencimento InPrmAlteracaoDataVencimento)
        {
            var ocorrencia = new CSICP_FF116
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InPrmAlteracaoDataVencimento.InTenantID,
                Ff116Filialid = InPrmAlteracaoDataVencimento.InFilialIDBB001,
                Ff116Tipomovto = InPrmAlteracaoDataVencimento.InStIDAlteracaoDataVencimento,
                Ff116Datamovto = DateTime.UtcNow.ToLocalTime(),
                Ff116Usuariopropid = InPrmAlteracaoDataVencimento.InUsuarioID,
                Ff102Tituloid = titulo.Id,
                Ff116Msg = $"Alteração de data de vencimento para {InPrmAlteracaoDataVencimento.InNovaDataVencimento:dd/MM/yyyy} - Motivo: {InPrmAlteracaoDataVencimento.InMotivo}".Substring(0, 100)
            };

            _appDbContext.Add(ocorrencia);
        }
    }
}