using System;

namespace Basic.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // outValue değişkeni değerini OutKeyword metodu çalıştırıldıktan sonra alacak.
            int outValue;
            int lenght;
            Console.WriteLine("Veri seti uzunluğunu giriniz: ");
            lenght = Int32.Parse(Console.ReadLine());
            double[] dataSet = new double[lenght];

            for (int iterator = 0; iterator < lenght; iterator++)
            {
                Console.WriteLine("{0}. değeri giriniz: ", iterator + 1);
                dataSet[iterator] = double.Parse(Console.ReadLine());
            }

            Console.Write("Aritmetic Mean: ");
            Console.WriteLine(AritmeticMean(dataSet));

            Console.Write("Geometric Mean: ");
            Console.WriteLine(GeometricMean(dataSet));

            Console.Write("Harmonic Mean: ");
            Console.WriteLine(HarmonicMean(dataSet));

            Console.Write("Method Overloading: ");
            Console.WriteLine(MethodOverloading(lenght));

            Console.Write("Method Overloading: ");
            Console.WriteLine(MethodOverloading(lenght, lenght));

            Console.Write("Area of Circle - r = {0}: ", lenght);
            Console.WriteLine(DefaultParameters(lenght));

            Console.Write("Ref Keyword: ");
            Console.WriteLine(RefKeyword(ref lenght));

            Console.Write("Out Keyword: ");
            Console.WriteLine(OutKeyword(out outValue));
        }

        public static void Hello()
        {
            Console.WriteLine("Hello C,C++,C#");
        }

        // params: cok fazla parametreye sahip metotlardan aşağıdaki şekilde kullanılabilir.
        public static double AritmeticMean(params double[] dataset)
        {
            double summary = 0;
            for (int iterator = 0; iterator < dataset.Length; iterator++)
            {
                summary += dataset[iterator];
            }
            double mean = summary / dataset.Length;
            return mean;
        }

        public static double GeometricMean(params double[] dataset)
        {
            double multiplication = 1.0D;
            for (int iterator = 0; iterator < dataset.Length; iterator++)
            {
                multiplication *= dataset[iterator];
            }
            double mean = Math.Pow(multiplication, 1 / dataset.Length);
            return mean;
        }

        public static double HarmonicMean(params double[] dataset)
        {
            double denominator = 0.0D;
            for (int iterator = 0; iterator < dataset.Length; iterator++)
            {
                denominator += (1 / dataset[iterator]);
            }
            double mean = dataset.Length / denominator;
            return mean;
        }

        // Method Overloading fonksiyon isimlerinin aynı olup parametrelerinin farklı olması durumudur.
        public static int MethodOverloading(int value)
        {
            return value;
        }

        // Method Overloading fonksiyon isimlerinin aynı olup parametrelerinin farklı olması durumudur.
        public static int MethodOverloading(int number, int exponent)
        {
            double result = Math.Pow(number, exponent);
            return (int)result;
        }

        // Default Parametre, method içerisinde verilen parametrenin değişken değerinin tanımlandığı yerde belirtilmesi durumu.
        public static double DefaultParameters(double number, double pi = 3.14)
        {
            double areaOfCircle = Math.Pow(number, 2) * pi;
            return areaOfCircle;
        }

        // ref keyword'ü belirlenen değişkenin bellekdeki değerini değiştirir.
        public static int RefKeyword(ref int value)
        {
            // kullanıcıdan gelen length değeri bu metodun çalıştırılmasından sonra 9 değerini alacak.
            return value = 9;
        }

        // out keyword'ünün ref keyword'ünden farkı, out ile belirtilen değişkenin başlangıçta değer atamadan 
        // (set edilmeden) kullanılmasını mümkün kılmasıdır.
        public static int OutKeyword(out int value)
        {
            // outValue değişkeni bu metod çalıştırıldıktan sonra 1 değerini alır.
            return value = 1;
        }
    }
}
