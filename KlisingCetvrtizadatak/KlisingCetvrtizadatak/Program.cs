using System;

namespace KlisingCetvrtizadatak
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
                    int najmanjibroj;

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
                        int zbroj = 0;
                        foreach (int brojuNizu in nizbrojeva)
                        {
                            zbroj = zbroj + brojuNizu;
                        }
                        najmanjibroj = nizbrojeva[0];
                        float srednjaVrijednost = (float)zbroj / (float)nizbrojeva.Length;

                        //ALGORITAM
                        foreach (int brojuNizu in nizbrojeva)
                        {

                            if ((Math.Abs(srednjaVrijednost - brojuNizu) == Math.Abs(srednjaVrijednost - najmanjibroj)) && najmanjibroj > brojuNizu)
                            {
                                najmanjibroj = brojuNizu;
                            }
                            else if ((Math.Abs(srednjaVrijednost - brojuNizu) < Math.Abs(srednjaVrijednost - najmanjibroj)))
                            {
                                najmanjibroj = brojuNizu;

                            }
                        }
                        Console.WriteLine("Broj koji je najbliži srednjoj vrijednosti je " + najmanjibroj);

                    }

                }
            }
        }
        }
    }

