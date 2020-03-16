using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Enter your first number: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number: ");
            number3 = Int32.Parse(Console.ReadLine());
            int results;
            results = number1 + number2 + number3;
            Console.WriteLine("Sum= "+results.ToString());
            Console.ReadKey();
            results = number1 - number2 - number3;
            Console.WriteLine("Sum= " + results.ToString());
            Console.ReadKey();
            results = number1 * number2 * number3;
            Console.WriteLine("Sum= " + results.ToString());
            Console.ReadKey();
            results = number1 / number2 / number3;
            Console.WriteLine("Sum= " + results.ToString());
            Console.ReadKey();

        }
    }
}
