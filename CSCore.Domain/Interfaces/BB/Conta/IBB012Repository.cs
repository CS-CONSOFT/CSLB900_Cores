using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.BB.Conta
{
    public interface IBB012Repository
    {
        Task<CSICP_BB012> CreateAsync(
            CSICP_BB012 bb012,
            CSICP_BB01201 bb01201,
            CSICP_BB01202 bb01202,
            CSICP_BB01206 bb01206,
            string? in_FilialLoagadaID,
            string? in_ID_AA006);
        Task<CSICP_BB012> UpdateAsync(
            CSICP_BB012 bb012,
            CSICP_BB01201 bb01201,
            CSICP_BB01202 bb01202,
            CSICP_BB01206 bb01206);
        Task<CSICP_BB012> RemoveAsync(CSICP_BB012 bb012);
        Task<CSICP_BB012?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_BB012>, int)> GetListAsync(
            int tenant,
            string? search,
            int? searchCode,
            bool? isActive,
            int? ClasseId,
            int? ModRelacaoId,
            int? SituacaoId,
            int? StatusId,
            int? GrupoId,
            string? CPF_CNPJ,
            ParametrosBaseFiltro parametrosBaseFiltro
            );
        Task<CSICP_BB012> ChangeActive(CSICP_BB012 entity);
        Task<List<CSICP_BB01203>> GetNotas(string id, int tenant);
        Task<List<CSICP_BB012o>> GetRetencaoImpostos(string id, int tenant);
        Task<List<CSICP_BB012q>> GetDadosBancarios(string id, int tenant);
        Task<List<CSICP_BB012j>> GetOutrosEnderecos(string id, int tenant);
        Task<List<CSICP_BB01208>> GetContatos(string id, int tenant);
        Task<List<CSICP_BB012m>> GetGED(string id, int tenant);
        Task<List<CSICP_BB01209>> GetMeuCrediario(string id, int tenant);
        Task<List<CSICP_BB01210>> GetAnaliseCredito(string id, int tenant);
        Task<List<CSICP_BB012c>> GetBens(string id, int tenant);

        /// <summary>
        /// tipoRegMembroConvenio
        ///  1.Membro
        ///  2.Convenio
        ///  3.Avalista
        /// </summary>
        Task<List<CSICP_BB01207>> GetMembros(string id, int tenant, int tipoRegMembroConvenio);

        Task<CSICP_BB01206?> GetBB1206PorClienteID(string BB012clienteID, int tenant);
        Task<IReadOnlyCollection<CSICP_BB012>> GetComboCliente(int tenant, int modRel, string? search);
    }
}
