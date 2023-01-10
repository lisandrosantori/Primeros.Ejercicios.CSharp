
float a, b, suma, resta, multi, div;

Console.Write("Ingrese primer valor: ");
a = int.Parse(Console.ReadLine());
Console.Write("Ingrese segundo valor: ");
b = int.Parse(Console.ReadLine());

suma = a + b;
resta = a - b;
multi = a * b;
div = a / b;

Console.WriteLine($"La suma de los 2 valores es: {suma}");

Console.WriteLine($"La resta de los 2 valores es: {resta}");

Console.WriteLine($"La multiplicación de los 2 valores es: {multi}");

Console.WriteLine($"La división de los 2 valores es: {div}");

