using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016e
{
    public class DtoGetGG016e
    {
        public int TenantId { get; set; }

        public long Gg016eId { get; set; }

        public string? Gg016eDescricao { get; set; }

        public DateTime? Gg016eDregistro { get; set; }

        public string? Gg016eUsuariopropid { get; set; }
        public Dto_GetSY001Simples? NavGetSy001 { get; set; }
    }
}
