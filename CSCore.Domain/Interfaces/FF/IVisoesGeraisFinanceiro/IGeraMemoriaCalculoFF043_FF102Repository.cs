using System;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;

public record PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository(
    int InTenantID,
    long InFF040_ID,
    DateTime InDataBaseVencimento, 
    string InFormaPgtoID,
    string InCondicaoPgtoID,
    int InNroParcelas
    );

public interface IGeraMemoriaCalculoFF043_FF102Repository
{
    Task GeraFormaPagtotoMemoriaCalculoFF043_FF102(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm);
}
