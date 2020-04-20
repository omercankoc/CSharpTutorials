using System;

namespace Basic.Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int midterm;
            int final;
            double mod;

            Console.WriteLine("Ara sınav puanınızı giriniz: ");
            midterm = Int32.Parse(Console.ReadLine());

            // Ternary IF
            Console.WriteLine(midterm >= 0 && midterm <= 100 ? "Başarılı Giriş!" : "Başarısız Giriş!");

            Console.WriteLine("Final puanınızı giriniz: ");
            final = Int32.Parse(Console.ReadLine());

            // Ternary IF
            Console.WriteLine(final >= 0 && final <= 100 ? "Başarılı Giriş!" : "Başarısız Giriş!");

            double score = ((double)midterm * 0.50) + ((double)final * 0.50);

            // If-Else If-Else
            if (score >= 50 && score <= 100)
            {
                if (score >= 50 && score <= 60)
                {
                    Console.WriteLine("E:{0}", score);
                }

                else if (score > 60 && score <= 70)
                {
                    Console.WriteLine("D:{0}", score);
                }

                else if (score > 70 && score <= 80)
                {
                    Console.WriteLine("C:{0}", score);
                }

                else if (score > 80 && score <= 90)
                {
                    Console.WriteLine("B:{0}", score);
                }

                else if (score > 90 && score <= 100)
                {
                    Console.WriteLine("A:{0}", score);
                }
            }
            else
            {
                Console.WriteLine("F:{0}", score);
            }

            // Switch-Case
            mod = (int)score % 2;

            switch (mod)
            {
                case 0:
                    Console.WriteLine("{0} çift sayı!", (int)score);
                    break;
                case 1:
                    Console.WriteLine("{0} tek sayı!", (int)score);
                    break;
                default:
                    Console.WriteLine("Hata!");
                    break;
            }
        }
    }    
}
