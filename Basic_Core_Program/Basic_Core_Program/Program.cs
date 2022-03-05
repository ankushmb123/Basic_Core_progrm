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
            Swap_two_num Swap = new Swap_two_num();
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Swap.Swaping(num1, num2);
        }
    }
}