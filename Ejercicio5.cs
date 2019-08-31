using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica4
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string contraseña = "Saludos", clave = "";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la contraseña");
                clave = Console.ReadLine();
                if (clave != contraseña)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pista:");
                    Console.WriteLine(contraseña[i] + "\n");
                }
            }
            Console.WriteLine("Sus intentos se agotaron");
            Console.ReadKey();
        }
    }
}
