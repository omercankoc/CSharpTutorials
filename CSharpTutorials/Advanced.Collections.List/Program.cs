using System;
using System.Collections.Generic;

namespace Advanced.Collections.List
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> myArrayList = new List<int>();

            var counter = 0;
            Console.WriteLine("Girilecek değer sayısını giriniz:");
            for (int iterator = 0; iterator < counter; iterator++)
            {
                myArrayList.Add(Int32.Parse(Console.ReadLine()));
            }
        }
    }
}
