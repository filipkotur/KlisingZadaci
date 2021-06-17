using System;

namespace KlisingPrvizadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            bool provjera = false;

            while (1 == 1)
            {
                int counter = 0;
                Console.WriteLine("Unesi niz brojeva: ");
                string name = Console.ReadLine();
                string[] podijelaRijeci = name.Split(" ");
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
                    Console.WriteLine("Unesi broj koji je zbroj dvaju brojeva: ");

                    string stringProvjera = Console.ReadLine();
                    int tocanBroj;  provjera = int.TryParse(stringProvjera, out tocanBroj);
                    if (provjera == true)
                    {
                        int pokazivač = 0;
                        //ALGORITAM
                        foreach (int a in nizbrojeva)
                        {
                            for (int i = pokazivač + 1; i < nizbrojeva.Length; i++)
                            {
                                if (a + nizbrojeva[i] == tocanBroj)
                                {
                                    Console.WriteLine(a + "," + nizbrojeva[i]);


                                }
                            }
                            pokazivač++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nisi unio broj");
                    }


                }



            }
        }
    }
}
