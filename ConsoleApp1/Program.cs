using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");
            Console.WriteLine("Please enter the package weight:");
            int packageweight = Convert.ToInt32(Console.ReadLine());
            
            int maxweight = 50;
            if (packageweight > maxweight)
                {
                Console.WriteLine("Your package is too heavy to be delivered!");
                }

            Console.WriteLine("Please enter the package width:");
            int packagewidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packagelength = Convert.ToInt32(Console.ReadLine());

            int totaldimension = 50;
            if (packagewidth + packageheight + packagelength > totaldimension)
            {
                Console.WriteLine("Your package is too large to deliver!");
            }

            int package = (packagewidth * packageheight * packagelength);
            decimal quote = (package * packageweight / 100 + 0.00m);
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + " Thank You!");
            Console.ReadLine();
        }
    }
}
