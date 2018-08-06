using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
   public class Program
    {

        int versionNumber = 123;

        static void Main(string[] args)
        {
            //Create an instance of Program
            var myProgram = new Program();

            Console.WriteLine($"Current version: {myProgram.versionNumber}");
            Console.WriteLine(myProgram.ToString());
            Console.WriteLine(myProgram);

            var rectangle = new Rectangle();

            rectangle.Height = 5;
            rectangle.Width = 6;

            var triangle = new Triangle
            {
                Side1 = 3,
                Side2 = 4,
                Side3 = 5
            };



            myProgram.DisplayShape(rectangle);
            myProgram.DisplayShape(triangle);

            DateTime johnDoeDOB = new DateTime(10/10/1975);

            var JohnDoe = new Person(johnDoeDOB);

            JohnDoe.ShippingAddress.StreetAddress = "123 Main Street";

            JohnDoe.DisplayName();

            JohnDoe.ShippingAddress.DisplayAddress();

            //The following line will not compile
            //Console.WriteLine($"Current version: {versionNumber}");
            Console.ReadLine();
        }

        public void DisplayShape(Shape shape)
        {

            Console.WriteLine($"Shape Perimeter: {shape.Perimeter()}");
        }

        
    }
}
