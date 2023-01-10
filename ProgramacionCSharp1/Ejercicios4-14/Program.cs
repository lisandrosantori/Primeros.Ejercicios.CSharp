
/*Ejercicio 4 - Crear un programa que imprima la leyenda "Curso de .Net C# 2022"

Console.WriteLine("Curso de .Net C# 2022");
*/

/*Ejercicio 5 - Crear un programa que pida un número al usuario y lo muestre por pantalla

Console.Write("ingrese un número: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Este es el número que ingreso: {num}");
*/

/* Ejercicio 6 - Crear un programa que pida dos números e indique cúal es el mayor de ambos

float num1, num2;

Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine($"El número más alto es: {num1}");
else 
    Console.WriteLine($"El número más alto es: {num2}");

*/

/* Ejercicio 7 - Crear un programa que pida tres números e indique cúal es el mayor de los tres

// Forma larga sin arreglo

float num1, num2, num3;

Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3) 
    Console.WriteLine($"El número más alto es: {num1}");
else if (num2> num1 && num2 > num3)
    Console.WriteLine($"El número más alto es: {num2}");
else 
    Console.WriteLine($"El número más alto es: {num3}");



// Forma con arreglo

float[] numeros = new float[3];
float max = 0;

Console.WriteLine("Ingrese 3 números: ");
numeros[0] = int.Parse(Console.ReadLine());
numeros[1] = int.Parse(Console.ReadLine());
numeros[2] = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i]>max) 
        max = numeros[i];
}

Console.WriteLine($"El número máximo es {max}");


*/

/* Ejercicio 8 - Crear un programa que muestre los números del 1 al 100

Console.WriteLine("Números del 1 al 100");

for (int i=0; i<100; i++)
{
    Console.WriteLine(i+1);
} 

*/

/* Ejercicio 9 - Crear un programa que muestre la suma de los 100 primeros números enteros

Console.WriteLine("Suma de los primeros 100 números enteros");

int acumSuma = 0;

for(int i = 0; i < 100; i++)
{
    acumSuma = acumSuma + (i+1);    
}
Console.WriteLine($"La suma de los primero 100 números es: {acumSuma}");

*/

/* Ejercicio 10 - Crear un programa que indique si un número entero cargado por el usuario es par o impar

int num, resto;


Console.WriteLine("Vamos a ver si tu número es par o impar");

Console.WriteLine("Ingrese un número (0 para salir): ");
num = int.Parse(Console.ReadLine());

while (num != 0)
{
    resto = num % 2;

    if (resto == 0)
        Console.WriteLine("El número es par");
    else
        Console.WriteLine("El número es impar");

    Console.WriteLine("Ingrese un número (0 para salir): ");
    num = int.Parse(Console.ReadLine());
}
*/

/* Ejercicio 11 - Crear un programa que pida 10 números y muestre el promedio 

float promedio, acum = 0;
int[] numeros = new int[10];

Console.WriteLine("Ingrese 10 números: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el {i+1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    acum = acum + numeros[i];
}

promedio=acum/numeros.Length;

Console.WriteLine($"Su promedio es: {promedio}");

*/

/* Ejercicio 12 - Crear un programa que pida 10 números y muestre el mayor de todos

int max = 0;
int[] numeros = new int[10];

Console.WriteLine("Ingrese 10 números: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el {i+1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (max < numeros[i])
    {
        max = numeros[i];
    }
}


Console.WriteLine($"El número más alto de todos los cargados es: {max}");
*/

/* Ejercicio 13 - Crear un programa que pida 10 números y muestre la suma de sus cuadrados 

double numCuadrados = 0;
int[] numeros = new int[10];

Console.WriteLine("Ingrese 10 números: ");

// Una forma

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el {i+1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    numCuadrados = numCuadrados + (numeros[i] * numeros[i]);

    Console.WriteLine(numCuadrados);

}

// Con función

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write($"Ingrese el {i + 1}° número: ");
//    numeros[i] = int.Parse(Console.ReadLine());

//    numCuadrados = numCuadrados + (Math.Pow(numeros[i],2));

//    Console.WriteLine(numCuadrados);
//}
*/

/* Ejercicio 14 - Crear un juego donde:
 * Calcule un número al azar entre 1 y 100
 * Pida al usuario que indique un número
 * Si el número es el calculado que muestre Acertaste!!
 *  - Sino que indique si el número es muy bajo o muy alto 
 *  - Vuelva a dejar que cargue otro número
 * Si pasaron 8 chances mostrar, Perdiste!! el número era <numero azar>

int numUsuario, numRandom, nroIntetos = 1;
var random = new Random();

Console.WriteLine("Vamos a jugar a adivinar un número aleatorio entre 1 y 100... Tiene 8 intentos...");
numRandom = random.Next(1, 101);
Console.WriteLine("Ingrese su 1° número: ");
numUsuario = int.Parse(Console.ReadLine());

while (numUsuario != numRandom && nroIntetos < 8) 
{     
    if (numRandom > numUsuario)
    {
        Console.WriteLine($"Fallaste tu {nroIntetos}° intento! El número es más grande");        
    }
    else
    {
        Console.WriteLine($"Fallaste tu {nroIntetos}° intento! El número es más pequeño");        
    }  

    Console.WriteLine($"Ingrese su {nroIntetos+1}° número: ");
    numUsuario = int.Parse(Console.ReadLine()); 
    nroIntetos++;
}
if (numUsuario == numRandom && nroIntetos <= 8)
    Console.WriteLine($"Acertaste!!! el número era {numUsuario}");
else
    Console.WriteLine($"Fallaste tus 8 intentos, el número era {numRandom}");
*/






