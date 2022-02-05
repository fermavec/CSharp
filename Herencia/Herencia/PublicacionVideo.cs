using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Herencia
{
    class PublicacionVideo:Publicacion
    {
        //Variables del timer
        protected bool seReproduce = false;
        protected double duracionActual = 0;

        Timer reloj;
        
        //Propiedades de Publicacion Video
        protected string VideoUrl { get; set; }
        protected double Duracion { get; set; }

        //Constructor por defecto
        public PublicacionVideo() { }

        //Constructor Parametrizado
        public PublicacionVideo(string titulo, string autor, string urlVideo, double duracion, bool isPublic)
        {
            this.ID = CrearId();
            this.Titulo = titulo;
            this.Autor = autor;
            this.VideoUrl = urlVideo;
            this.Duracion = duracion;
        }

        //Metodo para impresion en consola
        public override string ToString()
        {
            return String.Format("{0} - {1} \ncreado por {2}. \n{3} \n{4} minutos.\n", this.ID, this.Titulo, this.Autor, this.VideoUrl, this.Duracion);

        }

        //Metodos para uso de Timer
        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }
        public void Stop()
        {
            if (seReproduce)
            {
                seReproduce = false;
                Console.WriteLine("Detenido en {0}s", duracionActual);
                duracionActual = 0;
                reloj.Dispose();
            }
        }
        private void Reproduccion(object o)
        {
            if(duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine("Video reproduciendo en {0}s", duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

    }
}
