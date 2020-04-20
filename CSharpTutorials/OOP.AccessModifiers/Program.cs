using System;

namespace OOP.AccessModifiers
{
    // private: Sadece tanımlandığı blok içerisinden erişilebilir.
    // protected: Tanımlandığı sınıf içerisinden ve kalıtım yolu ile devir alınan veya devir verilen sınıflarda kullanılabilir. 
    // internal: Proje içerisinde istenilen noktadan çağrılabilir.
    // public: Her blokdan ve projeden erişilebilir.

    // class'ın default tanımlayıcısı internal'dır.
    // değişkenin default tanımlayıcısı private'dır.
    // metotların default tanımlayıcıs public'dir.

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.EMail = "deneme@mail.com ";
            person.Username = "deneme";

            Console.WriteLine("Public ve Internal verilere erişebildi: Email:{0} Username:{1}", person.EMail, person.Username);
        }
    }

    class Person
    {
        private int ID { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }
        internal string EMail { get; set; }
    }
}
