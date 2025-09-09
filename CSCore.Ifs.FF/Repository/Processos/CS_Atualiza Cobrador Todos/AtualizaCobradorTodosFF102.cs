using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Atualiza_Cobrador_Todos
{

    public class AtualizaCobradorTodosFF102 : IAtualizaCobradorTodosFF102
    {
        private readonly AppDbContext _appDbContext;

        public AtualizaCobradorTodosFF102(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Atualiza_Cobrador_Todos(PrmAtualizaCobradorTodos InPrm)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF011 WorkFF011 = await _appDbContext.OsusrE9aCsicpFf011s.AsNoTracking().FirstOrDefaultAsync() ?? throw new KeyNotFoundException("FF011 não encontrada");

                // Parâmetros de exemplo
                DateTime qepCurrdate = DateTime.Today;


                var resultado = await (from ff102 in _appDbContext.OsusrE9aCsicpFf102s

                                       join bb001 in _appDbContext.E9ACSICP_BB001s on ff102.Ff102Filialid equals bb001.Id into bb001Join
                                       from bb001 in bb001Join.DefaultIfEmpty()

                                       join ff102Sit in _appDbContext.OsusrE9aCsicpFf102Sits on ff102.Ff102Situacaoid equals ff102Sit.Id into sitJoin
                                       from ff102Sit in sitJoin.DefaultIfEmpty()

                                       join ff104 in _appDbContext.OsusrE9aCsicpFf104s on ff102.Id equals ff104.Ff102Id into ff104Join
                                       from ff104 in ff104Join.DefaultIfEmpty()

                                       join sy001 in _appDbContext.OsusrE9aCsicpSy001s on ff102.Ff102Codcobrador equals sy001.Id into sy001Join
                                       from sy001 in sy001Join.DefaultIfEmpty()

                                       where ff102.Ff102Contaid == InPrm.InBB012_ID
                                          && ff102.Ff102Tpcobranca == InPrm.InStIDFF102_Cob_Cobranca
                                          && EF.Functions.DateDiffDay(ff102.Ff102DataVencimento, qepCurrdate) >= WorkFF011.Ff011DiasAtrasosDe
                                          && (ff102.Ff102Situacaoid == InPrm.InStIDFF102_Sit_Aberto || ff102.Ff102Situacaoid == InPrm.InStIDFF102_Sit_BxParcial)
                                       orderby ff102.Ff102DataVencimento ascending

                                       select ff102).ToListAsync();


                foreach (var item in resultado)
                {
                    item.Ff102Agcobradorid = InPrm.InBB006_CobradorID;
                    item.Ff102Codcobrador = InPrm.InBB006_CodigoCobrador;
                }
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

    }
}
