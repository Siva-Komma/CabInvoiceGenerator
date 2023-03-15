using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        enum 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cab invoice generator");
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoice.CalculateFare(2.0, 5);
            Console.WriteLine(fare);

            int val=(int)fare;
        }
    }
}
