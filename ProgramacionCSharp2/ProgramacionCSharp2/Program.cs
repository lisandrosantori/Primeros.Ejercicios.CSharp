/* ----------- FUNCIONES -----------  */

/* Ejercicio 1 - Implementar en funciones todos los ejericios de C# anteriores.
a) En Variables.cs
    i.   int suma(int a, int b)
    ii.  int resta(int a, int b)
    iii. int multiplicacion(int a, int b)
    iv.  decimal division (int a, int b)
b) En Condicional.cs
    i.   decimal impuestoSueldo(decimal sueldo)
*/

/* Ejercicio 2 - Implementar una función que calcule el factorial de un número

int numero, resultado;

Console.Write("Ingrese el número al cual le vamos a calcular el factoria: ");
numero = int.Parse(Console.ReadLine());

resultado = CalculoFactorial(numero);

Console.WriteLine($"El factorial del número {numero} es : {resultado}");

int CalculoFactorial(int num)
{
    int factorial = 1;

    while (num > 0)
    {
        factorial = factorial * num;

        num--;
    }

    return factorial;
}
*/

/* Ejercicio 3 - Implementar una función que convierta de C° a F°, donde F° = C° x 1.8 + 32 o C° = (F° - 32) / 1.8

double cel, far;

Console.WriteLine("Ingrese la temperatura en C° para convertirla en F°: ");
cel = double.Parse(Console.ReadLine());

far = ConvierteCenF(cel);

Console.WriteLine($"La temperatura en F° es: {far}");

double ConvierteCenF(double c)
{
    double f;
    f = (c * 1.8 + 32);

    return f;
}
*/

/* Ejercicio 4 - Implementar una funcín que reciba un año y devuelve true si es bisiesto y false si no lo es 
 
 Nota: Un año es bisiesto si es múltiplo de 4, de 400 y no es multiplo de 100

bool respuesta;
int a;

Console.WriteLine("Ingrese el año que quiera comprobar si es bisiesto: ");
a = int.Parse(Console.ReadLine());

respuesta = bisiesto(a);

Console.WriteLine(respuesta);

bool bisiesto(int anio)
{    
    int resulMul4 = anio % 4;
    int resutMul400 = anio % 400;
    int resulMul100 = anio % 100;

    //(resulMul4 == 0 && resutMul400 == 0 && resulMul100 != 0)
    //    Console.WriteLine(check);
    //else
    //    Console.WriteLine();


    return (resulMul4 == 0 || resutMul400 == 0 && resulMul100 != 0);
}
*/

/* Ejercicio 5 - Implementar una función que reciba dos números A y B y devulve true si A mayor o igual B y false en caso contario.

int a, b;
bool resultado;

Console.WriteLine("Ingresear 2 números a y b");
Console.Write("a: ");
a = int.Parse(Console.ReadLine());
Console.Write("b: ");
b = int.Parse(Console.ReadLine());

resultado = EsMayor(a, b);

Console.WriteLine(resultado);

bool EsMayor(int a , int b)
{
    return a == b || a > b ;
}

*/

/* Ejercicio 6 - Implementar una función que reciba una cadena de caractéres y devuelve la misma cadena pero con las letras pasadas a minúsculas
y viceversa, en caso de tener caracteres especiales no convertirlos.

string cadena;
string resultado;

Console.WriteLine("Ingresar una cadena con mayúsculas y minúsculas");
cadena = Console.ReadLine();


resultado = CambiarCaracteres(cadena);

Console.WriteLine(resultado);

string CambiarCaracteres(string cadena)
{
    int largoCadena = cadena.Length;
    string cadenaNueva = "";

    for(int i=0; i<largoCadena; i++)
    {
        if(cadena.Substring(i, 1) == cadena.Substring(i, 1).ToLower())
        {
            cadenaNueva = cadenaNueva + cadena.Substring(i, 1).ToUpper();
        }
        else
        {
            cadenaNueva = cadenaNueva + cadena.Substring(i, 1).ToLower();
        }            

    }
    return cadenaNueva;
}

*/

