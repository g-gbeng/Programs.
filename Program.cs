// See https://aka.ms/new-console-template for more information
using ConsoleApp4;
using System;

namespace tasks
{
    class MainTasks
    {
        static void Main()
        {
            Console.WriteLine("Hello, Welcome to Muyiwa's First Application. ");
            Console.WriteLine("A range of programs are available for your use.");
            Console.WriteLine("1. A program to print hello and a name on a separate line.");
            Console.WriteLine("2. A program to sum two numbers. ");
            Console.WriteLine("3. A program to divide 2 numbers. ");
            Console.WriteLine("4. A program to print the result of a range of combined operations.");
            Console.WriteLine("5. A program to multiply 3 numbers");
            Console.WriteLine("6. A program to add, subtract, divide and multiply 2 numbers.");
            Console.WriteLine("7. A program to find the average of 4 numbers. ");
            Console.WriteLine("8. A program to add 2 numbers and multiply by a 3rd number. ");
            Console.WriteLine("9. A program to swap the positions of two given numbers. ");

            Console.WriteLine("Enter a number between 1 and 9 to proceed");
            _ = int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            { case 1:
                    TaskOne taskOne = new TaskOne();
                    taskOne.Run();
                    break;
              case 2:
                    TaskTwo taskTwo = new TaskTwo();
                    taskTwo.Run();
                    break;
              case 3:
                    TaskThree taskThree = new TaskThree();
                    taskThree.Run();
                    break;
              case 4:
                    TaskFour taskFour = new TaskFour();
                    taskFour.Run();
                    break;
              case 5:
                    TaskFive taskFive = new TaskFive();
                    taskFive.Run();
                    break;
              case 6:
                    TaskSix taskSix = new TaskSix();
                    taskSix.Run();
                    break;
              case 7:
                    TaskSeven taskSeven = new TaskSeven();
                    taskSeven.Run();
                    break;
                case 8:
                    TaskEight taskEight = new TaskEight();
                    taskEight.Run();
                    break;
                    case 9:
                    TaskNine taskNine = new TaskNine();
                    taskNine.Run();
                    break;
                default:Console.WriteLine("INPUT IS NOT VALID");
                    break;

            }

                }
           
            }

            



        }
    

