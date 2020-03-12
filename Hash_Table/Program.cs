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
            BadHashTable<int> ht = new BadHashTable<int>(5);
            ht.Add(1);
            ht.Add(9492);
            ht.Add(777);

            ht.Search(61); 
            ht.Search(184);
            ht.Search(777);

            Console.ReadLine();
        }
    }
}
