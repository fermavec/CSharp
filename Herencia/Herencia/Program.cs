using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Este es mi primer post", true, "Fer Mavec");

            PublicacionImagen img1 = new PublicacionImagen("Mi foto", "Fer Mavec", "img.com.mx/img.html", true);

            PublicacionVideo video1 = new PublicacionVideo("Mi video", "Fer Mavec", "vid.com.mx/vid.mpg4", 25, true);

            //Impresiones en cnsola de las instancias de clase
            Console.WriteLine(post1.ToString());
            Console.WriteLine(img1.ToString());
            Console.WriteLine(video1.ToString());

            //Reproduccion de vide
            video1.Play();
            Console.WriteLine("Presione cualquier tecla para frenar el video");
            Console.ReadKey();
            video1.Stop();
            Console.WriteLine("Presione cualquier tecla para reproducir de nuevo el video");
            Console.ReadKey();
            video1.Play();


            Console.Read();

        }
    }
}
