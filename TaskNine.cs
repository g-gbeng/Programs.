using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TaskNine
    {
        public void Run()
        {
            Console.WriteLine("Enter first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Before swapping:a = {a}, b = {b}");
            double temporaryStorage = a;
            a = b;
            b = temporaryStorage;
            Console.WriteLine($"After swapping : a = {a}, b = {b}");

            Console.ReadLine();
        }
    }
}
