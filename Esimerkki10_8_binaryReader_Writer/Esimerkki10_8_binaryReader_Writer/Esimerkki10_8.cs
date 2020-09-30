using System;
using System.IO;

class Esimerkki10_8
{
    static void Main(string[] args)
    {
        //T�ss� m��ritell��n tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/tuotteet.txt";

        //T�ss� luodaan kirjoitusvirta (outputstream), jonka 
        //avulla my�s luodaan uusi tyhj� tiedosto.
        FileStream fOutStream = File.Create(tiedosto);

        //T�ss� luodaan BinaryWriter-virta FileStream �virran 
        //ymp�rille.
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

        //T�ss� data kirjoitetaan pysyv�sti tiedostoon ja 
        //BinaryWriter-virta suljetaan. Huomaa, ett� ilman
        //t�t� BinaryReader-olio ei pysty k�sittelem��n 
        //tiedostoa!
        bWriter.Flush();
        bWriter.Close();

        //T�ss� luodaan lukuvirta (inputstream), joka viittaa 
        //fyysiseen tiedostoon.
        FileStream fInStream = File.OpenRead(tiedosto);

        //T�ss� m��ritell��n apumuuttujia.
        decimal temp = 0.0m, sum = 0.0m, keskiHinta = 0.0m;

        //T�ss� luodaan BinaryReader-virta. 
        BinaryReader bReader = new BinaryReader(fInStream);

        Console.WriteLine("Tuotteiden tiedot: ");

        //Seuraavassa tuotteiden tiedot luetaan tiedostosta ja
        //tulostetaan n�yt�lle.
        for (int i = 0; i < nimet.Length; i++)
        {
            //T�ss� luetaan tuotteen nimi ja tulostetaan n�yt�lle.
            Console.Write(bReader.ReadString() + " ");

            //T�ss� luetaan tuotteen m��r� ja tulostetaan n�yt�lle.
            Console.Write(bReader.ReadInt16() + " ");

            //T�ss� luetaan tuotteen yksikk�hinta ja vied��n 
            //muuttujaan temp.
            temp = bReader.ReadDecimal();

            //Muuttuja temp tulostetaan n�yt�lle.
            Console.Write(temp + "\n");

            sum += temp;
        }

        //T�ss� lasketaan tuotteiden keskihinta.
        keskiHinta = sum / nimet.Length;

        //T�ss� tulostetaan keskiHinta
        Console.WriteLine("Tuotteiden keskihinta on {0, 5:f2}.",
        keskiHinta);

        //T�ss� suljetaan BinaryReader -virta.
        bReader.Close();
    }
}

