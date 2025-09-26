using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.Agenda_de_Cobranca
{
    public interface ISPCRepository
    {
        Task<CSICP_FF126> AtualizaFF126SitParaSPC(PrmRegistraSPC prm, Func<int, bool>? InValidacaoSeAcaoPodeOcorrer, string? mensagemDeErro);
        Task AtualizaBB012SitParaSPC(int InTenantID, int InStIDCsicp_bb012_SitCta_CIS, string InBB012_ID_DaFF125);
        Task<CSICP_FF125> AtualizaFF125SitParaSPC(int InTenantID, int InStIDCsicp_bb012_SitCta_CIS, string InFF102Titulo_Da_FF126);
        Task<CSICP_FF125> ObterRegistroFF102_FF125ParaSPC(int InTenantID, string InFF102Titulo_Da_FF126);
    }
}
