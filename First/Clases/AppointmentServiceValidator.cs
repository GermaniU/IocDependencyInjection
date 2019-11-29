using System;

namespace First
{
    public class AppointmentServiceValidator : IAppointmentServiceValidator
    {
        public  ValidationResult Validate(Appointment appointment)
        {
            ValidationResult validation = new ValidationResult();

            if (string.IsNullOrEmpty(appointment.Patient.Name)) 
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");

            if (appointment.Time.Equals(DateTime.MinValue))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");

            if (!appointment.Patient.Email.Contains("@") || string.IsNullOrEmpty(appointment.Patient.Email))
                validation.ErrorMessage.Add($"La cita no puede ser agendada, debido a que debe proporcionar un email valido.");

            return validation;
        }
    }
}