using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr002
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr002Nomefazenda { get; set; }

    public string? Rr002Cnpj { get; set; }

    public string? Rr002Endereco { get; set; }

    public string? Rr002Nroender { get; set; }

    public string? Rr002Complemento { get; set; }

    public string? Rr002Bairro { get; set; }

    public int? Rr002Cep { get; set; }

    [ForeignKey("NavAA025Pais")]
    public string? Rr002Paisid { get; set; }

    [ForeignKey("NavAA028Cidade")]
    public string? Rr002Cidadeid { get; set; }

    [ForeignKey("NavAA027UF")]
    public string? Rr002Ufid { get; set; }

    
    public CSICP_Aa028? NavAA028Cidade { get; set; }
    public CSICP_Aa027? NavAA027UF { get; set; }
    public CSICP_Aa025? NavAA025Pais { get; set; }
}
