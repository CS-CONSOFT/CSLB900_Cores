using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102.RepoDto;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.FF.Repository.FF1XX.FF102;
using static CSCore.Domain.ComboTypes;


namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF102Repository : IRepositorioBase<CSICP_FF102>
    {
        Task<(List<CSICP_FF102>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabelecimentoId,
            int? in_tipoRegistro,
            string? in_prefixo,
            decimal? in_titulo,
            string? in_sufixo,
            string? in_nomeConta,
            int? in_situacaoId,
            int? in_codigoConta,
            int? in_TpCobranca,
            decimal? in_NoTitulonoBanco,
            string? in_serie,
            decimal? in_numeroNotaf,
            string? in_AgCobrador,
            string? in_centroCusto,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            QualDataFiltro? in_tipoDataFiltro
            );

        /*
              --- ATENÇÃO ---
              Essa rotina é usada tanto para retornar a lista para tela de títulos em cobrança
              Quanto na rotina Atualiza_Cobrador_Todos na classe AtualizaCobradorTodosFF102
              Qualquer mudança aqui, deve ser analisada para ambos os casos.
              Se houver necessidade futura, deve-se criar uma rotina específica para cada caso.
              Valter - 13/09/2025
              */
        Task<(List<CSICP_FF102>, int)> GetListTitulosEmCobrancaAsync(PrmGetListTitulosEmCobrancaRepo prmGetListTitulosEmCobrancaRepo);

        /// <summary>
        ///name="in_tipoRegistro">1.Contas a Receber, 2.Cartao Credito, 3.Contas a Pagar
        /// </summary>
        /// <param name="in_tenant"></param>
        /// <param name="in_ff102Id"></param>
        /// <param name="in_tipoRegistro">1.Contas a Receber, 2.Cartao Credito, 3.Contas a Pagar</param>
        Task<CSICP_FF102?> GetByIdAsync(int in_tenant, string in_ff102Id, int? in_tipoRegistro);

        Task AtualizaCobradorFF102(int InTenantID, string InTituloID,string InNovoCobradorSY001);
    }
}
