using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class BMW:Auto
    {
        //Variables
        private string marca = "BMW";

        //Propiedades
        public string Modelo { get; set; }

        //Constructor
        public BMW()
        {
            this.HP = 0;
            this.Color = "NA";
            this.Modelo = "NA";
        }
        public BMW(int hp, string color, string modelo):base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Metodo
        public new void MostarDetalles()
        {
            Console.WriteLine("Marca: {0}\nModelo: {1}\nCaballos de Fuerza: {2}\nColor: {3}", marca, Modelo, HP, Color);
        }
        public sealed override void Reparar()
        {
            Console.WriteLine("Auto BMW {0} reparado\n", Modelo); 
        }
    }
}
