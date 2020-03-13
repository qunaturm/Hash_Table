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


            Console.ReadLine();
        }
    }
}
