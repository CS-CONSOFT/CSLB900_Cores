using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado
{
    public class RepoSaveLogServiceCenter : IRepoSaveLogServiceCenter
    {
        private readonly AppDbContext _appDbContext;

        public RepoSaveLogServiceCenter(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task SalvarLogAsync(
        int tenantId,
        string nomeUsuario,
        string severidade,
        string mensagem,
        string? jsonHeader = null,
        string? jsonQuery = null,
        string? jsonBody = null,
        bool isExibiu = false)
        {
            using var connection = _appDbContext.Database.GetDbConnection();
            if (connection.State != System.Data.ConnectionState.Open)
                await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = @"
        INSERT INTO OSUSR_E9A_CSICP_SY997 
        (
            TENANT_ID, 
            SY997_DATAINC, 
            SY997_NOMEUSUARIO, 
            SY997_ISEXIBIU, 
            SY997_SEVERIDADE, 
            SY997_MENSAGEM, 
            SY997_EXTERNAL_ID, 
            JSON_HEADER, 
            JSON_QUERY, 
            JSON_BODY
        )
        VALUES 
        (
            @TenantId, 
            @DataInc, 
            @NomeUsuario, 
            @IsExibiu, 
            @Severidade, 
            @Mensagem, 
            @ExternalId, 
            @JsonHeader, 
            @JsonQuery, 
            @JsonBody
        )";

            var tenantParam = command.CreateParameter();
            tenantParam.ParameterName = "@TenantId";
            tenantParam.Value = tenantId;
            command.Parameters.Add(tenantParam);

            var dataIncParam = command.CreateParameter();
            dataIncParam.ParameterName = "@DataInc";
            dataIncParam.Value = DateTime.UtcNow.ToLocalTime();
            command.Parameters.Add(dataIncParam);

            var nomeUsuarioParam = command.CreateParameter();
            nomeUsuarioParam.ParameterName = "@NomeUsuario";
            nomeUsuarioParam.Value = nomeUsuario.Length > 100 ? nomeUsuario.Substring(0, 100) : nomeUsuario;
            command.Parameters.Add(nomeUsuarioParam);

            var isExibiuParam = command.CreateParameter();
            isExibiuParam.ParameterName = "@IsExibiu";
            isExibiuParam.Value = isExibiu;
            command.Parameters.Add(isExibiuParam);

            var severidadeParam = command.CreateParameter();
            severidadeParam.ParameterName = "@Severidade";
            severidadeParam.Value = severidade.Length > 50 ? severidade.Substring(0, 50) : severidade;
            command.Parameters.Add(severidadeParam);

            var mensagemParam = command.CreateParameter();
            mensagemParam.ParameterName = "@Mensagem";
            mensagemParam.Value = mensagem ?? (object)DBNull.Value;
            command.Parameters.Add(mensagemParam);

            var externalIdParam = command.CreateParameter();
            externalIdParam.ParameterName = "@ExternalId";
            externalIdParam.Value = Guid.NewGuid().ToString();
            command.Parameters.Add(externalIdParam);

            var jsonHeaderParam = command.CreateParameter();
            jsonHeaderParam.ParameterName = "@JsonHeader";
            jsonHeaderParam.Value = jsonHeader ?? (object)DBNull.Value;
            command.Parameters.Add(jsonHeaderParam);

            var jsonQueryParam = command.CreateParameter();
            jsonQueryParam.ParameterName = "@JsonQuery";
            jsonQueryParam.Value = jsonQuery ?? (object)DBNull.Value;
            command.Parameters.Add(jsonQueryParam);

            var jsonBodyParam = command.CreateParameter();
            jsonBodyParam.ParameterName = "@JsonBody";
            jsonBodyParam.Value = jsonBody ?? (object)DBNull.Value;
            command.Parameters.Add(jsonBodyParam);

            await command.ExecuteNonQueryAsync();
        }

    }
}
