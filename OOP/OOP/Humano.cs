using System;

namespace OOP
{
    class Humano
    {
        //Creando un miembro de tipo Variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;
        //Al crear un constructor, puedo declarar las variables
        //como privadas

        //Creando un miembro constructor
        //Constructor No Parametrizado

        
        //Constructor Parametrizado o Por Defecto
        public Humano()
        {
            Console.WriteLine("Soy un constructor por defecto, sin parametros");
        }
        public Humano(/*string miNombre*/ string primerNombre, string apellido, string colorOjos, int edad)
        {
            //dos formas diferentes de asignar en un constructor
            /*primerNombre = miNombre*/
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        //Creando un miembro del tipo Método
        public void presentarme()
        {
            if (primerNombre == null)
            {
                Console.WriteLine("Hola, soy una inteligencia artificial que aun no ha sido nombrada");
            }
            else
            {
                Console.WriteLine("Hola, mi nombre es {0} {1}; tengo {2} años y soy de ojos {3}", primerNombre, apellido, edad, colorOjos);
            }
        }
    }
}
