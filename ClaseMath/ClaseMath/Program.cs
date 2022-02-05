using System;

namespace ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = .0003234;
            double b = .0020234;

            Console.WriteLine("El redondeo hacia arriba de 15.3 es {0}", Math.Ceiling(15.3));
            Console.WriteLine("El redondeo hacia abajo de 15.3 es {0}", Math.Floor(15.3));
            Console.WriteLine("El valor más chico entre {0} y {1} es {2}", a, b, Math.Min(a, b));
            Console.WriteLine("El valor más grande entre {0} y {1} es {2}", a, b, Math.Max(a, b));

            Console.WriteLine("El numero de granos duplicados por cada cuadro de ajedrez es " + Math.Pow(2, 64));
            Console.WriteLine("El valor de Pi es: {0}", Math.PI);

            Console.WriteLine("La raíz cuadrada del absoluto de -4 es: {0}", Math.Sqrt(Math.Abs(-4)));

            Console.WriteLine("El coseno de 1 es: {0}", Math.Cos(1)); 
        }
    }
}
