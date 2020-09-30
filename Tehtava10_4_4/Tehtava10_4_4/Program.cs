using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Tehtava10_4_4


{
    [Serializable]
    class Tyontekija
    {

        private string nimi;
        private int id;
        private float palkka;

        public Tyontekija(int id, string nimi, float palkka)
        {
            this.nimi = nimi;
            this.id = id;
            this.palkka = palkka;
        }

        public override string ToString()
        {
            return "id: " + id + " nimi: " + this.nimi + " palkka: " + this.palkka;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string nimi;
            int id;
            float palkka;

            //Tässä määrätään hakemisto, jossa tiedostot sijaitsevat.
            string path = "/users/C#_FileCreating/emplReg.txt";


            //Tässä luodaan kirjoitusvirta (outputstream),
            // että tiedoston vanha sisältö säilytetään.
            //jonka avulla myös luodaan uusi tyhjä tiedosto,
            FileStream fOutStream = File.Open(path, FileMode.Append, FileAccess.Write);

            //Luodaan StreamWriter-virta FileStream-virran ympärille.
            BinaryFormatter bFormater = new BinaryFormatter();

            //Luodaan Hashtable-olio
            Hashtable hashtable = new Hashtable();

            //Tässä kysytään kolmelta käytäjiltä id, nimi ja palkka
            Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka): ");
            int tyontekija = 0;

            while (tyontekija < 3)
            {
                Console.WriteLine("Anna id: ");
                id = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Anna nimi: ");
                nimi = Console.ReadLine();

                Console.WriteLine("Anna palkka: ");
                palkka = float.Parse(Console.ReadLine());

                //Tässä täytetään hashtable key(id) ja value(Tyontekija-olio)
                hashtable.Add(id, new Tyontekija(id, nimi, palkka));

                tyontekija++;
            }

            //-----Kirjotetaan hashtable tidostoon------
            bFormater.Serialize(fOutStream, hashtable);
            Console.WriteLine("Hashtabel koko ennen: " + hashtable.Count);
            //Tässä tiedot kirjoitetaan lopullisesti tiedostoon.
            fOutStream.Flush();
            //Tässä virta suljetaan.
            fOutStream.Close();


            /*
             * Tässä luetaan data tiedostosta
             */

            // Tässä määrittelään FileStream lukuvirta
            FileStream fInStream = File.OpenRead(path);

            // Tässä luodaan tyhjenetaan hashtable-olion ja luodaan data FileStreamilta
            hashtable.Clear();
            Console.WriteLine("Hashtabel koko: " + hashtable.Count);


            while (fInStream.Position != fInStream.Length)
            {
                //Deserialize()-metodi palauttaa object-olioita,
                //joudutaan suorittamaan tyyppimuunnos!
                hashtable = (Hashtable)(bFormater.Deserialize(fInStream));
            }
            Console.WriteLine("Hashtabel koko jälkeen: " + hashtable.Count);
            //Tässä luodaan Enumerator
            IDictionaryEnumerator dEnumerator = hashtable.GetEnumerator();


            //Tässä kysytään käyttäjältä 'id' siihen saakka kun sitä loytyy
            //ja sen avulla tulostetaan muut tiedot 

            Boolean jatkuu = true;

            while (jatkuu)
            {

                Boolean hklLoytynyt = false;
                Console.WriteLine("Anna työntekijän id: ");
                id = Int16.Parse(Console.ReadLine());

                while (dEnumerator.MoveNext())
                {
                    if (dEnumerator.Key.Equals(id))
                    {
                        Console.WriteLine(dEnumerator.Value);
                        hklLoytynyt = true;

                    }
                }
                if (!hklLoytynyt)
                {
                    Console.WriteLine("Työntekijää ei löytynyt id-numerolla " + id);
                    jatkuu = false;
                }
                //Tässä rekisterin läpikäyntifunktio taas alustetaan.
                dEnumerator.Reset();
            }

            //Tässä suljetaan lukuvirta.
            fInStream.Close();
        }


    }
    /*
     * Second way, that was in the online course
     * using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
class Tyontekija
{
    public int Id { get; set; }
    public string Nimi { get; set; }
    public float Palkka { get; set; }

    public Tyontekija(int id, string nimi, float palkka)
    {
        this.Id = id;
        this.Nimi = nimi;
        this.Palkka = palkka;
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "tyontekijat_hash.dat";

        FileStream fOutStream = File.Open(tiedosto, FileMode.Create, FileAccess.Write);
        BinaryFormatter sFormatter = new BinaryFormatter();
        Hashtable tyontekijat = new Hashtable();

        Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka): ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Anna id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna nimi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("Anna palkka:");
            float palkka = (float)Convert.ToDouble(Console.ReadLine());

            tyontekijat.Add(id, new Tyontekija(id, nimi, palkka));
        }

        sFormatter.Serialize(fOutStream, tyontekijat);
        fOutStream.Close();

        FileStream fInStream = File.OpenRead(tiedosto);

        List<Tyontekija> tt_lista = new List<Tyontekija>();
        object obj;
        while (fInStream.Position != fInStream.Length)
        {
            obj = sFormatter.Deserialize(fInStream);

            if (obj is Hashtable)
            {
                tyontekijat = (Hashtable)obj;
            }
        }

        haku:
        Console.WriteLine("Anna työntekijän id:");
        int haettavaId = Convert.ToInt32(Console.ReadLine());

        Tyontekija tt = (Tyontekija)tyontekijat[haettavaId];
        if (tt != null)
        {
            Console.WriteLine("id: " + tt.Id + " nimi: " + tt.Nimi + " palkka: " + tt.Palkka);
			goto haku;
        }
        else
        {
            Console.WriteLine("Työntekijää ei löytynyt id-numerolla " + haettavaId);
        }

        
    }
}


     */
}
