using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Publicacion
    {
        private static int publicacionId;

        //Propiedades
        protected int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool IsPublic { get; set; }

        //Creando Constructor por defecto
        public Publicacion()
        {
            ID = CrearId();
            Titulo = "Mi primer publicacion";
            IsPublic = true;
            Autor = "Admin";
        }

        //Constructor parametrizado
        public Publicacion(string titulo, bool isPublic, string autor)
        {
            this.ID = CrearId();
            this.Titulo = titulo;
            this.IsPublic = isPublic;
            this.Autor = autor;

        }

        //Metodo que crea el ID
        protected int CrearId()
        {
            ++publicacionId;
            return publicacionId;
        }

        //Metodo para editar una publicacion
        public void Editar(string titulo, bool isPublic)
        {
            this.Titulo = titulo;
            this.IsPublic = isPublic;
        }

        //Metodo para convertir a string la publicacion
        public override string ToString()
        {
            return String.Format("{0} - {1} \ncreado por {2}.\n", this.ID, this.Titulo, this.Autor);
        }
    }
}
