using System;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingresa un número entero: ");
            string valorIngresado = Console.ReadLine();

            try 
            {
                int valor = int.Parse(valorIngresado);
            }
            //Puedo usar un Exception solo como excepción general.
            catch (FormatException)
            {
                Console.WriteLine("Na na na. Eso no es un número entero");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("No manches, que numerote!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Me siento tan vacio!!!!");
            }
            finally
            {
                Console.WriteLine("Pase lo que pase, yo estaré ahí para tí");
            }
            
            Console.Read();
        }
    }
}
