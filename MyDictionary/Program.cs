using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(5, "Ahmet");
            dictionary.Add(6, "Can");
            dictionary.Add(7, "Mert");
            dictionary.Add(2, "Cansu");
            dictionary.Add(-1, "Atakan");




            foreach (var item in dictionary.GetValues())
            {

                Console.WriteLine(item);
            }
        }
    }
}
