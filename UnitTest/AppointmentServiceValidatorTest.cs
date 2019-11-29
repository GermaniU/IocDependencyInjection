using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First.Tests
{
    [TestClass()]
    public class AppointmentServiceValidatorTest
    {
        [TestMethod()]
        public void Validate_ParametroPatientNameVacio_MensajeError()
        {
            var AppointmentServiceValidator = new AppointmentServiceValidator();

           var ResultadoValidacion = AppointmentServiceValidator.Validate(ObtenerRegistrosAsignacionSinNombrePaciente());

           Assert.AreEqual("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.", ResultadoValidacion.ErrorMessage.FirstOrDefault());
        }

        [TestMethod()]
        public void Validate_ParametroFechaNoValida_MensajeError()
        {
            var AppointmentServiceValidator = new AppointmentServiceValidator();

            var ResultadoValidacion = AppointmentServiceValidator.Validate(ObtenerRegistrosAsignacionFechaNoValida());

            Assert.AreEqual("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.", ResultadoValidacion.ErrorMessage.FirstOrDefault());
        }

        [TestMethod()]
        public void Validate_ParametroPatientEmailNoValido_MensajeError()
        {
            var AppointmentServiceValidator = new AppointmentServiceValidator();

            var ResultadoValidacion = AppointmentServiceValidator.Validate(ObtenerRegistrosAsignacionEmailNoValida());

            Assert.AreEqual("La cita no puede ser agendada, debido a que debe proporcionar un email valido.", ResultadoValidacion.ErrorMessage.FirstOrDefault());
        }

        private Appointment ObtenerRegistrosAsignacionSinNombrePaciente()
        {
            var dat1 = new DateTime(2008, 5, 1, 8, 30, 52);

            var paciente = new Patient()
            {
                Name = string.Empty,
                Email =  "germani@gmail.com"
                
            };

            var registro = new Appointment()
            {
                Time = dat1,
                Patient = paciente
            };

            registro.Patient = paciente;

            return registro;
        }

        private Appointment ObtenerRegistrosAsignacionFechaNoValida()
        {
            var dat1 = new DateTime();

            var paciente = new Patient()
            {
                Name = "Yo",
                Email = "germani@gmail.com"

            };

            var registro = new Appointment()
            {
                Time = dat1,
                Patient = paciente
            };

            registro.Patient = paciente;

            return registro;
        }

        private Appointment ObtenerRegistrosAsignacionEmailNoValida()
        {
            var dat1 = new DateTime(2008, 5, 1, 8, 30, 52);

            var paciente = new Patient()
            {
                Name = "Yo",
                Email = "germani.com"

            };

            var registro = new Appointment()
            {
                Time = dat1,
                Patient = paciente
            };

            registro.Patient = paciente;

            return registro;
        }

    }
}