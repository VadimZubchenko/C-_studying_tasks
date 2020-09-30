using System;
using System.Collections;
using System.IO;

namespace Tehtava10_2_4
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

            //Tässä luodaan lukuvirta (inputstream) lukemista
            //varten siten
            FileStream fInStream = File.OpenRead(path);

            //Tässä luodaan StreamReader-virta FileStream-virran ympärille
            StreamReader sReader = new StreamReader(fInStream);

            //Seuraava olisi toinen lyhyempi tapa alustaa StreamWriter-olio.
            //StreamReader sReader = File.OpenText(path);

            

            //Tässä kysytään id käytäjältä
            char id;
            Console.WriteLine("Anna työntekijän id: ");
                id = Convert.ToChar(Console.ReadLine());

            //Tässä luetaan koko datan tiedostossa
            //ja jos id löytyy, sitten tulostetaan asiakastiedot
            BinaryReader bReader = new BinaryReader(fInStream);
            bool loytty = false;
            string line = "";
            while((line = sReader.ReadLine()) != null)
            {
                

                if (id == line[0])
                {
                    //Tässä tulostetaan vain koko rivi
                    Console.WriteLine(line);
                    //Tässä jäetaan koko rivi osaksi, jotka erott avat toisista
                    // välilyönnilla ja kootaan niista taulukko "parts".
                    string[] parts = line.Split(' ');

                    //Tulostetaan tarvittavat osat tietyyn paikaan 
                    Console.Write("id: " + parts[0]);
                    Console.Write(" name: " + parts[1]);
                    Console.WriteLine(" palkka: " + parts[2]);
                    
                    loytty = true;

                    //Seuraavassa taulukon sisältö voidaan tulostaa käyttämällä
                    //läpikäyntifunktiota IEnumerator.

                    IEnumerator enumerator = line.GetEnumerator();
                        
                    while (enumerator.MoveNext())
                        
                        if (enumerator.Current != null)
                            Console.Write(enumerator.Current + " ");

                }
            }
                
            if(!loytty)
                Console.WriteLine("Työntekijää ei löydy id-numerolla "+ id);
                

            //Tässä suljetaan StreamReader-virta.
            sReader.Close();
           

        }
    }
}
