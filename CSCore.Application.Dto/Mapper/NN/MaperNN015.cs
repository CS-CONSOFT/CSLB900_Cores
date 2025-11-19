using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.NN._015;
using CSCore.Application.Dto.Dtos.NN.Dto;
using CSCore.Application.Dto.Mapper.NN._015;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_NN;
using System.Runtime.CompilerServices;

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
                NavNN001 = entity.NavNN001,
                NavNN015Status = entity.NavNN015Status,
                NavNN015Rp = entity.NavNN015Rp,
                NavNN015Filial = entity.NavNN015Filial?.ToDtoGetSimples(),
                NavSY001Usuario = entity.NavNn015Usuarioprop?.ToDtoGetSimples()

            };
        }

        public static DtoGetNN016 ToDtoGet(this CSICP_NN016 entity)
        {
            return new DtoGetNN016
            {
                TenantId = entity.TenantId,
                Nn016Id = entity.Nn016Id,
                Nn016CrcpId = entity.Nn016CrcpId,
                Nn016Filial = entity.Nn016Filial,
                Nn016TipoMovimento = entity.Nn016TipoMovimento,
                Nn016FilialBaixa = entity.Nn016FilialBaixa,
                Nn016TituloId = entity.Nn016TituloId,

                Nn016Prefixo = entity.Nn016Prefixo,
                Nn016Titulo = entity.Nn016Titulo,
                Nn016Sfx = entity.Nn016Sfx,
                Nn016SequenciaBaixa = entity.Nn016SequenciaBaixa,
                Nn016DataVencimento = entity.Nn016DataVencimento,
                Nn016Diasatraso = entity.Nn016Diasatraso,
                Nn016Vlrabertotitulos = entity.Nn016Vlrabertotitulos,
                Nn016ValorJuros = entity.Nn016ValorJuros,
                Nn016ValorDesconto = entity.Nn016ValorDesconto,
                Nn016ValorMulta = entity.Nn016ValorMulta,
                Nn016ValorTaxa = entity.Nn016ValorTaxa,
                Nn016ValorPago = entity.Nn016ValorPago,
                Nn016SituacaotitId = entity.Nn016SituacaotitId,

                Nn016BaixarSn = entity.Nn016BaixarSn,
                Nn016CliFor = entity.Nn016CliFor,
                Nn016Historico = entity.Nn016Historico,
                Nn016Mensagem = entity.Nn016Mensagem,
                Nn016ValorJurosCalc = entity.Nn016ValorJurosCalc,
                Nn016ValorMultaCalc = entity.Nn016ValorMultaCalc,
                Nn016ValorTaxaCalc = entity.Nn016ValorTaxaCalc,
                Nn016TotalApagar = entity.Nn016TotalApagar,
                Nn016Protocolnumber = entity.Nn016Protocolnumber,
                Nn016IdEstorno = entity.Nn016IdEstorno,
                Nn016TaxaAntecipacao = entity.Nn016TaxaAntecipacao,
                Nn016ValorTxAntcartao = entity.Nn016ValorTxAntcartao,
                Nn016Vcorrmonetaria = entity.Nn016Vcorrmonetaria,
                Nn016Vhonorarios = entity.Nn016Vhonorarios,
                Nav_FF102Sit = entity.NavFF102Sit,
                Nav_GetBB001Simples = entity.NavFF102Titulo?.NavBB001?.ToDtoGetSimples(),
                Nav_GetBB012Simples = entity.NavFF102Titulo?.NavBB012?.ToDtoGetExibSimples()
            };
        }

        public static DtoGetNN015Padrao ToDtoGetNN015Padrao(this CSICP_NN015 entity)
        {
            return new DtoGetNN015Padrao
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
                Nn015Thonorarios = entity.Nn015Thonorarios
            };
        }
    }
}
