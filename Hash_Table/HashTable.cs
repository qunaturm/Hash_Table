using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class HashTable<T>
    {
        private T[] items;
        public HashTable(int size)
        {
            if (size > 0)
            {
                items = new T[size];
            }
        }

        public void Add(T item)
        {
            int key = GetHash(item);
            items[key] = item;
        }

        public bool Search(T item)
        {
            int key = GetHash(item);
            bool res = items[key].Equals(item);
            if (res == true) Console.WriteLine("this item is included to your hashtable");
            else Console.WriteLine("this item wasn't find");
            return res;

        }

        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length; //bad hash function
        }
    }
}
