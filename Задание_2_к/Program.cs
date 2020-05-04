using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_2_к
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x)<(Math.PI/2)) y = Math.Sin(x);
            else if (Math.Abs(x) <= Math.PI) y = Math.Cos(x);
            else y = 0;
            return y;
        }
        static void Main(string[] args)
        {
            double a, b, h;
            bool prov;
            do
            {
                Console.Write("Введите начальное значение числа : ");
                prov = double.TryParse(Console.ReadLine(),out a);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите конечное значение числа : ");
                prov = double.TryParse(Console.ReadLine(), out b);
                if (b < a)
                    prov = false;
                if (!prov)
                    Console.WriteLine("Некорректный ввод");

            } while (!prov);
            do
            {
                Console.Write("Введите шаг : ");
                prov = double.TryParse(Console.ReadLine(), out h);
                if (h <= 0)
                    prov = false;
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            Console.ReadLine();
        }
    }
}
