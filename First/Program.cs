using IoC;
using StructureMap;
using System;
using static System.Console;
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Container.For<AppointmentServiceContainer>();

            var appointmentService = container.GetInstance<IAppointmentService>();

            var paciente = new Patient
            {
                Name = "Rodrigo",
                Email = "Rodrigo@gmail.com"
            };

            var appt = new Appointment
            {
                Time = new DateTime(2019, 03, 08, 15, 20, 19),
                Patient = paciente
            };


            WriteLine(appointmentService.Create(appt));

            ReadLine();
        }
    }
}
