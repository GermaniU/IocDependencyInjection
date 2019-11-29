namespace First
{
    public interface IAppointmentServiceValidator
    {
        ValidationResult Validate(Appointment appointment);
    }
}