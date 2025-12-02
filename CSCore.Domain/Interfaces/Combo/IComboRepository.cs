using CSCore.Domain.CS_Models.Staticas;
using CSCore.Domain.Interfaces.BB;
using static CSCore.Domain.ComboTypes;

namespace CSCore.Domain.Interfaces.Combo
{
    public enum GG016F_IS_GRADE_LINHA
    {
        GG016F_COLUNA, GG016F_LINHA
    }
    public interface IComboRepository
    {
        Task<IEnumerable<object>> GetCommonListForComboBB(int tenant, ComboTypeBB comboType);
        Task<IEnumerable<object>> GetCommonListForComboBB001(
            int tenant, string sy001_usuarioID, ComboTypeBB001 comboTypeBB);
        Task<IEnumerable<object>> GetCommonListForComboBB035(int tenant, string bb012);
        Task<IEnumerable<object>> GetCommonListForComboAA(int tenant, ComboTypeAA comboType);
        Task<IEnumerable<object>> GetCommonListForComboFF(int tenant, ComboTypeFF comboType);
        Task<IEnumerable<object>> GetCommonListForComboGG(int tenant, ComboTypeGG comboType);
        Task<IEnumerable<object>> GetCommonListForComboCG(int tenant, ComboTypeCG comboType);
        Task<IEnumerable<object>> GetCommonListForComboRR(int tenant, ComboTypeRR comboType);
        Task<IEnumerable<object>> GetCommonListForComboSYS(int tenant, ComboTypeSYS comboType);
        Task<IEnumerable<object>> GetCommonListForComboPais(int tenant);
        Task<IEnumerable<object>> GetCommonListForComboUF(int tenant, string? paisId);
        Task<IEnumerable<object>> GetCommonListForComboCidade(string? ufId, string? search, int tenant);
        Task<IEnumerable<object>> GetComboGG001(int tenant, string estabelecimentoId, bool? trasVirtual = false);
        Task<IEnumerable<object>> GetCommonListForComboBB008(int tenant, string FormaPagamentoID);
        Task<IEnumerable<object>> GetCommonListForComboBB026(int tenant, TIPO_ESPECIE ESPECIE);
        Task<IEnumerable<object>> GG016fGradeLinha(int tenant, GG016F_IS_GRADE_LINHA gG016F_IS_GRADE_LINHA);
        Task<IEnumerable<object>> GG016(int tenant, string ID_csicp_gg016b);
        Task<IEnumerable<object>> GG019(int tenant,
       string InProdutoID_gg008,
       string? InSaldoID);
        Task<IEnumerable<CSICP_Email>> GetComboStaticaEmail();
    }
}
