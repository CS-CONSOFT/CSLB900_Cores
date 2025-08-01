using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Compartilhado.Utilidade
{
    public static class IncrementarCodigo
    {
        public static int IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<T>(
     AppDbContext context,
     int? novoCodigo,
     string? in_currentID,
     string nomePropriedadeCodigo,
     string nomePropriedadeId,
     bool usarMaxCodigo = true
 ) where T : class
        {
            // Recupera a entidade pelo ID atual
            var entidadeAtual = context.Set<T>()
                .FirstOrDefault(e => EF.Property<string>(e, nomePropriedadeId) == in_currentID);

            int? tenantId = null;

            if (entidadeAtual != null)
            {
                // Obtém o valor de TenantId via reflexão
                var tenantIdProp = entidadeAtual.GetType().GetProperty("TenantId");
                if (tenantIdProp == null)
                    throw new Exception("Propriedade TenantId não encontrada na entidade.");

                tenantId = (int?)tenantIdProp.GetValue(entidadeAtual);
                if (tenantId is null)
                    throw new Exception("Propriedade TenantId não encontrada na entidade.");
            }
            else
            {
                // Busca um TenantId válido de qualquer entidade existente
                tenantId = context.Set<T>()
                    .Select(e => EF.Property<int>(e, "TenantId"))
                    .FirstOrDefault();

                if (tenantId == 0)
                    throw new Exception("Não foi possível determinar o TenantId para nova entidade. Informe um TenantId válido.");
            }

            if (usarMaxCodigo)
            {
                if (novoCodigo == null || novoCodigo == 0)
                {
                    var maxCodigo = context.Set<T>()
                                           .Where(e => EF.Property<int>(e, "TenantId") == tenantId)
                                           .Max(e => EF.Property<int?>(e, nomePropriedadeCodigo));

                    return maxCodigo.HasValue ? maxCodigo.Value + 1 : 1;
                }
            }

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
