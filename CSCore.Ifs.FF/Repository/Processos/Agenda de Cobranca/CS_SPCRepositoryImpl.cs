using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.Agenda_de_Cobranca
{
    public class CS_SPCRepositoryImpl : ISPCRepository
    {
        private readonly AppDbContext appDbContext;

        public CS_SPCRepositoryImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task AtualizaBB012SitParaSPC(int InTenantID, int? InStIDCsicp_bb012_SitCta_CIS, string InBB012_ID_DaFF125)
        {
            CSICP_BB012 WorkBB012 = await ObterRegistroBB012ParaSPC(InTenantID, InBB012_ID_DaFF125);
            WorkBB012.Bb012SitContaId = InStIDCsicp_bb012_SitCta_CIS;
        }

        public async Task<CSICP_FF125> AtualizaFF125SitParaSPC(int InTenantID, int? InStIDCsicp_bb012_SitCta_CIS, string InFF102Titulo_Da_FF126)
        {
            CSICP_FF125 WorkFF125 = await ObterRegistroFF102_FF125ParaSPC(InTenantID, InFF102Titulo_Da_FF126);
            WorkFF125.Ff125Sitcobranca = InStIDCsicp_bb012_SitCta_CIS;
            return WorkFF125;
        }

        public async Task<CSICP_FF126> AtualizaFF126SitParaSPC(PrmRegistraSPC prm)
        {
            CSICP_FF126 WorkFF126 = await ObterRegistroFF126ParaSPC(prm);

            WorkFF126.Ff126Dtregistro = prm.InFf126_DtRegistro; 
            WorkFF126.Ff126Registrarspc = prm.InFf126Registrarspc;
            WorkFF126.Ff126Mensagem = prm.InFf126_Mensagem;
            WorkFF126.Ff126Propid = prm.InSY001_ID;
            WorkFF126.Ff126Sitcobranca = prm.InStIDCsicp_bb012_SitCta_CIS;
            WorkFF126.Ff126SitcobrancaEntId = prm.InFf126SitcobrancaEntId;
            WorkFF126.Ff126SituacaosaiId = prm.InFf126SituacaoSaiID;

            return WorkFF126;
        }

        private async Task<CSICP_BB012> ObterRegistroBB012ParaSPC(int InTenantID, string InBB012_ID_DaFF125)
        {
            return await appDbContext.OsusrE9aCsicpBb012s
                .Where(e => e.TenantId == InTenantID)
                .Where(e => e.Id == InBB012_ID_DaFF125)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("BB012 não encontrada!");
        }

        public async Task<CSICP_FF125> ObterRegistroFF102_FF125ParaSPC(int InTenantID, string InFF102Titulo_Da_FF126)
        {
            return await (
                 from ff102 in appDbContext.OsusrE9aCsicpFf102s
                 join ff125 in appDbContext.OsusrE9aCsicpFf125s
                     on ff102.Ff102Contaid equals ff125.Ff125ContaId
                 where ff102.TenantId == InTenantID
                     && ff102.Id == InFF102Titulo_Da_FF126
                     && ff125.TenantId == InTenantID
                 select ff125
             ).FirstOrDefaultAsync() ?? throw new KeyNotFoundException("CSICP_FF125 não encontrada!");
        }

        private async Task<CSICP_FF126> ObterRegistroFF126ParaSPC(PrmRegistraSPC prm)
        {
            return await appDbContext.OsusrE9aCsicpFf126s
                .Where(e => e.TenantId == prm.InTenantId
                && e.Ff126Id == prm.InFF126_ID
                && e.Ff126Sitcobranca == prm.InStIDCsicp_bb012_SitCta_CIS)
                .FirstOrDefaultAsync()
                ?? throw new KeyNotFoundException("Entidade não encontrada ou registro não é Incluir SPC!");
        }
    }
}
