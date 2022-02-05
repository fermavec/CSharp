using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpecificStrings("Yo soy un argumento enviado a un método");
            Console.WriteLine(Sumar(15, 185));
            Console.WriteLine(Multiplicar(125.24, 5.25));
            Console.WriteLine("Escribe tu nombre");
            string inputName = Console.ReadLine();
            SaludarAmigo(inputName);
            Console.Read();
        }
        //Por fuera del método main pero dentro de la clase en la que estamos trabahando
        //NivelDeAcceso/STATIC/TipoDeRetorno/nombreDelMetodo/(argumentos)/{}
        //"static" es la aclaración de que un método no pertenece a un objeto OOP
        //Método Void
        public static void WriteSomething()
        {
            Console.WriteLine("Yo nací dentro de un método");
        }
        public static void WriteSpecificStrings(string myText)
        {
            Console.WriteLine(myText);
        }
        //Métodos con valores de Retorno
        public static int Sumar(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
        public static double Multiplicar(double n1, double n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }
        public static void SaludarAmigo(string nombre)
        {
            Console.WriteLine("Hola {0}, que tengas un excelente día", nombre);
        }
    }
}
