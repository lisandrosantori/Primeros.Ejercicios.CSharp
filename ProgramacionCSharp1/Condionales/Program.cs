/* Ejercicio 2 - Copiar el ejemplo anterior y probarlo.

float sueldo;
string linea;
Console.Write("Ingrese el sueldo: ");
linea= Console.ReadLine();
sueldo=float.Parse(linea);
if (sueldo > 3000)
{
    Console.Write("Esta persona debe abonar impuestos");
}
else
{
    Console.Write("Esta persona NO debe abonar impuestos");
}
Console.ReadKey();
*/

/* Ejercicio 3 - Modificar el código anterior para que muestre que:
 *  - Si el sueldo está entre 3000 y 10000 paga 10% de impuestos.
 *  - Si el sueldo está entre 10000 y 25000 paga 20% de impuestos.
 *  - Si el sueldo es más de 25000 paga 30% de impuestos.


float sueldo;
string linea;
Console.WriteLine("Ingrese el sueldo: ");
linea= Console.ReadLine();
sueldo=int.Parse(linea);

if (sueldo <= 3000)
{
    Console.WriteLine("Esta persona NO paga impuestos");
}
else if(sueldo > 3000 && sueldo <= 10000)
{
    Console.WriteLine("Esta perosona paga 10% de impuestos");
}
else if (sueldo > 10000 && sueldo <= 25000)
{
    Console.WriteLine("Esta persona paga 20% de impuestos");
}
else
{
    Console.WriteLine("Esta persona paga 30% de impuestos");
}
*/



