//Seuraavassa otetaan System.Text-kirjasto, josta
//StringBuilder-luokka l�ytyy.
using System;
using System.IO;
using System.Text;

class Esimerkki10_10
{
    static void Main(string[] args)
    {
        //Seuraavassa m��ritell��n StringBuilder-olio, jonka 
        //sis�lt�� my�hemmin k�sitell��n StringReader- ja
        //StringWriter-olioiden avulla.
        StringBuilder tekstiPuskuri = new StringBuilder();

        //T�ss� luodaan StringWriter-olio StringBuilder-olion 
        //ymp�rille.
        StringWriter sWriter = new StringWriter(tekstiPuskuri);

        //T�ss� kirjoitetaan tekstipuskuriin.
        sWriter.WriteLine(DateTime.Now);
        sWriter.WriteLine("YOn pilvista.");
        sWriter.WriteLine("Sataa lunta.");
        sWriter.WriteLine("Sataa r�ntaa.");
        sWriter.WriteLine("Sataa vetta.");
        sWriter.WriteLine("On aurinkoista.");

        //T�ss StringWriter suljetaan.
        sWriter.Close();

        //T�ss� tulostetaan m��r�np��n nimi.
        Console.WriteLine("Tekstipuskurin koko on " +
        sWriter.GetStringBuilder().Length + ":");

        //T�ss� luodaan StringReader -olio StringBuilder-olion 
        //ymp�rille.
        StringReader sReader =
        new StringReader(tekstiPuskuri.ToString());

        //T�ss� tekstipuskurin sis�lt� luetaan sisalto 
        //-merkkijonoon ja tulostetaan n�yt�lle.
        string sisalto = sReader.ReadToEnd();
        Console.WriteLine(sisalto);

        //T�ss� sReader -olio alustetaan uudelleen. T�m�n 
        //j�lkeen sen osoitin viittaa sen alkuun edellisen 
        //ReadToEnd() -metodin kutsun j�lkeen.  
        sReader = new StringReader(tekstiPuskuri.ToString());

        //T�ss� tekstipuskurin ensimm�inen rivi luetaan 
        //ja tulostetaan.
        Console.WriteLine("Ensimmainen rivi: " +
        sReader.ReadLine());

        //Seuraavassa tekstipuskurista luetaan yksi merkki 
        //meotdilla Peek(), joka ei siirr� virran osoitinta  
        //eteenp�in. T�m� tarkoittaa, ett� kun seuraavan kerran  
        //luetaan virrasta, luku alkaa metodin Peek()  
        //palauttamasta merkist�!
        Console.WriteLine("Peek() -metodin lukema merkki, \neli ensim. rivin jalkeen: " +
        (char)sReader.Peek());

        //T�ss� tekstipuskurista luetaan yksi merkki ja 
        //tulostetaan.
        Console.WriteLine("Read() -metodin lukema merkki: " +
        (char)sReader.Read());
        Console.WriteLine("ja nyt Peek() -> Read() jalkeen: " +
        (char)sReader.Peek());

        char[] puskuri = new char[32];

        //T�ss� luetaan 32 merkki� puskurista 
        //puskuri -taulukkoon.
        sReader.ReadBlock(puskuri, 0, puskuri.Length);

        Console.WriteLine("32 merkki� tekstipuskurista: ");
        foreach (char ch in puskuri)
            Console.Write(ch);

        Console.WriteLine();

        sReader.Close();
    }
}
