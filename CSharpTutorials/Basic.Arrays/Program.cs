using System;

namespace Basic.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse();
            Matrix();
        }

        public static void Reverse()
        {
            Console.WriteLine("Gireceğiniz dizinin eleman sayısını giriniz: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] straightList = new int[length];
            int[] reverseList = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}. değeri giriniz:", i + 1);
                straightList[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Dizi:", straightList);

            for (int i = 0; i < length; i++)
            {
                Console.Write(straightList[i] + " ");
            }

            Console.WriteLine("\nGirdiğiniz Dizinin Tersi:");

            for (int i = 0; i < length; i++)
            {
                reverseList[length - 1 - i] = straightList[i];
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(reverseList[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Matrix()
        {
            int row;
            int column;

            Console.WriteLine("Matrisin satır sayısını giriniz: ");
            row = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Matrisin sütün sayısını giriniz: ");
            column = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("{0} satırın {1} elemanını giriniz: ", i + 1, j + 1);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Girdiğiniz Matris: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
