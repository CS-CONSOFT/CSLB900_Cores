using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF113
{
    public class DtoCreateUpdateFF113 : IConverteParaEntidade<CSICP_FF113>
    {
        public string? Ff113Usuariopropr { get; set; }

        public string? Ff113Filialid { get; set; }

        public string? Ff113RefConfBanco { get; set; }

        public DateTime? Ff113Dataregistro { get; set; }

        public string? Ff113Nota { get; set; }

        public int? Ff113Lote { get; set; }

        public string? Ff113Desclote { get; set; }

        public string? Ff113Borderoid { get; set; }

        public int? Ff113Tipo { get; set; }

        public string? Ff113Retornoid { get; set; }

        public string? Nn015Bxtesourariaid { get; set; }

        public int? Ff113Codgmovtoremessa { get; set; }

        public CSICP_FF113 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF113
            {
                TenantId = tenant,
                Id = id!,
                Ff113Usuariopropr = Ff113Usuariopropr,
                Ff113Filialid = Ff113Filialid,
                Ff113RefConfBanco = Ff113RefConfBanco,
                Ff113Dataregistro = Ff113Dataregistro,
                Ff113Nota = Ff113Nota,
                Ff113Lote = Ff113Lote,
                Ff113Desclote = Ff113Desclote,
                Ff113Borderoid = Ff113Borderoid,
                Ff113Tipo = Ff113Tipo,
                Ff113Retornoid = Ff113Retornoid,
                Nn015Bxtesourariaid = Nn015Bxtesourariaid,
                Ff113Codgmovtoremessa = Ff113Codgmovtoremessa
            };
        }
    }
}
