using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoAVista;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoDia;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Pkcs;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;

public class GeraMemoriaCalculoFF043_FF102RepositoryImpl : IGeraMemoriaCalculoFF043_FF102Repository
{
    private readonly AppDbContext _context;
    private readonly IGenerateProtocolo generateProtocolo;
    private readonly ICS_GenerateId generateId;

    public GeraMemoriaCalculoFF043_FF102RepositoryImpl(AppDbContext context, IGenerateProtocolo generateProtocolo, ICS_GenerateId generateId)
    {
        _context = context;
        this.generateProtocolo = generateProtocolo;
        this.generateId = generateId;
    }

    public async Task GeraFormaPagtotoMemoriaCalculoFF043_FF102(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
    {
        var idFF042 = await GeraFF042APartirDaFF040Async(prm);
        await GerarMemoriaCalculoFF043Async(prm, idFF042);
    }


    public async Task CS_005_GeraContasAPagar(
        int InTenantID,
        long InFF040_ID,
        int InStID_FF040Sit_Registrado,
        int InStID_FF102_Ent_Parcela,
        int InStID_FF102_Sit_Aberto,
        int InStID_FF102_Sit_Provisao,
        int InStID_FF102_Aut_PagamentoAutorizado,
        int InStID_FF102_Aut_PagamentoNaoAutorizado,
        int InStID_Entities_SIM,
        int InStID_Entities_NAO
        )
    {
        CSICP_FF040 WorkFF040 = await ObterFF040PorIdAsync(InTenantID, InFF040_ID);
        List<long> ff042IdList = await ObterFF042IdsPorFF040Async(InTenantID, InFF040_ID);
        List<CSICP_FF043> WorkListFF043 
            = await ObterFF043PorFF042IdsAsync(InTenantID, ff042IdList);


        List<CSICP_FF102> WorkListFF102_Adicionados = new List<CSICP_FF102>();  
        foreach (var current in WorkListFF043)
        {
            string generatedTituloId = generateId.GenerateUuId();
            var observacao = "Geração em massa de Titulos " +
            (WorkFF040.Ff040Tiporegistro == 3 ? "CP" : "CR") + " " +
            (WorkFF040.Ff040Protocolnumber ?? "") + " " +
            (WorkFF040.Ff040Texto ?? "");

            bool ff000_IsDesabFcConfAut = await ObterIsDesabilitaFcConfAutAsync(InTenantID);

            CSICP_FF102 titulo = MontarFF102(InTenantID, InStID_FF102_Ent_Parcela, InStID_FF102_Sit_Aberto, InStID_FF102_Sit_Provisao, InStID_FF102_Aut_PagamentoAutorizado, InStID_FF102_Aut_PagamentoNaoAutorizado, InStID_Entities_SIM, InStID_Entities_NAO, WorkFF040, WorkListFF043, current, generatedTituloId, observacao, ff000_IsDesabFcConfAut);
            WorkListFF102_Adicionados.Add(titulo);


        }

        WorkFF040.Ff040Situacaoid = InStID_FF040Sit_Registrado;
    }

    private async Task<bool> ObterIsDesabilitaFcConfAutAsync(int InTenantID)
    {
        return await _context.OsusrE9aCsicpFf000s
            .AsNoTracking()
            .Where(e => e.TenantId == InTenantID)
            .Where(e => e.Ff000EstabId == "")
            .Select(e => e.Ff000Isdesabfcconfaut)
            .FirstOrDefaultAsync() ?? false;
    }

    private static CSICP_FF102 MontarFF102(int InTenantID, int InStID_FF102_Ent_Parcela, int InStID_FF102_Sit_Aberto, int InStID_FF102_Sit_Provisao, int InStID_FF102_Aut_PagamentoAutorizado, int InStID_FF102_Aut_PagamentoNaoAutorizado, int InStID_Entities_SIM, int InStID_Entities_NAO, CSICP_FF040 WorkFF040, List<CSICP_FF043> WorkListFF043, CSICP_FF043 current, string generatedTituloId, string observacao, bool ff000_IsDesabFcConfAut)
    {
        return CSICP_FF102.CreateInstance(
               tenantId: InTenantID,
               id: generatedTituloId,
               ff102Tiporegistro: WorkFF040.Ff040Tiporegistro == 1 ? 1 : 3,
               ff102Filialid: WorkFF040.Ff040Empresaid,
               ff102Tipoparcelaid: InStID_FF102_Ent_Parcela,
               ff102ParcelaX: current.Ff043Parcela,
               ff102ParcelaY: WorkListFF043.Count,
               ff102Pfx: current.Ff043Pfxtitulo,
               ff102Sfx: current.Ff043Sfxtitulo,
               ff102Contaid: WorkFF040.Ff040ContaId,
               ff102Contarealid: WorkFF040.Ff040ContaId,
               ff102Ccustoid: WorkFF040.Ff040CcustoId,
               ff102Usuarioproprieid: WorkFF040.Ff040UsuarioProprId,
               ff102Agcobradorid: WorkFF040.Ff040AgcobradorId,
               ff102Responsavelid: WorkFF040.Ff040ResponsavelId,
               ff102Administradoraid: null,
               ff102DataEmissao: WorkFF040.Ff040DataMovimento,
               ff102Cdatamovimento: current.Ff043DataVencto,
               ff102ValorTitulo: Math.Round(current.Ff043ValorParcela ?? 0, 2),
               ff102VlLiqTitulo: Math.Round(current.Ff043ValorParcela ?? 0, 2),
               ff102Observacao: observacao,
               ff102FluxoCaixa: InStID_Entities_SIM,
               ff102Situacaoid: WorkFF040.Ff040Isprovisao == true ? InStID_FF102_Sit_Provisao : InStID_FF102_Sit_Aberto,
               ff102NoTitulo: current.Ff043Titulo,
               ff10FpagtoId: "42",
               ff102Condicaoid: "42",
               ff102cpConfirmadoId: ff000_IsDesabFcConfAut ? InStID_Entities_SIM : InStID_Entities_NAO,
               ff102cpPagtoautorizadoId: ff000_IsDesabFcConfAut ? InStID_FF102_Aut_PagamentoAutorizado : InStID_FF102_Aut_PagamentoNaoAutorizado,
               ff102Especieid: WorkFF040.Ff040EspecieId == null ? 42 : WorkFF040.Ff040EspecieId);
    }

    private async Task<List<CSICP_FF043>> ObterFF043PorFF042IdsAsync(int InTenantID, List<long> ff042IdList)
    {
        List<CSICP_FF043> WorkListFF043 = await _context.OsusrE9aCsicpFf043s
                    .Where(e => e.TenantId == InTenantID)
                    .Where(e => e.Ff043TituloCpId == null)
                    .Where(e => ff042IdList.Contains(e.Ff042Id))
                    .ToListAsync();

        if (!WorkListFF043.Any()) throw new EmptyListException("Sem CSICP_FF043 para gerar contas a pagar");
        return WorkListFF043;
    }

    private async Task<List<long>> ObterFF042IdsPorFF040Async(int InTenantID, long InFF040_ID)
    {
        List<CSICP_FF042> WorkListFF042 =
                    await _context.OsusrE9aCsicpFf042s
                    .Where(e => e.TenantId == InTenantID && e.Ff040Id == InFF040_ID)
                    .ToListAsync();

        if (!WorkListFF042.Any()) throw new EmptyListException("Sem forma de pagamento no movimento");

        List<long> ff042IdList = WorkListFF042.DistinctBy(e => e.Ff042Id).Select(e => e.Ff042Id).ToList();
        return ff042IdList;
    }

    private async Task<CSICP_FF040> ObterFF040PorIdAsync(int InTenantID, long InFF040_ID)
    {
        return await _context.OsusrE9aCsicpFf040s
            .Where(e => e.TenantId == InTenantID && e.Ff040Id == InFF040_ID)
            .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("FF040 não encontrada");
    }

    private async Task GerarMemoriaCalculoFF043Async(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm, long idFF042)
    {
        CSICP_Bb008 work_bb008 = await ObterCondicaoPagamentoBb008(prm.InTenantID, prm.InCondicaoPgtoID);

        decimal Protocolo = await this.generateProtocolo.Fcn_Protocolo10(prm.InEmpresaID, "CPAGAR", prm.InTenantID);

        var prmGeraMemoriaCalculo = CreateParaMemoriaCalculoFF043Params.Create(
            in_StID_bb008_tp_Dias: prm.In_StID_bb008_tp_Dias,
            in_StID_bb008_tp_ParcelaDias: prm.In_StID_bb008_tp_ParcelaDias,
            in_StID_bb008_tp_ParcelaMes: prm.In_StID_bb008_tp_ParcelaMes,
            in_StID_bb008_tp_A_vista: prm.In_StID_bb008_tp_A_vista,
            inTipoBB008_ID_Recuperada: work_bb008.Bb008Tipoid ?? -1,
            Protocolo: Protocolo,
            inGenerateId: generateId,
            inEmpresaID: prm.InEmpresaID,
            inNumeroDeParcelas: prm.InNroDeParcelas,
            inValorEntrada: 0m,
            inAppDbContext: _context
        );


        IAuxProcessarCalculoTitulo? processarCalculoTitulo
            = GerarMemoriaCalcFF04XFactory.RetornaInstanciaParaExecutarOCalculo(prmGeraMemoriaCalculo);


        #warning PRECISA ALTERAR PRA STRATEGY!!!!
        if (processarCalculoTitulo is ProcessarParcelasTipoParcelaDiasOuMes)
            processarCalculoTitulo = processarCalculoTitulo as ProcessarParcelasTipoParcelaDiasOuMesParaFF043;
        else if (processarCalculoTitulo is ProcessarCalculoTituloTipoDias)
            processarCalculoTitulo = processarCalculoTitulo as ProcessarParcelasTipoParcelaDiaParaFF043;
        else if (processarCalculoTitulo is ProcessarCalculoTipoAVista)
            processarCalculoTitulo = processarCalculoTitulo as ProcessarParcelasTipoAVistaParaFF043;

        RetornoFinanciamento calculoFinanciamento = CalcularValoresdeFinanciamento(work_bb008, prm);

        /*GERA MEMÓRIA*/
        await processarCalculoTitulo!.Processar(
           InControleID: idFF042.ToString(),
           InData: DateOnly.FromDateTime(prm.InDataBaseVencimento),
           InTenantID: prm.InTenantID,
           ina_calculoFinanciamento: calculoFinanciamento
        );
    }

    private RetornoFinanciamento CalcularValoresdeFinanciamento(CSICP_Bb008 work_bb008, PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
    {
       

        int work_qtd_parcelas
                    = CondicaoPagamentoAvaliador
                    .AvaliarCondicaoPagamento(
                        prm.In_StID_bb008_tp_ParcelaDias,
                        prm.In_StID_bb008_tp_ParcelaMes,
                        prm.In_StID_bb008_tp_Dias,
                        work_bb008,
                        work_bb008.Bb008Condicao?.Split(';') ?? []);

        RetornoFinanciamento calculoFinanciamento 
            = FinanciamentoCalculator.CalcularValoresFinanciamento(
            faturaTotal: prm.InFaturaTotal,
            qtdParcelas: work_qtd_parcelas,
            valorEntrada: 0m);
        return calculoFinanciamento;
    }

    private async Task<long> GeraFF042APartirDaFF040Async(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
    {
        CSICP_FF040 WorkFF040 = await _context.OsusrE9aCsicpFf040s
                    .Where(e => e.TenantId == prm.InTenantID && e.Ff040Id == prm.InFF040_ID)
                    .AsNoTracking()
                    .FirstOrDefaultAsync() ?? throw new Exception("FF040 não encontrada");

        WorkFF040.Ff040Dbasevencto = prm.InDataBaseVencimento;

        CSICP_FF042 WorkFF042 = CSICP_FF042.Create(
            ff040Entity: WorkFF040,
            formaPgtoID: prm.InFormaPgtoID,
            condicaoPgtoID: prm.InCondicaoPgtoID,
            NroParcelas: prm.InNroDeParcelas);

        var result = _context.Add(WorkFF042);
        return WorkFF042.Ff042Id;
    }

    
   private async Task<CSICP_Bb008> ObterCondicaoPagamentoBb008(int InTenantID, string InCondicaoPagamentoID)
        {
            return await _context.OsusrE9aCsicpBb008s
                                .Where(e => e.TenantId == InTenantID
                                && e.Id == InCondicaoPagamentoID)
                                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Condição de pagamento não encontrada!");
        }

}
