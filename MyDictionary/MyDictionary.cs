using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        (Key,Value)[] items;
        public MyDictionary()
        {
            items = new (Key, Value)[0];
        }
        public void Add(Key key, Value value)
        {
            (Key,Value)[] tempArray = items;
            items = new (Key,Value)[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = (key, value);

        }
        public int Length
        {
            get { return items.Length; }
        }

        public void Listing()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}

