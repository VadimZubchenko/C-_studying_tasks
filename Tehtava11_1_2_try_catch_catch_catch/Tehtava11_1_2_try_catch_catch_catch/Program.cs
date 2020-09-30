using System;

class Esimerkki11_3
//Poikkeusten sieppaaminen yhdellä try- ja 3 catch-lohkolla:
{
    static void Main(string[] args)
    {

        int[] taulukko = new int[3];
        int luku1, luku2;
        bool jatka = true;
        int i = 0;
        //Seuraavassa lauseet laitetaan try/catch -lohkoon.
        try
        {
            while (jatka)
            {
                Console.WriteLine("Anna kaksi kokonaislukua:");
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());

                int jako = luku1 / luku2;

                taulukko[i] = jako;
                i++;
            }

        }
        catch (FormatException e)
        {
            Console.WriteLine("Syötetty arvo ei ollut kokonaisluku.");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Viittaus taulukon ulkopuolelle!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Yritit jakaa nollalla.");
        }

    }

}

