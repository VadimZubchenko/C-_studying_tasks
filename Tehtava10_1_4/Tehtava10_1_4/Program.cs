using System;
using System.IO;

namespace Tehtava10_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan uusi tiedosto rekisteri.cs
            //määritellään tiedoston täydellinen osoite. 
            string path = "/users/C#_FileCreating/rekisteri.txt";

            //tässä luodaan uusi tiedosto, jos sitä ei ole olemassa
            if (!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("File is created!");
            }
            else
                Console.WriteLine("File already exists!");

            //Tässä luodaan kirjoitusvirta (outputstream) kirjoutusta
            //varten siten, että tiedoston vanha sisältö säilytetään
            //FileMode.append -lla.
            FileStream fOutStream = File.Open(path,
            FileMode.Append, FileAccess.Write);

            //Tässä luodaan StreamWriter-virta FileStream-virran ympärille
            StreamWriter sWriter = new StreamWriter(fOutStream);

            //Seuraava olisi toinen lyhyempi tapa alustaa StreamWriter-olio.
            //StreamWriter sWriter = File.AppendText(path);

            //Tässä kerätään datan käyttäjältä
            Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka): ");

            int id = 0;
            string nimi = "";
            double palkka = 0;

            int laskuri = 3;
            do
            {
                Console.WriteLine("Anna id:");
                id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Anna nimi:");
                nimi = Console.ReadLine();

                Console.WriteLine("Anna palkka: ");
                palkka = Double.Parse(Console.ReadLine());

                //Tässä kerattu ArrayListaan datan kirjoitetaan tiedostoon.
                sWriter.WriteLine(id + " " + nimi + " " + palkka);


                laskuri--;
            }
            while (laskuri > 0);
            //Tässä data kirjoitetaan pysyvästi tiedostoon ja 
            //StreamWriter-virta suljetaan.
            sWriter.Flush();
            sWriter.Close();

        }
    }
}
