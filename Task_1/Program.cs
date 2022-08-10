using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /*1.   Разработать структуру для решения линейного уравнения 0=kx+b.
     * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
     * Для решения уравнения предусмотреть метод Root.
     * Создать экземпляр разработанной структуры.
     * Осуществить использование экземпляра в программе.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление корня линейного уравнения kx+b=0");
            Console.WriteLine();
            Console.Write("Введите значение коэффициента k - ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение члена b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Linear linear = new Linear(k, b);
            double root = linear.Root();

            Console.WriteLine($"Значение корня уравнения - {root}");
            Console.ReadKey();
        }
    }
}
