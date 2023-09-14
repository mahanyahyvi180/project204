using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"power(10)={power(10)}");
            Console.WriteLine($"power(2,10)={power(2, 10)}");
        }

            static int power(int baseValue,int exponentValue=2)
            {
                int result = 1;

                for (int i = 1; i <= exponentValue; i++)
                {
                    result *= baseValue;
                }
                return result;
            }
        }
    }

