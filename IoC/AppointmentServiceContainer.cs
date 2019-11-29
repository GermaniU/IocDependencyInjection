using First;
using StructureMap;

namespace IoC
{
    public class AppointmentServiceContainer : Registry
    {
        public AppointmentServiceContainer()
        {
            For<IAppointmentServiceValidator>().Use<AppointmentServiceValidator>();
        }
    }
}