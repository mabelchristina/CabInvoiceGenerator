using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        const int COST_PER_KILOMETER = 10;
        const int COST_PER_MINUTE = 1;
        const int MINIMUM_FARE = 5;
        public double CalculateFare(double distance, int time)
        {

            double totalFare = distance * COST_PER_KILOMETER + time * COST_PER_MINUTE;
            if (totalFare < MINIMUM_FARE)
                return MINIMUM_FARE;
            return totalFare;
        }
        public double CalculateMultipleFare(InvoiceSummary[] rides)
        {
            double totalFare = 0;
            foreach (InvoiceSummary ride in rides)
            {
                totalFare += this.CalculateFare(ride.distance, ride.time);
            }
            return totalFare;
        }
        public double CalculateMultipleFareRidesSummary(InvoiceSummary[] rides)
        {
            double totalFare = 0;
            int numberOfRides = 0;
            foreach (InvoiceSummary ride in rides)
            {
                totalFare += CalculateFare(ride.distance, ride.time);
                numberOfRides += 1;
            }
            EnhancedInvoice invoiceSummary = new EnhancedInvoice(numberOfRides, totalFare);
            return invoiceSummary.averageFarePerRide;
        }
    }
}
