using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF106;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF106Mapper
    {
        public static DtoGetFF106 ToDtoGetFF106(this CSICP_FF106 entity)
        {
            return new DtoGetFF106
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff106Filialid = entity.Ff106Filialid,
                Ff105Id = entity.Ff105Id,
                Ff102Id = entity.Ff102Id,
                Ff106Selecionado = entity.Ff106Selecionado,
                Ff106Agcobradorid = entity.Ff106Agcobradorid,
                Ff106Tipocobrancaid = entity.Ff106Tipocobrancaid,
                Ff106InstCobranca1 = entity.Ff106InstCobranca1,
                Ff106InstCobranca2 = entity.Ff106InstCobranca2,
                Ff106IdOutroBordero = entity.Ff106IdOutroBordero,
                Ff106CodgOcorrencia = entity.Ff106CodgOcorrencia,
                Ff106Ocorrencia = entity.Ff106Ocorrencia,
                Ff106Jurosrecebido = entity.Ff106Jurosrecebido,
                Ff106Multarecebida = entity.Ff106Multarecebida,
                Ff106Outrovlrrecebido = entity.Ff106Outrovlrrecebido,
                Ff106Descconcedido = entity.Ff106Descconcedido,
                Ff106Valorpago = entity.Ff106Valorpago,
                Ff106DataRecto = entity.Ff106DataRecto,
                Ff106DataCredito = entity.Ff106DataCredito,
                Nn016IdBxTes = entity.Nn016IdBxTes,
                Ff106DataBxaut = entity.Ff106DataBxaut,
                Ff106DataProtesto = entity.Ff106DataProtesto,
                Ff106Diasprotesto = entity.Ff106Diasprotesto,
                Ff106Prazorecto = entity.Ff106Prazorecto,
                Ff106DataLimrecto = entity.Ff106DataLimrecto,
                Ff106CodigoErroApi = entity.Ff106CodigoErroApi,
                Ff106VersaoErroApi = entity.Ff106VersaoErroApi,
                Ff106MsgErroApi = entity.Ff106MsgErroApi,
                Ff106OcorErroApi = entity.Ff106OcorErroApi,
                Ff106OcorrenciaApi = entity.Ff106OcorrenciaApi,
                Ff106LiqApi = entity.Ff106LiqApi,
                Ff106BaixaApi = entity.Ff106BaixaApi,
            };
        }
    }
}
