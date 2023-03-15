using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> userride = null;
        public RideRepository()
        {
            this.userride = new Dictionary<string, List<Ride>>();
        }
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userride.ContainsKey(userId);
            try
            {
               if(!rideList)
               {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userride.Add(userId, list);
               }
            }catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDE, "Rides are null");
            }
        }
        public Ride[] GetRides(string userId)
        {
            try
            {
                return this.userride[userId].ToArray();
            }
            catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID,"Invalid User Id");
            }
        }
    }
}
