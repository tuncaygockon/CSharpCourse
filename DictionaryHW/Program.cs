using System;

namespace DictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> persons = new MyDictionary<int, string>();
            persons.Add(001, "Tuncay");
            persons.Add(002, "Ozan");
            persons.Add(003, "Caner");
            persons.Add(004, "Ali");
            persons.Add(005, "Osman");

            foreach (var id in persons.Keys)
            {
                Console.WriteLine(id);
            }

            foreach (var names in persons.Values)
            {
                Console.WriteLine(names);
            }
        }


    }
}
