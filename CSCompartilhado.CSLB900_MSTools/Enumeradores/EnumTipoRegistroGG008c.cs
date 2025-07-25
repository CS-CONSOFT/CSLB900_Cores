using static CSLB900.MSTools.Enumeradores.EnumTipoRegistroGG008c;

namespace CSLB900.MSTools.Enumeradores
{
    public static class EnumTipoRegistroGG008c
    {
        public enum TIPO_REGISTRO_GG008c
        {
            FICHA_TECNICA = 1,
            CARACTERISTICA = 2,
            IMAGENS = 3,
        }
    }

    public static class VerificaTipoRegistroGG008c
    {
        public static string RetornaStringDoTipoRegistroCorrepondente(TIPO_REGISTRO_GG008c tipoRegistro)
        {
            if (tipoRegistro == TIPO_REGISTRO_GG008c.FICHA_TECNICA) return "1";
            if (tipoRegistro == TIPO_REGISTRO_GG008c.CARACTERISTICA) return "2";
            if (tipoRegistro == TIPO_REGISTRO_GG008c.IMAGENS) return "3";
            throw new InvalidDataException("Tipo de registro GG008 inválido");
        }
    }
}
