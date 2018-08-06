using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
  public class Address
    {
       

        public string StreetAddress { get; set; }
        public string City { get; set; }

        public string County { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

      

        public void DisplayAddress()
        {

            Console.WriteLine($"{ StreetAddress}\n{City}, {County}, {PostalCode}\n{Country}");
        }
    }

   

    
}
