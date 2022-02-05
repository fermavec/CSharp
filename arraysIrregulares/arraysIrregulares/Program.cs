using System;

namespace arraysIrregulares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            irregular[0] = new int[] { 2, 4, 6, 8, 10 };
            irregular[1] = new int[] { 2, 4, 10 };
            irregular[2] = new int[] { 12, 28 };

            int[][] irregular2 = new int[][]
            {
                new int[] {2, 4, 6, 8, 10 },
                new int[] { 2, 4, 10 },
                new int[] { 12, 28 }
            };

            Console.WriteLine("El valor del es {0}", irregular[1][2]);
            Console.WriteLine("El valor del es {0}", irregular2[0][2]);

            //Reto
            for(int i = 0; i < irregular2.Length; i++)
            {
                Console.WriteLine("Los valores del arreglo {0} son", i);
                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.WriteLine(irregular[i][j]);
                };
                
            }

            //Reto2
            string[][] familias = new string[][]
            {
                new string[]{"Jon", "Arya", "Rob", "Brian"},
                new string[]{"Cersei", "Tyrion"},
                new string[]{"Daenerys", "Aegon", "Vyseris"}
            };

            Console.WriteLine("Hola {0}, mi nombre es {1}", familias[0][2], familias[2][1]);
            Console.WriteLine("Hola {0}, mi nombre es {1}", familias[1][1], familias[2][0]);
            Console.WriteLine("Hola {0}, mi nombre es {1}", familias[1][0], familias[0][1]);
        }
    }
}
