using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public double distance;
        public int time;

        public InvoiceSummary(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
