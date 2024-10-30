using System;
using System.Collections.Generic;

namespace Tarea2
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto() { }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }

    internal class Cargador
    {
        private Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

        public void RellenarDiccionario(int id, Producto producto)
        {
            productos[id] = producto;
        }

        public void MostrarProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.Key}, Nombre: {producto.Value.Nombre}, Precio: ${producto.Value.Precio}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Cargador cargador = new Cargador();

            for (int i = 0; i < 3; i++) // Cambia el 3 por la cantidad de productos que deseas ingresar
            {
                Console.WriteLine("Ingresa un ID para el producto:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre del producto:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el precio del producto:");
                decimal precio = Convert.ToDecimal(Console.ReadLine());

                Producto producto = new Producto(nombre, precio);
                cargador.RellenarDiccionario(id, producto);
                Console.Clear();
            }

            cargador.MostrarProductos();
        }
    }
}
