using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите знавчение угла от 0 до 360 градусов:");
            int alfa = int.Parse(Console.ReadLine());
            if (alfa < 0 || alfa > 360)
            {
                Console.WriteLine("Недопустимое число");
                Environment.Exit(0);


            }
            double pi = 3.14;
            double answer = (pi * alfa) / 180;
            Console.WriteLine($"значение угла в радианах:{string.Format("{0:0.000}", answer)}");

        }
    }
}