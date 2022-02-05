using System;

namespace CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos coches tienes?");
            string autos = Console.ReadLine();
            int coches = int.Parse(autos);

            switch (coches)
            {
                case 0:
                    Console.WriteLine("¿Qué haces aquí si no tienes auto=?");
                    break;
                case 1:
                    Console.WriteLine("Pagarás 50 usd");
                    break;
                case 2:
                    Console.WriteLine("Pagarás 65 usd");
                    break;
                case 3:
                    Console.WriteLine("Pagarás 75 usd");
                    break;
                default:
                    Console.WriteLine("Pagarás millones de dolares");
                    break;
            }

        }
    }
}
