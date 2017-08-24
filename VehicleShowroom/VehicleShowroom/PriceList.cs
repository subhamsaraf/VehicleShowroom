using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShowroom
{
    public class PriceList
    {
        Dictionary<string, double> SellingPrice = new Dictionary<string, double>();
        Dictionary<string, double> PricePerDay = new Dictionary<string, double>();

        public void Add(string modelNumber, double price , TypeOfService typeOfService)
        {
            if(typeOfService == TypeOfService.Sell)
            {
                SellingPrice[modelNumber] = price;
            }
            else if(typeOfService == TypeOfService.Rent)
            {
                PricePerDay[modelNumber] = price;
            }
        }

        public double GetPrice(string modelNumber,TypeOfService typeOfService)
        {
            if (typeOfService == TypeOfService.Sell)
            {
                return SellingPrice[modelNumber];
            }
            else if (typeOfService == TypeOfService.Rent)
            {
                return PricePerDay[modelNumber];
            }
            return 0;
        }
    }
}
