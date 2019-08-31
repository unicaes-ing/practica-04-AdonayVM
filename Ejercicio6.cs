using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica4
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int contador = 1, cantidad, auxiliar = 0;
            double precio = 0;

            Console.WriteLine("Ingrese la cantidad de Sucursales:");

            if (int.TryParse(Console.ReadLine(), out cantidad))
            {
                while (cantidad != 0)
                {

                    do
                    {
                        for (int i = 1; i <= cantidad; i++)
                        {
                            for (int j = 1; j <= 3; j++)
                            {
                                Console.WriteLine("Ingrese el monto de la venta #{0} de la sucursal #{1}", j, i);
                                precio = Convert.ToDouble(Console.ReadLine());
                                if (precio == 0)
                                {
                                    j = 4;
                                    i = cantidad + 1;
                                }
                            }

                        }
                        contador--;
                    } while (contador != 0);
                    cantidad = 0;
                }
            }
            else
            {

                //Verificacion.
                Console.WriteLine("No valido");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Ingrese la cantidad de Sucursales:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                while (cantidad != 0)
                {

                    do
                    {
                        for (int i = 1; i <= cantidad; i++)
                        {
                            for (int j = 1; j <= 3; j++)
                            {
                                Console.WriteLine("Ingrese el monto de la venta #{0} de la sucursal #{1}", j, i);
                                precio = Convert.ToDouble(Console.ReadLine());
                                if (precio == 0)
                                {
                                    j = 4;
                                    i = cantidad + 1;
                                }
                            }

                        }
                        contador--;
                    } while (contador != 0);
                    cantidad = 0;

                }
            }
        }
    }
}
