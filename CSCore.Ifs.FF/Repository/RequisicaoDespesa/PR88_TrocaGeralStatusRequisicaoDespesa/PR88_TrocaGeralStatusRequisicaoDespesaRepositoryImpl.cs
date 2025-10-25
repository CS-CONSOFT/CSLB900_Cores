using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.RequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR88_TrocaGeralStatusRequisicaoDespesa
{
    public class PR88_TrocaGeralStatusRequisicaoDespesaRepositoryImpl : IPR88_TrocaGeralStatusRequisicaoDespesaRepository
    {
        private readonly AppDbContext appDbContext;

        public PR88_TrocaGeralStatusRequisicaoDespesaRepositoryImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<CSICP_FF140> TrocaGeralStatusRD(int InTenantID,long In140_ID, int InNovoStatudID)
        {
            var WorkFF140 = await this.appDbContext.OsusrE9aCsicpFf140s.Where(e => e.TenantId == InTenantID)
                .Where(e => e.Ff140Id == In140_ID)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            WorkFF140.AlterarStatusDoMovimento(InNovoStatudID);
            return WorkFF140;
        }

        public bool AssinaExecucaoTrocaStatus(int InNovoStatudExecucaoID, CSICP_FF140 InFF140)
        {
            InFF140.AlterarStatusExecucao(InNovoStatudExecucaoID);
            return true;
        }
    }
}
