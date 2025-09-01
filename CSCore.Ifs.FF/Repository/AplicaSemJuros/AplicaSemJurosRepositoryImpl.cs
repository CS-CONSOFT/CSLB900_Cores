using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public class AplicaSemJurosRepositoryImpl : IAplicaSemJurosRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IStaticaLabelRepository _staticaLabelRepository;

        public AplicaSemJurosRepositoryImpl(
            AppDbContext appDbContext, 
            ICS_GenerateId generateId, 
            IStaticaLabelRepository staticaLabelRepository)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _staticaLabelRepository = staticaLabelRepository;
        }

        public async Task<bool> ExecutarAplicaSemJuros(PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                // Valida parâmetros de entrada
                ValidarParametros(InPrmAplicaSemJuros);

                // Busca o título
                CSICP_FF102 titulo = await BuscarTitulo(InPrmAplicaSemJuros);

                // Valida regras de negócio
                await ValidarSituacao(titulo, InPrmAplicaSemJuros);

                // Não cobrança de juros
                AplicarNaoCobrancaJuros(titulo, InPrmAplicaSemJuros);

                // Grava ocorrência
                GravaOcorrencia(titulo, InPrmAplicaSemJuros);

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

        private static void ValidarParametros(PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            if (InPrmAplicaSemJuros == null)
                throw new ArgumentNullException(nameof(InPrmAplicaSemJuros), "Parâmetro de entrada não pode ser nulo");

            if (InPrmAplicaSemJuros.InTenantID <= 0)
                throw new ArgumentException("ID do tenant deve ser maior que zero", nameof(InPrmAplicaSemJuros.InTenantID));

            if (string.IsNullOrEmpty(InPrmAplicaSemJuros.InFF102ID))
                throw new ArgumentException("ID do título é obrigatório", nameof(InPrmAplicaSemJuros.InFF102ID));

            if (string.IsNullOrEmpty(InPrmAplicaSemJuros.InUsuarioID))
                throw new ArgumentException("ID do usuário é obrigatório", nameof(InPrmAplicaSemJuros.InUsuarioID));
        }

        private async Task<CSICP_FF102> BuscarTitulo(PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            var titulo = await _appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == InPrmAplicaSemJuros.InTenantID
                       && e.Id == InPrmAplicaSemJuros.InFF102ID)
                .FirstOrDefaultAsync();

            if (titulo == null)
                throw new KeyNotFoundException("Título não encontrado");

            return titulo;
        }

        private async Task ValidarSituacao(CSICP_FF102 titulo, PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            // Validação 1: Situação deve estar Aberto ou Baixa Parcial
            if (titulo.Ff102Situacaoid != InPrmAplicaSemJuros.InStIDFF102SitAberto &&
                titulo.Ff102Situacaoid != InPrmAplicaSemJuros.InStIDFF102SitBxParcial)
            {
                throw new InvalidOperationException("O Título precisa está aberto ou em Baixa Parcial!");
            }

            // Validação 2: Não deve ter sido aplicado anteriormente
            if (titulo.Ff102SitespecialId == null)
            {
                throw new InvalidOperationException("Este Título já foi aplicado Juros/Multa não cobrado!");
            }

            await ValidarSituacao(titulo, InPrmAplicaSemJuros);
        }

        private static void AplicarNaoCobrancaJuros(CSICP_FF102 titulo, PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            titulo.Ff102SitespecialId = InPrmAplicaSemJuros.InStIDNCobraJuros;
            titulo.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
        }
        private void GravaOcorrencia(CSICP_FF102 titulo, PrmAplicaSemJuros InPrmAplicaSemJuros)
        {
            var ocorrencia = new CSICP_FF116
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InPrmAplicaSemJuros.InTenantID,
                Ff116Filialid = InPrmAplicaSemJuros.InFilialIDBB001,
                Ff116Tipomovto = InPrmAplicaSemJuros.InStIDNCobraJuros,
                Ff116Datamovto = DateTime.UtcNow.ToLocalTime(),
                Ff116Usuariopropid = InPrmAplicaSemJuros.InUsuarioID,
                Ff102Tituloid = titulo.Id,
                Ff116Msg = $"Aplicação de não cobrança de juros - Motivo: {InPrmAplicaSemJuros.InMotivo}".Substring(0, 100)
            };

            _appDbContext.Add(ocorrencia);
        }
    }
}