/* ----------- ARREGLOS -----------  */

/* Ejercicio 1 - Implementar el codigo del ejemplo y probarlo.

int[] sueldos;

Cargar();
Imprimir();

void Cargar()
{
    sueldos = new int[5];
    for (int f = 0; f < 5; f++)
    {
        Console.Write("Ingrese valor de la componente: ");
        string linea;
        linea = Console.ReadLine();
        sueldos[f] = int.Parse(linea);
    }
}

void Imprimir()
{
    for (int f = 0; f < 5; f++)
    {
        Console.WriteLine(sueldos[f]);
    }
    Console.ReadKey();
}

*/

/* Ejercicio 2 - Definir un vector de 5 componentes de tipo float que representen la altura de 5 personas.
    a) Obtener el promedio de las mismas.Funcion Promedio()
    b) Contar cuantas personas son más altas que el promedio y cuantas más bajas

float[] altura;

Cargar();
Console.WriteLine($"El promedio de las aturas es: {Promedio()}");
Console.WriteLine($"Hay {MasAltasDelProm()} personas más altas que el promedio");
Console.WriteLine($"Hay {MasBajasDelProm()} personas más bajas que el promedio");
Console.WriteLine($"Hay {IgualQueElProm()} personas que tiene una altura igual al promedio");

void Cargar()
{
    altura = new float[5];
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine("Cargue la altura: ");
        string linea;
        linea = Console.ReadLine();
        altura[i] = float.Parse(linea);
    }
}
float Promedio()
{
    float suma = 0, promedio = 0;
    for (int i = 0; i < altura.Length; i++)
    {
        suma += altura[i];
    }

    return (suma / altura.Length);
}
int MasAltasDelProm()
{
    int masAltas = 0;
    for(int i = 0; i < altura.Length; i++)
    {
        if (altura[i] > Promedio())
        {
            masAltas++;
        }
    }
    return masAltas;
}
int MasBajasDelProm()
{
    int masBajas = 0;
    for (int i = 0; i < altura.Length; i++)
    {
        if (altura[i] < Promedio())
        {
            masBajas++;
        }
    }
    return masBajas;
}
int IgualQueElProm()
{
    int igual = 0;
    for (int i = 0; i < altura.Length; i++)
    {
        if (altura[i] == Promedio())
        {
            igual++;
        }
    }
    return igual;
}

*/

/* Ejercicio 3 - Una empresa tiene 2 turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
    a) Confeccionar un programa que permita almacenar los sueldo de los empleados agrupados por turno. Funcion Cargar().
    b) Imprimir los gastos en sueldo de cada turno. Funcion Imprimir().



int[] sueldo, sueldoMa, sueldoTa;
string[] turno;

Cargar();
Imprimir();

void Cargar()
{
    sueldo = new int[4];
    turno = new string[4];
    sueldoMa = new int[4];
    sueldoTa = new int[4];

    for (int i = 0; i < sueldo.Length; i++)
    {
        Console.Write($"Cargar sueldo del {i+1}° empleado: ");
        sueldo[i] = int.Parse(Console.ReadLine());
        Console.Write($"Cargar el turno del {i+1}° empleado (M y T): ");
        turno[i] = Console.ReadLine();
        Console.WriteLine("-------------------------------------");
        if (turno[i] == "M" || turno[i] == "m")
        {
            sueldoMa[i] = sueldo[i];
        }
        else if (turno[i] == "T" || turno[i] == "t")
        {
            sueldoTa[i] = sueldo[i];
        }
    }
}
void Imprimir()
{
    int sumaMa = 0, sumaTa = 0;
    for (int i = 0; i < sueldo.Length; i++)
    {        
        if (sueldoMa[i] != 0)
        {
            sumaMa += sueldoMa[i];            
        }            
        if (sueldoTa[i] != 0)
        {
            sumaTa += sueldoTa[i];                       
        }           
    }
    Console.WriteLine($"Los gastos del turno mañana son: {sumaMa}");
    Console.WriteLine($"Los gastos del turno tarde son: {sumaTa}");
    Console.ReadKey();
}
*/

