using System.IO;
using System.Collections.Generic;
using System;

namespace Recursiva.Superliga.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            var casados = metodos.Punto3("Casado", "Universitario");
            var river = metodos.Punto4("River");
            var estadistica = metodos.Punto5();
            Console.WriteLine("La cantidad de personas registradas es de: " + metodos.Punto1());
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("El promedio de edad de hinchas de Racing es de: " + metodos.Punto2("Racing"));
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Listado de personas casadas y con estudios Universitarios: ");
            foreach (var item in casados)
            {
                Console.WriteLine(item.Nombre + " " + item.Edad + " " + item.Equipo);

            }
            Console.WriteLine("------------------------------------------------------------------");
            foreach (var item in river)
            {
                Console.WriteLine("Nombre: " + item.Key + " Cantidad de veces: " + item.Value);
            }
            Console.WriteLine("------------------------------------------------------------------");
            foreach (var item in estadistica)
            {

                Console.WriteLine("El equipo: " + item.Nombre);
                Console.WriteLine("Posee: " + item.cSocios + " Socios");
                Console.WriteLine("Su promedio de edad es de: " + item.avgEdad);
                Console.WriteLine("Su socio menor tiene: " + item.minEdad);
                Console.WriteLine("Su socio mayor tiene: " + item.maxEdad);
                Console.WriteLine("------------------------------------------------------------------");

            }



        }
    }


}
