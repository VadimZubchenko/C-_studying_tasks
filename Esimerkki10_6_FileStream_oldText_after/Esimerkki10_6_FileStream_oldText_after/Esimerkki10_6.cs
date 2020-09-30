using System;
using System.IO;

class Esimerkki10_6
{
    static void Main(string[] args)
    {
        //T‰ss‰ m‰‰ritell‰‰n hakemisto, jossa tiedostot 
        //sijaitsevat.
        string polku = "/users/UusiKansio/VadimNew/";

        //T‰ss‰ m‰‰ritell‰‰n tiedostojen nimet.
        string tiedosto = "Greeting.cs", varmuus = "OldText.cs";

        //T‰ss‰ luodaan lukuvirta (inputstream), joka viittaa 
        //fyysiseen tiedostoon.
        FileStream fInStream = File.OpenRead(polku + tiedosto);

        Console.WriteLine(fInStream.Name + " -tiedoston koko on "
        + fInStream.Length + " tavua.");

        //T‰ss‰ luodaan kirjoitusvirta (outputstream), joka 
        //viittaa fyysiseen tiedostoon. 
        FileStream fOutStream = File.Open(polku + varmuus,
        FileMode.Append, FileAccess.Write);//Append - lis‰ teksti alkuperaisen loppuun

        //Seuraava olisi toinen tapa alustaa FileStream-olio.
        //FileStream fOutStream = new FileStream(polku + varmuus, 
        //FileMode.Append, FileAccess.Write);

        Console.WriteLine(fOutStream.Name + " -tiedoston koko alussa on " + fOutStream.Length + " tavua.");

        int luetutTavut;

        //Seuraavassa dataa siirret‰‰n tiedosojen v‰lill‰ 128 
        //-tavun jonoina. Read() -metodilla tavuja luetaan
        //taulukkoon, jonka sis‰ltˆ sitten siirret‰‰n toiseen
        //tiedostoon.
        byte[] puskuri = new byte[128];

        //Seuraavassa data luetaan Read()- ja kirjoitetaan 
        //Write()-metodien avulla. N‰m‰ metodit vaativat 
        //puskuritaulukon nimen, sen indeksin, josta luku 
        //aloitetaan sek‰ taulukosta luettavien alkioiden m‰‰r‰n.
        while ((luetutTavut = fInStream.Read(puskuri, 0,
        puskuri.Length)) > 0)
            fOutStream.Write(puskuri, 0, luetutTavut);

        //T‰ss‰ dataa kirjoitetaan lopullisesti m‰‰r‰np‰‰h‰n. 
        fOutStream.Flush();

        Console.WriteLine(fOutStream.Name + " -tiedoston koko lopussa on " + fOutStream.Length + " tavua.");

        //T‰ss‰ dataa kirjoitetaan lopullisesti levylle ja 
        //kirjiotusvirta suljetaan.
        fOutStream.Close();

        //T‰ss‰ lukuvirta suljetaan.
        fInStream.Close();
    }
}