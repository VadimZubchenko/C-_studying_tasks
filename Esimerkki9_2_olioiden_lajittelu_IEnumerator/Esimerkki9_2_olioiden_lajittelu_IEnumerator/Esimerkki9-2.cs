//ArrayList-luokan käyttöä varten otetaan
//käyttöön System.Collections-kirjasto.
using System;
using System.Collections;

//Seuraavassa määritellään luokka Henkilo, joka toteuttaa
//liittymän IComparable. Tämä on pakollinen jos halutaan
//pystyä lajittelemaan ArrayList-kokoelman Henkilo-olioita.
class Henkilo : IComparable
{
    string nimi;
    int id;
    float palkka;

    public Henkilo(string nimi, int id, float palkka)
    {
        this.nimi = nimi;
        this.id = id;
        this.palkka = palkka;
    }

    public override string ToString()
    {
        return id + " " + nimi + " " + palkka;
    }

    //Seuraavassa toteutetaan IComparable-liittymän metodi
    //CompareTo(), joka kutsutaan aina, kun oliot lajitellaan. 
    public int CompareTo(Object obj)
    {
        //Tässä joudutaan muuntamaan obj-olio Henkilo-
        //tyyppiseksi. Tämä on mahdollista, koska obj on 
        //tyyppiä Object, joka on kaikkien luokkien kantaluokka.
        Henkilo tempHenkilo = (Henkilo)obj;

        if (this.palkka < tempHenkilo.palkka)
            return -1;
        else if (this.palkka > tempHenkilo.palkka)
            return 1;
        else
            return 0;
    }
}

class Esimerkki9_2
{
    static void Main(string[] args)
    {
        //Tässä luodaan ArrayList-kokoelma henkilot. 
        ArrayList henkilot = new ArrayList();

        //seuraavassa määritellään Henkilo-olioita.
        Henkilo h1 = new Henkilo("Pessi", 100, 4234.50f);
        Henkilo h2 = new Henkilo("AnnaLiisa", 200, 1234.60f);
        Henkilo h3 = new Henkilo("Illuusia", 300, 3234.70f);

        //Seuraavassa lisätään dataa ArrayList-kokoelmaan.
        henkilot.Add(h1);
        henkilot.Add(h2);
        henkilot.Add(h3);

        Console.WriteLine("Henkilötiedot alussa:");

        //Seuraavassa ArrayList-kokoelman kaikki alkiot 
        //tulostetaan näytölle käyttämällä liittymää
        //IEnumerator.
        IEnumerator enumarator = henkilot.GetEnumerator();
        while (enumarator.MoveNext())
            Console.WriteLine(enumarator.Current);

        Console.WriteLine("-----------------");

        //Seuraavassa selvitetään sisältääkö 
        //ArrayList-kokoelma henkilot oliota h2.
        Console.WriteLine("IndexOf() avulla selvitetaan index ");
        if (henkilot.Contains(h2))
        {
            //Tässä selvitetään h2-olion indeksi.
            int h2Indeksi = henkilot.IndexOf(h2);
            Console.WriteLine("h2-olion indeksi on " +
            h2Indeksi);
            Console.WriteLine("h2: " +
            henkilot[h2Indeksi]);
        }

        Console.WriteLine("-----------------");

        //Tässä haetaan h3-olio metodin BinarySearch() avulla.
        Console.WriteLine("BinarySearch() avulla selvitetaan index ");
        int h3Indeksi = henkilot.BinarySearch(h3);
        Console.WriteLine("h3-olion indeksi on " +
        h3Indeksi);
        Console.WriteLine("h3: " +
        henkilot[h3Indeksi]);
        Console.WriteLine("-----------------");

        //Tässä ArrayList-kokoelman sisältö lajitellaan 
        //palkan mukaan nousevaan järjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkilötiedot nousevassa järjestyksessä palkan mukaan:");

        //Tässä läpikäyntifunktio enumerator 
        //alustetaan uudelleen.
        enumarator = henkilot.GetEnumerator();

        //Seuraavassa käydään luettelo läpi ja kaikki 
        //alkiot taas tulostetaan näytölle. 
        while (enumarator.MoveNext())
            Console.WriteLine(enumarator.Current);

        Console.WriteLine("-----------------");

        //Tässä ArrayList-kokoelman henkilot sisältö 
        //lajitellaan palkan mukaan laskevaan järjestykseen.
        henkilot.Reverse();

        Console.WriteLine("Henkilötiedot laskevassa järjestyksessä palkan mukaan:");

        //Tässä ArrayList-kokoelman henkilot kaikki alkiot 
        //taas tulostetaan näytölle. Huomaa, että tässä 
        //taulukon sisältö käydään indeksin avulla läpi.
        for (int i = 0; i < henkilot.Count; i++)
            Console.WriteLine(henkilot[i]);

        Console.WriteLine("-----------------");

        //Tässä poistetaan kokoelman henkilot kaikki alkiot.
        henkilot.Clear();

        Console.WriteLine("Henkilöiden lukumäärä Clear() metodin kutsun jälkeen:");

        //Tässä taas tulostetaan taulukon alkioiden lukumäärä.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);
    }
}
