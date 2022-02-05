using System;

namespace arrayscomoparametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int[] {5, 10, 1, 8, 7, 6, 3, 8, 5, 10};
            Console.WriteLine(ObtenerPromedio(calificaciones));

            double[] customerAccounts = new double[] { 250.13, 2850.36, 125.25, 2045, 3075.85 };
            CrazyBank(customerAccounts);

        }
        static double ObtenerPromedio (int[] puntajes)
        {
            int cantidad = puntajes.Length;
            double promedio;
            int suma = 0;

            for(int i = 0; i < cantidad; i++)
            {
                suma += puntajes[i];
            }
            
            return promedio = (double)suma / cantidad;
        }
        static void CrazyBank(double[] customers)
        {
            double credito = 200;
            
            for(int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Su saldo es de: {0}usd", customers[i]);
                customers[i] += credito;
                Console.WriteLine("El Crazy Bank está feliz de otorgarle 200 usd de regalo simplemente porque estamos bien locos");
                Console.WriteLine("Ahora su saldo es de: {0}usd", customers[i]);
                Console.WriteLine("----------------------------");
            }
            
        }
        
    }
}
