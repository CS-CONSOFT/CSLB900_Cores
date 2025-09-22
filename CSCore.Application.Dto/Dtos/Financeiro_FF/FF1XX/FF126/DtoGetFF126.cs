using System;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF126;

public class DtoGetFF126
{
    private DtoGetFF126()
    {
    }

    public static DtoGetFF126? ToDtoGetFF126(CSICP_FF126? entity)
    {
        if (entity == null)
            return null;
        return new DtoGetFF126
        {
            TenantId = entity.TenantId,
            Ff126Id = entity.Ff126Id,
            Ff126Dtregistro = entity.Ff126Dtregistro,
            Ff126TituloId = entity.Ff126TituloId,
            Ff126Diasatrasoent = entity.Ff126Diasatrasoent,
            Ff126SitcobrancaEntId = entity.Ff126SitcobrancaEntId,
            Ff126Sitcobranca = entity.Ff126Sitcobranca,
            Ff126SituacaosaiId = entity.Ff126SituacaosaiId,
            Ff126Mensagem = entity.Ff126Mensagem,
            Ff126Propid = entity.Ff126Propid,
            Ff126Isactive = entity.Ff126Isactive,
            Ff126Ispago = entity.Ff126Ispago,
            Ff126Dtpagto = entity.Ff126Dtpagto,
            Ff126Registrarspc = entity.Ff126Registrarspc,
            Ff126Categoriaid = entity.Ff126Categoriaid,
            Ff126Iscobrar = entity.Ff126Iscobrar,
            Ff126Isprimario = entity.Ff126Isprimario,
            Ff126Horaregistro = entity.Ff126Horaregistro
        };    

    }

    public int TenantId { get; set; }

    public string Ff126Id { get; set; } = null!;

    public DateTime? Ff126Dtregistro { get; set; }

    public string Ff126TituloId { get; set; } = string.Empty;

    public int? Ff126Diasatrasoent { get; set; }

    public int? Ff126SitcobrancaEntId { get; set; }

    public int? Ff126Sitcobranca { get; set; }

    public int? Ff126SituacaosaiId { get; set; }

    public string Ff126Mensagem { get; set; } = string.Empty;

    public string? Ff126Propid { get; set; }

    public bool? Ff126Isactive { get; set; }

    public bool? Ff126Ispago { get; set; }

    public DateTime? Ff126Dtpagto { get; set; }

    public bool? Ff126Registrarspc { get; set; }

    public string? Ff126Categoriaid { get; set; }

    public bool? Ff126Iscobrar { get; set; }

    public bool? Ff126Isprimario { get; set; }

    public DateTime? Ff126Horaregistro { get; set; }


    
}
