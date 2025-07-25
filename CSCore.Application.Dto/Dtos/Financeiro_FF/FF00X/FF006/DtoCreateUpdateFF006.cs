using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF006
{
    public class DtoCreateUpdateFF006 : IConverteParaEntidade<CSICP_FF006>
    {
        public string? Ff102Id { get; set; }

        public decimal? Ff006Vdescjuros { get; set; }

        public decimal? Ff006Pdescjuros { get; set; }

        public DateTime? Ff006Dsolicitacao { get; set; }

        public string? Ff006Usuariosolicid { get; set; }

        public DateTime? Ff006Dresgate { get; set; }

        public string? Ff006Usuarioresgid { get; set; }

        public string? Ff006Chaveautoriz { get; set; }

        public decimal? Ff006Vabertotit { get; set; }

        public decimal? Ff006Vjurostit { get; set; }

        public int? Ff006Datrasotit { get; set; }

        public int? Ff006Statusid { get; set; }

        public string? Ff006Chave { get; set; }

        public string? Ff006Tabela { get; set; }

        public CSICP_FF006 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF006
            {
                TenantId = tenant,
                Ff006Id = long.Parse(id!),
                Ff102Id = Ff102Id,
                Ff006Vdescjuros = Ff006Vdescjuros,
                Ff006Pdescjuros = Ff006Pdescjuros,
                Ff006Dsolicitacao = Ff006Dsolicitacao,
                Ff006Usuariosolicid = Ff006Usuariosolicid,
                Ff006Dresgate = Ff006Dresgate,
                Ff006Usuarioresgid = Ff006Usuarioresgid,
                Ff006Chaveautoriz = Ff006Chaveautoriz,
                Ff006Vabertotit = Ff006Vabertotit,
                Ff006Vjurostit = Ff006Vjurostit,
                Ff006Datrasotit = Ff006Datrasotit,
                Ff006Statusid = Ff006Statusid,
                Ff006Chave = Ff006Chave,
                Ff006Tabela = Ff006Tabela
            };
        }
    }
}









