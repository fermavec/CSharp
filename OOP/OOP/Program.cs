using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando al Objeto Humano
            Humano fer = new Humano("Fernando", "Mavec", "Negros", 34);
            Humano pato = new Humano("Patricia", "Caracas", "Cafés", 60);

            //Instanciando Objeto mediante constructor por defecto
            Humano molde = new Humano();
            molde.presentarme();

            /* Al haber constructor, lo siguiente ya no es necesario
            //Accediendo a una variable publica externa
            //fer.primerNombre = "Fernando";
            //fer.apellido = "Mavec";
            //pato.primerNombre = "Patricia";
            //pato.apellido = "Caracas";
            */

            //Accediendo a un método público externo
            fer.presentarme();
            pato.presentarme();

        }
    }
}
