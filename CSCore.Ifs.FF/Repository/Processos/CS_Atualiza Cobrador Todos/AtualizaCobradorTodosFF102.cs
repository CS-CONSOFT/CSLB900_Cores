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
                int WorkFf011DiasAtrasosDe = await RecuperaDiasAtrasoDeDaFF011();
                List<CSICP_FF102> listaFF102 = await GetListFF102(InPrm, WorkFf011DiasAtrasosDe);

                foreach (var ff102Corrente in listaFF102)
                {
                    ff102Corrente.Ff102Agcobradorid = InPrm.InBB006_CobradorID;
                    ff102Corrente.Ff102Codcobrador = InPrm.InSY001_ID;
                }
                CSICP_FF125 WorkFF125 = await RecuperaFF125ParaUpdate(InPrm);

                WorkFF125.Ff125AgcobradorId = InPrm.InBB006_CobradorID;
                WorkFF125.Ff125Cobradorid = InPrm.InSY001_ID;

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        private async Task<CSICP_FF125> RecuperaFF125ParaUpdate(PrmAtualizaCobradorTodos InPrm)
        {
            return await _appDbContext.OsusrE9aCsicpFf125s
                .Where(e => e.Ff125ContaId!.Equals(InPrm.InBB012_ID)).FirstOrDefaultAsync() ?? throw new KeyNotFoundException("WorkFF125 não encontrada!");
        }

        private async Task<int> RecuperaDiasAtrasoDeDaFF011()
        {
            return await _appDbContext.OsusrE9aCsicpFf011s.AsNoTracking().Select(e => e.Ff011DiasAtrasosDe).FirstOrDefaultAsync() ?? throw new KeyNotFoundException("FF011 não encontrada");
        }

        private async Task<List<CSICP_FF102>> GetListFF102(PrmAtualizaCobradorTodos InPrm, int IntFf011DiasAtrasosDe)
        {
            return await (from ff102 in _appDbContext.OsusrE9aCsicpFf102s

 
                          where ff102.Ff102Contaid == InPrm.InBB012_ID
                             && ff102.Ff102Tpcobranca == InPrm.InStIDFF102_Cob_Cobranca
                             && EF.Functions.DateDiffDay(ff102.Ff102DataVencimento, DateTime.Today) >= IntFf011DiasAtrasosDe
                             && (ff102.Ff102Situacaoid == InPrm.InStIDFF102_Sit_Aberto || ff102.Ff102Situacaoid == InPrm.InStIDFF102_Sit_BxParcial)
                          orderby ff102.Ff102DataVencimento ascending

                          select ff102).ToListAsync();
        }
    }
}
