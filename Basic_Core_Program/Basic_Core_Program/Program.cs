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
            Check_Even_odd even_odd = new Check_Even_odd();
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            even_odd.Evenodd(number);
            
        }
    }
}