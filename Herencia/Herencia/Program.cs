using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Empleado y Gerente
            Empleado empleado = new Empleado("Juan", 3000);
            Gerente gerente = new Gerente("Ana", 5000, "Ventas");

            // Mostrar información utilizando polimorfismo a través de la interfaz
            Console.WriteLine("Información del Empleado:");
            empleado.MostrarInformacion();

            Console.WriteLine("\nInformación del Gerente:");
            gerente.MostrarInformacion();
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
