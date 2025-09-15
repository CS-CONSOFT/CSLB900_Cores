using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB029;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;

public class DtoGetCSICP_FF125
{
    public DtoGetCSICP_FF125()
    {
    }

    public int TenantId { get; set; }

    public string Ff125Id { get; set; } = null!;

    public string? Ff125ContaId { get; set; }

    public DateTime? Ff125Dtregistro { get; set; }

    public int? Ff125Qtdtitulos { get; set; }

    public decimal? Ff125Totalaberto { get; set; }

    public string? Ff125Cobradorid { get; set; }

    public string? Ff125AgcobradorId { get; set; }

    public string? Ff125Mensagem { get; set; }

    public DateTime? Ff125Dtprevisaogeral { get; set; }

    public bool? Ff125Isactive { get; set; }

    public string? Ff125Categoriaid { get; set; }

    public int? Ff125StatusId { get; set; }

    public int? Ff125SitcobentId { get; set; }

    public bool? Ff125Ismarcado { get; set; }

    public bool? Ff125Iscobrado { get; set; }

    public DateTime? Ff125Dtcobranca { get; set; }

    public string? Ff125ContaAvalista { get; set; }

    public string? Ff125Motivoid { get; set; }

    public int? Ff125Sitcobranca { get; set; }

    public decimal? Ff125Latitude { get; set; }

    public decimal? Ff125Longitude { get; set; }

    public Dto_GetBB012_ExibSimples? NavBB012Conta { get; set; }
    public Dto_GetBB01206Simples? NavBB01206EnderecoConta { get; set; }
    public CSICP_FF002? NavFF002Motivo { get; set; }
    public Dto_GetSY001Simples? NavSY001Cobrador { get; set; }
    public Dto_GetBB006_Exibicao? NavBB006AgCobrador { get; set; }
    public Dto_GetBB029? NavBB029Categoria { get; set; }
    public OsusrE9aCsicpFf125Stat? NavFF125Status { get; set; }
    public CSICP_FF998? NavFF998SitCob { get; set; }
    public CSICP_Bb012Sitcta? NavBB012SitCta { get; set; }
    public DtoGetCSICP_FF125(CSICP_FF125 entity)
    {
        TenantId = entity.TenantId;
        Ff125Id = entity.Ff125Id;
        Ff125ContaId = entity.Ff125ContaId;
        Ff125Dtregistro = entity.Ff125Dtregistro;
        Ff125Qtdtitulos = entity.Ff125Qtdtitulos;
        Ff125Totalaberto = entity.Ff125Totalaberto;
        Ff125Cobradorid = entity.Ff125Cobradorid;
        Ff125AgcobradorId = entity.Ff125AgcobradorId;
        Ff125Mensagem = entity.Ff125Mensagem;
        Ff125Dtprevisaogeral = entity.Ff125Dtprevisaogeral;
        Ff125Isactive = entity.Ff125Isactive;
        Ff125Categoriaid = entity.Ff125Categoriaid;
        Ff125StatusId = entity.Ff125StatusId;
        Ff125SitcobentId = entity.Ff125SitcobentId;
        Ff125Ismarcado = entity.Ff125Ismarcado;
        Ff125Iscobrado = entity.Ff125Iscobrado;
        Ff125Dtcobranca = entity.Ff125Dtcobranca;
        Ff125ContaAvalista = entity.Ff125ContaAvalista;
        Ff125Motivoid = entity.Ff125Motivoid;
        Ff125Sitcobranca = entity.Ff125Sitcobranca;
        Ff125Latitude = entity.Ff125Latitude;
        Ff125Longitude = entity.Ff125Longitude;
        NavBB012Conta = entity.NavBB012Conta?.ToDtoGetExibSimples();
        NavFF002Motivo = entity.NavFF002Motivo;
        NavBB012SitCta  = entity.NavBB012SitCta;
        NavBB006AgCobrador = entity.NavBB006AgCobrador?.ToDtoGetExibicao();
        NavBB01206EnderecoConta = entity.NavBB012Conta?.NavBB01206?.ToDtoBB01206Simples();
        NavBB029Categoria = entity.NavBB029Categoria?.ToDtoGet();
        NavFF125Status = entity.NavFF125Status;
        NavFF998SitCob = entity.NavFF998SitCob;
        NavSY001Cobrador = entity.NavSY001Cobrador?.ToDtoGetSimples();
    }
}

   

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    
