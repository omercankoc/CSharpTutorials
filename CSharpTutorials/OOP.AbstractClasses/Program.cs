using System;

namespace OOP.AbstractClasses
{
    // Interface ve Virtual Metotların hybrid halidir.
    // Interface'ler gibi Abstract Class'lar da new'lenemez.

    class Program
    {
        static void Main(string[] args)
        {
            Database database1 = new MSSQLServer();
            database1.Add();
            database1.Delete();

            Database database2 = new OracleDB();
            database2.Add();
            database2.Delete();
        }
    }

    abstract class Database
    {
        // Tamamlanmış Metot - Kalıtım ile devranılan her sınıfda aynı kullanılır.
        public void Add()
        {
            Console.WriteLine("Ortak olan ekleme metodu içeriği...");
        }

        // Tamamlanmamış Metot - Kalıtım ile devranılan her sınıfda özelleştirilebilir.
        public abstract void Delete();
    }

    class MSSQLServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Özelleştirilmiş MSSQL Server Delete Metodu İçeriği!");
        }
    }

    class OracleDB : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Özelleştirilmiş OracleDB Delete Metodu İçeriği!");
        }
    }
}
