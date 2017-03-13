using static System.Console;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Type in a string");
            string input;
            input = ReadLine();

            if(input == "")
            {
                WriteLine("The input is empty");
            } else if(input.Length < 5)
            {
                WriteLine("The string had Less than 5 characters");
            } else if(input.Length <= 10)
            {
                WriteLine("The string had at least 5 but less than 10 characters");
            }
            WriteLine($"The input was {input}");
        }
    }
}