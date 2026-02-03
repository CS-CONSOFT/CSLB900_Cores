using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor
{
    public static class CHAVES_REDIS
    {
        public const string STR_LOCALIZACOES = "localizacao:sistema";
        public const string MBR_LOCALIZACAO_PACIENTES_MEMBRO= "paciente:";
        public const string MBR_LOCALIZACAO_CLINICA_MEMBRO= "clinica:";
        public const string STR_CONSULTA= "consulta:";
        public const string STR_FILA = "fila:";
        public const string STR_CONSULTA_CLINICA= "consulta:clinica:";
        public const string STR_CONSULTA_MEDICO= "consulta:medico:";
    }
}
