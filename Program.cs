using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-3): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered '1'");
            Console.WriteLine("You entered '2' ");
            Console.WriteLine("You entered '3' ");

            Console.WriteLine("Invalid input. Please enter a number between 1 and 3. ");
            Console.WriteLine();
        }
    }
}
