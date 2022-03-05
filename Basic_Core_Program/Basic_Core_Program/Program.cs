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
            Check_Vowel_consonant vowelconsonant = new Check_Vowel_consonant();
            Console.WriteLine("Enter charactor");
            char alphabet = Convert.ToChar(Console.ReadLine());
            vowelconsonant.vowel_consonant(alphabet);
        }
    }
}