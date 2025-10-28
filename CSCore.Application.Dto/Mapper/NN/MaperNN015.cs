using CSCore.Application.Dto.Mapper.NN._015;
using CSCore.Domain.CS_Models.CSICP_NN;

namespace CSCore.Application.Dto.Mapper.NN
{
    public static class MaperNN015
    {
        public static DtoGetNN015 ToDtoGet(this CSICP_NN015 entity)
        {
            return new DtoGetNN015
            {
                TenantId = entity.TenantId,
                Nn015CrcpId = entity.Nn015CrcpId,
                Nn015FilialId = entity.Nn015FilialId,
                Nn015Filial = entity.Nn015Filial,
                Nn015TipoMovtoid = entity.Nn015TipoMovtoid,
                Nn015Ciorigemestorno = entity.Nn015Ciorigemestorno,
                Nn015DataMovimento = entity.Nn015DataMovimento,
                Nn015CtacorrenteId = entity.Nn015CtacorrenteId,
                Nn015CodgCcorrente = entity.Nn015CodgCcorrente,
                Nn015Documento = entity.Nn015Documento,
                Nn015Ischeque = entity.Nn015Ischeque,
                Nn015NoCheque = entity.Nn015NoCheque,
                Nn015Agencia = entity.Nn015Agencia,
                Nn015Banco = entity.Nn015Banco,
                Nn015ContaId = entity.Nn015ContaId,
                Nn015Clientefornec = entity.Nn015Clientefornec,
                Nn015BomPara = entity.Nn015BomPara,
                Nn015Venctoinicial = entity.Nn015Venctoinicial,
                Nn015Venctofinal = entity.Nn015Venctofinal,
                Nn015TotalTitulo = entity.Nn015TotalTitulo,
                Nn015TotalJuros = entity.Nn015TotalJuros,
                Nn015TotalMulta = entity.Nn015TotalMulta,
                Nn015TotalDescontos = entity.Nn015TotalDescontos,
                Nn015TotalTaxa = entity.Nn015TotalTaxa,
                Nn015TotalPago = entity.Nn015TotalPago,
                Nn015Historico = entity.Nn015Historico,
                Nn015Favorecido = entity.Nn015Favorecido,
                Nn015Status = entity.Nn015Status,
                Nn015GrupoId = entity.Nn015GrupoId,
                Nn015ClasseId = entity.Nn015ClasseId,
                Nn015CcustoId = entity.Nn015CcustoId,
                Nn015AgcobradorId = entity.Nn015AgcobradorId,
                Nn015Tipomovimento = entity.Nn015Tipomovimento,
                Nn015Isestorno = entity.Nn015Isestorno,
                Nn015UsuariopropId = entity.Nn015UsuariopropId,
                Nn015TotaljurosCalc = entity.Nn015TotaljurosCalc,
                Nn015TotalmultaCalc = entity.Nn015TotalmultaCalc,
                Nn015TotaltaxaCalc = entity.Nn015TotaltaxaCalc,
                Nn015Protocolnumber = entity.Nn015Protocolnumber,
                Nn015Dbaixatit = entity.Nn015Dbaixatit,
                Nn015Dcreditotit = entity.Nn015Dcreditotit,
                Nn015TaxaAntecipacao = entity.Nn015TaxaAntecipacao,
                Nn015ValorTxAntcartao = entity.Nn015ValorTxAntcartao,
                Nn015Tcorrmonetaria = entity.Nn015Tcorrmonetaria,
                Nn015Thonorarios = entity.Nn015Thonorarios,

            };
        }
    }
}
