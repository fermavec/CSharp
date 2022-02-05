using System;

namespace Puntajes
{
    class Program
    {
        static int record = 300;
        static string recordPersona = "Juan";



        static void Main(string[] args)
        {
            revisarRecord(250, "Mario");
            revisarRecord(315, "Laura");
            revisarRecord(350, "Nicolás");
            Console.Read();
        }

        public static void revisarRecord (int puntaje, string jugador)
        {
            if(puntaje > record)
            {
                record = puntaje;
                recordPersona = jugador;
                Console.WriteLine("El nuevo record es " + puntaje);
                Console.WriteLine("Fue logrado por " + jugador);
            }
            else
            {
                Console.WriteLine("El record vigente de " + record + " logrado por "
                    + recordPersona + " no fue superado");
            }
        }
    }
}
