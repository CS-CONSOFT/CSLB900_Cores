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


        public async Task AtualizaBB012SitParaSPC(int InTenantID, int InStIDCsicp_bb012_SitCta_CIS, string InBB012_ID_DaFF125)
        {
            CSICP_BB012 WorkBB012 = await ObterRegistroBB012ParaSPC(InTenantID, InBB012_ID_DaFF125);
            WorkBB012.Bb012SitContaId = InStIDCsicp_bb012_SitCta_CIS;
        }

        public async Task<CSICP_FF125> AtualizaFF125SitParaSPC(int InTenantID, int InStIDCsicp_bb012_SitCta_CIS, string InFF102Titulo_Da_FF126)
        {
            CSICP_FF125 WorkFF125 = await ObterRegistroFF102_FF125ParaSPC(InTenantID, InFF102Titulo_Da_FF126);
            WorkFF125.Ff125Sitcobranca = InStIDCsicp_bb012_SitCta_CIS;
            return WorkFF125;
        }
        /// <summary>
        /// Atualiza a entidade CSICP_FF126 com os parâmetros de registro SPC especificados e retorna a entidade atualizada.
        /// Feito por valter em 19*09/2025 para o SPC
        /// </summary>
        /// <param name="prm">Os parâmetros contendo os valores para atualizar na entidade CSICP_FF126, incluindo identificadores de tenant e registro, data de registro, mensagem e informações de status.</param>
        /// <param name="InValidacaoSeAcaoPodeOcorrer">Um delegate opcional utilizado para validar se a ação é permitida. Se fornecido e retornar false, a operação não é permitida.</param>
        /// <param name="mensagemDeErro">A mensagem de erro a ser utilizada caso a ação não seja permitida. Pode ser nula.</param>
        /// <returns>Uma task que representa a operação assíncrona. O resultado da task contém a entidade CSICP_FF126 atualizada.</returns>
        /// <exception cref="KeyNotFoundException">Lançada se a entidade correspondente aos identificadores de tenant e registro especificados não for encontrada ou não for elegível para registro no SPC.</exception>
        /// <exception cref="InvalidOperationException">Lançada se o delegate de validação de permissão for fornecido e retornar false, indicando que a ação não é permitida.</exception>
        public async Task<CSICP_FF126> AtualizaFF126SitParaSPC(PrmRegistraSPC prm, Func<int, bool>? InValidacaoSeAcaoPodeOcorrer, string? mensagemDeErro)
        {
           CSICP_FF126 WorkFF126 = await appDbContext.OsusrE9aCsicpFf126s
                .Where(e => e.TenantId == prm.InTenantId
                && e.Ff126Id == prm.InFF126_ID)
                .FirstOrDefaultAsync()
                ?? throw new KeyNotFoundException("Entidade CSICP_FF126 não encontrada!");

            if (InValidacaoSeAcaoPodeOcorrer != null && !InValidacaoSeAcaoPodeOcorrer(WorkFF126.Ff126Sitcobranca ?? -1))
                throw new InvalidOperationException(mensagemDeErro);


            WorkFF126.Ff126Dtregistro = prm.InFf126_DtRegistro; 
            WorkFF126.Ff126Registrarspc = prm.InFf126Registrarspc;
            WorkFF126.Ff126Mensagem = prm.InFf126_Mensagem;
            WorkFF126.Ff126Propid = prm.InSY001_ID;
            WorkFF126.Ff126Sitcobranca = prm.InSituacaoCtaID;
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

 
    }
}
