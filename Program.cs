using System;
using System;

namespace GestionEstudiantes
{
    // Clase Estudiante
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; } // Array de 3 teléfonos

        // Constructor
        public Estudiante()
        {
            Telefonos = new string[3]; // Inicializa el array con 3 posiciones
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("\n--- Información del Estudiante ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Estudiante ===");

            Estudiante estudiante = new Estudiante();

            // Solicitar datos al usuario
            Console.Write("Ingrese el ID del estudiante: ");
            estudiante.ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese los nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            estudiante.Direccion = Console.ReadLine();

            // Leer los 3 números de teléfono
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            // Mostrar la información registrada
            estudiante.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}