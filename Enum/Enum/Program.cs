using System;

namespace Enum
{
    enum Dia { lunes = 1, martes, miercoles, jueves, viernes, sabado, domingo};
    class Program
    {
        static void Main(string[] args)
        {
            Dia v = Dia.viernes;
            Console.WriteLine("Hoy es {0}", v);
            Console.WriteLine((int)Dia.lunes);
        }
    }
}
