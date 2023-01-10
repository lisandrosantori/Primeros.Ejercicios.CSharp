string cad = "***CadenA De Caracteres***";
string cad1 = "Runa";

Console.WriteLine(cad.Substring(0,10)); // Muestra los caracteres, con el primer indice se marca desde cuando comienza y el segundo marca la cantidad
Console.WriteLine(cad.Contains(cad1)); // TRUE si contiene la cadena dentro de la otra cadena, FALSE si no la contiene.
Console.WriteLine(cad.ToLower()); // Reduce a minúsculas.
Console.WriteLine(cad.ToUpper()); // Convierte todo en mayúsculas.
Console.WriteLine(cad1.CompareTo(cad));
                                   



