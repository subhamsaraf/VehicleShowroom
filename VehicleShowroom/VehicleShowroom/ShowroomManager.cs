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
        public double GenerateBill(Vehicle vehicle,TypeOfService typeOfService,PriceList priceList)
        {
            double price = priceList.GetPrice(vehicle.ModelNumber, typeOfService);
            TotalRevenue += price;
            return price;
        }

    }
}
