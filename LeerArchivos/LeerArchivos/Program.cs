using System;

namespace LeerArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto Completo
            string texto = System.IO.File.ReadAllText(@"C:\Users\fchav\OneDrive\Documentos\Fer Mavec\C#\TextoALeer.txt");
            Console.WriteLine("El archivo contiene el siguiente texto:\n{0}", texto);

            //Lineas
            string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\fchav\OneDrive\Documentos\Fer Mavec\C#\TextoALeer.txt");
            foreach(string linea in lineas)
            {
                Console.WriteLine("\t" + linea);

            }

            //Crear archivo de texto
            string[] typeONegative = { "black", "black", "black", "black", "number oooooooooooonnnnnneeeeeeeee" };
            //Seleccion de ruta para sobreescribir
            System.IO.File.WriteAllLines(@"C:\Users\fchav\OneDrive\Documentos\Fer Mavec\C#\TextoALeer.txt", typeONegative);
            //Seleccion de ruta para crear nuevo
            System.IO.File.WriteAllLines(@"C:\Users\fchav\OneDrive\Documentos\Fer Mavec\C#\TypeONegative.txt", typeONegative);

            Console.WriteLine("Archivo Creado");
        }
    }
}
