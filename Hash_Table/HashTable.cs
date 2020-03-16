using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;
        public HashTable(int size)
        {
            if (size > 0)
            {
                items = new List<TValue>[size];
            }
        }

        public void AddItem(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
        }

        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            bool res = items[k].Contains(item);
            if (res == true) Console.WriteLine("this item is included to your hashtable");
            else Console.WriteLine("this item wasn't find");
            return res;

        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }

}
