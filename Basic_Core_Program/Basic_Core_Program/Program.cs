using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Largest_among_num large = new Largest_among_num();
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            large.largest_num(number1, number2, number3);
            
        }
    }
}