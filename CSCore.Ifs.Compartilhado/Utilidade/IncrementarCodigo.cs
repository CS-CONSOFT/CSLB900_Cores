using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Compartilhado.Utilidade
{
    public static class IncrementarCodigo
    {
        public static int IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<T>
            (AppDbContext context,
            int? novoCodigo,
            string? in_currentID,
            string nomePropriedadeCodigo,
            string nomePropriedadeId,
            bool usarMaxCodigo = true) where T : class
        {
            // Recupera a entidade pelo ID atual
            var entidadeAtual = context.Set<T>()
                .FirstOrDefault(e => EF.Property<string>(e, nomePropriedadeId) == in_currentID);

            if (entidadeAtual == null)
                throw new Exception("Entidade não encontrada para o ID informado.");

            // Obtém o valor de TenantId via reflexão
            var tenantIdProp = entidadeAtual.GetType().GetProperty("TenantId");
            if (tenantIdProp == null)
                throw new Exception("Propriedade TenantId não encontrada na entidade.");

            int? tenantId = (int?)tenantIdProp.GetValue(entidadeAtual);
            if(tenantId is null) throw new Exception("Propriedade TenantId não encontrada na entidade.");

            if (usarMaxCodigo)
            {
                // Se o novo código for nulo ou zero
                if (novoCodigo == null || novoCodigo == 0)
                {
                    // Obter o maior valor do código
                    var maxCodigo = context.Set<T>()
                                           .Where(e => EF.Property<int>(e, "TenantId") == tenantId)
                                           .Max(e => EF.Property<int?>(e, nomePropriedadeCodigo));

                    // Incrementa o maior valor existente
                    return maxCodigo.HasValue ? maxCodigo.Value + 1 : 1;
                }
            }

            // Verifica se o código já existe
            bool codeExists = context.Set<T>().Any(e => 
                EF.Property<int?>(e, nomePropriedadeCodigo) == novoCodigo && 
                EF.Property<string>(e, nomePropriedadeId) != in_currentID &&
                EF.Property<int>(e, "TenantId") == tenantId);

            if (codeExists)
            {
                throw new Exception($"O código {novoCodigo} já existe. Por favor, forneça um código diferente.");
            }
            return novoCodigo.Value;
        }
    }
}
