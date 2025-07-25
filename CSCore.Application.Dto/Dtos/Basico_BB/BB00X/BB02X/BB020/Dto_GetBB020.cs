using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;

namespace CSBS101._82Application.Dto.BB00X.BB020
{
    public class Dto_GetBB020
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public string? Bb019Id { get; set; }

        public string? Bb008Condicaodepagamentoid { get; set; }

        public decimal? Bb020Tcobcartao { get; set; }

        public string? Bb020Fpagtoid { get; set; }

        public Dto_GetBB008SemFatoresList? NavBb008Condicaodepagamento { get; set; }

        //public Dto_GetBB019? NavBb019 { get; set; }

        public Dto_GetBB026SemList? NavBb020Fpagto { get; set; }
    }
}
