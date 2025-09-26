using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;

public class GeraMemoriaCalculoFF043_FF102RepositoryImpl : IGeraMemoriaCalculoFF043_FF102Repository
{
    private readonly AppDbContext _context;

    public GeraMemoriaCalculoFF043_FF102RepositoryImpl(AppDbContext context)
    {
        _context = context;
    }

    public async Task GeraFormaPagtotoMemoriaCalculoFF043_FF102(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
    {
        await GeraFF042APartirDaFF040Async(prm);

        //recuperar a bb008 para pegar o ID do tipo
        //recuperar o id dabb008 correspondente dessa 
        //passar o generate protocolo
        //passar o generateID
        //passar o numero de parcela
        //passar o valor de entrada
        //passar o appDbContext
        //precisa testar o processar parcela tipo parcela no foreach ao gerar a enitdade
        //precisa testar tambem o CondicaoPagamentoDividia

        var prmGeraMemoriaCalculo = new CreateParaMemoriaCalculoFF043Params();
        IAuxProcessarCalculoTitulo processarCalculoTitulo
            = ProcessarRenegociacaoCalcTituloFactory.CreateParaMemoriaCalculoFF043(prmGeraMemoriaCalculo);


        //precisa refatorar para receber os parametros
        // processarCalculoTitulo.Processar();

    }

    private async Task GeraFF042APartirDaFF040Async(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm)
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
            NroParcelas: prm.InNroParcelas);

        _context.Add(WorkFF042);
    }
}
