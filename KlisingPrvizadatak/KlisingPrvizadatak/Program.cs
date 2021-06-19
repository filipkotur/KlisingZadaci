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
                int brojač = 0;
                Console.WriteLine("Unesi niz brojeva: ");
                string pocetniUnos = Console.ReadLine();
                if(!string.IsNullOrEmpty(pocetniUnos)) {

                string[] podijelaRijeci = pocetniUnos.Split(" ");
                int[] nizbrojeva = new int[podijelaRijeci.Length];
                foreach (string rijec in podijelaRijeci)
                {
                                     
                        if (Int32.TryParse(rijec, out broj))
                            nizbrojeva[brojač++] = broj;
                        else
                        {
                        Console.WriteLine("Nisi unio brojeve!");
                      
                    }

                }



                    //do ovdje je zapisano unos broj i provjera nakon toga slijedi algoritam 
                    if (podijelaRijeci.Length == nizbrojeva.Length)
                    {
                        Console.WriteLine("Unesi broj koji je zbroj dvaju brojeva: ");

                        string stringProvjera = Console.ReadLine();
                        int tocanBroj; provjera = int.TryParse(stringProvjera, out tocanBroj);
                        if (provjera == true)
                        {
                            int pokazivač = 0;
                            //ALGORITAM
                            foreach (int brojuNizu in nizbrojeva)
                            {
                                for (int i = pokazivač + 1; i < nizbrojeva.Length; i++)
                                {
                                    if (brojuNizu + nizbrojeva[i] == tocanBroj)
                                    {
                                        Console.WriteLine(brojuNizu + "," + nizbrojeva[i]);


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
}
