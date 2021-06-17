using System;

namespace KlisingDrugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;

            while (1 == 1)
            {
                int counter = 0;
                Console.WriteLine("Unesi niz brojeva: ");
                string recenica = Console.ReadLine();
                string[] podijelaRijeci = recenica.Split(" ");
                int[] nizbrojeva = new int[podijelaRijeci.Length];

                foreach (string s in podijelaRijeci)
                {
                    if (Int32.TryParse(s, out broj))
                        nizbrojeva[counter++] = broj;
                    else
                    {

                        Console.WriteLine("Nisi unio brojeve!");
                        break;
                    }
                }
                //do ovdje je zapisano unos broj i provjera nakon toga slijedi algoritam 
                if (podijelaRijeci.Length == nizbrojeva.Length)
                {

                    int[] noviNiz = new int[nizbrojeva.Length];
                    int krajReda = nizbrojeva.Length -1;
                    //ALGORITAM
                    foreach (int a in nizbrojeva)
                    {
                        noviNiz[krajReda] = a;
                        krajReda--;
                    }
                    foreach (int a in noviNiz)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
