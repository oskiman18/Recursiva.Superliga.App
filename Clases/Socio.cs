using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursiva.Superliga.App
{
    class Socio
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Equipo { get; set; }
        public string EstadoCivil { get; set; }
        public string NivelEstudios { get; set; }

        public Socio(string nombre, int edad, string equipo, string ec, string ne)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Equipo = equipo;
            this.EstadoCivil = ec;
            this.NivelEstudios = ne;
        }
    }
}
