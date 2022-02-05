using System;

namespace RetoIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registre su nombre de usuario: ");
            string userId = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            string userpass = Console.ReadLine();
            Console.WriteLine("Felicidades, estás registrado");
            
            Console.WriteLine("¿Quieres acceder al sistema? (Y/Yes, N/No)");
            string answer = Console.ReadLine();
            if (answer.Equals("Y"))
            {
                Console.WriteLine("Ingresa tu usuario: ");
                string userInput = Console.ReadLine();
                
                if (userId.Equals(userInput))
                {
                    Console.WriteLine("Ingresa tu contraseña");
                    string passInput = Console.ReadLine();
                    if (userpass.Equals(passInput))
                    {
                        Console.WriteLine("Bienvenido {0}", userId);
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario incorrecto");
                }

            }
            else if(answer.Equals("N"))
            {
                Console.WriteLine("Muchas Gracias por registrarte. Estaremos en contacto");
            }
            else
            {
                Console.WriteLine("Ingresa una opción valida (En mayusculas)");
            }


        }
    }
}
