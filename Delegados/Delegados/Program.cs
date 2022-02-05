using System;

namespace Delegados
{
    class Program
    {
        public delegate double HacerCalculo(double x, double y);
        public static double Suma(double a, double b)
        {
            Console.WriteLine("La suma de {0} y {1} es {2}", a, b, a+b);
            return a+b;
        }
        public static double Division(double a, double b)
        {
            Console.WriteLine("La división de {0} entre {1} es {2}", a, b, a / b);
            return a / b;
        }
        static void Main(string[] args)
        {
            HacerCalculo miCalculoS = Suma;
            miCalculoS(5.2, 5.25);

            HacerCalculo miCalculoD = Division;
            miCalculoD(10.50, 5.25);
            Console.WriteLine("**************");

            HacerCalculo calculoMultiple = miCalculoS + miCalculoD;
            calculoMultiple(85.23, 41.29);


            Console.Read();

        }
    }
}
