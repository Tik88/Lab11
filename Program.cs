using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения 0=kx+b:");
            Equations reshenie = new Equations();
            Console.WriteLine("Значение b:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение k:");
            double k = Convert.ToInt32(Console.ReadLine());
            reshenie.Condition(b, k);
        }
        struct Equations
        {
            private double b;
            private double k;
            private double x;

            internal void Condition(double meaningB, double meaningK)
            {
                b = meaningB;
                k = meaningK;
                Root();
            }
            public void Root()
            {
                if (k != 0)
                {
                    x = -b / k;
                    Console.WriteLine("Решение линейного уравнения 0=kx+b:");
                    Console.WriteLine("Переносим свободные слагаемые (без х) из левой части в правую, получим 0=b+kx;");
                    Console.WriteLine("Переносим свободные слагаемые с неизвестным х из правой части в левую, получаем -b=kx;");
                    Console.WriteLine("Делим обе части уравнения на x=k*x/(-b/x);");
                    Console.WriteLine("Получаем формулу х=-b/k");
                    Console.WriteLine("Итог решения: x={0,2:f2}", x);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ошибка деления на 0!!");
                    Console.ReadKey();
                }
            }

        }

    }
}
