using System;
using System.Collections.Generic;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opgave 2
            Console.WriteLine("Dictionary of people:");
            Dictionary<string, int> persons = new Dictionary<string, int>();
            persons.Add("Mads", 22);
            persons.Add("Kathrine", 48);
            persons.Add("Lars", 60);
            persons.Add("Morten", 28);

            foreach (KeyValuePair<string, int> pair in persons)
            {
                Console.WriteLine(pair.Key);
            }
            #endregion

            Console.WriteLine();

            #region Opgave 3
            Console.WriteLine("Remove person:");
            if (persons.Remove("Lars"))
            {
                Console.WriteLine("Removed Lars");
            }
            else
            {
                Console.WriteLine("Couldn't find Lars");
            }
            #endregion

            Console.WriteLine();

            #region Opgave 4
            Console.WriteLine("People left on the list:");
            foreach (var item in persons)
            {
                Console.WriteLine(item.Key);
            }
            #endregion
        }
    }
}