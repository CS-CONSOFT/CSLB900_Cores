using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF000
{

    public class DtoCreateUpdateFF000 : IConverteParaEntidade<CSICP_FF000>
    {
        public string? Ff000EstabId { get; set; }

        public decimal? Ff000N1Vacimade { get; set; }

        public string? Ff000N1AutorizadorId { get; set; }

        public string? Ff000N1AusenciaId { get; set; }

        public decimal? Ff000N2Vacimade { get; set; }

        public string? Ff000N2AutorizadorId { get; set; }

        public string? Ff000N2AusenciaId { get; set; }

        public decimal? Ff000N3Vacimade { get; set; }

        public string? Ff000N3AutorizadorId { get; set; }

        public string? Ff000N3AusenciaId { get; set; }

        public decimal? Ff000N4Vacimade { get; set; }

        public string? Ff000N4AutorizadorId { get; set; }

        public string? Ff000N4AusenciaId { get; set; }

        public decimal? Ff000N5Vacimade { get; set; }

        public string? Ff000N5AutorizadorId { get; set; }

        public string? Ff000N5AusenciaId { get; set; }

        public int? Ff000BasecalcId { get; set; }

        public decimal? Ff000PercJuros { get; set; }

        public decimal? Ff000PercMulta { get; set; }

        public int? Ff000Diascarjuros { get; set; }

        public int? Ff000Diascarmulta { get; set; }

        public int? Ff000Diasbloqueio { get; set; }

        public int? Ff000Diasbloqmovto { get; set; }

        public int? Ff000Diasretroagirvencto { get; set; }

        public int? Ff000Diasavancarvencto { get; set; }

        public bool? Ff000Isdesabfcconfaut { get; set; }

        public decimal? Ff000PercCorrmonetaria { get; set; }

        public decimal? Ff000PercHonorarios { get; set; }

        public string? Ff000Renccustoid { get; set; }

        public string? Ff000Renagcobradorid { get; set; }

        public string? Ff000Rentpcobrancaid { get; set; }

        public decimal? Ff000Pminentrenegociacao { get; set; }

        public bool? Ff000Isrensomentetodos { get; set; }

        public string? Ff000Renespecieid { get; set; }

        public bool? Ff000Isrensempregerarvc { get; set; }

        public int? Ff00Formabxtesid { get; set; }

        public int? F000Formaenvapi { get; set; }

        public string? Ff000AgcobradoridApi { get; set; }

        public string? Ff000TpcobrancaidApi { get; set; }

        public bool? Ff000Ispermitecpfcnpjdup { get; set; }

        public string? Ff000PixcobFpagtoid { get; set; }
        public CSICP_FF000 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF000
            {
                TenantId = tenant,
                Ff000Id = id!,
                Ff000EstabId = Ff000EstabId,
                Ff000N1Vacimade = Ff000N1Vacimade,
                Ff000N1AutorizadorId = Ff000N1AutorizadorId,
                Ff000N1AusenciaId = Ff000N1AusenciaId,
                Ff000N2Vacimade = Ff000N2Vacimade,
                Ff000N2AutorizadorId = Ff000N2AutorizadorId,
                Ff000N2AusenciaId = Ff000N2AusenciaId,
                Ff000N3Vacimade = Ff000N3Vacimade,
                Ff000N3AutorizadorId = Ff000N3AutorizadorId,
                Ff000N3AusenciaId = Ff000N3AusenciaId,
                Ff000N4Vacimade = Ff000N4Vacimade,
                Ff000N4AutorizadorId = Ff000N4AutorizadorId,
                Ff000N4AusenciaId = Ff000N4AusenciaId,
                Ff000N5Vacimade = Ff000N5Vacimade,
                Ff000N5AutorizadorId = Ff000N5AutorizadorId,
                Ff000N5AusenciaId = Ff000N5AusenciaId,
                Ff000BasecalcId = Ff000BasecalcId,
                Ff000PercJuros = Ff000PercJuros,
                Ff000PercMulta = Ff000PercMulta,
                Ff000Diascarjuros = Ff000Diascarjuros,
                Ff000Diascarmulta = Ff000Diascarmulta,
                Ff000Diasbloqueio = Ff000Diasbloqueio,
                Ff000Diasbloqmovto = Ff000Diasbloqmovto,
                Ff000Diasretroagirvencto = Ff000Diasretroagirvencto,
                Ff000Diasavancarvencto = Ff000Diasavancarvencto,
                Ff000Isdesabfcconfaut = Ff000Isdesabfcconfaut,
                Ff000PercCorrmonetaria = Ff000PercCorrmonetaria,
                Ff000PercHonorarios = Ff000PercHonorarios,
                Ff000Renccustoid = Ff000Renccustoid,
                Ff000Renagcobradorid = Ff000Renagcobradorid,
                Ff000Rentpcobrancaid = Ff000Rentpcobrancaid,
                Ff000Pminentrenegociacao = Ff000Pminentrenegociacao,
                Ff000Isrensomentetodos = Ff000Isrensomentetodos,
                Ff000Renespecieid = Ff000Renespecieid,
                Ff000Isrensempregerarvc = Ff000Isrensempregerarvc,
                Ff00Formabxtesid = Ff00Formabxtesid,
                F000Formaenvapi = F000Formaenvapi,
                Ff000AgcobradoridApi = Ff000AgcobradoridApi,
                Ff000TpcobrancaidApi = Ff000TpcobrancaidApi,
                Ff000Ispermitecpfcnpjdup = Ff000Ispermitecpfcnpjdup,
                Ff000PixcobFpagtoid = Ff000PixcobFpagtoid,
            };
                        
        }
    }
}
