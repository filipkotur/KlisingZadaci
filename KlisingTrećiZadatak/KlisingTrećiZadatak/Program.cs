using System;
using System.Collections.Generic;

namespace KlisingTrećiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesi string: ");
            string recenica = Console.ReadLine();
            char[] ProvjeraChara = new char[recenica.Length];
            
            var dictionary = new Dictionary<char, int>();
            foreach (char znak in recenica)
            {
                if (dictionary.ContainsKey(znak))
                    dictionary[znak]++;
                else
                    dictionary.Add(znak, 1);
            }
            foreach (var val in dictionary)
            {
                if (val.Value != 1)
                {
                    Console.WriteLine("uneseni karakter "+val.Key+" pojavljuje se " + val.Value+" puta");
                }
            }


        }
    }
}
