using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //public double distance;
        //public int time;

        //public InvoiceSummary(double distance, int time)
        //{
        //    this.distance = distance;
        //    this.time = time;
        //}
        public double distance;
        public int time;
        public CabRide rideType;

        public InvoiceSummary(CabRide rideType, double distance, int time)
        {
            this.distance = distance;
            this.time = time;
            this.rideType = rideType;
        }

    }
}
