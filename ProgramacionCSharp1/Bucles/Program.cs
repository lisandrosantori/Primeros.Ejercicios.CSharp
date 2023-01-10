/* Ejercicio 2 - Copiar los bucles y probarlos

// WHILE

Console.Write("Ingrese un numero (0 para salir): ");

int num = int.Parse(Console.ReadLine());
int acum = num;

while (num != 0)
{
    Console.Write("Ingrese un numero (0 para salir): ");
    num=int.Parse(Console.ReadLine());
    acum = acum + num;
}
Console.Write($"Acumulado: {acum}");

// DO WHILE

int acum = 0;
int num;

do
{
    Console.Write("Ingrese un número (0 para salir): ");
    num = int.Parse(Console.ReadLine());
    acum = acum + num;
}while(num != 0);

Console.WriteLine($"Acumulado: {acum}");

// FOR

int i = 0;
int num = 0;
int acum = 0;

for (i=0; i<10; i++)
{
    Console.Write("Ingrese un número: ");
    num=int.Parse(Console.ReadLine());
    acum = acum + num;
}
Console.WriteLine($"Acumulado: {acum}");

*/

/* Ejercicio 3 - A - Programa que pida 10 números al usuario y muestre los últimos 5 números

int[] numeros = new int[10];

for (int i = 0;i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el {i+1}° número");
    numeros[i] = int.Parse( Console.ReadLine() );

}

Console.WriteLine("Los últimos 5 números cargados fuero: ");

for(int i = 5; i< numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
*/

/* Ejercicio 3 - B - Programa que pida las notas de 10 estudiantes y que muestre cuantos se sacaron menos de 4, cuantos entre 4 y 7 y cuantos más de 7

int[] notas = new int[10];
int menos4 = 0, entre4y7 = 0, mas7 = 0;

Console.WriteLine("Cargue las notas de 10 estudiantes: ");
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"{i+1}° estudante: ");
    notas[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] < 4)
    {
        menos4++;
    }
    else if (notas[i] >= 4 && notas[i] < 7)
    {
        entre4y7++;
    }
    else
    {
        mas7++;
    }
}

Console.WriteLine($"Los estudiantes que se sacaron menos de 4 son: {menos4}");
Console.WriteLine($"Los estudiantes que se sacaron entre 4 y 7 son: {entre4y7}");
Console.WriteLine($"Los estudiantes que se sacaron más de 7 son: {mas7}");

*/

/* Ejercicio 3 - C - Modificar el programa B para que valide la nota cargada entre 1 y 10 y que muentre un mensaje de error y vuelva a pedir el número

int[] notas = new int[10];
int menos4 = 0, entre4y7 = 0, mas7 = 0;

Console.WriteLine("Cargue las notas de 10 estudiantes: ");

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"{i + 1}° estudante: ");
    notas[i] = int.Parse(Console.ReadLine());

    while (notas[i] < 1 || notas[i] > 10)
    {
        Console.WriteLine("La nota del estudiantes debe ser entre 1 y 10");
        Console.Write($"Vuelva a carga la nota del {i + 1}° estudante: ");
        notas[i] = int.Parse(Console.ReadLine());
    }   
    
}
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] < 4)
    {
        menos4++;
    }
    else if (notas[i] >= 4 && notas[i] < 7)
    {
        entre4y7++;
    }
    else
    {
        mas7++;
    }
}

Console.WriteLine($"Los estudiantes que se sacaron menos de 4 son: {menos4}");
Console.WriteLine($"Los estudiantes que se sacaron entre 4 y 7 son: {entre4y7}");
Console.WriteLine($"Los estudiantes que se sacaron más de 7 son: {mas7}");
*/

/* Ejercicio 3 - D - Desarrollar la tabla de multilplicar del 5 (del 5 al 50)

int num = 0;
int[] tabla= new int[10];

Console.WriteLine("Tabla del 5: ");

for (int i = 0;i < tabla.Length; i++)
{
    tabla[i]= 5 * (i+1);
    Console.WriteLine($"5x{i+1}= {tabla[i]}");
}   
*/

/* Ejercicio 3 - E - Desarrollar un programa que muentre los número pares del 2 al 50

Console.WriteLine("Números pares...");
Console.WriteLine("indique hasta que número quieser saber los números pares: ");
int numMax=int.Parse(Console.ReadLine());
int[] tabla = new int[numMax/2]; 


for (int i = 0; i < numMax/2; i++)
{
    tabla[i] = 2 * (i + 1);
    Console.WriteLine(tabla[i]);
}
*/

