using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer
{
    public class FizzBuzz
    {
        public void DoFizzBuzz(int num) 
        {
            string str = "";

            for (int i = 0; i < num; i++)
            {
                if (i % 15 == 0)
                {
                    str += "FizzBuzz";
                } else if (i % 5 == 0 )
                {
                    str += "Buzz";
                } else if (i % 3 == 0 )
                {
                    str += "Fizz";
                } else
                {
                    str = i.ToString();
                }

                Console.WriteLine(str);
                str = "";

            }
            return;
        }
    }
}
