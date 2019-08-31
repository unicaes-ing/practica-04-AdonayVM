using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            bool Ver = false;
            int ventas;
            double total = 0.0;
            double ventass;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese el monto de la venta:");

                //ventas = Convert.ToDouble(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out ventas))
                {

                    if (ventas == -1.0)
                    {

                    }
                    else
                    {
                        total += ventas;
                        contador++;
                    }
                    Ver = true;
                }
                else
                {

                    ventass = Convert.ToDouble(Console.ReadLine());
                    if (ventass == -1.0)
                    {

                    }
                    else
                    {
                        total += ventass;
                        contador++;

                    }

                } while (ventas != -1.0) ;

                Console.WriteLine("Cantidad de ventas: {0:N2}", contador);
                Console.WriteLine("Dinero en ventas: {0:C2}", total);
                Console.WriteLine("Ventas + 5% de bono: {0:C2}", (total + (total * 0.05)));
                Console.ReadKey();
                Console.ReadKey();
            } while (Ver == false);
        }
    }
}
