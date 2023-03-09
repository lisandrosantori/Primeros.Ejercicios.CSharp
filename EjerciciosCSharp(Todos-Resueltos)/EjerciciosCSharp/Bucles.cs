using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    internal class Bucles
    {
        static void Main2(string[] args)
        {
            /* WHILE
            Console.WriteLine("Ingrese un número (0 para salir)");

            int num = int.Parse(Console.ReadLine());
            int acum = 0;

            while(num != 0)
            {
                Console.WriteLine("Ingrese un número (0 para salir");

                num = int.Parse(Console.ReadLine());
                acum = acum + num;
            }

            Console.WriteLine($"Acumulado: {acum}");
            */

            /* DO WHILE

            int num;
            int acum = 0;

            do
            {
                Console.WriteLine("Ingrese un número (0 para salir)");

                num = int.Parse(Console.ReadLine());
                acum = acum + num;

            } while (num != 0);

                Console.WriteLine($"Acumulado: {acum}");
            */

            /* FOR 

            int num = 0;
            int acum = 0;

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("ingrese un número");
                num = int.Parse(Console.ReadLine());
                acum = acum + num;
            }

            Console.WriteLine($"Acumulado: {acum}");

            */

            /* Ejercicio 3 A 
             * Programa que pida 10 números al usuarios y muestre los últimos 5 cargados.
            
            int[] numeros = new int [10];
           

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número {i+1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Últimos 5 números");

            for (int j = 5; j < 10; j++)
            {
                Console.WriteLine($"{numeros[j]}");
            }
            */

            /* Ejercicio 3 B 
             * Programa que pida las notas de 10 estudiantes y muestre cuando sacaron menos de 4, cuandos de 4 y 7 y cuantos más de 7.
            
            int[] notas = new int[10];
            int menor4 = 0;
            int entre4y7 = 0;
            int mayor7 = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la {i+1}° nota: ");
                notas[i] = int.Parse(Console.ReadLine());
                if (notas[i] < 4)
                {
                    menor4++;
                }
                else if (notas[i]>=4 && notas[i] <= 7)
                {
                    entre4y7++;
                }
                else
                {
                    mayor7++;
                }
            }

            Console.WriteLine($"Los alumnos que se sacaron una nota inferior a 4 fueron: {menor4} alumnos");
            Console.WriteLine($"Los alumnos que se sacaron una nota superior a 4 y inferior a 7 fueron: {entre4y7} alumnos");
            Console.WriteLine($"Los alumnos que se sacaron una nota superior a 7 fueron: {mayor7} alumnos");
            */

            /* Ejercicio 3 C
             * Modificar el programa b para que valide que la nota cargada esté entre 1 y 10 y si no muestre un mensaje de error y no tenga en cuenta ese números.
            
            int[] notas = new int[10];
            int menor4 = 0;
            int entre4y7 = 0;
            int mayor7 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la {i + 1}° nota: ");
                notas[i] = int.Parse(Console.ReadLine());

                while (notas[i] < 1 || notas[i] > 10) 
                {
                    Console.WriteLine("Nota incorrecta (debe ser un valor entre 1 y 10)");
                    Console.Write($"Vuelva a ingresar la {i + 1}° nota: ");
                    notas[i] = int.Parse(Console.ReadLine());
                }
                if (notas[i] < 4)
                {
                    menor4++;
                }
                else if (notas[i] >= 4 && notas[i] <= 7)
                {
                    entre4y7++;
                }
                else
                {
                    mayor7++;
                }
            }

            Console.WriteLine($"Los alumnos que se sacaron una nota inferior a 4 fueron: {menor4} alumnos");
            Console.WriteLine($"Los alumnos que se sacaron una nota superior a 4 y inferior a 7 fueron: {entre4y7} alumnos");
            Console.WriteLine($"Los alumnos que se sacaron una nota superior a 7 fueron: {mayor7} alumnos");
            */

            /* Ejercicio 3 D 
             * Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)
            
            int[] tabla = new int[10];
            int num;

            Console.WriteLine("Ingrese el número del cual quiera la tabla: ");
            num = int.Parse(Console.ReadLine());

            for(int i=0; i<10; i++)
            {
                tabla[i] = num * (i + 1);
            }

            Console.WriteLine($"Tabla del número {num}:");

            for(int j=0; j<10; j++)
            {
                Console.WriteLine($"{num} x {j+1} = { tabla[j]}");
            }
            */

            /* Ejercicio 3 E 
             * Desarrollar un programa que muestre los números pares del 2 al 50
            
            int[] tabla = new int[25];
            int num;

            Console.WriteLine("Ingrese el número del cual quiera la tabla: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 25; i++)
            {
                tabla[i] = num * (i + 1);
            }

            Console.WriteLine($"Tabla del número {num}:");

            for (int j = 0; j < 25; j++)
            {
                Console.WriteLine($"{num} x {j+1} = { tabla[j]}");
            }
            */

            /* Ejercicio 3 F

            * Hacer un programa que pida 10 números enteros y muestre por consola una tabla de la siguiente forma. 
            * Promedio parcial es el promedio del ítem con todos los anteriores (redondear a 2 decimales

            * Por ejemplo se vería así

            * id	numero	promedio
            * 1	    10	    10
            * 2	    20		15
            * 3	    12
            */
            int[] notas = new int[10];

            int menosDe4 = 0;
            int menosDe7 = 0;
            int masDe7 = 0;
            int contador = 0;

            Console.WriteLine("ingrese las notas:");

            while (contador < notas.Length)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero <= 10 && numero >= 0)
                {
                    notas[contador] = numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("La nota ingresada no cumple el requisito de 1 a 10");
                }

            }

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 4)
                {
                    menosDe4++;
                }
                else if (notas[i] < 7)
                {
                    menosDe7++;

                }
                else
                {
                    masDe7++;
                }
            }

            Console.WriteLine($"Los alumnos que se ssacaron menos de 4: {menosDe4}.{Environment.NewLine} " +
                $"los alumnos que se sacaron menos de 7: {menosDe7}. {Environment.NewLine} " +
                $"los alumonos que se sacaron mas de 7: {masDe7}.");

        }

    }
}