/* Ejercicio 4 - Dado un vector con 10 números calcular y mostrar por pantalla el promedio, el valor máximo y el mínimo. 
Función Cargar(), Promedio(), Maximo(), Minimo().

double[] vector;

Cargar();
Console.WriteLine($"El promedio del vector es: {Promedio()}");
Console.WriteLine($"El valor máximo del vector es: {Maximo()}");
Console.WriteLine($"El valor mínimo del vector es: {Minimo()}");

void Cargar()
{
    vector = new double[10];
    Console.WriteLine("Cargar 10 números al vector");
    for (int i = 0; i < vector.Length; i++)
    {
        Console.WriteLine($"---------- {i+1}° ----------");
        vector[i] = float.Parse(Console.ReadLine());
    }
}
double Promedio()
{
    double suma = 0;
    for(int i = 0; i < vector.Length; i++)
    {
        suma += vector[i];
    }
    return suma / vector.Length;
}
double Maximo()
{
    double max=0;
    for(int i = 0; i < vector.Length; i++)
    {
        if (vector[i] > max)
        {
            max = vector[i];
        }
    }
    return max;
}
double Minimo()
{
    double min = vector[0];
    for(int i = 0; i < vector.Length; i++)
    {
        if (vector[i] < min)
        {
            min = vector[i];
        }
    }
    return min;
}

*/

/* Ejercicio 5 - Dado un arreglo de 5 posiciones tipo string.
	a) Cargar 5 mensajes. Función cargar();
	b) Mostrar por pantalla cada mensaje.
	c) Mostrar sólo los mensajes comenzados con la letra "A".
	d) Mostrar sólo los mensajes que contenga "sa".
	e) Mostrar en un sólo string todos los mensajes separados por ", ".


string[] cadenas;

Cargar();
Console.WriteLine("Se muestran por consola las cadenas cargadas");
Mostrar();
Console.WriteLine("Se muestran las cadenas comenzadas con 'A'");
ComienzoA();
Console.WriteLine("Las cadenas que contiene 'sa' son");
ContengaSa();
Console.WriteLine("Estas son todas las cadenas separas por ','");
MostrarTodo();

void Cargar()
{
    cadenas = new string[5];   
    for(int i = 0; i < cadenas.Length; i++)
    {
        Console.Write($"Ingresar la {i+1}° cadena: ");
        cadenas[i] = Console.ReadLine();
    }
}
void Mostrar()
{
    for(int i = 0; i < cadenas.Length; i++)
    {
        Console.WriteLine(cadenas[i]);
    }
}
void ComienzoA()
{
    
    for(int i=0; i < cadenas.Length; i++)
    {
        if (cadenas[i].Substring(0, 1) == "A")
        {
            Console.WriteLine(cadenas[i]);
        }            
    }
    
}
void ContengaSa()
{
    
    for(int i = 0; i < cadenas[i].Length; i++)
    {
        for (int j = 0; j < (cadenas[i].Length-1); j++)
        {
            if (cadenas[i].Substring(j, 2) == "sa")
            {
                Console.WriteLine(cadenas[i]);                
            }
        }
    }
}
void MostrarTodo()
{
    for(int i = 0; i < cadenas.Length; i++)
    {
        if (i < (cadenas.Length - 1))
            Console.Write($"{cadenas[i]}, ");            
        else
            Console.Write($"{cadenas[i]}. ");
    }
}

*/

/* Ejercicio 6 - Dado un vector de 10 números mostrar por pantalla los números pero en orden inverso al que fueron cargados. 
 * Función Cargar() y Reverso()

int[] numeros;
int[] reverso;

Cargar();
Reverso();


void Cargar()
{
    numeros = new int[10];
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
    }
}
void Reverso()
{
    reverso = new int[10];
    int j = (reverso.Length - 1);
    for (int i = 0; i < numeros.Length; i++)
    {
        reverso[j] = numeros[i];
        j--;
    }
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(reverso[i]);
    }
}
*/

