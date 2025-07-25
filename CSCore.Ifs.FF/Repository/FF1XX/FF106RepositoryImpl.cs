using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF106RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF106>(appDbContext, "Id"), IFF106Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(List<CSICP_FF106>, int)> GetListAsync(int in_tenant,
            string in_ff105ID, int in_page, int in_pageSize)
        {
            IQueryable<CSICP_FF106> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff105ID, query);
            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);
            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF106> FiltraQuandoExisteFiltro(string in_ff105ID, IQueryable<CSICP_FF106> query)
        {
            if (in_ff105ID != null)
                query = query.Where(e => e.Ff105Id!.Equals(in_ff105ID));
            return query;
        }

        private IQueryable<CSICP_FF106> GetQueryBase(int in_tenant)
        {
            return from ff106 in _appDbContext.OsusrE9aCsicpFf106s
                   .AsNoTracking()
                   .Where(ff106 => ff106.TenantId == in_tenant)
                   select new CSICP_FF106
                   {
                       TenantId = ff106.TenantId,
                       Id = ff106.Id,
                       Ff106Filialid = ff106.Ff106Filialid,
                       Ff105Id = ff106.Ff105Id,
                       Ff102Id = ff106.Ff102Id,
                       Ff106Selecionado = ff106.Ff106Selecionado,
                       Ff106Agcobradorid = ff106.Ff106Agcobradorid,
                       Ff106Tipocobrancaid = ff106.Ff106Tipocobrancaid,
                       Ff106InstCobranca1 = ff106.Ff106InstCobranca1,
                       Ff106InstCobranca2 = ff106.Ff106InstCobranca2,
                       Ff106IdOutroBordero = ff106.Ff106IdOutroBordero,
                       Ff106CodgOcorrencia = ff106.Ff106CodgOcorrencia,
                       Ff106Ocorrencia = ff106.Ff106Ocorrencia,
                       Ff106Jurosrecebido = ff106.Ff106Jurosrecebido,
                       Ff106Multarecebida = ff106.Ff106Multarecebida,
                       Ff106Outrovlrrecebido = ff106.Ff106Outrovlrrecebido,
                       Ff106Descconcedido = ff106.Ff106Descconcedido,
                       Ff106Valorpago = ff106.Ff106Valorpago,
                       Ff106DataRecto = ff106.Ff106DataRecto,
                       Ff106DataCredito = ff106.Ff106DataCredito,
                       Nn016IdBxTes = ff106.Nn016IdBxTes,
                       Ff106DataBxaut = ff106.Ff106DataBxaut,
                       Ff106DataProtesto = ff106.Ff106DataProtesto,
                       Ff106Diasprotesto = ff106.Ff106Diasprotesto,
                       Ff106Prazorecto = ff106.Ff106Prazorecto,
                       Ff106DataLimrecto = ff106.Ff106DataLimrecto,
                       Ff106CodigoErroApi = ff106.Ff106CodigoErroApi,
                       Ff106VersaoErroApi = ff106.Ff106VersaoErroApi,
                       Ff106MsgErroApi = ff106.Ff106MsgErroApi,
                       Ff106OcorErroApi = ff106.Ff106OcorErroApi,
                       Ff106OcorrenciaApi = ff106.Ff106OcorrenciaApi,
                       Ff106LiqApi = ff106.Ff106LiqApi,
                       Ff106BaixaApi = ff106.Ff106BaixaApi,
                   };
        }
    }
}