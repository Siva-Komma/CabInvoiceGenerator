using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType rideType;
        private RideRepository rideRepository;

        private double MINIMUM_COST_PER_KM;
        private int COST_PER_TIME;
        private double MINIMUM_FARE;
        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            this.rideRepository = new RideRepository();
            try
            {
                if(rideType.Equals(RideType.PREMIUM)) 
                { 
                    this.MINIMUM_COST_PER_KM= 15;
                    this.COST_PER_TIME= 2;
                    this.MINIMUM_FARE= 20;
                }
                else if(rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM= 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE= 5;
                }
            }catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE,"Invalid Ride");
            }

        }
    }
}
