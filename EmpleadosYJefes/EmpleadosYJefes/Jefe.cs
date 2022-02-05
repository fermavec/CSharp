using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosYJefes
{
    class Jefe:Empleado
    {
        //Propiedad
        public string AutoDeEmpresa { get; set; }

        //Constructor
        public Jefe(string autoDeEMpresa, string nombre, string apellido, int salario):base(nombre,apellido,salario)
        {
            this.AutoDeEmpresa = AutoDeEmpresa;
        }

        //Método
        public void Dirigir()
        {
            Console.WriteLine("Me llamo {0} {1}, y estoy liderando mi empresa", Nombre, Apellido);
        }
    }
}
