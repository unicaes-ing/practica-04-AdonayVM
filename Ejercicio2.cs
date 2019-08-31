using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica4
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            bool conf = false;
            double nota = 0, asistencia = 0;
            int apro = 0, repro = 0;
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Nota del estudiante " + i + ":");
                    if (double.TryParse(Console.ReadLine(), out nota))
                    {
                        conf = true;
                        nota = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el procentaje de asistencia del estudiante # {0}", i);
                        asistencia = Convert.ToDouble(Console.ReadLine());
                        if (nota >= 7.0 && asistencia >= 75)
                        {
                            apro = apro + 1;
                        }
                        else
                        {
                            repro = repro + 1;
                        }
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
            } while (conf == false); ;
            
            Console.WriteLine("Alumnos aprobados: {0:N2}", apro);
            Console.WriteLine("Alumnos reprobados: {0:N2}", repro);
            Console.ReadKey();
        }
    }
}
