using System;
using System.IO;

class Esimerkki10_9
{
    static void Main(string[] args)
    {
        //T‰ss‰ m‰‰ritell‰‰n tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/tuotteet.txt";

        //T‰ss‰ luodaan kirjoitusvirta (outputstream) kirjoutusta
        //varten siten, ett‰ tiedoston vanha sis‰ltˆ s‰ilytet‰‰n.
        FileStream fOutStream = File.Open(tiedosto,
        FileMode.Append, FileAccess.Write);

        //T‰ss‰ luodaan StreamWriter-virta FileStream-virran 
        //ymp‰rille.
        StreamWriter sWriter = new StreamWriter(fOutStream);

        //Seuraavassa kirjoitetaan p‰iv‰m‰‰r‰ tiedostoon.
        sWriter.WriteLine(DateTime.Now);

        //Seuraavassa luodaan tuotteiden tiedot.
        string[] nimet = { "Leip‰", "Voi", "Maito" };
        Int16[] maarat = { 10, 8, 12 };
        decimal[] yksikkoHinnat = { 4.56m, 5.45m, 1.10m };

        //Seuraavassa tuotteiden tiedot kirjoitetaan tiedostoon.
        for (int i = 0; i < nimet.Length; i++)
            sWriter.WriteLine(nimet[i] + " " + maarat[i] + " " +
            yksikkoHinnat[i]);

        //T‰ss‰ data kirjoitetaan pysyv‰sti tiedostoon ja 
        //StreamWriter-virta suljetaan. Huomaa, ett‰ ennen
        //seuraava lausetta StreamReader-virta ei pysty 
        //k‰sittelem‰‰n tiedostoa!
        sWriter.Flush();
        sWriter.Close();

        //T‰ss‰ luodaan lukuvirta (inputstream), joka viittaa 
        //fyysiseen tiedostoon.
        FileStream fInStream = File.OpenRead(tiedosto);

        //T‰ss‰ luodaan StreamReader-virta. 
        StreamReader sReader = new StreamReader(fInStream);

        string rivi = null;
        while ((rivi = sReader.ReadLine()) != null)
        {
            //T‰ss‰ etsit‰‰n p‰iv‰m‰‰r‰ ja tulsotetaan erikseen.
            if (rivi.IndexOf('.') != -1)
                Console.WriteLine("Seuraavat tiedot on lis‰tty " +
                rivi);
            else
                Console.WriteLine(rivi);
        }

        //T‰ss‰ suljetaan StreamReader-virta.
        sReader.Close();
    }
}
