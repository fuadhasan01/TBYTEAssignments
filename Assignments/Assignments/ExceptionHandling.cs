using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            int number1 = 95;
            int number2 = 4;
            int addition = number1 + number2;
            int multiplication = number1 * number2;
            int substrution = number1 - number2;
            int division = number1 / number2;
            int modulus = number1 % number2;

            //Console.WriteLine("Addition: {0} Substruction: {1} Multiplication: {2} Divition: {3} ",addition, substrution,multiplication,division);

            // Exception handling in c#
            // try-catch , finally





            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The exception is {0}", ex);
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //Switch-case

            int num = 5;

            switch (num)
            {
                case 0:
                    Console.WriteLine("Number 0");
                    break;
                case 1: Console.WriteLine("Number 1"); break;
                case 5: Console.WriteLine("Number 5"); break;
            }
        }
    }
}
