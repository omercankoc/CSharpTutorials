using System;

namespace Basic.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string nameSurname;

            Console.Write("Adınızı Giriniz:");
            name = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Soyadınızı Giriniz: ");
            surname = Console.ReadLine();

            nameSurname = name + " " + surname;

            foreach (var item in nameSurname)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("{0} {1}", name, surname);
            Console.WriteLine("Adınız : " + name);
            Console.WriteLine("Soyadınız : " + surname);
            Console.WriteLine("Merhaba : " + nameSurname);

            // String içerisindeki karakter sayısını döndürür
            var result1 = nameSurname.Length;
            Console.Write("Karakter Sayısı: {0}", result1);
            Console.WriteLine();

            // Bir String tipindeki değişkeni kopyalamak
            var result2 = nameSurname.Clone();
            Console.Write("Kopyalanmış veri: {0}", result2);
            Console.WriteLine();

            // String tipindeki verinin son karakterinin kontrolü
            bool result3 = nameSurname.EndsWith("ç");
            Console.Write("İsminizin ç harfi ile bitme durumu: {0}", result3);
            Console.WriteLine();

            // String tipindeki verinin ilk karakterinin kontrolü
            bool result4 = nameSurname.StartsWith("ö");
            Console.Write("İsminizin ö harfi ile başlama durumu: {0}", result4);
            Console.WriteLine();

            // String tipineki verinin içinde karakter arama
            var result5 = nameSurname.IndexOf("can");
            Console.Write("Karakter dizisi içinde aranan: {0}", result5);
            Console.WriteLine();

            // Stirng tipindeki veriye ekleme yapmak
            var result6 = nameSurname.IndexOf("Merhaba");
            Console.Write("Ekleme yapıldı: {0}", result6);
            Console.WriteLine();

            //String tipindeki verinin belirlenen bir kısmını elde etme
            var result7 = nameSurname.Substring(3);
            var result8 = nameSurname.Substring(3, 5);
            Console.Write("Parçalanmış veri: {0},{1}", result7, result8);
            Console.WriteLine();

            // String verinin karakterlerini büyük harfe çevirir
            var result9 = nameSurname.ToLower();
            // String verinin karakterlerini küçük harfe çevirir
            var result10 = nameSurname.ToUpper();
            Console.Write("Küçük Harf: {0} Büyük Harf: {1}", result9, result10);
            Console.WriteLine();

            // String verinin içerisinde belirlenen karakterleri yine belirlenenbir karakter ile değiştirme
            var result11 = nameSurname.Replace(" ", "-");
            Console.Write("Değiştirilmiş Karakterler: {0}", result11);
            Console.WriteLine();

            // String tipindeki verinin belirlenen kısmını siler
            var result12 = nameSurname.Remove(4);
            var result13 = nameSurname.Remove(4, 6);
            Console.Write("Parçalı silinmiş veri: {0},{1}", result12, result13);
        }
    }
}
