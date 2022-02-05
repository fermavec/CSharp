using System;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados
            Random dado = new Random();
            Random dado2 = new Random();
            int valorCara;
            int valorCara2;

            for (int i = 0; i < 10; i++)
            {
                valorCara = dado.Next(1, 6 + 1);
                valorCara2 = dado2.Next(1, 6 + 1);
                if (valorCara == valorCara2)
                {
                    Console.WriteLine("DOUBLE\nDado 1: {0}, Dado 2: {1}", valorCara, valorCara2);
                }
                else
                {
                    Console.WriteLine("Dado 1: {0}, Dado 2: {1}", valorCara, valorCara2);
                }
            }
            //Adivina Adivinador
            Random respuesta = new Random();
            int valorRespuesta;

            Console.WriteLine("Tienes 3 preguntas, selecciona correctamente ya que sólo puedo darte respuestas específicas.");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Pregunta {0}:", j+1);
                Console.ReadLine();
                valorRespuesta = respuesta.Next(1, 3 + 1);
                if (valorRespuesta == 1)
                {
                    Console.WriteLine("Afirmativo");
                }
                else if (valorRespuesta == 2)
                {
                    Console.WriteLine("Negativo");
                }
                else
                {
                    Console.WriteLine("Tal vez");
                }
            }
        }

    }
}
