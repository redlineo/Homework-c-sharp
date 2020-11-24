using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("Деление на ноль, дядя.");
                }
                else
                {
                    Console.WriteLine(a / b);
                }

            }
            catch
            {
                Console.WriteLine("Введите данные в правильном формате.");
                Environment.Exit(0);
            }
            
        }
    }
}
