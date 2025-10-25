using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF
{
    public class DtoGetFF104
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff104Filialid { get; set; }

        public string? Ff102Id { get; set; }

        public int? Ff104Filial { get; set; }

        public string? Ff104Pfx { get; set; }

        public decimal? Ff104NoTitulo { get; set; }

        public string? Ff104Sfx { get; set; }

        public decimal? Ff104CiNfNCupom { get; set; }

        public int? Ff104Notafiscal { get; set; }

        public string? Ff104Serienf { get; set; }

        public DateTime? Ff104Dataemissao { get; set; }

        public decimal? Ff104Valornf { get; set; }

        public string? Ff104Contrato { get; set; }

        public int? Ff104Nropdv { get; set; }

        public string? Ff104Renegociacaoid { get; set; }

        public string? Cc040Id { get; set; }

        public string? Cc030Id { get; set; }

        public bool? Ff104IsVinculado { get; set; }

        public string? Dd040Id { get; set; }

        public long? Bf010Id { get; set; }

        public long? Ff040Id { get; set; }

        public long? Ff140Id { get; set; }

        public long? Dd190Id { get; set; }

        public string? Ge012Id { get; set; }

        public string? Ge010Id { get; set; }

        public static DtoGetFF104? ToDtoGetFF104(CSICP_FF104? Entity)
        {
            if (Entity is null) return null;
            return new DtoGetFF104
            {
                Ff104Filialid = Entity.Ff104Filialid,
                Ff102Id = Entity.Ff102Id,
                Ff104Filial = Entity.Ff104Filial,
                Ff104Pfx = Entity.Ff104Pfx,
                Ff104Sfx = Entity.Ff104Sfx,
                Ff104Notafiscal = Entity.Ff104Notafiscal,
                Ff104Serienf = Entity.Ff104Serienf,
                Ff104Valornf = Entity.Ff104Valornf,
                Ff104Contrato = Entity.Ff104Contrato,
                Ff104Nropdv = Entity.Ff104Nropdv,
                Ff104Renegociacaoid = Entity.Ff104Renegociacaoid,
                Cc040Id = Entity.Cc040Id,
                Cc030Id = Entity.Cc030Id,
                Dd040Id = Entity.Dd040Id,
                Bf010Id = Entity.Bf010Id,
                Ff040Id = Entity.Ff040Id,
                Ff140Id = Entity.Ff140Id,
                Dd190Id = Entity.Dd190Id,
                Ge012Id = Entity.Ge012Id,
                Ge010Id = Entity.Ge010Id
            };
        }
    }
}
