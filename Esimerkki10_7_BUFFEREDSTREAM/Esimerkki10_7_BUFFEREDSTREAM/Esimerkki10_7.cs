  using System;
  using System.IO;
/*
 *BufferedStream-luokan avulla dataa voidaan lukea
 *tietokoneen muistiin ennen sen siirt‰mist‰ toiseen paikkaan.
 */
class Esimerkki10_7
{
 static void Main(string[] args)
 {
   //T‰ss‰ m‰‰ritell‰‰n hakemisto, jossa tiedostot 
   //sijaitsevat.
   string polku = "/users/UusiKansio/VadimNew/";

   //T‰ss‰ m‰‰ritell‰‰n tiedostojen nimet.
   string tiedosto="Greeting.cs", varmuus="Varmuus_2.cs";

   //T‰ss‰ luodaan lukuvirta (inputstream), joka viittaa 
   //fyysiseen tiedostoon.
   FileStream fInStream = File.OpenRead(polku + tiedosto);

   //T‰ss‰ luodaan BufferedStream-virta FileStream-virran 
   //ymp‰rill‰.
   BufferedStream bInStream = new BufferedStream(fInStream);

   //T‰ss‰ luodaan kirjoitusvirta (outputstream), joka 
   //viittaa fyysiseen tiedostoon.
   FileStream fOutStream = File.Open(polku + varmuus, 
   FileMode.Append, FileAccess.Write);

   //T‰ss‰ luodaan BufferedStream-virta FileStream-virran 
   //ymp‰rill‰.
   BufferedStream bOutStream = 
   new BufferedStream(fOutStream);

   Console.WriteLine(fInStream.Name + " -tiedoston koko on " + bInStream.Length + " tavua.");

   Console.WriteLine(fOutStream.Name + " -tiedoston koko alussa on " + bOutStream.Length + " tavua.");

   int luetutTavut;

   //Seuraavassa dataa siirret‰‰n tiedosojen v‰lill‰ 3072 
   //-tavun jonoina. Read() -metodilla tavuja luetaan
   //taulukkoon, jonka sis‰ltˆ sitten siirret‰‰n toiseen
   //tiedostoon.
   byte[] puskuri = new byte[3072];

   //Seuraavassa data siirret‰‰n BufferedStream -luokan
   //Read()- ja Write()-metodien avulla. N‰m‰ metodit 
   //vaativat puskuritaulukon nimen, sen indeksin, josta 
   //luku aloitetaan sek‰ taulukosta luettavien alkioiden 
   //m‰‰r‰n.
   while ((luetutTavut = bInStream.Read(puskuri, 0, 
   puskuri.Length)) > 0)
     bOutStream.Write(puskuri, 0, luetutTavut);

   //T‰ss‰ dataa kirjoitetaan lopullisesti m‰‰r‰np‰‰h‰n. 
   bOutStream.Flush();

   Console.WriteLine(fOutStream.Name + " -tiedoston koko lopussa on " + fOutStream.Length + " tavua.");

   //T‰ss‰ dataa kirjoitetaan lopullisesti levylle ja 
   //kirjiotusvirta suljetaan.
   fOutStream.Close();

   //T‰ss‰ lukuvirta suljetaan.
   fInStream.Close();

   //Seuraavassa BufferedStream-virrat suljetaan.
   bOutStream.Close();
   bInStream.Close();
 }
}
