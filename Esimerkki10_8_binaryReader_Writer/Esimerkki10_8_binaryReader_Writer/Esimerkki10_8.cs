using System;
using System.IO;

class Esimerkki10_8
{
    static void Main(string[] args)
    {
        //Tässä määritellään tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/tuotteet.txt";

        //Tässä luodaan kirjoitusvirta (outputstream), jonka 
        //avulla myös luodaan uusi tyhjä tiedosto.
        FileStream fOutStream = File.Create(tiedosto);

        //Tässä luodaan BinaryWriter-virta FileStream –virran 
        //ympärille.
        BinaryWriter bWriter = new BinaryWriter(fOutStream);

        //Seuraavassa luodaan tuotteiden tiedot.
        string[] nimet = { "Leipa", "Voi", "Maito" };
        short[] maarat = { 10, 8, 12 };
        decimal[] yksikkoHinnat = { 4.56m, 5.45m, 1.10m };

        //Seuraavassa tuotteiden tiedot kirjoitetaan tiedostoon.
        for (int i = 0; i < nimet.Length; i++)
        {
            bWriter.Write(nimet[i]);
            bWriter.Write(maarat[i]);
            bWriter.Write(yksikkoHinnat[i]);
        }

        //Tässä data kirjoitetaan pysyvästi tiedostoon ja 
        //BinaryWriter-virta suljetaan. Huomaa, että ilman
        //tätä BinaryReader-olio ei pysty käsittelemään 
        //tiedostoa!
        bWriter.Flush();
        bWriter.Close();

        //Tässä luodaan lukuvirta (inputstream), joka viittaa 
        //fyysiseen tiedostoon.
        FileStream fInStream = File.OpenRead(tiedosto);

        //Tässä määritellään apumuuttujia.
        decimal temp = 0.0m, sum = 0.0m, keskiHinta = 0.0m;

        //Tässä luodaan BinaryReader-virta. 
        BinaryReader bReader = new BinaryReader(fInStream);

        Console.WriteLine("Tuotteiden tiedot: ");

        //Seuraavassa tuotteiden tiedot luetaan tiedostosta ja
        //tulostetaan näytölle.
        for (int i = 0; i < nimet.Length; i++)
        {
            //Tässä luetaan tuotteen nimi ja tulostetaan näytölle.
            Console.Write(bReader.ReadString() + " ");

            //Tässä luetaan tuotteen määrä ja tulostetaan näytölle.
            Console.Write(bReader.ReadInt16() + " ");

            //Tässä luetaan tuotteen yksikköhinta ja viedään 
            //muuttujaan temp.
            temp = bReader.ReadDecimal();

            //Muuttuja temp tulostetaan näytölle.
            Console.Write(temp + "\n");

            sum += temp;
        }

        //Tässä lasketaan tuotteiden keskihinta.
        keskiHinta = sum / nimet.Length;

        //Tässä tulostetaan keskiHinta
        Console.WriteLine("Tuotteiden keskihinta on {0, 5:f2}.",
        keskiHinta);

        //Tässä suljetaan BinaryReader -virta.
        bReader.Close();
    }
}

