using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosYJefes
{
    class Empleado
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }

        //Constructores
        public Empleado() 
        {
            Nombre = "Juan";
            Apellido = "Flores";
            Salario = 5000;
        }

        public Empleado(string nombre, string apellido, int salario)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }

        //Métodos
        public void Trabajar()
        {
            Console.WriteLine("Estoy trabando");
        }
        public void Descansar()
        {
            Console.WriteLine("Estoy descansando");
        }

    }
}
