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

        public async Task<RetornoPadraoProcessosVoid> AtualizaRegistroSPC(PrmRegistraSPC prm)
        {
            CSICP_FF126 WorkFF126 = await appDbContext.OsusrE9aCsicpFf126s
                .Where(e => e.TenantId == prm.InTenantId 
                && e.Ff126Id == prm.InFF126_ID
                && e.Ff126Sitcobranca == prm.InStIDCsicp_bb012_SitCta_CIS)
                .FirstOrDefaultAsync() 
                ?? throw new KeyNotFoundException("Entidade não encontrada ou registro não é Incluir SPC!");

            CSICP_FF125? WorkFF125 = await (
                 from ff102 in appDbContext.OsusrE9aCsicpFf102s
                 join ff125 in appDbContext.OsusrE9aCsicpFf125s
                     on ff102.Ff102Contaid equals ff125.Ff125ContaId
                 where ff102.TenantId == prm.InTenantId
                     && ff102.Id == WorkFF126.Ff126TituloId
                     && ff125.TenantId == prm.InTenantId
                 select ff125
             ).FirstOrDefaultAsync() ?? throw new KeyNotFoundException("CSICP_FF125 não encontrada!");

            CSICP_BB012? WorkBB012 = await appDbContext.OsusrE9aCsicpBb012s
                .Where(e => e.TenantId == prm.InTenantId)
                .Where(e => e.Id == WorkFF125.Ff125ContaId)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("BB012 não encontrada!");

            WorkFF126.Ff126Dtregistro = prm.InFf126_DtRegistro;
            WorkFF126.Ff126Registrarspc = true;
            WorkFF126.Ff126Mensagem = prm.InFf126_Mensagem;
            WorkFF126.Ff126Propid = prm.InSY001_ID;
            WorkFF126.Ff126Sitcobranca = prm.InStIDCsicp_bb012_SitCta_CIS;
            WorkFF125.Ff125Sitcobranca = prm.InStIDCsicp_bb012_SitCta_CIS;
            WorkBB012.Bb012SitContaId = prm.InStIDCsicp_bb012_SitCta_CIS;

            return RetornoPadraoProcessosVoid.Create(RetornoPadraoProcessos.Sucesso, sucesso: true);
        }
    }
}
