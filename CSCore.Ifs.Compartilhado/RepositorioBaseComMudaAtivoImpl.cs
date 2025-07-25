using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using System.Reflection;

namespace CSCore.Ifs.Repository
{
    /// <summary>
    /// Use essa classe quando a entidade tiver que fazer o switch de ativo e inativo
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="appDbContext"></param>
    /// <param name="IdIdentifierName"></param>
    /// <param name="TenantIdentifierName"></param>
    public class RepositorioBaseComMudaAtivoImpl<TEntity>(
        AppDbContext appDbContext,
        string IdIdentifierName = "Id",
        string TenantIdentifierName = "TenantId"
        )
        : RepositorioBaseImpl<TEntity>(appDbContext, IdIdentifierName, TenantIdentifierName),
        IRepositorioBaseMudaAtivo<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<TEntity> ChangeActiveAsync(string entityID, int tenant)
        {
            TEntity entity = await GetEntityForUpdateAsync(entityID, tenant);
            return await VerificaSePossuiPropriedadeIsAtivoEAtualizaIsAtivoCasoEntidadePossua(entity);
        }



        public async Task<TEntity> ChangeActiveAsync(long entityID, int tenant)
        {
            TEntity entity = await GetEntityForUpdateAsync(entityID, tenant);
            return await VerificaSePossuiPropriedadeIsAtivoEAtualizaIsAtivoCasoEntidadePossua(entity);
        }

        private async Task<TEntity> VerificaSePossuiPropriedadeIsAtivoEAtualizaIsAtivoCasoEntidadePossua(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            (bool temPropriedadeIsAtivo, PropertyInfo? propriedadeEncontrada) =
                VerificadorPropriedadesEntidade.TemPropriedade<TEntity>(["Isactive", "IsActive", "isActive", "isactive", "active", "Active"]);

            if (temPropriedadeIsAtivo is not true)
                throw new InvalidOperationException("A entidade não possui uma propriedade booleana de status ativo.");

            bool currentValue = (bool)propriedadeEncontrada!.GetValue(entity)!;
            propriedadeEncontrada.SetValue(entity, !currentValue);

            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
