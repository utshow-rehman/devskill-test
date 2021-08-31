using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ItemBox<T> : IStorage<T> where T : class, new()
    {
        List<T>itms=new List<T>();
        public int Count { get; set; }
          
        public void Add(T item)
        {
             itms.Add(item);
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            itms.Remove(item);
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            return itms[index];
            throw new NotImplementedException();
        }
    }
}
