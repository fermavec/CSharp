using System;

namespace Constantes
{
    class Program
    {
        //Las constantes se trabajam en este Scoope
        const double PI = 3.141592;
        const int SEMANAS = 52, MESES = 12;
        const string CONSTANTE = "Soy inmutable";

        static void Main(string[] args)
        {
            Console.WriteLine("El valor de PI es: {0}", PI);
            Console.Read();
        }
    }
}
