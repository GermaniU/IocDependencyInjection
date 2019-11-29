using System;

namespace First
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentServiceValidator validator;

        public AppointmentService(IAppointmentServiceValidator _validator)
        {
            validator = _validator ?? throw new ArgumentNullException(nameof(_validator));
        }

        // 1 Crear clase validaciones
        // 2 Crear Objeto llamador paciente
        // Crear objeto Cita que tenga un paciente y la fecha cita
        public string Create(Appointment appointment)
        {
            ValidationResult validation = validator.Validate(appointment);

            return validation.IsValid ?
                $"La cita quedo agendada para el paciente {appointment.Patient.Name}."
                : string.Join(Environment.NewLine, validation.ErrorMessage);

        }
    }
}