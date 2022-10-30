using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности {0:f3}\nПлощадь окружности {1:f3}",Circle.GetLengthCircle(r), Circle.GetSquareCircle(r));
            if (Circle.GetInCircle(r, x0, y0, x, y))
            {
                Console.WriteLine("Точка находиться внутри окружности");           
            }
            else 
            {
                Console.WriteLine("Точка находиться вне окружности");
            }
            Console.ReadKey();
        }
    }
}
