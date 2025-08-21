using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.ComboTypes;


namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF102Repository : IRepositorioBase<CSICP_FF102>
    {
        Task<(List<RepoDtoCSICP_FF102>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabelecimentoId,
            int in_tipoRegistro,
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

        Task<RepoDtoCSICP_FF102?> GetByIdAsync(int in_tenant, string in_ff102Id, int in_tipoRegistro);
    }
}
