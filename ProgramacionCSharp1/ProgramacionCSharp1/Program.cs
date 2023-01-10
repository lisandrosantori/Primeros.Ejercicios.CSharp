
float num1, num2, suma, producto, resta, modulo, division;

Console.Write("Ingrese primer valor: ");
num1= int.Parse(Console.ReadLine());

Console.Write("Ingrese segundo valor: ");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;

producto = num1 * num2;

resta = num1 - num2;

modulo = num1 % num2;

division = num1 / num2;

Console.WriteLine($"La suma de los dos valores es: {suma}");

Console.WriteLine($"El producto de los dos valores es: {producto}");

Console.WriteLine($"La resta de los dos valores es: {resta}");

Console.WriteLine($"El modulo de los dos valores es: {modulo}");

Console.WriteLine($"La división de los dos valores es: {division}");

Console.ReadKey();
