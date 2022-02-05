using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Auto
    {
        //Propiedades
        protected int HP { get; set; }
        protected string Color { get; set; }

        //Relacion con Auto info
        protected AutoInfo informacion = new AutoInfo();

        //Constructor
        //Por defecto
        public Auto()
        {
            this.HP = 0;
            this.Color = "NA";
        }
        //Parametrizado
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Metodos
        public void MostrarDetalles()
        {
            Console.WriteLine("Caballos de Fuerza: {0}\nColor: {1}", this.HP, this.Color);
        }
        public virtual void Reparar()
        {
            Console.WriteLine("Auto Reparado\n");
        }

        //MEtodos para setear auto info
        public void SetearAutoInfo(int id, string propietario) 
        {
            informacion.ID = id;
            informacion.Propietario = propietario;
        }

        public void LeerAutoInfo()
        {
            Console.WriteLine("ID: {0}\nPropietario {1}\n", informacion.ID, informacion.Propietario);
        }
    }
}
