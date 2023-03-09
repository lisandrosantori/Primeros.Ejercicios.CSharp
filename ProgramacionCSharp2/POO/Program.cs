/* Ejercicio 1: Crear un proyecto tipo consola llamada POO 
        a) En Program.cs copiar el ejemplo anterior y agregar la clase abstracta AdministrarProducto que contiene los siguientes métodos virtuales.
	        - CargarProducto(Producto prod) que permite cargar la informacion de cada producto y almacenarla en una lista.
	        - MostrarProducto(List<Producto> prods) que permite visualizar la información de todos los productos cargados.
	        - SececcionarProducto(string sku)
	        - ActualizarProducto(Producto prod)
	        - BorrarProducto(string sku) 
*/


using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        Producto prod = GetProducto();

        Console.WriteLine($"{prod.Sku}, {prod.Marca}, {prod.Modelo}, {prod.Detalle}");
        
    }

    private static Producto GetProducto()
    {
        var prod = new Producto()
        {
            Sku = "ASD345",
            Marca = "EPSON",
            Modelo = "TX-135",
            Detalle = "Impresora Multifunción con cartuchos"
        };

        return prod;
    }
    
    //public abstract class AdministrarProducto
    //{
    //    public virtual Producto CargarProducto(Producto prod) //permite cargar la informacion de cada producto y almacenarla en una lista.
    //    {
    //        return prod;
    //    }



    //    //public virtual MostrarProducto(List<Producto> prods) //permite visualizar la información de todos los productos cargados.
    //    //{

    //    //}

    //    //public virtual SeleccionarProducto(string sku)
    //    //{

    //    //}

    //    //public virtual ActualizarProducto(Producto prod)
    //    //{

    //    //}

    //    //public virtual BorrarProducto(string sku)
    //    //{

    //    //}

    //}

    public class ImpresorasHalper
    {
        public decimal GetPrecio()
        {
            return 1;
        }
        public bool GetEstado()
        {
            return false;
        }
        public int GetStock()
        {
            return 0;
        }
    }
}

public class Producto
{

    public string Sku { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Detalle { get; set; }



}




