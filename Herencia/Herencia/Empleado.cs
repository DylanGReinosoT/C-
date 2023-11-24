using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado: IMostrarinformacion
    {
        //Atributos
        public string Nombre { get; set; }
        public double Salario { get; set; }

        // Constructor
        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        //Metodo
        public double SalarioAnual()
        {
            return Salario * 12; 
        }

        //Implementacion de la interfaz

        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Salario mensual: {Salario:C}");
            Console.WriteLine($"Salario anual: {SalarioAnual():C}");
        }
    }

}
