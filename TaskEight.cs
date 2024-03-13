using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TaskEight
    {
        public void Run() 
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((num1 + num2) * num3);

            Console.ReadLine();

        }
    }
}
