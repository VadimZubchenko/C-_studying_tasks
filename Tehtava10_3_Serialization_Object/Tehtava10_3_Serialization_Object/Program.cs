//Seuraavassa otetaan serialisoinnin vaatimat 
//Serialization- ja Binary- luokat käyttöön.

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


//Seuraavassa määritellän Tyontekija -luoka, joka merkitään
//serialisoitavaksi.
[Serializable]
class Tyontekija
{
    readonly string nimi;
    readonly int id;
    readonly float palkka;

    //Tässä määritellään luokan muodostin.
    public Tyontekija(string nimi, int id, float palkka)
    {
        this.nimi = nimi;
        this.id = id;
        this.palkka = palkka;
    }


    //Tässä määritellä luodaTyontekija-metodi, joka palauttaa
    //joko Tyontekija-luokan instanssin tai null-arvon.
    public Tyontekija GetTyontekija(int id)
    {

        if (this.id == id)
            return this;
        else
            return null;
    }

    //Tässä määritellään luokan ToString() -metodi.
    public override string ToString()
    {

        return "id: " + id + " nimi: " + nimi + " palkka: " + palkka;
    }
}

class Tehtava10_3
{
    static void Main(string[] args)
    {
        //Tässä määritellään tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/rekisteriNew.dat";
        
        //Tässä luodaan FileStream -olio, jonka avulla
        //serialisointi suoritetaan.
        FileStream fOutStream = File.Open(tiedosto, FileMode.Append, FileAccess.Write);

        //Tässä luodaan BinaryFormatter-olio, jolla serialisointi tapahtuu.
        BinaryFormatter bFormatter = new BinaryFormatter();

        //Seuraavassa luodaan tyontekija -taulukko, jossa 
        //säilytetään tuotteiden tiedot.
        Tyontekija[] tyontekijat = new Tyontekija[3];

        int id = 0; 
        string nimi = "";
        float palkka = 0;

        //Tässä kerätään datan käyttäjältä
        Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka): ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Anna id:");
            id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Anna nimi:");
            nimi = Console.ReadLine();

            Console.WriteLine("Anna palkka: ");
            palkka = float.Parse(Console.ReadLine());

            //täytetään taylukko Tyontekija-oliolla
            tyontekijat[i] = new Tyontekija(nimi, id, palkka);

        }
        //Seuraavassa Tyontekija-oliot(Tyontekija(nimi, id, palkka)
        //kirjoitetaan tiedostoon.
        for (int i = 0; i < tyontekijat.Length; i++)
            //kirjoitetaan kolme oliota erikseen 
            bFormatter.Serialize(fOutStream, tyontekijat[i]);

        //Tässä tiedot kirjoitetaan lopullisesti tiedostoon.
        fOutStream.Flush();

        //Tässä virta suljetaan.
        fOutStream.Close();
        
        /*
         * Täässä vaihessa luodaan Tyontekija-oliot tiedostosta 
         * ja etsitään id-lla henkilotiedot.
         * Tämän jälkeen ohjelman tulee pyytää työntekijän id-numero 
         * ja tarkistaa löytyykö työntekijä rekisteristä, 
         * nimittäin tiedostosta eikä taulokosta. 
         * Jos työntekijä löytyy, sen tiedot tulee tulostaa näytölle 
         * ja muuten ilmoittaa epäonnistuneesta hausta.
         */

        //Tässä määritellään lukuvirta.
        FileStream fInStream = File.OpenRead(tiedosto);

        //Tässä luodaan uusi taulukko, johon kirjoitetaan Tyontekija-oliot tiedostosta
        Tyontekija[] tyontekija = new Tyontekija[3];

        //Tässä käydään fInStream -lukuvirta käydään läpi. 
        //Huomaa, kuinka (fInStream.Position != fInStream.Length-ehdon
        //avulla tarkistetaan kuinka ollaan päästy tiedoston loppuun.
        while (fInStream.Position != fInStream.Length)
        {
            //Tässä luodaan Tyontekija-oliot jokasen erikseen ja tallennetaan
            //Tyontekija[] taulukkoon, joka on tyyppiä Tyontekija. Koska 
            //Deserialize() -metodi palauttaa object-olioita, 
            //joudutaan suorittamaan tyyppimuunnos!
            for (int i = 0; i < tyontekija.Length; i++)
                tyontekija[i] = (Tyontekija)(bFormatter.Deserialize(fInStream));
        };
        
        Boolean loyty = true;
        int count = 0;
        int idNew = 0;
        do
        {
            
            Console.WriteLine("Anna työntekijän id:");
            idNew = Int32.Parse(Console.ReadLine());

            // Tässä kohdassa tyontekijat-taulukko on luotu
            // tiedostosta rekisteriNew.d
            foreach (Tyontekija t in tyontekija)
            {
                if (t.GetTyontekija(idNew) != null)
                {
                    Console.WriteLine(t.GetTyontekija(idNew));
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            if (count >= tyontekija.Length)
            {
                Console.WriteLine("Työntekijää ei löytynyt id-numerolla " + idNew);
                loyty = false;
            }
        }
        while (loyty);

        //Tässä suljetaan lukuvirta.
        fInStream.Close();


    }
}

/*
 * Tässä on toinen algoritmi käyttäen 
 * List<Tyontekija> tyontekijat
 * niiin ei tarvitse laita tyontekijan määrän 
 * kuten Tyontekija[3]
 */
/*
using System;
using System.Collections.Generic;
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

    public Tyontekija HaeTyontekija(int id)
    {
        if (this.Id == id)
        {
            return this;
        }
        else
        {
            return null;
        }
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "tyontekijat.dat";

        FileStream fOutStream = File.Open(tiedosto, FileMode.Create, FileAccess.Write);
        BinaryFormatter sFormatter = new BinaryFormatter();
        List<Tyontekija> tyontekijat = new List<Tyontekija>();

        Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka): ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Anna id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna nimi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("Anna palkka:");
            float palkka = (float)Convert.ToDouble(Console.ReadLine());

            tyontekijat.Add(new Tyontekija(id, nimi, palkka));
        }

        sFormatter.Serialize(fOutStream, tyontekijat);
        fOutStream.Close();

        FileStream fInStream = File.OpenRead(tiedosto);

        object obj;
        while (fInStream.Position != fInStream.Length)
        {
            obj = sFormatter.Deserialize(fInStream);

            if (obj is List<Tyontekija>)
            {
                tyontekijat = (List<Tyontekija>)obj;
            }

        }

    haku:
        Console.WriteLine("Anna työntekijän id:");
        int haettavaId = Convert.ToInt32(Console.ReadLine());

        Tyontekija tt = null;
        foreach (var t in tyontekijat)
        {
            tt = t.HaeTyontekija(haettavaId);
            if (tt != null)
            {
                Console.WriteLine("id: " + tt.Id + " nimi: " + tt.Nimi + " palkka: " + tt.Palkka);
                break;
            }
        }

        if (tt == null)
        {
            Console.WriteLine("Työntekijää ei löytynyt id-numerolla " + haettavaId);
        }
        else
        {
            goto haku;
        }

    }
}
*/



