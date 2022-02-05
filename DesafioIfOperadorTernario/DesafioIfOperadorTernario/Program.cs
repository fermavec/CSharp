using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIfOperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperaturaIngresada = 0;
            string mensajeTemperatura = string.Empty;
            string valorIngresado = string.Empty;

            Console.WriteLine("Ingrese la temperatura actual: ");
            valorIngresado = Console.ReadLine();

            bool integerValido = int.TryParse(valorIngresado, out temperaturaIngresada);

            if(integerValido)
            {
                mensajeTemperatura = temperaturaIngresada <= 15 ?
                    // si es verdadero 
                    "Hace mucho frío" :
                    // si es falso
                    (temperaturaIngresada >= 16 && temperaturaIngresada <= 28) ?
                    // si es verdadero
                    "Hace un clima agradable" :
                    // si es falso
                    "Hace mucho calor";
                Console.WriteLine(mensajeTemperatura);
            }
            else
            {
                Console.WriteLine("Esa no es una temperatura válida");
            }
            Console.ReadKey();

        }
    }
}
