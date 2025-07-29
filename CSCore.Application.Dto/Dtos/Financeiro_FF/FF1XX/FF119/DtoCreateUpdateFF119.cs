using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF119
{
    public class DtoCreateUpdateFF119 : IConverteParaEntidade<CSICP_FF119>
    {
        public string? Ff112Id { get; set; }

        public int? Ff119Regid { get; set; }

        public int? Ff119Posicaode { get; set; }

        public int? Ff119Posicaoate { get; set; }

        public string? Ff119Conteudo { get; set; }

        public string? Ff119Descricao { get; set; }
        public CSICP_FF119 ToEntity(int tenant, string? _)
        {
            return new CSICP_FF119
            {
                TenantId = tenant,
                Ff112Id = Ff112Id,
                Ff119Regid = Ff119Regid,
                Ff119Posicaode = Ff119Posicaode,
                Ff119Posicaoate = Ff119Posicaoate,
                Ff119Conteudo = Ff119Conteudo,
                Ff119Descricao = Ff119Descricao,
                
            };
        }
    }
}