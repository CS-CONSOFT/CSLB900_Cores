using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Mapper.FF.FF1XX;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.NN.NN016.Dto;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.NN.NN016
{
    public class NN016RepositoryImpl : RepositorioBaseImpl<CSICP_NN016>, INN016Repository
    {
        private readonly AppDbContext _appDbContext;

        public NN016RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<DtoGetNN016?> GetByIdAsync(int tenant, string id)
        {
            var query = _appDbContext.OsusrE9aCsicpNn016s
                .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF102Titulo)
                .ThenInclude(e => e.NavBB001)
                .AsNoTracking();
            query = query.Where(e => e.TenantId == tenant && e.Nn016Id == id);
            return await query.Select(e => new DtoGetNN016
            {
                TenantId = e.TenantId,
                Nn016Id = e.Nn016Id,
                Nn016CrcpId = e.Nn016CrcpId,
                Nn016Filial = e.Nn016Filial,
                Nn016TipoMovimento = e.Nn016TipoMovimento,
                Nn016FilialBaixa = e.Nn016FilialBaixa,
                Nn016TituloId = e.Nn016TituloId,
                Nn016Prefixo = e.Nn016Prefixo,
                Nn016Titulo = e.Nn016Titulo,
                Nn016Sfx = e.Nn016Sfx,
                Nn016SequenciaBaixa = e.Nn016SequenciaBaixa,
                Nn016DataVencimento = e.Nn016DataVencimento,
                Nn016Diasatraso = e.Nn016Diasatraso,
                Nn016Vlrabertotitulos = e.Nn016Vlrabertotitulos,
                Nn016ValorJuros = e.Nn016ValorJuros,
                Nn016ValorDesconto = e.Nn016ValorDesconto,
                Nn016ValorMulta = e.Nn016ValorMulta,
                Nn016ValorTaxa = e.Nn016ValorTaxa,
                Nn016ValorPago = e.Nn016ValorPago,
                Nn016SituacaotitId = e.Nn016SituacaotitId,
                Nn016BaixarSn = e.Nn016BaixarSn,
                Nn016CliFor = e.Nn016CliFor,
                Nn016Historico = e.Nn016Historico,
                Nn016Mensagem = e.Nn016Mensagem,
                Nn016ValorJurosCalc = e.Nn016ValorJurosCalc,
                Nn016ValorMultaCalc = e.Nn016ValorMultaCalc,
                Nn016ValorTaxaCalc = e.Nn016ValorTaxaCalc,
                Nn016TotalApagar = e.Nn016TotalApagar,
                Nn016Protocolnumber = e.Nn016Protocolnumber,
                Nn016IdEstorno = e.Nn016IdEstorno,
                Nn016TaxaAntecipacao = e.Nn016TaxaAntecipacao,
                Nn016ValorTxAntcartao = e.Nn016ValorTxAntcartao,
                Nn016Vcorrmonetaria = e.Nn016Vcorrmonetaria,
                Nn016Vhonorarios = e.Nn016Vhonorarios,
                Nav_FF102Sit = e.NavFF102Sit,
                Nav_GetBB001Simples = e.NavFF102Titulo == null ? null : e.NavFF102Titulo!.NavBB001 == null ? null : e.NavFF102Titulo.NavBB001.ToDtoGetSimples(),
                Nav_GetFF102Simples = e.NavFF102Titulo == null ? null : e.NavFF102Titulo.ToDtoGet_Exibicao(),

            }).FirstOrDefaultAsync();

        }

        public async Task<(IEnumerable<DtoGetNN016>, int)> GetListAsync(int tenant,string NN015_ID, int page, int pageSize)
        {
            var query = _appDbContext.OsusrE9aCsicpNn016s.Where(e => e.TenantId == tenant).Where(e => e.Nn016CrcpId == NN015_ID)
                 .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF102Titulo)
                .ThenInclude(e => e.NavBB001)
                   .AsNoTracking();

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Nn016CrcpId);
            query = query.PaginacaoNoBanco(page, pageSize);

            var lista = await query.Select(e => new DtoGetNN016
            {
                TenantId = e.TenantId,
                Nn016Id = e.Nn016Id,
                Nn016CrcpId = e.Nn016CrcpId,
                Nn016Filial = e.Nn016Filial,
                Nn016TipoMovimento = e.Nn016TipoMovimento,
                Nn016FilialBaixa = e.Nn016FilialBaixa,
                Nn016TituloId = e.Nn016TituloId,
                Nn016Prefixo = e.Nn016Prefixo,
                Nn016Titulo = e.Nn016Titulo,
                Nn016Sfx = e.Nn016Sfx,
                Nn016SequenciaBaixa = e.Nn016SequenciaBaixa,
                Nn016DataVencimento = e.Nn016DataVencimento,
                Nn016Diasatraso = e.Nn016Diasatraso,
                Nn016Vlrabertotitulos = e.Nn016Vlrabertotitulos,
                Nn016ValorJuros = e.Nn016ValorJuros,
                Nn016ValorDesconto = e.Nn016ValorDesconto,
                Nn016ValorMulta = e.Nn016ValorMulta,
                Nn016ValorTaxa = e.Nn016ValorTaxa,
                Nn016ValorPago = e.Nn016ValorPago,
                Nn016SituacaotitId = e.Nn016SituacaotitId,
                Nn016BaixarSn = e.Nn016BaixarSn,
                Nn016CliFor = e.Nn016CliFor,
                Nn016Historico = e.Nn016Historico,
                Nn016Mensagem = e.Nn016Mensagem,
                Nn016ValorJurosCalc = e.Nn016ValorJurosCalc,
                Nn016ValorMultaCalc = e.Nn016ValorMultaCalc,
                Nn016ValorTaxaCalc = e.Nn016ValorTaxaCalc,
                Nn016TotalApagar = e.Nn016TotalApagar,
                Nn016Protocolnumber = e.Nn016Protocolnumber,
                Nn016IdEstorno = e.Nn016IdEstorno,
                Nn016TaxaAntecipacao = e.Nn016TaxaAntecipacao,
                Nn016ValorTxAntcartao = e.Nn016ValorTxAntcartao,
                Nn016Vcorrmonetaria = e.Nn016Vcorrmonetaria,
                Nn016Vhonorarios = e.Nn016Vhonorarios,
                Nav_FF102Sit = e.NavFF102Sit,
                Nav_GetBB001Simples = e.NavFF102Titulo == null ? null : e.NavFF102Titulo!.NavBB001 == null ? null : e.NavFF102Titulo.NavBB001.ToDtoGetSimples(),
                Nav_GetFF102Simples = e.NavFF102Titulo == null ? null : e.NavFF102Titulo.ToDtoGet_Exibicao(),

            }).ToListAsync();


            return (lista, count);
        }

        public async Task<IEnumerable<DtoGetNN016>> GetListAsyncPorNN015ParaBaixaContasaReceberPagar(int tenant, string InNN015)
        {
            var idAberto = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.Label!.Equals(Entities.FF102_Sit.Aberto))
                .Select(e => e.Id).FirstOrDefaultAsync();

            var idBxParcial = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.Label!.Equals(Entities.FF102_Sit.BxParcial))
                .Select(e => e.Id).FirstOrDefaultAsync();

            var query = _appDbContext.OsusrE9aCsicpNn016s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Nn016CrcpId == InNN015)
                .Where(e => e.Nn016SituacaotitId == idAberto || e.Nn016SituacaotitId == idBxParcial)
                  .AsNoTracking();

            query = query.OrderBy(e => e.Nn016CrcpId);

            var lista = await query.Select(e => new DtoGetNN016
            {
                TenantId = e.TenantId,
                Nn016Id = e.Nn016Id,
                Nn016CrcpId = e.Nn016CrcpId,
                Nn016Filial = e.Nn016Filial,
                Nn016TipoMovimento = e.Nn016TipoMovimento,
                Nn016FilialBaixa = e.Nn016FilialBaixa,
                Nn016TituloId = e.Nn016TituloId,
                Nn016Prefixo = e.Nn016Prefixo,
                Nn016Titulo = e.Nn016Titulo,
                Nn016Sfx = e.Nn016Sfx,
                Nn016SequenciaBaixa = e.Nn016SequenciaBaixa,
                Nn016DataVencimento = e.Nn016DataVencimento,
                Nn016Diasatraso = e.Nn016Diasatraso,
                Nn016Vlrabertotitulos = e.Nn016Vlrabertotitulos,
                Nn016ValorJuros = e.Nn016ValorJuros,
                Nn016ValorDesconto = e.Nn016ValorDesconto,
                Nn016ValorMulta = e.Nn016ValorMulta,
                Nn016ValorTaxa = e.Nn016ValorTaxa,
                Nn016ValorPago = e.Nn016ValorPago,
                Nn016SituacaotitId = e.Nn016SituacaotitId,
                Nn016BaixarSn = e.Nn016BaixarSn,
                Nn016CliFor = e.Nn016CliFor,
                Nn016Historico = e.Nn016Historico,
                Nn016Mensagem = e.Nn016Mensagem,
                Nn016ValorJurosCalc = e.Nn016ValorJurosCalc,
                Nn016ValorMultaCalc = e.Nn016ValorMultaCalc,
                Nn016ValorTaxaCalc = e.Nn016ValorTaxaCalc,
                Nn016TotalApagar = e.Nn016TotalApagar,
                Nn016Protocolnumber = e.Nn016Protocolnumber,
                Nn016IdEstorno = e.Nn016IdEstorno,
                Nn016TaxaAntecipacao = e.Nn016TaxaAntecipacao,
                Nn016ValorTxAntcartao = e.Nn016ValorTxAntcartao,
                Nn016Vcorrmonetaria = e.Nn016Vcorrmonetaria,
                Nn016Vhonorarios = e.Nn016Vhonorarios,
            }).ToListAsync();


            return lista;
        }
    }
}
