using System;
using System.Collections.Generic;

namespace Tarea2
{
    internal class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public Alumno() { }

        public Alumno(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }
    }

    internal class Cargador
    {
        private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

        public void RellenarDiccionario(int id, Alumno alumno)
        {
            alumnos[id] = alumno;
        }

        public void MostrarAlumnos()
        {
            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"ID: {alumno.Key}, Nombre: {alumno.Value.Nombre}, Matrícula: {alumno.Value.Matricula}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Cargador cargador = new Cargador();

            for (int i = 0; i < 3; i++) // Cambia el 3 por 10 si deseas ingresar 10 alumnos
            {
                Console.WriteLine("Ingresa un ID para el alumno:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre del alumno:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la matrícula del alumno:");
                string matricula = Console.ReadLine();

                Alumno alumno = new Alumno(nombre, matricula);
                cargador.RellenarDiccionario(id, alumno);
                Console.Clear();
            }

            cargador.MostrarAlumnos();
        }
    }
}
