using System;
using System.Collections.Generic;
using System.Text;

namespace RetoHerencia
{
    class Empleado
    {
        //Propiedades
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected double  Salario { get; set; }

        //Metodos
        public void ChecarEntrada()
        {
            Console.WriteLine("{0} {1} checó entrada al trabajo", this.Nombre, this.Apellido);
        }
        public void ChecarSalida()
        {
            Console.WriteLine("{0} {1} checó salida del trabajo", this.Nombre, this.Apellido);
        }

        //Constructores
        //Default
        public Empleado()
        {
            this.Nombre = "Empleado";
            this.Apellido = "NoLastName";
            this.Salario = 0;
        }
        //Parametrizado
        public Empleado(string nombre, string apellido, double salario) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }

        //Metodo toString
        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }
}
