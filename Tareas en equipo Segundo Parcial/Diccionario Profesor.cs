using System;
using System.Collections.Generic;

namespace Tarea2
{
    internal class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }

        public Profesor() { }

        public Profesor(string nombre, string materia)
        {
            Nombre = nombre;
            Materia = materia;
        }
    }

    internal class Cargador
    {
        private Dictionary<int, Profesor> profesores = new Dictionary<int, Profesor>();

        public void RellenarDiccionario(int id, Profesor profesor)
        {
            profesores[id] = profesor;
        }

        public void MostrarProfesores()
        {
            foreach (var profesor in profesores)
            {
                Console.WriteLine($"ID: {profesor.Key}, Nombre: {profesor.Value.Nombre}, Materia: {profesor.Value.Materia}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Cargador cargador = new Cargador();

            for (int i = 0; i < 3; i++) // Cambia el 3 por el número de profesores que deseas ingresar
            {
                Console.WriteLine("Ingresa un ID para el profesor:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre del profesor:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la materia que imparte el profesor:");
                string materia = Console.ReadLine();

                Profesor profesor = new Profesor(nombre, materia);
                cargador.RellenarDiccionario(id, profesor);
                Console.Clear();
            }

            cargador.MostrarProfesores();
        }
    }
}
