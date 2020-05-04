using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, v;
            bool prov;
            do
            {
                Console.Write("Введите число x: ");
                prov = double.TryParse(Console.ReadLine(), out x);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите число y: ");
                prov = double.TryParse(Console.ReadLine(), out y);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите число z: ");
                prov = double.TryParse(Console.ReadLine(), out z);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите число v: ");
                prov = double.TryParse(Console.ReadLine(), out v);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            double minres = min(min(x, y), min(z, v));
            Console.WriteLine("Минимальное значение из введёных чисел: "+minres);
            Console.ReadLine();
        }
        public static double min(double a, double b)
        {
            return (a < b) ? a : b;
        }
    }
}
