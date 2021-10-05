using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Vendedor
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public char Genero { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Vendedor()
        {
            Cedula = string.Empty;
            Nombre = string.Empty;
            PrimerApellido = string.Empty;
            SegundoApellido = string.Empty;
            FechaNacimiento = DateTime.MinValue;
            Genero = '\0';
            FechaIngreso = DateTime.MinValue;
        }

        public Vendedor(string cedula, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, char genero, DateTime fechaIngreso)
        {
            Cedula = cedula;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            FechaIngreso = fechaIngreso;
        }
    }
}
