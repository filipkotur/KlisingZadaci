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
                int brojač = 0;
                Console.WriteLine("Unesi niz brojeva: ");
                string pocetniUnos = Console.ReadLine();
                if (!string.IsNullOrEmpty(pocetniUnos))
                {
                    string[] podijelaRijeci = pocetniUnos.Split(" ");
                    int[] nizbrojeva = new int[podijelaRijeci.Length];

                    foreach (string rijec in podijelaRijeci)
                    {
                        if (Int32.TryParse(rijec, out broj))
                            nizbrojeva[brojač++] = broj;
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
                        int krajReda = nizbrojeva.Length - 1;
                        //ALGORITAM
                        foreach (int brojuNizu in nizbrojeva)
                        {
                            noviNiz[krajReda] = brojuNizu;
                            krajReda--;
                        }
                        foreach (int brojuNizu in noviNiz)
                        {
                            Console.Write(brojuNizu + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
