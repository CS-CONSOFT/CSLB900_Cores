using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado
{
    public interface IRepoSaveLogServiceCenter
    {
        Task SalvarLogAsync(
 int tenantId,
 string nomeUsuario,
 string severidade,
 string mensagem,
 string? jsonHeader = null,
 string? jsonQuery = null,
 string? jsonBody = null,
 bool isExibiu = false);
    }
}
