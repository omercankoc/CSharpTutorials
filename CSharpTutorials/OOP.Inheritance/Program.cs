using System;

namespace OOP.Inheritance
{
    // Inheritance'de base olan ata class kendi başına bir anlam ifade eder.
    // Bir alt sınıf en fazla bir üst sınıfı kalıtım yolu ile devralabilir.

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Ömer";
            customer.Surname = "Koç";
            customer.City = "İstanbul";

            Personnel personnel = new Personnel();
            personnel.ID = 2;
            personnel.Name = "Ömer";
            personnel.Surname = "Koç";
            personnel.Department = "Computer Science";

            Console.WriteLine(customer.ID + " " + customer.Name + " " + customer.Surname + " " + customer.City);
            Console.WriteLine(personnel.ID + " " + personnel.Name + " " + personnel.Surname + " " + personnel.Department);
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Personnel : Person
    {
        public string Department { get; set; }
    }
}
