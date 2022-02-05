using System;

namespace RetoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando = "";
            double calificacionFinal = 0;
            int counter = 0;

            do
            {
                Console.WriteLine("Ingrese la calificación del Alumno: ");
                string calificacionInput = Console.ReadLine();
                double calificacionIngresada = double.Parse(calificacionInput);
                calificacionFinal += calificacionIngresada;
                counter++;
                Console.WriteLine("De enter para otra calificación o escriba la palabra 'fin' para calcular el promedio.");
                comando = Console.ReadLine();
            } while (comando != "fin");
            
            double promedio = calificacionFinal / counter;
            Console.WriteLine(promedio);
        }
    }
}
