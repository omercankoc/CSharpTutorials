using System;

namespace OOP.VirtualMethods
{
    // Virtual, metodun içerisinde genel operasyonu belirtilir. Override ile o metodun özelleştirilmesi mümkün olur.

    class Program
    {
        static void Main(string[] args)
        {
            MSSQLServer mssqlserver = new MSSQLServer();
            mssqlserver.Add();
            mssqlserver.Delete();
            mssqlserver.Update();

            MYSQLServer myssqlserver = new MYSQLServer();
            myssqlserver.Add();
            myssqlserver.Delete();
            myssqlserver.Update();

            Console.ReadLine();
        }
    }

    class Database
    {
        // Kalıtım ile devir alınacak sınıf metodları: Add(), Delete(), Update()
        public virtual void Add()
        {
            Console.WriteLine("Public Adding Method...");
        }

        public virtual void Update()
        {
            Console.WriteLine("Public Updating Method...");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Public Deleting Method...");
        }
    }

    class MSSQLServer : Database
    {
        // Kalıtım ile devir alınmıs Add() metodu burada özelleştiriliyor...
        public override void Add()
        {
            // base.Add();
            Console.WriteLine("Added by MS SQL Server!");
        }

        // Kalıtım ile devir alınmıs Update() metodu burada özelleştiriliyor...
        public override void Update()
        {
            // base.Update();
            Console.WriteLine("Updated by MS SQL Server!");
        }

        // Kalıtım ile devir alınmıs Delete() metodu burada özelleştiriliyor...
        public override void Delete()
        {
            // base.Delete();
            Console.WriteLine("Deleted by MS SQL Server!");
        }
    }

    class MYSQLServer : Database
    {
        // Kalıtım ile devir alınmıs Add() metodu burada özelleştiriliyor...
        public override void Add()
        {
            // base.Add();
            Console.WriteLine("Added by  MySQL Server!");
        }

        // Kalıtım ile devir alınmıs Update() metodu burada özelleştiriliyor...
        public override void Update()
        {
            // base.Update();
            Console.WriteLine("Updated by MySQL Server!");
        }

        // Kalıtım ile devir alınmıs Delete() metodu burada özelleştiriliyor...
        public override void Delete()
        {
            // base.Delete();
            Console.WriteLine("Deleted by MySQL Server!");
        }
    }
}
