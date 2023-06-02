using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    internal class EjerciciosClase
    {
        /* Ejercicio 1 de clase
        
        static void Main(string[] args)
        {
            int n = 123;
            int resultado = Aleatorio(n);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        // Función que devuelve un número aleatorio entre 0 y n, donde n es el parámetro

        static int Aleatorio(int n)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();



            sw.Stop();
            var rand = new Random((int)sw.ElapsedMilliseconds);

            int elegido = rand.Next() % n;

            return elegido;

        }
    

    }*/

        /* Ejercicio 2 de clase
        static void Main(string[] args)
        {            
            int[] numeros = { 45, 12, 35, 48, 9, 48, 67, 48, 16, 18 };

            int resultado = Aleatorio(numeros);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        // Función que devuelve un número aleatorio entre 0 y n, donde n es el parámetro

        static int Aleatorio(int[] numeros)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();



            sw.Stop();
            var rand = new Random((int)sw.ElapsedMilliseconds);

            int elegido = rand.Next() % numeros.Length;

            return numeros[elegido];

        }
        }*/

        /* Ejercicio 3 de clase

        static void Main(string[] args)
        {
            int[] numeros = { 45, 12, 35, 48, 9, 48, 67, 48, 16, 18 };

            //int resultado = Aleatorio(numeros);
            //Console.WriteLine(resultado);

            var (max, min) = MaxMin(numeros);

            int resultado = Maximo(numeros);
            int resultado1 = Mininimo(numeros);

            Console.WriteLine("El número máximo es: " + resultado + " y el número mínimo: " + resultado1);
            Console.WriteLine("El número máximo es: " + max + " y el número mínimo: " + min);

            Console.ReadLine();
        }

        private static (int, int) MaxMin(int[] numeros)
        {
            int max = Maximo(numeros);
            int min = Mininimo(numeros);

            return (max, min);
        }

        /// <summary>
        /// Función que devuelve un número aleatorio entre los numeros de un vector recibido por parametro
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 
        static int Aleatorio(int[] numeros)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();



            sw.Stop();
            var rand = new Random((int)sw.ElapsedMilliseconds);

            int elegido = rand.Next() % numeros.Length;

            return numeros[elegido];

        }

        static int Maximo(int[] numeros)
        {
            int max = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }

            }

            return max;

        }

        static int Mininimo(int[] numeros)
        {
            int min = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                min = numeros[i];

                if (min > numeros[i])
                {
                    min = numeros[i];
                }
            }
            return min;
        }

        }*/

        /*Ejercicio 4 de clase 
        static void Main(string[] args)
        {
            int[] numeros = { 45, 12, 35, 48, 9, 48, 67, 48, 16, 18 };

            //int resultado = Aleatorio(numeros);
            //Console.WriteLine(resultado);

            var (max, min) = MaxMin(numeros);

            int resultado = Maximo(numeros);
            int resultado1 = Minimo(numeros);

            int max2 = Maximo2(numeros);
            int min2 = Minimo2(numeros);

            Console.WriteLine("El número máximo es: " + resultado + " y el número mínimo: " + resultado1);
            Console.WriteLine("El número máximo es: " + max + " y el número mínimo: " + min);
            Console.WriteLine("El número máximo es: " + max2 + " y el número mínimo: " + min2);
            Console.ReadLine();
        }

        private static (int, int) MaxMin(int[] numeros)
        {
            int max = Maximo(numeros);
            int min = Minimo(numeros);

            return (max, min);
        }

        /// <summary>
        /// Función que devuelve un número aleatorio entre los numeros de un vector recibido por parametro
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 
        static int Aleatorio(int[] numeros)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();



            sw.Stop();
            var rand = new Random((int)sw.ElapsedMilliseconds);

            int elegido = rand.Next() % numeros.Length;

            return numeros[elegido];

        }

        static int Maximo2(int[] numeros)
        {
            int max = 0;

            foreach (var n in numeros)
            {
                if (n > max) max = n;

            }
            return max;
        }
        static int Minimo2(int[] numeros)
        {
            int min = 999;

            foreach (var n in numeros)
            {

                if (n < min) min = n;

            }
            return min;
        }
        static int Maximo(int[] numeros)
        {
            int max = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }

            }

            return max;

        }
        static int Minimo(int[] numeros)
        {
            int min = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                min = numeros[i];

                if (min > numeros[i])
                {
                    min = numeros[i];
                }
            }
            return min;
        }
        }*/

        /*Ejercicio 5 de clase

        static void Main(string[] args)
        {
            int[] numeros = { 45, 12, 35, 48, 9, 48, 67, 48, 16, 18 };

            int resultadoA = Aleatorio(numeros);
            Console.WriteLine(resultadoA);

            var (max, min) = MaxMin(numeros);

            int resultado = Maximo(numeros);
            int resultado1 = Minimo(numeros);

            int max2 = Maximo2(numeros);
            int min2 = Minimo2(numeros);

            Console.WriteLine("El número máximo es: " + resultado + " y el número mínimo: " + resultado1);
            Console.WriteLine("El número máximo es: " + max + " y el número mínimo: " + min);
            Console.WriteLine("El número máximo es: " + max2 + " y el número mínimo: " + min2);
            Console.ReadLine();


        }

        private static (int, int) MaxMin(int[] numeros)
        {
            int max = Maximo(numeros);
            int min = Minimo(numeros);

            return (max, min);
        }

        /// <summary>
        /// Función que devuelve un número aleatorio entre los numeros de un vector recibido por parametro
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 
        static int Aleatorio(int[] numeros)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            sw.Stop();
            var rand = new Random((int)sw.ElapsedMilliseconds);

            int elegido = rand.Next() % numeros.Length;

            return numeros[elegido];

        }

        static int Maximo2(int[] numeros)
        {
            int max = 0;

            foreach (var n in numeros)
            {
                if (n > max) max = n;

            }
            return max;
        }
        static int Minimo2(int[] numeros)
        {
            int min = 999;

            foreach (var n in numeros)
            {

                if (n < min) min = n;

            }
            return min;
        }
        static int Maximo(int[] numeros)
        {
            int max = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }

            }

            return max;

        }
        static int Minimo(int[] numeros)
        {
            int min = 999;

            for (int i = 0; i < numeros.Length; i++)
            {

                if (min > numeros[i])
                {
                    min = numeros[i];
                }
            }
            return min;
        }

    }*/

    }
}



