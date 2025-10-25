using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF106
{
    public class DtoCreateUpdateFF106 : IConverteParaEntidade<CSICP_FF106>
    {
        public string? Ff106Filialid { get; set; }

        public string? Ff105Id { get; set; }

        public string? Ff102Id { get; set; }

        public bool? Ff106Selecionado { get; set; }

        public string? Ff106Agcobradorid { get; set; }

        public string? Ff106Tipocobrancaid { get; set; }

        public string? Ff106InstCobranca1 { get; set; }

        public string? Ff106InstCobranca2 { get; set; }

        public string? Ff106IdOutroBordero { get; set; }

        public int? Ff106CodgOcorrencia { get; set; }

        public string? Ff106Ocorrencia { get; set; }

        public decimal? Ff106Jurosrecebido { get; set; }

        public decimal? Ff106Multarecebida { get; set; }

        public decimal? Ff106Outrovlrrecebido { get; set; }

        public decimal? Ff106Descconcedido { get; set; }

        public decimal? Ff106Valorpago { get; set; }

        public DateTime? Ff106DataRecto { get; set; }

        public DateTime? Ff106DataCredito { get; set; }

        public string? Nn016IdBxTes { get; set; }

        public DateTime? Ff106DataBxaut { get; set; }

        public DateTime? Ff106DataProtesto { get; set; }

        public int? Ff106Diasprotesto { get; set; }

        public int? Ff106Prazorecto { get; set; }

        public DateTime? Ff106DataLimrecto { get; set; }

        public string? Ff106CodigoErroApi { get; set; }

        public string? Ff106VersaoErroApi { get; set; }

        public string? Ff106MsgErroApi { get; set; }

        public string? Ff106OcorErroApi { get; set; }

        public int? Ff106OcorrenciaApi { get; set; }

        public int? Ff106LiqApi { get; set; }

        public int? Ff106BaixaApi { get; set; }

        public CSICP_FF106 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF106
            {
                TenantId = tenant,
                Id = id!,
                Ff106Filialid = Ff106Filialid,
                Ff105Id = Ff105Id,
                Ff102Id = Ff102Id,
                Ff106Selecionado = Ff106Selecionado,
                Ff106Agcobradorid = Ff106Agcobradorid,
                Ff106Tipocobrancaid = Ff106Tipocobrancaid,
                Ff106InstCobranca1 = Ff106InstCobranca1,
                Ff106InstCobranca2 = Ff106InstCobranca2,
                Ff106IdOutroBordero = Ff106IdOutroBordero,
                Ff106CodgOcorrencia = Ff106CodgOcorrencia,
                Ff106Ocorrencia = Ff106Ocorrencia,
                Ff106Jurosrecebido = Ff106Jurosrecebido,
                Ff106Multarecebida = Ff106Multarecebida,
                Ff106Outrovlrrecebido = Ff106Outrovlrrecebido,
                Ff106Descconcedido = Ff106Descconcedido,
                Ff106Valorpago = Ff106Valorpago,
                Ff106DataRecto = Ff106DataRecto,
                Ff106DataCredito = Ff106DataCredito,
                Nn016IdBxTes = Nn016IdBxTes,
                Ff106DataBxaut = Ff106DataBxaut,
                Ff106DataProtesto = Ff106DataProtesto,
                Ff106Diasprotesto = Ff106Diasprotesto,
                Ff106Prazorecto = Ff106Prazorecto,
                Ff106DataLimrecto = Ff106DataLimrecto,
                Ff106CodigoErroApi = Ff106CodigoErroApi,
                Ff106VersaoErroApi = Ff106VersaoErroApi,
                Ff106MsgErroApi = Ff106MsgErroApi,
                Ff106OcorErroApi = Ff106OcorErroApi,
                Ff106OcorrenciaApi = Ff106OcorrenciaApi,
                Ff106LiqApi = Ff106LiqApi,
                Ff106BaixaApi = Ff106BaixaApi,
            };
        }
    }

    public class DtoCreateUpdateFF106List
    {
         public List<DtoCreateUpdateFF106>? ListaCreate { get; set; }

    }
}