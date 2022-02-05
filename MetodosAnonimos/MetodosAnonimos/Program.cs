using System;

namespace MetodosAnonimos
{
    class Program
    {
        public delegate string ObtenerTexto(string nombre);
        static void Main(string[] args)
        {
            //Metodo anonimo compila al final
            ObtenerTexto miDelegado = delegate (string nombre)
            {
                return "Hola " + nombre;
            };
            Console.WriteLine(miDelegado("Fer"));

            //Por eso puedo ejecutar el metodo nombrado aqui
            DecirHola();

            //Recibiendo de metodo anonimo a metodo clasico
            Mostrar(miDelegado);


        }
        //Metodo anonimo como parametro de otro metodo
        public void Mostrar(ObtenerTexto miDelegado)
        {
            Console.WriteLine(miDelegado("Mundo"));
        }
        //Metodo nombrado compila primero
        public static void DecirHola()
        {
            Console.WriteLine("Hola");
        }
    }
}
