/* b) En Condicional.cs
    i.   decimal impuestoSueldo(decimal sueldo)


Console.WriteLine("Ingrese el sueldo: ");
decimal salario = decimal.Parse(Console.ReadLine());
string cadena, resultado;

resultado = impuestosSueldo(salario);

Console.WriteLine(resultado);

string impuestosSueldo(decimal sueldo)
{
    if (sueldo <= 3000)
    {
        cadena = "Esta persona NO paga impuestos";
    }
    else if (sueldo > 3000 && sueldo <= 10000)
    {
        cadena = "Esta perosona paga 10% de impuestos";
    }
    else if (sueldo > 10000 && sueldo <= 25000)
    {
        cadena = "Esta persona paga 20% de impuestos";
    }
    else
    {
        cadena = "Esta persona paga 30% de impuestos";
    }

    return cadena;
}
*/
