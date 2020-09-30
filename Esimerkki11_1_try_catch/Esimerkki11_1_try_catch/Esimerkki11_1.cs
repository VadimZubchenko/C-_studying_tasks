using System;
// nollalla jako yritys
class Esimerkki11_1
{
    static void Main(string[] args)
    {
        //T?ss? esitell??n muuttujat.
        int luku1, luku2;
        string jatka = "k";
        again:
        //Seuraavassa lauseet laitetaan try/catch-lohkoon.
        try
        {
            
            while (jatka.Equals("k"))
            {
                Console.Write("Kirjoita ensimm?inen luku: ");
                luku1 = int.Parse(Console.ReadLine());

                Console.Write("Kirjoita ensimm?inen luku: ");
                luku2 = int.Parse(Console.ReadLine());

                Console.WriteLine("{0}/{1}={2,5:f2}", luku1, luku2,
                (luku1 / luku2));

                Console.WriteLine("Haluatko jatkaa? (k/e): ");
                jatka = Console.ReadLine();
            }
        }
        catch
        {
            //T?ss? tulostetaan viesti jos virhe sattuu.
            Console.WriteLine("Sattui virhe: Nollalla jako! Try again.");
            goto again;
        }
        
        Console.WriteLine("try/catch -lohkon ulkopuolella");
        
       

    }
}