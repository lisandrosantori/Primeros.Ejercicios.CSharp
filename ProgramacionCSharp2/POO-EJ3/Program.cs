
using POO_EJ3.Persona;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Profesor> profes = GetProfesores();

        Estudiante est = GetEstudiante();

        //Mostrar datos basicos del estudiante

        Console.WriteLine($"Nombre: {est.Nombre}, Promedio {est.Promedio}");
        Console.WriteLine("Asiste a los siguientes seminarios: ");

        var seminarios = GetSeminariosByCode(est.CodSeminario);

        foreach(var s in seminarios)
        {
            Console.WriteLine($"Seminarios: {s.Codigo} - {s.Nombre}");
        }
        
    }

    private static List<Seminario> GetSeminariosByCode(List<string> codigos)
    {
        var seminarios = new List<Seminario>();

        var seminario = new Seminario()
        {
            Codigo = "Z21",
            Nombre = "Fisica Nuclear",
            Catedra = "Fisica"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z65",
            Nombre = "Topologia Algebraica",
            Catedra = "Matematica"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z12",
            Nombre = "Teoria del numero",
            Catedra = "Matematica"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z62",
            Nombre = "Calculo I",
            Catedra = "Matematica"

        };
        seminarios.Add(seminario);
        seminario = new Seminario()
        {
            Codigo = "Z87",
            Nombre = "Quimica General",
            Catedra = "Quimica"

        };
        seminarios.Add(seminario);
        seminario = new Seminario()
        {
            Codigo = "Z94",
            Nombre = "Mecanica de los fluidos",
            Catedra = "Mecanica"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z35",
            Nombre = "Electronica del estado solido",
            Catedra = "Electronica"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z43",
            Nombre = "Sistemas operativos",
            Catedra = "Sistemas"

        };
        seminarios.Add(seminario);

        seminario = new Seminario()
        {
            Codigo = "Z86",
            Nombre = "Algoritmo y estructura de datos",
            Catedra = "Matematica"

        };
        seminarios.Add(seminario);

        //Filtamos por codigo

        var seminariosFiltrados = new List<Seminario>();

        foreach (var s in seminarios)
        {
            if (codigos.Contains(s.Codigo))
                seminariosFiltrados.Add(s);
        }

        //Filtro por primer codigo

        seminariosFiltrados = seminarios.Where(c => c.Codigo == codigos[0]).ToList();

        //Filtro por primer codigo

        seminariosFiltrados = (from s in seminarios 
                               where s.Codigo == codigos[0]
                               select s).ToList();

        // Si contiene un elemento en el array
        bool contiene = seminarios.Select(x => x.Codigo == codigos[1]).FirstOrDefault();
        contiene = seminarios.Select(x => x.Codigo == "ksdnfkdha").FirstOrDefault();

        return seminariosFiltrados;
    }

    private static List<Profesor> GetProfesores()
    {
        List<Profesor> profes = new List<Profesor>();

        var prof = new Profesor()
        {
            Nombre = "Julio Lopez",
            Email = "julio.lopez@uni.com.ar",
            Telefono = "555-23467",
            Salario = 120000
        };
        profes.Add(prof);

        return profes;
    }

    private static Estudiante GetEstudiante()
    {
        var est = new Estudiante()
        {
            Email = "juan.perez@gmail.com",
            Nombre = "Juan Perez",
            NroEstudiante = 323,
            Enrolable = false,
            Promedio = 6,
            Telefono = "555-3245"
        };

        est.CodSeminario = new List<string> { "Z21", "Z43", "Z62"};




        return est;
        
    }
}