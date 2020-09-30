using System;
using System.IO;

class Esimerkki10_5
{
    static void Main(string[] args)
    {
        /*
         * varmista, ett‰ tiedostot Greeting.cs ja Varmuus.cs
         * ovat olemassa hakemistossa /users/UusiKansio/VadimNew/
         */
        //T‰ss‰ m‰‰ritell‰‰n hakemisto, jossa tiedostot sijaitsevat.
        string polku = "/users/UusiKansio/VadimNew/";
        
        //T‰ss‰ m‰‰ritell‰‰n tiedoston nimi.
        string tiedosto="Greeting.cs", varmuus="Varmuus.cs";

        //T‰ss‰ luodaan lukuvirta (inputstream), joka viittaa 
        //fyysiseen tiedostoon.
        FileStream fInStream = File.OpenRead(polku + tiedosto);//"/users/UusiKansio/VadimNew/" + Greeting.cs

        Console.WriteLine(fInStream.Name + " on luettava? " + fInStream.CanRead);

        Console.WriteLine(fInStream.Name + " -tiedoston koko on " + fInStream.Length + " tavua.");

        //T‰ss‰ luodaan kirjoitusvirta (outputstream), joka viittaa 
        //fyysiseen tiedostoon. Huomaa, ett‰ seuraava tiedostovirta
        //kirjoittaa tiedoston vanhan sis‰llˆn p‰‰lle. 
        FileStream fOutStream = File.OpenWrite(polku + varmuus);

        Console.WriteLine(fOutStream.Name + " on kirjoitettavissa? " + fOutStream.CanWrite);

        int luettuTavu;

        //Seuraavassa ensin luetaan tiedostoston sis‰ltˆ tavuina 
        //ReadByte()-metodin avulla ja kirjoitetaan uuteen 
        //tiedostoon WriteByte()-metodin avulla. ReadByte()
        //paalauttaa -1 jos tiedostossa ei ole en‰‰ luettavaa.
        while ((luettuTavu = fInStream.ReadByte()) != -1)
            fOutStream.WriteByte((byte)luettuTavu);

        //T‰ss‰ muistissa oleva data kirjoitetaan fyysiseen tiedostoon.
        fOutStream.Flush();

        Console.WriteLine(fOutStream.Name + " -tiedoston koko lopussa on " + fOutStream.Length + " tavua.");

        //Seuraavassa tiedostovirrat suljetaan.
        fOutStream.Close();
        fInStream.Close();
    }
}
