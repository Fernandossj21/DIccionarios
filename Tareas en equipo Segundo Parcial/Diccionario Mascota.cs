using System;
using System.Collections.Generic;

namespace Tarea2
{
    internal class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
        public Mascota() { }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.

        public Mascota(string nombre, string raza)
        {
            Nombre = nombre;
            Raza = raza;
        }
    }

    internal class Face
    {
        private Dictionary<int, Mascota> mascotas = new Dictionary<int, Mascota>();

        public void RellenarDiccionario(int id, Mascota mascota)
        {
            mascotas[id] = mascota;
        }

        public void MostrarMascotas()
        {
            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"ID: {mascota.Key}, Nombre: {mascota.Value.Nombre}, Raza: {mascota.Value.Raza}");
            }
        }
    }
}
