using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Example 1");

            Console.WriteLine(ConcatName("Tiago", "Aguiar"));
        }

        static string ConcatName(string name, string lastname)
        {
            return $"{name} {lastname}";
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
