using System;
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
            }
        }
        public void AddItem(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item); 
        }

        public int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
