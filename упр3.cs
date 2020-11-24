using System;

namespace ConsoleApp3
{

    class NextChar
    {
        static void Main(string[] args)
        {
            char b = Convert.ToChar(Console.ReadLine());
            b++;
            Console.WriteLine(Convert.ToChar(b));
        }
    }
}
