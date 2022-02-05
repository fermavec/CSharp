using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string patron = @"Hola";
            string texto = "Hola, mi numero telefonico es 123456";
            Regex regex = new Regex(patron);

            MatchCollection aciertos = regex.Matches(texto);

            Console.WriteLine("{0} aciertos encontrados:\n {1}", aciertos.Count, texto);

            foreach (Match acierto in aciertos)
            {
                GroupCollection grupo = acierto.Groups;
                Console.WriteLine("{0} fue encontrado en {1}", grupo[0].Value, grupo[0].Index);

                Console.ReadLine();
            }
        }
    }
}
