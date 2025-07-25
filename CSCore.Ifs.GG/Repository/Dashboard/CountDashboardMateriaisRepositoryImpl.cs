using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.Dashboard;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.Dashboard
{
    public enum DashboardMateriaisEnum
    {
        Almoxarifados_gg001,
        Almoxarifados_gg001_AlmoxPizza,
        Almoxarifados_gg001_ComTAlmox,
    }


    public class CountDashboardMateriaisRepositoryImpl(AppDbContext appDbContext) : ICountDashboardMateriaisRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        /// <summary>
        /// int - total count || int - total ativo
        /// </summary>
        public async Task<RepoDtoResponseCountMateriaisDashboard> GetTotalizadoresAsync(int tenantId)
        {
            var resultadoAlmoxPizza = await (
                from _gg001 in _appDbContext.Set<CSICP_GG001>()

                join _gg001TAlmox in _appDbContext.Set<CSICP_GG001Talmox>()
                on _gg001.Gg001Tipoalmoxarifado equals _gg001TAlmox.Id into joinT1
                from _gg001TAlmox in joinT1.DefaultIfEmpty()

                where _gg001.TenantId == tenantId
                    && _gg001.Gg001Isactive == true
                    && _gg001TAlmox.Label != "Virtual"

                group _gg001 by _gg001TAlmox.Label into g
                orderby g.Count() descending
                select new RepoDtoResponseLabelCount
                {
                    Texto = g.Key,
                    Contagem = g.Count()
                }
            ).ToListAsync();

            var resultadoKardexCountProduto = await (
                from _gg008kdx in _appDbContext.Set<CSICP_GG008Kdx>()

                join _bb001 in _appDbContext.Set<CSICP_BB001>()
                on _gg008kdx.Gg008Filialid equals _bb001.Id

                where _gg008kdx.TenantId == tenantId
                    && _bb001.Bb001Isactive == true

                group _bb001 by new { _bb001.Bb001Codigoempresa, _bb001.Bb001Nomefantasia } into g
                orderby g.Count() descending
                select new RepoDtoResponseLabelCount
                {
                    Texto = ($"{g.Key.Bb001Codigoempresa} - {g.Key.Bb001Nomefantasia}"),
                    Contagem = g.Count()
                }
            ).ToListAsync();

            var resultadoQuantidadeNSPorAlmox = await (
                from _gg520 in _appDbContext.Set<CSICP_GG520>()

                join _gg001 in _appDbContext.Set<CSICP_GG001>()
                on _gg520.Gg520Almoxid equals _gg001.Id

                join _gg001TAlmox in _appDbContext.Set<CSICP_GG001Talmox>()
                on _gg001.Gg001Tipoalmoxarifado equals _gg001TAlmox.Id

                where _gg520.TenantId == tenantId
                    && _gg001.Gg001Isactive == true
                    && _gg001TAlmox.Label != "Virtual"

                group _gg001 by new { _gg001.Gg001Codigoalmox, _gg001.Gg001Descalmox } into g
                orderby g.Count() descending
                select new RepoDtoResponseLabelCount
                {
                    Texto = ($"{g.Key.Gg001Codigoalmox} - {g.Key.Gg001Descalmox}"),
                    Contagem = g.Count()
                }
            ).ToListAsync();

            RepoDtoResponseCount repoDtoResponseCount = await GetCountGG001Simples(tenantId);

            var countGrupo = await RecuperaTotalCountEActiveCount<CSICP_GG003>(tenantId, "Gg003Isactive", "Grupo");
            var countClasse = await RecuperaTotalCountEActiveCount<CSICP_GG004>(tenantId, "Gg004Isactive", "Classe");
            var countArtigo = await RecuperaTotalCountEActiveCount<CSICP_GG005>(tenantId, "Gg005Isactive", "Artigo");
            var countMarca = await RecuperaTotalCountEActiveCount<CSICP_GG006>(tenantId, "Gg006IsActive", "Marca");
            var countUnidade = await RecuperaTotalCountEActiveCount<CSICP_GG007>(tenantId, "Gg007IsActive", "Unidade");
            var countQuantidadeProdutos = await RecuperaTotalCountEActiveCount<CSICP_GG008>(tenantId, "Gg008IsActive", "Quantidade Produtos");
            var countPadrao = await RecuperaTotalCountEActiveCount<CSICP_GG009>(tenantId, "Gg009IsActive", "Padrão");
            var countTipoPadrao = await RecuperaTotalCountEActiveCount<CSICP_GG010>(tenantId, "Gg010IsActive", "Tipo Padrão");
            var countQualidadeProduto = await RecuperaTotalCountEActiveCount<CSICP_GG011>(tenantId, "Gg011IsActive", "Qualidade Produto");
            var countLinha = await RecuperaTotalCountEActiveCount<CSICP_GG014>(tenantId, "Gg014IsActive", "Linha");
            var countSubGrupo = await RecuperaTotalCountEActiveCount<CSICP_GG015>(tenantId, "Gg015IsActive", "Subgrupo");
            var countCategoria = await RecuperaTotalCountEActiveCount<CSICP_GG017>(tenantId, null ,"Categoria");
            var countNcm = await RecuperaTotalCountEActiveCount<CSICP_GG021>(tenantId, "Gg021IsActive", "NCM");
            var countAnp = await RecuperaTotalCountEActiveCount<CSICP_GG029>(tenantId, null , "ANP");
            var countQuantidadeTotalNS = await RecuperaTotalCountEActiveCount<CSICP_GG520>(tenantId, "Gg520Isactive", "Quantidade Total NS");
            var countEstabelecimento = await RecuperaTotalCountEActiveCount<CSICP_BB001>(tenantId, "Bb001Isactive", "Estabelecimento");



            RepoDtoResponseCountMateriaisDashboard response = new()
            {
                contadorPizzaAlmox = resultadoAlmoxPizza,
                contadorAlmoxarifado = repoDtoResponseCount,
                contadorGrupo = countGrupo,
                contadorClasse = countClasse,
                contadorArtigo = countArtigo,
                contadorMarca = countMarca,
                contadorUnidade = countUnidade,
                contadorQuantidadeProdutos = countQuantidadeProdutos,
                contadorPadrao = countPadrao,
                contadorTipoPadrao = countTipoPadrao,
                contadorQualidadeProduto = countQualidadeProduto,
                contadorLinha = countLinha,
                contadorSubGrupo = countSubGrupo,
                contadorCategoria = countCategoria,
                contadorNCM = countNcm,
                contadorAnp = countAnp,
                contadorQuantidadeTotalNS = countQuantidadeTotalNS,
                contadorEstabelecimento = countEstabelecimento,
                contadorPizzaKardexProduto = resultadoKardexCountProduto,
                contadorQuantidadeNSPorAlmox = resultadoQuantidadeNSPorAlmox,
            };

            return response;
        }

        private async Task<RepoDtoResponseCount> GetCountGG001Simples(int tenantId)
        {
            var queryCountAlmox = from csicp_gg001 in _appDbContext.CSICP_GG001s

                                  join csicp_gg001_TAlmox in _appDbContext.CSICP_GG001Talmoxes
                                  on csicp_gg001.Gg001Tipoalmoxarifado equals csicp_gg001_TAlmox.Id into joinT1
                                  from csicp_gg001_TAlmox in joinT1.DefaultIfEmpty()

                                  where csicp_gg001.TenantId == tenantId
                                      && csicp_gg001_TAlmox.Label != "Virtual"

                                  group csicp_gg001 by csicp_gg001.TenantId into g
                                  orderby g.Count() descending

                                  select new RepoDtoResponseCount
                                  {
                                      Entidade = "Almoxarifado",
                                      TotalRegistro = g.Count(),
                                      NumeroAtivos = g.Count(e => e.Gg001Isactive == true),
                                      NumeroInativos = g.Count(e => e.Gg001Isactive == false),
                                  };

            var almoxarifadoQueryResult = await queryCountAlmox.FirstOrDefaultAsync();
            return almoxarifadoQueryResult;
        }

        private async Task<RepoDtoResponseCount> RecuperaTotalCountEActiveCount<TEntity>
            (int tenant, string? isAtivoNomeProp, string nomeEntidade) where TEntity : class
        {
            var result = await _appDbContext.Set<TEntity>()
               .Where(e => EF.Property<int>(e, "TenantId") == tenant)
               .GroupBy(e => EF.Property<int>(e, "TenantId"))
               .Select(g => new
               {
                   TotalCount = g.Count(),
                   ActiveCount = isAtivoNomeProp != null ? g.Count(e => EF.Property<bool>(e, isAtivoNomeProp) == true) : g.Count(e => true) // If no active property, count all
               })
               .FirstOrDefaultAsync();

            if (result == null)
            {
                return new RepoDtoResponseCount { };
            }

            return new RepoDtoResponseCount
            {
                Entidade = nomeEntidade,
                TotalRegistro = result.TotalCount,
                NumeroAtivos = result.ActiveCount,
                NumeroInativos = result.TotalCount - result.ActiveCount
            };
        }
    }
}
