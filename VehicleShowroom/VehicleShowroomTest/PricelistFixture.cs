using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleShowroom;

namespace VehicleShowroomTest
{
    [TestClass]
    public class PricelistFixture
    {
        [TestMethod]
        public void Check_price_are_set_fine_as_per_the_service_opted()
        {
            PriceList pricelist = new PriceList();
            pricelist.Add("a1b2c3", 500, TypeOfService.Rent);
            pricelist.Add("1234556", 120000, TypeOfService.Sell);
            double price = pricelist.GetPrice("a1b2c3", TypeOfService.Rent);
            Assert.AreEqual(500, price);
        }
        [TestMethod]
        public void Check_if_same_model_number_have_different_prices_as_per_the_type_of_service()
        {
            PriceList pricelist = new PriceList();
            pricelist.Add("a1b2c3", 500, TypeOfService.Rent);
            pricelist.Add("a1b2c3", 120000, TypeOfService.Sell);
            double rentPrice = pricelist.GetPrice("a1b2c3", TypeOfService.Rent);
            double sellPrice = pricelist.GetPrice("a1b2c3", TypeOfService.Sell);
            Assert.AreEqual(500, rentPrice);
            Assert.AreEqual(120000, sellPrice);
        }
        [TestMethod]
        public void Check_if_bill_is_0_for_test_drive()
        {
            PriceList pricelist = new PriceList();
            pricelist.Add("a1b2c3", 500, TypeOfService.Rent);
            pricelist.Add("a1b2c3", 120000, TypeOfService.Sell);
            double testdrivebill= pricelist.GetPrice("a1b2c3", TypeOfService.TestDrive);
            Assert.AreEqual(0, testdrivebill);
 
        }

    }
}
