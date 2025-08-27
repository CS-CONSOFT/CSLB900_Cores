using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters.GG032;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.Extrato;
using CSCore.Ifs.GG.Repository.GG._03X;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public enum TIPO_ACAO_INVENTARIO
    {
        BLOQUEAR = 1,
        DESBLOQUEAR = 2
    }



    public class ValoresGG032Totais
    {
        public decimal TotalCusto { get; set; }
        public decimal TotalCustoReal { get; set; }
        public decimal TotalCustoMedio { get; set; }
        public decimal TotalCustoVenda { get; set; }
        public int TotalListaSaldo { get; set; }
    }



    public class GG032RepositoryImpl(
        AppDbContext appDbContext,
        IGeraExtrato geraExtrato,
        ICS_GenerateId generateId,
        IGerarInventarioEmMassa gerarInventarioEmMassa) :
        RepositorioBaseImpl<CSICP_GG032>(appDbContext), IGG032Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IGeraExtrato _geraExtrato = geraExtrato;
        private readonly ICS_GenerateId _generateId = generateId;
        private readonly IGerarInventarioEmMassa _gerarInventarioEmMassa = gerarInventarioEmMassa;


        public async Task<CSICP_GG032?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_GG032> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            CSICP_GG032? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG032>, int)> GetListAsync(int tenant, int pageSize, int page,
             string? search,
             int? codigo,
             int? GG032Status_ID,
             DateTime DataInicial,
             DateTime DataFinal
            )
        {
            IQueryable<CSICP_GG032> query = CriaQueryBase(tenant);

            query = FiltraQuandoExisteFiltros(query, search, GG032Status_ID, DataInicial, DataFinal);

            if (codigo is not null)
            {
                query = query.Where(e => e.Gg032Codgalmox == codigo);
            }

            query = query.PaginacaoNoBanco(page, pageSize);



            int count = query.GetCountTotal();

            List<CSICP_GG032> listaCSICP_GG032 = await query.ToListAsync();
            return (listaCSICP_GG032, count);
        }

        /// <summary>
        /// Bloqueia ou desbloqueia o inventário. 
        /// 1 - bloquear || 2 - desbloquear
        /// </summary>
        public async Task CS_BloquearDesbloquearInventario(
            int tenant, string in_InventarioId,
            int in_StID_gg032_Sta_Bloqueado_ID,
            int in_StID_csicp_gg032_Sta_Solicitado_ID,
            int in_tipoAcaoInventario)
        {

        }


        public async Task<string> CS_GeradorInventarioEmMassa(
            int in_tenantId, int in_StID_EntitiesGG001TAlmox_Virtual, bool isQtdZero, FiltroProdutoRequest request)
        {
            return await _gerarInventarioEmMassa
                .CS_GeradorInventarioEmMassa(in_tenantId, isQtdZero, in_StID_EntitiesGG001TAlmox_Virtual, request);
        }


        public async Task CS_InventarioProcessar(
            int tenant,
            string in_InventarioId,
            int in_StID_GG032_Sta_Bloqueado_ID,
            int in_StID_GG032_Sta_Concluido_ID,
            int in_StID_GG028_EntSaida_Saida_ID,
            int in_StID_GG028_EntSaida_Entrada_ID,
            int in_StID_GG028_Nat_Inventario_ID)
        {


        }

        private static IQueryable<CSICP_GG032> FiltraQuandoExisteFiltros
           (IQueryable<CSICP_GG032> query,
           string? search,
           int? GG032Status_ID,
           DateTime DataInicial,
           DateTime DataFinal
           )
        {
            query = query
                .Where(e => e.Gg032Datamovimento >= DataInicial && e.Gg032Datamovimento <= DataFinal);

            if (search is not null)
            {
                query = query.Where(e => e.Gg032Protocolnumber != null &&
                                    e.Gg032Protocolnumber.Contains(search));

            }

            if (GG032Status_ID is not null)
                query = query.Where(e => e.Gg032StatusId == GG032Status_ID);


            return query;
        }


        private IQueryable<CSICP_GG032> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG032> query = from _CSICP_GG032 in _appDbContext.OsusrE9aCsicpGg032s
                                            where _CSICP_GG032.TenantId == tenant

                                            join _CSICP_BB012 in _appDbContext.OsusrE9aCsicpSy001s
                                            on _CSICP_GG032.Gg032Usuarioid equals _CSICP_BB012.Id into _CSICP_BB012_joined
                                            from _CSICP_BB012 in _CSICP_BB012_joined.DefaultIfEmpty()

                                            join _OsusrE9aCsicpGg032Stum in _appDbContext.OsusrE9aCsicpGg032Sta
                                            on _CSICP_GG032.Gg032StatusId equals _OsusrE9aCsicpGg032Stum.Id into _OsusrE9aCsicpGg032Stum_joined
                                            from _OsusrE9aCsicpGg032Stum in _OsusrE9aCsicpGg032Stum_joined.DefaultIfEmpty()

                                            join _tipoInventario in _appDbContext.CSICP_GG001Talmoxes
                                            on _CSICP_GG032.Gg032TipoinventarioId equals _tipoInventario.Id into _tipoInventario_joined
                                            from _tipoInventario in _tipoInventario_joined.DefaultIfEmpty()


                                            select new CSICP_GG032
                                            {
                                                TenantId = _CSICP_GG032.TenantId,
                                                Id = _CSICP_GG032.Id,
                                                Gg032Filialid = _CSICP_GG032.Gg032Filialid,
                                                Gg032Usuarioid = _CSICP_GG032.Gg032Usuarioid,
                                                Gg032Filial = _CSICP_GG032.Gg032Filial,
                                                Gg032Datamovimento = _CSICP_GG032.Gg032Datamovimento,
                                                Gg032Observacao = _CSICP_GG032.Gg032Observacao,
                                                Gg032Almoxid = _CSICP_GG032.Gg032Almoxid,
                                                Gg032Codgalmox = _CSICP_GG032.Gg032Codgalmox,
                                                Gg032Totalcusto = _CSICP_GG032.Gg032Totalcusto,
                                                Gg032Totalcreal = _CSICP_GG032.Gg032Totalcreal,
                                                Gg032Totalcmedio = _CSICP_GG032.Gg032Totalcmedio,
                                                Gg032Totalvenda = _CSICP_GG032.Gg032Totalvenda,
                                                Gg032DataHoraBloqueado = _CSICP_GG032.Gg032DataHoraBloqueado,
                                                Gg032DataHoraProcessado = _CSICP_GG032.Gg032DataHoraProcessado,
                                                Gg032QtosPodutos = _CSICP_GG032.Gg032QtosPodutos,
                                                Gg032QtosNaoconform = _CSICP_GG032.Gg032QtosNaoconform,
                                                Gg032QtosNaoinventariado = _CSICP_GG032.Gg032QtosNaoinventariado,
                                                Gg032QtdRegraNconf = _CSICP_GG032.Gg032QtdRegraNconf,
                                                Gg032TipoinventarioId = _CSICP_GG032.Gg032TipoinventarioId,
                                                Gg032StatusId = _CSICP_GG032.Gg032StatusId,
                                                Gg032Protocolnumber = _CSICP_GG032.Gg032Protocolnumber,
                                                NavGG032Status = _OsusrE9aCsicpGg032Stum,
                                                NavSy001Usuario = _CSICP_BB012 != null ? new Csicp_Sy001
                                                {
                                                    TenantId = _CSICP_BB012.TenantId,
                                                    Id = _CSICP_BB012.Id,
                                                    Sy001Nome = _CSICP_BB012.Sy001Nome,
                                                    Sy001Usuario = _CSICP_BB012.Sy001Usuario
                                                } : null,
                                                NavGG001Talmox = _tipoInventario ?? null
                                            };
            return query;
        }



    }
}

