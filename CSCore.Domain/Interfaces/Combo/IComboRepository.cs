using CSCore.Domain.CS_Models.Staticas;
using CSCore.Domain.Interfaces.BB;
using static CSCore.Domain.ComboTypes;

namespace CSCore.Domain.Interfaces.Combo
{
    public interface IComboRepository
    {
        Task<IEnumerable<object>> GetCommonListForComboBB(int tenant, ComboTypeBB comboType);
        Task<IEnumerable<object>> GetCommonListForComboBB001(
            int tenant, string sy001_usuarioID, ComboTypeBB001 comboTypeBB);
        Task<IEnumerable<object>> GetCommonListForComboBB035(int tenant, string bb012);
        Task<IEnumerable<object>> GetCommonListForComboAA(int tenant, ComboTypeAA comboType);
        Task<IEnumerable<object>> GetCommonListForComboFF(int tenant, ComboTypeFF comboType);
        Task<IEnumerable<object>> GetCommonListForComboGG(int tenant, ComboTypeGG comboType);
        Task<IEnumerable<object>> GetCommonListForComboSYS(int tenant, ComboTypeSYS comboType);
        Task<IEnumerable<object>> GetCommonListForComboPais(int tenant);
        Task<IEnumerable<object>> GetCommonListForComboUF(int tenant, string? paisId);
        Task<IEnumerable<object>> GetCommonListForComboCidade(string? ufId, string? search, int tenant);
        Task<IEnumerable<object>> GetComboGG001(int tenant, string? estabelecimentoId, bool? trasVirtual = false);
        Task<IEnumerable<object>> GetCommonListForComboBB008(int tenant, string FormaPagamentoID);
        Task<IEnumerable<object>> GetCommonListForComboBB026(int tenant, TIPO_ESPECIE ESPECIE);


        Task<IEnumerable<CSICP_Email>> GetComboStaticaEmail();
    }
}
