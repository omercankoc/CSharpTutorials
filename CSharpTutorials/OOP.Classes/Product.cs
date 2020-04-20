using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    class Product
    {
        // Auto Properties
        public int ID { get; set; }           // Properties
        public int CategoryID { get; set; }   // Properties
        public string Brand { get; set; }     // Properties
        public string Type { get; set; }      // Properties
        public int Stock { get; set; }        // Properties
        public decimal Price { get; set; }    // Properties

        // Manuel Properties
        private string _statement;  // Field
        public string Statement     // Properties
        {
            get
            {
                return Brand + " " + Type + " " + _statement;
            }

            set
            {
                _statement = value;
            }
        }
    }
}
