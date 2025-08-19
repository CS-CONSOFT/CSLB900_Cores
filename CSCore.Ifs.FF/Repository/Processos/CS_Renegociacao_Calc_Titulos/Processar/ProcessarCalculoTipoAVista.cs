using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarCalculoTipoAVista : IProcessarCalculoTitulo
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;

        public ProcessarCalculoTipoAVista(AppDbContext appDbContext, ICS_GenerateId generateId)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
        }

        public async Task Processar(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) in_calculoFinanciamento)
        {
            CSICP_FF999 work_ff999 = new CSICP_FF999
            {
                Id = _generateId.GenerateUuId(),
                TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                Ff999Valorparcela = in_calculoFinanciamento.ValorFinanciado,
                Ff999Parcela = 1,
                Ff999Datavencto = in_Renegociacao_Calc_Titulos.in_data
            };
            _appDbContext.Add(work_ff999);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
