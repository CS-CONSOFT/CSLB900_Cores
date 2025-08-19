using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarCalculoTituloTipoDias : IProcessarCalculoTitulo
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IEnumerable<string> _aux_condicaoPagtoDividida;
        private readonly decimal _work_valor_entrada;

        public ProcessarCalculoTituloTipoDias(AppDbContext appDbContext, ICS_GenerateId generateId, IEnumerable<string> aux_condicaoPagtoDividida, decimal work_valor_entrada)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
            _work_valor_entrada = work_valor_entrada;
        }

        public async Task Processar(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) in_calculoFinanciamento)
        {
            int aux_parcela_atual = 0;
            foreach (var current in _aux_condicaoPagtoDividida)
            {
                CSICP_FF999 work_ff999 = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                    Ff999Valorparcela = in_Renegociacao_Calc_Titulos.in_valorEntrada,
                    Ff999Parcela = aux_parcela_atual + 1,
                    Ff999Datavencto = in_Renegociacao_Calc_Titulos.in_data.AddDays(int.Parse(current))
                };

                if (EhSemEntrada(_work_valor_entrada, aux_parcela_atual))
                {
                    work_ff999.Ff999Valorparcela = in_calculoFinanciamento.ValorParcela + in_calculoFinanciamento.ValorRestoParcela;
                    in_calculoFinanciamento.ValorRestoParcela = 0;
                }
                aux_parcela_atual += 1;
                _appDbContext.Add(work_ff999);
            }
            await _appDbContext.SaveChangesAsync();
        }
        private static bool EhSemEntrada(decimal work_valor_entrada, int aux_parcela_atual)
        {
            return aux_parcela_atual != 0 || work_valor_entrada == 0;
        }
    }
}
