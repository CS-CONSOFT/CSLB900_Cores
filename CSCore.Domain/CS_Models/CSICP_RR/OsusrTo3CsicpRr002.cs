using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

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

    public string? Rr002Paisid { get; set; }

    public string? Rr002Cidadeid { get; set; }

    public string? Rr002Ufid { get; set; }

    public virtual ICollection<OsusrTo3CsicpRr001> OsusrTo3CsicpRr001s { get; set; } = new List<OsusrTo3CsicpRr001>();
}
