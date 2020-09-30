//Seuraavassa otetaan System.Text-kirjasto, josta
//StringBuilder-luokka löytyy.
using System;
using System.IO;
using System.Text;

class Esimerkki10_10
{
    static void Main(string[] args)
    {
        //Seuraavassa määritellään StringBuilder-olio, jonka 
        //sisältöä myöhemmin käsitellään StringReader- ja
        //StringWriter-olioiden avulla.
        StringBuilder tekstiPuskuri = new StringBuilder();

        //Tässä luodaan StringWriter-olio StringBuilder-olion 
        //ympärille.
        StringWriter sWriter = new StringWriter(tekstiPuskuri);

        //Tässä kirjoitetaan tekstipuskuriin.
        sWriter.WriteLine(DateTime.Now);
        sWriter.WriteLine("YOn pilvista.");
        sWriter.WriteLine("Sataa lunta.");
        sWriter.WriteLine("Sataa räntaa.");
        sWriter.WriteLine("Sataa vetta.");
        sWriter.WriteLine("On aurinkoista.");

        //Täss StringWriter suljetaan.
        sWriter.Close();

        //Tässä tulostetaan määränpään nimi.
        Console.WriteLine("Tekstipuskurin koko on " +
        sWriter.GetStringBuilder().Length + ":");

        //Tässä luodaan StringReader -olio StringBuilder-olion 
        //ympärille.
        StringReader sReader =
        new StringReader(tekstiPuskuri.ToString());

        //Tässä tekstipuskurin sisältö luetaan sisalto 
        //-merkkijonoon ja tulostetaan näytölle.
        string sisalto = sReader.ReadToEnd();
        Console.WriteLine(sisalto);

        //Tässä sReader -olio alustetaan uudelleen. Tämän 
        //jälkeen sen osoitin viittaa sen alkuun edellisen 
        //ReadToEnd() -metodin kutsun jälkeen.  
        sReader = new StringReader(tekstiPuskuri.ToString());

        //Tässä tekstipuskurin ensimmäinen rivi luetaan 
        //ja tulostetaan.
        Console.WriteLine("Ensimmainen rivi: " +
        sReader.ReadLine());

        //Seuraavassa tekstipuskurista luetaan yksi merkki 
        //meotdilla Peek(), joka ei siirrä virran osoitinta  
        //eteenpäin. Tämä tarkoittaa, että kun seuraavan kerran  
        //luetaan virrasta, luku alkaa metodin Peek()  
        //palauttamasta merkistä!
        Console.WriteLine("Peek() -metodin lukema merkki, \neli ensim. rivin jalkeen: " +
        (char)sReader.Peek());

        //Tässä tekstipuskurista luetaan yksi merkki ja 
        //tulostetaan.
        Console.WriteLine("Read() -metodin lukema merkki: " +
        (char)sReader.Read());
        Console.WriteLine("ja nyt Peek() -> Read() jalkeen: " +
        (char)sReader.Peek());

        char[] puskuri = new char[32];

        //Tässä luetaan 32 merkkiä puskurista 
        //puskuri -taulukkoon.
        sReader.ReadBlock(puskuri, 0, puskuri.Length);

        Console.WriteLine("32 merkkiä tekstipuskurista: ");
        foreach (char ch in puskuri)
            Console.Write(ch);

        Console.WriteLine();

        sReader.Close();
    }
}
