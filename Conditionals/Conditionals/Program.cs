using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al comparar Strings usas "Equals"
            string nombre = "Fer";
            string user = "Fer";
            if (nombre.Equals(user))
            {
                Console.WriteLine("Inicializando...");
            }
            else
            {
                Console.WriteLine("No eres usuario");
            }

            //El comparar numericos puedes usar "=="
            Console.WriteLine("Ingresa la temperatura a la que está tu ciudad en este momento: ");
            string temperaturaInput = Console.ReadLine();

            double temperatura;
            double grados;

            if(double.TryParse(temperaturaInput, out grados)) 
            {
                temperatura = grados;
            }
            else
            {
                temperatura = 0.00;
                Console.WriteLine("El valor no es un número");
            }
            
            
            if (temperatura < 0)
            {
                Console.WriteLine("Ni salgas, te vas a congelar");
            }
            else if (temperatura < 12)
            {
                Console.WriteLine("Abrigate bien");
            }
            else if (temperatura > 12 && temperatura < 20)
            {
                Console.WriteLine("Con un sueter la armas");
            }
            else if (temperatura > 20 && temperatura < 35)
            {
                Console.WriteLine("Puedes andar en playera sin problema");
            }
            else
            {
                Console.WriteLine("Estás seguro/a? te vas a derretir");
            }


        }
    }
}
