using System;

namespace BlueScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Ett allvarligt systemfel har inträffat.");
            Console.WriteLine("Datorn måste startas om.");

       
        }
    }
}
