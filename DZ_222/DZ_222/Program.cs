using System;

namespace DZ_222
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, R;
            Console.WriteLine("Здраствуйте. Вас приветствуте программа Function!");
            int start = -8, finish = 10, r = 3;
            do
            {
                Console.Write("Введите значения R=");
                R = decimal.Parse(Console.ReadLine());
                if (R < 0) Console.WriteLine("Ошибка. Попробуйте ещё раз.");
            } while (R < 0);

            for (x = start; x <= finish; x += 0.2m)
            {

                if (x < -5)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment1());
                }
                else if (x == -5)
                {
                    Console.WriteLine("y({0:0.000})=Фyнкция имеет два заначения {1:0.000} и {2:0.000}", x, sigment1(), sigment2(x));
                }
                else if (R > r && x == -3)
                {
                    Console.WriteLine(" y({0:0.000})=Фyнкция имеет два заначения {1:0.000} и {2:0.000}", x, sigment2(x), sigment3(x, R));
                }
                else if (x <= -3)
                {
                    Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment2(x));
                } 
                else if (x < 3)
                {
                    if (Math.Pow((double)R, 2) - Math.Pow((double)x, 2) < 0)
                    {

                        Console.WriteLine("y({0:0.000})=Функция не определена в данной точке", x);
                    }
                    else
                        Console.WriteLine("y({0:0.000})={1:0.000}", x, sigment3(x, R));
                }
                else if (R > r && x == 3)
                {
                    Console.WriteLine(" y({0:0.000})=Фyнкция имеет два заначения {1:0.000} и {2:0.000}", x, sigment3(x,R), sigment4(x));
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
            Console.ReadKey();
        }

        static decimal sigment1()
        {
            decimal y = -3m;
            return y;
        }
        static decimal sigment2(decimal x)
        {
            decimal y = x + 3m;
            return y;
        }
        static double sigment3(decimal x, decimal R)
        {
            double y = Math.Sqrt((double)(R * R - x * x));
            return Math.Abs(y);
        }
        static decimal sigment4(decimal x)
        {
            decimal y = 3 / 5m * (x - 3);
            return y;
        }
        static decimal sigment5()
        {
            decimal y = 3;
            return y;
        }
    }
}
