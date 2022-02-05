using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES NUMERICAS
            /*Para trabajar con numeros podemos usar Int, Long, Sbyte y Short
             La diferencia radica en la cantidad de informacion que pueden recibir
            Con decimales aplica lo mismo con Float, Double y Decimal*/
            //Variables de Enteros
            int number1 = 13;
            int number2 = 27;
            int sum = number1 + number2;

            //Variables Decimales
            double pi = 3.1416;
            double e = 2.718;
            double sumd = pi + e;

            //Variables flotantes
            float pif = 3.14f;
            float ef = 2.71f;
            float sumf = pif + ef;

            //CADENAS DE TEXTO
            string nombre = "Fernando";
            string apellido = "Mavec";
            string mensaje = "Mi nombre es";

            mensaje = mensaje.ToLower();
            nombre = nombre.ToUpper();

            //Explicit Casting
            double myDouble = 180.2358;
            int myInteger;

            myInteger = (int)myDouble;

            //Implicit Convertions are not castings
            int implicitNum = 123456;
            long numLongImplicit = implicitNum;

            //Conversion de tipo
            //Aplica con todo tipo de dato a conversion (guardando las distancias)
            double doubleToString = 2.123;
            string doubleStr = doubleToString.ToString();

            //Parsing
            string strParse = "15";
            string strParse2 = "10";
            string notAParse = strParse + strParse2;//Se concatenan
            int strParsed = Int32.Parse(strParse);
            int strParsed2 = Int32.Parse(strParse2);
            int strParsedSum = strParsed + strParsed2;//Se suman

            //Métodos de los Strings
            /*Console.WriteLine("Escribe tu nombre: "); 
            String usuario = Console.ReadLine();
            String usuarioMay = usuario.ToUpper();
            String usuarioMin = usuario.ToLower();
            String usuarioTrimmed = usuario.Trim();
            String usuarioSubs = usuario.Substring(3);

            Console.WriteLine("Esta es otra forma más sencilla {0}", usuario.ToLower());
            */

            /*//Reto dos
            Console.WriteLine("Ingrese una frase o texto: ");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a buscar: ");
            string wordToFind = Console.ReadLine();
            Console.WriteLine("Tu letra esta en la posición {0}", textoUsuario.IndexOf(wordToFind));
            Console.Read();
            */

            /*//Reto 3
            Console.WriteLine("Escribe tu nombre-: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            string lastNameInput = Console.ReadLine();
            string fullName = nameInput + " " + lastNameInput;
            Console.WriteLine("Tu nombre completo es: {0}", fullName);
            Console.Read();
            */

            /*//Reto 4
            byte bait = 255;
            Console.WriteLine(bait);
            sbyte negative = -85;
            Console.WriteLine(negative);
            int entero = -2147483648;
            Console.WriteLine(entero);
            uint desdeCero = 4294967295;
            Console.WriteLine(desdeCero);
            short corto = -32768;
            Console.WriteLine(corto);
            */
        }
    }
}
