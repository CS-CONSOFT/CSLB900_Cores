using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Enumeradores;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using static CSLB900.MSTools.Enumeradores.EnumTipoRegistroGG008c;

namespace CSCore.Ifs.Repository.GG._00X
{

    public class GG008cRepositoryImpl(AppDbContext appDbContext) : IGG008cRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG008c> CreateCaracteristicaAsync(CSICP_GG008c entity)
        {
            await Remove_SeNecessario_OsValoresPresenteNaTabelaPorTenant_Produto_TipoRegistro(entity.TenantId, entity.Gg008cProdutoid!, TIPO_REGISTRO_GG008c.CARACTERISTICA);

            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        public async Task<CSICP_GG008c> UpdateCaracteristicaAsync(CSICP_GG008c entity)
        {
            string TIPO_REGISTRO_CARACTERISTICA = "2";
            await VerificaSeEntidadeExisteELancaExcecaoCasoNaoExista(entity, TIPO_REGISTRO_CARACTERISTICA);
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        public async Task<CSICP_GG008c> CreateImagemAsync(CSICP_GG008c entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_GG008c> UpdateImagemAsync(CSICP_GG008c entity)
        {
            string TIPO_REGISTRO_IMAGEM = "3";
            await VerificaSeEntidadeExisteELancaExcecaoCasoNaoExista(entity, TIPO_REGISTRO_IMAGEM);

            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public Task<CSICP_GG008c?> GetByIdRetornarImagensAsync(int tenant, string produtoGG008ID, string imagemGG008cID)
        {
            IQueryable<CSICP_GG008c> query =
                RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.IMAGENS);
            query = query.Where(e => e.Id == imagemGG008cID);
            return query.FirstOrDefaultAsync();
        }

        public Task<CSICP_GG008c?> GetByIdRetornarCaracteristicaAsync
            (int tenant, string produtoGG008ID, string? caracteristicaGG008cID)
        {
            IQueryable<CSICP_GG008c> query =
                RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant,
                produtoGG008ID, TIPO_REGISTRO_GG008c.CARACTERISTICA);

            if (caracteristicaGG008cID != null)
                query = query.Where(e => e.Id == caracteristicaGG008cID);

            return query.FirstOrDefaultAsync();
        }

        public Task<CSICP_GG008c?> GetByIdRetornarFichaTecnicaAsync
            (int tenant, string produtoGG008ID, string? fichaTecnicaGG008cID)
        {
            IQueryable<CSICP_GG008c> query =
                RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant,
                produtoGG008ID, TIPO_REGISTRO_GG008c.FICHA_TECNICA);

            if (fichaTecnicaGG008cID != null)
                query = query.Where(e => e.Id == fichaTecnicaGG008cID);


            return query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_GG008c>, int)> GetListRetornarImagensAsync(int tenant, string produtoGG008ID)
        {
            IQueryable<CSICP_GG008c> query =
                RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.IMAGENS);

            var queryCount = query;
            int count = queryCount.Count();

            List<CSICP_GG008c> listaGG008cImagens = await query.ToListAsync();
            return (listaGG008cImagens, count);
        }

        public async Task DeleteImagemAsync(CSICP_GG008c entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }


        public async Task<(List<CSICP_GG008c>, int)> GetListRetornarCaracteristicaAsync(int tenant, string produtoGG008ID)
        {
            IQueryable<CSICP_GG008c> query =
                 RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(
                     tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.CARACTERISTICA);

            var queryCount = query;
            int count = queryCount.Count();

            List<CSICP_GG008c> lsitaGG008Caracteristca = await query.ToListAsync();
            return (lsitaGG008Caracteristca, count);
        }

        public async Task<(List<CSICP_GG008c>, int)> GetListRetornarFichaTecnicaAsync(int tenant, string produtoGG008ID)
        {
            IQueryable<CSICP_GG008c> query =
                RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(
                    tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.FICHA_TECNICA);

            var queryCount = query;
            int count = queryCount.Count();

            List<CSICP_GG008c> lsitaFichaTec = await query.ToListAsync();
            return (lsitaFichaTec, count);
        }




        public Task<CSICP_GG008c?> GetByIdRetornarCaracteristicaAsync(int tenant, string produtoGG008ID)
        {
            IQueryable<CSICP_GG008c> query = RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.CARACTERISTICA);
            return query.FirstOrDefaultAsync();
        }

        public Task<CSICP_GG008c?> GetByIdRetornarFichaTecnicaAsync(int tenant, string produtoGG008ID)
        {
            IQueryable<CSICP_GG008c> query = RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant, produtoGG008ID, TIPO_REGISTRO_GG008c.FICHA_TECNICA);
            return query.FirstOrDefaultAsync();
        }


        public async Task<CSICP_GG008c> CreateFichaTecnicaAsync(CSICP_GG008c entity)
        {
            await Remove_SeNecessario_OsValoresPresenteNaTabelaPorTenant_Produto_TipoRegistro(entity.TenantId, entity.Gg008cProdutoid!, TIPO_REGISTRO_GG008c.FICHA_TECNICA);
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<CSICP_GG008c> UpdateFichaTecnicaAsync(CSICP_GG008c entity)
        {
            string TIPO_REGISTRO_FICHA = "1";
            await VerificaSeEntidadeExisteELancaExcecaoCasoNaoExista(entity, TIPO_REGISTRO_FICHA);
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private IQueryable<CSICP_GG008c> RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(
            int tenant, string produtoGG008ID, TIPO_REGISTRO_GG008c tipoRegistro)
        {
            string _tipoRegistro = VerificaTipoRegistroGG008c.RetornaStringDoTipoRegistroCorrepondente(tipoRegistro);

            return _appDbContext.OsusrE9aCsicpGg008cs
                           .Where(e => e.TenantId == tenant)
                           .Where(e => e.Gg008cProdutoid == produtoGG008ID)
                           .Where(e => e.Gg008cTiporegistro == _tipoRegistro)
                           .AsQueryable();
        }

        private async Task Remove_SeNecessario_OsValoresPresenteNaTabelaPorTenant_Produto_TipoRegistro(int tenant, string produtoID, TIPO_REGISTRO_GG008c tipoRegistro)
        {
            IQueryable<CSICP_GG008c> query = RetornaQueryBaseDoGG008cPorTenant_e_ProdutoID_e_Tipo(tenant, produtoID, tipoRegistro);
            List<CSICP_GG008c> listaDadosRemoverBanco = await query.ToListAsync();
            if (listaDadosRemoverBanco.Count == 1) _appDbContext.RemoveRange(listaDadosRemoverBanco);

        }

        private async Task VerificaSeEntidadeExisteELancaExcecaoCasoNaoExista(CSICP_GG008c entity, string TIPO_REGISTRO)
        {
            CSICP_GG008c? entidadeEncontrada = await _appDbContext.OsusrE9aCsicpGg008cs
                            .Where(e => e.Id == entity.Id)
                            .Where(e => e.TenantId == entity.TenantId)
                            .Where(e => e.Gg008cTiporegistro == TIPO_REGISTRO)
                            .FirstOrDefaultAsync();
            if (entidadeEncontrada is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            _appDbContext.Entry(entidadeEncontrada).State = EntityState.Detached;
        }


    }
}
