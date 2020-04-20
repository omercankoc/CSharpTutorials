using System;

namespace Basic.Structures
{
    class Program
    {
        /// <summary>
        /// Struct property'lerinin tanımlaması.
        /// </summary>
        struct User
        {
            public string userID;
            public string username;
            public string email;
            public string password;
            public string phone;
            public string firstname;
            public string lastname;
        };

        static void Main(string[] args)
        {
            // Struct oluşturma.
            User First;
            User Second;

            First.userID = "001";
            First.username = "keinSpieler";
            First.email = "keinSpieler@mail.com";
            First.password = "0112358";
            First.phone = "498529637410";
            First.firstname = "Albert";
            First.lastname = "Klein";

            Console.WriteLine("Hello" + " " + First.firstname + " " + First.lastname);
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
