using System;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.Parametros;

/*PARAMETROS USADOS NA FACTORY PARA MEMORIA FF043*/
public class CreateParaMemoriaCalculoFF043Params
{
    private CreateParaMemoriaCalculoFF043Params()
    {
    }

    public int In_StID_bb008_tp_Dias { get; set; }
    public int In_StID_bb008_tp_ParcelaDias { get; set; }
    public int In_StID_bb008_tp_ParcelaMes { get; set; }
    public int In_StID_bb008_tp_A_vista { get; set; }
    public int InTipoBB008_ID_Recuperada { get; set; }
    public IGenerateProtocolo Protocolo { get; set; }
    public ICS_GenerateId InGenerateId { get; set; } = null!;
    public string InEmpresaID { get; set; } = null!;
    public int InNumeroDeParcelas { get; set; }
    public decimal InValorEntrada { get; set; }
    public AppDbContext InAppDbContext { get; set; } = null!;
    public string FF003_Pfx { get; set; } = "";

    public static CreateParaMemoriaCalculoFF043Params Create(
        int in_StID_bb008_tp_Dias,
        int in_StID_bb008_tp_ParcelaDias,
        int in_StID_bb008_tp_ParcelaMes,
        int in_StID_bb008_tp_A_vista,
        int inTipoBB008_ID_Recuperada,
        IGenerateProtocolo Protocolo,
        ICS_GenerateId inGenerateId,
        string inEmpresaID,
        int inNumeroDeParcelas,
        decimal inValorEntrada,
        AppDbContext inAppDbContext,
        string FF003_Pfx
        )
    {
        return new CreateParaMemoriaCalculoFF043Params
        {
            In_StID_bb008_tp_Dias = in_StID_bb008_tp_Dias,
            In_StID_bb008_tp_ParcelaDias = in_StID_bb008_tp_ParcelaDias,
            In_StID_bb008_tp_ParcelaMes = in_StID_bb008_tp_ParcelaMes,
            In_StID_bb008_tp_A_vista = in_StID_bb008_tp_A_vista,
            InTipoBB008_ID_Recuperada = inTipoBB008_ID_Recuperada,
            Protocolo = Protocolo,
            InGenerateId = inGenerateId,
            InEmpresaID = inEmpresaID,
            InNumeroDeParcelas = inNumeroDeParcelas,
            InValorEntrada = inValorEntrada,
            InAppDbContext = inAppDbContext,
            FF003_Pfx = FF003_Pfx

        };
    }

}
