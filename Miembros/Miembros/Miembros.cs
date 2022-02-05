using System;
using System.Collections.Generic;
using System.Text;

namespace Miembros
{
    class Miembros
    {
        //Miembros - Campos Privados
        private string nombre;
        private string profesion;
        private double salario;

        //Miembros - Campos Publicos
        public int edad;

        //Miembros Propiedad 
        public string Nombre 
        {
            get 
            {
                return nombre;    
            }
            set 
            {
                nombre = value;
            } 
        }
        public string Profesion { get; set; }

        //Miembro - Método PRivado
        private void ComparteSalario()
        {
            Console.WriteLine("Tu salario es de {0}", salario);
        }

        //Miembro - Método Público
        public void Autorizado(bool isAuthorized)
        {
            if (isAuthorized)
            {
                ComparteSalario();
            }
            else
            {
                Console.WriteLine("No tienes autorización");
            }
        }

        //Miembro - Constructor
        public Miembros()
        {
            nombre = "Fer";
            edad = 34;
            profesion = "Desarrollador Senior";
            salario = 2000000;
            Console.WriteLine("Objeto Crado");
        }

        //Miembro - Finalizador o Destructor
        ~Miembros()
        {
            //Elimina Objeto y solo se puede declarar 1 sola vez
            Console.WriteLine("Objeto Destruido");
                
        }

    }
}
