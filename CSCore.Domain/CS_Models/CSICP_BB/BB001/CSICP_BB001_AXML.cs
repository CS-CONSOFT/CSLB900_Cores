using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_BB001_AXML
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb001aId { get; set; }

    public string? Bb001aEstabid { get; set; }

    public string? Bb001aNome { get; set; }

    public string? Bb001aEmail { get; set; }

    public string? Bb001aTelefone { get; set; }

    public string? Bb001aCpfcnpj { get; set; }

    public bool? Bb001aIscpf { get; set; }


    //public CSICP_BB001? Bb001aEstab { get; set; }
}
