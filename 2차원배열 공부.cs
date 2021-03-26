using System;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a =
            {
                new int[3],
                new int[5]
            };
            
            for (int show = 0; show < a.Length; show++)
            {
                for (int show2 = 0; show2 < a[show].Length; show2++)
                {
                    Console.Write((show + 1) + "번줄\t");
                }
                Console.WriteLine();
            }

        }
    }
}
