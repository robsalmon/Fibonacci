using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string TaxPayerId { get; set; } = string.Empty;

        public Address ShippingAddress { get; set; }

        public Person(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
            
        }

        public void DisplayName()
        {

            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
