using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer forma de crear arrays
            int[] calificaciones = new int[5];

            calificaciones[0] = 10;
            calificaciones[1] = 7;
            calificaciones[2] = 6;
            calificaciones[3] = 8;
            calificaciones[4] = 5;

            Console.WriteLine(calificaciones[3]);

            Console.WriteLine("Ingrese la calificación del primer estudiante");
            string calificacion_1 = Console.ReadLine();
            calificaciones[0] = int.Parse(calificacion_1);

            Console.WriteLine("La calificación del primer alumno es {0}", calificaciones[0]);

            //Segunda forma de construir arrays
            int[] edades = { 10, 34, 25, 18, 52 };
            Console.WriteLine(edades[2]);

            //Tercer forma de crear un Array
            int[] inasistencias = new int[] { 5, 2, 0, 3, 8 };
            Console.WriteLine(inasistencias[0]);
            Console.WriteLine(inasistencias[inasistencias.Length - 1]);

            int extensionArray = inasistencias.Length;
            Console.WriteLine(extensionArray);
        }
    }
}
