using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        [Test]
        public void GivenDistanceAndTime_CalculateFareMethodShould_ReturnTotalFare()
        {
            double distance = 20;
            int time = 45;

            // Calculating fare by passing the values of distance = 20km and time = 45 minutes
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 245;

            // Checking if the test case passes
            Assert.AreEqual(expectedFare, actualFare);
        }
        [Test]
        public void GivenMultipleRides_ThenCalculateFare_ShouldReturnTotalFare()
        {
            //InvoiceSummary[] rides = { new InvoiceSummary(2.0, 5), new InvoiceSummary(3.0, 6) };
            //double fare = invoiceGenerator.CalculateMultipleFare(rides);
            //Assert.AreEqual(61.0, fare);
        }
        [Test]
        public void GivenMultipleRides_ThenCalculateFare_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            //InvoiceSummary[] rides = { new InvoiceSummary(2.0, 5), new InvoiceSummary(3.0, 6) };
            //double invoiceSummary = invoice.CalculateMultipleFare(rides);
            EnhancedInvoice expected = new EnhancedInvoice(2, 61);
          //  object.Equals(expected, invoiceSummary);
        }
        [Test]
        public void GivenUserIdAndMultipleRides_ThenCalculateFare_shouldReturnNullUserException()
        {
            string userId = null;
            //InvoiceSummary[] rides = { new InvoiceSummary(2, 5), new InvoiceSummary(3, 6) };
            RideRepository rideRepository = new RideRepository();
            //CustomException exception = Assert.Throws<CustomException>(() => rideRepository.AddRides(userId, rides));
            //Assert.AreEqual("NULL_EXCEPTION", exception.message);
        }
        [Test]
        public void GivenUerIDAndListOfRides_WhenCalculated_ThenShouldReturnPremiumInvoice()
        {
            string userId1 = "Mabel";
            string userId2 = "Christina";
            InvoiceSummary[] rides1 = { new InvoiceSummary(CabRide.PREMIUM, 2, 5), new InvoiceSummary(CabRide.PREMIUM, 0.1, 1) };
            InvoiceSummary[] rides2 = { new InvoiceSummary(CabRide.PREMIUM, 2, 5), new InvoiceSummary(CabRide.PREMIUM, 0.1, 1) };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides(userId1, rides1);
            rideRepository.AddRides(userId2, rides2);
            InvoiceGenerator invoice = new InvoiceGenerator();
            var totalFareOne = invoice.CalculateMultipleFare(rideRepository.GetRides(userId1));
            var totalFareTwo = invoice.CalculateMultipleFare(rideRepository.GetRides(userId2));
            Assert.AreEqual(30.0, totalFareTwo);
        }
    }
}