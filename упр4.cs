using System;

namespace ConsoleApp4
{

    class Square
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Решений нет");
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Корни совпадают и равны " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
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
