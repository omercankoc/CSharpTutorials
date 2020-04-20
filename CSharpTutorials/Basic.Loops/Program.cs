using System;

namespace Basic.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue;
            string nameSurname;

            Console.WriteLine("Adınızı giriniz:");
            nameSurname = Console.ReadLine();

            Console.WriteLine("Rasgele bir sayı giriniz: ");
            userValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ForLoop(userValue));
            Console.WriteLine(WhileLoop(userValue));
            Console.WriteLine(DoWhileLoop(userValue));

            ForEachLoop(nameSurname);
        }

        public static double ForLoop(int length)
        {
            double exponent = 0;
            for (int iterator = 0; iterator <= length; iterator++)
            {
                exponent += Math.Pow(iterator, 2);
            }
            Console.WriteLine("1^2 + ... + {0}^2 = {1}", length, exponent);
            return exponent;
        }

        public static int WhileLoop(int length)
        {
            int summary = 0;
            int iterator = 0;
            while (iterator <= length)
            {
                summary += iterator;
                iterator++;
            }
            Console.WriteLine("1 + ... + {0} = {1}", length, summary);
            return summary;
        }

        public static int DoWhileLoop(int length)
        {
            int iterator = 1;
            int multiplication = 1;
            do
            {
                multiplication *= iterator;
                iterator++;
            } while (iterator <= length);
            Console.WriteLine("1 * ... * {0} = {1}", length, multiplication);
            return multiplication;
        }

        public static void ForEachLoop(string value)
        {
            Console.WriteLine("İsminizin harfleri:");
            foreach (var character in value)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine();
        }
    }
}
