using System;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;

public record PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository(
    int InTenantID,
    string InEmpresaID,
    long InFF040_ID,
    DateTime InDataBaseVencimento,
    string InFormaPgtoID,
    string InCondicaoPgtoID,
    int InNroDeParcelas,
    decimal InFaturaTotal,
    int In_StID_bb008_tp_Dias,
    int In_StID_bb008_tp_ParcelaDias,
    int In_StID_bb008_tp_ParcelaMes,
    int In_StID_bb008_tp_A_vista
    );

public interface IGeraMemoriaCalculoFF043_FF102Repository
{
    Task GeraFormaPagtotoMemoriaCalculoFF043_FF102(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm);
    Task CS_005_GeraContasAPagar(
         int InTenantID,
         long InFF040_ID,
         int InStID_FF040Sit_Registrado);
}
