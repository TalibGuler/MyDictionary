using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plakalar = new Dictionary<string, int>();

            plakalar.Add("Kocaeli", 41);
            plakalar.Add("Ardahan", 75);
            plakalar.Add("Edirne", 22);
            plakalar.Add("Amasya", 05);
            plakalar.Add("Sakarya", 54);

            Console.WriteLine("----------------Dictionary----------------");
            Console.WriteLine("Dictionary kullanımı sonucu plakaların sayısı: "+ plakalar.Count);

            Console.WriteLine();
            
            MyDictionary<string, int> plakalar2 = new MyDictionary<string, int>();
            plakalar2.Add("Kocaeli", 41);
            plakalar2.Add("Ardahan", 75);
            plakalar2.Add("Edirne", 22);
            plakalar2.Add("Amasya", 05);
            plakalar2.Add("Sakarya", 54);

            Console.WriteLine("---------------MyDictionary---------------");
            Console.WriteLine("MyDictionary kullanımı sonucu plakalar2 nin sayısı: " + plakalar2.Count);
        }
    }

    class MyDictionary<K, V>
    {
        K[] keys;

        public MyDictionary()
        {
            keys = new K[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKey = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            keys[keys.Length - 1] = key;
        }
        public int Count
        {
            get { return keys.Length; }
        }
    }



}
