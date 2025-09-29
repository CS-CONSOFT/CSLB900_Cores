using System;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;

public record ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
        IGenerateProtocolo Protocolo,
        ICS_GenerateId GenerateId,
        string EmpresaID,
        string[] Aux_condicaoPagtoDividida,
        decimal Work_valor_entrada,
        AppDbContext AppDbContext,
        IIncrementarDataStrategy IncrementarDataStrategy
);
