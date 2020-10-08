using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Dzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, R;
            Console.WriteLine("Здраствуйте. Вас приветствуте программа Function!");
            int start = -8, finish = 10, r = 3;
            Console.Write("Введите значения R=");
            R = decimal.Parse(Console.ReadLine());
            if (R != 3) Console.WriteLine("Мне конечно это не нравится. Но будем считать, что я  не видел этого.");

            for (x = start; x <= finish; x += 0.2m)
            {
                if (x < -5)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment1());
                }
                else if (x < -3)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment2(x));
                }
                else if (x < 3)
                {
                    if (R != r)
                        Console.WriteLine("y({0:0.000})=функция не определима из-за неверного R");
                    else
                        Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment3(x, R));
                }
                else if (x < 8)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment4(x));
                }
                else if (x <= 10)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment5());
                }
            }
        }

        static double sigment1()
        {
            double y = -3;
            return y;
        }
        static decimal sigment2(decimal x)
        {
            decimal y = x + 3;
            return y;
        }
        static decimal sigment3(decimal x, decimal r)
        {
            decimal y = (decimal)Math.Sqrt(Math.Pow((double)r, 2) - Math.Pow((double)x, 2));
            return Math.Abs(y);
        }
        static decimal sigment4(decimal x)
        {
            decimal y = 3m / 5m * (x - 3);
            return y;
        }
        static double sigment5()
        {
            double y = 3;
            return y;
        }
    }
}
