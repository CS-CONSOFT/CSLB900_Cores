using CSCore.Application.Dto.Dtos;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public class PrmPesquisaProdutos
    {
        public int tenant { get; set; }
        public int pageSize { get; set; }
        public int page { get; set; }
        public string? search { get; set; }
        public decimal? codigo { get; set; }
        public string? grupoDescricao { get; set; }
        public string? classeDescricao { get; set; }
        public string? marcaDescricao { get; set; }
        public string? artigoDescricao { get; set; }
        public string? codigoBarraGG019 { get; set; }
        public string? in_estabelecimentoLogadoID { get; set; }
        public string? subGrupoDescricao { get; set; }
        public bool? isForaDaLinha { get; set; }
        public bool? isEComerce { get; set; }
        public bool? isActive { get; set; }
        public bool? isComNcm { get; set; }
        public bool isSomenteComSaldo { get; set; }
    }
    public interface IGG008Repository : IRepositorioBaseMudaAtivo<CSICP_GG008>
    {
        Task<CSICP_GG008?> GetByIdAsync(string gg008ID, int tenant);
        Task<bool> VerificaSeCodigoJaExiste(int codigo, int tenant);
        Task<(IEnumerable<CSICP_GG008>, int)> GetListAsync(
            int in_tenant,
            int in_pageSize, int in_page,
            string? in_search,
            decimal? in_codigo,
            string? in_grupoDescricao,
            string? in_classeDescricao,
            string? in_marcaDescricao,
            string? in_artigoDescricao,
            bool? in_isForaDaLinha,
            string? in_subGrupoDescricao,
            bool? in_isEComerce,
            bool? in_isActive,
            bool? in_isComNcm);

        Task<(IEnumerable<RepoDtoResponseGG008Kdx>, int)> GetQueryParaListaComKardex(
           PrmPesquisaProdutos prmPesquisaProdutos);
    }
}
