using System;
using System.Collections.Generic;

namespace Tarea2
{
    internal class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }

        public Cancion() { }

        public Cancion(string nombre, string genero)
        {
            Nombre = nombre;
            Genero = genero;
        }
    }

    internal class Cargador
    {
        private Dictionary<int, Cancion> canciones = new Dictionary<int, Cancion>();

        public void RellenarDiccionario(int id, Cancion cancion)
        {
            canciones[id] = cancion;
        }

        public void MostrarCanciones()
        {
            foreach (var cancion in canciones)
            {
                Console.WriteLine($"ID: {cancion.Key}, Nombre: {cancion.Value.Nombre}, G�nero: {cancion.Value.Genero}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Cargador cargador = new Cargador();

            for (int i = 0; i < 3; i++) // Cambia el 3 por 10 si deseas ingresar 10 canciones
            {
                Console.WriteLine("Ingresa un ID para la canci�n:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre de la canci�n:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el g�nero de la canci�n:");
                string genero = Console.ReadLine();

                Cancion cancion = new Cancion(nombre, genero);
                cargador.RellenarDiccionario(id, cancion);
                Console.Clear();
            }

            cargador.MostrarCanciones();
        }
    }
}
