using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TaskTwo
    {
        public void Run()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert .ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
         
    }
}
