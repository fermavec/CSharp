using System;
using System.Collections;


namespace ArraylistsAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando un ArrayList Indeterminado
            ArrayList miArrayList = new ArrayList();

            //Declarando un ArrayList Determinado
            ArrayList miArrayList2 = new ArrayList(100);

            //Agregando elementos
            miArrayList.Add(25);
            miArrayList.Add("Fer");
            miArrayList.Add(25.25);
            miArrayList.Add(24);

            //Eliminar Elementos por valor
            miArrayList.Remove(25.25);

            //Eliminar Elementos por indice o posicion
            miArrayList.RemoveAt(0);

            //Contar Elementos
            Console.WriteLine(miArrayList.Count);

            //Reto
            double suma = 0;
            foreach(object elemento in miArrayList)
            {
                if(elemento is int)
                {
                    suma += Convert.ToDouble(elemento);
                }
                else if (elemento is double)
                {
                    suma += (double)elemento;
                }
                else if (elemento is string)
                {
                    Console.WriteLine(elemento);
                }
                else
                {
                    Console.WriteLine("No contemplamos este objeto");
                }
            }
            Console.WriteLine(suma);
        }
    }
}
