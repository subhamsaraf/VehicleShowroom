using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleShowroom;

namespace VehicleShowroomTest
{
    [TestClass]
    public class ShowroomManagerFixture
    {
        [TestMethod]
        public void check_if_we_get_the_correct_price_from_the_manager()
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
            double price = manager.GenerateBill(vehicle, TypeOfService.Rent,pricelist);
            Assert.AreEqual(500,price);
        }
    }
}
