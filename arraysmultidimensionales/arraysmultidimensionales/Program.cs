using System;

namespace arraysmultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de 2 dimensiones
            string[,] matriz2D;

            //Array de 3 dimensiones
            int[,,] matriz3D;

            string[,] arreglo2D = new string[,]
            {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i"}
            };
            //[fila, columna]
            Console.WriteLine(arreglo2D[2, 0]);

            char [,,] arreglo3D = new char[,,]
                {
                    {
                        {'a', 'b', 'c' },
                        {'d', 'e', 'f' },
                        {'g', 'h', 'i' }
                    },
                    {
                        { 'j', 'k', 'l'},
                        { 'm', 'n', 'o'},
                        { 'p', 'q', 'r'}
                    },
                    {
                        { 's', 't', 'v'},
                        { 'w', 'x', 'y'},
                        { 'z', 'q', 'f'}
                    }
                };

            Console.WriteLine(arreglo3D[0, 0, 0]);

        }
    }
}
