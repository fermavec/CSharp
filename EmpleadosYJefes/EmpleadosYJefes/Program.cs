using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosYJefes
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado miguel = new Empleado("Miguel", " Flores", 4000);
            miguel.Trabajar();
            miguel.Descansar();

            Jefe chuckNorris = new Jefe("Ferrari", " Chuck", "Norris", 9999999);
            chuckNorris.Dirigir();

            Pasante laura = new Pasante(15, 20, "Laura", "Casas", 2000);
            laura.Trabajar();
            laura.Aprender();

            Console.Read();


        }
    }
}
