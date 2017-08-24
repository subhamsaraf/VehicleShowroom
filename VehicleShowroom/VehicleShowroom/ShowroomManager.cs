using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShowroom
{
    public class ShowroomManager
    { 
        public double TotalRevenue { get; private set; }
        public List<ServiceLog> Services = new List<ServiceLog>();
        public double GenerateBill(Vehicle vehicle,TypeOfService typeOfService,PriceList priceList,double hoursOfServices)
        {
            double price = priceList.GetPrice(vehicle.ModelNumber, typeOfService);
            price = price * hoursOfServices;
            TotalRevenue += price;
            ServiceLog serviceLog = new ServiceLog()
            {
                HoursOfService = hoursOfServices,
                PriceOfTheService = price,
                typeOfService = typeOfService,
                typeOfVehicle = vehicle.Type
            };
            Services.Add(serviceLog);
            return price;

        }

    }
}
