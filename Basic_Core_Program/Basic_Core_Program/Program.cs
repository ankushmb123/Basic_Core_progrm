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
            Prime_factor prime = new Prime_factor();
            int num = Convert.ToInt32(Console.ReadLine());
            prime.Factorization(num);

        }
    }
}