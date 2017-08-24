using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShowroom
{
    public class ServiceLog
    {
        public TypeOfService typeOfService { get; set; }
        public VehicleType typeOfVehicle { get; set; }
        public double PriceOfTheService { get; set; }
        public double HoursOfService { get; set; }
    }
}
