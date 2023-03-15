using System;
using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            InvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);


        }
        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            InvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary invoiceSummary = InvoiceGenerator.CalculateFare(rides);
            InvoiceSummary expected = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expected,invoiceSummary);
        }
    }
}
