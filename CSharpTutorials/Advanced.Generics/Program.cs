using System;
using System.Collections.Generic;

namespace Advanced.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methodlar için kullanılan Generic
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("İstanbul", "İzmir", "İstanbul");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // Sınıflar için kullanılna Generic.
            List<Customer> result2 = utilities.BuildList<Customer>
                (new Customer { ID = 1, Name = "omer" }, new Customer { ID = 2, Surname = "can" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    interface IEntity
    {
        public int ID { get; set; }
    }

    class Product : IEntity
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }

    class Customer : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }

    interface IRepository<T> where T : class, IEntity, new()
    {
        // Generic: Sıkça yapılan operasyonların nesne bazlı olarak değiştirilmesini sağlayan yapıdır.
        // where T:class : T parametresi yerine sadece referans tip olan bir tip gelebilir. | where T:struct : değer tipli değerler gelebilir.
        // IEntity : T IEntity'den implament edilmeli.
        // new() : new'lenebilen bir tip gelebilir.

        List<T> GetAll();
        T Get(int ID);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IProductDAL : IRepository<Product>
    {
        // ProductDAL'a özel operasyonlar
    }

    interface ICustomerDAL : IRepository<Customer>
    {
        // CustomerDAL'a özel operasyonlar
    }

    class ProductDAL : IProductDAL
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDAL : ICustomerDAL
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
