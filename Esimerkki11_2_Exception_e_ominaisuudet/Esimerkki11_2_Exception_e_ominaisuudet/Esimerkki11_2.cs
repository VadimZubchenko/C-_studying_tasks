using System;

class Esimerkki11_2
{
    static void Main(string[] args)
    {
        //T?ss? esitell??n muuttujat.
        ushort[] bitit = { 1, 0, 1, 0, 0 };
        ushort luku = 5;
        ushort j = 0;

        //Seuraavassa lauseet laitetaan try/catch-lohkoon.
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i={0} --> {1}/{2}={3} ", i,
                luku, bitit[i], (luku / bitit[i]));
                j++;
            }
        }
        catch (Exception e)
        {
            //T?ss? asetetaan apulinkin nimi.
            e.HelpLink = "/users/C#_FileCreating/rekisteri.txt";

            Console.WriteLine("----------------");

            //T?ss? tulostetaan virheeseen liittyv?t lis?tiedot.
            
            Console.WriteLine("Virheen tiedot:");
            Console.WriteLine("HelpLink: " + e.HelpLink);
            Console.WriteLine("Message: " + e.Message);
            Console.WriteLine("Source: " + e.Source);
            Console.WriteLine("StackTrace: " + e.StackTrace);

            Console.WriteLine("----------------");
            
        }
        finally
        {
            Console.WriteLine("finally -lohkossa! Loput bitit:");
            for (int i = j; i < bitit.Length; i++)
                Console.Write("bitit[" + i + "]=" + bitit[i] + " ");

            Console.WriteLine();
        }
    }
}
