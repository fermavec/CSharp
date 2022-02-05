using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 4, 10);
            Console.WriteLine("El volumen es de {0}", caja.Volumen);
            caja.MuestraInfo();
            Console.Read();
        }
    }
}
