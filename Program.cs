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
            var  casados = metodos.Punto3();
            var lista = metodos.Punto4();
            Console.WriteLine("La cantidad de personas registradas es de: " + metodos.Punto1());
            Console.WriteLine("El promedio de edad de hinchas de Racing es de: " + metodos.Punto2());
            Console.WriteLine("Listado de personas casadas y con estudios Universitarios: ");
            foreach (var item in casados )
            {
                Console.WriteLine(item.Nombre + " " + item.Edad + " " + item.Equipo);

            }
        }
    }


  
}


