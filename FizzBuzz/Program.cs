using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FizzBuzz fizzBuzzer = new FizzBuzz();
            Console.WriteLine("starting fizzbuzz...");
            fizzBuzzer.DoFizzBuzz(25);
            Console.ReadLine();
        }
    }
}
