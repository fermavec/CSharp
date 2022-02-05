using System;

namespace ClaseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime born = new DateTime(1987, 07, 15);
            Console.WriteLine("Yo nací el {0}", born);

            //Fecha actual
            Console.WriteLine(DateTime.Today);

            //Hora Actual
            Console.WriteLine(DateTime.Now);

            //Mañana(Metodo)
            DateTime manana = Tomorrow();
            Console.WriteLine(manana);

            //Dia de la semana (Reto)
            Console.WriteLine(DateTime.Today.DayOfWeek);

            //Primer dia del año
            DateTime anio = firstDayofYear(1910);
            Console.WriteLine(anio);

            //Hora en especifico
            DateTime diaDelAño = new DateTime(1910, 1, 1);
            Console.WriteLine(diaDelAño.DayOfWeek);

            //Reto
            DateTime ahora = DateTime.Now;
            Console.WriteLine("Son las {0} horas, con {1} minutos y {2} segundos.", ahora.Hour, ahora.Minute, ahora.Second);
            //Programa
            Console.WriteLine("Por favor, ingrese una fecha en el siguiente formato yyyy-mm-dd");
            string fechaIngresada = Console.ReadLine();
            DateTime tiempo = new DateTime(2000, 02, 15);

            if(DateTime.TryParse(fechaIngresada, out tiempo))
            {
                Console.WriteLine("Fecha ingresada: {0}", tiempo);
                Console.WriteLine("Fecha Actueal: {0}", ahora);
                TimeSpan diasEnteros = ahora.Subtract(tiempo);
                Console.WriteLine("Dias transcurridos {0}", diasEnteros.Days);
            }
            else
            {
                Console.WriteLine("Formato de fecha incorrecto.");
            }
        }
        //Metodos
        static DateTime Tomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime firstDayofYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
