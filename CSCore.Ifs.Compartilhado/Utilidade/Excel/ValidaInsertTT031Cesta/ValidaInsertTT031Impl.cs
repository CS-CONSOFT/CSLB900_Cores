using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Ifs.Compartilhado.Utilidade.Excel.ValidaInsertTT031Cesta;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.TT.TT0XX.ValidaInsertTT031Cesta
{
    public class ValidaInsertTT031Impl(AppDbContext appDbContext) : IValidaInsertTT031
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_TT031> Validar(
            int in_tenant,
            long in_tt030_id,
            string codgProduto,
            decimal? qtdProduto, 
            decimal? valorProduto,
            decimal? descProduto, 
            string in_estabId)
        {
           
            var produtoEncontrado = await _appDbContext.OsusrE9aCsicpGg019s
                .Where(e => e.TenantId == in_tenant && e.Gg019Codbarrasalfa == codgProduto)
                .FirstOrDefaultAsync();

          

            var produtoId = produtoEncontrado?.Gg019Produtoid;
            var kardexDoProduto = await _appDbContext.OsusrE9aCsicpGg008Kdxes
                .Where(e => e.TenantId == in_tenant
                        && e.Gg008Produtoid == produtoId
                        && e.Gg008Filialid == in_estabId)
                .FirstOrDefaultAsync();

           

            var saldoDoProdutoID = await GetSaldo(in_tenant, kardexDoProduto?.Gg008Kardexid, primeiroSaldoVeioNulo: false);

            if (saldoDoProdutoID == null)
                saldoDoProdutoID = await GetSaldo(in_tenant, kardexDoProduto?.Gg008Kardexid, primeiroSaldoVeioNulo: true);


            var kardexId = kardexDoProduto?.Gg008Kardexid;
            CSICP_TT031? tt031existe = await _appDbContext.OsusrE9aCsicpTt031s
                .Where(e => e.TenantId == in_tenant
                        && e.Tt030Id == in_tt030_id
                        && e.Gg008Id == produtoId
                        && e.Gg008kdxId == kardexId
                        && e.Gg520Id == saldoDoProdutoID)
                .FirstOrDefaultAsync();

            if(tt031existe is null)
            {
                tt031existe = new CSICP_TT031
                {
                    TenantId = in_tenant,
                    CsCodgproduto = codgProduto,
                    CsQtd = qtdProduto,
                    CsValor = valorProduto,
                    CsDesc = descProduto,
                    Tt030Id = in_tt030_id,
                    Gg008Id = produtoId,
                    Gg008kdxId = kardexId,
                    Gg520Id = saldoDoProdutoID,
                };
            }
            

            return tt031existe;
        }
        private async Task<string?> GetSaldo(
           int in_tenant, string? kardexID, bool primeiroSaldoVeioNulo)
        {
            var query = _appDbContext.OsusrE9aCsicpGg520s
                .Where(e => e.TenantId == in_tenant
                        && e.Gg520KardexId == kardexID
                        && e.Gg520Isactive == true
                        && e.Gg520NsNumerosaldo > 0);

            if (primeiroSaldoVeioNulo == false)
                query = query.Where(e => e.Gg520Ispdv == true);

            query = query.OrderBy(e => e.Gg520NsNumerosaldo);


            return await query.Select(e => e.Id).FirstOrDefaultAsync();

        }
    }

}
