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
            var ht = new HashTable<int, int>(10);
            int a = 123;
            ht.Add(a.GetHashCode(), a);
            a = 333;
            ht.Add(a.GetHashCode(), a);
            int b = 124;
            int c = 333;
            ht.Search(b.GetHashCode(), b);
            ht.Search(c.GetHashCode(), c);

            var hts = new HashTable<int, string>(10);
            hts.Add(5, "hello");
            hts.Add(13, "i want to die");
            hts.Add(99, "jopa");

            hts.Search("ttt".GetHashCode(), "ttt");
            hts.Search("i want to die".GetHashCode(), "i want to die");

            Console.ReadLine();
        }
    }
}
