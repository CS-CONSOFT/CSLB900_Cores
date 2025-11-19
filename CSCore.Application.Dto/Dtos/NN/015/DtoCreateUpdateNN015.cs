using CSCore.Domain.CS_Models.CSICP_NN;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.NN._015
{
    public class DtoCreateUpdateNN015 : IConverteParaEntidade<CSICP_NN015>
    {
        public string? Nn015FilialId { get; set; }

        public int? Nn015TipoMovtoid { get; set; }

        public decimal? Nn015Ciorigemestorno { get; set; }

        public DateTime? Nn015DataMovimento { get; set; }

        public string? Nn015CtacorrenteId { get; set; }

        public int? Nn015CodgCcorrente { get; set; }

        public string? Nn015Documento { get; set; }

        public bool? Nn015Ischeque { get; set; }

        public int? Nn015NoCheque { get; set; }

        public string? Nn015Agencia { get; set; }

        public int? Nn015Banco { get; set; }

        public string? Nn015ContaId { get; set; }

        public int? Nn015Clientefornec { get; set; }

        public DateTime? Nn015BomPara { get; set; }

        public DateTime? Nn015Venctoinicial { get; set; }

        public DateTime? Nn015Venctofinal { get; set; }

        public decimal? Nn015TotalTitulo { get; set; }

        public decimal? Nn015TotalJuros { get; set; }

        public decimal? Nn015TotalMulta { get; set; }

        public decimal? Nn015TotalDescontos { get; set; }

        public decimal? Nn015TotalTaxa { get; set; }

        public decimal? Nn015TotalPago { get; set; }

        public string? Nn015Historico { get; set; }

        public string? Nn015Favorecido { get; set; }

        public int? Nn015Status { get; set; }

        public string? Nn015GrupoId { get; set; }

        public string? Nn015ClasseId { get; set; }

        public string? Nn015CcustoId { get; set; }

        public string? Nn015AgcobradorId { get; set; }

        public int? Nn015Tipomovimento { get; set; }

        public bool? Nn015Isestorno { get; set; }

        public string? Nn015UsuariopropId { get; set; }

        public decimal? Nn015TotaljurosCalc { get; set; }

        public decimal? Nn015TotalmultaCalc { get; set; }

        public decimal? Nn015TotaltaxaCalc { get; set; }

        public string? Nn015Protocolnumber { get; set; }

        public DateTime? Nn015Dbaixatit { get; set; }

        public DateTime? Nn015Dcreditotit { get; set; }

        public decimal? Nn015TaxaAntecipacao { get; set; }

        public decimal? Nn015ValorTxAntcartao { get; set; }

        public decimal? Nn015Tcorrmonetaria { get; set; }

        public decimal? Nn015Thonorarios { get; set; }
        public CSICP_NN015 ToEntity(int tenant, string? id)
        {
            return new CSICP_NN015
            {
                TenantId = tenant,
                Nn015CrcpId = id!,
                Nn015Filial = null,
                Nn015FilialId = this.Nn015FilialId,
                Nn015TipoMovtoid = this.Nn015TipoMovtoid,
                Nn015Ciorigemestorno = this.Nn015Ciorigemestorno,
                Nn015DataMovimento = this.Nn015DataMovimento,
                Nn015CtacorrenteId = this.Nn015CtacorrenteId,
                Nn015CodgCcorrente = this.Nn015CodgCcorrente,
                Nn015Documento = this.Nn015Documento,
                Nn015Ischeque = this.Nn015Ischeque,
                Nn015NoCheque = this.Nn015NoCheque,
                Nn015Agencia = this.Nn015Agencia,
                Nn015Banco = this.Nn015Banco,
                Nn015ContaId = this.Nn015ContaId,
                Nn015Clientefornec = this.Nn015Clientefornec,
                Nn015BomPara = this.Nn015BomPara,
                Nn015Venctoinicial = this.Nn015Venctoinicial,
                Nn015Venctofinal = this.Nn015Venctofinal,
                Nn015TotalTitulo = this.Nn015TotalTitulo,
                Nn015TotalJuros = this.Nn015TotalJuros,
                Nn015TotalMulta = this.Nn015TotalMulta,
                Nn015TotalDescontos = this.Nn015TotalDescontos,
                Nn015TotalTaxa = this.Nn015TotalTaxa,
                Nn015TotalPago = this.Nn015TotalPago,
                Nn015Historico = this.Nn015Historico,
                Nn015Favorecido = this.Nn015Favorecido,
                Nn015Status = this.Nn015Status,
                Nn015GrupoId = this.Nn015GrupoId,
                Nn015ClasseId = this.Nn015ClasseId,
                Nn015CcustoId = this.Nn015CcustoId,
                Nn015AgcobradorId = this.Nn015AgcobradorId,
                Nn015Tipomovimento = this.Nn015Tipomovimento,
                Nn015Isestorno = this.Nn015Isestorno,
                Nn015UsuariopropId = this.Nn015UsuariopropId,
                Nn015TotaljurosCalc = this.Nn015TotaljurosCalc,
                Nn015TotalmultaCalc = this.Nn015TotalmultaCalc,
                Nn015TotaltaxaCalc = this.Nn015TotaltaxaCalc,
                Nn015Protocolnumber = this.Nn015Protocolnumber,
                Nn015Dbaixatit = this.Nn015Dbaixatit,
                Nn015Dcreditotit = this.Nn015Dcreditotit,
                Nn015TaxaAntecipacao = this.Nn015TaxaAntecipacao,
                Nn015ValorTxAntcartao = this.Nn015ValorTxAntcartao,
                Nn015Tcorrmonetaria = this.Nn015Tcorrmonetaria,
                Nn015Thonorarios = this.Nn015Thonorarios,

            };
        }
    }
}
