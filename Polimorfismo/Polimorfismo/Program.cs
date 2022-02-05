using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancias Independientes
            Auto auto1 = new Auto(750, "Rojo");
            Audi audi1 = new Audi(1500, "Negro", "A6");
            BMW bmw1 = new BMW(1250, "Blanco", "Z4");

            //Lista de Autos
            var autos = new List<Auto>
            {
                new Audi(200, "Rojo", "A1"),
                new BMW(300, "Gris", "i3"),
            };

            //Llamadas a metodos
            auto1.MostrarDetalles();
            auto1.Reparar();
            audi1.MostarDetalles();
            audi1.Reparar();
            bmw1.MostarDetalles();
            bmw1.Reparar();

            //Llamando metodo de cada auto de la lista autos
            foreach(var auto in autos)
            {
                auto.MostrarDetalles();
                auto.Reparar();
            }

            //Instanciando con Polimorfismo
            Auto bmwPolimorfo = new BMW(250, "Gris", "z3");
            Auto audiPolimorfo = new Audi(100, "Azul", "A3");

            bmwPolimorfo.MostrarDetalles();
            audiPolimorfo.MostrarDetalles();

            //Casting con Autos
            BMW bmwToCast = new BMW(200, "Verde", "Z4");
            bmwToCast.MostrarDetalles();

            Auto bmwCasted = (Auto)bmwToCast;
            bmwCasted.MostrarDetalles();

            //Sellado
            //MZ3 miMz3 = new MZ3();
            //miMz3.Reparar();

            //Relacionado pero sin Herencia
            audi1.SetearAutoInfo(123456, "Fer Mavec");
            bmw1.SetearAutoInfo(123568, "Fer Mavec");

            audi1.MostrarDetalles();
            audi1.LeerAutoInfo();
            bmw1.MostrarDetalles();
            bmw1.LeerAutoInfo();



        }
    }
}
