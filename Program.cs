using System;

namespace Práctica4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool conf = false;
            double sueldo, total, prom;
            total = 0;
            do
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Sueldo de trabajador {0}", i);
                    if (double.TryParse(Console.ReadLine(), out sueldo))
                    {
                        conf = true;
                        total = total + sueldo;
                    }
                    else
                    {
                        Console.Clear();
                        i = i - 1;
                        Console.WriteLine("Dato inválido");
                        Console.WriteLine("[ENTER]");
                        Console.ReadKey();
                    }
                }
            } while (conf == false);
            
            prom = total / 20;
            Console.WriteLine("Total de sueldos: " + total);
            Console.WriteLine("");
            Console.WriteLine("Promedio de sueldos: " + prom);
            Console.ReadKey();
        }
    }
}
