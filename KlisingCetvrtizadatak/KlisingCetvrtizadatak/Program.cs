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
                int counter = 0;
                Console.WriteLine("Unesi niz brojeva: ");
                string recenica = Console.ReadLine();
                string[] podijelaRijeci = recenica.Split(" ");
                int[] nizbrojeva = new int[podijelaRijeci.Length];
                int najmanjibroj ;

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
                        int zbroj = 0;
                        foreach (int a in nizbrojeva)
                        {
                            zbroj = zbroj + a;
                        }
                    najmanjibroj = nizbrojeva[0];
                        float srednjaVrijednost = (float)zbroj / (float)nizbrojeva.Length;
                        
                    //ALGORITAM
                    foreach (int a in nizbrojeva)
                        {
                           
                            if ((Math.Abs(srednjaVrijednost - a) == Math.Abs(srednjaVrijednost - najmanjibroj)) && najmanjibroj >a)
                            {
                            najmanjibroj = a;
                        }
                            else if((Math.Abs(srednjaVrijednost - a) < Math.Abs(srednjaVrijednost - najmanjibroj)))
                            {
                                najmanjibroj = a;

                            }
                        }
                    Console.WriteLine("Broj koji je najbliži srednjoj vrijednosti je " + najmanjibroj);

                }

            }
            }
        }
    }

