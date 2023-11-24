using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Gerente : Empleado, IMostrarinformacion
    {
        public string Departamento { get; set; }

        // Constructor
        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }

        // Implementación de la interfaz IMostrarInformacion
        public new void MostrarInformacion()
        {
            base.MostrarInformacion(); 
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    
}
