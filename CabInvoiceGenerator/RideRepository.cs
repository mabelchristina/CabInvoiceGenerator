using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        public Dictionary<string, List<InvoiceSummary>> userRideObject;

        public RideRepository()
        {
            this.userRideObject = new Dictionary<string, List<InvoiceSummary>>();
        }

        public void AddRides(string UserID, InvoiceSummary[] rides)
        {
            if (UserID == null)
                throw new CustomException(ExceptionType.NULL_EXCEPTION + "");
            bool checkRide = userRideObject.ContainsKey(UserID);
            List<InvoiceSummary> list = new List<InvoiceSummary>();
            if (checkRide == false)
            {
                list.AddRange(rides);
                userRideObject.Add(UserID, list);
            }
        }
    }
}
