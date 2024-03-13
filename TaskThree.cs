using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TaskThree
    {
        public void Run() 
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 / num2);

            Console.ReadLine();
        }
    }
}
