using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleShowroom;

namespace VehicleShowroomTest
{
    [TestClass]
    public class ShowroomManagerFixture
    {
        [TestMethod]
        public void Check_if_we_get_the_correct_price_from_the_manager()
        {
            Vehicle vehicle = new Vehicle()
            {
                ModelNumber = "a1b2c3",
                Type = VehicleType.Car,
            };
            ShowroomManager manager = new ShowroomManager();
            PriceList pricelist = new PriceList();
            pricelist.Add("a1b2c3", 500, TypeOfService.Rent);
            pricelist.Add("1234556", 120000, TypeOfService.Sell);
            double price = manager.GenerateBill(vehicle, TypeOfService.Rent,pricelist,5);
            Assert.AreEqual(2500,price);
        }
        [TestMethod]
        public void Manager_keeps_a_record_of_total_revenue()
        {
            Vehicle vehicle = new Vehicle()
            {
                ModelNumber = "a1b2c3",
                Type = VehicleType.Car,
            };
            ShowroomManager manager = new ShowroomManager();
            PriceList pricelist = new PriceList();
            pricelist.Add("a1b2c3", 500, TypeOfService.Rent);
            pricelist.Add("a1b2c3", 120000, TypeOfService.Sell);
            manager.GenerateBill(vehicle, TypeOfService.Rent, pricelist, 5);
            manager.GenerateBill(vehicle, TypeOfService.Sell, pricelist, 1);
            Assert.AreEqual(122500,manager.TotalRevenue);
        }
    }
}
