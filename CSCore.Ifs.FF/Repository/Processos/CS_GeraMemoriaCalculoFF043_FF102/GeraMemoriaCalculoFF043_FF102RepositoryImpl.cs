using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.Parametros;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoAVista;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoDia;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
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

    public async Task<CSICP_FF042> GerarFormaPagamentoMemoriaCalculo(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
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
        return WorkFF042;
    }


    public async Task CS_005_GeraContasAPagar(CS_005_GeraContasAPagarParametros prm)
    {
        CSICP_FF040 WorkFF040 = await ObterFF040PorIdAsync(prm.InTenantID, prm.InFF040_ID);
        List<long> ff042IdList = await ObterFF042IdsPorFF040Async(prm.InTenantID, prm.InFF040_ID);
        List<CSICP_FF043> WorkListFF043 
            = await ObterFF043PorFF042IdsAsync(prm.InTenantID, ff042IdList);

        foreach (var currentFF043 in WorkListFF043)
        {
            string? especieBB026ID_Da_Forma = await ObterEspecieIdDaFormaPgtoAsync(prm);
            string generatedTituloId = generateId.GenerateUuId();
            bool ff000_IsDesabFcConfAut = await ObterIsDesabilitaFcConfAutAsync(prm.InTenantID, WorkFF040.Ff040Empresaid);

            CSICP_FF102 titulo = MontarFF102(
                prm,
                WorkFF040,
                WorkFF043: currentFF043,
                WorkListFF043.Count,
                ff000_IsDesabFcConfAut,
                bb026_especieID: especieBB026ID_Da_Forma,
                generatedTituloId);

            CSICP_FF104 cSICP_FF104 = MontarFF104(prm, WorkFF040, titulo);

            _context.Add(titulo);
            _context.Add(cSICP_FF104);

            //currentFF043.Ff043TituloCpId = generatedTituloId;
        }

        WorkFF040.Ff040Situacaoid = prm.InStID_FF040Sit_Registrado;
    }

    public async Task GerarMemoriaCalculoFF043Async(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm, long idFF042)
    {
        CSICP_Bb008 work_bb008 = await ObterCondicaoPagamentoBb008(prm.InTenantID, prm.InCondicaoPgtoID);

        decimal Protocolo = await this.generateProtocolo.Fcn_Protocolo10(prm.InEmpresaID, "CPAGAR", prm.InTenantID);

        var prmGeraMemoriaCalculo = CreateParaMemoriaCalculoFF043Params.Create(
            in_StID_bb008_tp_Dias: prm.In_StID_bb008_tp_Dias,
            in_StID_bb008_tp_ParcelaDias: prm.In_StID_bb008_tp_ParcelaDias,
            in_StID_bb008_tp_ParcelaMes: prm.In_StID_bb008_tp_ParcelaMes,
            in_StID_bb008_tp_A_vista: prm.In_StID_bb008_tp_A_vista,
            inTipoBB008_ID_Recuperada: work_bb008.Bb008Tipoid ?? -1,
            Protocolo: this.generateProtocolo,
            inGenerateId: generateId,
            inEmpresaID: prm.InEmpresaID,
            inNumeroDeParcelas: prm.InNroDeParcelas,
            inValorEntrada: 0m,
            inAppDbContext: _context
        );


        IAuxProcessarCalculoTitulo? processarCalculoTitulo
            = GerarMemoriaCalcFF04XFactory.RetornaInstanciaParaExecutarOCalculo(prmGeraMemoriaCalculo);



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





    /*PRIVADOS*/

    private async Task<string?> ObterEspecieIdDaFormaPgtoAsync(CS_005_GeraContasAPagarParametros prm)
    {
        return await _context.OsusrE9aCsicpBb026s
            .Where(e => e.TenantId == prm.InTenantID && e.Id == prm.InFormaPgtoID).AsNoTracking().Select(e => e.Bb026EspecieId).FirstOrDefaultAsync();
    }

    private CSICP_FF104 MontarFF104(CS_005_GeraContasAPagarParametros prm, CSICP_FF040 WorkFF040, CSICP_FF102 titulo)
    {
        return CSICP_FF104.CreateInstance(
            tenantId: prm.InTenantID,
            id: generateId.GenerateUuId(),
            filialID: WorkFF040.Ff040Empresaid ?? null,
            ff102_id: titulo.Id,
            ff040_id: WorkFF040.Ff040Id,
            pfx: titulo.Ff102Pfx ?? "",
            sfx: titulo.Ff102Sfx ?? "",
            noTitulo: titulo.Ff102NoTitulo ?? 0,
            nfNoCupom: decimal.Parse(WorkFF040.Ff040Protocolnumber ?? "0"),
            dataEmissao: DateOnly.FromDateTime(WorkFF040.Ff040DataMovimento),
            valorNF: Math.Round(titulo.Ff102ValorTitulo ?? 0, 2)
            );
    }

    private async Task<bool> ObterIsDesabilitaFcConfAutAsync(int InTenantID, string? InBB001_ID)
    {
        return await _context.OsusrE9aCsicpFf000s
            .AsNoTracking()
            .Where(e => e.TenantId == InTenantID)
            .Where(e => e.Ff000EstabId == InBB001_ID)
            .Select(e => e.Ff000Isdesabfcconfaut)
            .FirstOrDefaultAsync() ?? false;
    }

    private CSICP_FF102 MontarFF102(
        CS_005_GeraContasAPagarParametros prm, CSICP_FF040 WorkFF040, CSICP_FF043 WorkFF043,int WorkListFF043Count,
        bool ff000_IsDesabFcConfAut, string? bb026_especieID, string tituloIDGerado)
    {
      
        var observacao = "V-Geração em massa de Titulos " +
           (WorkFF040.Ff040Tiporegistro == 3 ? "CP" : "CR") + " " +
           (WorkFF040.Ff040Protocolnumber ?? "") + " " +
           (WorkFF040.Ff040Texto ?? "");

        return CSICP_FF102.CreateInstance(
               tenantId: prm.InTenantID,
               id: tituloIDGerado,
               ff102Tiporegistro: WorkFF040.Ff040Tiporegistro == 1 ? 1 : 3,
               ff102Filialid: WorkFF040.Ff040Empresaid,
               ff102Tipoparcelaid: prm.InStID_FF102_Ent_Parcela,
               ff102ParcelaX: WorkFF043.Ff043Parcela,
               ff102ParcelaY: WorkListFF043Count,
               ff102Pfx: WorkFF043.Ff043Pfxtitulo,
               ff102Sfx: WorkFF043.Ff043Sfxtitulo,
               ff102Contaid: WorkFF040.Ff040ContaId,
               ff102Contarealid: WorkFF040.Ff040ContaId,
               ff102Ccustoid: WorkFF040.Ff040CcustoId,
               ff102Usuarioproprieid: WorkFF040.Ff040UsuarioProprId,
               ff102Agcobradorid: WorkFF040.Ff040AgcobradorId,
               ff102Responsavelid: WorkFF040.Ff040ResponsavelId,
               ff102Administradoraid: null,
               ff102DataEmissao: WorkFF040.Ff040DataMovimento,
               ff102Cdatamovimento: WorkFF043.Ff043DataVencto,
               ff102ValorTitulo: Math.Round(WorkFF043.Ff043ValorParcela ?? 0, 2),
               ff102VlLiqTitulo: Math.Round(WorkFF043.Ff043ValorParcela ?? 0, 2),
               ff102Observacao: observacao,
               ff102FluxoCaixa: prm.InStID_Entities_SIM,
               ff102Situacaoid: WorkFF040.Ff040Isprovisao == true ? prm.InStID_FF102_Sit_Provisao : prm.InStID_FF102_Sit_Aberto,
               ff102NoTitulo: WorkFF043.Ff043Titulo,
               ff10FpagtoId: prm.InFormaPgtoID,
               ff102Condicaoid: prm.InCondicaoPgtoID,
               ff102cpConfirmadoId: ff000_IsDesabFcConfAut ? prm.InStID_Entities_SIM : prm.InStID_Entities_NAO,
               ff102cpPagtoautorizadoId: ff000_IsDesabFcConfAut ? prm.InStID_FF102_Aut_PagamentoAutorizado : prm.InStID_FF102_Aut_PagamentoNaoAutorizado,
               ff102Especieid: WorkFF040.Ff040EspecieId != null ? WorkFF040.Ff040EspecieId : bb026_especieID);
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

   

    private RetornoFinanciamento CalcularValoresdeFinanciamento(CSICP_Bb008 work_bb008, PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
    {
       
        //ERRO 1, DEVE USAR A QTD DE PARCELAS QUE FOI PASSADA
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

    
   private async Task<CSICP_Bb008> ObterCondicaoPagamentoBb008(int InTenantID, string InCondicaoPagamentoID)
        {
            return await _context.OsusrE9aCsicpBb008s
                                .Where(e => e.TenantId == InTenantID
                                && e.Id == InCondicaoPagamentoID)
                                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Condição de pagamento não encontrada!");
        }

}
