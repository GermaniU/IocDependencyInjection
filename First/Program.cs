using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using static System.Console;
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            IAppointmentServiceValidator validator = new AppointmentServiceValidator();

            var container = Container.For<AppointmentServiceContainer>();

             var appt = new Appointment
            {
                Patient = new Patient
                {
                    Name = "Rodrigo"
                },
                Time = new DateTime(2019, 03, 08, 15, 20, 19)

            };
            WriteLine(new AppointmentService(validator).Create(appt));

            ReadLine();
        }
    }
}
