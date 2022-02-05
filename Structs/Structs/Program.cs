using System;

namespace Structs
{
    struct Juego
    {
        //Puede tener variables
        public string nombre;
        public string desarrollador;

        //No puede tener constructor por Default
        //No hereda
        //Si tiene interfaces
        //Si puede tener constructor parametrizado
        public Juego(string nombre, string desarrollador)
        {
            this.nombre = nombre;
            this.desarrollador = desarrollador;
        }
        
        //Si puede tener metodos
        public void Mostrar()
        {
            Console.WriteLine("{0}\nDesarrollado por: {1}", nombre, desarrollador);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego1 = new Juego("Ataque Zombie", "Mavec's Crazy Games Studio");
            
            //juego1.nombre = "Ataque Zombie";
            //juego1.desarrollador = "Mavec's Crazy Games Studio";

            juego1.Mostrar();

        }
    }
}
