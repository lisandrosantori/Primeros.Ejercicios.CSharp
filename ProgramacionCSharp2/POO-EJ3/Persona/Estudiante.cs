using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace POO_EJ3.Persona
{
    public class Estudiante : Persona
    {
        public int NroEstudiante { get; set; }
        public decimal Promedio { get; set; }
        public bool Enrolable { get; set; }

        public List<string> CodSeminario { get; set; }
    }
}
