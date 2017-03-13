using System;
using static System.Console;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an number");
            int input = 0;
            Int32.TryParse(ReadLine(), out input);

            switch (input)
            {
                case 1:
                    WriteLine("You entered 1");
                    break;
                case 2:
                    WriteLine("You entered 2");
                    break;
                case 3:
                    WriteLine("You entered 3");
                    break;
                case 4:
                    WriteLine("You entered 4");
                    break;
                default:
                    WriteLine("Out of range");
                    break;
            }
        }
    }
}