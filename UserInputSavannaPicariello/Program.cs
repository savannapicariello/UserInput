using System;

namespace UserInputSavannaPicariello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Savanna Picariello.");
            Console.WriteLine("Please type something, then press enter...");

            string response = Console.ReadLine();

            Console.WriteLine("This is what you typed:");
            Console.WriteLine(response);


        }
    }
}
