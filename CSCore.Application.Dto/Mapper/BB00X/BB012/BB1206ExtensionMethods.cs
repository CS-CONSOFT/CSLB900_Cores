using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSCore.Application.Dto.Mapper.BB00X.BB012
{
    public static class BB1206ExtensionMethods
    {
        public static CSICP_BB01206 ToEntity(this Dto_CreateUpdateBB01206 dto, string bb012J_id, string IdEndereco)
        {
            return new CSICP_BB01206
            {
                Id = IdEndereco,
                Bb012jEnderecoid = bb012J_id,
                Bb012Id = null,
                Bb012Logradouro = dto.Bb012Logradouro,
                Bb012Numero = dto.Bb012Numero,
                Bb012Complemento = dto.Bb012Complemento,
                Bb012Bairro = dto.Bb012Bairro,
                Bb012CodigoCidade = dto.Bb012CodigoCidade,
                Bb012Uf = dto.Bb012Uf,
                Bb012Cep = dto.Bb012Cep,
                Bb012CodigoPais = dto.Bb012CodigoPais,
                Bb012EntregaLogradouro = dto.Bb012EntregaLogradouro,
                Bb012EntregaNumero = dto.Bb012EntregaNumero,
                Bb012EntregaComplement = dto.Bb012EntregaComplement,
                Bb012EntregaCodgbairro = dto.Bb012EntregaCodgbairro,
                Bb012EntregaBairro = dto.Bb012EntregaBairro,
                Bb012EntregaCodCidade = dto.Bb012EntregaCodCidade,
                Bb012EntregaUf = dto.Bb012EntregaUf,
                Bb012EntregaCep = dto.Bb012EntregaCep,
                Bb012EntregaPais = dto.Bb012EntregaPais,
                Bb012Perimetro = dto.Bb012Perimetro,
                Bb012EntregaPerimetro = dto.Bb012EntregaPerimetro,
                Bb012Telefone = dto.Bb012Telefone,
                Bb012Celular = dto.Bb012Celular,
                Bb012Email = dto.Bb012Email,
            };
        }


    }
}