/* Ejercicio 3 - F - Hacer un programa que pida 10 números enteros y muestre por consola una tabla de la siguiente forma:
 * 
 * Promedio parcial es el promedio del ítem con todos los anteriores (redondear a 2 decimales)
 * 
 * Por ejemplo se vería así:
 * 
 * id   numero     promedio
 * 1    10          10
 * 2    20          15
 * 3    12  
 

float[] numeros = new float[10];
float[] suma = new float[10];
float[] promedio = new float[10];
float[,] tabla = new float[11,3];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el {i+1}° número entero: ");
    numeros[i] = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        suma[i] = numeros[i];
        promedio[i] = suma[i] / (i + 1);
    }
    else
    {
        suma[i] = suma[i - 1] + numeros[i];
        promedio[i] = suma[i] / (i + 1);
    }
    
}
Console.WriteLine("ID       Número          Promedio");
for (int i = 0; i < numeros.Length; i++)
{

    Console.Write($"{i + 1}");
    Console.Write($"        {numeros[i]}  ");
    Console.WriteLine($"            {promedio[i].ToString("#.00")}");
}
*/

/* Ejercicio 3 - G - Realizar un programa que lea los lados de n triángulos, e informar:
 * a) De cada uno de ellos, que tipo de triángulos es: equiláteros (tres lados iguales,
 * isósceles (dos lados igual), o escaleno (ningún lado igual).
 * b) Cantidad de triángulos de cada tipo.
 * c) Tipo de triángulos que posee menor cantidad.

int trianEq = 0, trianIs = 0, trianEs = 0, cantTria;

Console.WriteLine("¿Cuántos triángulos va a cargar?: ");
cantTria = int.Parse(Console.ReadLine());

int[] lado1= new int[cantTria];
int[] lado2= new int[cantTria];
int[] lado3= new int[cantTria];

for (int i = 0; i < lado1.Length; i++)
{
    Console.Write($"Cargue el primer lado del {i + 1}° triángulo: ");
    lado1[i] = int.Parse(Console.ReadLine());

    Console.Write($"Cargue el segundo lado del {i + 1}° triángulo: ");
    lado2[i] = int.Parse(Console.ReadLine());

    Console.Write($"Cargue el tercer lado del {i + 1}° triángulo: ");
    lado3[i] = int.Parse(Console.ReadLine());

    Console.WriteLine("----------------------------------------------");
}


for (int i = 0; i < lado1.Length; i++)
{
    if (lado1[i] == lado2[i])
    {        
        if (lado1[i] == lado3[i])
        {
            trianEq++;
        }
        else
        {
            trianIs++;
        }
    }
    else
    {
        if (lado1[i] == lado3[i])
        {
            trianIs++;
        }
        else
        {
            if (lado2[i] == lado3[i])
            {
                trianIs++;
            }
            else
            {
                trianEs++;
            }
        }
    }
    
}

Console.WriteLine($"Triángulos equiláteros: {trianEq}");
Console.WriteLine($"Triángulos isósceles: {trianIs}");
Console.WriteLine($"Triángulos escalenos: {trianEs}");

if (trianEq < trianIs && trianEq < trianEs)
    Console.WriteLine("El triángulo que posee menor cantidad es el equilátero");
else if (trianIs < trianEq && trianIs < trianEs) 
    Console.WriteLine($"El triángulo que posee menor cantidad es el isósceles");
else if (trianEs < trianEq && trianEs < trianIs)
    Console.WriteLine($"El triángulo que posee menor cantidad es el escaleno");
*/

/* Ejercicio 3 - H - Dado un número entero determinar si es un número primo. Un número primo es aquel que solo es divisible 
 * por sí mismo y por uno (pista: usar el operador modulo %). 

int num;
int moduloCero, contadorModCero = 0, divisor;

Console.Write("Ingrese el numero: ");
num = divisor = int.Parse(Console.ReadLine());

do
{
    if (divisor >= 1)
    {
        moduloCero = num % divisor;

        if(moduloCero==0)
            contadorModCero++;
    }

    divisor--;

} while (divisor >= 1);

if (contadorModCero == 2)
{
    Console.WriteLine("El número es primo");
}
else
{
    Console.WriteLine("El número no es primo");
}
*/

/* Ejercicio 3 - I - Pedir ingreso por teclado de 2 números enteros a y b. En forma repetitiva hace 10 clicos pedir un tercer número entero c.
Si está entre A y B (o entre B y A según sea el mayor de los dos) mostrar "Número C entá dentro del rango" sino, "Número C esta fuera del
rango". Donde C es el valor del numero cargado en esa iteración.*/ 

// NO LO ENTENDI.
// NO LO ENTENDI.
// NO LO ENTENDI.
// NO LO ENTENDI.
// NO LO ENTENDI.
// NO LO ENTENDI.









