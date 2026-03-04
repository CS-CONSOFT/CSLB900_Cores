using CSCore.ClinicTime.Motor.Prioridade;
using CSCore.ClinicTime.Motor.Prioridade.Strategies.Novas;

namespace CSCore.ClinicTime.Motor.Util
{
    internal enum TipoPacienteEspecial
    {
        DeficienciaFisica = 1,
        DeficienciaAuditiva = 2,
        DeficienciaVisual = 3,
        DeficienciaIntelectual = 4,
        DeficienciaMultipla = 5,
        DeficienciaPsicossocialOuSaudeMental = 6,
        GestanteRiscoHabitual = 7,
        GestanteRiscoIntermediario = 8,
        GestanteAltoRisco = 9,
        IdosoDependenciaI = 10,
        IdosoDependenciaII = 11,
        IdosoDependenciaIII = 12
    }

    internal static class VerificaTipoPacienteEspecial
    {
        public static TipoPacienteEspecial? ObterTipoPacienteEspecial(string? label)
        {
            if (label == null) return null;
            return label switch
            {
                "Deficiência Física" => TipoPacienteEspecial.DeficienciaFisica,
                "Deficiência Auditiva" => TipoPacienteEspecial.DeficienciaAuditiva,
                "Deficiência Visual" => TipoPacienteEspecial.DeficienciaVisual,
                "Deficiência Intelectual" => TipoPacienteEspecial.DeficienciaIntelectual,
                "Deficiência Múltipla" => TipoPacienteEspecial.DeficienciaMultipla,
                "Deficiência Psicossocial ou por Saúde Mental" => TipoPacienteEspecial.DeficienciaPsicossocialOuSaudeMental,
                "Gestante Risco Habitual (Baixo Risco)" => TipoPacienteEspecial.GestanteRiscoHabitual,
                "Gestante Risco Intermediário" => TipoPacienteEspecial.GestanteRiscoIntermediario,
                "Gestante Alto Risco" => TipoPacienteEspecial.GestanteAltoRisco,
                "Idoso Dependência I" => TipoPacienteEspecial.IdosoDependenciaI,
                "Idoso Dependência II" => TipoPacienteEspecial.IdosoDependenciaII,
                "Idoso Dependência III" => TipoPacienteEspecial.IdosoDependenciaIII,
                _ => (TipoPacienteEspecial?)null
            };
        }
        public static List<IPrioridadeStrategy> ConverteTipoPacienteEspecialParaIPriority(string? label)
        {
            if (string.IsNullOrWhiteSpace(label))
                return new List<IPrioridadeStrategy> { new PrioridadeSemPrioridade() };

            string[] tiposDeEspecial = [label];
            if (label.Contains(";"))
                tiposDeEspecial = label.Split(';');

            var prioridades = new List<IPrioridadeStrategy>();
            foreach (var current in tiposDeEspecial)
            {
                var tipo = ObterTipoPacienteEspecial(current.Trim());
                IPrioridadeStrategy prioridade = tipo switch
                {
                    TipoPacienteEspecial.DeficienciaFisica => new PrioridadeDeficienciaFisica(),
                    TipoPacienteEspecial.DeficienciaAuditiva => new PrioridadeDeficienciaAuditiva(),
                    TipoPacienteEspecial.DeficienciaVisual => new PrioridadeDeficienciaVisual(),
                    TipoPacienteEspecial.DeficienciaIntelectual => new PrioridadeDeficienciaIntelectual(),
                    TipoPacienteEspecial.DeficienciaMultipla => new PrioridadeDeficienciaMultipla(),
                    TipoPacienteEspecial.DeficienciaPsicossocialOuSaudeMental => new PrioridadeDeficienciaPsicossocialOuSaudeMental(),
                    TipoPacienteEspecial.GestanteRiscoHabitual => new PrioridadeGestanteRiscoHabitual(),
                    TipoPacienteEspecial.GestanteRiscoIntermediario => new PrioridadeGestanteRiscoIntermediario(),
                    TipoPacienteEspecial.GestanteAltoRisco => new PrioridadeGestanteAltoRisco(),
                    TipoPacienteEspecial.IdosoDependenciaI => new PrioridadeIdosoDependenciaI(),
                    TipoPacienteEspecial.IdosoDependenciaII => new PrioridadeIdosoDependenciaII(),
                    TipoPacienteEspecial.IdosoDependenciaIII => new PrioridadeIdosoDependenciaIII(),
                    _ => new PrioridadeSemPrioridade()
                };
                prioridades.Add(prioridade);
            }

            return prioridades;
        }
    }
}