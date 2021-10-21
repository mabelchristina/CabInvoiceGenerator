using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceTest
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_CalculateFareMethodShould_ReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 20;
            int time = 45;

            // Calculating fare by passing the values of distance = 20km and time = 45 minutes
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 245;

            // Checking if the test case passes
            Assert.AreEqual(expectedFare, actualFare);
        }

    }
}