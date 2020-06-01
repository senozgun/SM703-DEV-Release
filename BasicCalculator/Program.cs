using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Int 1: ");
            int iNumber1 = int.Parse(Console.ReadLine());

            Console.Write("Int 2: ");
            int iNumber2 = int.Parse(Console.ReadLine());

            int iSum = iNumber1 + iNumber2;

            Console.WriteLine("The Result is : " + iSum);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
