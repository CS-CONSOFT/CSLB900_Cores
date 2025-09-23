using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Application.Dto.Mapper.FF.FF00X;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX
{
    public record DtoGetCSICP_FF127Simples(
        int TenantId,
        string Ff127Id,
        string? Ff127Protocolnumber,
        string? Ff127ContaId,
        DateTime? Ff127Dtregistro,
        DateTime? Ff127Dtprevisao,
        string? Ff127Mensagem,
        bool? Ff127Ispago,
        bool? Ff127Isactive,
        string? Ff127CobradorId,
        string? Ff127AgcobradorId,
        bool? Ff127Isvisitado,
        DateTime? Ff127Dtvisita,
        DateTime? Ff127HoraRegistro,
        string? Ff127UsuarioInc,
        string? Ff127Motivoid
    );
    public class DtoGetCSICP_FF127
    {
        
        public DtoGetCSICP_FF127(CSICP_FF127 entity)
        {
            TenantId = entity.TenantId;
            Ff127Id = entity.Ff127Id;
            Ff127Protocolnumber = entity.Ff127Protocolnumber;
            Ff127ContaId = entity.Ff127ContaId;
            Ff127Dtregistro = entity.Ff127Dtregistro;
            Ff127Dtprevisao = entity.Ff127Dtprevisao;
            Ff127Mensagem = entity.Ff127Mensagem;
            Ff127Ispago = entity.Ff127Ispago;
            Ff127Isactive = entity.Ff127Isactive;
            Ff127CobradorId = entity.Ff127CobradorId;
            Ff127AgcobradorId = entity.Ff127AgcobradorId;
            Ff127Isvisitado = entity.Ff127Isvisitado;
            Ff127Dtvisita = entity.Ff127Dtvisita;
            Ff127HoraRegistro = entity.Ff127HoraRegistro;
            Ff127UsuarioInc = entity.Ff127UsuarioInc;
            Ff127Motivoid = entity.Ff127Motivoid;
            NavFF002Motivo = entity.NavFF002Motivo?.ToDtoGetSimples();
            NavBB012Conta = entity.NavBB012Conta?.ToDtoGetExibSimples();
            NavBB006AgCobrador = entity.NavBB006AgCobrador?.ToDtoGetExibicao();
            NavSY001Cobrador = entity.NavSY001Cobrador?.ToDtoGetSimples();
        }



        public int TenantId { get; set; }

        public string Ff127Id { get; set; } = null!;

        public string? Ff127Protocolnumber { get; set; }

        public string? Ff127ContaId { get; set; }

        public DateTime? Ff127Dtregistro { get; set; }

        public DateTime? Ff127Dtprevisao { get; set; }

        public string? Ff127Mensagem { get; set; }

        public bool? Ff127Ispago { get; set; }

        public bool? Ff127Isactive { get; set; }

        public string? Ff127CobradorId { get; set; }

        public string? Ff127AgcobradorId { get; set; }

        public bool? Ff127Isvisitado { get; set; }

        public DateTime? Ff127Dtvisita { get; set; }

        public DateTime? Ff127HoraRegistro { get; set; }

        public string? Ff127UsuarioInc { get; set; }

        public string? Ff127Motivoid { get; set; }

        public DtoGetFF002Simples? NavFF002Motivo { get; set; }
        public Dto_GetBB012_ExibSimples? NavBB012Conta { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006AgCobrador { get; set; }
        public Dto_GetSY001Simples? NavSY001Cobrador { get; set; }
    }
}
