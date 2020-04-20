using System;

namespace Basic.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random sayı nesnesi oluşturur ----------------------------
            Random random = new Random();
            int randomValue = random.Next(0, 100);
            int userValue;

            // long:64bit -----------------------------------------------
            long lowerLimitLong = -9223372036854775808;
            long upperLimitLong = 9223372036854775807;

            // int:32bit ------------------------------------------------
            int lowerLimitInt = -2147483648;
            int upperLimitInt = 2147483647;

            // short:16bit ----------------------------------------------
            short lowerLimitShort = -32768;
            short upperLimitShort = 32767;

            // byte:8bit ------------------------------------------------
            byte lowerLimitByte = 0;
            byte upperLimitByte = 255;

            // decimal:128bit -------------------------------------------
            decimal piNumber = 3.14159265359M;

            // double:64bit ---------------------------------------------
            double goldenRatio = 1.6180339D;

            // float:32bit ----------------------------------------------
            float eulerConstant = 2.71F;

            // char:16bit -----------------------------------------------
            char character = 'C';

            // "var" bir veri tipi değildir. Değişken tutmak için kullanılır. 
            var valueVar = 3;

            Console.Write("0-100 arası bir değer giriniz:");
            userValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rasgele Değer: {0}", randomValue);
            Console.WriteLine("Girdiğiniz Değer: {0}", userValue);

            if (userValue > 0 && userValue < 100)
            {
                if (userValue > randomValue)
                {
                    Console.WriteLine("Kazandın!");
                }
                else
                {
                    Console.WriteLine("Kaybettiniz!");
                }
            }
            else
            {
                Console.WriteLine("0-100 arasında bir değer giriniz!");
            }

            Console.WriteLine("Long Aralığı: {0} - {1}", lowerLimitLong, upperLimitLong);
            Console.WriteLine("Int Aralığı: {0} - {1}", lowerLimitInt, upperLimitInt);
            Console.WriteLine("Short Aralığı: {0} - {1}", lowerLimitShort, upperLimitShort);
            Console.WriteLine("Byte Aralığı: {0} - {1}", lowerLimitByte, upperLimitByte);

            Console.WriteLine("{0}'nin ASCII Değeri : {1}", character, (int)character);

            Console.WriteLine("Pi Sayısı:{0}", piNumber);
            Console.WriteLine("Altın Oran:{0}", goldenRatio);
            Console.WriteLine("Euler Katsayısı:{0}", eulerConstant);

            // Değeri döndürür
            Console.WriteLine(Days.Friday);
            // Değerin bulundğu index değerinin döndürür
            Console.WriteLine((int)Days.Friday);

            Console.WriteLine("Dünya Savaşı {0}", valueVar);

            // Kullanıcı bir tuşa basana kadar konsol erkanını açık tutar.
            Console.ReadLine();

            int x = 42;
            int y = 103;
            Console.WriteLine(x == y);
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
