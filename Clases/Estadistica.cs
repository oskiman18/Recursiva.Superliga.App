using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursiva.Superliga.App.Clases
{
    //cree una clase auxiliar para los datos de los clubes que pide
    //en la consigna 5
    class Estadistica
    {
        public int cSocios { get; set; }
        public string Nombre { get; set; }
        public float avgEdad { get; set; }
        public int minEdad { get; set; }
        public int maxEdad { get; set; }
        
        public Estadistica(int cs,string nombre,float avg, int min, int max)
        {
            this.cSocios = cs;
            this.Nombre = nombre;
            this.avgEdad = avg;
            this.minEdad = min;
            this.maxEdad = max;
        }

    }
}
