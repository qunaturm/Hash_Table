using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class GoodHashTable<T>
    {
        private Item<T>[] items;
        public GoodHashTable(int size)
        {
            if (size > 0)
            {
                items = new Item<T>[size];

                for (int i = 0; i < size; ++i)
                {
                    items[i] = new Item<T>(i);
                }
            }
        }
        public void AddItem(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item); 
        }

        public void Dell(T item)
        {
            var key = GetHash(item);
            for (int i = 0; i < items.Length; ++i)
            {
                if (items[key].Nodes.Contains(item))
                {
                    items[key].Nodes = null;

                }
            }
        }

        public void Search(T item)
        {
            var key = GetHash(item);
            bool res = items[key].Nodes.Contains(item);
            if (res == true) Console.WriteLine("this item is included to your hashtable");
            else Console.WriteLine("this item wasn't find");
        }

        public int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }

        public IEnumerator GetEnumerator(int max)
        {
            if (max < items.Length)
            {
                for (int i = 0; i < max; ++i)
                {
                    if (i == max) yield break;
                    else yield return items[i];
                }
            }
        }
    }
}
