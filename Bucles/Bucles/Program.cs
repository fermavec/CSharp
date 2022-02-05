using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //DoWhile();
            //WhileLoop();
            BreakContinue();
        }
        //Bucle For
        public static void ForLoop()
        {
            for(int contador = 2; contador <= 20; contador += 2)
            {
                Console.WriteLine("El valor de contador es: {0} Par.", contador);
            }
        }
        
        //Bucle While
        public static void DoWhile()
        {
            int largoDeTexto = 0;
            do
            {
                Console.WriteLine("Ingresa el nombre de un amigo: ");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                Console.WriteLine("Llevas {0} Caracteres", largoDeTexto);
            } while (largoDeTexto < 20);
        }

        //Loop While
        public static void WhileLoop()
        {
            int counter = 0;
            while(counter < 4)
            {
                Console.WriteLine("Galileo");
                counter++;
            }
            Console.WriteLine("Figaro");
        }

        //Break and Continue
        public static void BreakContinue()
        {
            for(int i = 1; i < 10; i++)
            {
                if(i == 3)
                {
                    Console.WriteLine("A la de 3 bricamos");
                    continue;
                }else if (i == 7)
                {
                    Console.WriteLine("En el 7 paramos");
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
