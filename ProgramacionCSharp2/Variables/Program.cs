/* a) En Variables.cs
    i.   int suma(int a, int b)
    ii.  int resta(int a, int b)
    iii. int multiplicacion(int a, int b)
    iv.  decimal division (int a, int b)

int resSuma, resResta, resMulti;
var num1 = 0;
var num2 = 0;
decimal resDiv;

Console.WriteLine("Ingrese números para sumar:");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

resSuma = Sumar(num1,num2);
resResta = Restar(num1,num2);
resMulti = Multiplicar(num2,num1);
resDiv = Dividir(num1, num2);

Console.WriteLine($"La suma entre {num1} y {num2} es: {resSuma}");
Console.WriteLine($"La resta entre {num1} y {num2} es: {resResta}");
Console.WriteLine($"La multiplicación entre {num1} y {num2} es: {resMulti}");
Console.WriteLine($"La división entre {num1} y {num2} es: {resDiv}");

int Sumar(int a, int b)
{
    int suma = a + b;

    return suma;
}
int Restar(int a, int b)
{
    int resta = a - b;

    return resta;
}
int Multiplicar(int a, int b)
{
    int multi = a * b;

    return multi;
}
decimal Dividir(decimal a, decimal b)
{
    decimal div = a / b;

    return div;
}



*/