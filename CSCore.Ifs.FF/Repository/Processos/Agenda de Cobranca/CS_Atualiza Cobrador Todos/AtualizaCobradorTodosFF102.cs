using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF102;
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
        private readonly IFF102Repository fF102Repository;

        public AtualizaCobradorTodosFF102(AppDbContext appDbContext, IFF102Repository fF102Repository)
        {
            _appDbContext = appDbContext;
            this.fF102Repository = fF102Repository;
        }

        public async Task Atualiza_Cobrador_Todos(PrmAtualizaCobradorTodos InPrm)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                int WorkFf011DiasAtrasosDe = await RecuperaDiasAtrasoDeDaFF011();

                var prm = new PrmGetListTitulosEmCobrancaRepo(
                    InPrm.InTenantID,
                    InPrm.InBB012_ID,
                    InPrm.InStIDFF102_Cob_Cobranca,
                    InPrm.InStIDFF102_Sit_Aberto,
                    InPrm.InStIDFF102_Sit_BxParcial);

                prm.PageNumber = 1;
                prm.PageSize = int.MaxValue;
                prm.DeveExcederOMaxPageSize = true;

                (List<CSICP_FF102> listaFF102, int count) = await fF102Repository.GetListTitulosEmCobrancaAsync(prm);

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

   
    }
}
