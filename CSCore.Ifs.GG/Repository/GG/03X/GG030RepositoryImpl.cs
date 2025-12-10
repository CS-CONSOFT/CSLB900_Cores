using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public class GG030RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_GG030>(appDbContext), IGG030Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG030?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<CSICP_GG030> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            CSICP_GG030? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<CSICP_GG030?> GetByIdParaUpdateAsync(string id, int tenant)
        {
            IQueryable<CSICP_GG030> query = this._appDbContext.OsusrE9aCsicpGg030s.Where(e =>e.TenantId == tenant && e.Id == id);


            CSICP_GG030? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public override async Task<CSICP_GG030?> UpdateAsync(string id, int tenant, CSICP_GG030 entity)
        {
            this._appDbContext.OsusrE9aCsicpGg030s.Update(entity);
            await this._appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<(IEnumerable<CSICP_GG030>, int)> GetListAsync
            (int tenant,
            string? search,
            int? GG030Status_ID,
            string? in_estabID,
            DateTime DataInicial,
            DateTime DataFinal,
            int pageSize,
            int page)
        {
            IQueryable<CSICP_GG030> query = CriaQueryBase(tenant);

            query = FiltraQuandoExisteFiltros(query, search, GG030Status_ID, DataInicial, DataFinal);
            if (in_estabID is not null) query = query.Where(e => e.Gg030Filialid == in_estabID);
            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG030> listaCSICP_GG030 = await query.ToListAsync();
            return (listaCSICP_GG030, count);
        }

        private IQueryable<CSICP_GG030> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG030> query = from _CSICP_GG030 in _appDbContext.OsusrE9aCsicpGg030s
                                            where _CSICP_GG030.TenantId == tenant

                                            join _CSICP_SY001 in _appDbContext.OsusrE9aCsicpSy001s
                                            on _CSICP_GG030.Gg030Usuarioid equals _CSICP_SY001.Id into JOIN_SY001
                                            from _CSICP_SY001 in JOIN_SY001.DefaultIfEmpty()

                                            join _CSICP_BB005 in _appDbContext.OsusrE9aCsicpBb005s
                                            on _CSICP_GG030.Gg030Ccustoid equals _CSICP_BB005.Id into JOIN_BB005
                                            from _CSICP_BB005 in JOIN_BB005.DefaultIfEmpty()

                                            join CSICP_BB001 in _appDbContext.E9ACSICP_BB001s
                                            on _CSICP_GG030.Gg030Filialid equals CSICP_BB001.Id into JOIN_BB001
                                            from CSICP_BB001 in JOIN_BB001.DefaultIfEmpty()

                                            join CSICP_BB007 in _appDbContext.OsusrE9aCsicpBb007s
                                            on _CSICP_GG030.Gg030Responsavelid equals CSICP_BB007.Id into JOIN_BB007
                                            from CSICP_BB007 in JOIN_BB007.DefaultIfEmpty()

                                            join gg030Sta in _appDbContext.OsusrE9aCsicpGg030Sta
                                            on _CSICP_GG030.Gg030Status equals gg030Sta.Id into JOIN_GG030Sta
                                            from gg030Sta in JOIN_GG030Sta.DefaultIfEmpty()

                                            join gg023Val in _appDbContext.OsusrE9aCsicpGg023Vals
                                            on _CSICP_GG030.Gg030PrecoajusteId equals gg023Val.Id into gg023VAL
                                            from gg023Val in gg023VAL.DefaultIfEmpty()

                                            select new CSICP_GG030
                                            {
                                                TenantId = _CSICP_GG030.TenantId,
                                                Id = _CSICP_GG030.Id,
                                                Gg030Usuarioid = _CSICP_GG030.Gg030Usuarioid,
                                                Gg030Filial = _CSICP_GG030.Gg030Filial,
                                                Gg030Filialid = _CSICP_GG030.Gg030Filialid,
                                                Gg030DataMovimento = _CSICP_GG030.Gg030DataMovimento,
                                                Gg030Observacao = _CSICP_GG030.Gg030Observacao,
                                                Gg030CodgCCusto = _CSICP_GG030.Gg030CodgCCusto,
                                                Gg030Ccustoid = _CSICP_GG030.Gg030Ccustoid,
                                                Gg030NoDocto = _CSICP_GG030.Gg030NoDocto,
                                                Gg030Percajuste = _CSICP_GG030.Gg030Percajuste,
                                                Gg030Responsavel = _CSICP_GG030.Gg030Responsavel,
                                                Gg030Responsavelid = _CSICP_GG030.Gg030Responsavelid,
                                                Gg030TotalMovimento = _CSICP_GG030.Gg030TotalMovimento,
                                                Gg030Status = _CSICP_GG030.Gg030Status,
                                                Gg030PrecoajusteId = _CSICP_GG030.Gg030PrecoajusteId,
                                                Gg030Protocolnumber = _CSICP_GG030.Gg030Protocolnumber,

                                                NavBB005 = _CSICP_BB005 != null ? _CSICP_BB005: null,
                                                NavSY001 = _CSICP_SY001 != null ? new Csicp_Sy001
                                                {
                                                    Id = _CSICP_SY001.Id,
                                                    TenantId = _CSICP_SY001.TenantId,
                                                    Sy001Usuario = _CSICP_SY001.Sy001Usuario,
                                                    Sy001Nome = _CSICP_SY001.Sy001Nome
                                                } : null,
                                                NavBB001 = CSICP_BB001 != null ? new CSICP_BB001
                                                {
                                                    Id = CSICP_BB001.Id,
                                                    TenantId = CSICP_BB001.TenantId,
                                                    Bb001Nomefantasia = CSICP_BB001.Bb001Nomefantasia,
                                                    Bb001Codigoempresa = CSICP_BB001.Bb001Codigoempresa,
                                                    Bb001Isactive = CSICP_BB001.Bb001Isactive,
                                                    BB001_IsRegimeRegular = CSICP_BB001.BB001_IsRegimeRegular,
                                                    Bb001Razaosocial = CSICP_BB001.Bb001Razaosocial
                                                } : null,
                                                NavGG023Val = gg023Val != null ? gg023Val : null,
                                                NavGG030Sta = gg030Sta != null ? gg030Sta : null,
                                                NavBB007 = CSICP_BB007 != null ? new Domain.CSICP_BB007
                                                {
                                                    TenantId = CSICP_BB007.TenantId,
                                                    Id = CSICP_BB007.Id,
                                                    Bb007Filial = CSICP_BB007.Bb007Filial,
                                                    Bb007Codigo = CSICP_BB007.Bb007Codigo,
                                                    Bb007Responsavel = CSICP_BB007.Bb007Responsavel,
                                                    Bb007Nomereduzido = CSICP_BB007.Bb007Nomereduzido,
                                                    Bb007Classificacao = CSICP_BB007.Bb007Classificacao,
                                                    Bb007UsuarioId = CSICP_BB007.Bb007UsuarioId,
                                                    Bb007Codgsupervisor = CSICP_BB007.Bb007Codgsupervisor,
                                                    Bb007Codggerente = CSICP_BB007.Bb007Codggerente,
                                                    Bb007Geracpagar = CSICP_BB007.Bb007Geracpagar,
                                                    Bb007Coms1 = CSICP_BB007.Bb007Coms1,
                                                    Bb007Coms2 = CSICP_BB007.Bb007Coms2,
                                                    Bb007Coms3 = CSICP_BB007.Bb007Coms3,
                                                    Bb007Coms4 = CSICP_BB007.Bb007Coms4,
                                                    Bb007Coms5 = CSICP_BB007.Bb007Coms5,
                                                    Bb007Basecomicms = CSICP_BB007.Bb007Basecomicms,
                                                    Bb007Basecomicmsret = CSICP_BB007.Bb007Basecomicmsret,
                                                    Bb007Basecomipi = CSICP_BB007.Bb007Basecomipi,
                                                    Bb007Basecomfrete = CSICP_BB007.Bb007Basecomfrete,
                                                    Bb007Basecomacrfinan = CSICP_BB007.Bb007Basecomacrfinan,
                                                    Bb007Basecomdespesas = CSICP_BB007.Bb007Basecomdespesas,
                                                    Bb007Basecomseguro = CSICP_BB007.Bb007Basecomseguro,
                                                    Bb007Maxdescvenda = CSICP_BB007.Bb007Maxdescvenda,
                                                    Bb007Codgccusto = CSICP_BB007.Bb007Codgccusto,
                                                    Bb007Codgalmox = CSICP_BB007.Bb007Codgalmox,
                                                    Bb007Codgatividade = CSICP_BB007.Bb007Codgatividade,
                                                    Bb007Senha = CSICP_BB007.Bb007Senha,
                                                    Bb007Nomebanco = CSICP_BB007.Bb007Nomebanco,
                                                    Bb007Agencia = CSICP_BB007.Bb007Agencia,
                                                    Bb007Conta = CSICP_BB007.Bb007Conta,
                                                    Bb007Coreregistro = CSICP_BB007.Bb007Coreregistro,
                                                    Bb007Vinculocliente = CSICP_BB007.Bb007Vinculocliente,
                                                    Bb007Observacao = CSICP_BB007.Bb007Observacao,
                                                    Bb007Nrohandheld = CSICP_BB007.Bb007Nrohandheld,
                                                    Bb007Userhandheld = CSICP_BB007.Bb007Userhandheld,
                                                    Bb007Senhahandheld = CSICP_BB007.Bb007Senhahandheld,
                                                    Bb007Handheldsuperv = CSICP_BB007.Bb007Handheldsuperv,
                                                    Bb007Imphandheld = CSICP_BB007.Bb007Imphandheld,
                                                    Bb007Nomeusuario = CSICP_BB007.Bb007Nomeusuario,
                                                    Bb031Funcaoid = CSICP_BB007.Bb031Funcaoid,
                                                    Bb032Cargoid = CSICP_BB007.Bb032Cargoid,
                                                    Bb007Dtadmissao = CSICP_BB007.Bb007Dtadmissao,
                                                    Bb007Dtdemissao = CSICP_BB007.Bb007Dtdemissao,
                                                    Bb007Codgregiao = CSICP_BB007.Bb007Codgregiao,
                                                    Bb007Faixaautorizacao = CSICP_BB007.Bb007Faixaautorizacao,
                                                    Bb007Ccustoid = CSICP_BB007.Bb007Ccustoid,
                                                    Bb007Almoxid = CSICP_BB007.Bb007Almoxid,
                                                    Empresaid = CSICP_BB007.Empresaid,
                                                    Bb007Isactive = CSICP_BB007.Bb007Isactive,
                                                    Bb007Contafornid = CSICP_BB007.Bb007Contafornid,
                                                    Bb007Cpf = CSICP_BB007.Bb007Cpf,
                                                } : null,
                                            };
            return query;
        }


        private static IQueryable<CSICP_GG030> FiltraQuandoExisteFiltros
            (IQueryable<CSICP_GG030> query,
            string? search,
            int? GG030Status_ID,
            DateTime DataInicial,
            DateTime DataFinal
            )
        {
            query = query
                .Where(e => e.Gg030DataMovimento!.Value.Date >= DataInicial.Date
                && e.Gg030DataMovimento!.Value.Date <= DataFinal.Date);

            if (search is not null)
            {
                query = query.Where(e => e.NavBB005 != null &&
                                    e.NavBB005.Bb005Nomeccusto != null &&
                                    e.NavBB005.Bb005Nomeccusto.Contains(search));

                query = query.Where(e => e.NavSY001 != null &&
                                    e.NavSY001.Sy001Usuario != null &&
                                    e.NavSY001.Sy001Usuario.Contains(search));
            }

            if (GG030Status_ID is not null)
                query = query.Where(e => e.Gg030Status == GG030Status_ID);


            return query;
        }

        public async Task<bool> DeleteGg030Est(long id, int tenant)
        {
            var entity =
                await _appDbContext.OsusrE9aCsicpGg030ests.Where(e => e.Gg030aId == id && e.TenantId == tenant)
                .FirstOrDefaultAsync();
            if (entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<string> CreateGg030Est(CSICP_GG030Est entity)
        {
            entity.NavBB001 = null;
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity.Gg030Id ?? string.Empty;
        }

        public async Task<(IEnumerable<CSICP_GG030Est>, int)> GetListGG030EstAsync(
            int tenant, string? gg030_id, int pageSize, int page)
        {
            var query = from gg030Est in _appDbContext.OsusrE9aCsicpGg030ests
                        where gg030Est.TenantId == tenant

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on gg030Est.Bb001Id equals bb001.Id into JOIN_BB001
                        from bb001 in JOIN_BB001.DefaultIfEmpty()

                        select new CSICP_GG030Est
                        {
                            TenantId = gg030Est.TenantId,
                            Gg030aId = gg030Est.Gg030aId,
                            Gg030Id = gg030Est.Gg030Id,
                            Bb001Id = gg030Est.Bb001Id,
                            NavBB001 = bb001 != null ? new CSICP_BB001
                            {
                                Id = bb001.Id,
                                TenantId = bb001.TenantId,
                                Bb001Nomefantasia = bb001.Bb001Nomefantasia,
                                Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                                Bb001Isactive = bb001.Bb001Isactive,
                                BB001_IsRegimeRegular = bb001.BB001_IsRegimeRegular,
                                Bb001Razaosocial = bb001.Bb001Razaosocial

                            } : null
                        };
            if(gg030_id is not null)
                query = query.Where(e => e.Gg030Id == gg030_id);

            query = query.PaginacaoNoBanco(page, pageSize);
            var countQuery = query;
            int count = countQuery.GetCountTotal();
            return (await query.ToListAsync(), count);
        }
    }
}
