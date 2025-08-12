using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF105;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF105RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF105>(appDbContext, "Id"), IFF105Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        private class FF105ComStatusInfo
        {
            public CSICP_FF105 FF105Bordero { get; set; } = null!;
            public OsusrE9aCsicpFf105Status? FF105StatusBordero { get; set; }
        }

        /// Busca o borderô com suas informações de status para validações
        private async Task<FF105ComStatusInfo> ObterBorderoComStatusAsync(int in_tenantId, string in_ff105_borderoId)
        {
            // Verifica se o borderô existe
            var ff105 = await _appDbContext.OsusrE9aCsicpFf105s
                .FirstOrDefaultAsync(e => e.TenantId == in_tenantId && e.Id == in_ff105_borderoId);

            if (ff105 == null)
                throw new Exception("Borderô FF105 não encontrado");

            // Busca o status do borderô com join
            var ff105ComStatus = await (from ff105bordero in _appDbContext.OsusrE9aCsicpFf105s
                                        join ff105status in _appDbContext.OsusrE9aCsicpFf105Statuses
                                        on ff105bordero.Ff105Status equals ff105status.Id into ff105borderoStatusJoin
                                        from statusInfo in ff105borderoStatusJoin.DefaultIfEmpty()

                                        where ff105bordero.TenantId == in_tenantId && ff105bordero.Id == in_ff105_borderoId

                                        select new FF105ComStatusInfo
                                        {
                                            FF105Bordero = ff105bordero,
                                            FF105StatusBordero = statusInfo
                                        })
                                        .FirstOrDefaultAsync();

            return ff105ComStatus ?? new FF105ComStatusInfo
            {
                FF105Bordero = ff105
            };
        }

        public async Task<RepoDtoCSICP_FF105?> GetByIdAsync(int in_tenant, string in_ff105Id)
        {
            IQueryable<RepoDtoCSICP_FF105> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF105? cSICP_FF105 = await query.FirstOrDefaultAsync(e => e.Id == in_ff105Id);
            return cSICP_FF105;
        }

        private IQueryable<RepoDtoCSICP_FF105> GetQueryBase(int in_tenant)
        {
            return from ff105 in _appDbContext.OsusrE9aCsicpFf105s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff105.Ff105Filialid equals bb001.Id into bb001_ff105_join
                   from bb001 in bb001_ff105_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff105.Ff105Agcobradorid equals bb006.Id into bb006_ff105_join
                   from bb006 in bb006_ff105_join.DefaultIfEmpty()

                   join bb009 in _appDbContext.OsusrE9aCsicpBb009s
                   on ff105.Ff105Tipocobrancaid equals bb009.Id into bb009_ff105_join
                   from bb009 in bb009_ff105_join.DefaultIfEmpty()

                   join ff102_apiBanco in _appDbContext.OsusrE9aCsicpFf102ApiBancos
                   on ff105.Ff105ApiId equals ff102_apiBanco.Id into ff102_apiBanco_ff105_join
                   from ff102_apiBanco in ff102_apiBanco_ff105_join.DefaultIfEmpty()

                   join ff105_status in _appDbContext.OsusrE9aCsicpFf105Statuses
                   on ff105.Ff105Status equals ff105_status.Id into ff105_Status_ff105_join
                   from ff105_Status in ff105_Status_ff105_join.DefaultIfEmpty()

                   join ff105_statusApi in _appDbContext.OsusrE9aCsicpFf105Statusapis
                   on ff105.Ff105Statusapi equals ff105_statusApi.Id into ff105_statusApi_ff105_join
                   from ff105_statusApi in ff105_statusApi_ff105_join.DefaultIfEmpty()

                   where ff105.TenantId == in_tenant
                   select new RepoDtoCSICP_FF105
                   {
                       TenantId = ff105.TenantId,
                       Id = ff105.Id,
                       Ff105Filialid = ff105.Ff105Filialid,
                       Ff105Descricaobordero = ff105.Ff105Descricaobordero,
                       Ff105ClienteInicial = ff105.Ff105ClienteInicial,
                       Ff105ClienteFinal = ff105.Ff105ClienteFinal,
                       Ff105EmissaoInicial = ff105.Ff105EmissaoInicial,
                       Ff105EmissaoFinal = ff105.Ff105EmissaoFinal,
                       Ff105VenctoInicial = ff105.Ff105VenctoInicial,
                       Ff105VenctoFinal = ff105.Ff105VenctoFinal,
                       Ff105CodgcategIni = ff105.Ff105CodgcategIni,
                       Ff105CodgcategFim = ff105.Ff105CodgcategFim,
                       Ff105CodgrotaIni = ff105.Ff105CodgrotaIni,
                       Ff105CodgrotaFim = ff105.Ff105CodgrotaFim,
                       Ff105ValorMinimo = ff105.Ff105ValorMinimo,
                       Ff105Agcobradorid = ff105.Ff105Agcobradorid,
                       Ff105Tipocobrancaid = ff105.Ff105Tipocobrancaid,
                       Ff105InstCobranca1 = ff105.Ff105InstCobranca1,
                       Ff105InstCobranca2 = ff105.Ff105InstCobranca2,
                       Ff105Agencia = ff105.Ff105Agencia,
                       Ff105AgenciaDv = ff105.Ff105AgenciaDv,
                       Ff105ContaCorrente = ff105.Ff105ContaCorrente,
                       Ff105ContaDv = ff105.Ff105ContaDv,
                       Ff105DataEnvio = ff105.Ff105DataEnvio,
                       Ff105ValorBordero = ff105.Ff105ValorBordero,
                       Ff105QtdTitulos = ff105.Ff105QtdTitulos,
                       Ff105Fechado = ff105.Ff105Fechado,
                       Ff105IsActive = ff105.Ff105IsActive,
                       Ff105Status = ff105.Ff105Status,
                       Ff105Protocolnumber = ff105.Ff105Protocolnumber,
                       Ff105ApiId = ff105.Ff105ApiId,
                       Ff105Statusapi = ff105.Ff105Statusapi,
                       Ff105DataCriacao = ff105.Ff105DataCriacao,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco
                       } : null,

                       NavBB009 = bb009 != null ? new CSICP_Bb009
                       {
                           TenantId = bb009.TenantId,
                           Id = bb009.Id,
                           Bb009Codigo = bb009.Bb009Codigo,
                           Bb009Tipocobranca = bb009.Bb009Tipocobranca,
                       } : null,

                       NavFF102ApiBanco = ff102_apiBanco != null ? new CSICP_FF102ApiBanco
                       {
                           Id = ff102_apiBanco.Id,
                           Label = ff102_apiBanco.Label,
                           Order = ff102_apiBanco.Order,
                           IsActive = ff102_apiBanco.IsActive,
                       } : null,

                       NavFF105Status = ff105_Status != null ? new OsusrE9aCsicpFf105Status
                       {
                           Id = ff105_Status.Id,
                           Label = ff105_Status.Label,
                           Order = ff105_Status.Order,
                           IsActive = ff105_Status.IsActive,
                       } : null,

                       NavFF105Statusapi = ff105_statusApi != null ? new OsusrE9aCsicpFf105Statusapi
                       {
                           Id = ff105_statusApi.Id,
                           Label = ff105_statusApi.Label,
                           Order = ff105_statusApi.Order,
                           IsActive = ff105_statusApi.IsActive,
                       } : null
                   };
        }

        public async Task<(List<RepoDtoCSICP_FF105>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabId, string? in_descBordero, string? in_agCobradorId, DateTime? in_dataInicio, DateTime? in_dataFinal)

        {
            IQueryable<RepoDtoCSICP_FF105> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_descBordero, in_agCobradorId, in_dataInicio, in_dataFinal, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF105> FiltraQuandoExisteFiltro(string? in_estabId, string? in_descBordero, string? in_agCobradorId,
            DateTime? in_dataInicio, DateTime? in_dataFinal, IQueryable<RepoDtoCSICP_FF105> query)
        {
            if (in_estabId != null)
                query = query.Where(e => e.Ff105Filialid!.Equals(in_estabId));
            if (in_descBordero != null)
                query = query.Where(e => e.Ff105Descricaobordero!.Contains(in_descBordero));
            if (in_agCobradorId != null)
                query = query.Where(e => e.Ff105Agcobradorid!.Equals(in_agCobradorId));
            if (in_dataInicio.HasValue)
                query = query.Where(e => e.Ff105EmissaoInicial >= in_dataInicio.Value);
            if (in_dataFinal.HasValue)
                query = query.Where(e => e.Ff105EmissaoFinal <= in_dataFinal.Value);
            return query;
        }

        public async Task PublicarBorderoAsync(int in_tenantId, string in_ff105_borderoId, int in_idff105_status_publicado)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                var ff105ComStatus = await ObterBorderoComStatusAsync(in_tenantId, in_ff105_borderoId);
                var ff105 = ff105ComStatus.FF105Bordero;

                var statusLabel = ff105ComStatus.FF105StatusBordero?.Label;
                bool statusValido = statusLabel == Csicp_ff105_Status.Carregado || statusLabel == Csicp_ff105_Status.Aberto;
                bool statusNaoFechado = ff105.Ff105Fechado != true;

                if (!(statusValido && statusNaoFechado))
                {
                    throw new Exception("Você só pode 'PUBLICAR' um registro 'CARREGADO' e não 'FECHADO!!!'");
                }
                // Termina aqui o fluxo de validação do status

                var ff106List = await _appDbContext.OsusrE9aCsicpFf106s
                    .Where(e => e.TenantId == in_tenantId && e.Ff105Id == in_ff105_borderoId)
                    .ToListAsync();

                //Variável para guardar o valor total do borderô
                decimal? valorBordero = 0;

                foreach (var ff106 in ff106List)
                {
                    //Se o título já estiver com borderô, pular para o próximo
                    if (ff106.Ff106IdOutroBordero != null)
                        continue;

                    var ff102 = await _appDbContext.OsusrE9aCsicpFf102s
                        .FirstOrDefaultAsync(e => e.TenantId == in_tenantId && e.Id == ff106.Ff102Id);

                    if (ff102 == null)
                        throw new Exception("Título FF102 não encontrado");

                    //Guardar os valores da tabela ff102 na tabela ff106
                    ff106.Ff106Agcobradorid = ff102.Ff102Agcobradorid;
                    ff106.Ff106Tipocobrancaid = ff102.Ff102Tipocobrancaid;
                    ff106.Ff106InstCobranca1 = ff102.Ff102InstCobranca1;
                    ff106.Ff106InstCobranca2 = ff102.Ff102InstCobranca2;

                    //Assinar publicação
                    decimal? protocoloNumberDecimal = null;
                    if (!string.IsNullOrWhiteSpace(ff105.Ff105Protocolnumber))
                    {
                        if (decimal.TryParse(ff105.Ff105Protocolnumber, out var result))
                            protocoloNumberDecimal = result;
                    }
                    ff102.Ff102NoBordero = protocoloNumberDecimal;
                    ff102.Ff102Agcobradorid = ff105.Ff105Agcobradorid;
                    ff102.Ff102Tipocobrancaid = ff105.Ff105Tipocobrancaid;
                    ff102.Ff102Dtimestamp = DateTime.Now;

                    valorBordero += ff102.Ff102ValorTitulo;

                    _appDbContext.OsusrE9aCsicpFf106s.Update(ff106);
                    _appDbContext.OsusrE9aCsicpFf102s.Update(ff102);
                }

                // Atualiza status do borderô
                ff105.Ff105Status = in_idff105_status_publicado;
                ff105.Ff105ValorBordero = valorBordero;
                _appDbContext.OsusrE9aCsicpFf105s.Update(ff105);

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        public async Task DespublicarBorderoAsync(int in_tenantId, string in_ff105_borderoId, int in_idff105_status_carregado)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                var ff105ComStatus = await ObterBorderoComStatusAsync(in_tenantId, in_ff105_borderoId);
                var ff105 = ff105ComStatus.FF105Bordero;

                var statusLabel = ff105ComStatus.FF105StatusBordero?.Label;
                bool statusValido = statusLabel == Csicp_ff105_Status.Publicado;
                bool statusNaoFechado = ff105.Ff105Fechado != true;

                if (!(statusValido && statusNaoFechado))
                {
                    throw new Exception("Você só pode 'DESPUBLICAR' um registro 'PUBLICADO' e não 'FECHADO'!!!");
                }
                // Termina aqui o fluxo de validação do status

                var ff106List = await _appDbContext.OsusrE9aCsicpFf106s
                    .Where(e => e.TenantId == in_tenantId && e.Ff105Id == in_ff105_borderoId)
                    .ToListAsync();

                foreach (var ff106 in ff106List)
                {
                    var ff102 = await _appDbContext.OsusrE9aCsicpFf102s
                        .FirstOrDefaultAsync(e => e.TenantId == in_tenantId && e.Id == ff106.Ff102Id);

                    if (ff102 == null)
                        throw new Exception("Título FF102 não encontrado");

                    //Guarda os valores da tabela ff106 na tabela ff102
                    ff102.Ff102Agcobradorid = ff106.Ff106Agcobradorid;
                    ff102.Ff102Tipocobrancaid = ff106.Ff106Tipocobrancaid;
                    ff102.Ff102InstCobranca1 = ff106.Ff106InstCobranca1;
                    ff102.Ff102InstCobranca2 = ff106.Ff106InstCobranca2;

                    //Assina Publicação
                    ff102.Ff102NoBordero = 0;
                    ff102.Ff102Dtimestamp = DateTime.Now;

                    _appDbContext.OsusrE9aCsicpFf102s.Update(ff102);
                    _appDbContext.OsusrE9aCsicpFf106s.Update(ff106);
                }

                // Atualiza status do borderô
                ff105.Ff105Status = in_idff105_status_carregado;
                ff105.Ff105ValorBordero = 0;
                _appDbContext.OsusrE9aCsicpFf105s.Update(ff105);

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        public async Task EncerrarBorderoAsync(int in_tenantId, string in_ff105_borderoId, int in_idff105_status_encerrado)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                var ff105ComStatus = await ObterBorderoComStatusAsync(in_tenantId, in_ff105_borderoId);
                var ff105 = ff105ComStatus.FF105Bordero;

                var statusLabel = ff105ComStatus.FF105StatusBordero?.Label;
                bool statusValido = statusLabel == Csicp_ff105_Status.Publicado;

                if (!statusValido)
                {
                    throw new Exception("Você só pode fechar um registro 'PUBLICADO'!!!");
                }
                // Termina aqui o fluxo de validação do status

                // Atualiza status do borderô
                ff105.Ff105Status = in_idff105_status_encerrado;
                _appDbContext.OsusrE9aCsicpFf105s.Update(ff105);

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}