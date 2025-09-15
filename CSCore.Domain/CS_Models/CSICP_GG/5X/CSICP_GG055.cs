using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG055 : IEquatable<CSICP_GG055>
{
    public int TenantId { get; set; }

    public long Gg055Id { get; set; }

    public long? Gg054Id { get; set; }

    public int? Gg055Codgproduto { get; set; }

    public string? Gg055Codgbarras { get; set; }

    public string? Gg055ProdutoId { get; set; }

    public string? Gg055Saldoid { get; set; }

    public string? Gg055KdxId { get; set; }

    public string? Gg055Unidade { get; set; }

    public string? Gg055Gradelinhaid { get; set; }

    public string? Gg055Gradecolunaid { get; set; }

    public string? Gg055Lote { get; set; }

    public string? Gg055Sublote { get; set; }

    public decimal? Gg055Quantidade { get; set; }

    public int? Gg055Status { get; set; }

    public string? Gg055UsuarioId { get; set; }

    public DateTime? Gg055DataInc { get; set; }

    public DateTime? Gg055HoraInc { get; set; }

    public string? Gg055UsuarioAlt { get; set; }

    public DateTime? Gg055DataAlt { get; set; }

    public DateTime? Gg055HoraAlt { get; set; }

    public int? Gg055Criarexcid { get; set; }


    public CSICP_GG008Kdx? Nav_Gg008Kdx { get; set; }

    public CSICP_GG520? Nav_GG520Saldo { get; set; }

    public CSICP_GG008? Nav_GG008Produto { get; set; }

    public CSICP_GG001? Nav_GG001Almox { get; set; }





    public bool Equals(CSICP_GG055? other)
    {
        if (other is null)
            return false;

        return this.Gg055ProdutoId == other.Gg055ProdutoId;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as CSICP_GG055);
    }

    public override int GetHashCode()
    {
        return (this.Gg055ProdutoId).GetHashCode();
    }
}
