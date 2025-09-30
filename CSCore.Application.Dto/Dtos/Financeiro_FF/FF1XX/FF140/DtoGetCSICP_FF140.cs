using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB009;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF141;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF143;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF144;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Application.Dto.Mapper.FF.FF00X;
using CSCore.Application.Dto.Mapper.FF.FF1XX;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF140
{
    public record DtoGetFF140Simples(
        int TenantId,
        long Ff140Id,
        DateTime? Ff140Data,
        string? Ff140Contaid,
        string? Ff140Especieid,
        string? Ff140Ccustoid,
        string? Ff140Usuarioproprieid,
        string? Ff140Agcobradorid,
        string? Ff140FpagtoId,
        string? Ff140Condicaoid,
        string? Ff140Tipocobrancaid,
        string? Ff140Descricao,
        string? Ff140Protocolnumber,
        decimal? Ff140Vrequisicao,
        string? Ff140Projetoid,
        int? Ff140Statusid,
        int? Ff140Execucaoid,
        int? Ff140Tpvinculoid,
        int? Ff140QtdeParcelas,
        string? Ff140Estabid,
        int? Ff140AdtoId
    );

    public class DtoGetCSICP_FF140
    {
        public DtoGetCSICP_FF140(CSICP_FF140 entity)
        {
            TenantId = entity.TenantId;
            Ff140Id = entity.Ff140Id;
            Ff140Data = entity.Ff140Data;
            Ff140Contaid = entity.Ff140Contaid;
            Ff140Especieid = entity.Ff140Especieid;
            Ff140Ccustoid = entity.Ff140Ccustoid;
            Ff140Usuarioproprieid = entity.Ff140Usuarioproprieid;
            Ff140Agcobradorid = entity.Ff140Agcobradorid;
            Ff140FpagtoId = entity.Ff140FpagtoId;
            Ff140Condicaoid = entity.Ff140Condicaoid;
            Ff140Tipocobrancaid = entity.Ff140Tipocobrancaid;
            Ff140Descricao = entity.Ff140Descricao;
            Ff140Protocolnumber = entity.Ff140Protocolnumber;
            Ff140Vrequisicao = entity.Ff140Vrequisicao;
            Ff140Projetoid = entity.Ff140Projetoid;
            Ff140Statusid = entity.Ff140Statusid;
            Ff140Execucaoid = entity.Ff140Execucaoid;
            Ff140Tpvinculoid = entity.Ff140Tpvinculoid;
            Ff140QtdeParcelas = entity.Ff140QtdeParcelas;
            Ff140Estabid = entity.Ff140Estabid;
            Ff140AdtoId = entity.Ff140AdtoId;
            NavBB001EstabID = entity.NavBB001EstabID?.ToDtoGetExibicao();
            NavBB005CCustoID = entity.NavBB005CCustoID?.ToDtoGetBB005_Exibicao();
            NavBB006AgCobradorID = entity.NavBB006AgCobradorID?.ToDtoGetExibicao();
            NavBB008CondicaoID = entity.NavBB008CondicaoID?.ToDtoGetSimples();
            NavBB009TpCobrancaID = entity.NavBB009TpCobrancaID?.ToDtoGetBB009_Exibicao();
            NavBB012ContaID = entity.NavBB012ContaID?.ToDtoGetExibSimples();
            NavBB026FPagto = entity.NavBB026FPagto?.ToDtoGetExibicao();
            NavFF003EspecieID = entity.NavFF003EspecieID?.ToDtoGetExibicao();
            NavSY001UsuarioPropID = entity.NavSY001UsuarioPropID?.ToDtoGetSimples();
            NavFF140Status = entity.NavFF140Status;
            NavFF140Exe = entity.NavFF140Exe;
            NavFF140Vinculo = entity.NavFF140Vinculo;
            NavListFF141 = entity.NavListFF141?.Select(e => e.ToDtoGetFF141()).ToList();
            NavListFF143 = entity.NavListFF143?.Select(e => e.ToDtoGetFF143()).ToList();
            NavListFF144 = entity.NavListFF144?.Select(e => e.ToDtoGetFF144()).ToList();
        }

        public int TenantId { get; set; }

        public long Ff140Id { get; set; }

        public DateTime? Ff140Data { get; set; }

        public string? Ff140Contaid { get; set; }

        public string? Ff140Especieid { get; set; }

        public string? Ff140Ccustoid { get; set; }

        public string? Ff140Usuarioproprieid { get; set; }

        public string? Ff140Agcobradorid { get; set; }

        public string? Ff140FpagtoId { get; set; }

        public string? Ff140Condicaoid { get; set; }

        public string? Ff140Tipocobrancaid { get; set; }

        public string? Ff140Descricao { get; set; }

        public string? Ff140Protocolnumber { get; set; }

        public decimal? Ff140Vrequisicao { get; set; }

        public string? Ff140Projetoid { get; set; }

        public int? Ff140Statusid { get; set; }

        public int? Ff140Execucaoid { get; set; }

        public int? Ff140Tpvinculoid { get; set; }

        public int? Ff140QtdeParcelas { get; set; }

        public string? Ff140Estabid { get; set; }

        public int? Ff140AdtoId { get; set; }

        //NavsGetList
        public Dto_GetBB001_Exibicao? NavBB001EstabID { get; set; }
        public Dto_GetBB005_Exibicao? NavBB005CCustoID { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006AgCobradorID { get; set; }
        public Dto_GetBB008_Exibicao? NavBB008CondicaoID { get; set; }
        public Dto_GetBB009_Exibicao? NavBB009TpCobrancaID { get; set; }
        public Dto_GetBB012_ExibSimples? NavBB012ContaID { get; set; }
        public Dto_GetBB026_Exibicao? NavBB026FPagto { get; set; }
        public Dto_GetFF003_Exibicao? NavFF003EspecieID { get; set; }
        public Dto_GetSY001Simples? NavSY001UsuarioPropID { get; set; }
        public OsusrE9aCsicpFf140Stum? NavFF140Status { get; set; }
        public OsusrE9aCsicpFf140Exe? NavFF140Exe { get; set; }
        public OsusrE9aCsicpFf140Vin? NavFF140Vinculo { get; set; }

        //NavsListGetByID
        public List<DtoGetFF141>? NavListFF141 { get; set; }
        public List<DtoGetFF143>? NavListFF143 { get; set; }
        public List<DtoGetFF144>? NavListFF144 { get; set; }
    }
}
