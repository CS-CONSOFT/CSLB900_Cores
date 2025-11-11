using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos;
using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos.Parametros;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Calculos;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.LB900.Calculos
{
    public class CalculoAtrasoMultaJurosTitulos : ICalculoAtrasoMultaJurosTitulos
    {
        private readonly AppDbContext _appDbContext;

        public CalculoAtrasoMultaJurosTitulos(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        /// <summary>
        /// Utilizar esse método quando for calcular títulos de contas a receber, pois ele busca os parâmetros padrão na tabela FF000
        /// </summary>
        /// <param name="InEntradaCalculo"></param>
        /// <returns></returns>
        public async Task<PrmRetornoCalculo> CalcularContasAReceber(PrmEntradaCalculo InEntradaCalculo)
        {
            CSICP_FF000? WorkFF000 = await RecuperarParametrosTitulo(InEntradaCalculo);
            if (WorkFF000 is null) return new PrmRetornoCalculo();
            return CalcularTitulos(InEntradaCalculo, WorkFF000);
        }


        /// <summary>
        /// Utilizar esse método quando for calcular títulos de contas a pagar, pois ele usa os parametros enviados
        /// </summary>
        /// <param name="InEntradaCalculo"></param>
        /// <returns></returns>
        public PrmRetornoCalculo CalcularContasAPagar(PrmEntradaCalculo InEntradaCalculo)
        {
            return CalcularTitulos(InEntradaCalculo, InCSICPFF000: null);
        }

        private PrmRetornoCalculo CalcularTitulos(
          PrmEntradaCalculo InEntradaCalculo,
          CSICP_FF000? InCSICPFF000)
        {
            // Criar cópia para evitar mutação do objeto original
            var parametrosCalculoLocal = CriarParametrosCalculoComDefaults(InEntradaCalculo, InCSICPFF000);

            var (valorJuros, diasAtrasoJuros) = CalculoTitulos.CalcularJuros(
                parametrosCalculoLocal.DataVencimento,
                parametrosCalculoLocal.ValorTitulo,
                parametrosCalculoLocal.PercentualJuros,
                parametrosCalculoLocal.DiasLiberacao,
                parametrosCalculoLocal.ValorJurosDias,
                parametrosCalculoLocal.FinacEspJurosMulta);

            var (valorMulta, diasAtrasoMulta) = CalculoTitulos.CalcularMulta(
                parametrosCalculoLocal.DataVencimento,
                parametrosCalculoLocal.ValorTitulo,
                parametrosCalculoLocal.PercentualMulta,
                parametrosCalculoLocal.ValorMulta,
                parametrosCalculoLocal.DiasLiberacao,
                parametrosCalculoLocal.FinacEspJurosMulta);

            var (valorHonorario, diasAtrasoHonorario) = CalculoTitulos.CalcularHonorarios(
                parametrosCalculoLocal.DataVencimento,
                parametrosCalculoLocal.ValorTitulo,
                parametrosCalculoLocal.PercentualHonorarios,
                parametrosCalculoLocal.DiasLiberacao);

            var (valorCorrecaoMonetaria, diasAtrasoCorrecaoMonetaria) = CalculoTitulos.CalcularCorrecaoMonetaria(
                parametrosCalculoLocal.DataVencimento,
                parametrosCalculoLocal.ValorTitulo,
                parametrosCalculoLocal.PercentualCorrecaoMonetaria,
                parametrosCalculoLocal.DiasLiberacao);

            return MontarRetornoCalculo(
                InEntradaCalculo,
                InCSICPFF000,
                valorJuros, diasAtrasoJuros,
                valorMulta, diasAtrasoMulta,
                valorHonorario, diasAtrasoHonorario,
                valorCorrecaoMonetaria, diasAtrasoCorrecaoMonetaria);
        }

        private static ParametrosCalculoLocal CriarParametrosCalculoComDefaults(
           PrmEntradaCalculo entradaCalculo,
           CSICP_FF000? parametrosTitulo)
            {
                return new ParametrosCalculoLocal
                {
                    DataVencimento = entradaCalculo.InDataVencimento,
                    ValorTitulo = entradaCalculo.InValorTitulo,

                    PercentualJuros = (entradaCalculo.InPercentualJuros == 0 || entradaCalculo.InPercentualJuros == null)
                        ? parametrosTitulo?.Ff000PercJuros ?? 0
                        : entradaCalculo.InPercentualJuros,

                    PercentualMulta = (entradaCalculo.InPercentualMulta == 0 || entradaCalculo.InPercentualMulta == null)
                        ? parametrosTitulo?.Ff000PercMulta ?? 0
                        : entradaCalculo.InPercentualMulta,

                    PercentualHonorarios = (entradaCalculo.InPercentualHonorarios == 0 || entradaCalculo.InPercentualHonorarios == null)
                        ? parametrosTitulo?.Ff000PercHonorarios ?? 0
                        : entradaCalculo.InPercentualHonorarios,

                    PercentualCorrecaoMonetaria = (entradaCalculo.InPercentualCorrecaoMonetaria == 0 || entradaCalculo.InPercentualCorrecaoMonetaria == null)
                        ? parametrosTitulo?.Ff000PercCorrmonetaria ?? 0
                        : entradaCalculo.InPercentualCorrecaoMonetaria,

                    DiasLiberacao = (entradaCalculo.InDiasLiberacao == 0 || entradaCalculo.InDiasLiberacao == null)
                        ? parametrosTitulo?.Ff000Diascarjuros ?? 0
                        : entradaCalculo.InDiasLiberacao,

                    FinacEspJurosMulta = entradaCalculo.InFinacEspJurosMulta,

                    ValorJurosDias = entradaCalculo.InValorJurosDia,
                    ValorMulta = entradaCalculo.InValorMulta
                };
            }

        private static PrmRetornoCalculo MontarRetornoCalculo(
            PrmEntradaCalculo InEntradaCalculo,
            CSICP_FF000? WorkFF000,
            decimal WorkValorCalculoJuros,
            int WorkDiasAtrasoJuros,
            decimal WorkValorCalculoMulta,
            int WorkDiasAtrasoMulta,
            decimal WorkValorCalculoHonorario,
            int WorkDiasAtrasoHonorario,
            decimal WorkValorCalculoCorrecaoMonetaria,
            int WorkDiasAtrasoCorrecaoMonetaria)
        {
            return new PrmRetornoCalculo
            {
                OutDiasAtrasoJuros = WorkDiasAtrasoJuros,
                OutValorJuros = WorkValorCalculoJuros,
                OutPercentualJurosTitulo = InEntradaCalculo.InPercentualJuros,
                OutPercentualJurosConfig = WorkFF000?.Ff000PercJuros,

                OutValorMulta = WorkValorCalculoMulta,
                OutDiasAtrasoMulta = WorkDiasAtrasoMulta,
                OutPercentualMultaTitulo = InEntradaCalculo.InPercentualMulta,
                OutPercentualMultaConfig = WorkFF000?.Ff000PercMulta,

                OutDiasAtrasoCorrecaoMonetaria = WorkDiasAtrasoCorrecaoMonetaria,
                OutValorCorrecaoMonetaria = WorkValorCalculoCorrecaoMonetaria,
                OutPercentualCorrecaoMonetariaTitulo = InEntradaCalculo.InPercentualCorrecaoMonetaria,
                OutPercentualCorrecaoMonetariaConfig = WorkFF000?.Ff000PercCorrmonetaria,

                OutValorHonorario = WorkValorCalculoHonorario,
                OutDiasAtrasoHonorario = WorkDiasAtrasoHonorario,
                OutPercentualHonorarioTitulo = InEntradaCalculo.InPercentualHonorarios,
                OutPercentualHonorarioConfig = WorkFF000?.Ff000PercHonorarios,

            };
        }



        private async Task<CSICP_FF000?> RecuperarParametrosTitulo(PrmEntradaCalculo InEntradaCalculo)
        {
            return await _appDbContext.OsusrE9aCsicpFf000s
                .Where(e => e.TenantId == InEntradaCalculo.InTenantID
                && e.Ff000EstabId == InEntradaCalculo.InEstabID)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }



        private class ParametrosCalculoLocal
        {
            public DateTime DataVencimento { get; set; }
            public decimal ValorTitulo { get; set; }
            public decimal? PercentualJuros { get; set; }
            public decimal? ValorJurosDias { get; set; }
            public decimal? ValorMulta { get; set; }
            public decimal? PercentualMulta { get; set; }
            public decimal? PercentualHonorarios { get; set; }
            public decimal? PercentualCorrecaoMonetaria { get; set; }
            public int? DiasLiberacao { get; set; }
            public bool FinacEspJurosMulta { get; set; }
        }
    }
}
