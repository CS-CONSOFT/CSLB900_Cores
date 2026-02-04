using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Medico
{
    public interface IClinicTimeMotorMedico
    {
        void MedicoSolicitaTempoExtraNaConsulta();

        void IniciarConsulta();

        void FinalizarConsulta();
    }
    public class ClinicTimeMotorMedico : IClinicTimeMotorMedico
    {
        public void FinalizarConsulta()
        {
            throw new NotImplementedException();
        }

        public void IniciarConsulta()
        {
            throw new NotImplementedException();
        }

        public void MedicoSolicitaTempoExtraNaConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
