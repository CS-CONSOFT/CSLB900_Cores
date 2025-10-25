using CSCore.Application.Dto.Dtos.DD;
using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD830Mapper
    {
        public static DtoGetDD830 ToDto(this CSICP_DD830 entity)
        {
            if (entity == null) return null;
            return new DtoGetDD830
            {
                TenantId = entity.TenantId,
                Dd830Id = entity.Dd830Id,
                Bb001Id = entity.Bb001Id,
                Dd830Siptef = entity.Dd830Siptef,
                Dd830SidLoja = entity.Dd830SidLoja,
                Dd830SidTerminal = entity.Dd830SidTerminal,
                Dd830Comando = entity.Dd830Comando,
                Dd830Vtransacao = entity.Dd830Vtransacao,
                Dd830Ntransacao = entity.Dd830Ntransacao,
                Dd830Operador = entity.Dd830Operador,
                Dd830Restricoes = entity.Dd830Restricoes,
                Dd830Ispinpad = entity.Dd830Ispinpad,
                Dd830Isautoconfirma = entity.Dd830Isautoconfirma,
                Dd830Dcreate = entity.Dd830Dcreate,
                Dd830Progresso = entity.Dd830Progresso,
                Dd830Formapagto = entity.Dd830Formapagto,
                Dd830Tpparcela = entity.Dd830Tpparcela,
                Dd830Qparcela = entity.Dd830Qparcela,
                Dd830Intervalopar = entity.Dd830Intervalopar,
                Dd830Isprimparcavista = entity.Dd830Isprimparcavista,
                Dd830Dprimparcela = entity.Dd830Dprimparcela,
                Dd830Status = entity.Dd830Status,
                Dd830Hashid = entity.Dd830Hashid,
                Dd830RetCompestab = entity.Dd830RetCompestab,
                Dd830RetCompcliente = entity.Dd830RetCompcliente,
                Dd830RetCompcancestab = entity.Dd830RetCompcancestab,
                Dd830RetCompcanc = entity.Dd830RetCompcanc,
                Dd830RetProtocoltran = entity.Dd830RetProtocoltran,
                Dd830RetDoc = entity.Dd830RetDoc,
                Dd830RetNsu = entity.Dd830RetNsu,
                Dd830RetDautorizacao = entity.Dd830RetDautorizacao,
                Dd830RetHautorizacao = entity.Dd830RetHautorizacao,
                Dd830RetIsautorizado = entity.Dd830RetIsautorizado,
                Dd830RetMsg = entity.Dd830RetMsg,
                Dd042Id = entity.Dd042Id,
                Dd072Id = entity.Dd072Id,
                Pd014Id = entity.Pd014Id,
                Dd830Tptransacao = entity.Dd830Tptransacao,
                Dd830RetDcanc = entity.Dd830RetDcanc,
                Dd830RetHcanc = entity.Dd830RetHcanc,
                Dd830Inferp = entity.Dd830Inferp,
                Dd830VendaId = entity.Dd830VendaId,
                Dd830Codgbandsitef = entity.Dd830Codgbandsitef,
                Dd830IdEsitef = entity.Dd830IdEsitef,
                Dd830Tpregistro = entity.Dd830Tpregistro,
                Dd830Tipo = entity.Dd830Tipo
            };
        }
    }
}
