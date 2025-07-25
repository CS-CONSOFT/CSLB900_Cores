namespace CSSY103.C82Application.Dto.SY904
{
    public class DtoSY904 : IEquatable<DtoSY904>
    {
        public string? Id { get; set; }

        //public string? IdSY905 { get; set; }

        public string? Label { get; set; }

        public string? Programa { get; set; }

        public int? Ordem { get; set; }
        public string? Url { get; set; }

        public string? Descricao { get; set; }
        public bool? IsActive { get; set; }

        public bool Equals(DtoSY904? other)
        {
            if (other is null) return false;
            if (this == other) return false;
            return this.Id == other.Id;
        }
        public override int GetHashCode()
        {
            int hashTextual = this.Id == null ? 0 : this.Id.GetHashCode();
            return hashTextual;
        }
    }
}
