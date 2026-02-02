namespace CSCore.ClinicTime.Motor.Paciente
{
    public interface IClinicTimeMotorPaciente
    {
        /// <summary>
        /// Esse método é responsável por marcar a presença do paciente no local da consulta.
        /// </summary>
        void MarcarPresencaNoLocal();

        /// <summary>
        /// Esse método é responsável por fazer com que o paciente faça chekin, afirmando que irá para a consulta.
        /// Ele é um pré requisito para MarcarPresencaNoLocal
        /// </summary>
        void RealizarCheckInPrevio();

        void PacienteMarcarDesistencia();      
    }
    public class ClinicTimeMotorPaciente : IClinicTimeMotorPaciente
    {
       
        /// <summary>
        /// Esse método é responsável por marcar a presença do paciente no local da consulta.
        /// </summary>
        public void MarcarPresencaNoLocal()
        {
            throw new NotImplementedException();
        }

        public void MedicoSolicitaTempoExtraNaConsulta()
        {
            throw new NotImplementedException();
        }

        public void PacienteMarcarDesistencia()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Esse método é responsável por fazer com que o paciente faça chekin, afirmando que irá para a consulta.
        /// Ele é um pré requisito para MarcarPresencaNoLocal
        /// </summary>
        public void RealizarCheckInPrevio()
        {
            throw new NotImplementedException();
        }


        #region PRIVATE METHODS
        private void AjustarProximaConsulta()
        {
            throw new NotImplementedException();
        }

        private void RecalcularFila()
        {
            throw new NotImplementedException(); 
        }

        private void NotificarMudancaDaFila()
        {
            throw new NotImplementedException(); 
        }
        #endregion
    }
}
