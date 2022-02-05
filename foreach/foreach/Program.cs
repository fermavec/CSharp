using System;

namespace forEach
{
    class Program
{
    static void Main(string[] args)
    {
        int [] nums = new int [10];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i + 1;
        }

        for(int j = 0; j < nums.Length; j++)
        {
            Console.WriteLine("El valor del indice {0} es {1}", j, nums[j]);
        }

        //Todo lo anterior se pordría hacer con un bucle ForEach
        foreach(int k in nums)
            {
                Console.WriteLine(k);
            }

            //Desafio
            string[] amigos = { "Aldo", "Alejandro", "Carlos", "Alain", "Sofia" };

        foreach(string amigo in amigos)
            {
                Console.WriteLine("Hola {0}", amigo);
            }
    }
}
}
