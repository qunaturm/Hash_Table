using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new GoodHashTable<Person>(10);
            var p1 = new Person { Name = "Ivan", Age = 25, Country = "Russia" };
            var p2 = new Person { Name = "Jon", Age = 32, Country = "England" };
            var p3 = new Person { Name = "Bob", Age = 41, Country = "China" };


            ht.AddItem(p1);
            ht.AddItem(p2);

            ht.Search(p1);
            ht.Search(p3);

            Console.WriteLine(Environment.NewLine);

            Console.ReadLine();
        }
    }
}
