using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores
{
    public class EscreveValores : IEscreveValores
    {
        private readonly AppDbContext _appDbContext;

        public EscreveValores(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Executar(PrmEscreveValores InPrmEscreveValores)
        {
            try
            {
                var WorkResultado = await (from ff018 in _appDbContext.OsusrE9aCsicpFf018s
                                           join ff102Sit in _appDbContext.OsusrE9aCsicpFf102Sits
                                           on ff018.Ff018Situacaotituloid equals ff102Sit.Id into leftJoin
                                           from ff102Sit in leftJoin.DefaultIfEmpty()
                                           where ff018.Ff017Id == InPrmEscreveValores.InFF017ID && ff018.TenantId == InPrmEscreveValores.InTenantID &&
                                                 (ff018.Ff018Situacaotituloid == InPrmEscreveValores.InSTIDFF102SitAberto || ff018.Ff018Situacaotituloid == InPrmEscreveValores.InSTID102BxParcial)
                                           group ff018 by ff018.Id into g
                                           select new
                                           {
                                               FF018_VALOR_ABERTOSUM = g.Sum(x => x.Ff018ValorAberto ?? 0),
                                               FF018_VALOR_JUROSSUM = g.Sum(x => x.Ff018ValorJuros ?? 0),
                                               FF018_VALOR_MULTASUM = g.Sum(x => x.Ff018ValorMulta ?? 0),
                                               FF018_VALOR_TITULOSUM = g.Sum(x => x.Ff018ValorTitulo ?? 0)
                                           })
                           .AsNoTrackingWithIdentityResolution()
                           .FirstOrDefaultAsync();

                CSICP_FF017? WorkFF017 = await _appDbContext.OsusrE9aCsicpFf017s
                    .Where(e => e.TenantId == InPrmEscreveValores.InTenantID && e.Id == InPrmEscreveValores.InFF017ID)
                    .FirstOrDefaultAsync();

                if (WorkFF017 == null && WorkResultado == null)
                    throw new KeyNotFoundException("Nenhum registro encontrado para atualizar.");

                WorkFF017!.Ff017TotalTitulos = WorkResultado!.FF018_VALOR_TITULOSUM;
                WorkFF017.Ff017TotalAberto = WorkResultado.FF018_VALOR_ABERTOSUM;
                WorkFF017.Ff017TotalJuros = WorkResultado.FF018_VALOR_JUROSSUM;
                WorkFF017.Ff017TotalMulta = WorkResultado.FF018_VALOR_MULTASUM;
                WorkFF017.Ff017Totrenegociado = WorkResultado.FF018_VALOR_ABERTOSUM - WorkFF017.Ff017TotalDescontos;

                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
