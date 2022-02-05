using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class PublicacionImagen:Publicacion
    {
        //Propiedades de la clase PublicacionImagen
        protected string UrlImagen { get; set; }


        //Constructor por defecto
        public PublicacionImagen() { }

        //Constructor Parametrizado
        public PublicacionImagen(string titulo, string autor, string urlImagen, bool isPublic)
        {
            this.ID = CrearId();
            this.Titulo = titulo;
            this.Autor = autor;
            this.UrlImagen = urlImagen;
            this.IsPublic = isPublic;
        }

        //Metodo para impresion en consola
        public override string ToString()
        {
            return String.Format("{0} - {1} \ncreado por {2}. \n{3}\n", this.ID, this.Titulo, this.Autor, this.UrlImagen);
        }

    }
}