/* ----------- COLECCIONES - GENERICS - LISTAS - FOREACH -----------  */

/* Ejercicio 1 - Implementar el código de ejemplo y probarlo

// Listas

List<string> productosNombre = new List<string>()
{
    "HP X89",
    "HP X091"
};

List<string> marcas = new List<string>();
// Añadir un elemento
marcas.Add("Lenovo JH43948");
// Añadir una lista a otra lista
marcas.AddRange(productosNombre); // Se agrega la lista de productosnombres a marcas

// Foreach

List<int> secuencia = new List<int> {1, 2, 4, 5, 10};

foreach (var n in secuencia)
{
    if (n % 2 == 0)
        Console.WriteLine($"{n + 2}");
    else
        Console.WriteLine($"{n - 2}");
}
*/

/* Ejercicio 2 - Crear una lista de enteros llamadas numeros
	a) Cargar una lista de 10 números enteros por teclado
	b) Mostrarlos por pantalla
	c) Calcular el promedio de todos los números de la lista.
	d) Calcular la suma de los cuadrados.
	e) Genera otra lista llamada Enteros con los números del 1 al 100.
		- En base a esta generar otra lista llamada F formado de la siguiente manera: (NO SE QUE PIDE)
			* F(1) = F(2) = 1
			* F(3) = 2
			* F(n) = F(n-1) + F(n-2)


List<int> numeros = new List<int>(); //{ 5, 15, 46, 48, 57, 49, 12, 15, 16, 2 };
List<int> enteros = new List<int>(100);
Cargar();

Mostrar();

Console.WriteLine($"El promedio es: {Promedio()}");

Console.WriteLine($"La suma de los cuadrados es: {SumaCuadrados()}");

Cargar1a100();

MostrarNros();

void Cargar()
{
    for(int i = 0; i < 10; i++)
    {
        Console.Write($"Cargar el {i+1}° valor: ");
        numeros.Add(int.Parse(Console.ReadLine()));
    }
}
void Mostrar()
{
    Console.WriteLine("Los números de la lista son: ");
    foreach(int n in numeros)
    {
        Console.WriteLine(n);
    }
}
float Promedio()
{
    float suma = 0, promedio = 0;
    for (int i = 0; i < 10; i++)
    {        
        suma += numeros[i];
    }
    promedio = suma/10;

    return promedio;
}
double SumaCuadrados()
{
    double suma = 0;
    for (int i = 0; i < 10; i++)
    {
        suma += Math.Pow(numeros[i],2);
    }
    return suma;
}
void Cargar1a100()
{
    int numeros = 0;
    while (numeros < 100)
    {
        numeros++;
        enteros.Add(numeros);
        
    }
    
}
void MostrarNros()
{
    for (int i = 0; i < enteros.Count; i++)
    {
        Console.WriteLine(enteros[i]);
    }
}

NO ENTENDI EL "E" INSISO 2...

*/

/* Ejercicio 3 - Generar un programa que genere textos aleatorios
	- Crear una lista llamada Palabras. -- PalabrasAleatorias --
	- Cargar con 10 palabras.
	- Recorrerla y mostrar la lista de palabras en forma aleatoria
		- Pista: Usar acceso por índice y la función random().

Random rnd = new Random();
List<string> Abecedario = new List<string> {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
List<string> PalabrasAleatorias = new List<string>(10);

TextoAleatorio();

Console.WriteLine("Estas son las palabras aleatorias formadas: ");
Mostrar();

int NumeroRandom()
{
    int numero = 0;
    numero = rnd.Next(26);
    return numero;
}
void TextoAleatorio()
{
    
    for(int i = 0; i < 10; i++)
    {
        string palabra = "";
        for (int j = 0; j < (NumeroRandom()+1); j++) 
        {            
            palabra = palabra + Abecedario[NumeroRandom()];
        }
        PalabrasAleatorias.Add(palabra);
    }
}
void Mostrar()
{
    for(int i = 0; i < PalabrasAleatorias.Count; i++)
    {
        Console.WriteLine(PalabrasAleatorias[i]);
    }
}

*/


