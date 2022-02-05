using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Audi:Auto
    {
        //Variables
        private string marca = "Audi";

        //Propiedades
        public string Modelo { get; set; }

        //Constructor
        public Audi()
        {
            this.HP = 0;
            this.Color = "NA";
            this.Modelo = "NA";
        }
        public Audi(int hp, string color, string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Metodo
        public void MostarDetalles()
        {
            Console.WriteLine("Marca: {0}\nModelo: {1}\nCaballos de Fuerza: {2}\nColor: {3}", marca, Modelo, HP, Color);
        }
        public override void Reparar()
        {
            Console.WriteLine("Auto Audi {0} reparado\n", Modelo);
        }
    }
}
