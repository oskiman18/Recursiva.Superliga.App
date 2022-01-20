using Recursiva.Superliga.App.Clases;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Recursiva.Superliga.App
{
    internal class Metodos
    {
        const string RUTA = @"C:\Users\Oscar\source\repos\Recursiva.Superliga\socios.csv";

        public List<Socio> Leercsv()
        {
            List<Socio> lista = new List<Socio>();
            var reader = new StreamReader(File.OpenRead(RUTA));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                Socio socio = new Socio(values[0],
                                        int.Parse(values[1]),
                                        values[2],
                                        values[3],
                                        values[4]);

                lista.Add(socio);
            }
            return lista;
        }

        public int Punto1()
        {
            List<Socio> lista = Leercsv();
            return lista.Count();
        }


        public float Punto2(string club)
        {
            List<Socio> lista = Leercsv();
            var sRacing = lista.Where(x => x.Equipo.Equals(club));
            var promedio = sRacing.Average(x => x.Edad);
            return (float)promedio;



        }
        public IEnumerable<Socio> Punto3(string ec, string ne)
        {
            List<Socio> lista = Leercsv();
            var result = lista.Where(x => x.EstadoCivil.Equals(ec)
                    && x.NivelEstudios.Equals(ne)).Take(100);
            return result;

        }


        public IEnumerable<KeyValuePair<string, int>> Punto4(string club)
        {
            List<Socio> lista = Leercsv();
            var sRiver = lista.Where(x => x.Equipo.Equals(club)).GroupBy(x => x.Nombre);
            Dictionary<string, int> nombres = new();
            foreach (var item in sRiver)
            {
                nombres.Add(item.Key, item.Count());
            }
            var listafinal = nombres.OrderByDescending(x => x.Value).Take(5);
            return listafinal;

        }

        public IOrderedEnumerable<Estadistica> Punto5(){

            List<Socio> lista = Leercsv();
            var lista2 = lista.GroupBy(x => x.Equipo);
            List<Estadistica>cSocios = new();
            foreach (var item in lista2)
            {
                Estadistica e = new Estadistica(item.Count(), 
                                item.Key, 
                                (float)item.Average(x => x.Edad), 
                                item.Min(x => x.Edad), 
                                item.Max(x => x.Edad));
                cSocios.Add(e);
            }
            var listFinal = cSocios.OrderByDescending(x => x.cSocios);
            return listFinal;
        }

    }
}