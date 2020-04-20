using System;

namespace OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Proces
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.Brand = "Brand1";
            product1.Type = "Type1";
            product1.Price = 1000;
            product1.Stock = 100;
            product1.Statement = "Test";

            // Get Proces
            Product product2 = new Product();
            product2.ID = 2;
            product2.CategoryID = 3;
            product2.Brand = "Brand2";
            product2.Type = "Type2";
            product2.Price = 2000;
            product2.Stock = 200;
            product2.Statement = "Test";

            // Set Proces
            Console.WriteLine(product1.ID + "" + product1.CategoryID);
            Console.WriteLine(product2.ID + "" + product2.CategoryID);

            // Class'ların Referansı: Camel Case => ProductManager | Pascal Case => productManager
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            productManager.Delete();
        }
    }
}
