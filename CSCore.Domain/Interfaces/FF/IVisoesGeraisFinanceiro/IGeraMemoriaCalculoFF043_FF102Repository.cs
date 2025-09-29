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


public record CS_005_GeraContasAPagarParametros
     (
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
     );


public interface IGeraMemoriaCalculoFF043_FF102Repository
{
    Task GeraFormaPagtotoMemoriaCalculoFF043_FF102(PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository prm);
    Task CS_005_GeraContasAPagar(CS_005_GeraContasAPagarParametros prm);
}
