using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        public Dictionary<string, List<InvoiceSummary>> userRide;

        public RideRepository()
        {
            this.userRide = new Dictionary<string, List<InvoiceSummary>>();
        }

        public void AddRides(string UserID, InvoiceSummary[] rides)
        {
            if (UserID == null)
                throw new CustomException(ExceptionType.NULL_EXCEPTION + "");
            bool checkRide = userRide.ContainsKey(UserID);
            List<InvoiceSummary> list = new List<InvoiceSummary>();
            if (!checkRide)
            {
                list.AddRange(rides);
                userRide.Add(UserID, list);
            }
        }
        public InvoiceSummary[] GetRides(string userId)
        {
            return userRide[userId].ToArray();
        }
    }
}
