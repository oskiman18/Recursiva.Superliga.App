using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Recursiva.Superliga.App
{
    internal class Metodos
    {
   

        public List<Socio> Leercsv()
        {
            List<Socio> lista = new List<Socio>();
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Oscar\source\repos\Recursiva.Superliga\socios.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                Socio socio = new Socio(values[0], int.Parse(values[1]), values[2], values[3], values[4]);

                lista.Add(socio);
            }
            return lista;
        }

        public int Punto1()
        {
            List<Socio> lista = Leercsv();
            return lista.Count();               
        }


        public float Punto2()
        {
            List<Socio> lista = Leercsv();
            var sRacing = lista.Where(x => x.Equipo.Equals("Racing"));
            var promedio = sRacing.Average(x => x.Edad);
            return (float)promedio;
           
           

        }
        public List<Socio> Punto3()
        {
            List<Socio> lista = Leercsv();
            int pc = 0;
            List<Socio> result = new List<Socio>();
            foreach (var item in lista)
            {
                if(item.EstadoCivil.Equals("Casado") 
                    && item.NivelEstudios.Equals("Universitario")){
                    result.Add(item);
                    pc++;
                    if(pc==100) return result;
                }
            }

            return result;

        }


        public List<Socio> Punto4()
        {
            List<Socio> lista = Leercsv();
            var nombres = lista.Where(x=> x.Equipo.Equals("River")).GroupBy(x => x.Nombre);
            
            foreach (var item in lista)
            {
                if (item.Equipo.Equals("River"))
                {
               //   nombres.Add(item.Nombre);
                }
            }

            return lista;

        }



    }
}