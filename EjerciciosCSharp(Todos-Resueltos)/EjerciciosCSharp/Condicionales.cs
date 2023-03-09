using System;

namespace EjerciciosCSharp
{
    internal class Condicionales
    {
        static void Main1(string[] args)
        {
            /* Estructura Condicional
            float sueldo;
            string linea;
            Console.Write("Ingrese sueldo: ");
            linea= Console.ReadLine();
            sueldo= float.Parse(linea);
            if (sueldo > 3000)
            {
                Console.WriteLine("Esta persona debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("Esta persona NO debe abonar impuestos");
            }
            Console.ReadKey();
            */

            /* Estructura Condicional modificación
            float sueldo;
            string linea;
            Console.Write("Ingrese sueldo: ");
            linea= Console.ReadLine();
            sueldo= float.Parse(linea);

            if (sueldo > 3000)
            {
                Console.WriteLine("Esta persona debe abonar impuestos");
            } 
            else if (sueldo > 3000 && sueldo < 10000)
            {
                Console.WriteLine("Esta persona paga un 10% de impuestos");
            }
            else if (sueldo > 10000 && sueldo < 25000)
            {
                Console.WriteLine("Esta persona paga un 20% de impuestos");
            }
            else
            {
                Console.WriteLine("Esta persona paga un 35% de impuestos");
            }
            Console.ReadKey();
            */

        }
    }
}
