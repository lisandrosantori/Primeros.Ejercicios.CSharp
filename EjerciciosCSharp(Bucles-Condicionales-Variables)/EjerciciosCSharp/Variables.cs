using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los números:");
            Console.Write("Primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Segundo número (para la división este número no puede ser 0): ");
            int y = int.Parse(Console.ReadLine());

            int resultadoSuma = Sumar(x, y);
            int resultadoResta = Restar(x, y);
            int resultadoMulti = Multiplicar(x, y);
            int resultadoDividir = Dividir(x, y);

            Console.WriteLine("La suma de los 2 números es: " + resultadoSuma);
            Console.WriteLine("La resta de los 2 números es: " + resultadoResta);
            Console.WriteLine("La multiplicación de los 2 números es: " + resultadoMulti);
            Console.WriteLine("La división de los 2 números es: " + resultadoDividir);

        }        

        static int Sumar (int x, int y)
        {
            int suma = x + y;
            return suma;
        }
        static int Restar(int x, int y)
        {
            int resta = x - y;
            return resta;

        }
        static int Multiplicar(int x, int y)
        {
            int multi = x * y;
            return multi;

        }
        static int Dividir(int x, int y)
        {
            int dividir = x / y;
            return dividir;

        }

        

    }
}
