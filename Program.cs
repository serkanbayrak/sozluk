using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> MyDictionary = new MyDictionary<string, string>();

            MyDictionary.Add("key", "anahtar");
            MyDictionary.Add("run","kosmak, çalıştırmak");
            MyDictionary.Add("process", "işlem");

        }
    }
}
